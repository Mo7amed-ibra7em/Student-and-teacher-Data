using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASS_DATA_STUDENT_TEACHER;
using STUDENT_TEACHER_DATA.Notification;

namespace STUDENT_TEACHER_DATA
{
    public partial class F_ADD_TEACH : Form
    {
        DatabaseHelperDll HelperDll = new DatabaseHelperDll("Data Source=M-A-IBRAHEM;Initial Catalog=STUDENT TEACHER DATA; Integrated Security = True");
        string[] Dept1 = { "الجبر الخطي", "برمجة 1", "تحليل 1", "احتمالات وإحصاء", "لغة أجنبية", "قواعد معطيات 1", "تطبيقات إنترنت" };
        string[] Dept2 = { "مبادئ الادارة","محاسبة 1", "ادارة الانتاج", "مبادئ الإقتصاد", "ادارة التسويق", "رياضيات", "تمويل واسثمار" };
        string[] Dept3 = { "فقه عبادات", "قواعد معطيات 1", "برمجة1 ", "برمجة متقدمة 1", "هندسة برمجيات", "وسائط متعددة", "رياضيات" };
        string[] Dept4 = { "مبادئ الادارة", "مبادئ الاحصاء", "محاسبة 1", "اساسيات المعلوماتية", "رياضيات ", "عقيدة ", "قوانين أعمال" };

        public F_ADD_TEACH()
        {
            InitializeComponent();
            b_add_teach.Click += new EventHandler(b_add_teach_Click);
            t_fname_teach.KeyPress += new KeyPressEventHandler(t_fname_teach_KeyPress);
            t_id_teach.KeyPress += new KeyPressEventHandler(t_id_teach_KeyPress);
            com_dept_teach.SelectionChangeCommitted += new EventHandler(com_dept_teach_SelectionChangeCommitted);
            t_id_teach.TextChanged += new EventHandler(t_id_teach_TextChanged);
        }
        private void F_ADD_TEACH_Load(object sender, EventArgs e)
        {

        }

        private void b_add_teach_Click(object sender, EventArgs e)
        {
            if(t_id_teach.Text != "" && t_fname_teach.Text != "")
            {
                double Id = Convert.ToDouble(t_id_teach.Text);
                string FullName = t_fname_teach.Text;
                string Dept = com_dept_teach.Text;
                string Course = com_course_teach.Text;
                HelperDll.InsertDataTeacher(Id, FullName, Dept, Course);
                MessageCollection.showNatification(HelperDll.Message());
                ///Clear
                t_id_teach.Text = "";
                t_fname_teach.Text = "";
                com_dept_teach.SelectedIndex = 0;
                com_course_teach.SelectedIndex = 0;
            }
            else
            {
                MessageCollection.showNatification("أدخل جميع البيانات");
            }
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
        private void t_id_teach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void t_fname_teach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void t_id_teach_TextChanged(object sender, EventArgs e)
        {
            bool Tests = HelperDll.Tests(t_id_teach.Text,"TBL_TEACHER");
            if (Tests == true)
            {
                t_id_teach.ForeColor = Color.Red;
            }
            else
            {
                t_id_teach.ForeColor = Color.White;
            }
        }
    }
}
