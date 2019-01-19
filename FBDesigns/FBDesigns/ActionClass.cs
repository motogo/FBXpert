using System.Drawing;
using System.Windows.Forms;

namespace FBXDesigns
{

    public enum eAction {None=0, OnResize = 1, OnMove = 2  };
    public enum eTableType {Autosize = 0, Minimized = 1, Maximized= 2 };
    public class ActionClass
    {
        public Control crtl;
        public Control mainctrl;
        public Control hotspot;
        public eAction action;
        public Control parent = null;
        public eTableType tabletype = eTableType.Autosize;

        public Point absolute_offset = new Point();

        public float zoom = 1.0f;


        private static readonly object _lock_this = new object();
        private static volatile ActionClass instance = null;
      
        public static ActionClass Instance()
        {
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new ActionClass();
                }
            }
            return (instance);
        }


        public ActionClass()
        {

        }

        public void SetAbsoluteOffset(Point abs_off)
        {
            absolute_offset = abs_off;
        }

        public void Clear()
        {
            action = eAction.None;
            crtl = null;
            mainctrl = null;            
            parent = null;
            hotspot = null;
       }

        public void Show()
        {
            mainctrl.BringToFront();
            mainctrl.Visible = true;
        }

        public void Hide()
        {
            mainctrl.Visible = false;
        }
               
        public Size last_local_dimensions = new Size(0, 0);
        
        public void DrawMoveRectangle(Point pt)
        {
            DrawMoveRectangle(pt, new Point(0, 0));                     
        }

        Point pth;

        public void DrawMoveRectangleStart(Point pt)
        {
            pth = hotspot.PointToClient(pt);
            DrawMoveRectangle(pt, new Point(0, 0));
        }

        public void DrawMoveRectangle(Point pt, Point offset)
        {
            if (mainctrl != null)
            {
                mainctrl.BringToFront();
                SetTableHeight(mainctrl, tabletype);
                
                Point ptl = mainctrl.PointToClient(pt);
                
                int left = mainctrl.Left + ptl.X - mainctrl.Width - pth.X+3+hotspot.Width; 
                int top = mainctrl.Top + ptl.Y - mainctrl.Height - pth.Y+3+hotspot.Height; 

                Point location = new Point(left, top);
                
                Size dims = new Size(mainctrl.Size.Width,mainctrl.Size.Height);
                dims.Width++;
                dims.Height++;

                Graphics g = parent.CreateGraphics();
                Pen pen = new Pen(Color.Blue);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                Pen penBackground = new Pen(parent.BackColor);
                //Pen penBackground = new Pen(Color.Red);

                g.DrawRectangle(penBackground, last_local_position.X, last_local_position.Y, last_local_dimensions.Width, last_local_dimensions.Height);
                
                last_local_position = location;
                last_local_dimensions = dims;               
                g.DrawRectangle(pen, location.X, location.Y,dims.Width, dims.Height);
            }
        }        

        public Point GetAbsolutePoint()
        {
            return mainctrl.PointToScreen(Point.Empty);            
        }

        public Point GetLocalPointPoint()
        {
            return mainctrl.PointToClient(Point.Empty);
        }

        public void FixLeftRectangle(Point pt)
        {
            SetTableHeight(mainctrl, tabletype);
            last_local_position = pt;            
        }

        public void DrawResizeRectangle(Point pt)
        {           
                if (mainctrl != null)
                {
                    Point p = GetAbsolutePoint();
                    Point ptl = mainctrl.PointToClient(pt);
                    SetTableHeight(mainctrl, tabletype);
                    int width  = ptl.X  + (hotspot.Height / 2);  
                    int height = ptl.Y + (hotspot.Height / 2);  
                    Size dims = new Size(width, height);
                    Graphics g = parent.CreateGraphics();
                    Pen pen = new Pen(Color.Black);
                    Pen penBackground = new Pen(parent.BackColor);

                    g.DrawRectangle(penBackground, last_local_position.X, last_local_position.Y, last_local_dimensions.Width, last_local_dimensions.Height);

                    last_local_dimensions = dims;
                    
                    g.DrawRectangle(pen, last_local_position.X, last_local_position.Y, dims.Width, dims.Height);                    
                }            
        }
        
        public void ClearLastRectangle()
        {          
                if (mainctrl != null)
                {                    
                    Graphics g = parent.CreateGraphics();
                    Pen pen = new Pen(Color.Black);
                    Pen penBackground = new Pen(parent.BackColor);
                    g.DrawRectangle(penBackground, last_local_position.X, last_local_position.Y, last_local_dimensions.Width, last_local_dimensions.Height);
            }
            
        }

        public void SetTableHeight(Control ctrl, eTableType tt)
        {
            if(tt == eTableType.Minimized)
            {
                ctrl.Height = 56;
            }
            else if(tt == eTableType.Autosize)
            {
               // ctrl.Height = 256;
            }
            else
            {
               // ctrl.Height = 512;
            }
            
        }

        public double zoom_fkt = 1;

        public void DrawMove(Point pt)
        {
            if (action == eAction.OnMove)
            {
                MoveToPosAsAbsolute(pt);
            }
        }

        public void MoveToPosAsAbsolute(Point pt)
        {            
                if (mainctrl != null)
                {
                    Point p = GetAbsolutePoint();
                    Point ptl = mainctrl.PointToClient(pt);
                    SetTableHeight(mainctrl, tabletype);

                    int left = mainctrl.Left + ptl.X + (hotspot.Width/2); // + (pt.X - p.X) - mainctrl.Width + 8;
                    int top = mainctrl.Top + ptl.Y - (hotspot.Height/2);  // + (pt.Y - p.Y) - mainctrl.Height + form_frame_height;
                    Point p_local = new Point(left,top);
                    MoveToPosAsLocal(p_local);                    
                }            
        }

        public Point last_local_position = new Point(0, 0);

        public void MoveToPosAsLocal(Point pt)
        {
            if (mainctrl != null)
            {                                
                mainctrl.Left = (int)(pt.X);
                mainctrl.Top = (int)(pt.Y);
                mainctrl.Width = (int)(last_local_dimensions.Width);
                mainctrl.Height = (int)(last_local_dimensions.Height);

                last_local_position = pt;                
                hotspot.BackColor = Color.Green;
                mainctrl.Invalidate();
            }
        }

        public void DrawLastMove()
        {
                DrawLastTable();
                if (mainctrl != null)
                {                
                    hotspot.BackColor = Color.Green;
                    mainctrl.Invalidate();
                }
            
        }
        public float AbsolutZoom = 1;
        public void Zoom(float zm)
        {
           
            if ((mainctrl.Height * zm) > 32)
            {
                zoom = zm;
                AbsolutZoom *= zm;
                last_local_position.X = (int)(last_local_position.X * zoom);
                last_local_position.Y = (int)(last_local_position.Y * zoom);
                last_local_dimensions.Width = (int)(last_local_dimensions.Width * zoom);
                last_local_dimensions.Height = (int)(last_local_dimensions.Height * zoom);

                DrawLastMove();
                DrawLastTable();
            }
        }

        public void DrawTable()
        {            
                if (mainctrl != null)
                {
                    SetTableHeight(mainctrl, tabletype);
                    mainctrl.Invalidate();
                }            
        }

        public void DrawLastTable()
        {
            if (mainctrl != null)
            {
                mainctrl.Left = (int) (last_local_position.X);
                mainctrl.Top = (int) (last_local_position.Y);
                mainctrl.Width = (int) (last_local_dimensions.Width);
                mainctrl.Height = (int) (last_local_dimensions.Height);

                mainctrl.Invalidate();
            }
        }

        public void DrawResizeAfterRelease(Point pt)
        {
            DrawResize(pt);
            hotspot.BackColor = Color.Green;
        }

        public void DrawResize(Point pt)
        {            
            if (action == eAction.OnResize)
            {
                DrawResizeAsAbsolute(pt);                
            }
        }

        public void DrawResizeStart(Point pt)
        {
            if (action == eAction.OnResize)
            {
                pth = hotspot.PointToClient(pt);
                DrawResizeAsAbsolute(pt);
            }
        }

        public void DrawResizeAsAbsolute(Point pt)
        {
            //pt abstand absolut vom Bildschirmrand
            if (action == eAction.OnResize)
            {
                if (mainctrl != null)
                {
                    Point ptl = mainctrl.PointToClient(pt);
                    parent.Text = "Y:" + pt.Y.ToString();
                    int Width = ptl.X + (hotspot.Width - pth.X + 3);
                    int Height = ptl.Y + (hotspot.Height - pth.Y + 3);
                    DrawResizeAsLocal(new Size(Width, Height));
                }
            }
        }

        public void DrawResizeAsLocal(Size pt)
        {           
             if (mainctrl != null)
             {
                 mainctrl.BringToFront();
                 hotspot.BackColor = Color.Red;                    
                 mainctrl.Width = (int)(pt.Width);
                 mainctrl.Height = (int)(pt.Height);
                 mainctrl.Left = (int) (last_local_position.X);
                 mainctrl.Top = (int)(last_local_position.Y);
                 last_local_dimensions = mainctrl.Size;
             }                
        }
    }
}
