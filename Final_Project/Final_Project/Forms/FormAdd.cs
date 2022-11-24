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
    public partial class FormAdd : Form
    {

        public FormAdd()
        {
            InitializeComponent();
            
        }
        MyDiaryDBContext context = new MyDiaryDBContext();

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtContent.Text = "";
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            lbName.Text = LoginForm.setValueUser;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int id = context.Users.FirstOrDefault(u => u.Username == lbName.Text).UserId;

                Diary d = new Diary
                {
                    Title = txtTitle.Text,
                    Contents = txtContent.Text,
                    Date = dateWrite.Value,
                    UserId = id
                };

                if (d != null)
                {
                    ValidationContext validationContext = new ValidationContext(d, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(d, validationContext, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                context.Diaries.Add(d);
                if(context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add Success " + id);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.InnerException.Message + "ID: ");
            }
        }
    }
}
