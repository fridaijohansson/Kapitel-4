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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnöppna_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                FileStream inström = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                StreamReader läsare = new StreamReader(inström);

                string förnamn = läsare.ReadLine();
                while(förnamn != null)
                {
                    kontaktlista.Add(new Kontakt()
                    {
                        Förnamn = förnamn,
                        Efternamn = läsare.ReadLine(),
                        Epost = läsare.ReadLine(),
                        Tele = läsare.ReadLine()
                    }) ;
                    förnamn = läsare.ReadLine();
                }
                
            }
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            string förnamn = tbxFör.Text;
            string efternamn = tbxEfter.Text;
            string epost = tbxEpost.Text;
            string tele = tbxTele.Text;

            Kontakt kontakt = new Kontakt(förnamn, efternamn, epost, tele);
            kontaktlista.Add(kontakt);


            DialogResult dr = saveFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                FileStream utsröm = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter skrivare = new StreamWriter(utsröm);


                foreach(Kontakt k in kontaktlista)
                {
                    skrivare.WriteLine(k.Förnamn);
                    skrivare.WriteLine(k.Efternamn);
                    skrivare.WriteLine(k.Epost);
                    skrivare.WriteLine(k.Tele);
                }
                
            }
        }
    }
}
