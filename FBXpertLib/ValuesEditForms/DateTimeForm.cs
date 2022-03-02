using System;
using System.Windows.Forms;

namespace FBXpertLib
{
    public partial class DateTimeForm : Form
    {
        public DateTimeForm(Form parent, DateTime dt)
        {
            InitializeComponent();
            Value = dt;
            // this.MdiParent = parent;
        }




        public DateTime Value
        {
            get
            {
                if (dateTimePicker1.Value <= dateTimePicker1.MinDate) return DateTime.MinValue;
                else
                {
                    return dateTimePicker1.Value.Date + dateTime.Value.TimeOfDay;
                }
            }
            set
            {
                if (value >= dateTimePicker1.MinDate)
                {
                    DateTime dt = value;
                    dateTimePicker1.Value = dt.Date;
                    dateTime.Value = dt.Date;
                }
                else
                {
                    dateTimePicker1.Value = dateTimePicker1.MinDate;
                    dateTime.Value = dateTimePicker1.Value;
                }
            }
        }

        private void hsCancel_Click(object sender, EventArgs e)
        {
            Value = DateTime.MinValue;
            Close();
        }

        private void hsOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
