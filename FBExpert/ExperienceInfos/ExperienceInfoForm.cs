using BasicClassLibrary;
using BasicForms;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FormInterfaces;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MessageFormLibrary;
using FBXpert;
using Initialization;

namespace SQLView
{

    partial class ExperienceInfoForm : INormalForm
    {
       
        private eColorDesigns _appDesign = eColorDesigns.Gray;
        private eColorDesigns _developDesign = eColorDesigns.Gray;
        private ExperienceInfoClass exp = null;
        private ExperienceInfoClass explocal = null;
        private AutocompleteClass ac;
        private AutocompleteClass aclocal;
        private DBRegistrationClass _dbReg = null;
        private List<TableClass> _tables;
        private ExperienceInfo ExData = new ExperienceInfo();
        private ExperienceInfo ExLocalData = new ExperienceInfo();
        private string _dbfile = string.Empty;
        private string _dblocalfile = string.Empty;

        public ExperienceInfoForm(DBRegistrationClass ca, List<TableClass> tables, Form mdiParent = null, eColorDesigns appDesign = eColorDesigns.Gray, eColorDesigns developDesign = eColorDesigns.Gray, bool testMode = false)
        {
            MdiParent = mdiParent;
          
            _appDesign = appDesign;
            _developDesign = developDesign;
            _tables  = tables;
            InitializeComponent();
            _dbReg = ca;
            ClearDevelopDesign(_developDesign);
            SetDesign(_appDesign);
;
            LanguageChanged();
            LanguageClass.Instance.RegisterChangeNotifiy(OnRaiseLanguageChangedHandler);
        }

        private void OnRaiseLanguageChangedHandler(object sender, LanguageChangedEventArgs k)
        {
            LanguageChanged();
        }

        private void LanguageChanged()
        {
           
        }

        private ExperienceInfo AddToInfo(string keycode, string info)
        {
            ExperienceInfo data = null;
            
            try
            {
                var sh = new ExperienceInfoClass(_dbfile);
                data = sh.InsertExperienceInfo(keycode,info);
                sh.ExperienceInfoRefresh(dgvExperienceInfo, txtExperienceKeyCode.Text);
                sh.SortGrid(dgvExperienceInfo, ExperienceInfoClass.SelColInx);
            }
            catch (Exception ex)
            {
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "#Add to Info", $@"#{ex.Message}", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Error);
            }
            return data;
        }

