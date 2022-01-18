
namespace RestuarntApi
{
    partial class Area
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TerasBtn = new System.Windows.Forms.Button();
            this.salon2Btn = new System.Windows.Forms.Button();
            this.salon1Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TerasBtn
            // 
            this.TerasBtn.BackColor = System.Drawing.Color.Lime;
            this.TerasBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TerasBtn.Location = new System.Drawing.Point(572, 370);
            this.TerasBtn.Name = "TerasBtn";
            this.TerasBtn.Size = new System.Drawing.Size(184, 68);
            this.TerasBtn.TabIndex = 5;
            this.TerasBtn.Text = "Teras";
            this.TerasBtn.UseVisualStyleBackColor = false;
            this.TerasBtn.Click += new System.EventHandler(this.TerasBtn_Click);
            // 
            // salon2Btn
            // 
            this.salon2Btn.BackColor = System.Drawing.Color.Lime;
            this.salon2Btn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salon2Btn.Location = new System.Drawing.Point(302, 370);
            this.salon2Btn.Name = "salon2Btn";
            this.salon2Btn.Size = new System.Drawing.Size(184, 68);
            this.salon2Btn.TabIndex = 4;
            this.salon2Btn.Text = "Salon 2";
            this.salon2Btn.UseVisualStyleBackColor = false;
            this.salon2Btn.Click += new System.EventHandler(this.salon2Btn_Click);
            // 
            // salon1Btn
            // 
            this.salon1Btn.BackColor = System.Drawing.Color.Lime;
            this.salon1Btn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salon1Btn.Location = new System.Drawing.Point(41, 370);
            this.salon1Btn.Name = "salon1Btn";
            this.salon1Btn.Size = new System.Drawing.Size(184, 68);
            this.salon1Btn.TabIndex = 3;
            this.salon1Btn.Text = "Salon 1";
            this.salon1Btn.UseVisualStyleBackColor = false;
            this.salon1Btn.Click += new System.EventHandler(this.salon1Btn_Click);
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TerasBtn);
            this.Controls.Add(this.salon2Btn);
            this.Controls.Add(this.salon1Btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Area";
            this.Text = "Area";
            this.Load += new System.EventHandler(this.Area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TerasBtn;
        private System.Windows.Forms.Button salon2Btn;
        private System.Windows.Forms.Button salon1Btn;
    }
}