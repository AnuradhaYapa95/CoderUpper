﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RemvCourses : Form
    {
        public RemvCourses()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Exit the Program?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Course01 c1 = new Course01();
            c1.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int courseID = int.Parse(bunifuMaterialTextbox3.Text);

            String del = "DELETE FROM  Course where CourseID =" + courseID + "";

            DatabaseConnection dbc = new DatabaseConnection();
            string feedback = dbc.DBConnection(del);

            MessageBox.Show(feedback);
            bunifuMaterialTextbox3.Text = "";
        }

        private void RemvCourses_Load(object sender, EventArgs e)
        {

        }
    }
}
