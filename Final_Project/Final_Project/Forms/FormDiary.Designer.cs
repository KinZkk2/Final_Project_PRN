namespace Final_Project.Forms
{
    partial class FormDiary
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
            this.panelDiary = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.dgDiary = new System.Windows.Forms.DataGridView();
            this.panelDiary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiary)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDiary
            // 
            this.panelDiary.Controls.Add(this.btnReload);
            this.panelDiary.Controls.Add(this.lbUsername);
            this.panelDiary.Controls.Add(this.label1);
            this.panelDiary.Controls.Add(this.btnDelete);
            this.panelDiary.Controls.Add(this.btnDetail);
            this.panelDiary.Controls.Add(this.dgDiary);
            this.panelDiary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiary.Location = new System.Drawing.Point(0, 0);
            this.panelDiary.Name = "panelDiary";
            this.panelDiary.Size = new System.Drawing.Size(946, 583);
            this.panelDiary.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(16, 538);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(94, 29);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(73, 478);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(75, 20);
            this.lbUsername.TabIndex = 10;
            this.lbUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Author: ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(302, 507);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 60);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(512, 507);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(139, 60);
            this.btnDetail.TabIndex = 7;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // dgDiary
            // 
            this.dgDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiary.Location = new System.Drawing.Point(0, 0);
            this.dgDiary.Name = "dgDiary";
            this.dgDiary.RowHeadersWidth = 51;
            this.dgDiary.RowTemplate.Height = 29;
            this.dgDiary.Size = new System.Drawing.Size(946, 475);
            this.dgDiary.TabIndex = 6;
            this.dgDiary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDiary_CellContentClick);
            // 
            // FormDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 583);
            this.Controls.Add(this.panelDiary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiary";
            this.Text = "FormDiary";
            this.Load += new System.EventHandler(this.FormDiary_Load);
            this.panelDiary.ResumeLayout(false);
            this.panelDiary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDiary;
        private Label lbUsername;
        private Label label1;
        private Button btnDelete;
        private Button btnDetail;
        private DataGridView dgDiary;
        private Button btnReload;
    }
}