using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternManagementSystem
{
    public  class DatabaseConnection
    {
        public static MySqlConnection getDbConnection()

        {
            MySqlConnection conn = null;
            try { 


            string connectionString = "Server = localhost; Database = IMT; Uid = root; pwd = '' ";
             conn = new MySqlConnection(connectionString);
            conn.Open();
            
            }catch(Exception e){
                e.GetBaseException();
            }
            return conn;
        }

        public static void addIntern(Intern intern)
        {
            String sql = "insert into intern values(null,@name,@email,@phone,@dob,@role,@skill)";
            MySqlConnection conn = getDbConnection();
            MySqlCommand cmd =new MySqlCommand(sql,conn);
            cmd.Parameters.Add("@name",MySqlDbType.VarChar).Value = intern.InternName;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = intern.InternEmail;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = intern.InternPhone;
            cmd.Parameters.Add("@dob", MySqlDbType.Date).Value = intern.InternDoB;
            cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = intern.InternRole;
            cmd.Parameters.Add("@skill", MySqlDbType.VarChar).Value = intern.InternSkills;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
              MessageBox.Show("Something went wrong! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
       public static MySqlDataAdapter gridAdapter;
        public static DataTable gridDt;
        public static int srtValue = 0;
        public static void DisplayAndSearch(String sql, DataGridView dgv)
        {
            MySqlConnection conn = getDbConnection();
            MySqlCommand cmd =new MySqlCommand(sql,conn);
            gridAdapter = new MySqlDataAdapter(cmd);
            gridDt = new DataTable();
            gridAdapter.Fill(srtValue, 20, gridDt);
            dgv.DataSource = gridDt;
            conn.Close();
        }

        public static void GetRight()
        {
            srtValue = srtValue + 20;

            gridDt.Clear();
            gridAdapter.Fill(srtValue, 20, gridDt);
         
        }
        public static void GetLeft()
        {
            srtValue = srtValue - 20;
            if(srtValue <= 0)
            {
                srtValue = 0;
            }
            gridDt.Clear();
            gridAdapter.Fill(srtValue, 20, gridDt);
           
        }

    }
}
