using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace övn
{
    public partial class Form1 : Form
    {
        List<Kontakt> kontaktlista = new List<Kontakt>();

        string öppnadFil = null;
        public Form1()
        {
            InitializeComponent();
        }


        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileStream inström = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                StreamReader läsare = new StreamReader(inström);

                string förnamn = läsare.ReadLine();
                while (förnamn != null)
                {
                    kontaktlista.Add(new Kontakt(förnamn)
                    {
                        Förnamn = förnamn,
                        Efternamn = läsare.ReadLine(),
                        Epost = läsare.ReadLine(),
                        Tele = läsare.ReadLine()
                    });

                    listBox1.Items.Add(kontaktlista[kontaktlista.Count - 1]);
                    förnamn = läsare.ReadLine();
                }

                foreach (Kontakt k in kontaktlista)
                {
                    tbxFör.Text = k.Förnamn;
                    tbxEfter.Text = k.Efternamn;
                    tbxEpost.Text = k.Epost;
                    tbxTele.Text = k.Tele;
                }

                läsare.Dispose();
            }
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Spara(saveFileDialog1.FileName);
            }
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(öppnadFil == null)
            {
                if(DialogResult.OK == saveFileDialog1.ShowDialog())
                {
                    öppnadFil = saveFileDialog1.FileName;
                    Spara(saveFileDialog1.FileName);
                }
                else
                {
                    Spara(saveFileDialog1.FileName);
                }
            }
        }

        private void Spara(string filnamn)
        {
            string förnamn = tbxFör.Text;
            string efternamn = tbxEfter.Text;
            string epost = tbxEpost.Text;
            string tele = tbxTele.Text;

            Kontakt kontakt = new Kontakt(förnamn, efternamn, epost, tele);
            kontaktlista.Add(kontakt);


            FileStream utsröm = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter skrivare = new StreamWriter(utsröm);


            foreach (Kontakt k in kontaktlista)
            {
                skrivare.WriteLine(k.Förnamn);
                skrivare.WriteLine(k.Efternamn);
                skrivare.WriteLine(k.Epost);
                skrivare.WriteLine(k.Tele);
            }
            skrivare.Dispose();
            
        }

        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void läggTillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string förnamn = tbxFör.Text;
            string efternamn = tbxEfter.Text;
            string epost = tbxEpost.Text;
            string tele = tbxTele.Text;

            Kontakt kontakt = new Kontakt(förnamn, efternamn, epost, tele);
            kontaktlista.Add(kontakt);
            listBox1.Items.Add(kontakt);
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kontakt k = listBox1.SelectedItem as Kontakt;
            kontaktlista.Remove(k);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
