namespace Final_Project.Forms
{
    partial class FormFavorite
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
            this.dgFavorite = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFavorite
            // 
            this.dgFavorite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFavorite.Location = new System.Drawing.Point(51, 32);
            this.dgFavorite.Name = "dgFavorite";
            this.dgFavorite.RowHeadersWidth = 51;
            this.dgFavorite.RowTemplate.Height = 29;
            this.dgFavorite.Size = new System.Drawing.Size(739, 391);
            this.dgFavorite.TabIndex = 0;
            // 
            // FormFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 553);
            this.Controls.Add(this.dgFavorite);
            this.Name = "FormFavorite";
            this.Text = "FormFavorite";
            this.Load += new System.EventHandler(this.FormFavorite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFavorite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgFavorite;
    }
}