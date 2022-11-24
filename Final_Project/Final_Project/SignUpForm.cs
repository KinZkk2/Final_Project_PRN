using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        MyDiaryDBContext context = new MyDiaryDBContext();
        DataProvider d = new DataProvider();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                bool gen = true;
                if (rdFemale.Checked)
               {
                    gen = false;
                }
                User u = new User
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Dob = dateDob.Value,
                    Gender = gen
                };
                if (u != null)
                {
                    ValidationContext validationContext = new ValidationContext(u, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(u, validationContext, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                //string username = "";
                string strSelect = "select * from Users where Username = '" + txtUsername.Text + "'";
                DataTable dt = d.executeQuery(strSelect);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username already used");
                }
                else
                {
                    context.Users.Add(u);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Sign Up Success!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm l = new LoginForm();
                l.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
