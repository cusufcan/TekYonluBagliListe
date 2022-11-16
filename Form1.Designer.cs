namespace VizeCalismaProje
{
    partial class Form1
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
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txtBox_No = new System.Windows.Forms.TextBox();
            this.txtBox_Ad = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_ListeYazdir = new System.Windows.Forms.Button();
            this.dGridView_Yazdir = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Yazdir)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ekle.Location = new System.Drawing.Point(168, 12);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(100, 50);
            this.btn_Ekle.TabIndex = 0;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txtBox_No
            // 
            this.txtBox_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_No.Location = new System.Drawing.Point(12, 12);
            this.txtBox_No.Multiline = true;
            this.txtBox_No.Name = "txtBox_No";
            this.txtBox_No.Size = new System.Drawing.Size(150, 50);
            this.txtBox_No.TabIndex = 1;
            // 
            // txtBox_Ad
            // 
            this.txtBox_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Ad.Location = new System.Drawing.Point(12, 68);
            this.txtBox_Ad.Multiline = true;
            this.txtBox_Ad.Name = "txtBox_Ad";
            this.txtBox_Ad.Size = new System.Drawing.Size(150, 50);
            this.txtBox_Ad.TabIndex = 2;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sil.Location = new System.Drawing.Point(274, 12);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(100, 50);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_ListeYazdir
            // 
            this.btn_ListeYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListeYazdir.Location = new System.Drawing.Point(168, 68);
            this.btn_ListeYazdir.Name = "btn_ListeYazdir";
            this.btn_ListeYazdir.Size = new System.Drawing.Size(206, 50);
            this.btn_ListeYazdir.TabIndex = 5;
            this.btn_ListeYazdir.Text = "Yazdır";
            this.btn_ListeYazdir.UseVisualStyleBackColor = true;
            this.btn_ListeYazdir.Click += new System.EventHandler(this.btn_ListeYazdir_Click);
            // 
            // dGridView_Yazdir
            // 
            this.dGridView_Yazdir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_Yazdir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.name});
            this.dGridView_Yazdir.Location = new System.Drawing.Point(12, 124);
            this.dGridView_Yazdir.Name = "dGridView_Yazdir";
            this.dGridView_Yazdir.Size = new System.Drawing.Size(360, 280);
            this.dGridView_Yazdir.TabIndex = 6;
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.no.HeaderText = "Number";
            this.no.Name = "no";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 416);
            this.Controls.Add(this.dGridView_Yazdir);
            this.Controls.Add(this.btn_ListeYazdir);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.txtBox_Ad);
            this.Controls.Add(this.txtBox_No);
            this.Controls.Add(this.btn_Ekle);
            this.Name = "Form1";
            this.Text = "Tek Yönlü Bağlı Liste";
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Yazdir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txtBox_No;
        private System.Windows.Forms.TextBox txtBox_Ad;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_ListeYazdir;
        private System.Windows.Forms.DataGridView dGridView_Yazdir;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}

