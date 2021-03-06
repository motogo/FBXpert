﻿using ExtendedXmlSerializer.Configuration;
using ExtendedXmlSerializer.ExtensionModel.Xml;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using Initialization;
using MessageLibrary;
using MessageLibrary.SendMessages;
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

        NotifiesClass _localNotifies;
        private static readonly object _lockThis = new object();
        private static volatile DatabaseDesignForm instance = null;
        public static DatabaseDesignForm Instance()
        {
            if (instance == null)
            {
                lock (_lockThis)
                {
                    instance = new DatabaseDesignForm();
                }
            }
            else
            {
                instance.FormLoadAgain();
            }
            return (instance);
        }

        public void SetNotifies(NotifiesClass notifies)
        {
            _localNotifies = notifies;
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
            _ss.SharedFolder = ApplicationPathClass.GetFullPath(Application.UserAppDataPath);
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
                SendMessageClass.Instance().SendAllErrors(Name + " -> LoadUserDesign() ->" + ex.Message);
            }
        }

        private void SaveUserDesign()
        {
            if ((_mw != null) && (_ss != null))
            {                
                _mw.XmlDataFileName = xmlEditDefinition.originalXmlFile;                               
                _ss.SharedFolder = ApplicationPathClass.GetFullPath(Application.UserAppDataPath);
                _ss.StorageName = Name;
                _ss.AddOrUpdate(Name, _mw);                
            }
        }

        private void CreateDBObjects(int lvl)
        {       
           // var serializer = new SharpSerializer();


          //  var serializer = new XmlSerializer(typeof(DatabaseDesignClass));
            if(File.Exists(xmlEditDefinition.originalXmlFile))
            {
                var fs = new FileStream(xmlEditDefinition.originalXmlFile, FileMode.Open);
                var serializer = new ConfigurationContainer().Create();
                            
                var ddc = (DatabaseDesignClass) serializer.Deserialize<DatabaseDesignClass>(fs);
               
                //DatabaseDesignClass ddc = (DatabaseDesignClass) serializer.Deserialize(XmlReader.Create(fs));
                //var ddc = (DatabaseDesignClass)serializer.Deserialize(fs);
                fs.Close();
          
                selDBObjects.ClearItems();

                foreach (var tc in ddc.Tables.Values)
                {
                    foreach(var fld in tc.Fields)
                    {
                        if (fld.Value.Domain.RawType.Length > 0) continue;
                        Console.WriteLine();
                    }
                }

                foreach (var tc in ddc.Views.Values)
                {
                    foreach (var fld in tc.Fields.Values)
                    {
                        if (fld.Domain.RawType.Length > 0) continue;
                        Console.WriteLine();
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
                    selDBObjects.Add("Cb"+tc.Name, CheckState.Checked, tc);
                }
                if(selDBObjects.ItemDatas.Count > 0)
                selDBObjects.SelectedIndex = 0;
            }
        }

        private void ShowAllObjects()
        {
            foreach(var ob in ObjectList)
            {
                foreach(var ln in ob.LineList)
                {
                    DesignTableClass ob_s = (DesignTableClass) ln.StartObject;
                    DesignTableClass ob_e = (DesignTableClass) ln.EndObject;
                    Graphics g;

                    g = pbDesign.CreateGraphics();

                    Pen myPen = new Pen(Color.Red);
                    myPen.Width = 4;
                    myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    myPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    g.DrawLine(myPen, ob_s.Location.X, ob_s.Location.Y,ob_e.Location.X, ob_e.Location.Y);

                }
            }
        }

        private void CreateDesignObjects()
        {
            ObjectList.Clear();

            // string[] ln = File.ReadAllLines(fn);

            DesignTableClass tc;
            int x = 20;
            int y = 20;
            
            //foreach (string s in ln)
            int n = 0;
            //object ob1=null;
            //object ob2=null;
            foreach (ItemDataClass s in selDBObjects.CheckedItemDatas)
            {
                if(s.Object.GetType() == typeof(TableClass))
                {
                    //  string n = s.Substring(s.IndexOf("'")+1, s.LastIndexOf("'") - s.IndexOf("'") -1);
                    n++;
                    tc = new DesignTableClass(pbDesign,s.Object.ToString(),true,x,y);
                    
                    tc.TableNotify.Notify.OnRaiseInfoHandler += Notify_OnRaiseInfoHandler; 
                    x += 160;
                    //y += 0;
                    if(x > 1000)
                    {
                        x = 20;
                        y += 180;
                    }
                    var tob = (TableClass) s.Object;
                    foreach(var att in tob.Fields.Values)                        
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
                if(s.Object.GetType() == typeof(TableClass))
                {
                    TableClass tb1 = (TableClass) s.Object;
                    foreach(var fld in tb1.Fields)
                    {
                        if(fld.Key.EndsWith("_ID"))
                        {
                            DesignTableClass ob1 = (DesignTableClass) FindObject(tb1.Name);
                            DesignTableClass ob2 = (DesignTableClass) FindObject(fld.Key.Remove(fld.Key.Length-3));
                            if((ob1 != null)&&(ob2!=null))
                            {
                                ReferenzClass rc = new ReferenzClass();
                                rc.Name = fld.Key;
                                rc.StartObject = ob1;
                                rc.EndObject = ob2;
                                ob1.LineList.Add(rc);
                            }
                        }
                    }
                }
            }


            
        }

        private object FindObject(string tn)
        {
            return ObjectList.Find(x=>x.Name == tn);
        }

        private void XmlEditSimpleUserControl1_LoadClick(string fileName)
        {
            string fn = xmlEditDefinition.originalXmlFile;

            CreateDBObjects(0);
            CreateDesignObjects();
            ShowAllObjects();
            /*
            DataSet ds = new DataSet();
            ds.ReadXml(fn);
            */



        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageLibrary.MessageEventArgs k)
        {
            ActTable = k.Data as DesignTableClass;
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


        List<DesignTableClass> ObjectList = new List<DesignTableClass>();
        List<ReferenzClass> LineList = new List<ReferenzClass>();


        DesignTableClass ActTable = null;
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

           
            int offsetx = this.Left;
            int offsety = this.Top;

            Point absoff = new Point();
            absoff.X = 0;
            absoff.Y = 32;  // Location plus Fenstertitelrand


            DesignTableClass tc = new DesignTableClass(pbDesign,"test");
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
            instance = null;
        }

       

        private void hsZoomPlus_Click(object sender, EventArgs e)
        {
            float zm = 01;
            foreach (DesignTableClass tc in ObjectList)
            {
                tc.SetZoom(2f);
            }
            txtObjectZoom.Text = zm.ToString();
        }

        private void hsZoomMinus_Click(object sender, EventArgs e)
        {

            float zm = 01;
            foreach (DesignTableClass tc in ObjectList)
            {
                tc.SetZoom(0.5f);
                zm = tc.GetZoom();
            }

            txtObjectZoom.Text = zm.ToString(CultureInfo.InvariantCulture);
        }

        private void xmlEditDefinition_Load(object sender, EventArgs e)
        {

        }

        private void pnlDBObjectsCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DesignerForm_Load(object sender, EventArgs e)
        {
            LoadUserDesign();
            CreateDBObjects(0);
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
    }
}
