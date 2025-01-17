﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aru_software_eng_UI
{
    public partial class IdeaGeneratorLogin : Form
    {
        FormManager manager;
        Form next_window;
        BackendController backend_controller;
        public IdeaGeneratorLogin(Form n_previous_window)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = BackendController.getInstance();
        }
        private void IG_Back_Button_Click(object sender, EventArgs e)
        {
            manager.back();
        }
        private void IG_login_button_Click(object sender, EventArgs e)
        {
            // Get username  
            string username = IG_login_textbox.Text;
            // Get password
            string password = IG_password_textbox.Text;
            DataBaseLoginEntry loginEntry = backend_controller.loginSearchUsername(username);
            if ((loginEntry.getEmail() == username || loginEntry.getUsername() == username) && loginEntry.getPassword() == password)
            {
                // redirect to Idea Submitter page
                next_window = new IdeaSubmitterForm(this, loginEntry);
            }
            else
            {
                MessageBox.Show("Incorrect login, please try again");
            }
        }
        private void IG_login_textbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(IG_login_textbox.Text))
            {
                e.Cancel = true;
                IG_login_textbox.Focus();
                errorProvider1.SetError(IG_login_textbox, "Please enter your username: ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(IG_login_textbox, null);
            }
        }
    }
}
