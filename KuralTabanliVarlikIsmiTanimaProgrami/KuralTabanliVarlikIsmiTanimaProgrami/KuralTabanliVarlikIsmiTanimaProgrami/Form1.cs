using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuralTabanliVarlikIsmiTanimaProgrami
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        public string metin;
        public bool panelDurum = false;

        KayitSinif kayitFormAna = new KayitSinif();
        SozlukSinif sozlukFormAna = new SozlukSinif();
        TemelSinif temelFormAna = new TemelSinif();
        AnalizSinif analizFormAna = new AnalizSinif();

        private void FormAna_Load(object sender, EventArgs e)
        {
            sozlukFormAna.SozlukleriAl();
        }

        private void FormAna_Resize(object sender, EventArgs e)
        {
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitFormAna.Kaydet(richTextBoxAna.Text);
        }

        private void analizEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PanelAcKapat();
            temelFormAna.MetinParcala(richTextBoxAna.Text.ToString());
            analizFormAna.AnalizEt();
            richTextBoxAna.Text = AnalizSinif.analizEdilenMetin;
            //PanelAcKapat();
        }

        public void PanelAcKapat()
        {
            if (!panelDurum)
            {
                this.panelAna.Visible = true;
                progressBarAna.Visible = true;
                analizEtToolStripMenuItem.Enabled = false;
                kaydetToolStripMenuItem.Enabled = false;
                panelDurum = true;
            }
            else
            {
                panelAna.Visible = false;
                progressBarAna.Visible = false;
                analizEtToolStripMenuItem.Enabled = true;
                kaydetToolStripMenuItem.Enabled = true;
                panelDurum = false;
            }
        }
    }
}

