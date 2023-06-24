using CLASS_DATA_STUDENT_TEACHER;
using STUDENT_TEACHER_DATA.Forms;
using STUDENT_TEACHER_DATA.Notification;
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

namespace STUDENT_TEACHER_DATA
{
    public partial class F_DATA_STU : Form
    {
        DatabaseHelperDll HelperDll = new DatabaseHelperDll("Data Source=M-A-IBRAHEM;Initial Catalog=STUDENT TEACHER DATA; Integrated Security = True");
        public double ID;
        F_UPDATE_STU f_update_stu;
        public F_DATA_STU()
        {
            InitializeComponent();
        }

        private void F_DATA_STU_Load(object sender, EventArgs e)
        {
            HelperDll.ShowDataStudent(dgv_stu);
        }
        private void b_delete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgv_stu.CurrentRow.Cells[0].Value);
            HelperDll.DeleteData(Id, "tbl_student");
            HelperDll.ShowDataStudent(dgv_stu);
            MessageCollection.showNatification(HelperDll.Message());
        }
        private void t_search_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT ID as 'الرقم الجامعي ', STU_FNAME 'اسم الطالب', STU_DEPT 'الفرع', STU_YEAR 'السنة' FROM TBL_STUDENT WHERE ID LIKE '%" + t_search.Text + "%' or STU_FNAME LIKE '%" + t_search.Text + "%' or STU_DEPT LIKE '%" + t_search.Text + "%' or STU_YEAR LIKE '%" + t_search.Text + "%'";
            DataTable TableSearch = HelperDll.Search(query);
            dgv_stu.DataSource = TableSearch;
        }
        private void b_edit_Click(object sender, EventArgs e)
        {
            ID = 0;
            if (dgv_stu.CurrentRow != null)
            {
                ID = Convert.ToDouble(dgv_stu.CurrentRow.Cells[0].Value);
                f_update_stu = new F_UPDATE_STU(ID);
                f_update_stu.ShowDialog();
            }
        }
        private void dgv_stu_DoubleClick(object sender, EventArgs e)
        {
            ID = 0;
            if (dgv_stu.CurrentRow != null)
            {
                ID = Convert.ToDouble(dgv_stu.CurrentRow.Cells[0].Value);
                f_update_stu = new F_UPDATE_STU(ID);
                f_update_stu.ShowDialog();
            }
        }
    }
}
