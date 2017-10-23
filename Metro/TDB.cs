using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatiN.Core;
using WatiN.Core.Native;

namespace LeBOTcoin
{
    public partial class TDB : MetroForm
    {
        private IE browser = null;
        public TDB()
        {
            InitializeComponent();
            Settings.Instance.AutoMoveMousePointerToTopLeft = false;
            Settings.Instance.MakeNewIeInstanceVisible = false;
            browser = new IE();
        }

        private void TDB_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void TDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            browser.Dispose();
        }

        private void TDB_Shown(object sender, EventArgs e)
        {
            browser.GoTo("https://www.leboncoin.fr/");
            if (browser.Div(Find.ByClass("clearfix")).Exists)
            {
                metroLabel2.Text = "Connecté";
            }
            else
            {
                metroLabel2.Text = "En cours de connexion...";
                browser.Button(Find.ByClass("button-white button-secondary popin-open trackable custom-small-hidden")).Click();
                browser.ElementOfType<TextFieldExtended>(Find.ByName("st_username")).Value = "bridoux.martin@gmail.com";
                browser.TextField(Find.ByName("st_passwd")).Value = "1999mbmb";
                browser.Button(Find.ByValue("Se connecter")).Click();
                browser.WaitForComplete();
                if (browser.Div(Find.ByClass("create")).Exists)
                {
                    metroLabel2.Text = "Connecté";
                }
                else
                {
                    metroLabel2.Text = "Impossible de se connecter";
                }
            }
        }

    }
}
