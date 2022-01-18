
namespace RestuarntApi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbSelectSpecies = new System.Windows.Forms.ComboBox();
            this.cmbSelectName = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtEats = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_formAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEats)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbSelectSpecies
            // 
            this.cmbSelectSpecies.FormattingEnabled = true;
            this.cmbSelectSpecies.Location = new System.Drawing.Point(12, 75);
            this.cmbSelectSpecies.Name = "cmbSelectSpecies";
            this.cmbSelectSpecies.Size = new System.Drawing.Size(193, 21);
            this.cmbSelectSpecies.TabIndex = 2;
            this.cmbSelectSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbSelectSpecies_SelectedIndexChanged);
            // 
            // cmbSelectName
            // 
            this.cmbSelectName.FormattingEnabled = true;
            this.cmbSelectName.Location = new System.Drawing.Point(310, 74);
            this.cmbSelectName.Name = "cmbSelectName";
            this.cmbSelectName.Size = new System.Drawing.Size(225, 21);
            this.cmbSelectName.TabIndex = 3;
            this.cmbSelectName.SelectedIndexChanged += new System.EventHandler(this.cmbSelectName_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(604, 75);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(184, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtEats
            // 
            this.dtEats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEats.Location = new System.Drawing.Point(2, 368);
            this.dtEats.Name = "dtEats";
            this.dtEats.Size = new System.Drawing.Size(937, 223);
            this.dtEats.TabIndex = 5;
            this.dtEats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEats_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(751, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Dishes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_formAdd
            // 
            this.btn_formAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_formAdd.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_formAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_formAdd.Location = new System.Drawing.Point(31, 276);
            this.btn_formAdd.Name = "btn_formAdd";
            this.btn_formAdd.Size = new System.Drawing.Size(174, 43);
            this.btn_formAdd.TabIndex = 7;
            this.btn_formAdd.Text = "Add";
            this.btn_formAdd.UseVisualStyleBackColor = false;
            this.btn_formAdd.Click += new System.EventHandler(this.btn_formAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Geri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_formAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtEats);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbSelectName);
            this.Controls.Add(this.cmbSelectSpecies);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbSelectSpecies;
        private System.Windows.Forms.ComboBox cmbSelectName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dtEats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_formAdd;
        private System.Windows.Forms.Label label1;
    }
}

