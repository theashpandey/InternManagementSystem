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
    public partial class AddIntern : Form
    {
        public AddIntern()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            nameBox.Text = emailBox.Text = phoneBox.Text = dobBox.Text = internRoleBox.Text = skillsBox.Text = String.Empty;
        }

        private void phoneBox_Leave(object sender, EventArgs e)
        {
            if (phoneBox.Text == "")
            {
                phoneBox.Text = "Enter Your Phone";
                phoneBox.ForeColor = Color.DimGray;
            }
        }

        private void phoneBox_Enter(object sender, EventArgs e)
        {
            if (phoneBox.Text == "Enter Your Phone")
            {
                phoneBox.Text = "";
                phoneBox.ForeColor = Color.Black;
            }
        }
        private void internRoleBox_Leave(object sender, EventArgs e)
        {
            if (internRoleBox.Text == "")
            {
                internRoleBox.Text = "Selected Role";
                internRoleBox.ForeColor = Color.DimGray;
            }
        }

        private void internRoleBox_Enter(object sender, EventArgs e)
        {
            if (internRoleBox.Text == "Selected Role")
            {
                internRoleBox.Text = "";
                internRoleBox.ForeColor = Color.Black;
            }
        }

        private void skillsBox_Leave(object sender, EventArgs e)
        {
            if (skillsBox.Text == "")
            {
                skillsBox.Text = "Enter Your Skills";
                skillsBox.ForeColor = Color.DimGray;
            }
        }

        private void skillsBox_Enter(object sender, EventArgs e)
        {
            if (skillsBox.Text == "Enter Your Skills")
            {
                skillsBox.Text = "";
                skillsBox.ForeColor = Color.Black;
            }
        }

        private void emailBox_Leave(object sender, EventArgs e)
        {
            if (emailBox.Text == "")
            {
                emailBox.Text = "Enter Your Email";
                emailBox.ForeColor = Color.DimGray;
            }
        }

        private void emailBox_Enter(object sender, EventArgs e)
        {
            if (emailBox.Text == "Enter Your Email")
            {
                emailBox.Text = "";
                emailBox.ForeColor = Color.Black;
            }
        }
        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                nameBox.Text = "Enter Your Name";
                nameBox.ForeColor = Color.DimGray;
            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Enter Your Name")
            {
                nameBox.Text = "";
                nameBox.ForeColor = Color.Black;
            }
        }
       
        private void addIntern_btn_Click(object sender, EventArgs e)
        {
        
            Intern intern = new Intern(nameBox.Text.Trim(), emailBox.Text.Trim(), phoneBox.Text.Trim(), dobBox.Value, internRoleBox.Text.Trim(), skillsBox.Text.Trim());
            DatabaseConnection.addIntern(intern);
            Clear();
        }

        private void internImageBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Files(*.png)|*.png|JPG Files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String imgLocation = openFileDialog.FileName;
                internImageBox.ImageLocation = imgLocation;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
            adminPanel.Show();
        }
    }
}
