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
using System.Xml.Linq;

namespace Final_Project.Forms
{
    public partial class FormProfile : Form
    {
        MyDiaryDBContext context = new MyDiaryDBContext();

        public FormProfile()
        {
            InitializeComponent();
        }
        /*
        private void btnChangeAvt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png)|*.jpg; *.png";
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filePath);
        }
        */

        private void FormProfile_Load(object sender, EventArgs e)
        {
            loadData();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateProfile f = new FormUpdateProfile();
            f.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            FormProfile formProfile = new FormProfile();
            formProfile.Refresh();
        }

        private void loadData()
        {
            txtUsername.Text = LoginForm.setValueUser;

            User u = context.Users.FirstOrDefault(u => u.Username == txtUsername.Text);

            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", u, "UserId");

            txtFirstName.DataBindings.Clear();
            txtFirstName.DataBindings.Add("Text", u, "FirstName");
            txtLastName.DataBindings.Clear();
            txtLastName.DataBindings.Add("Text", u, "LastName");
            string gen = "Male";
            if (!u.Gender)
            {
                gen = "FeMale";
            }
            txtGender.Text = gen;
            txtDob.DataBindings.Clear();
            txtDob.DataBindings.Add("Text", u, "Dob");
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
    }
}
