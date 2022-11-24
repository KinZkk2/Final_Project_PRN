namespace Final_Project.Forms
{
    partial class FormUpdateProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelProfileDetail = new System.Windows.Forms.Panel();
            this.btnChangeAvt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelProfileDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProfileDetail
            // 
            this.panelProfileDetail.BackColor = System.Drawing.SystemColors.Control;
            this.panelProfileDetail.Controls.Add(this.btnChangeAvt);
            this.panelProfileDetail.Controls.Add(this.pictureBox1);
            this.panelProfileDetail.Controls.Add(this.btnCancel);
            this.panelProfileDetail.Controls.Add(this.btnUpdate);
            this.panelProfileDetail.Controls.Add(this.rdFemale);
            this.panelProfileDetail.Controls.Add(this.rdMale);
            this.panelProfileDetail.Controls.Add(this.panel11);
            this.panelProfileDetail.Controls.Add(this.label15);
            this.panelProfileDetail.Controls.Add(this.panel10);
            this.panelProfileDetail.Controls.Add(this.label14);
            this.panelProfileDetail.Controls.Add(this.panel9);
            this.panelProfileDetail.Controls.Add(this.label13);
            this.panelProfileDetail.Controls.Add(this.panel8);
            this.panelProfileDetail.Controls.Add(this.label12);
            this.panelProfileDetail.Controls.Add(this.label11);
            this.panelProfileDetail.Controls.Add(this.panel6);
            this.panelProfileDetail.Controls.Add(this.label10);
            this.panelProfileDetail.Controls.Add(this.panel5);
            this.panelProfileDetail.Controls.Add(this.label9);
            this.panelProfileDetail.Controls.Add(this.panel4);
            this.panelProfileDetail.Controls.Add(this.label8);
            this.panelProfileDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfileDetail.Location = new System.Drawing.Point(0, 0);
            this.panelProfileDetail.Name = "panelProfileDetail";
            this.panelProfileDetail.Size = new System.Drawing.Size(980, 450);
            this.panelProfileDetail.TabIndex = 3;
            // 
            // btnChangeAvt
            // 
            this.btnChangeAvt.Location = new System.Drawing.Point(68, 184);
            this.btnChangeAvt.Name = "btnChangeAvt";
            this.btnChangeAvt.Size = new System.Drawing.Size(139, 30);
            this.btnChangeAvt.TabIndex = 54;
            this.btnChangeAvt.Text = "Choose Avatar";
            this.btnChangeAvt.UseVisualStyleBackColor = true;
            this.btnChangeAvt.Click += new System.EventHandler(this.btnChangeAvt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(669, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(556, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(556, 127);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(78, 24);
            this.rdFemale.TabIndex = 50;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(426, 127);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(63, 24);
            this.rdMale.TabIndex = 49;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.txtPassword);
            this.panel11.Location = new System.Drawing.Point(426, 343);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(496, 34);
            this.panel11.TabIndex = 48;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(3, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(490, 21);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label15.Location = new System.Drawing.Point(266, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 23);
            this.label15.TabIndex = 47;
            this.label15.Text = "Password:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.txtPhone);
            this.panel10.Location = new System.Drawing.Point(426, 297);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(496, 34);
            this.panel10.TabIndex = 46;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(3, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(490, 21);
            this.txtPhone.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label14.Location = new System.Drawing.Point(266, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 23);
            this.label14.TabIndex = 45;
            this.label14.Text = "Phone:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.txtEmail);
            this.panel9.Location = new System.Drawing.Point(426, 253);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(496, 34);
            this.panel9.TabIndex = 44;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(3, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(490, 21);
            this.txtEmail.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label13.Location = new System.Drawing.Point(266, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 23);
            this.label13.TabIndex = 43;
            this.label13.Text = "Email:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.txtAddress);
            this.panel8.Location = new System.Drawing.Point(426, 211);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(496, 34);
            this.panel8.TabIndex = 42;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(3, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.Size = new System.Drawing.Size(490, 21);
            this.txtAddress.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label12.Location = new System.Drawing.Point(266, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 23);
            this.label12.TabIndex = 41;
            this.label12.Text = "Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(266, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 23);
            this.label11.TabIndex = 40;
            this.label11.Text = "Date of Birth:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dateDob);
            this.panel6.Location = new System.Drawing.Point(426, 171);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(496, 34);
            this.panel6.TabIndex = 39;
            // 
            // dateDob
            // 
            this.dateDob.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDob.CustomFormat = "dd/MM/yyyy";
            this.dateDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDob.Location = new System.Drawing.Point(0, 4);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(493, 27);
            this.dateDob.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label10.Location = new System.Drawing.Point(266, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "Gender:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.txtLastName);
            this.panel5.Location = new System.Drawing.Point(426, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(496, 34);
            this.panel5.TabIndex = 37;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(3, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(490, 21);
            this.txtLastName.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label9.Location = new System.Drawing.Point(266, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "Last Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtFirstName);
            this.panel4.Location = new System.Drawing.Point(426, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(496, 34);
            this.panel4.TabIndex = 35;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(3, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(490, 21);
            this.txtFirstName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label8.Location = new System.Drawing.Point(266, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "First Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.panelProfileDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateProfile";
            this.Text = "FormUpdateProfile";
            this.Load += new System.EventHandler(this.FormUpdateProfile_Load);
            this.panelProfileDetail.ResumeLayout(false);
            this.panelProfileDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelProfileDetail;
        private Button btnUpdate;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Panel panel11;
        private TextBox txtPassword;
        private Label label15;
        private Panel panel10;
        private TextBox txtPhone;
        private Label label14;
        private Panel panel9;
        private TextBox txtEmail;
        private Label label13;
        private Panel panel8;
        private TextBox txtAddress;
        private Label label12;
        private Label label11;
        private Panel panel6;
        private DateTimePicker dateDob;
        private Label label10;
        private Panel panel5;
        private TextBox txtLastName;
        private Label label9;
        private Panel panel4;
        private TextBox txtFirstName;
        private Label label8;
        private Button btnCancel;
        private Button btnChangeAvt;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}