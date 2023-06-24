using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASS_DATA_STUDENT_TEACHER;
using STUDENT_TEACHER_DATA.Notification;

namespace STUDENT_TEACHER_DATA
{
    public partial class F_ADD_STU : Form
    {
        DatabaseHelperDll HelperDll = new DatabaseHelperDll("Data Source=M-A-IBRAHEM;Initial Catalog=STUDENT TEACHER DATA; Integrated Security = True");
        string[] Dept1 = { "السنة الأولى", "السنة الثانية", "السنة الثالثة", "السنة الرابعة", "السنة الخامسة" };
        string[] Dept2 = { "السنة الأولى", "السنة الثانية", "السنة الثالثة", "السنة الرابعة" };
        string[] Dept3 = { "السنة الأولى", "السنة الثانية" };

        public F_ADD_STU()
        {
            InitializeComponent();
            ///المفوضات
            t_id_stu.KeyPress += new KeyPressEventHandler(T_IdStu_KeyPressEventHandler);
            t_fname_stu.KeyPress += new KeyPressEventHandler(T_FnameStu_KeyPressEventHandler);
            b_add_stu.Click += new EventHandler(b_add_stu_Click);
            com_dept_stu.SelectionChangeCommitted += new EventHandler(com_dept_stu_SelectionChangeCommitted);
            t_id_stu.TextChanged += new EventHandler(t_id_stu_TextChanged);
        }
        private void F_ADD_STU_Load(object sender, EventArgs e)
        {

        }

        private void T_IdStu_KeyPressEventHandler(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        private void T_FnameStu_KeyPressEventHandler(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        private void b_add_stu_Click(object sender, EventArgs e)
        {
            if (t_id_stu.Text != "" && t_id_stu.Text != "")
            {
                double Id = Convert.ToDouble(t_id_stu.Text);
                string FullName = t_fname_stu.Text;
                string Dept = com_dept_stu.Text;
                string Year = com_year_stu.Text;
                HelperDll.InsertDataStudent(Id, FullName, Dept, Year);
                MessageCollection.showNatification(HelperDll.Message());
                ///Clear
                t_id_stu.Text = "";
                t_fname_stu.Text = "";
                com_dept_stu.SelectedIndex = 0;
                com_year_stu.SelectedIndex = 0;
                Id = 0;
            }
            else
            {
                MessageCollection.showNatification("أدخل جميع البيانات");
            }
        }
        private void com_dept_stu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            com_year_stu.Items.Clear();

            if (com_dept_stu.SelectedIndex == 0)
            {
                com_year_stu.Items.AddRange(Dept1);
            }
            else if (com_dept_stu.SelectedIndex == 1)
            {
                com_year_stu.Items.AddRange(Dept2);
            }
            else if (com_dept_stu.SelectedIndex == 2)
            {
                com_year_stu.Items.AddRange(Dept3);
            }
            else
            {
                com_year_stu.Items.AddRange(Dept3);
            }
        }
        private void t_id_stu_TextChanged(object sender, EventArgs e)
        {
            bool Tests = HelperDll.Tests(t_id_stu.Text,"TBL_STUDENT");
            if(Tests == true)
            {
                t_id_stu.ForeColor= Color.Red;
            }
            else
            {
                t_id_stu.ForeColor= Color.White;
            }
        }
    }
}
