using CLASS_DATA_STUDENT_TEACHER;
using STUDENT_TEACHER_DATA.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_TEACHER_DATA.Forms
{
    public partial class F_UPDATE_STU : Form
    {
        DatabaseHelperDll HelperDll = new DatabaseHelperDll("Data Source=M-A-IBRAHEM;Initial Catalog=STUDENT TEACHER DATA; Integrated Security = True");
        string connection = "Data Source=M-A-IBRAHEM;Initial Catalog=STUDENT TEACHER DATA; Integrated Security = True";
        double Id;
        F_DATA_STU data_stu = Application.OpenForms["F_DATA_STU"] as F_DATA_STU;
        string[] Dept1 = { "السنة الأولى", "السنة الثانية", "السنة الثالثة", "السنة الرابعة", "السنة الخامسة" };
        string[] Dept2 = { "السنة الأولى", "السنة الثانية", "السنة الثالثة", "السنة الرابعة" };
        string[] Dept3 = { "السنة الأولى", "السنة الثانية" };
        public F_UPDATE_STU(double id)
        {
            InitializeComponent();
            Id = id;
        }
        private void F_UPDATE_STU_Load(object sender, EventArgs e)
        {
            string[] DataStudent = DatabaseHelperDll.GetDataStudent(connection, Id);
            if (Id > 0)
            {
                t_id_stu.Text = DataStudent[0];
                t_fname_stu.Text = DataStudent[1];
                com_dept_stu.Text = DataStudent[2];
                if (com_dept_stu.SelectedIndex == 0)
                {
                    com_year_stu.Items.AddRange(Dept1);
                }
                else if (com_dept_stu.SelectedIndex == 1)
                {
                    com_year_stu.Items.AddRange(Dept2);
                }
                else
                {
                    com_year_stu.Items.AddRange(Dept3);
                }
                com_year_stu.Text = DataStudent[3];
            }
        }
        private void b_Update_stu_Click(object sender, EventArgs e)
        {
            string FullName = t_fname_stu.Text;
            string Dept = com_dept_stu.Text;
            string Year = com_year_stu.Text;
            HelperDll.UpdateDataStudent(Id, FullName, Dept, Year);
            Id = 0;
            Close();
            HelperDll.ShowDataStudent(data_stu.dgv_stu);
            MessageCollection.showNatification(HelperDll.Message());
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
            else
            {
                com_year_stu.Items.AddRange(Dept3);
            }
        }
    }
}
