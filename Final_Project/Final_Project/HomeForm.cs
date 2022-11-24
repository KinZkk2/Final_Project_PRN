using Final_Project.Models;

namespace Final_Project
{
    public partial class HomeForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        private string username;
        MyDiaryDBContext context = new MyDiaryDBContext();
        public HomeForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(38, 41, 99);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()    
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    //previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdd(), sender);
        }

        private void btnDiary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDiary(), sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProfile(), sender);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if (MessageBox.Show(this, "Do you want to sign out?", "Sign Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                loginForm.Show();
                this.Hide();
            }
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public HomeForm(string user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //label4.Text = username;
            loadData();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            User u = context.Users.FirstOrDefault(u => u.Username == LoginForm.setValueUser);

            if (u.Image != null)
            {
                picAvatar.Image = Image.FromFile(u.Image);
            }
            else
            {
                picAvatar.Image = Image.FromFile("D:\\University\\5.Fall22\\PRN211\\CODE\\Final_Project\\Final_Project\\Resources\\Avatar-trang-den.png");
            }

            lbName.Text = u.FirstName + " " + u.LastName;
        }

        private void btnFavou_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFavorite(), sender);
        }
    }
}