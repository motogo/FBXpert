using BasicClassLibrary;
using BasicForms;
using DBBasicClassLibrary;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.MiscClasses;
using FormInterfaces;
using System;
using System.Windows.Forms;
namespace SQLView
{

    partial class ExperienceInfoForm : INormalForm
    {
       
        private eColorDesigns _appDesign = eColorDesigns.Gray;
        private eColorDesigns _developDesign = eColorDesigns.Gray;

        private ExperienceInfoClass exp = null;

        private AutocompleteClass ac;

        public ExperienceInfoForm(Form mdiParent = null, eColorDesigns appDesign = eColorDesigns.Gray, eColorDesigns developDesign = eColorDesigns.Gray, bool testMode = false)
        {
            MdiParent = mdiParent;
          
            _appDesign = appDesign;
            _developDesign = developDesign;
            InitializeComponent();

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
                var sh = new ExperienceInfoClass();
                data = sh.InsertExperienceInfo(keycode,info);
                sh.ExperienceInfoRefresh(dgvExperienceInfo, txtExperienceKeyCode.Text);
                sh.SortGrid(dgvExperienceInfo, ExperienceInfoClass.SelColInx);
            }
            catch (Exception ex)
            {
               
            }
            return data;
        }

        private bool UpdateToInfo()
        {
            bool ok = false;
            try
            {
                var sh = new ExperienceInfoClass();
                ok = sh.UpdateExperienceInfo(ExData);
                sh.ExperienceInfoRefresh(dgvExperienceInfo, txtExperienceKeyCode.Text);
                sh.SortGrid(dgvExperienceInfo, ExperienceInfoClass.SelColInx);

            }
            catch (Exception ex)
            {
               
            }
            return ok;
        }

        private void SQLViewForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            
            UserStart();

            this.Text = $@"Experience Infos";

            LoadExperienceInfo($@"{Application.StartupPath}\Info\InfoExpierenceData.db");
            LanguageChanged();
            txtDatabase.Text = exp.InfoExpierenceFile;
        }

        private void LoadExperienceInfo(string dbfile)
        {
            try
            {
                exp = new ExperienceInfoClass(dbfile);
                exp.ExperienceInfoRefresh(dgvExperienceInfo,txtExperienceKeyCode.Text);
                exp.SortGrid(dgvExperienceInfo, ExperienceInfoClass.SelColInx);
                txtDatabase.Text = dbfile;
            }
            catch (Exception ex)
            {
               
            }
        }

        private void SQLViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void UserStart()
        {
            UserActionClass.Instance.UserAction = UserActionType.none;
        }
 
        private void hsClose_Click(object sender, EventArgs e)
        {
            UserActionClass.Instance.UserAction = UserActionType.none; Close();
        }
       
   
        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {
         
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

        private void ExperienceInfoForm_Enter(object sender, EventArgs e)
        {
          //  SEHotSpot.Controller.Instance().SetHookForm(this);
        }

       
        ExperienceInfo ExData = new ExperienceInfo();
        private void hotSpot5_Click(object sender, EventArgs e)
        {
            ExData = AddToInfo(txtExperienceKeyCode.Text, txtExperienceInfo.Text);
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

        private void ExperienceDataClear()
        {
            txtExperienceInfo.Text = string.Empty;
            txtExperienceKeyCode.Text = string.Empty;
        }
        private void ExperienceDataToEdit()
        {
            txtExperienceKeyCode.Text = ExData.KeyCode;
            txtExperienceInfo.Text = ExData.Info; 
        }

        private void ExperienceEditToData()
        {
            ExData.KeyCode = txtExperienceKeyCode.Text;
            ExData.Info = txtExperienceInfo.Text;
            ExData.Stamp = DateTime.Now;
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
            openFileDialog1.InitialDirectory = $@"{Application.StartupPath}\Info\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadExperienceInfo(openFileDialog1.FileName);
            }
        }
    }
}