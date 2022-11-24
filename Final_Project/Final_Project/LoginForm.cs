using Final_Project.Forms;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class LoginForm : Form
    {
        public static string setValueUser = "";
        public LoginForm()
        {
            InitializeComponent();
        }
        MyDiaryDBContext context = new MyDiaryDBContext();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
              
                if(context.Users.Where(u => u.Username == txtUsername.Text 
                                         && u.Password == txtPassword.Text).Count()>0)
                {
                    MessageBox.Show("Login Successfully! ");
                    setValueUser = txtUsername.Text;
                    HomeForm hf = new HomeForm();
                    hf.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect. Please try again!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                SignUpForm form = new SignUpForm();
                form.Show();
                this.Hide();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
