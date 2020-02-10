using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övn
{
    class Kontakt
    {
        private string _förnamn;
        private string _efternamn;
        private string _epost;
        private string _tele;

        public Kontakt(string förnamn, string efternamn, string epost, string tele)
        {
            this._förnamn = förnamn;
            this._efternamn = efternamn;
            this._epost = epost;
            this._tele = tele;
        }
        public Kontakt(string förnamn)
        {
            this._förnamn = förnamn;
        }

        public string Förnamn
        {
            get { return _förnamn; }
            set { _förnamn = value; }
        }
        public string Efternamn
        {
            get { return _efternamn; }
            set { _efternamn = value; }
        }
        public string Epost
        {
            get { return _epost; }
            set { _epost = value; }
        }
        public string Tele
        {
            get { return _tele; }
            set { _tele = value; }
        }
    }
}
