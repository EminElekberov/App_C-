
namespace RestuarntApi
{
    partial class AddMenuDishes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbSpice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtvGrid = new System.Windows.Forms.DataGridView();
            this.AddMenuButton = new System.Windows.Forms.Button();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.txtAddMenu = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSave = new System.Windows.Forms.DataGridView();
            this.btnNewMenu = new System.Windows.Forms.Button();
            this.txtNewMenuName = new System.Windows.Forms.TextBox();
            this.txtNewMenuPrice = new System.Windows.Forms.TextBox();
            this.txtNewMenuSpices = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSave)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 455);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Maroon;
            this.tabPage2.Controls.Add(this.cmbSpice);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtvGrid);
            this.tabPage2.Controls.Add(this.AddMenuButton);
            this.tabPage2.Controls.Add(this.txtAddPrice);
            this.tabPage2.Controls.Add(this.txtAddMenu);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.DimGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Species";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cmbSpice
            // 
            this.cmbSpice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpice.FormattingEnabled = true;
            this.cmbSpice.Location = new System.Drawing.Point(8, 56);
            this.cmbSpice.Name = "cmbSpice";
            this.cmbSpice.Size = new System.Drawing.Size(164, 28);
            this.cmbSpice.TabIndex = 9;
            this.cmbSpice.SelectedIndexChanged += new System.EventHandler(this.cmbSpice_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Montserrat", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(355, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Montserrat", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Spicies";
            // 
            // dtvGrid
            // 
            this.dtvGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvGrid.Location = new System.Drawing.Point(-4, 229);
            this.dtvGrid.Name = "dtvGrid";
            this.dtvGrid.Size = new System.Drawing.Size(800, 204);
            this.dtvGrid.TabIndex = 4;
            this.dtvGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddMenuButton
            // 
            this.AddMenuButton.ForeColor = System.Drawing.Color.Maroon;
            this.AddMenuButton.Location = new System.Drawing.Point(544, 180);
            this.AddMenuButton.Name = "AddMenuButton";
            this.AddMenuButton.Size = new System.Drawing.Size(179, 42);
            this.AddMenuButton.TabIndex = 3;
            this.AddMenuButton.Text = "Add";
            this.AddMenuButton.UseVisualStyleBackColor = true;
            this.AddMenuButton.Click += new System.EventHandler(this.AddMenuButton_Click);
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(359, 180);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(103, 23);
            this.txtAddPrice.TabIndex = 2;
            // 
            // txtAddMenu
            // 
            this.txtAddMenu.Location = new System.Drawing.Point(7, 180);
            this.txtAddMenu.Name = "txtAddMenu";
            this.txtAddMenu.Size = new System.Drawing.Size(284, 23);
            this.txtAddMenu.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvSave);
            this.tabPage1.Controls.Add(this.btnNewMenu);
            this.tabPage1.Controls.Add(this.txtNewMenuName);
            this.tabPage1.Controls.Add(this.txtNewMenuPrice);
            this.tabPage1.Controls.Add(this.txtNewMenuSpices);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 429);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "New Menu";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Spicies";
            // 
            // dgvSave
            // 
            this.dgvSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSave.Location = new System.Drawing.Point(0, 221);
            this.dgvSave.Name = "dgvSave";
            this.dgvSave.Size = new System.Drawing.Size(796, 208);
            this.dgvSave.TabIndex = 4;
            // 
            // btnNewMenu
            // 
            this.btnNewMenu.BackColor = System.Drawing.Color.Red;
            this.btnNewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewMenu.Location = new System.Drawing.Point(235, 149);
            this.btnNewMenu.Name = "btnNewMenu";
            this.btnNewMenu.Size = new System.Drawing.Size(297, 50);
            this.btnNewMenu.TabIndex = 3;
            this.btnNewMenu.Text = "Save";
            this.btnNewMenu.UseVisualStyleBackColor = false;
            this.btnNewMenu.Click += new System.EventHandler(this.btnNewMenu_Click);
            // 
            // txtNewMenuName
            // 
            this.txtNewMenuName.Location = new System.Drawing.Point(313, 68);
            this.txtNewMenuName.Name = "txtNewMenuName";
            this.txtNewMenuName.Size = new System.Drawing.Size(176, 20);
            this.txtNewMenuName.TabIndex = 2;
            // 
            // txtNewMenuPrice
            // 
            this.txtNewMenuPrice.Location = new System.Drawing.Point(630, 68);
            this.txtNewMenuPrice.Name = "txtNewMenuPrice";
            this.txtNewMenuPrice.Size = new System.Drawing.Size(105, 20);
            this.txtNewMenuPrice.TabIndex = 1;
            // 
            // txtNewMenuSpices
            // 
            this.txtNewMenuSpices.Location = new System.Drawing.Point(24, 68);
            this.txtNewMenuSpices.Name = "txtNewMenuSpices";
            this.txtNewMenuSpices.Size = new System.Drawing.Size(176, 20);
            this.txtNewMenuSpices.TabIndex = 0;
            // 
            // AddMenuDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddMenuDishes";
            this.Text = "AddMenuDishes";
            this.Load += new System.EventHandler(this.AddMenuDishes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtvGrid;
        private System.Windows.Forms.Button AddMenuButton;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.TextBox txtAddMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvSave;
        private System.Windows.Forms.Button btnNewMenu;
        private System.Windows.Forms.TextBox txtNewMenuName;
        private System.Windows.Forms.TextBox txtNewMenuPrice;
        private System.Windows.Forms.TextBox txtNewMenuSpices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSpice;
    }
}