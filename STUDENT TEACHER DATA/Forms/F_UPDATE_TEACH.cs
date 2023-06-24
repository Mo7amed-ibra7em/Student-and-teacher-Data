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
    public partial class F_UPDATE_TEACH : Form
    {
        DatabaseHelperDll HelperDll = new DatabaseHelperDll("Data Source=M-A-IBRAHEM;Initial Catalog=STUDENT TEACHER DATA; Integrated Security = True");
        string connection = "Data Source=M-A-IBRAHEM;Initial Catalog=STUDENT TEACHER DATA; Integrated Security = True";
        double Id;
        F_DATA_TEACH data_teach = Application.OpenForms["F_DATA_TEACH"] as F_DATA_TEACH;
        string[] Dept1 = { "الجبر الخطي", "برمجة 1", "تحليل 1", "احتمالات وإحصاء", "لغة أجنبية", "قواعد معطيات 1", "تطبيقات إنترنت" };
        string[] Dept2 = { "مبادئ الادارة", "محاسبة 1", "ادارة الانتاج", "مبادئ الإقتصاد", "ادارة التسويق", "رياضيات", "تمويل واسثمار" };
        string[] Dept3 = { "فقه عبادات", "قواعد معطيات 1", "برمجة1 ", "برمجة متقدمة 1", "هندسة برمجيات", "وسائط متعددة", "رياضيات" };
        string[] Dept4 = { "مبادئ الادارة", "مبادئ الاحصاء", "محاسبة 1", "اساسيات المعلوماتية", "رياضيات ", "عقيدة ", "قوانين أعمال" };

        public F_UPDATE_TEACH(double id)
        {
            InitializeComponent();
            this.Id = id;
        }
        private void F_UPDATE_TEACH_Load(object sender, EventArgs e)
        {
            string[] DataTeacher = DatabaseHelperDll.GetDataTeacher(connection, Id);
            if (Id > 0)
            {
                t_id_teach.Text = DataTeacher[0];
                t_fname_teach.Text = DataTeacher[1];
                com_dept_teach.Text = DataTeacher[2];
                if (com_dept_teach.SelectedIndex == 0)
                {
                    com_course_teach.Items.AddRange(Dept1);
                }
                else if (com_dept_teach.SelectedIndex == 1)
                {
                    com_course_teach.Items.AddRange(Dept2);
                }
                else if (com_dept_teach.SelectedIndex == 2)
                {
                    com_course_teach.Items.AddRange(Dept3);
                }
                else
                {
                    com_course_teach.Items.AddRange(Dept4);
                }
                com_course_teach.Text = DataTeacher[3];
            }
        }
        private void b_update_teach_Click(object sender, EventArgs e)
        {
            string FullName = t_fname_teach.Text;
            string Dept = com_dept_teach.Text;
            string Course = com_course_teach.Text;
            HelperDll.UpdateDataTeacher(Id, FullName, Dept, Course);
            Id = 0;
            Close();
            HelperDll.ShowDataTeacher(data_teach.dgv_teach);
            MessageCollection.showNatification(HelperDll.Message());
        }
        private void com_dept_teach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            com_course_teach.Items.Clear();

            if (com_dept_teach.SelectedIndex == 0)
            {
                com_course_teach.Items.AddRange(Dept1);
            }
            else if (com_dept_teach.SelectedIndex == 1)
            {
                com_course_teach.Items.AddRange(Dept2);
            }
            else if (com_dept_teach.SelectedIndex == 2)
            {
                com_course_teach.Items.AddRange(Dept3);
            }
            else
            {
                com_course_teach.Items.AddRange(Dept4);
            }
        }
    }
}
