using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestuarntApi
{
    public partial class Form1 : Form
    {
        public  List<Group> groups = new List<Group>();
        public  List<Sifaris> sifaris = new List<Sifaris>();
        public Form1()
        {
            Group group1 = new Group("Şorba");
            Group group2 = new Group("Qəlyanaltı");
            Group group3 = new Group("Salat");
            Group group4 = new Group("Sendviç ve burger");
            Group group5 = new Group("Pizza");
            Group group6 = new Group("Kabab");
            Group group7 = new Group("Dönər");
            Group group8 = new Group("Şirniyyat");
            Group group9 = new Group("İçki");

            //sorbalar
            Dishes dishes1 = new Dishes("Mərci şorbası", 4);
            Dishes dishes2 = new Dishes("Toyuq şorbası", 4);
            Dishes dishes3 = new Dishes("Yayla şorbası", 3.5);
            Dishes dishes4 = new Dishes("Göbələk şorbası", 3.5);
            group1.AddStudent(dishes1);
            group1.AddStudent(dishes2);
            group1.AddStudent(dishes3);
            group1.AddStudent(dishes4);
            //Snacks
            Dishes dishes5 = new Dishes("Keçi pendiri", 4);
            Dishes dishes6 = new Dishes("Yaşıl Zeytun", 2.5);
            Dishes dishes7 = new Dishes("Qara Zeytun", 2.5);
            Dishes dishes8 = new Dishes("Qarisiq Tursu", 4);
            group2.AddStudent(dishes5);
            group2.AddStudent(dishes6);
            group2.AddStudent(dishes7);
            group2.AddStudent(dishes8);
            //salatlar
            Dishes dishes9 = new Dishes("Gavurdag salatı", 7.5);
            Dishes dishes10 = new Dishes("Çoban salatı", 4);
            Dishes dishes11 = new Dishes("Toyuq Sezar salatı", 8.5);
            Dishes dishes12 = new Dishes("Tuna salatı", 7.5);
            Dishes dishes13 = new Dishes("Yasıl salat", 6.9);
            Dishes dishes14 = new Dishes("Movsümi salat", 6.5);
            Dishes dishes15 = new Dishes("Yunan  salat", 6.9);
            Dishes dishes16 = new Dishes("Xüsusi salat", 7.9);
            Dishes dishes17 = new Dishes("İsti əzmə", 5);
            Dishes dishes18 = new Dishes("Haydari sousu", 5);
            Dishes dishes19 = new Dishes("Rus salatı", 5.5);
            Dishes dishes20 = new Dishes("Acılı toyuq salatı", 5.9);
            Dishes dishes21 = new Dishes("Mimoza salatı", 7.8);
            Dishes dishes22 = new Dishes("Manqal salatı", 6.5);
            Dishes dishes23 = new Dishes("Şakşuka salatı", 4.5);
            group3.AddStudent(dishes9);
            group3.AddStudent(dishes10);
            group3.AddStudent(dishes11);
            group3.AddStudent(dishes12);
            group3.AddStudent(dishes13);
            group3.AddStudent(dishes14);
            group3.AddStudent(dishes15);
            group3.AddStudent(dishes16);
            group3.AddStudent(dishes17);
            group3.AddStudent(dishes18);
            group3.AddStudent(dishes19);
            group3.AddStudent(dishes20);
            group3.AddStudent(dishes21);
            group3.AddStudent(dishes22);
            group3.AddStudent(dishes23);
            Dishes dishes24 = new Dishes("Club Sandwich", 7.9);
            Dishes dishes25 = new Dishes("Toyuq sendviçi", 7);
            Dishes dishes26 = new Dishes("Toyuq Burger", 6);
            Dishes dishes27 = new Dishes("Sezar Roll", 7.9);
            Dishes dishes28 = new Dishes("Mal əti Burger", 8);
            Dishes dishes29 = new Dishes("Mal əti Burger", 8);
            group4.AddStudent(dishes24);
            group4.AddStudent(dishes25);
            group4.AddStudent(dishes26);
            group4.AddStudent(dishes27);
            group4.AddStudent(dishes28);
            group4.AddStudent(dishes29);

            Dishes dishes30 = new Dishes("Polo göbələk pizzası", 11.5);
            Dishes dishes31 = new Dishes("Salam pizza", 11.5);
            Dishes dishes32 = new Dishes("Sezar Pizza", 15.9);
            Dishes dishes33 = new Dishes("Pizza Marqarita", 9.5);
            Dishes dishes34 = new Dishes("Qarışıq Pizza", 13.9);
            group5.AddStudent(dishes30);
            group5.AddStudent(dishes31);
            group5.AddStudent(dishes32);
            group5.AddStudent(dishes33);
            group5.AddStudent(dishes34);
            Dishes dishes35 = new Dishes("Adana kababı",11);
            Dishes dishes36 = new Dishes("Urfa kababı",8.9);
            Dishes dishes37 = new Dishes("Tüpürülmüş qovrulmuş Quzu", 9.5);
            Dishes dishes38 = new Dishes("Dilimlənmiş Quzu", 9.5);
            group6.AddStudent(dishes35);
            group6.AddStudent(dishes36);
            group6.AddStudent(dishes37);
            group6.AddStudent(dishes38);

            Dishes dishes39 = new Dishes("Dönər", 3);
            Dishes dishes40 = new Dishes("İskəndər", 9.9);
            Dishes dishes41 = new Dishes("Plov üzərində dönər", 7.5);
            Dishes dishes42 = new Dishes("Plov üzərində dönər", 7.5);
            group7.AddStudent(dishes39);
            group7.AddStudent(dishes40);
            group7.AddStudent(dishes41);
            group7.AddStudent(dishes42);

            Dishes dishes43 = new Dishes("Sutlach", 4);
            Dishes dishes44 = new Dishes("Kök Dilim Paxlava", 7);
            Dishes dishes45 = new Dishes("Milli Fındıqlı Paxlava", 6);
            Dishes dishes46 = new Dishes("Fıstıqlı Kare Paxlava", 7);
            group8.AddStudent(dishes43);
            group8.AddStudent(dishes44);
            group8.AddStudent(dishes45);
            group8.AddStudent(dishes46);

            Dishes dishes47 = new Dishes("Sirab 330 ml", 1.5);
            Dishes dishes48 = new Dishes("Ayran Atena, 200 ml", 2);
            Dishes dishes49 = new Dishes("Atena Ayran, 1000 ml", 6);
            Dishes dishes50 = new Dishes("Fanta®, 330 ml", 2);
            Dishes dishes51 = new Dishes("Sprite®, 330 ml", 2);
            group9.AddStudent(dishes47);
            group9.AddStudent(dishes48);
            group9.AddStudent(dishes49);
            group9.AddStudent(dishes50);
            group9.AddStudent(dishes51);
            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);
            groups.Add(group4);
            groups.Add(group5);
            groups.Add(group6);
            groups.Add(group7);
            groups.Add(group8);
            groups.Add(group9);
            InitializeComponent();
            //foreach (var item in groups)
            //{
            //    cmbSelectSpecies.Items.Add(item.Names);
            //}
        }


        private void update_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login(groups, cmbSelectSpecies, dtEats);
            login.ShowDialog();
            #region
            //AddMenuDishes addMenuDishes = new AddMenuDishes(groups, cmbSelectSpecies, dtEats);

            //addMenuDishes.ShowDialog();
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region
            //foreach (var item in groups)
            //{
            //    cmbSelectSpecies.Items.Add(item.Names);
            //}
            #endregion
            cmbSelectSpecies.Items.AddRange(groups.ToArray());
            cmbSelectSpecies.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cmbSelectSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selecetSpices = cmbSelectSpecies.SelectedItem as Group;
            Dishes selectStudent = cmbSelectName.SelectedItem as Dishes;
            cmbSelectName.Items.Clear();
            //cmbSelectName.Items.Clear();
            cmbSelectName.Text = "";
            cmbSelectName.Items.AddRange(selecetSpices.Nm().ToArray());
            dtEats.DataSource = cmbSelectSpecies;
        }
        public void list()
        {
            dtEats.Rows.Clear();
            foreach (var item in groups)
            {
                dtEats.DataSource=groups;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSelectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dishes dishes = cmbSelectName.SelectedItem as Dishes;
            //cmbSelectName.Text = "";
           // cmbSelectName.Items.
            for (int i =0 ; i < groups.Count-1; i++)
            {
                for (int j = 0; j < groups[i].dish.Count; j++)
                {
                   
                    if (groups[i].dish[j].Name == cmbSelectName.SelectedItem)
                    {
                        txtPrice.Text = groups[i].dish[j].Price.ToString();
                    }
                }
            }

        }
        private void btn_formAdd_Click(object sender, EventArgs e)
        {
            string bCmbGroup = cmbSelectSpecies.Text.Trim();
            string bCmbName = cmbSelectName.Text.Trim();
            double bprice = Convert.ToDouble(txtPrice.Text.Trim());

            if (bCmbGroup == null || bCmbName == null)
            {
                MessageBox.Show("Doldur", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Group group = new Group(bCmbGroup);
            Dishes dish = new Dishes(bCmbName, bprice);
            group.AddStudent(dish);
            //dtEats.DataSource = null;
            dtEats.DataSource = group.GetAlLStudent();
            cmbSelectSpecies.Text = "";
            cmbSelectName.Text = "";
            txtPrice.Text = "";
            list();
        }
        List<>
        private void ListDataGridWiew()
        {
            //foreach (var item in groups)
            //{
            //    dtEats
            //}
            dtEats.DataSource = cmbSelectSpecies;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            area.ShowDialog();
        }
        private void dtEats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
