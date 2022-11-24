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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }
        MyDiaryDBContext context = new MyDiaryDBContext();
        private void FormUpdate_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            lbId.Text = FormDiary.setIdValue.ToString();
            lbName.Text = LoginForm.setValueUser;

            Diary d = context.Diaries.FirstOrDefault(d => d.DiaryId == FormDiary.setIdValue);

            txtTitle.DataBindings.Clear();
            txtTitle.DataBindings.Add("Text", d, "Title");
            txtContent.DataBindings.Clear();
            txtContent.DataBindings.Add("Text", d, "Contents");
            dateWrite.DataBindings.Clear();
            dateWrite.DataBindings.Add("Text", d, "Date");
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Diary d = context.Diaries.FirstOrDefault(d => d.DiaryId == FormDiary.setIdValue);

            try
            {
                if (d != null)
                {
                    d.Title = txtTitle.Text;
                    d.Contents = txtContent.Text;
                    d.Date = dateWrite.Value;

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

                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update success");
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
    }
}
