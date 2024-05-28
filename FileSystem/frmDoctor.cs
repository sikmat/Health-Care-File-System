﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSystem.UserControls;

namespace FileSystem
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
            UC_Patient patient = new UC_Patient();
            addUserControl(patient);

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        DataTable dt = frmLogin.dtInfo;
        private void frmDoctor_Load(object sender, EventArgs e)
        {
            lblDetails.Text = dt.Rows[0]["surname"].ToString() + " " + dt.Rows[0]["name"].ToString();
            lblRole.Text = "(" + dt.Rows[0]["role_name"].ToString() + ")";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
