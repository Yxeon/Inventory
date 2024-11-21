using Inventory.Components;
using Inventory.Error_Handler;
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
    public partial class QuestionForm : UserControl
    {
        List<Validator> validators = new List<Validator>();
        Password _password;
        public QuestionForm(Password password)
        {
            _password = password;
            InitializeComponent();

            validators.Add(new Validator(tbPassword, lblPassword, "Question", "required|min:5"));
            validators.Add(new Validator(tbConfirmPassword, lblConfirmPassword, "Answer", "required"));
        }

        public QuestionForm()
        {
            _password = Password.GetPassword();
            InitializeComponent();

            validators.Add(new Validator(tbConfirmPassword, lblConfirmPassword, "Answer", "required"));

            Autofill();
        }

        void Autofill()
        {
            lblTitle.Text = "FORGOT PASSWORD";
            lblAnswer.Text = "ANSWER:";
            lblQuestion.Text = _password.Question + "?";

            lblPassword.Visible = false;
            tbPassword.Visible = false;
            button1.Visible = false;

            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validators.Count((validator) => validator.IsValid()) == validators.Count)
                {
                    DialogResult result = MessageBox.Show("This question will be your recovery password. Continue?", "Password", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _password.Question = tbPassword.Text;
                        _password.Answer = tbConfirmPassword.Text;

                        _password.Save();
                        MessageBox.Show("Password successfully registered");
                        MainForm.LoadForm(new HomeForm());
                    }
                }
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
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
                if (lblPassword.Visible == false)
                {
                    button2_Click(this, new EventArgs());
                }
                else
                {
                    button1_Click(this, new EventArgs());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (validators.Count((validator) => validator.IsValid()) == validators.Count)
                {
                    _password = Password.CheckIfAnswerRight(tbConfirmPassword.Text);
                    if (_password == null )
                    {
                        MessageBox.Show("Incorrect answer!");
                        return;
                    }
                    MainForm.LoadForm(new RegisterForm(_password));
                }
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }
    }
}
