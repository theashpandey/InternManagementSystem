using System.Windows.Forms;

namespace InternManagementSystem
{
    partial class AddIntern
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIntern));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.internRoleBox = new System.Windows.Forms.ComboBox();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skillsBox = new System.Windows.Forms.TextBox();
            this.internImageBox = new System.Windows.Forms.PictureBox();
            this.addIntern_btn = new System.Windows.Forms.Button();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(159)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 60);
            this.panel1.TabIndex = 1;
            // 
            // back_btn
            // 
            this.back_btn.BackgroundImage = global::InternManagementSystem.Properties.Resources.icons8_back_arrow_48__1_;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(159)))), ((int)(((byte)(143)))));
            this.back_btn.Location = new System.Drawing.Point(12, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(48, 48);
            this.back_btn.TabIndex = 1;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Intern";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.internRoleBox);
            this.panel2.Controls.Add(this.dobBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.skillsBox);
            this.panel2.Controls.Add(this.internImageBox);
            this.panel2.Controls.Add(this.addIntern_btn);
            this.panel2.Controls.Add(this.phoneBox);
            this.panel2.Controls.Add(this.emailBox);
            this.panel2.Controls.Add(this.nameBox);
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 550);
            this.panel2.TabIndex = 2;
            // 
            // internRoleBox
            // 
            this.internRoleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.internRoleBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internRoleBox.ForeColor = System.Drawing.Color.Black;
            this.internRoleBox.FormattingEnabled = true;
            this.internRoleBox.Items.AddRange(new object[] {
            "Web Developer",
            "Full Stack Developer",
            "Front End Developer"});
            this.internRoleBox.Location = new System.Drawing.Point(325, 339);
            this.internRoleBox.Name = "internRoleBox";
            this.internRoleBox.Size = new System.Drawing.Size(209, 22);
            this.internRoleBox.TabIndex = 19;
            this.internRoleBox.Text = "Selected Role";
            this.internRoleBox.Enter += new System.EventHandler(this.internRoleBox_Enter);
            this.internRoleBox.Leave += new System.EventHandler(this.internRoleBox_Leave);
            // 
            // dobBox
            // 
            this.dobBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobBox.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dobBox.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dobBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobBox.Location = new System.Drawing.Point(632, 267);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(209, 22);
            this.dobBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(629, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "DoB:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(629, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Skills:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Intern Role:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // skillsBox
            // 
            this.skillsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skillsBox.BackColor = System.Drawing.Color.White;
            this.skillsBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillsBox.ForeColor = System.Drawing.Color.DimGray;
            this.skillsBox.Location = new System.Drawing.Point(632, 338);
            this.skillsBox.Name = "skillsBox";
            this.skillsBox.Size = new System.Drawing.Size(209, 22);
            this.skillsBox.TabIndex = 9;
            this.skillsBox.Text = "Enter Your Skills";
            this.skillsBox.Enter += new System.EventHandler(this.skillsBox_Enter);
            this.skillsBox.Leave += new System.EventHandler(this.skillsBox_Leave);
            // 
            // internImageBox
            // 
            this.internImageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.internImageBox.Image = global::InternManagementSystem.Properties.Resources.icons8_user_100;
            this.internImageBox.Location = new System.Drawing.Point(133, 48);
            this.internImageBox.Name = "internImageBox";
            this.internImageBox.Size = new System.Drawing.Size(136, 133);
            this.internImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.internImageBox.TabIndex = 8;
            this.internImageBox.TabStop = false;
            this.internImageBox.Click += new System.EventHandler(this.internImageBox_Click);
            // 
            // addIntern_btn
            // 
            this.addIntern_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIntern_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(159)))), ((int)(((byte)(143)))));
            this.addIntern_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIntern_btn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIntern_btn.ForeColor = System.Drawing.Color.White;
            this.addIntern_btn.Location = new System.Drawing.Point(705, 427);
            this.addIntern_btn.Name = "addIntern_btn";
            this.addIntern_btn.Size = new System.Drawing.Size(136, 30);
            this.addIntern_btn.TabIndex = 7;
            this.addIntern_btn.Text = "Submit";
            this.addIntern_btn.UseVisualStyleBackColor = false;
            this.addIntern_btn.Click += new System.EventHandler(this.addIntern_btn_Click);
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneBox.BackColor = System.Drawing.Color.White;
            this.phoneBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.Color.DimGray;
            this.phoneBox.Location = new System.Drawing.Point(325, 265);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(209, 22);
            this.phoneBox.TabIndex = 6;
            this.phoneBox.Text = "Enter Your Phone";
            this.phoneBox.Enter += new System.EventHandler(this.phoneBox_Enter);
            this.phoneBox.Leave += new System.EventHandler(this.phoneBox_Leave);
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailBox.BackColor = System.Drawing.Color.White;
            this.emailBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.DimGray;
            this.emailBox.Location = new System.Drawing.Point(632, 197);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(209, 22);
            this.emailBox.TabIndex = 4;
            this.emailBox.Text = "Enter Your Email";
            this.emailBox.Enter += new System.EventHandler(this.emailBox_Enter);
            this.emailBox.Leave += new System.EventHandler(this.emailBox_Leave);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.DimGray;
            this.nameBox.Location = new System.Drawing.Point(325, 197);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(209, 22);
            this.nameBox.TabIndex = 0;
            this.nameBox.Tag = "";
            this.nameBox.Text = "Enter Your Name";
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // AddIntern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddIntern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Intern";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addIntern_btn;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.PictureBox internImageBox;
        private System.Windows.Forms.DateTimePicker dobBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skillsBox;
        private System.Windows.Forms.ComboBox internRoleBox;
        private System.Windows.Forms.Button back_btn;
    }
}