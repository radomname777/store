namespace WinFormsApp1
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.Count_txt = new System.Windows.Forms.Label();
            this.Price_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coca Cola";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ImageCheckBox1
            // 
            this.guna2ImageCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageCheckBox1.CheckedState.Image = global::WinFormsApp1.Properties.Resources.B;
            this.guna2ImageCheckBox1.Image = global::WinFormsApp1.Properties.Resources.check;
            this.guna2ImageCheckBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox1.ImageRotate = 0F;
            this.guna2ImageCheckBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.guna2ImageCheckBox1.Location = new System.Drawing.Point(10, 120);
            this.guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            this.guna2ImageCheckBox1.Size = new System.Drawing.Size(20, 18);
            this.guna2ImageCheckBox1.TabIndex = 3;
            this.guna2ImageCheckBox1.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged);
            // 
            // Count_txt
            // 
            this.Count_txt.AllowDrop = true;
            this.Count_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Count_txt.BackColor = System.Drawing.Color.Transparent;
            this.Count_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Count_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Count_txt.Location = new System.Drawing.Point(36, 120);
            this.Count_txt.Name = "Count_txt";
            this.Count_txt.Size = new System.Drawing.Size(43, 21);
            this.Count_txt.TabIndex = 4;
            this.Count_txt.Text = "100";
            this.Count_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price_txt
            // 
            this.Price_txt.BackColor = System.Drawing.Color.Transparent;
            this.Price_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Price_txt.Location = new System.Drawing.Point(20, 98);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(36, 22);
            this.Price_txt.TabIndex = 5;
            this.Price_txt.Text = "0";
            this.Price_txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(53, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "AZN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Count_txt);
            this.Controls.Add(this.guna2ImageCheckBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Product";
            this.Size = new System.Drawing.Size(103, 144);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public PictureBox pictureBox1;
        public Label label1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
        public Label Count_txt;
        private Label Price_txt;
        private Label label3;
    }
}
