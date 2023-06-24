using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_TEACHER_DATA.Notification
{
    public partial class F_NOTIFICATION : Form
    {
        public F_NOTIFICATION()
        {
            InitializeComponent();
        }
        private void timer_notification_Tick(object sender, EventArgs e)
        {
            Close();
        }
        private void lbl_notification_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void pictor_icon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_NOTIFICATION_Load(object sender, EventArgs e)
        {

        }
    }
}
