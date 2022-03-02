using BasicClassLibrary;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FBXDesigns
{

    public class Shape
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        public Point Location;
        public string Name;

        public static Point GetCursorPosition()
        {
            GetCursorPos(out var lpPoint);
            return lpPoint;
        }
    }
    public class ReferenzClass : Shape
    {
        public object StartObject;
        public object EndObject;

    }


    public class UIDesignTableClass : Shape
    {
        public static bool debug = false;
        private readonly Point _absoluteOffset = new Point(0, 0);
        private GroupBox _gbTable;
        private Panel _pnlTableCenter;
        private ListView _lvTableAttributes;
        private Panel _pnlTableBottom;
        private Panel _pnlTableBottomRight;
        private Panel _pnlTableCaption;
        private TextBox _txtCaption;
        private ContextMenuStrip _cmsTable;
        private ToolStripMenuItem _tsmiMinimize;
        private ToolStripMenuItem _tsmiClose;
        private ToolStripMenuItem _tsmiMove;
        private ToolStripMenuItem _tsmiResize;
        private readonly ActionClass _action;

        public NotifiesClass TableNotify = new NotifiesClass();
        public Control PForm;
        public List<ReferenzClass> LineList = new List<ReferenzClass>();



        private void InitializeComponent()
        {
            _gbTable = new GroupBox();
            _pnlTableCenter = new Panel();
            _lvTableAttributes = new ListView();
            _pnlTableBottom = new Panel();
            _pnlTableBottomRight = new Panel();
            _pnlTableCaption = new Panel();
            _txtCaption = new TextBox();

            _cmsTable = new ContextMenuStrip();
            _tsmiMinimize = new ToolStripMenuItem();
            _tsmiClose = new ToolStripMenuItem();
            _tsmiMove = new ToolStripMenuItem();
            _tsmiResize = new ToolStripMenuItem();

            _gbTable.SuspendLayout();
            _pnlTableCenter.SuspendLayout();
            _pnlTableBottom.SuspendLayout();
            _pnlTableCaption.SuspendLayout();

            // 
            // gbTable
            // 
            _gbTable.Controls.Add(_pnlTableCenter);
            _gbTable.Controls.Add(_pnlTableBottom);
            _gbTable.Controls.Add(_pnlTableCaption);
            _gbTable.Location = new Point(56, 46);
            _gbTable.Name = "_gbTable";
            _gbTable.Size = new Size(100, 120);
            _gbTable.TabIndex = 1;
            _gbTable.TabStop = false;
            _gbTable.Text = "";
            // 
            // pnlTableCenter
            // 
            _pnlTableCenter.Controls.Add(_lvTableAttributes);
            _pnlTableCenter.Dock = DockStyle.Fill;
            _pnlTableCenter.Location = new Point(3, 38);
            _pnlTableCenter.Name = "_pnlTableCenter";
            _pnlTableCenter.Size = new Size(176, 145);
            _pnlTableCenter.TabIndex = 2;
            // 
            // lvTableAttributes
            // 
            _lvTableAttributes.BackColor = SystemColors.Info;
            _lvTableAttributes.BorderStyle = BorderStyle.None;
            _lvTableAttributes.Dock = DockStyle.Fill;
            _lvTableAttributes.GridLines = true;
            _lvTableAttributes.Location = new Point(0, 0);
            _lvTableAttributes.Name = "_lvTableAttributes";
            _lvTableAttributes.Size = new Size(176, 145);
            _lvTableAttributes.TabIndex = 0;
            _lvTableAttributes.UseCompatibleStateImageBehavior = false;
            _lvTableAttributes.View = View.Details;
            _lvTableAttributes.MouseMove += Form_MouseMove;
            _lvTableAttributes.MouseClick += PnlTableBottom_MouseClick;
            System.Windows.Forms.ColumnHeader colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colName.Text = "Attribute";
            _lvTableAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colName });



            // 
            // pnlTableBottom
            // 

            _pnlTableBottom.Dock = DockStyle.Bottom;
            _pnlTableBottom.Controls.Add(_pnlTableBottomRight);
            _pnlTableBottom.Location = new Point(3, 183);

            _pnlTableBottom.Name = "_pnlTableBottom";
            _pnlTableBottom.Size = new Size(176, 12);
            _pnlTableBottom.TabIndex = 1;
            _pnlTableBottom.MouseMove += Form_MouseMove;


            // 
            // pnlTableBottom
            // 

            _pnlTableBottomRight.Dock = DockStyle.Right;
            _pnlTableBottomRight.Location = new Point(3, 183);
            _pnlTableBottomRight.BackColor = Color.Green;

            _pnlTableBottomRight.Name = "_pnlTableBottom";
            _pnlTableBottomRight.Size = new Size(14, 12);
            _pnlTableBottomRight.TabIndex = 1;
            _pnlTableBottomRight.MouseMove += Form_MouseMove;
            _pnlTableBottomRight.MouseClick += PnlTableBottom_MouseClick;
            _pnlTableBottomRight.MouseDoubleClick += PnlTableBottom_MouseDblClick;

            // 
            // pnlTableCaption
            // 
            _pnlTableCaption.Controls.Add(_txtCaption);

            _pnlTableCaption.Dock = DockStyle.Top;
            _pnlTableCaption.Location = new Point(3, 16);
            _pnlTableCaption.Name = "_pnlTableCaption";
            _pnlTableCaption.Size = new Size(176, 22);
            _pnlTableCaption.TabIndex = 0;
            // 
            // txtCaption
            // 
            _txtCaption.ContextMenuStrip = _cmsTable;
            _txtCaption.Dock = DockStyle.Fill;
            _txtCaption.Location = new Point(0, 0);
            _txtCaption.Name = "_txtCaption";
            _txtCaption.Size = new Size(147, 20);
            _txtCaption.TabIndex = 0;
            _txtCaption.Text = @"test";
            _txtCaption.ReadOnly = true;
            _txtCaption.BorderStyle = BorderStyle.None;
            _txtCaption.BackColor = _pnlTableCaption.BackColor;
            _txtCaption.MouseMove += Form_MouseMove;

            // 
            // cmsTable
            // 
            _cmsTable.AutoSize = false;
            _cmsTable.Items.AddRange(new ToolStripItem[] {
            _tsmiMinimize,
            _tsmiClose,
            _tsmiMove,
            _tsmiResize});
            _cmsTable.Name = "_cmsTable";
            _cmsTable.Size = new Size(100, 110);
            _cmsTable.ItemClicked += cmsTable_ItemClicked;
            // 
            // tsmiMinimize
            // 
            _tsmiMinimize.Image = Properties.Resources.minus_gn16x;
            _tsmiMinimize.Name = "_tsmiMinimize";
            _tsmiMinimize.Text = @"minimize";
            _tsmiMinimize.Size = new Size(152, 22);
            // 
            // tsmiClose
            // 
            _tsmiClose.Image = Properties.Resources.cross_red_x16;
            _tsmiClose.ImageAlign = ContentAlignment.MiddleLeft;
            _tsmiClose.TextAlign = ContentAlignment.MiddleRight;
            _tsmiClose.Name = "_tsmiClose";
            _tsmiClose.Text = @"close";
            _tsmiClose.Size = new Size(152, 22);
            // 
            // tsmiMove
            // 
            _tsmiMove.Image = Properties.Resources.help_about_gn_x16;
            _tsmiMove.Name = "_tsmiMove";
            _tsmiMove.Text = @"move";
            _tsmiMove.Size = new Size(152, 22);
            // 
            // tsmiResize
            // 
            _tsmiResize.Image = Properties.Resources.help_about_blue_x16;
            _tsmiResize.Name = "_tsmiResize";
            _tsmiResize.Text = @"resize";
            _tsmiResize.Size = new Size(152, 22);
            PForm.Controls.Add(_gbTable);
            _gbTable.ResumeLayout(false);
            _pnlTableCenter.ResumeLayout(false);
            _pnlTableBottom.ResumeLayout(false);
            _pnlTableBottom.PerformLayout();
            _pnlTableCaption.ResumeLayout(false);
            _pnlTableCaption.PerformLayout();

        }

        private void PnlTableBottom_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            if (e.Button == MouseButtons.Left)
            {
                ResizeTable();
            }
            else if (e.Button == MouseButtons.Right)
            {
                PickTable();
            }
            */
            /*
            Point pt = GetCursorPosition();
            if (Action.action == eAction.OnResize)
            {
                Action.ClearLastRectangle();
                Action.DrawResizeAfterRelease(pt);                
            }            
            Action.action = eAction.None;
            */
        }

        private void PnlTableBottom_MouseDown(object sender, MouseEventArgs e)
        {
            if (_action.action != eAction.None) return;
            if (e.Button == MouseButtons.Left)
            {
                ResizeTable();
            }
            else if (e.Button == MouseButtons.Right)
            {
                PickTable();
            }
            /*
            Point pt = GetCursorPosition();
            if (Action.action == eAction.OnResize)
            {
                Action.ClearLastRectangle();
                Action.DrawResizeAfterRelease(pt);                
            }            
            Action.action = eAction.None;
            */
        }

        private void PnlTableBottom_MouseDblClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    ResizeTable();
                    break;
                case MouseButtons.Right:
                    PickTable();
                    break;
            }
        }

        private void Table_MouseMove(object sender, MouseEventArgs e)
        {
            if (_action.hotspot == sender)
            {
                switch (_action.action)
                {
                    case eAction.OnMove:
                        {
                            if (debug) Debug.WriteLine("Table_MouseMove onmove");
                            Point pt = GetCursorPosition();
                            _action.DrawMoveRectangle(pt);
                            //DrawMove(pt);
                            break;
                        }
                    case eAction.OnResize:
                        {
                            Point pt = GetCursorPosition();

                            if (debug) Debug.WriteLine("Table_MouseMove onresize");
                            _action.DrawResize(pt);
                            break;
                        }
                }
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            GetCursorPosition();
            switch (_action.action)
            {
                case eAction.OnMove:
                    _action.ClearLastRectangle();
                    //Action.DrawMove(pt);
                    _action.DrawLastMove();
                    _action.action = eAction.None;
                    if (debug) Debug.WriteLine("Form_MouseUp onmove");
                    break;
                case eAction.OnResize:
                    /*
                    Action.ClearLastRectangle();
                    Action.DrawLastResize(pt);                
                    Action.action = eAction.None;
                    */
                    if (debug) Debug.WriteLine("Form_MouseUp onresize");
                    _action.action = eAction.None;
                    break;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            ActSender = sender;           
            if (Action.action == eAction.OnMove)
            {
                Point pt = GetCursorPosition();
                Action.DrawMoveRectangle(pt);
                Debug.WriteLine("Form_MouseMove onmove");
            }
            else if (Action.action == eAction.OnResize)
            {
                Point pt = GetCursorPosition();               
                Action.tabletype = eTableType.Autosize;
                tsmiMinimize.Tag = eTableType.Autosize;
                Action.DrawResize(pt);                    
                tsmiMinimize.Image = global::SEDiagramms.Properties.Resources.minus_gn16x;
                Debug.WriteLine("Form_MouseMove onresize");
            }
            */
        }


        private void MinimizeTable(object sender)
        {
            _action.tabletype = (eTableType)_tsmiMinimize.Tag;
            _tsmiMinimize.Image = _action.tabletype == eTableType.Minimized ? Properties.Resources.quadrat_gn16x : Properties.Resources.minus_gn16x;

            _action.crtl = (Control)sender;
            _action.mainctrl = _gbTable;
            _action.parent = PForm;
            _action.DrawTable();
        }

        private void PickTable(object sender)
        {
            //Move Table     
            Debug.WriteLine("PickTable");
            TableNotify?.AddToINFO("", "ACT_TABLE", this);
            Point pt = GetCursorPosition();

            _action.crtl = (Control)sender;
            _action.mainctrl = _gbTable;
            _action.hotspot = _pnlTableBottomRight;
            _action.parent = PForm;
            _action.action = eAction.OnMove;
            _action.hotspot.BackColor = Color.Red;
            _action.DrawMoveRectangleStart(pt);
        }

        private void PickTable()
        {
            //Move Table   
            Debug.WriteLine("PickTable");
            TableNotify?.AddToINFO("", "ACT_TABLE", this);
            _pnlTableBottomRight.MouseMove += Table_MouseMove;
            Point pt = GetCursorPosition();

            _action.action = eAction.OnMove;
            _action.crtl = _pnlTableBottomRight;
            _action.mainctrl = _gbTable;
            _action.parent = PForm;
            _action.hotspot = _pnlTableBottomRight;
            _action.hotspot.BackColor = Color.Red;
            _action.DrawMoveRectangleStart(pt);
        }

        private void ResizeTable(object sender)
        {
            if (debug) Debug.WriteLine("ResizeTable");
            TableNotify?.AddToINFO("", "ACT_TABLE", this);
            Point pt = GetCursorPosition();

            _action.crtl = (Control)sender;
            _action.mainctrl = _gbTable;
            _action.parent = PForm;
            _action.hotspot = _pnlTableBottomRight;
            _action.action = eAction.OnResize;
            _action.GetAbsolutePoint();
            _action.FixLeftRectangle(_gbTable.Location);
            _action.DrawResizeRectangle(pt);
        }

        public void SetZoom(float zoom)
        {
            _action?.Zoom(zoom);
        }

        public float GetZoom()
        {
            return _action != null ? (_action.AbsolutZoom) : 1;
        }

        private void ResizeTable()
        {
            if (debug) Debug.WriteLine("ResizeTable");
            TableNotify?.AddToINFO("", "ACT_TABLE", this);
            Point pt = GetCursorPosition();

            _action.action = eAction.OnResize;
            _action.ClearLastRectangle();
            _action.DrawResizeStart(pt);
        }

        private void cmsTable_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == _tsmiMinimize)
            {
                _tsmiMinimize.Tag = (eTableType)_tsmiMinimize.Tag == eTableType.Minimized ? eTableType.Autosize : eTableType.Minimized;
                MinimizeTable(sender);
            }
            else if (e.ClickedItem == _tsmiResize)
            {
                ResizeTable();
            }
            else if (e.ClickedItem == _tsmiMove)
            {
                PickTable(sender);
            }
        }

        public void Show()
        {
            _action.Show();
        }

        public void AddAttribute(string name)
        {
            ListViewItem lvi = new ListViewItem(name);
            _lvTableAttributes.Items.Add(lvi);
        }

        public UIDesignTableClass(Control frm, string name, bool show = true, int x = 50, int y = 50)
        {
            Location = new Point(x, y);
            Name = name;
            _action = new ActionClass { parent = frm };
            _action.SetAbsoluteOffset(_absoluteOffset);

            _action.action = eAction.None;
            PForm = frm;
            PForm.MouseMove += Form_MouseMove;
            PForm.MouseUp += Form_MouseUp;

            InitializeComponent();
            _pnlTableBottomRight.MouseUp += Form_MouseUp;
            _pnlTableBottomRight.MouseMove += Table_MouseMove;
            _pnlTableBottomRight.MouseClick += PnlTableBottom_MouseClick;
            _pnlTableBottomRight.MouseDown += PnlTableBottom_MouseDown;
            _action.hotspot = _pnlTableBottomRight;
            _action.mainctrl = _gbTable;
            _tsmiMinimize.Tag = eTableType.Autosize;
            _gbTable.Left = x;
            _gbTable.Top = y;
            _gbTable.Text = "";
            _txtCaption.Text = name;

            _action.last_local_position = _gbTable.Location;
            _action.last_local_dimensions = _gbTable.Size;
            _action.DrawLastMove();

            if (show)
            {
                _action.Show();
            }
            else
            {
                _action.Hide();
            }
            _pnlTableBottom.Height = 14;
            _gbTable.Refresh();
        }

        public override string ToString()
        {
            return _txtCaption.Text;
        }

    }
}
