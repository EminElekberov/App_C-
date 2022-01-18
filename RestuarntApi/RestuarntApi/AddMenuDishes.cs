using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestuarntApi
{
    public partial class AddMenuDishes : Form
    {
        private ComboBox _cmbAdd;
        private DataGridView _dgvAddeats;
        List<Group> groups;
        public AddMenuDishes(List<Group> grps, ComboBox cmb, DataGridView dgv)
        {
            InitializeComponent();
            this.groups = grps;
            _cmbAdd = cmb;
            _dgvAddeats = dgv;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddMenuButton_Click(object sender, EventArgs e)
        {

            string bName = txtAddMenu.Text.Trim();
            double bPrice = Convert.ToDouble(txtAddPrice.Text.Trim());
            string bSpice = cmbSpice.Text.Trim();
            if (bName == null || bPrice == null)
            {
                MessageBox.Show("Doldur", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dishes dish = new Dishes(bName, bPrice);
            Group gr = new Group(bSpice);
            gr.AddStudent(dish);
            groups.Add(gr);
            //Group selectGroup = (Group)cmbSpice.SelectedItem;
            //selectGroup.AddStudent(dish);
            //dtvGrid.Rows.Add(gr.GetAlLStudent().ToArray());
            dtvGrid.DataSource = gr.GetAlLStudent();
            txtAddMenu.Text = "";
            txtAddPrice.Text = "";
            list();

            //string bCmbGroup = cmbSpice.Text.Trim();
            //string dishName = txtAddMenu.Text.Trim();
            //double price = Convert.ToDouble(txtAddPrice.Text.Trim());

            //Dishes dish = new Dishes(dishName, price);
            //Group group = (Group)cmbSpice.SelectedItem;
            //group.AddStudent(dish);
            //dtvGrid.DataSource = null;
            //dtvGrid.DataSource = groups.ToArray();
            //txtAddMenu.Text = "";
        }
        public void list()
        {
            for (int i = 0; i < groups.Count - 1; i++)
            {
                for (int j = 0; j < groups[i].dish.Count; j++)
                {
                    dtvGrid.Rows.Add(groups[i].dish[j].Name);
                }
            }
        }
        private void btnNewMenu_Click(object sender, EventArgs e)
        {
            string bNewDish = txtNewMenuSpices.Text.Trim();
            string bNewName = txtNewMenuName.Text.Trim();
            double bPrice = Convert.ToDouble(txtNewMenuPrice.Text.Trim());
            Dishes dish = new Dishes(bNewName, bPrice);
            Group group = new Group(bNewDish);
            group.AddStudent(dish);
            groups.Add(group);
            dgvSave.DataSource = null;
            dgvSave.DataSource = group.GetAlLStudent().ToArray();

            #region
            //Group gr = null;
            //try
            //{
            //    Dishes dishes = new Dishes(bNewName, bPrice);
            //    gr = new Group(bNewDish);
            //    gr.AddStudent(dishes);
            //    MessageBox.Show("elave olundu ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //catch (Exception)
            //{
            //    MessageBox.Show("xais olunur xanali doldurun ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    throw;
            //}
            //dgvSave.DataSource = gr.GetAlLStudent();
            #endregion
        }


        private void AddMenuDishes_Load(object sender, EventArgs e)
        {
            foreach (var item in groups)
            {
                cmbSpice.Items.Add(item.Names);
            }
            // cmbSpice.Items.AddRange(groups.ToArray());
            cmbSpice.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbSpice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSpice_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
