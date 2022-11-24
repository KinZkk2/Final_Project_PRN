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
    public partial class FormFavorite : Form
    {
        public FormFavorite()
        {
            InitializeComponent();
        }
        MyDiaryDBContext context = new MyDiaryDBContext();
        private void FormFavorite_Load(object sender, EventArgs e)
        {
            //var data = FormDiary.list.Select(d => new
            //{
            //    DiaryId = d.DiaryId,
            //    Title = d.Title,
            //    Contents = d.Contents,
            //    Date = d.Date 
            //}).ToList();

            //dgFavorite.DataSource = data;

            int id = context.Users.FirstOrDefault(item => item.Username == LoginForm.setValueUser).UserId;

            var data = context.Diaries.Where(item => item.UserId == id).Where(item => item.Favorite == true).Select(item => new
            {
                DiaryId = item.DiaryId,
                Title = item.Title,
                Content = item.Contents,
                Date = item.Date,
            }).ToList();

            dgFavorite.DataSource = data;   
        }
    }
}
