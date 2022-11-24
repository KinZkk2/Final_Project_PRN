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

namespace Final_Project.Forms
{
    public partial class FormUpdateProfile : Form
    {
        MyDiaryDBContext context = new MyDiaryDBContext();
        DataProvider d = new DataProvider();
        public FormUpdateProfile()
        {
            InitializeComponent();
        }

        private void FormUpdateProfile_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            User u = context.Users.FirstOrDefault(u=>u.Username == LoginForm.setValueUser);

            txtFirstName.DataBindings.Clear();
            txtFirstName.DataBindings.Add("Text", u, "FirstName");
            txtLastName.DataBindings.Clear();
            txtLastName.DataBindings.Add("Text", u, "LastName");
            if (u.Gender)
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
            dateDob.DataBindings.Clear();
            dateDob.DataBindings.Add("Text", u, "Dob");
            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add("Text", u, "Address");
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", u, "Phone");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", u, "Email");
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", u, "Password");

            if (u.Image != null)
            {
                pictureBox1.Image = Image.FromFile(u.Image);
            }
            else
            {
                pictureBox1.Image = Image.FromFile("D:\\University\\5.Fall22\\PRN211\\CODE\\Final_Project\\Final_Project\\Resources\\Avatar-trang-den.png");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = context.Users.FirstOrDefault(u=>u.Username == LoginForm.setValueUser);

            try
            {
                bool gender = true;
                if (rdFemale.Checked)
                {
                    gender = false;
                }
                if (user != null)
                {
                    user.FirstName = txtFirstName.Text;
                    user.LastName = txtLastName.Text;
                    user.Gender = gender;
                    user.Email = txtEmail.Text;
                    user.Address = txtAddress.Text;
                    user.Dob = dateDob.Value;
                    user.Phone = txtPhone.Text;
                    user.Password = txtPassword.Text;
                    user.Image = openFileDialog1.FileName;
                    if (user != null)
                    {
                        ValidationContext validationContext = new ValidationContext(user, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(user, validationContext, errors, true))
                        {
                            foreach (ValidationResult result in errors)
                            {
                                MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update Success");
                        loadData();
                    }
                }
                else
                {
                    MessageBox.Show("Update fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnChangeAvt_Click(object sender, EventArgs e)
        {
            User user = new User();

            openFileDialog1.Filter = "Select image(*.jpg; *.png)|*.jpg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
