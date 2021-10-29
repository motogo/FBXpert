using BasicClassLibrary;
using ExtendedXmlSerializer.Configuration;
using ExtendedXmlSerializer.ExtensionModel.Xml;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using Initialization;
using MessageLibrary.SendMessages;
using Polenter.Serialization;
using SEListBox;
using SharedStorages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace FBXDesigns
{


    public partial class DatabaseDesignForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);


        private static readonly Lazy<DatabaseDesignForm> lazy = new Lazy<DatabaseDesignForm>(() => new DatabaseDesignForm());
        public static DatabaseDesignForm Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public DatabaseDesignForm()
        {
            InitializeComponent();
            xmlEditDefinition.LoadClick += XmlEditSimpleUserControl1_LoadClick;   
        }

        public void SetParent(Form par)
        {
            this.MdiParent = par;
        }


        [Serializable]
        class MerkeWerte
        {           
            public string XmlDataFileName;          
        };

        private MerkeWerte _mw = new MerkeWerte();
        private readonly SharedStorage _ss = new SharedStorage();

        private void LoadUserDesign()
        {
            _ss.SharedFolder = ApplicationPathClass.Instance.GetFullPath(Application.UserAppDataPath);
            _ss.StorageName = Name;
            _ss.DestroyWhenDisposed = false;
            try
            {
                var mw2 = (MerkeWerte)_ss[Name];
                if (mw2 == null) return;
                _mw = mw2;
                xmlEditDefinition.originalXmlFile = _mw.XmlDataFileName;
                xmlEditDefinition.LoadXmlFromFile(_mw.XmlDataFileName);
               
            }
            catch (Exception ex)
            {                                                                                                              
                SendMessageClass.Instance.SendAllErrors(Name + " -> LoadUserDesign() ->" + ex.Message);
            }
        }

        private void SaveUserDesign()
        {
            if ((_mw != null) && (_ss != null))
            {                
                _mw.XmlDataFileName = xmlEditDefinition.originalXmlFile;                               
                _ss.SharedFolder = ApplicationPathClass.Instance.GetFullPath(Application.UserAppDataPath);
                _ss.StorageName = Name;
                _ss.AddOrUpdate(Name, _mw);                
            }
        }

        public void SetDatas(DBRegistrationClass dbReg, Dictionary<string, TableClass> Tables, Dictionary<string, ViewClass> Views)
        {
            ddc = new DesDatabaseDesignClass
            {
                Database = dbReg,
                Views = new Dictionary<string, DesViewClass>(),
                Tables = new Dictionary<string, DesTableClass>()
            };

            int posx = 10;
            int posy = 10;


            foreach (ViewClass view in Views.Values)
            {
                DesViewClass dvc = new DesViewClass
                {
                    View = view,
                    Design = new ObjectDesignClass(posx, posy)
                };

                posx += 100;
                posy += 20;
                ddc.Views.Add(view.Name, dvc);
            }

            posx = 10;
            posy = 100;
            foreach (TableClass table in Tables.Values)
            {
                DesTableClass dvc = new DesTableClass
                {
                    Table = table,
                    Design = new ObjectDesignClass(posx, posy)
                };

                posx += 100;
                posy += 20;
                ddc.Tables.Add(table.Name, dvc);
            }
            
            CreateDBDesign(0);
            CreateDBObjects(0);
            
        }
        private void CreateDBDesign(int lvl)
        {
            /*
            int x = 10;
            int y = 10;
            foreach (var tc in ddc.Tables.Values)
            {
                tc.Design = new ObjectDesignClass();
                tc.Design.posx = x;
                tc.Design.posy = y;
                x += 50;
            }
            x = 10;
            y = 100;
            foreach (var tc in ddc.Views.Values)
            {
                tc.Design = new ObjectDesignClass();
                tc.Design.posx = x;
                tc.Design.posy = y;
                x += 50;
            }
            */
        }
        DesDatabaseDesignClass ddc = null;
        private void CreateDBObjects(int lvl)
        {
            if (ddc == null) return;
            selDBObjects.ClearItems();

            foreach (var tc in ddc.Tables.Values)
            {
                foreach(var fld in tc.Table.Fields)
                {
                    if (fld.Value.Domain.RawType.Length > 0) continue;
                    
                }
            }

            foreach (var tc in ddc.Views.Values)
            {
                foreach (var fld in tc.View.Fields.Values)
                {
                    if (fld.Domain.RawType.Length > 0) continue;
                    
                }
            }

            foreach (var tc in ddc.Tables.Values)
            {
               // CodeFactory.Instance().CreateDesignForTable(lvl,tc);
                selDBObjects.Add(tc.Table.Name, CheckState.Checked, tc);
            }

            foreach (var tc in ddc.Views.Values)
            {
               // CodeFactory.Instance().CreateDesignForTable(lvl,tc);
                selDBObjects.Add(tc.View.Name, CheckState.Checked, tc);
            }

            foreach (var tc in ddc.Tables.Values)
            {
              //  CodeFactory.Instance().CreateDesignForCbTable(lvl,tc);
                selDBObjects.Add("Cb" + tc.Table.Name, CheckState.Checked, tc);
            }

            foreach (var tc in ddc.Views.Values)
            {
              //  CodeFactory.Instance().CreateDesignForCbTable(lvl,tc);
                selDBObjects.Add("Cb"+tc.View.Name, CheckState.Checked, tc);
            }
            if(selDBObjects.ItemDatas.Count > 0)
            selDBObjects.SelectedIndex = 0;            
        }
        private void CreateDBObjectsFromXML(int lvl)
        {
            // var serializer = new SharpSerializer();


            //  var serializer = new XmlSerializer(typeof(DatabaseDesignClass));
            if (File.Exists(xmlEditDefinition.originalXmlFile))
            {
                var fs = new FileStream(xmlEditDefinition.originalXmlFile, FileMode.Open);
                var serializer = new ConfigurationContainer().Create();

                var ddc = (DatabaseDesignClass)serializer.Deserialize<DatabaseDesignClass>(fs);

                //DatabaseDesignClass ddc = (DatabaseDesignClass) serializer.Deserialize(XmlReader.Create(fs));
                //var ddc = (DatabaseDesignClass)serializer.Deserialize(fs);
                fs.Close();

                selDBObjects.ClearItems();

                foreach (var tc in ddc.Tables.Values)
                {
                    foreach (var fld in tc.Fields)
                    {
                        if (fld.Value.Domain.RawType.Length > 0) continue;
                        
                    }
                }

                foreach (var tc in ddc.Views.Values)
                {
                    foreach (var fld in tc.Fields.Values)
                    {
                        if (fld.Domain.RawType.Length > 0) continue;
                        
                    }
                }

                foreach (var tc in ddc.Tables.Values)
                {
                    // CodeFactory.Instance().CreateDesignForTable(lvl,tc);
                    selDBObjects.Add(tc.Name, CheckState.Checked, tc);
                }

                foreach (var tc in ddc.Views.Values)
                {
                    // CodeFactory.Instance().CreateDesignForTable(lvl,tc);
                    selDBObjects.Add(tc.Name, CheckState.Checked, tc);
                }

                foreach (var tc in ddc.Tables.Values)
                {
                    //  CodeFactory.Instance().CreateDesignForCbTable(lvl,tc);
                    selDBObjects.Add("Cb" + tc.Name, CheckState.Checked, tc);
                }

                foreach (var tc in ddc.Views.Values)
                {
                    //  CodeFactory.Instance().CreateDesignForCbTable(lvl,tc);
                    selDBObjects.Add("Cb" + tc.Name, CheckState.Checked, tc);
                }
                if (selDBObjects.ItemDatas.Count > 0)
                    selDBObjects.SelectedIndex = 0;
            }
        }
        private void ShowAllObjects()
        {
            foreach(var ob in ObjectList)
            {
                foreach(var ln in ob.LineList)
                {
                    UIDesignTableClass ob_s = (UIDesignTableClass)ln.StartObject;
                    UIDesignTableClass ob_e = (UIDesignTableClass)ln.EndObject;
                    Graphics g;

                    g = pbDesign.CreateGraphics();

                    using (Pen myPen = new Pen(Color.Red))
                    {
                        myPen.Width = 4;
                        myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        myPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        g.DrawLine(myPen, ob_s.Location.X, ob_s.Location.Y, ob_e.Location.X, ob_e.Location.Y);
                    }

                }
            }
        }

        private void CreateDesignObjects()
        {
            ObjectList.Clear();

            // string[] ln = File.ReadAllLines(fn);

            UIDesignTableClass tc;
            int x = 20;
            int y = 20;
            
            //foreach (string s in ln)
            int n = 0;
            //object ob1=null;
            //object ob2=null;
            foreach (ItemDataClass s in selDBObjects.CheckedItemDatas)
            {
                if(s.Object.GetType() == typeof(DesTableClass))
                {
                    //  string n = s.Substring(s.IndexOf("'")+1, s.LastIndexOf("'") - s.IndexOf("'") -1);
                    DesTableClass TableObject = (DesTableClass) s.Object;
                    n++;
                    

                    tc = new UIDesignTableClass(pbDesign,s.Object.ToString(),true, TableObject.Design.posx,TableObject.Design.posy);

                    tc.TableNotify.Register4Info(Notify_OnRaiseInfoHandler1);
                    x += 160;
                    //y += 0;
                    if(x > 1000)
                    {
                        x = 20;
                        y += 180;
                    }
                    var tob = (DesTableClass) s.Object;
                    foreach(var att in tob.Table.Fields.Values)                        
                    {                        
                        tc.AddAttribute(att.Name);
                    }
                    //if(n == 1) ob1 = tc;
                    //if(n == 2) ob2 = tc;

                    ObjectList.Add(tc);
                }
                
                /*
                else if (s.ToUpper().StartsWith("VIEW"))
                {

                }
                else if (s.ToUpper().StartsWith("FIELD"))
                {

                }
                */
            }

            foreach (ItemDataClass s in selDBObjects.CheckedItemDatas)
            {
                if(s.Object.GetType() == typeof(DesTableClass))
                {
                    DesTableClass tb1 = (DesTableClass) s.Object;
                    foreach(var fld in tb1.Table.Fields)
                    {
                        if(fld.Key.EndsWith("_ID"))
                        {
                            UIDesignTableClass ob1 = (UIDesignTableClass) FindObject(tb1.Table.Name);
                            UIDesignTableClass ob2 = (UIDesignTableClass) FindObject(fld.Key.Remove(fld.Key.Length-3));
                            if((ob1 != null)&&(ob2!=null))
                            {
                                ReferenzClass rc = new ReferenzClass
                                {
                                    Name = fld.Key,
                                    StartObject = ob1,
                                    EndObject = ob2
                                };
                                ob1.LineList.Add(rc);
                            }
                        }
                    }
                }
            }


            
        }

        private void Notify_OnRaiseInfoHandler1(object sender, MessageEventArgs k)
        {
            ActTable = k.Data as UIDesignTableClass;
        }

        private object FindObject(string tn)
        {
            return ObjectList.Find(x=>x.Name == tn);
        }

        private void XmlEditSimpleUserControl1_LoadClick(string fileName)
        {
            //string fn = xmlEditDefinition.originalXmlFile;
            CreateDBDesign(0);
            CreateDBObjects(0);
            CreateDesignObjects();
            ShowAllObjects();
            /*
            DataSet ds = new DataSet();
            ds.ReadXml(fn);
            */



        }
        

        float zoom = 1;

        public void SetZoom(float z)
        {
            zoom = z;
            if(ActTable != null)
            {
                ActTable.SetZoom(z);                
            }
        }
        
        public void FormLoadAgain()
        {

        }
      
        private void hsNewtable_Click(object sender, EventArgs e)
        {
            
        }


        private List<UIDesignTableClass> ObjectList = new List<UIDesignTableClass>();
        private List<ReferenzClass> LineList = new List<ReferenzClass>();


        private UIDesignTableClass ActTable = null;
        /*
        public DrawLine(int i)
        {                    
                    Graphics g;

                    g = pbDesign.CreateGraphics();

                    Pen myPen = new Pen(Color.Red);
                    myPen.Width = 4;
                    myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    myPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    g.DrawLine(myPen, ob_s.Location.X, ob_s.Location.Y,ob_e.Location.X, ob_e.Location.Y);
        }
        */
        private void hotSpot1_Click(object sender, EventArgs e)
        {
            ActionClass.Instance().Clear();

            Point absoff = new Point
            {
                X = 0,
                Y = 32  // Location plus Fenstertitelrand
            };


            UIDesignTableClass tc = new UIDesignTableClass(pbDesign,"test");
            ActTable = tc;

        }

        private void DesignerForm_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void hsZoomCanvasPlus_Click(object sender, EventArgs e)
        {
            pbDesign.Width *= 2;
            pbDesign.Height *= 2;
        }

        private void hsZoomDesingMinus_Click(object sender, EventArgs e)
        {
            pbDesign.Width /= 2;
            pbDesign.Height /= 2;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_ClientSizeChanged(object sender, EventArgs e)
        {
            if(pbDesign.Left < tabStruktur.Left)
            {
                pbDesign.Left = tabStruktur.Left;                
            }

            if (pbDesign.Height < tabStruktur.Left)
            {
                pbDesign.Height = tabXMLDefinition.Height;
            }
        }

        private void DesignerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUserDesign();
            //instance = null;
        }

       

        private void hsZoomPlus_Click(object sender, EventArgs e)
        {
            float zm = 01;
            foreach (UIDesignTableClass tc in ObjectList)
            {
                tc.SetZoom(2f);
            }
            txtObjectZoom.Text = zm.ToString();
        }

        private void hsZoomMinus_Click(object sender, EventArgs e)
        {

            float zm = 01;
            foreach (UIDesignTableClass tc in ObjectList)
            {
                tc.SetZoom(0.5f);
                zm = tc.GetZoom();
            }

            txtObjectZoom.Text = zm.ToString(CultureInfo.InvariantCulture);
        }

        private void xmlEditDefinition_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
        }

        private void pnlDBObjectsCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DesignerForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            CreateDesignObjects();
            ShowAllObjects();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hsRefreshStruktur_Click(object sender, EventArgs e)
        {
            pbDesign.Refresh();
            CreateDesignObjects();
            ShowAllObjects();
        }

        private void CbDebug_CheckedChanged(object sender, EventArgs e)
        {
            UIDesignTableClass.debug = cbDebug.Checked;
        }



        public void SerializeCurrent()
        {
            int lvl = 1;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.CloseOutput = false;

            using (XmlWriter writer = XmlWriter.Create($@"D:\temp\db.xml",settings))
            {
                //writer.WriteStartDocument(true);
                //writer.WriteComment(Environment.NewLine);
                writer.WriteString(Environment.NewLine);
                writer.WriteStartElement(ddc.Database.Alias);
                writer.WriteString(Environment.NewLine);
                writer.WriteString(AppStrings.FormatTab(lvl)); writer.WriteStartElement("Tables");
                
                foreach (DesTableClass key in ddc.Tables.Values)
                {
                    writer.WriteString(Environment.NewLine);
                    writer.WriteString(AppStrings.FormatTab(lvl + 1)); writer.WriteStartElement("Table");
                    writer.WriteAttributeString("Name", key.Table.Name.ToString());
                    writer.WriteString(Environment.NewLine);
                    writer.WriteString(AppStrings.FormatTab(lvl + 2)); writer.WriteStartElement("Fields");
                    foreach (TableFieldClass fld in key.Table.Fields.Values)
                    {
                        writer.WriteString(Environment.NewLine);
                        writer.WriteString(AppStrings.FormatTab(lvl + 3)); writer.WriteStartElement("Field");
                        writer.WriteString(Environment.NewLine);
                        writer.WriteString(AppStrings.FormatTab(lvl + 4)); writer.WriteElementString("Name", fld.Name);
                        writer.WriteString(Environment.NewLine);
                        writer.WriteString(AppStrings.FormatTab(lvl + 4)); writer.WriteElementString("Type", TypeConvert.GetRawType(fld.Domain.FieldType,fld.Domain.Length));
                        writer.WriteString(Environment.NewLine);
                        if (key.Table.IsPrimary(fld.Name))
                        {
                            writer.WriteString(AppStrings.FormatTab(lvl + 4)); writer.WriteElementString("PK", key.Table.primary_constraint.Name);
                            writer.WriteString(Environment.NewLine);
                        }
                        writer.WriteString(AppStrings.FormatTab(lvl + 3)); writer.WriteEndElement(); //Field
                    }
                    writer.WriteString(Environment.NewLine);
                    writer.WriteString(AppStrings.FormatTab(lvl + 2)); writer.WriteEndElement(); //Fields
                    writer.WriteString(Environment.NewLine);
                    writer.WriteString(AppStrings.FormatTab(lvl + 1)); writer.WriteEndElement(); //Table
                }
                writer.WriteString(Environment.NewLine);
                writer.WriteString(AppStrings.FormatTab(lvl)); writer.WriteEndElement(); //Tables
                writer.WriteString(Environment.NewLine);
                writer.WriteEndElement(); //Root
                //writer.WriteEndDocument();
            }

        }

        private void hsSaveDesign_Click(object sender, EventArgs e)
        {
            SerializeCurrent();
        }
    }
}
