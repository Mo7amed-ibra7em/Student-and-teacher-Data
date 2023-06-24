using CLASS_DATA_STUDENT_TEACHER;
using STUDENT_TEACHER_DATA.Forms;
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

namespace STUDENT_TEACHER_DATA
{
    public partial class F_DATA_TEACH : Form
    {
        DatabaseHelperDll HelperDll = new DatabaseHelperDll("Data Source=M-A-IBRAHEM;Initial Catalog=STUDENT TEACHER DATA; Integrated Security = True");
        public double ID;
        F_UPDATE_TEACH f_update_teach;
        public F_DATA_TEACH()
        {
            InitializeComponent();
        }

        private void F_DATA_TEACH_Load(object sender, EventArgs e)
        {
            HelperDll.ShowDataTeacher(dgv_teach);
        }
        private void b_delete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgv_teach.CurrentRow.Cells[0].Value);
            HelperDll.DeleteData(Id, "tbl_teacher");
            HelperDll.ShowDataTeacher(dgv_teach);
            MessageCollection.showNatification(HelperDll.Message());
        }
        private void t_search_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT ID as 'الرقم الوظيفي ', TEACH_FNAME 'اسم المدرس', TEACH_DEPT 'الفرع', TEACH_COURSE 'المقرر' FROM TBL_TEACHER WHERE ID LIKE '%" + t_search.Text + "%' or TEACH_FNAME LIKE '%" + t_search.Text + "%' or TEACH_DEPT LIKE '%" + t_search.Text + "%' or TEACH_COURSE LIKE '%" + t_search.Text + "%'";
            DataTable TableSearch = HelperDll.Search(query);
            dgv_teach.DataSource = TableSearch;
        }
        private void b_edit_Click(object sender, EventArgs e)
        {
            ID = 0;
            if (dgv_teach.CurrentRow != null)
            {
                ID = Convert.ToDouble(dgv_teach.CurrentRow.Cells[0].Value);
                f_update_teach = new F_UPDATE_TEACH(ID);
                f_update_teach.ShowDialog();
            }          
        }
        private void dgv_teach_DoubleClick(object sender, EventArgs e)
        {
            ID = 0;
            if (dgv_teach.CurrentRow != null)
            {
                ID = Convert.ToDouble(dgv_teach.CurrentRow.Cells[0].Value);
                f_update_teach = new F_UPDATE_TEACH(ID);
                f_update_teach.ShowDialog();
            }
        }
    }
}