        private ExperienceInfo AddToLocalInfo(string keycode, string info)
        {
            ExperienceInfo data = null;

            try
            {
                var sh = new ExperienceInfoClass(_dblocalfile);
                data = sh.InsertExperienceInfo(keycode, info);
                sh.ExperienceInfoRefresh(dgvLocalExperienceInfo, txtLocalExperienceKeyCode.Text);
                sh.SortGrid(dgvLocalExperienceInfo, ExperienceInfoClass.SelColInx);
            }
            catch (Exception ex)
            {
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "#Add to Info", $@"#{ex.Message}", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Error);
            }
            return data;
        }

        private bool UpdateToInfo()
        {
            bool ok = false;
            try
            {
                var sh = new ExperienceInfoClass(_dbfile);
                ok = sh.UpdateExperienceInfo(ExData);
                sh.ExperienceInfoRefresh(dgvExperienceInfo, txtExperienceKeyCode.Text);
                sh.SortGrid(dgvExperienceInfo, ExperienceInfoClass.SelColInx);
            }
            catch (Exception ex)
            {
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "#Update Info", $@"#{ex.Message}", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Error);
            }
            return ok;
        }

        private bool UpdateToLocalInfo()
        {
            bool ok = false;
            try
            {
                var sh = new ExperienceInfoClass(_dblocalfile);
                ok = sh.UpdateExperienceInfo(ExLocalData);
                sh.ExperienceInfoRefresh(dgvLocalExperienceInfo, txtLocalExperienceKeyCode.Text);
                sh.SortGrid(dgvLocalExperienceInfo, ExperienceInfoClass.SelColInx);
            }
            catch (Exception ex)
            {
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "#Update Info", $@"#{ex.Message}", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Error);
            }
            return ok;
        }

        private void ExperienceInfoForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            
            UserStart();

            this.Text = $@"Experience Infos";
            
            LoadExperienceInfo( $@"{AppSettingsClass.Instance.PathSettings.InfoPath}\{StaticVariablesClass.ExperienceInfoFile}");
            LoadLocalExperienceInfo($@"{AppSettingsClass.Instance.PathSettings.InfoPath}\{_dbReg.AliasAsFileName}_{StaticVariablesClass.ExperienceInfoFile}");
            LanguageChanged();

            SetAutocompeteObjects(_tables);
            SetLocalAutocompeteObjects(_tables);
        }

        private void LoadExperienceInfo(string dbfile)
        {
            try
            {
                _dbfile = dbfile;
                exp = new ExperienceInfoClass(dbfile);
                exp.ExperienceInfoRefresh(dgvExperienceInfo,txtExperienceKeyCode.Text);
                exp.SortGrid(dgvExperienceInfo, ExperienceInfoClass.SelColInx);
                txtDatabase.Text = _dbfile;
            }
            catch (Exception ex)
            {
               
            }
        }

        private void LoadLocalExperienceInfo(string dbfile)
        {
            try
            {
                _dblocalfile = dbfile;
                explocal = new ExperienceInfoClass(_dblocalfile);
                explocal.ExperienceInfoRefresh(dgvLocalExperienceInfo, txtLocalExperienceKeyCode.Text);
                explocal.SortGrid(dgvLocalExperienceInfo, ExperienceInfoClass.SelColInx);
                txtLocalDatabase.Text = _dblocalfile;
            }
            catch (Exception ex)
            {

            }
        }

        private void ExperienceInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void UserStart()
        {
            UserActionClass.Instance.UserAction = UserActionType.none;
        }

        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(fctExperienceInfo, _dbReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);
            ac.Activate();
        }

        public void SetLocalAutocompeteObjects(List<TableClass> tables)
        {
            aclocal = new AutocompleteClass(fctLocalExperienceInfo, _dbReg);
            aclocal.CreateAutocompleteForDatabase();
            aclocal.AddAutocompleteForSQL();
            aclocal.AddAutocompleteForTables(tables);
            aclocal.Activate();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            UserActionClass.Instance.UserAction = UserActionType.none; Close();
        }
       
        private void RefreshExperienceInfo()
        {
            try
            {
               exp.ExperienceInfoRefresh(dgvExperienceInfo,txtExperienceKeyCode.Text);
               exp.SortGrid(dgvExperienceInfo, ExperienceInfoClass.SelColInx);
            }
            catch (Exception ex)
            {
               
            }
        }

        private void RefreshLocalExperienceInfo()
        {
            try
            {
                explocal.ExperienceInfoRefresh(dgvLocalExperienceInfo, txtLocalExperienceKeyCode.Text);
                explocal.SortGrid(dgvLocalExperienceInfo, ExperienceInfoClass.SelColInx);
            }
            catch (Exception ex)
            {

            }
        }

        private void ExperienceInfoForm_Enter(object sender, EventArgs e)
        {
          //  SEHotSpot.Controller.Instance().SetHookForm(this);
        }

        private void hsInserExperienceInfo_Click(object sender, EventArgs e)
        {
            ExData = AddToInfo(txtExperienceKeyCode.Text,fctExperienceInfo.Text);       
        }

        private void hsRefreshExpierenceInfo_Click(object sender, EventArgs e)
        {
            RefreshExperienceInfo();
        }

        private void dgvExperienceInfo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            exp.SwapSortGrid(grid, e.ColumnIndex);
            ExperienceInfoClass.SelColInx = e.ColumnIndex;
        }

        private void hsClearExperienceInfoFields_Click(object sender, EventArgs e)
        {
            ExperienceDataClear();
        }

        private void ExperienceCellsToData()
        {
            var row = dgvExperienceInfo.SelectedRows[0];
            ExData.Id = (int)row.Cells[(int)ExperienceInfoInx.Id].Value;
            ExData.Info = row.Cells[(int)ExperienceInfoInx.Info].Value.ToString();
            ExData.KeyCode = row.Cells[(int)ExperienceInfoInx.KeyCode].Value.ToString();
            ExData.IsActive = (bool)row.Cells[(int)ExperienceInfoInx.IsActive].Value;
            ExData.Stamp = (DateTime)row.Cells[(int)ExperienceInfoInx.Stamp].Value;
        }
        private void LocalExperienceCellsToData()
        {
            var row = dgvLocalExperienceInfo.SelectedRows[0];
            ExLocalData.Id = (int)row.Cells[(int)ExperienceInfoInx.Id].Value;
            ExLocalData.Info = row.Cells[(int)ExperienceInfoInx.Info].Value.ToString();
            ExLocalData.KeyCode = row.Cells[(int)ExperienceInfoInx.KeyCode].Value.ToString();
            ExLocalData.IsActive = (bool)row.Cells[(int)ExperienceInfoInx.IsActive].Value;
            ExLocalData.Stamp = (DateTime)row.Cells[(int)ExperienceInfoInx.Stamp].Value;
        }

        private void ExperienceDataClear()
        {
            fctExperienceInfo.Text = string.Empty;
            txtExperienceKeyCode.Text = string.Empty;
        }
        private void LocalExperienceDataClear()
        {
            fctLocalExperienceInfo.Text = string.Empty;
            txtLocalExperienceKeyCode.Text = string.Empty;
        }
        private void ExperienceDataToEdit()
        {
            txtExperienceKeyCode.Text = ExData.KeyCode;
            fctExperienceInfo.Text = ExData.Info; 
        }
        private void LocalExperienceDataToEdit()
        {
            txtLocalExperienceKeyCode.Text = ExLocalData.KeyCode;
            fctLocalExperienceInfo.Text = ExLocalData.Info;
        }

        private void ExperienceEditToData()
        {
            ExData.KeyCode = txtExperienceKeyCode.Text;
            ExData.Info = fctExperienceInfo.Text;
            ExData.Stamp = DateTime.Now;
        }
        private void LocalExperienceEditToData()
        {
            ExLocalData.KeyCode = txtLocalExperienceKeyCode.Text;
            ExLocalData.Info = fctLocalExperienceInfo.Text;
            ExLocalData.Stamp = DateTime.Now;
        }

        private void dgvExperienceInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView grid = sender as DataGridView;
            if (grid.SelectedRows.Count > 0)
            {
                ExperienceCellsToData();
                ExperienceDataToEdit();
            }
        }

        private void hsDeleteExpierenceInfo_Click(object sender, EventArgs e)
        {
            int n = 0;
            foreach (DataGridViewRow dr in dgvExperienceInfo.SelectedRows)
            {
                if (exp.DeleteExperienceInfoEntry((int)dr.Cells[0].Value)) n++;
            }
            if (n > 0)
            {
                try
                {
                   exp.ExperienceInfoRefresh(dgvExperienceInfo,txtExperienceKeyCode.Text);
                   exp.SortGrid(dgvExperienceInfo, ExperienceInfoClass.SelColInx);
                }
                catch (Exception ex)
                {
                    SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "#Delete Info", $@"#{ex.Message}", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Error);
                }
            }
        }

        private void cmdExperienceInfo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiDeleteExperienceInfo)
            {
                int n = 0;
                foreach (DataGridViewRow dr in  dgvExperienceInfo.SelectedRows)
                {
                    if (exp.DeleteExperienceInfoEntry((int)dr.Cells[0].Value)) n++;
                }
                if (n > 0)
                {
                    try
                    {
                        exp.ExperienceInfoRefresh(dgvExperienceInfo,txtExperienceKeyCode.Text);
                        exp.SortGrid(dgvExperienceInfo, ExperienceInfoClass.SelColInx);
                    }
                    catch (Exception ex)
                    {
                      
                    }
                }
            }
        }

        private void hsUpdateExperienceInfo_Click(object sender, EventArgs e)
        {
            ExperienceEditToData();
            UpdateToInfo();
        }
       
        private void hsLoadDatabasePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = $@"{ApplicationPathClass.Instance.ApplicationPath}\Info\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                LoadExperienceInfo(openFileDialog1.FileName);
            }
        }

        private void txtExperienceInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                if (ac != null) ac.Show();
                e.Handled = true;
            }
        }

        private void hsLoadLocalDatabasePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = $@"{ApplicationPathClass.Instance.ApplicationPath}\Info\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadLocalExperienceInfo(openFileDialog1.FileName);
            }
        }

        private void hsUpdateLocalExperienceInfo_Click(object sender, EventArgs e)
        {
            LocalExperienceEditToData();
            UpdateToLocalInfo();
        }

        private void hsDeleteLocalData_Click(object sender, EventArgs e)
        {
            int n = 0;
            foreach (DataGridViewRow dr in dgvLocalExperienceInfo.SelectedRows)
            {
                if (explocal.DeleteExperienceInfoEntry((int)dr.Cells[0].Value)) n++;
            }
            if (n > 0)
            {
                try
                {
                    explocal.ExperienceInfoRefresh(dgvLocalExperienceInfo, txtLocalExperienceKeyCode.Text);
                    explocal.SortGrid(dgvLocalExperienceInfo, ExperienceInfoClass.SelColInx);
                }
                catch (Exception ex)
                {
                    SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "#Delete Info", $@"#{ex.Message}", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Error);
                }
            }
        }

        private void hsRefreshLocalExperienceInfo_Click(object sender, EventArgs e)
        {
            RefreshLocalExperienceInfo();
        }

        private void hsClearLocalExperienceInfo_Click(object sender, EventArgs e)
        {
            LocalExperienceDataClear();
        }

        private void hsInsertLoaclExperienceInfo_Click(object sender, EventArgs e)
        {
            ExLocalData = AddToLocalInfo(txtLocalExperienceKeyCode.Text, fctLocalExperienceInfo.Text);
        }

        private void dgvLocalExperienceInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView grid = sender as DataGridView;
            if (grid.SelectedRows.Count > 0)
            {
                LocalExperienceCellsToData();
                LocalExperienceDataToEdit();
            }
        }

        private void fctLocalExperienceInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                if (aclocal != null) aclocal.Show();
                e.Handled = true;
            }
        }
    }
}