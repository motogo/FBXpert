using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class ProgressClockForm : Form
    {
        private readonly Form _parent;
        private readonly Graphics _graphics = null;
        private Rectangle _clockRect = new Rectangle(0, 0, 100, 100);
        private readonly Pen _clockPen = new Pen(Color.Blue,3);

        private readonly System.Windows.Forms.Timer _clockTimer = new System.Windows.Forms.Timer();
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int Value { get; set; }
        public int X
        {
            get => pictureBox1.Left;
            set => Left = value;
        }

        public int Y
        {
            get => pictureBox1.Top;
            set => Top = value;
        }

        public ProgressClockForm(Form parent)
        {
            _parent = parent;
            InitializeComponent();
            _graphics = pictureBox1.CreateGraphics();
            _graphics.DrawEllipse(_clockPen, _clockRect);
            Maximum = 60;
            _clockTimer.Interval = 100;
            _clockTimer.Tick += ClockTimer_Tick;
        }

        public void Start(int ms)
        {
            _clockTimer.Interval = 100;
            DrawEmptyClock();
            bool started = true;
            while(started)
            {
                try
                {
                    Thread.Sleep(500);
                    NextTick();
                }
                catch
                {
                    started = false;
                    Close();
                }
            }
        }
        public void DrawEmptyClock()
        {
            _graphics.DrawEllipse(_clockPen, _clockRect);
            Point center = new Point(_clockRect.Width / 2 + _clockRect.X, _clockRect.Height / 2 + _clockRect.Y);
            Rectangle innerRect = new Rectangle(center.X - 5, center.Y - 5, 10, 10);
            _graphics.DrawEllipse(_clockPen, innerRect);
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            NextTick();
        }
        private void NextTick()
        {
            Brush br = new SolidBrush(Color.Lime);
            _graphics.FillPie(br,_clockRect, Minimum, Value++);
            if(Value > Maximum)
            {
                Value = Minimum;
                _graphics.FillPie(new SolidBrush(pictureBox1.BackColor), _clockRect, 0, 360);
                DrawEmptyClock();
            }
        }

        private void ProgressClockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _clockTimer.Stop();
        }

        private void ProgressClockForm_Load(object sender, EventArgs e)
        {
            Start(100);
        }
    }
}
