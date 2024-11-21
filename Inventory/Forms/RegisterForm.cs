using Inventory.Components;
using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class RegisterForm : UserControl
    {
        Password _password;
        List<Validator> validators = new List<Validator>();
        public RegisterForm()
        {
            InitializeComponent();
            validators.Add(new Validator(tbPassword, lblPassword, "Password", "required|min:8"));
            validators.Add(new Validator(tbConfirmPassword, lblConfirmPassword, "Confirm Password", "required|min:8|compare") { compare_control = tbPassword });
        }

        public RegisterForm(Password password)
        {
            this._password = password;
            InitializeComponent();
            validators.Add(new Validator(tbPassword, lblPassword, "Password", "required|min:8"));
            validators.Add(new Validator(tbConfirmPassword, lblConfirmPassword, "Confirm Password", "required|min:8|compare") { compare_control = tbPassword });
            Autofill();
        }

        void Autofill()
        {
            lblTitle.Text = "SET NEW PASSWORD";
            label1.Text = "Enter new password";
            label2.Text = "Confirm new password";

            button1.Visible = false;
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validators.Count == validators.Count(validator => validator.IsValid()))
            {
                var User = new Password
                {
                    Pass = tbPassword.Text
                };
                MainForm.LoadForm(new QuestionForm(User));
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void tbConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (button2.Enabled == false)
                {
                    button1_Click(this, new EventArgs());
                }
                else
                {
                    button2_Click(this, new EventArgs());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validators.Count == validators.Count(validator => validator.IsValid()))
            {
                _password.Pass = tbPassword.Text;
                _password.Update();

                MessageBox.Show("Password successfully updated!");
                MainForm.LoadForm(new LoginForm());
            }
        }
    }
}
