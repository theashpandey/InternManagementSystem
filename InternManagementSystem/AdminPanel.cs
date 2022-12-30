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

      

        private void addIntern_btn_Click(object sender, EventArgs e)
        {
            AddIntern addIntern = new AddIntern();
            this.Hide();
            addIntern.Show();
        }
        public void Display()
        {
            DatabaseConnection.DisplayAndSearch("select id,name,phone from intern", dataGridView);
        }

        private void AdminPanel_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void gridLeft_Btn_Click(object sender, EventArgs e)
        {
            DatabaseConnection.GetLeft();
        }

        private void gridright_btn_Click(object sender, EventArgs e)
        {
            DatabaseConnection.GetRight();
        }
    }
}
