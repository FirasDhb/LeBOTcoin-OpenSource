using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using WatiN.Core;

namespace Leboncoin
{
    public partial class Ajouter : MetroForm
    {
        private IE browser = null;
        public string select = "";
        public Array clothing_size1 = new string[] { "Taille du vêtement", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50 et plus" };
        public Array clothing_size3 = new string[] { "Taille du vêtement", "XS", "S", "M", "L", "XL", "XXL", "XXXL et plus" };
        public Array clothing_size4 = new string[] { "Taille du vêtement", "3 ans", "4 ans", "5 ans", "6 ans", "8 ans", "10 ans", "12 ans", "14 ans", "16 ans", "18 ans" };
        public Array clothing_type = new string[] { "Type de vêtement", "Femme", "Femme enceinte", "Homme", "Enfant" };
        public Array brand = new string[] { "Marque", "Audi", "Bmw", "Citroen", "Fiat", "Ford", "Mercedes", "Opel", "Peugeot", "Renault", "Volkswagen", "Abarth", "Aleko", "Alfa Romeo", "Alpina", "Aro", "Artega", "Aston Martin", "Autobianchi", "Auverland", "Bentley", "Bertone", "Bluecar Groupe Bollore", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Corvette", "Dacia", "Daewoo", "Daihatsu", "Dangel", "De La Chapelle", "Dodge", "Donkervoort", "Ds", "Ferrari", "Fisker", "Gme", "Honda", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Iveco", "Jaguar", "Jeep", "Kia", "Lada", "Lamborghini", "Lancia", "Land Rover", "Lexus", "Lotus", "Mahindra", "Maruti", "Maserati", "Mastretta", "Maybach", "Mazda", "Mclaren", "Mega", "Mg", "Mia", "Mini", "Mitsubishi", "Morgan", "Nissan", "Pgo", "Piaggio", "Polski/fso", "Pontiac", "Porsche", "Proton", "Rolls-royce", "Rover", "Saab", "Santana", "Seat", "Shuanghuan", "Skoda", "Smart", "Ssangyong", "Subaru", "Suzuki", "Talbot", "Tavria", "Tesla", "Toyota", "Tvr", "Venturi", "Volvo", "Autres" };
        public Array regdate = new string[] { "Année modèle", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960 ou avant" };
        public Array carburant = new string[] { "Carburant", "Essence", "Diesel", "GPL", "Electrique", "Autre" };
        public Array gearbox = new string[] { "Boite de vitesse", "Manuelle", "Automatique" };
        public Array furnished = new string[] { "Meublé / Non meublé", "Meublé", "Non meublé" };
        public Array real_estate_type = new string[] { "Type de bien", "Maison", "Appartement", "Terrain", "Parking", "Autre" };
        public Array energy_rate = new string[] { "Classe énergie", "A (moins de 50)", "B (de 51 à 90)", "C (de 91 à 150)", "D (de 151 à 230)", "E (de 231 à 330)", "F (de 331  50)", "G (de 451 à 590)", "H (de 591 à 750)", "I (751 et plus)", "Vierge" };
        public Array ges = new string[] { "GES", "A (moins de 5)", "B (de 6 à 10)", "C (de 11 à 20)", "D (de 21 à 35)", "E (de 36 à 55)", "F (de 56 à 80)", "G de 81 à 110)", "H (de 111 à 145)", "I (146 et plus)", "Vierge" };
        public Array shoe_type = new string[] { "Type de chaussure", "Femme", "Homme", "Enfant" };
        public Array shoe_size = new string[] { "Pointure", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50 et plus" };
        public Array baby_age = new string[] { "Taille", "Prématuré", "0 mois", "1 mois", "3 mois", "6 mois", "9 mois", "12 mois", "18 mois", "24 mois", "36 mois" };
        public Array animal_type = new string[] { "Type de l'offre", "Chiens & Chats", "Autres animaux", "Accessoires" };
        public Ajouter(string selected)
        {
            InitializeComponent();
            metroButton4.Enabled = false;
            if (selected != "")
            {
                select = selected;
                button1.Visible = false;
                Text = "Modifier une annonce";
                metroButton4.Text = "Modifier";
            }
            Settings.Instance.AutoMoveMousePointerToTopLeft = false;
            Settings.WaitUntilExistsTimeOut = 500;
            Settings.Instance.MakeNewIeInstanceVisible = false;

        }
        string pphoto1 = string.Empty;
        string pphoto2 = string.Empty;
        string pphoto3 = string.Empty;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo1 = new OpenFileDialog();
            if (photo1.ShowDialog() == DialogResult.OK)
            {
                pphoto1 = photo1.FileName;
                pictureBox1.ImageLocation = pphoto1;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo2 = new OpenFileDialog();
            if (photo2.ShowDialog() == DialogResult.OK)
            {
                pphoto2 = photo2.FileName;
                pictureBox2.ImageLocation = pphoto2;
            }
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {

            OpenFileDialog photo3 = new OpenFileDialog();
            if (photo3.ShowDialog() == DialogResult.OK)
            {
                pphoto3 = photo3.FileName;
                pictureBox3.ImageLocation = pphoto3;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string ppp1 = String.Empty;
            string ppp2 = String.Empty;
            string ppp3 = String.Empty;
            string nom = "";
            if (select == "")
            {
                nom = Prompt.ShowDialog("Nom", "Comment nommer cette annonce?");
            }
            else
            {
                nom = select;
                SQLiteConnection maConnexion1;
                maConnexion1 = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
                maConnexion1.Open();
                SQLiteCommand blah = new SQLiteCommand(maConnexion1);
                string sqla = "select * from " + select;
                SQLiteCommand commandeé = new SQLiteCommand(sqla, maConnexion1);
                SQLiteDataReader reader = commandeé.ExecuteReader();
                while (reader.Read())
                {
                    ppp1 = reader["photo1"].ToString();
                    ppp2 = reader["photo2"].ToString();
                    ppp3 = reader["photo3"].ToString();
                };
                blah.CommandText = " DROP Table if exists '" + select + "'";
                blah.ExecuteNonQuery();
                maConnexion1.Close();
            }
            SQLiteConnection maConnexion;
            maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
            maConnexion.Open();
            string sql = "create table if not exists " + nom + " (prix int, catégorie text, texte text, titre text, photo1 text, photo2 text, photo3 text, clothing_size text, clothing_type text, brand text, regdate text, carburant text, gearbox text, model text, kilometer text, cc text, surface text, piece text, furnished text, real_estate_type text, energy_rate text, ges text, shoe_type text, shoe_size text, baby_age text, animal_type text)";
            SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
            commande.ExecuteNonQuery();
            string insert1 = "insert into " + nom + " (prix, catégorie, texte, titre, photo1, photo2, photo3) values (@prix, @catégorie, @texte, @titre, @photo1, @photo2, @photo3)";
            SQLiteCommand annonce1 = new SQLiteCommand(insert1, maConnexion);
            annonce1.Parameters.Add(new SQLiteParameter("@prix", int.Parse(metroTextBox3.Text)));
            annonce1.Parameters.Add(new SQLiteParameter("@catégorie", metroComboBox1.SelectedItem));
            annonce1.Parameters.Add(new SQLiteParameter("@texte", metroTextBox2.Text));
            annonce1.Parameters.Add(new SQLiteParameter("@titre", metroTextBox1.Text));
            if (pphoto1 == string.Empty)
            {
                annonce1.Parameters.Add(new SQLiteParameter("@photo1", ppp1));
            }
            else { annonce1.Parameters.Add(new SQLiteParameter("@photo1", pphoto1)); }
            if (pphoto2 == string.Empty)
            {
                annonce1.Parameters.Add(new SQLiteParameter("@photo2", ppp2));
            }
            else { annonce1.Parameters.Add(new SQLiteParameter("@photo2", pphoto2)); }
            if (pphoto3 == string.Empty)
            {
                annonce1.Parameters.Add(new SQLiteParameter("@photo3", ppp3));
            }
            else { annonce1.Parameters.Add(new SQLiteParameter("@photo3", pphoto3)); }
            annonce1.ExecuteNonQuery();

            foreach (System.Windows.Forms.Control c in Controls)
            {
                MetroComboBox t = c as MetroComboBox;
                if (t is MetroComboBox && t.Visible == true)
                {
                    if (t.Items[0].ToString() == "Taille du vêtement")
                    {
                        string insert = "update " + nom + " set clothing_size ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "«Choisissez»")
                    {
                        string insert = "update " + nom + " set model ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Type de vêtement")
                    {
                        string insert = "update " + nom + " set clothing_type ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Marque")
                    {
                        string insert = "update " + nom + " set brand ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Année modèle")
                    {
                        string insert = "update " + nom + " set regdate ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Carburant")
                    {
                        string insert = "update " + nom + " set carburant ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Boite de vitesse")
                    {
                        string insert = "update " + nom + " set gearbox ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Meublé / Non meublé")
                    {
                        string insert = "update " + nom + " set furnished ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Type de bien")
                    {
                        string insert = "update " + nom + " set real_estate_type ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Classe énergie")
                    {
                        string insert = "update " + nom + " set energy_rate ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "GES")
                    {
                        string insert = "update " + nom + " set ges ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Type de chaussure")
                    {
                        string insert = "update " + nom + " set shoe_type ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Pointure")
                    {
                        string insert = "update " + nom + " set shoe_size ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    if (t.Items[0].ToString() == "Taille")
                    {
                        string insert = "update " + nom + " set baby_age ='" + t.SelectedItem.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                }
            }
            foreach (System.Windows.Forms.Control co in Controls)
            {
                MetroTextBox tb = co as MetroTextBox;
                if (tb is MetroTextBox && tb.Visible == true)
                {
                    if (tb.WaterMark == "Kilométrage")
                    {
                        string insert = "update " + nom + " set kilometer ='" + tb.Text.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    else if (tb.WaterMark == "Cylindrée")
                    {
                        string insert = "update " + nom + " set cc ='" + tb.Text.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    else if (tb.WaterMark == "Surface")
                    {
                        string insert = "update " + nom + " set surface ='" + tb.Text.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                    else if (tb.WaterMark == "Pièces")
                    {
                        string insert = "update " + nom + " set piece ='" + tb.Text.ToString() + "'";
                        SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
                        annonce.ExecuteNonQuery();
                    }
                }
            }
            maConnexion.Close();
            Close();
        }



        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb4.Enabled = true; cb1.Visible = false; cb2.Visible = false; cb3.Visible = false; cb4.Visible = false; cb5.Visible = false; cb6.Visible = false; tb1.Visible = false; km.Visible = false; tb2.Visible = false; cc.Visible = false; tb1.WaterMark = "Kilométrage"; km.Text = "Km"; tb2.WaterMark = "Cylindrée"; cc.Text = "cm³";
            if (metroComboBox1.SelectedItem.ToString().StartsWith("-- "))
            { metroComboBox1.SelectedIndex=0; }
            else
            {
                if (metroComboBox1.SelectedItem.ToString() == "Vêtements")
                {
                    cb1.Visible = true;
                    cb1.DataSource = clothing_type;
                }
                else if (metroComboBox1.SelectedItem.ToString() == "Chaussures")
                {
                    cb1.DataSource = shoe_type;
                    cb2.DataSource = shoe_size;
                    cb1.Visible = true;
                    cb2.Visible = true;
                }
                else if (metroComboBox1.SelectedItem.ToString() == "Vêtements bébé")
                {
                    cb1.DataSource = baby_age;
                    cb1.Visible = true;
                }
                else if (metroComboBox1.SelectedItem.ToString() == "Voitures")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    browser = new IE();
                    Cursor.Current = Cursors.Default;
                    cb3.DataSource = brand;
                    cb1.DataSource = regdate;
                    cb5.DataSource = carburant;
                    cb6.DataSource = gearbox;
                    tb1.Visible = true;
                    cb4.Visible = true; cb4.Enabled = false;
                    cb1.Visible = true;
                    cb3.Visible = true;
                    cb5.Visible = true;
                    cb6.Visible = true;
                }
                else if (metroComboBox1.SelectedItem.ToString() == "Motos")
                {
                    cb1.DataSource = regdate;
                    tb1.Visible = true;
                    tb2.Visible = true;
                    cb1.Visible = true;
                }
                else if (metroComboBox1.SelectedItem.ToString() == "Caravaning")
                {
                    cb1.DataSource = regdate;
                    tb1.Visible = true;
                    cb1.Visible = true;
                }
                else if (metroComboBox1.SelectedItem.ToString() == "Utilitaires")
                {
                    cb1.DataSource = regdate;
                    cb5.DataSource = carburant;
                    tb1.Visible = true;
                    cb1.Visible = true;
                    cb5.Visible = true;
                }
                else if (metroComboBox1.SelectedItem.ToString() == "Ventes immobilières" || metroComboBox1.SelectedItem.ToString() == "Locations")
                {
                    cb1.DataSource = real_estate_type;
                    cb3.DataSource = energy_rate;
                    cb4.DataSource = ges;
                    km.Text = "m²";
                    tb1.WaterMark = "Surface";
                    cc.Text = "";
                    tb2.WaterMark = "Pièces";
                    tb1.Visible = true;
                    tb2.Visible = true;
                    cb1.Visible = true;
                    cb3.Visible = true;
                    cb4.Visible = true;
                    if (metroComboBox1.SelectedItem.ToString() == "Locations") { cb6.DataSource = furnished; cb6.Visible = true; }
                }
                else if (metroComboBox1.SelectedItem.ToString() == "Colocations")
                {
                    cb1.DataSource = energy_rate;
                    cb6.DataSource = ges;
                    km.Text = "m²";
                    tb1.WaterMark = "Surface";
                    cc.Text = "";
                    tb2.WaterMark = "Pièces";
                    tb1.Visible = true;
                    tb2.Visible = true;
                    cb1.Visible = true;
                    cb6.Visible = true;
                }
                else if (metroComboBox1.SelectedItem.ToString() == "Bureaux & Commerces")
                {
                    cb1.DataSource = energy_rate;
                    cb2.DataSource = ges;
                    cc.Text = "m²";
                    tb2.WaterMark = "Surface";
                    tb2.Visible = true;
                    cb1.Visible = true;
                    cb2.Visible = true;
                }
            }
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            ControlBox = true;
            if (select != "")
            {
                SQLiteConnection maConnexion;
                maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
                maConnexion.Open();
                string sql = "select * from " + select;
                SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
                SQLiteDataReader reader = commande.ExecuteReader();
                while (reader.Read())
                {
                    metroTextBox3.Text = reader["prix"].ToString();
                    metroComboBox1.SelectedItem = reader["catégorie"].ToString();
                    metroTextBox2.Text = reader["texte"].ToString();
                    metroTextBox1.Text = reader["titre"].ToString();
                    pictureBox1.ImageLocation = reader["photo1"].ToString();
                    pictureBox2.ImageLocation = reader["photo2"].ToString();
                    pictureBox3.ImageLocation = reader["photo3"].ToString();

                    if (metroComboBox1.SelectedItem.ToString() == "Vêtements")
                    {
                        cb1.SelectedItem = reader["clothing_type"].ToString();
                        cb2.SelectedItem = reader["clothing_size"].ToString();
                    }
                    else if (metroComboBox1.SelectedItem.ToString() == "Chaussures")
                    {
                        cb1.SelectedItem = reader["shoe_type"].ToString();
                        cb2.SelectedItem = reader["shoe_size"].ToString();
                    }
                    else if (metroComboBox1.SelectedItem.ToString() == "Vêtements bébé")
                    {
                        cb1.SelectedItem = reader["baby_age"].ToString();
                    }
                    else if (metroComboBox1.SelectedItem.ToString() == "Voitures")
                    {
                        cb1.SelectedItem = reader["regdate"].ToString();
                        cb3.SelectedItem = reader["brand"].ToString();
                        cb5.SelectedItem = reader["carburant"].ToString();
                        cb6.SelectedItem = reader["gearbox"].ToString();
                        cb4.SelectedItem = reader["model"].ToString();
                        tb1.Text = reader["kilometer"].ToString();
                        cb4.Enabled = true;
                    }
                    else if (metroComboBox1.SelectedItem.ToString() == "Motos")
                    {
                        cb1.SelectedItem = reader["regdate"].ToString();
                        tb1.Text = reader["kilometer"].ToString();
                        tb2.Text = reader["cc"].ToString();
                    }
                    else if (metroComboBox1.SelectedItem.ToString() == "Caravaning")
                    {
                        cb1.SelectedItem = reader["regdate"].ToString();
                        tb1.Text = reader["kilometer"].ToString();
                    }
                    else if (metroComboBox1.SelectedItem.ToString() == "Utilitaires")
                    {
                        cb1.SelectedItem = reader["regdate"].ToString();
                        cb5.SelectedItem = reader["carburant"].ToString();
                        tb1.Text = reader["kilometer"].ToString();
                    }
                    else if (metroComboBox1.SelectedItem.ToString() == "Ventes immobilières" || metroComboBox1.SelectedItem.ToString() == "Locations")
                    {
                        cb1.SelectedItem = reader["real_estate_type"].ToString();
                        cb3.SelectedItem = reader["energy_rate"].ToString();
                        cb4.SelectedItem = reader["ges"].ToString();
                        tb1.Text = reader["surface"].ToString();
                        tb2.Text = reader["piece"].ToString();
                        if (metroComboBox1.SelectedItem.ToString() == "Locations")
                        {
                            cb6.SelectedItem = reader["furnished"].ToString();
                        }
                    }
                    else if (metroComboBox1.SelectedItem.ToString() == "Colocations")
                    {
                        cb1.SelectedItem = reader["energy_rate"].ToString();
                        cb6.SelectedItem = reader["ges"].ToString();
                        tb1.Text = reader["surface"].ToString();
                        tb2.Text = reader["piece"].ToString();
                    }
                    else if (metroComboBox1.SelectedItem.ToString() == "Bureaux & Commerces")
                    {
                        cb1.SelectedItem = reader["energy_rate"].ToString();
                        cb2.SelectedItem = reader["ges"].ToString();
                        tb2.Text = reader["surface"].ToString();
                    }
                }
                maConnexion.Close();
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedItem.ToString() == "Vêtements")
            {
                if (cb1.SelectedItem.ToString() == "Femme" || cb1.SelectedItem.ToString() == "Femme enceinte") { cb2.DataSource = clothing_size1; cb2.Visible = true; }
                if (cb1.SelectedItem.ToString() == "Homme") { cb2.DataSource = clothing_size3; cb2.Visible = true; }
                if (cb1.SelectedItem.ToString() == "Enfant") { cb2.DataSource = clothing_size4; cb2.Visible = true; }
            }
            else if (metroComboBox1.SelectedItem.ToString() == "Chaussures") { cb2.DataSource = shoe_size; }
        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedItem.ToString() == "Voitures" && cb3.SelectedItem.ToString() != "Marque")
            {
                Cursor.Current = Cursors.WaitCursor;
                browser.GoTo("https://www.leboncoin.fr/beta/ajax/request_template.html?template=fields%2Ffield_model&brand=" + cb3.SelectedItem.ToString());
                browser.WaitForComplete();
                Cursor.Current = Cursors.Default;
                cb4.DataSource = browser.SelectList(Find.ById("model")).AllContents; cb4.Enabled = true;
                browser.Close();
            }
        }
        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void tb2_VisibleChanged(object sender, EventArgs e)
        {
            if (tb2.Visible == true) { cc.Visible = true; } else { cc.Visible = false; }
        }

        private void tb1_VisibleChanged_1(object sender, EventArgs e)
        {
            if (tb1.Visible == true) { km.Visible = true; } else { km.Visible = false; }
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroComboBox1_TextChanged(object sender, EventArgs e)
        {
            metroButton4.Enabled = false;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            foreach (System.Windows.Forms.Control cz in Controls)
            {
                MetroComboBox t = cz as MetroComboBox;
                if (t is MetroComboBox && t.Visible == true)
                {
                    a = a + 1;
                    if (t.SelectedIndex != 0) { b = b + 1; };
                }
            }
            foreach (System.Windows.Forms.Control ca in Controls)
            {
                MetroTextBox ta = ca as MetroTextBox;
                if (ta is MetroTextBox && ta.Visible == true)
                {
                    c = c + 1;
                    if (ta.Text != "") { d = d + 1; }
                }
            }
            if (a == b && c==d && metroComboBox1.SelectedIndex!=0) { metroButton4.Enabled = true; }

        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                MetroForm prompt = new MetroForm()
                {
                    Width = 450,
                    Height = 150,
                    Text = caption,
                    Style = MetroFramework.MetroColorStyle.Orange,
                    Resizable = false,
                    ControlBox = false,
                    TextAlign = MetroFormTextAlign.Center,
                    StartPosition = FormStartPosition.CenterScreen
                };
                MetroTextBox textBox = new MetroTextBox() { Left = 115, Top = 65, Width = 200 };
                MetroButton confirmation = new MetroButton() { Text = "Ok", Left = 165, Width = 100, Top = 100, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                textBox.Style = MetroFramework.MetroColorStyle.Orange;
                textBox.KeyPress += (sender, e) => { e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); };
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
    }

}