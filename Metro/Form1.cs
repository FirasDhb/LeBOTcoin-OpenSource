using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using Leboncoin;
using LeBOTcoin;
using WatiN.Core;
using System.Net;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using HtmlAgilityPack;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Xml;
using System.Text.RegularExpressions;
using MetroFramework;
using GitHubUpdate;
using System.Net.Mail;
using Octokit;

namespace Metro
{
    public partial class Form1 : MetroForm
    {
        BackgroundWorker bw = new BackgroundWorker();
        BackgroundWorker bw1 = new BackgroundWorker();
        private IE browser = null;
        static readonly string PasswordHash = "9@)nI#-l";
        static readonly string SaltKey = "!enC6QD(";
        static readonly string VIKey = "Fi&2J?AYM)^GNhd_";
        public string pwd, mail, ville = string.Empty;
        public string zip, phone;
        public bool checké = true;
        public int prixlbc = 0;
        public int progress;
        static string clothing_st = "", clothing_type = "",brand = "",regdate = "",fuel = "",gearbox = "",furnished = "",real_estate_type = "",energy_rate = "",ges = "",shoe_type = "",shoe_size = "",baby_age = "",animal_type = "";
        public string catégorie = "",textelbc = "",titrelbc = "",photo1 = "",photo2 = "",photo3 = "",model = "",mileage = "",cc = "",surface = "",piece = "",error = "";
        public string[] souscategory;
        public string[] souscategoryname = new string[] { "clothing_type", "clothing_st", "regdate", "fuel", "gearbox", "furnished", "real_estate_type", "energy_rate", "ges", "shoe_type", "shoe_size", "baby_age", "animal_type", "brand" };
        public Form1()
        {
            InitializeComponent();
            Settings.Instance.AutoMoveMousePointerToTopLeft = false;
            Settings.WaitUntilExistsTimeOut = 300;
            Settings.WaitForCompleteTimeOut = 300;
            Settings.Instance.MakeNewIeInstanceVisible = true;
            Settings.Instance.AutoStartDialogWatcher = true;
            Settings.MakeNewIe8InstanceNoMerge = false;
            log.ForeColor = Color.Black;
            loadingCircleToolStripMenuItem1.LoadingCircleControl.Color = Color.FromArgb(243, 119, 53);
            loadingCircleToolStripMenuItem1.LoadingCircleControl.Active = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.WorkerSupportsCancellation = true;
            bw1.DoWork += new DoWorkEventHandler(bw1_DoWork);
            bw1.ProgressChanged += new ProgressChangedEventHandler(bw1_ProgressChanged);
            bw1.WorkerReportsProgress = true;
            bw1.WorkerSupportsCancellation = true;
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            Ajouter f3 = new Ajouter("");
            f3.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TDB f4 = new TDB();
            f4.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { browser.Dispose();
                browser.ForceClose();
            }
            catch { }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            var ping = new System.Net.NetworkInformation.Ping();
            try
            {
                    var result = ping.Send("www.leboncoin.fr");
                    if (result.Status == System.Net.NetworkInformation.IPStatus.Success)
                    {
                        toolStripStatusLabel1.Text = "  En ligne";
                    }
            }
            catch { toolStripStatusLabel1.Text = "  Erreur réseau"; }
            loadingCircleToolStripMenuItem1.LoadingCircleControl.Active = false;
            loadingCircleToolStripMenuItem1.LoadingCircleControl.Visible = false;
        }
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages["tabPage3"])//your specific tabname
            {
                // Renouveller
                if (metroTextBox1.Text != string.Empty && metroTextBox2.Text != string.Empty) { metroLabel7.Visible = false; } else { metroLabel7.Visible = true; }
                listBox2.Items.Clear();
                SQLiteConnection maConnexion;
                maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
                maConnexion.Open();
                string sql = "Select name From sqlite_master where type='table' order by name";
                SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
                SQLiteDataReader reader = commande.ExecuteReader();
                int i = 0;
                while (reader.Read())
                listBox2.Items.Add(reader.GetString(i));
                maConnexion.Close();
                if (listBox2.Items.Count == 0) { ((System.Windows.Forms.Control)tabPage3).Enabled = false;
                    tabPage3.BackColor = Color.WhiteSmoke;
                    listBox2.BackColor = Color.WhiteSmoke;
                }
                else {
                    ((System.Windows.Forms.Control)tabPage3).Enabled = true;
                    tabPage3.BackColor = Color.Transparent;
                    listBox2.BackColor = Color.White;
                }
            }
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages["tabPage2"])//your specific tabname
            {
                // Gérer
                listBox1_SelectedIndexChanged(sender, e);
                listBox1.Items.Clear();
                SQLiteConnection maConnexion;
                maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
                maConnexion.Open();
                string sql = "Select name From sqlite_master where type='table' order by name";
                SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
                SQLiteDataReader reader = commande.ExecuteReader();
                int i = 0;
                while (reader.Read())
                    listBox1.Items.Add(reader.GetString(i));
                i = i + 1;
                maConnexion.Close();
            } 
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages["tabPage1"])//your specific tabname
            {
                // Accueil
            }
        }


        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox2.SetSelected(i, true);
                }
            }
            else
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox2.SetSelected(i, false);
                }
            }
        }
        private void Messageerreur(object sender, EventArgs e)
        {
            if(metroTextBox5.Text!=String.Empty && metroTextBox6.Text != String.Empty && toolStripStatusLabel1.Text != "  Erreur réseau") { metroButton1.Enabled = true; }else { metroButton1.Enabled = false; }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Items.Count != 0)
            {
                if (listBox2.SelectedItem == null)
                {
                    metroButton4.Enabled = false;
                }
                else
                {
                    if (metroTextBox1.Text != string.Empty && metroTextBox2.Text != string.Empty)
                    {
                        if (toolStripStatusLabel1.Text != "  Erreur réseau")
                        {
                            if (bw.IsBusy == false && bw1.IsBusy == false)
                            { metroButton4.Enabled = true; }
                            if (bw.IsBusy == true && bw1.IsBusy == false)
                            { metroButton4.Enabled = false; }
                            if (bw.IsBusy == false && bw1.IsBusy == true)
                            { metroButton4.Enabled = false; }
                            if (bw.IsBusy == true && bw1.IsBusy == true)
                            { metroButton4.Enabled = false; }
                        }
                    }
                }
            }
        }

        public async void Checker()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
                var repo = await client.Release.GetAll("Maartin10", "LeBOTcoin");
                var checker = new UpdateChecker("Maartin10", "LeBOTcoin");
                var versionactuelle = new Version(ProductVersion);
                var versionnouvelle = new Version(repo[0].TagName.Substring(1));
                if (versionactuelle < versionnouvelle)
                {
                    var result = new UpdateNotifyDialog(checker).ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        checker.DownloadAsset("LeBOTcoin.", ".Setup.msi", repo[0].TagName); // "LeBOTcoin.v1.0.0.Setup.msi"
                        Close();
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ce projet n'est plus actualisé mais passe en Open Source."+Environment.NewLine+"Cliquez sur \"Oui\" pour vérifier si une mise à jour est disponible.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { System.Diagnostics.Process.Start("https://github.com/Maartin10/LeBOTcoin/"); }
            Checker();
            if (!File.Exists("LeBOTcoin.sqlite"))
            {
                SQLiteConnection.CreateFile("LeBOTcoin.sqlite");
                MessageBox.Show("Bienvenue sur LeBOTcoin!" + Environment.NewLine + "Cette application vous permet de gérer et de renouveler facilement vos annonces Leboncoin." + Environment.NewLine+ Environment.NewLine +"Pour commencer, allez dans l'onglet \"Configuration\", et rentrez-y toutes les informations demandées, nécessaires au fonctionnement de l'application." + Environment.NewLine +"Ensuite, allez dans l'onglet \"Gérer\" puis sur le bouton Ajouter pour ajouter votre première annonce" + Environment.NewLine + Environment.NewLine + "Une fois tout cela fait, rendez-vous dans l'onglet \"Renouveler\", puis sélectionnez les annonces que vous souhaitez rafraîchir.");
            }
            metroTabControl1.SelectedTab = tabPage1;
            if (File.Exists("config.xml"))
            {
                XmlReader xmlReader = XmlReader.Create("config.xml");
                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "config"))
                    {
                        try
                        {
                            metroTextBox1.Text = Decrypt(xmlReader.GetAttribute("le"));
                            metroTextBox2.Text = Decrypt(xmlReader.GetAttribute("bon"));
                            metroTextBox4.Text = Decrypt(xmlReader.GetAttribute("phone"));
                            metroComboBox1.Items.Add(Decrypt(xmlReader.GetAttribute("coin")));
                            metroComboBox1.SelectedIndex = 0;
                            metroCheckBox2.Checked = Convert.ToBoolean(xmlReader.GetAttribute("check"));
                            string cp = Decrypt(xmlReader.GetAttribute("coin"));
                            metroTextBox3.Text = (cp.Length > 4) ? cp.Substring(cp.Length - 5, 5) : cp; ;
                        }
                        catch { }
                    }
                }
            }
        }
        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                if (string.IsNullOrWhiteSpace(log.Text))
                {
                    Invoke(new Action(() =>
                    {
                        log.Text = e.UserState as string;
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        log.Text = log.Text + Environment.NewLine + e.UserState as string;
                    }));
                }
            }
            if (e.ProgressPercentage == 1 )
            {
                float y = metroProgressBar1.Value + (10 / Selecteditems.Count);
                progress = (Int32)y;
                timer1.Start();
                Invoke(new Action(() =>{ notifyIcon1.Text = "LeBOTcoin - " + metroProgressBar1.ProgressPercentText; }));
            }
            if (e.ProgressPercentage == 100)
            {
                Invoke(new Action(() =>
                { metroProgressBar1.Value = 0;
                notifyIcon1.Text = "LeBOTcoin";}));
            }
        }
        void bw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                if (string.IsNullOrWhiteSpace(log.Text))
                {
                    Invoke(new Action(() =>
                    {
                        log.Text = e.UserState as string;
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        log.Text = log.Text + Environment.NewLine + e.UserState as string;
                    }));
                }
            }
            if (e.ProgressPercentage == 1)
            {
                float y = metroProgressBar1.Value + (13 / Selecteditems.Count);
                progress = (Int32)y;
                timer1.Start();
                Invoke(new Action(() => { notifyIcon1.Text = "LeBOTcoin - " + metroProgressBar1.ProgressPercentText; }));
            } if (e.ProgressPercentage == 100) {
                Invoke(new Action(() =>
            { metroProgressBar1.Value = 0;
            notifyIcon1.Text = "LeBOTcoin";}));}
        }
        public void Leboncoin(BackgroundWorker worker, int z)
        {
            if (!log.Text.Contains("Chargement..."))
            {
                worker.ReportProgress(0, "Chargement...");
            }
            browser.GoTo("https://www.leboncoin.fr/");
            browser.WaitForComplete();
            worker.ReportProgress(1);
            if (browser.Div(Find.ByClass("clearfix")).Exists)
            {
                if (!log.Text.Contains("- Connecté"))
                {
                    worker.ReportProgress(0, "- Connecté");
                }
            }
            else
            {
                worker.ReportProgress(0, "- En cours de connexion...");
                browser.Button(Find.ByClass("button-flat button-secondary popin-open trackable custom-small-hidden")).Click();
                browser.ElementOfType<TextFieldExtended>(Find.ByName("st_username")).Value = mail;
                browser.TextField(Find.ByName("st_passwd")).Value = pwd;
                try
                {
                    browser.Button(Find.ByValue("Se connecter")).Click();
                    browser.WaitForComplete();
                    if (browser.Div(Find.ByClass("create")).Exists)
                    {
                        if (!log.Text.Contains("Connecté"))
                        {
                            worker.ReportProgress(0, "- Connecté");
                        }
                    }else if (browser.ContainsText("Votre identifiant ou mot de passe est incorrect") || browser.ContainsText("Aucun compte ne correspond à cette adresse e-mail"))
                    {
                        worker.ReportProgress(0, " ");
                        worker.ReportProgress(0, "-- Votre identifiant ou mot de passe est incorrect --");
                        Kill("connection");
                    }
                }catch {
                    worker.ReportProgress(0, "- Erreur lors de la connection.");
                    Kill("connection");
                }
            }
            if (error != "connection")
            {
                worker.ReportProgress(1);
                browser.GoTo("https://compteperso.leboncoin.fr/account/index.html?ca=12_s");
                // Suppression de l'annonce
                if (browser.Link(Find.ByText(titrelbc)).Exists)
                {
                    browser.Link(Find.ByText(titrelbc)).Click();
                    worker.ReportProgress(0, " ");
                    worker.ReportProgress(0, "- Suppression de \"" + titrelbc + "\" en cours...");
                    browser.Link(Find.ByTitle("Supprimer l'annonce")).Click();
                    worker.ReportProgress(1);
                    browser.WaitForComplete();
                    browser.Button(Find.ByName("continue")).Click();
                    if (browser.ContainsText("L'annonce ci-dessous ne peut pas être supprimée, soit parce qu'elle a déjà été supprimée soit parce qu'elle est en cours de suppression ou de validation") || browser.Text.Contains("Cette annonce est désactivée"))
                    {
                        worker.ReportProgress(0, "- L'annonce a déjà été supprimée!");
                    }
                    else
                    {
                        browser.Button(Find.ByValue("Valider")).Click();
                        if (browser.ContainsText("Votre demande de suppression a bien été prise en compte"))
                        {
                            worker.ReportProgress(0, "- L'annonce a été supprimée");
                        }
                        else
                        {
                            worker.ReportProgress(0, "- Erreur lors de la suppression de l'annonce");
                        }
                    }
                    worker.ReportProgress(1);
                }
                // Mise en ligne de l'annonce
                browser.GoTo("https://compteperso.leboncoin.fr/account/index.html?ca=12_s");
                worker.ReportProgress(0, " ");
                worker.ReportProgress(0, "- Mise en ligne de \"" + titrelbc + "\"...");
                browser.WaitForComplete();
                browser.Link(Find.ByText("Déposez une annonce")).Click();
                worker.ReportProgress(1);
                browser.WaitForComplete();
                Invoke(new Action(() =>
                {
                    browser.RunScript("$('#category option').filter(function(i, e) { return $(e).text() == '" + catégorie + "'}).prop('selected', 'selected').trigger('change');");
                    browser.TextField(Find.ById("subject")).Value = titrelbc;
                    browser.TextField(Find.ById("body")).Value = textelbc;
                    browser.ElementOfType<TextFieldExtended>(Find.ById("price")).Value = prixlbc.ToString();
                    browser.TextField(Find.ByName("zipcode")).Value = zip;
                    browser.TextField(Find.ByName("city")).Value = ville;
                    if (browser.ElementOfType<TextFieldExtended>(Find.ById("phone")).Value == "")
                    {
                        browser.ElementOfType<TextFieldExtended>(Find.ById("phone")).Value = phone;
                    }
                    if (checké == true) { browser.Label("phone_hidden").Click(); }
                    for (int i = 0; i < souscategory.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(souscategory[i]))
                        {
                            try { browser.RunScript("$('#" + souscategoryname[i] + " option').filter(function(i, e) { return $(e).text() == \"" + souscategory[i] + "\"}).prop('selected', 'selected').trigger('change');"); }
                            catch { }
                            if (catégorie == "Voitures" && souscategoryname[i] == "brand")
                            {
                                browser.RunScript("$('#brand option[value=\"" + souscategory[i] + "\"]').prop('selected', true).trigger('change');");
                                browser.SelectList(Find.ById("model")).WaitUntil("disabled", false.ToString());
                                browser.RunScript("$('#model option[value=\"" + model + "\"]').prop('selected', true).trigger('change');");
                            }
                        }
                    }
                    if (browser.ElementOfType<TextFieldExtended>(Find.ById("mileage")).Parent.Parent.Parent.Parent.ClassName == "field") { browser.ElementOfType<TextFieldExtended>(Find.ById("mileage")).Value = mileage; }
                    if (browser.ElementOfType<TextFieldExtended>(Find.ById("cubic_capacity")).Parent.Parent.Parent.Parent.ClassName == "field") { browser.ElementOfType<TextFieldExtended>(Find.ById("cubic_capacity")).Value = cc; }
                    if (browser.ElementOfType<TextFieldExtended>(Find.ById("square")).Parent.Parent.Parent.Parent.ClassName == "field") { browser.ElementOfType<TextFieldExtended>(Find.ById("square")).Value = surface; }
                    if (browser.ElementOfType<TextFieldExtended>(Find.ById("rooms")).Parent.Parent.ClassName == "field") { browser.ElementOfType<TextFieldExtended>(Find.ById("rooms")).Value = piece; }
                }));
                worker.ReportProgress(1);
                if (photo1 != "")
                {
                    if (File.Exists(photo1))
                    {
                        browser.FileUpload(Find.ById("image0")).Set(photo1);
                        Invoke(new Action(() => { FocusToPreviousWindow(); }));
                        worker.ReportProgress(0, "Téléchargement de l'image 1...");
                        browser.Div("uploadPhoto-0").WaitUntil<Element>(element => element.GetAttributeValue("data-state").Equals("uploaded"));
                    }
                    else { worker.ReportProgress(0, "Image 1 non trouvée!"); }
                    worker.ReportProgress(1);
                }
                if (photo2 != "")
                {
                    if (File.Exists(photo2))
                    {
                        browser.FileUpload(Find.ById("image1")).Set(photo2);
                        Invoke(new Action(() => { FocusToPreviousWindow(); }));
                        worker.ReportProgress(0, "Téléchargement de l'image 2...");
                        browser.Div("uploadPhoto-1").WaitUntil<Element>(element => element.GetAttributeValue("data-state").Equals("uploaded"));
                    }
                    else { worker.ReportProgress(0, "Image 2 non trouvée!"); }
                    worker.ReportProgress(1);
                }
                if (photo3 != "")
                {
                    if (File.Exists(photo3))
                    {
                        browser.FileUpload(Find.ById("image2")).Set(photo3);
                        Invoke(new Action(() => { FocusToPreviousWindow(); }));
                        worker.ReportProgress(0, "Téléchargement de l'image 3...");
                        browser.Div("uploadPhoto-2").WaitUntil<Element>(element => element.GetAttributeValue("data-state").Equals("uploaded"));
                    }
                    else { worker.ReportProgress(0, "Image 3 non trouvée!"); }
                    worker.ReportProgress(1);
                }

                browser.CheckBox(Find.ById("phone_hidden")).Click();
                //Valider
                if (browser.Button(Find.ById("newadSubmit")).Exists) { browser.Button(Find.ById("newadSubmit")).Click(); }
                browser.CheckBox(Find.ById("accept_rule")).Click();
                if (browser.Button(Find.ById("lbc_submit")).Exists)
                {
                    browser.Button(Find.ById("lbc_submit")).Click();
                }
                if (browser.ContainsText("Nous avons bien reçu votre annonce. Nous vous remercions pour votre confiance."))
                {
                    worker.ReportProgress(0, "- Annonce mise en ligne!");
                }
                else
                {
                    worker.ReportProgress(0, "- Problème lors de la mise en ligne");
                }
                worker.ReportProgress(1);
                // FIN

                if (rang != 0)
                {
                    if (z == 1) { Click1(); }else if (z == 2) { Click2(); }
                    worker.CancelAsync();
                }
                else
                {
                    worker.ReportProgress(100);
                    worker.ReportProgress(0, " ");
                    worker.ReportProgress(0, "--  MISE EN LIGNE TERMINÉE --");
                    Invoke(new Action(() =>
                    {
                        browser.ForceClose();
                        browser.Dispose();
                        notifyIcon1.BalloonTipTitle = "Mise en ligne terminée!";
                        notifyIcon1.BalloonTipText = "LeBOTcoin a bien renouvelé vos annonces.";
                        notifyIcon1.ShowBalloonTip(3500);
                    }));
                }
            }
            worker.Dispose();
        }
        public void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Leboncoin(bw, 2);
        }
        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            Leboncoin(bw1, 1);
        }
        public int rang;
        public void Kill(string erreur) 
        {
            Invoke(new Action(() =>
            {
            bw.CancelAsync();
            bw1.CancelAsync();
            bw.Dispose();
            bw1.Dispose();
            metroProgressBar1.Value = 0;
            error = erreur;
            browser.ForceClose();
            browser.Dispose();
            }));
        }
        private void Click1()
        
        {
            bw1.CancelAsync();
            SQLiteConnection maConnexion;
            rang = rang - 1;
            maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
            maConnexion.Open();
            string sql = "select * from " + Selecteditems[rang].ToString();
            SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                prixlbc = (int)reader["prix"];
                catégorie = reader["catégorie"].ToString();
                textelbc = reader["texte"].ToString();
                titrelbc = reader["titre"].ToString();
                photo1 = reader["photo1"].ToString();
                photo2 = reader["photo2"].ToString();
                photo3 = reader["photo3"].ToString();
                clothing_st = reader["clothing_size"].ToString();
                clothing_type = reader["clothing_type"].ToString();
                brand = reader["brand"].ToString();
                regdate = reader["regdate"].ToString();
                fuel = reader["carburant"].ToString();
                gearbox = reader["gearbox"].ToString();
                furnished = reader["furnished"].ToString();
                real_estate_type = reader["real_estate_type"].ToString();
                energy_rate = reader["energy_rate"].ToString();
                ges = reader["ges"].ToString();
                shoe_type = reader["shoe_type"].ToString();
                shoe_size = reader["shoe_size"].ToString();
                baby_age = reader["baby_age"].ToString();
                animal_type = reader["animal_type"].ToString();
                model = reader["model"].ToString();
                mileage = reader["kilometer"].ToString();
                cc = reader["cc"].ToString();
                piece = reader["piece"].ToString();
                surface = reader["surface"].ToString();
            }
            souscategory = new string[] { clothing_type, clothing_st, regdate, fuel, gearbox, furnished, real_estate_type, energy_rate, ges, shoe_type, shoe_size, baby_age, animal_type, brand };
            maConnexion.Close();
            bw.RunWorkerAsync();
        }
        private void Click2()
        {
            bw.CancelAsync();
            SQLiteConnection maConnexion;
            rang = rang - 1;
            maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
            maConnexion.Open();
            string sql = "select * from " + Selecteditems[rang].ToString();
            SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                prixlbc = (int)reader["prix"];
                catégorie = reader["catégorie"].ToString();
                textelbc = reader["texte"].ToString();
                titrelbc = reader["titre"].ToString();
                photo1 = reader["photo1"].ToString();
                photo2 = reader["photo2"].ToString();
                photo3 = reader["photo3"].ToString();
                clothing_st = reader["clothing_size"].ToString();
                clothing_type = reader["clothing_type"].ToString();
                brand = reader["brand"].ToString();
                regdate = reader["regdate"].ToString();
                fuel = reader["carburant"].ToString();
                gearbox = reader["gearbox"].ToString();
                furnished = reader["furnished"].ToString();
                real_estate_type = reader["real_estate_type"].ToString();
                energy_rate = reader["energy_rate"].ToString();
                ges = reader["ges"].ToString();
                shoe_type = reader["shoe_type"].ToString();
                shoe_size = reader["shoe_size"].ToString();
                baby_age = reader["baby_age"].ToString();
                animal_type = reader["animal_type"].ToString();
                model = reader["model"].ToString();
                mileage = reader["kilometer"].ToString();
                cc = reader["cc"].ToString();
                piece = reader["piece"].ToString();
                surface = reader["surface"].ToString();
            }
            souscategory = new string[] {clothing_type, clothing_st, regdate, fuel, gearbox, furnished, real_estate_type, energy_rate, ges, shoe_type, shoe_size, baby_age, animal_type, brand };
            maConnexion.Close();
            bw1.RunWorkerAsync();
        }
        public List<string> Selecteditems = new List<string>();
        private void metroButton4_Click(object sender, EventArgs e)
        {
            rang = listBox2.SelectedItems.Count;
            foreach (var item in listBox2.SelectedItems)
            {
                Selecteditems.Add(item.ToString());
            }
            metroButton4.Enabled = false;
            browser = new IE();
            error = "";
            pwd = metroTextBox2.Text;
            mail = metroTextBox1.Text;
            var zipcode = metroComboBox1.SelectedItem.ToString();
            zip = Regex.Replace(zipcode, @"[^0-9-]+", string.Empty); ;
            ville = Regex.Replace(zipcode, @"[^a-zA-Z]+", string.Empty);
            phone = metroTextBox4.Text;
            checké = metroCheckBox2.Checked;
            log.Text = "";
            Click1();
          
        }
        private void bla()
        {
            SQLiteConnection maConnexion;
            maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
            maConnexion.Open();

            string sql = "create table if not exists Annonces (nom text, prix int)";
            SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
            commande.ExecuteNonQuery();

            string insert = "insert into Annonces (nom, prix) values (@param1, 870)";
            SQLiteCommand annonce = new SQLiteCommand(insert, maConnexion);
            List<string> selectedList = new List<string>();
            foreach (var item in listBox2.SelectedItems)
            {
                selectedList.Add(item.ToString());
            }
            annonce.Parameters.Add(new SQLiteParameter("@param1", string.Join(Environment.NewLine, selectedList)));
            annonce.ExecuteNonQuery();

            maConnexion.Close();
        }
        private void metroButton6_Click(object sender, EventArgs e)
        {
            SQLiteConnection maConnexion;
            maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
            maConnexion.Open();

            foreach (System.String item in listBox2.SelectedItems)
            {
            string sql = "select * from " + item;
            SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
            SQLiteDataReader reader = commande.ExecuteReader();
            int i = 1;
            while (reader.Read())
                log.Text = log.Text + "\n" + reader.GetString(i);
            i = i+1;
        }
            maConnexion.Close();
    }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            SQLiteConnection maConnexion;
            maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
            maConnexion.Open();
            SQLiteCommand getTables = new SQLiteCommand("Select name From sqlite_master where type='table' order by name;", maConnexion);
            SQLiteDataAdapter myCountAdapter = new SQLiteDataAdapter(getTables);
            DataSet myCountDataSet = new DataSet();
            myCountAdapter.Fill(myCountDataSet, "name");
            maConnexion.Close(); 
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                e.DrawBackground();
                Graphics g = e.Graphics;
                Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ?
                             Brushes.OrangeRed : new SolidBrush(e.BackColor);
                g.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font,
                         new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                metroButton8.Enabled = false;
                metroButton9.Enabled = false;
            }
            else
            {
                metroButton8.Enabled = true;
                metroButton9.Enabled = true;
                SQLiteConnection maConnexion;
                maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
                maConnexion.Open();
                string sql = "select * from " + listBox1.SelectedItem;
                SQLiteCommand commande = new SQLiteCommand(sql, maConnexion);
                SQLiteDataReader reader = commande.ExecuteReader();
                titre.Visible = true;
                texte.Visible = true;
                prix.Visible = true;
                metroLabel2.Visible = true;
                titre.Text = reader["titre"].ToString();
                texte.Text = reader["texte"].ToString();
                string price = reader["prix"].ToString();
                prix.Text = price + " €";
                maConnexion.Close();
            //   TextBox tb = new TextBox();
            //   tb.Location = new Point(12, 300);
            //   metroPanel3.Controls.Add(tb);
            }
        }

        private void metroButton7_Click_1(object sender, EventArgs e)
        {
            Ajouter f3 = new Ajouter("");
            f3.ShowDialog();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            SQLiteConnection maConnexion;
            maConnexion = new SQLiteConnection("Data Source=LeBOTcoin.sqlite;Version=3;");
            maConnexion.Open();
            SQLiteCommand blah = new SQLiteCommand(maConnexion);
            blah.CommandText = " DROP Table if exists '" + listBox1.SelectedItem + "'";
            blah.ExecuteNonQuery();
            maConnexion.Close();
            listBox1.ClearSelected();
            metroTabControl1_SelectedIndexChanged(sender,e);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            listBox2.ClearSelected();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress("lebotcoin.signalement@gmail.com", metroTextBox5.Text);
            var toAddress = new MailAddress("lebotcoin.signalement@gmail.com", metroTextBox5.Text);
            const string fromPassword = "LeBOTcoin!!!";
            string subject = "Signalement d'un problème LeBOTcoin -- "+ metroTextBox5.Text;
            string body = metroTextBox6.Text;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            try
            {
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                MetroMessageBox.Show(this, Environment.NewLine + "Problème signalé, merci de faire avancer le projet LeBOTcoin!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Question, 130);
            }
            catch
            {
                MetroMessageBox.Show(this, Environment.NewLine+"Erreur lors de l'envoi du signalement de problème."+Environment.NewLine+ "Veuillez réessayer.", "Erreur d'envoi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 150);}
            metroTextBox5.Text = ""; metroTextBox6.Text = "";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            metroTabControl1_SelectedIndexChanged(sender, e);
        }

        private void log_TextChanged(object sender, EventArgs e)
        {
            log.SelectionStart = log.Text.Length;
            log.ScrollToCaret();
        }
        private void metroButton8_Click(object sender, EventArgs e)
        {
            Ajouter f4 = new Ajouter(listBox1.SelectedItem.ToString());
            f4.ShowDialog();
        }

        private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == "  En ligne") { toolStripStatusLabel2.Image = LeBOTcoin.Properties.Resources.checked_symbol; loadingCircleToolStripMenuItem1.Visible = false; toolStripStatusLabel2.Visible = true; } else if (toolStripStatusLabel1.Text == "  Erreur réseau") { toolStripStatusLabel2.Image = LeBOTcoin.Properties.Resources.wrong; loadingCircleToolStripMenuItem1.Visible = false; toolStripStatusLabel2.Visible = true; }
        }

        private void log_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void metroComboBox1_Enter(object sender, EventArgs e)
        {
            metroToolTip1.Hide(this);
        }

        private void metroTextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (metroComboBox1.Items.Count != 0) { metroComboBox1.Items.Clear(); metroComboBox1.SelectedIndex = -1; }
            if (metroTextBox3.Text.Length == 5)
            {
                using (WebClient webClient = new WebClient())
                {
                    WebClient n = new WebClient();
                    string url = "https://www.leboncoin.fr/beta/ajax/location_list_newad.html?city=&zipcode=" + metroTextBox3.Text +"&searched=";
                    var json = "";
                    try { json = n.DownloadString(url); }
                    catch
                    {
                        MetroMessageBox.Show(this, "Code Postal non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,100);
                    }
                    if (json != "")
                    {

                       HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                       doc.LoadHtml(json);
                       List<HtmlNode> toftitle = doc.DocumentNode.Descendants().Where
                        (x => (x.Name == "li")).ToList();
                        int id = 0;
                        try
                        {
                            while (1 == 1)
                            {
                                List<string> villes = new List<string>();
                                var li = toftitle[id].Descendants("span").ToList();
                                foreach (var item in li)
                                {
                                    villes.Add(item.InnerText);
                                }
                                metroComboBox1.Items.Add(villes[0] + " " + villes[1]);
                                id = id + 1;
                            }
                        }
                        catch
                        {
                            metroComboBox1.Enabled = true;
                            metroComboBox1.SelectedIndex = -1;
                            metroComboBox1.Focus();
                        }
                    }
                }
            }
        }
        public static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }
        public static string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }
        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox3.Text.Length == 5 && metroComboBox1.SelectedIndex != -1 && metroTextBox4.Text.Length == 10) { metroButton3.Enabled=true; } else {metroButton3.Enabled=false; }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressBar1.Value <=progress)
            {
                metroProgressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void metroButton3_Click_2(object sender, EventArgs e)
        {
            try
            {
                string pwd = Encrypt(metroTextBox2.Text);
                string mail = Encrypt(metroTextBox1.Text);
                string zip = Encrypt(metroComboBox1.SelectedItem.ToString());
                string phoncrypt = Encrypt(metroTextBox4.Text);
                new XDocument(
                   new XElement("config",
                   new XAttribute("le", mail),
                   new XAttribute("bon", pwd),
                   new XAttribute("coin", zip),
                   new XAttribute("check", metroCheckBox2.Checked),
                   new XAttribute("phone", phoncrypt)
                )
               )
                .Save("config.xml");
            }catch{MetroMessageBox.Show(this, "Erreur lors de la sauvegarde, vérifiez vos données puis réessayez.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,100);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Hide();
        notifyIcon1.BalloonTipTitle = "LeBOTcoin est toujours actif.";
        notifyIcon1.BalloonTipText ="Double-cliquez sur l'icône pour l'afficher.";
        notifyIcon1.ShowBalloonTip(1500);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void afficherLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetLastActivePopup(IntPtr hWnd);

        [DllImport("user32.dll", ExactSpelling = true)]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        const uint GA_PARENT = 1;
        const uint GA_ROOT = 2;
        const uint GA_ROOTOWNER = 3;

        public IntPtr GetPreviousWindow()
        {
            IntPtr activeAppWindow = GetForegroundWindow();
            if (activeAppWindow == IntPtr.Zero)
                return IntPtr.Zero;

            IntPtr prevAppWindow = GetLastActivePopup(activeAppWindow);
            return IsWindowVisible(prevAppWindow) ? prevAppWindow : IntPtr.Zero;
        }

        public void FocusToPreviousWindow()
        {
            IntPtr prevWindow = GetPreviousWindow();
            if (prevWindow != IntPtr.Zero)
                SetForegroundWindow(prevWindow);
        }
    }
}
