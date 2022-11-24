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

namespace Final_Project.Forms
{
    public partial class FormDiary : Form
    {
        MyDiaryDBContext context = new MyDiaryDBContext();
        public static int setIdValue = 0;
        public static List<Diary> list = new List<Diary>();

        public FormDiary()
        {
            InitializeComponent();
        }

        private void FormDiary_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            lbUsername.Text = LoginForm.setValueUser;
            int id = context.Users.FirstOrDefault(u => u.Username == lbUsername.Text).UserId;

            var data = context.Diaries.Where(item => item.UserId == id).Select(item => new
            {
                DiaryId = item.DiaryId,
                Title = item.Title,
                Content = item.Contents,
                Date = item.Date,
                Favorite = item.Favorite,
            }).ToList();
            dgDiary.DataSource = data;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgDiary.CurrentCell.RowIndex;
                int id = Int32.Parse(dgDiary.Rows[row].Cells[0].FormattedValue.ToString());
                Diary d = context.Diaries.FirstOrDefault(item => item.DiaryId == id);

                if (d != null)
                {
                    context.Diaries.Remove(d);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Delete success!");
                        loadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message, "Error");
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int row = dgDiary.CurrentCell.RowIndex;
            int id = Int32.Parse(dgDiary.Rows[row].Cells[0].FormattedValue.ToString());
            setIdValue = id;

            FormUpdate f = new FormUpdate();
            f.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }


        private void dgDiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgDiary.Rows[e.RowIndex];

            viewRow.Cells["Favorite"].Value = Convert.ToBoolean(viewRow.Cells["Favorite"].EditedFormattedValue);
            //int row = dgDiary.CurrentCell.RowIndex;
            int id = Int32.Parse(viewRow.Cells[0].FormattedValue.ToString());
            Diary d = context.Diaries.FirstOrDefault(item => item.DiaryId == id);
            bool fa = Boolean.Parse(viewRow.Cells[4].FormattedValue.ToString());

            try
            {
                if (d != null)
                {
                    //d.Favorite = fa;
                    if (fa == false)
                    {
                        d.Favorite = true;
                        context.Diaries.Update(d);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Add diary to Favorite");
                            loadData();
                        }
                    }
                    else
                    {
                        d.Favorite = false;
                        context.Diaries.Update(d);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Remove diary to Favorite");
                            loadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

