using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CLASS_DATA_STUDENT_TEACHER
{
    public class DatabaseHelperDll
    {
        private SqlConnection connection;
        private string connectionString;
        int MessageIndex = 0;

        public DatabaseHelperDll(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
        }
        ///ادخال بيانات الطلاب
        public void InsertDataStudent(double Id, string FullName, string Dept, string Year)
        {
            string query = "INSERT INTO tbl_student (ID,STU_FNAME,STU_DEPT,STU_YEAR) VALUES (@Id ,@FullName ,@Dept ,@Year)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@Dept", Dept);
            command.Parameters.AddWithValue("@Year", Year);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageIndex = 0;
                Message();
            }
            catch (Exception ex)
            {
                MessageIndex = 1;
                Message();
            }
            finally
            {
                connection.Close();
            }
        }
        ///ادخال بيانات المدرسين
        public void InsertDataTeacher(double Id, string FullName, string Dept, string Course)
        {
            string query = "INSERT INTO tbl_teacher (ID,TEACH_FNAME,TEACH_DEPT,TEACH_COURSE) VALUES (@Id ,@FullName ,@Dept ,@Course)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@Dept", Dept);
            command.Parameters.AddWithValue("@Course", Course);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageIndex = 0;
                Message();
            }
            catch (Exception ex)
            {
                MessageIndex = 1;
                Message();
            }
            finally
            {
                connection.Close();
            }
        }
        ///تعديل بيانات المدرسين
        public void UpdateDataTeacher(double Id, string FullName, string Dept, string Course)
        {
            string query = "UPDATE TBL_TEACHER SET TEACH_FNAME = @FullName, TEACH_DEPT = @Dept , TEACH_COURSE = @Course WHERE Id = " + Id + ";";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@Dept", Dept);
            command.Parameters.AddWithValue("@Course", Course);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageIndex = 2;
                Message();
            }
            catch (Exception ex)
            {
                MessageIndex = 3;
                Message();
            }
            finally
            {
                connection.Close();
            }
        }
        ///تعديل بيانات الطلاب
        public void UpdateDataStudent(double Id, string FullName, string Dept, string Year)
        {
            string query = "UPDATE TBL_STUDENT SET STU_FName =@FullName , STU_Dept =@Dept , STU_Year =@Year WHERE Id = " + Id + ";";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@FullName", FullName);
                command.Parameters.AddWithValue("@Dept", Dept);
                command.Parameters.AddWithValue("@Year", Year);
                
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageIndex = 2;
                Message();
            }
            catch (Exception ex)
            {
                MessageIndex = 3;
                Message();
            }
            finally
            {
                connection.Close();
            }
        }
        ///حذف البيانات 
        public void DeleteData(int Id, string TBLName)
        {
            string query = "DELETE FROM " + TBLName + " WHERE Id = " + Id + "";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageIndex = 4;
                Message();
            }
            catch (Exception ex)
            {
                MessageIndex = 5;
                Message();
            }
            finally
            {
                connection.Close();
            }
        }
        ///البحث
        public DataTable Search(string query)
        {
            DataTable TableSearch = new DataTable();
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataAdapter adapter = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(TableSearch);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (adapter != null)
                    adapter.Dispose();

                if (command != null)
                    command.Dispose();

                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return TableSearch;
        }
        /// عرض البيانات على واجهة التعديل
        public static string[] GetDataStudent(string connection, double ID)
        {
            string[] ArrayDataStudent = new string[] { };
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = connection;
            }
            catch (Exception ex)
            {
                
            }
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlconn;
            SqlDataReader dread;
            try
            {
                sqlcmd.CommandText = "select ID,STU_FNAME,STU_DEPT,STU_YEAR from TBL_STUDENT where ID = " + ID + ";";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    ArrayDataStudent = new string[] { dread["ID"].ToString(), dread["STU_FNAME"].ToString(), dread["STU_DEPT"].ToString(), dread["STU_YEAR"].ToString() };
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                sqlconn.Close();
            }
            return ArrayDataStudent;
        }
        public static string[] GetDataTeacher(string connection, double ID)
        {
            string[] ArrayDataTeacher = new string[] { };
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = connection;
            }
            catch (Exception ex)
            {

            }
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlconn;
            SqlDataReader dread;
            try
            {
                sqlcmd.CommandText = "select ID,TEACH_FNAME,TEACH_DEPT,TEACH_COURSE from TBL_TEACHER where ID = " + ID + ";";
                sqlconn.Open();
                dread = sqlcmd.ExecuteReader();
                while (dread.Read())
                {
                    ArrayDataTeacher = new string[] { dread["ID"].ToString(), dread["TEACH_FNAME"].ToString(), dread["TEACH_DEPT"].ToString(), dread["TEACH_COURSE"].ToString() };
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlconn.Close();
            }
            return ArrayDataTeacher;
        }
        ///التحقق من العمليات
        public string Message()
        {
            string Message = "";
            switch(MessageIndex)
            {
                case 0:
                    Message ="تمت عملية الإضافة";
                    break;
                case 1:
                    Message = "تعذّر عملية الإضافة";
                    break;
                case 2:
                    Message = "تم التعديل بنجاح";
                    break;
                case 3:
                    Message = "تعذّر عملية التعديل";
                    break;
                case 4:
                    Message = "تم الحذف بنجاح";
                    break;
                case 5:
                    Message = "تعذّر عملية الحذف";
                    break;
            }
            return Message;
        }
        ///اختبار فيما اذا كان الـرقم موجود ام لا
        public bool Tests(string id,string TBLName)
        {
            string Qwery = "Select * From "+TBLName+" where ID = @ID_STU";
            SqlCommand comand = new SqlCommand(Qwery,connection);
            comand.Parameters.AddWithValue("@ID_STU", id);
            SqlDataReader reader;
            connection.Open();
            reader= comand.ExecuteReader();
            if(reader.HasRows)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        ///عرض البيانات على الداتا كريد فيو
        public void ShowDataStudent(DataGridView dataGridView)
        {
            string query = "SELECT ID as 'الرقم الجامعي ', STU_FNAME 'اسم الطالب', STU_DEPT 'الفرع', STU_YEAR 'السنة' from TBL_STUDENT";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            try
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        public void ShowDataTeacher(DataGridView dataGridView)
        {
            string query = "SELECT ID as 'الرقم الوظيفي ', TEACH_FNAME 'اسم المدرس', TEACH_DEPT 'الفرع', TEACH_COURSE 'المقرر' from TBL_TEACHER";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            try
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
