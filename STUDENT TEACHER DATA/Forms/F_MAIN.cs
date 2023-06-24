using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_TEACHER_DATA
{
    public partial class F_MAIN : Form
    {
        #region \\Design
        bool but1 = false;
        bool but2 = false;
        bool but3 = false;
        bool but4 = false;
        bool but5 = false;
        int animated = 0;
        #endregion
        public F_MAIN()
        {
            InitializeComponent();
        }

        private void F_MAIN_Load(object sender, EventArgs e)
        {
            pnl_load.Controls.Clear();
            F_DATA_STU data_stu = new F_DATA_STU();
            data_stu.TopLevel = false;
            pnl_load.Controls.Add(data_stu);
            data_stu.Dock = DockStyle.Fill;
            data_stu.Show();
            ///
            StartTimerThread();

        }
        private void timer_scroll_Tick(object sender, EventArgs e)
        {
            if (but1 == true)
            {
                pnl_scroll2.MinimumSize = l1.MaximumSize;
                if (pnl_scroll2.Size.Height >= animated)
                {
                    b_scroll.Height += 10;
                    pnl_scroll2.Height -= 10;
                }
                else
                {
                    b_scroll.Height -= 10;
                    pnl_scroll2.Height -= 10;
                }

                if (pnl_scroll2.Size == pnl_scroll2.MinimumSize)
                {
                    timer_scroll.Stop();
                    b_scroll.Height = 30;
                    but1 = false;
                    b_scroll.ShadowDecoration.Enabled = true;
                }
            }
            ////
            if (but2 == true)
            {
                if (animated == 0)
                {
                    pnl_scroll2.MaximumSize = l2.MaximumSize;
                    pnl_scroll2.Height += 10;
                    if (pnl_scroll2.Height == l2.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_scroll.Stop();
                        but2 = false;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll2.MinimumSize = l2.MaximumSize;
                    if (pnl_scroll2.Size.Height >= animated)
                    {
                        b_scroll.Height += 5;
                        pnl_scroll2.Height -= 10;
                    }
                    else
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height -= 5;
                    }
                    ///
                    if (pnl_scroll2.Height == l2.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_scroll.Stop();
                        but2 = false;
                    }
                }
            }
            ////
            if (but3 == true)
            {
                if (animated == 0)
                {
                    pnl_scroll2.MaximumSize = l3.MaximumSize;
                    b_scroll.Height += 10;
                    pnl_scroll2.Height += 10;
                    ///
                    if (pnl_scroll2.Height == l3.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_scroll.Stop();
                        but3 = false;
                    }
                }
                if (animated != 0)
                {
                    pnl_scroll2.MinimumSize = l3.MaximumSize;
                    if (pnl_scroll2.Height >= animated)
                    {
                        b_scroll.Height += 10;
                        pnl_scroll2.Height -= 10;
                    }
                    else
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height -= 10;
                    }
                    ///
                    if (pnl_scroll2.Height == l3.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_scroll.Stop();
                        but3 = false;
                    }
                }
            }
            ////
            if (but4 == true)
            {
                if (pnl_scroll2.Height > l4.MaximumSize.Height)
                {
                    pnl_scroll2.MinimumSize = l4.MaximumSize;
                    if (pnl_scroll2.Height >= animated)
                    {
                        b_scroll.Height += 10;
                        pnl_scroll2.Height -= 10;
                    }
                    else
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height -= 10;
                    }
                    ///
                    if (pnl_scroll2.Height == l4.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_scroll.Stop();
                        but4 = false;
                    }
                }
                if (pnl_scroll2.Height < l4.MaximumSize.Height)
                {
                    pnl_scroll2.MaximumSize = l4.MaximumSize;
                    if (pnl_scroll2.Size.Height >= animated)
                    {
                        b_scroll.Height -= 10;
                        pnl_scroll2.Height += 10;
                    }
                    else
                    {
                        b_scroll.Height += 10;
                        pnl_scroll2.Height += 10;
                    }
                    ///
                    if (pnl_scroll2.Height == l4.MaximumSize.Height)
                    {
                        b_scroll.Height = 30;
                        b_scroll.ShadowDecoration.Enabled = true;
                        timer_scroll.Stop();
                        but4 = false;
                    }
                }
            }
            ////
            if (but5 == true)
            {
                pnl_scroll2.MaximumSize = l5.MaximumSize;
                if (pnl_scroll2.Size.Height >= animated)
                {
                    b_scroll.Height -= 10;
                    pnl_scroll2.Height += 10;
                }
                else
                {
                    b_scroll.Height += 10;
                    pnl_scroll2.Height += 10;
                }

                if (pnl_scroll2.Size == pnl_scroll2.MaximumSize)
                {
                    b_scroll.Height = 30;
                    timer_scroll.Stop();
                    but5 = false;
                    b_scroll.ShadowDecoration.Enabled = true;
                }
            }

            ////Design////
        }
        private void b_data_stu_Click(object sender, EventArgs e)
        {
            if (pnl_scroll2.Height == l1.MaximumSize.Height)
            {

            }
            else if (pnl_scroll2.Height <= l3.MaximumSize.Height)
            {
                but1 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_scroll.Start();
                ///
                pnl_load.Controls.Clear();
                F_DATA_STU data_stu = new F_DATA_STU();
                data_stu.TopLevel = false;
                pnl_load.Controls.Add(data_stu);
                data_stu.Dock = DockStyle.Fill;
                data_stu.Show();
            }
            else if (pnl_scroll2.Height >= l4.MaximumSize.Height)
            {
                but1 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer_scroll.Start();
                ///
                pnl_load.Controls.Clear();
                F_DATA_STU data_stu = new F_DATA_STU();
                data_stu.TopLevel = false;
                pnl_load.Controls.Add(data_stu);
                data_stu.Dock = DockStyle.Fill;
                data_stu.Show();
            }
        }
        private void b_data_tech_Click(object sender, EventArgs e)
        {
            if (pnl_scroll2.Height == l2.MaximumSize.Height)
            {

            }
            else if (pnl_scroll2.Height == l1.MaximumSize.Height || pnl_scroll2.Height == l3.MaximumSize.Height)
            {
                but2 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_scroll.Start();
            }
            else if (pnl_scroll2.Height >= l2.MaximumSize.Height)
            {
                but2 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer_scroll.Start();
            }
            ///
            pnl_load.Controls.Clear();
            F_DATA_TEACH f_data_teach = new F_DATA_TEACH();
            f_data_teach.TopLevel = false;
            pnl_load.Controls.Add(f_data_teach);
            f_data_teach.Dock = DockStyle.Fill;
            f_data_teach.Show();
        }
        private void b_add_stu_Click(object sender, EventArgs e)
        {
            if (pnl_scroll2.Height == l3.MaximumSize.Height)
            {

            }
            else if (pnl_scroll2.Height <= l2.MaximumSize.Height)
            {
                but3 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_scroll.Start();
            }
            else if (pnl_scroll2.Height >= l4.MaximumSize.Height)
            {
                but3 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer_scroll.Start();
            }                ///
            pnl_load.Controls.Clear();
            F_ADD_STU f_add_stu = new F_ADD_STU();
            f_add_stu.TopLevel = false;
            pnl_load.Controls.Add(f_add_stu);
            f_add_stu.Dock = DockStyle.Fill;
            f_add_stu.Show();
        }
        private void b_add_teach_Click(object sender, EventArgs e)
        {
            if (pnl_scroll2.Height == l4.MaximumSize.Height)
            {

            }
            else if (pnl_scroll2.Height <= l2.MaximumSize.Height)
            {
                but4 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                animated = pnl_scroll2.MaximumSize.Height / 2;
                timer_scroll.Start();
            }
            else if (pnl_scroll2.Height == l3.MaximumSize.Height || pnl_scroll2.Height == l5.MaximumSize.Height)
            {
                but4 = true;
                b_scroll.ShadowDecoration.Enabled = false;
                timer_scroll.Start();
            }
            ///
            pnl_load.Controls.Clear();
            F_ADD_TEACH f_add_teach = new F_ADD_TEACH();
            f_add_teach .TopLevel = false;
            pnl_load.Controls.Add(f_add_teach);
            f_add_teach.Dock = DockStyle.Fill;
            f_add_teach.Show();
        }
        private void b_about_Click(object sender, EventArgs e)
        {
            but5 = true;
            b_scroll.ShadowDecoration.Enabled = false;
            animated = pnl_scroll2.MaximumSize.Height / 2;
            timer_scroll.Start();
            ///
            pnl_load.Controls.Clear();
            F_ABOUT about = new F_ABOUT();
            about.TopLevel = false;
            pnl_load.Controls.Add(about);
            about.Dock = DockStyle.Fill;
            about.Show();
        }
        ///الوقت المنقضي
        private bool stopTimer = false;
        private bool l_color = true;

        private void StartTimerThread()
        {
           Thread timerThread = new Thread(UpdateTimer);
            timerThread.Start();
        }
        private void UpdateTimer()
        {
            int seconds = 0;

            while (!stopTimer)
            {
                seconds++; // زيادة الثواني

                // التبديل بين الألوان 
                if (l_color)
                {
                    // تعيين لون النص إلى CornflowerBlue
                    l_seconds.ForeColor = Color.CornflowerBlue;
                    l_minutes.ForeColor = Color.CornflowerBlue;
                    l_hours.ForeColor = Color.CornflowerBlue;
                    l_dot2.ForeColor = Color.CornflowerBlue;
                    l_dot1.ForeColor = Color.CornflowerBlue;
                    l_color = false;
                }
                else
                {
                    // تعيين لون النص إلى 255, 128, 255)
                    l_seconds.ForeColor = Color.FromArgb(255, 128, 255);
                    l_minutes.ForeColor = Color.FromArgb(255, 128, 255);
                    l_hours.ForeColor = Color.FromArgb(255, 128, 255);
                    l_dot2.ForeColor = Color.FromArgb(255, 128, 255);
                    l_dot1.ForeColor = Color.FromArgb(255, 128, 255);
                    l_color = true;
                }

                if (seconds == 60)
                {
                    // زيادة الدقائق عند وصول قيمة الثواني إلى 60
                    l_minutes.Text = Convert.ToString(1 + Convert.ToInt32(l_minutes.Text));

                    // إضافة صفر في البداية إذا كانت القيمة أقل من 10
                    if (Convert.ToInt32(l_minutes.Text) <= 10)
                        l_minutes.Text = "0" + l_minutes.Text;

                    seconds = 00;
                }

                if (l_minutes.Text == "60")
                {
                    // زيادة الساعات عند وصول قيمة الدقائق إلى 60
                    l_hours.Text = Convert.ToString(1 + Convert.ToInt32(l_hours.Text));

                    // إضافة صفر في البداية إذا كانت القيمة أقل من 10
                    if (Convert.ToInt32(l_hours.Text) <= 10)
                        l_hours.Text = "0" + l_hours.Text;

                    l_minutes.Text = "00";
                }

                // على الواجهة label تحديث القيمة في 
                l_seconds.Invoke(new Action(() => l_seconds.Text = seconds.ToString()));

                Thread.Sleep(1000);
            }
        }
    }
}
