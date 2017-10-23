namespace Leboncoin
{
    partial class Ajouter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.cb3 = new MetroFramework.Controls.MetroComboBox();
            this.cb4 = new MetroFramework.Controls.MetroComboBox();
            this.cb1 = new MetroFramework.Controls.MetroComboBox();
            this.cb2 = new MetroFramework.Controls.MetroComboBox();
            this.cb5 = new MetroFramework.Controls.MetroComboBox();
            this.cb6 = new MetroFramework.Controls.MetroComboBox();
            this.tb1 = new MetroFramework.Controls.MetroTextBox();
            this.km = new MetroFramework.Controls.MetroLabel();
            this.cc = new MetroFramework.Controls.MetroLabel();
            this.tb2 = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(23, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Catégorie: ";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Choisissez une catégorie",
            "-- EMPLOI –-",
            "Offres d\'emploi",
            "-- VEHICULES –-",
            "Voitures",
            "Motos",
            "Caravaning",
            "Utilitaires",
            "Equipement Auto",
            "Equipement Moto",
            "Equipement Caravaning",
            "Nautisme",
            "Equipement Nautisme",
            "-- IMMOBILIER –-",
            "Ventes immobilières",
            "Locations",
            "Colocations",
            "Bureaux & Commerces",
            "-- MULTIMEDIA –-",
            "Informatique",
            "Consoles & Jeux vidéo",
            "Image & Son",
            "Téléphonie",
            "-- MAISON –-",
            "Ameublement",
            "Electroménager",
            "Arts de la table",
            "Décoration",
            "Linge de maison",
            "Bricolage",
            "Jardinage",
            "Vêtements",
            "Chaussures",
            "Accessoires & Bagagerie",
            "Montres & Bijoux",
            "Equipement bébé",
            "Vêtements bébé",
            "-- LOISIRS –-",
            "DVD / Films",
            "CD / Musique",
            "Livres",
            "Animaux",
            "Vélos",
            "Sports & Hobbies",
            "Instruments de musique",
            "Collection",
            "Jeux & Jouets",
            "Vins & Gastronomie",
            "-- MATERIEL PROFESSIONNEL –-",
            "Matériel Agricole",
            "Transport – Manutention",
            "BTP - Chantier Gros-œuvre",
            "Outillage - Matériaux 2nd-œuvre",
            "Équipements Industriels",
            "Restauration – Hôtellerie",
            "Fournitures de Bureau",
            "Commerces & Marchés",
            "Matériel Médical",
            "-- SERVICES –-",
            "Prestations de services",
            "Billetterie",
            "Evénements",
            "Cours particuliers",
            "Covoiturage"});
            this.metroComboBox1.Location = new System.Drawing.Point(23, 113);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "Choisissez une catégorie";
            this.metroComboBox1.Size = new System.Drawing.Size(195, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            this.metroComboBox1.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(23, 185);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(152, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Titre de l\'annonce:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(644, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(23, 213);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(666, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(23, 253);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(159, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Texte de l\'annonce:";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(490, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(175, 175);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(23, 281);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Multiline = true;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(666, 177);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBox2.TabIndex = 2;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel4.Location = new System.Drawing.Point(23, 482);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 25);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Prix:";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(46, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(73, 484);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(68, 23);
            this.metroTextBox3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBox3.TabIndex = 2;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox3.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            this.metroTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox3_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel5.Location = new System.Drawing.Point(147, 482);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(21, 25);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "€";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(73, 529);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(145, 32);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Photo 1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(289, 529);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(145, 32);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Photo 2";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton3.Location = new System.Drawing.Point(507, 529);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(145, 32);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Photo 3";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.Location = new System.Drawing.Point(289, 653);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(145, 35);
            this.metroButton4.TabIndex = 4;
            this.metroButton4.Text = "Ajouter";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.ItemHeight = 23;
            this.cb3.Location = new System.Drawing.Point(283, 73);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(174, 29);
            this.cb3.Style = MetroFramework.MetroColorStyle.Orange;
            this.cb3.TabIndex = 8;
            this.cb3.UseSelectable = true;
            this.cb3.Visible = false;
            this.cb3.SelectedIndexChanged += new System.EventHandler(this.cb3_SelectedIndexChanged);
            this.cb3.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // cb4
            // 
            this.cb4.FormattingEnabled = true;
            this.cb4.ItemHeight = 23;
            this.cb4.Location = new System.Drawing.Point(498, 73);
            this.cb4.Name = "cb4";
            this.cb4.PromptText = "Modèle";
            this.cb4.Size = new System.Drawing.Size(174, 29);
            this.cb4.Style = MetroFramework.MetroColorStyle.Orange;
            this.cb4.TabIndex = 8;
            this.cb4.UseSelectable = true;
            this.cb4.Visible = false;
            this.cb4.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.ItemHeight = 23;
            this.cb1.Location = new System.Drawing.Point(283, 112);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(174, 29);
            this.cb1.Style = MetroFramework.MetroColorStyle.Orange;
            this.cb1.TabIndex = 8;
            this.cb1.UseSelectable = true;
            this.cb1.Visible = false;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            this.cb1.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.ItemHeight = 23;
            this.cb2.Location = new System.Drawing.Point(498, 112);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(174, 29);
            this.cb2.Style = MetroFramework.MetroColorStyle.Orange;
            this.cb2.TabIndex = 8;
            this.cb2.UseSelectable = true;
            this.cb2.Visible = false;
            this.cb2.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // cb5
            // 
            this.cb5.FormattingEnabled = true;
            this.cb5.ItemHeight = 23;
            this.cb5.Location = new System.Drawing.Point(283, 151);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(174, 29);
            this.cb5.Style = MetroFramework.MetroColorStyle.Orange;
            this.cb5.TabIndex = 8;
            this.cb5.UseSelectable = true;
            this.cb5.Visible = false;
            this.cb5.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // cb6
            // 
            this.cb6.FormattingEnabled = true;
            this.cb6.ItemHeight = 23;
            this.cb6.Location = new System.Drawing.Point(498, 151);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(174, 29);
            this.cb6.Style = MetroFramework.MetroColorStyle.Orange;
            this.cb6.TabIndex = 8;
            this.cb6.UseSelectable = true;
            this.cb6.Visible = false;
            this.cb6.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb1.CustomButton.Image = null;
            this.tb1.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.tb1.CustomButton.Name = "";
            this.tb1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb1.CustomButton.TabIndex = 1;
            this.tb1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb1.CustomButton.UseSelectable = true;
            this.tb1.CustomButton.Visible = false;
            this.tb1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb1.IconRight = true;
            this.tb1.Lines = new string[0];
            this.tb1.Location = new System.Drawing.Point(498, 115);
            this.tb1.MaxLength = 32767;
            this.tb1.Name = "tb1";
            this.tb1.PasswordChar = '\0';
            this.tb1.PromptText = "Kilométrage";
            this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb1.SelectedText = "";
            this.tb1.SelectionLength = 0;
            this.tb1.SelectionStart = 0;
            this.tb1.ShortcutsEnabled = true;
            this.tb1.Size = new System.Drawing.Size(174, 23);
            this.tb1.Style = MetroFramework.MetroColorStyle.Orange;
            this.tb1.TabIndex = 9;
            this.tb1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb1.UseCustomBackColor = true;
            this.tb1.UseSelectable = true;
            this.tb1.Visible = false;
            this.tb1.WaterMark = "Kilométrage";
            this.tb1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb1.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.tb1.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            this.tb1.VisibleChanged += new System.EventHandler(this.tb1_VisibleChanged_1);
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb1_KeyPress);
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.Location = new System.Drawing.Point(643, 117);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(28, 19);
            this.km.TabIndex = 10;
            this.km.Text = "Km";
            this.km.Visible = false;
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(429, 156);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(32, 19);
            this.cc.TabIndex = 12;
            this.cc.Text = "cm³";
            this.cc.Visible = false;
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb2.CustomButton.Image = null;
            this.tb2.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.tb2.CustomButton.Name = "";
            this.tb2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb2.CustomButton.TabIndex = 1;
            this.tb2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb2.CustomButton.UseSelectable = true;
            this.tb2.CustomButton.Visible = false;
            this.tb2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb2.IconRight = true;
            this.tb2.Lines = new string[0];
            this.tb2.Location = new System.Drawing.Point(284, 154);
            this.tb2.MaxLength = 32767;
            this.tb2.Name = "tb2";
            this.tb2.PasswordChar = '\0';
            this.tb2.PromptText = "Cylindrée";
            this.tb2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb2.SelectedText = "";
            this.tb2.SelectionLength = 0;
            this.tb2.SelectionStart = 0;
            this.tb2.ShortcutsEnabled = true;
            this.tb2.Size = new System.Drawing.Size(174, 23);
            this.tb2.Style = MetroFramework.MetroColorStyle.Orange;
            this.tb2.TabIndex = 11;
            this.tb2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb2.UseCustomBackColor = true;
            this.tb2.UseSelectable = true;
            this.tb2.Visible = false;
            this.tb2.WaterMark = "Cylindrée";
            this.tb2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb2.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.tb2.TextChanged += new System.EventHandler(this.metroComboBox1_TextChanged);
            this.tb2.VisibleChanged += new System.EventHandler(this.tb2_VisibleChanged);
            this.tb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(678, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.pictureBox4.Location = new System.Drawing.Point(614, -28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 33);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(528, 567);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(307, 567);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 567);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Ajouter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(712, 695);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.km);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ajouter";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Ajouter une annonce";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Ajouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroComboBox cb3;
        private MetroFramework.Controls.MetroComboBox cb4;
        private MetroFramework.Controls.MetroComboBox cb1;
        private MetroFramework.Controls.MetroComboBox cb2;
        private MetroFramework.Controls.MetroComboBox cb5;
        private MetroFramework.Controls.MetroComboBox cb6;
        private MetroFramework.Controls.MetroTextBox tb1;
        private MetroFramework.Controls.MetroLabel km;
        private MetroFramework.Controls.MetroLabel cc;
        private MetroFramework.Controls.MetroTextBox tb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;

    }
}