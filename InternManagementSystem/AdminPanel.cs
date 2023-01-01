using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternManagementSystem
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

      

      
        public void Display()
        {
            DatabaseConnection.DisplayAndSearch("select id,name,phone from intern", dataGridView);
        }

        private void AdminPanel_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            DatabaseConnection.DisplayAndSearch("select id,name,phone from intern where name like '%"+searchBox.Text.Trim() + "%'", dataGridView);
        }

        private void add_intern_btn_Click(object sender, EventArgs e)
        {
            AddIntern addIntern = new AddIntern();
            this.Hide();
            addIntern.Show();
        }

        private void right_btn_Click(object sender, EventArgs e)
        {

            DatabaseConnection.GetRight();
        }

        private void left_btn_Click(object sender, EventArgs e)
        {

            DatabaseConnection.GetLeft();
        }

    }
}
