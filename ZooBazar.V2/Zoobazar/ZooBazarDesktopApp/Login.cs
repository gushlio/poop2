﻿using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using Domain.Manager;

namespace ZooBazarDesktopApp
{
    public partial class Login : Form
    {
        private EmployeeManager employeeManager;
        public Login()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (employeeManager.ValidateLogin(email, password))
            {
                employeeManager.OpenForm(email);
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }
    }
}
