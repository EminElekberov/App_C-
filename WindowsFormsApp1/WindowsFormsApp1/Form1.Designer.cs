
namespace WindowsFormsApp1
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
            this.SelectFolder = new System.Windows.Forms.TextBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CopyTxt = new System.Windows.Forms.TextBox();
            this.btncopy = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(130, 93);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(344, 20);
            this.SelectFolder.TabIndex = 0;
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(535, 93);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 1;
            this.btnselect.Text = "Sec";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CopyTxt
            // 
            this.CopyTxt.Location = new System.Drawing.Point(130, 185);
            this.CopyTxt.Name = "CopyTxt";
            this.CopyTxt.Size = new System.Drawing.Size(344, 20);
            this.CopyTxt.TabIndex = 2;
            // 
            // btncopy
            // 
            this.btncopy.Location = new System.Drawing.Point(535, 185);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(106, 20);
            this.btncopy.TabIndex = 3;
            this.btncopy.Text = "Kopyala";
            this.btncopy.UseVisualStyleBackColor = true;
            this.btncopy.Click += new System.EventHandler(this.btncopy_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncopy);
            this.Controls.Add(this.CopyTxt);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.SelectFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SelectFolder;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox CopyTxt;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

