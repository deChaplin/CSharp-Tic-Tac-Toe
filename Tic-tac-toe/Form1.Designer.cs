namespace Tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl00 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 506);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl00
            // 
            this.lbl00.AutoSize = true;
            this.lbl00.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl00.Location = new System.Drawing.Point(15, 24);
            this.lbl00.Name = "lbl00";
            this.lbl00.Size = new System.Drawing.Size(123, 133);
            this.lbl00.TabIndex = 1;
            this.lbl00.Text = "X";
            this.lbl00.Click += new System.EventHandler(this.lbl00_Click);
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl01.Location = new System.Drawing.Point(185, 24);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(123, 133);
            this.lbl01.TabIndex = 2;
            this.lbl01.Text = "X";
            this.lbl01.Click += new System.EventHandler(this.lbl01_Click);
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl11.Location = new System.Drawing.Point(185, 197);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(123, 133);
            this.lbl11.TabIndex = 3;
            this.lbl11.Text = "X";
            this.lbl11.Click += new System.EventHandler(this.lbl11_Click);
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl21.Location = new System.Drawing.Point(185, 360);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(123, 133);
            this.lbl21.TabIndex = 4;
            this.lbl21.Text = "X";
            this.lbl21.Click += new System.EventHandler(this.lbl21_Click);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl10.Location = new System.Drawing.Point(15, 197);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(123, 133);
            this.lbl10.TabIndex = 5;
            this.lbl10.Text = "X";
            this.lbl10.Click += new System.EventHandler(this.lbl10_Click);
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl20.Location = new System.Drawing.Point(15, 360);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(123, 133);
            this.lbl20.TabIndex = 6;
            this.lbl20.Text = "X";
            this.lbl20.Click += new System.EventHandler(this.lbl20_Click);
            // 
            // lbl22
            // 
            this.lbl22.AutoSize = true;
            this.lbl22.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl22.Location = new System.Drawing.Point(358, 360);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(123, 133);
            this.lbl22.TabIndex = 7;
            this.lbl22.Text = "X";
            this.lbl22.Click += new System.EventHandler(this.lbl22_Click);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl12.Location = new System.Drawing.Point(358, 197);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(123, 133);
            this.lbl12.TabIndex = 8;
            this.lbl12.Text = "X";
            this.lbl12.Click += new System.EventHandler(this.lbl12_Click);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl02.Location = new System.Drawing.Point(358, 24);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(123, 133);
            this.lbl02.TabIndex = 9;
            this.lbl02.Text = "X";
            this.lbl02.Click += new System.EventHandler(this.lbl02_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinner.Location = new System.Drawing.Point(15, 522);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 89);
            this.lblWinner.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 620);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lbl00);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl00;
        private Label lbl01;
        private Label lbl11;
        private Label lbl21;
        private Label lbl10;
        private Label lbl20;
        private Label lbl22;
        private Label lbl12;
        private Label lbl02;
        private Label lblWinner;
    }
}