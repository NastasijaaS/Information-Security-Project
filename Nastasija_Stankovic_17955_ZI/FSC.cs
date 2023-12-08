using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nastasija_Stankovic_17955_ZI
{
    class FSC
    {
        private string slova;

        private string square13;
        private string square2;
        private string square4;

        SHA1 sha1;
        private string hesh;
        public FSC()
        {
            slova = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            sha1 = new SHA1();

        }
        public String Hesh
        {
            get
            {
                return hesh;
            }
            set
            {
                this.hesh = value;
            }
        }
        public void SetSquare(string kljuc1,string kljuc2)
        {
            square13 = slova;
            square2 = kljuc1;
            square4 = kljuc2;
        }

        public string[] PostaviDifoltniSquare()
        {
            string[] dif = new string[2];
            dif[0] = "POIUYTREWQASDGFHJIKLZXCVB";
            dif[1] = "MJNHBGVFCDSXPOULAZTREWQYR";

            square2 = dif[0];
            square4 = dif[1];

            return dif;
            
        }


        public String Kriptovanje(String s)
        {
            string unos = Regex.Replace(s, @"\s+", "");
            unos = unos.Replace('j', 'i');
            if (unos.Length % 2 != 0)
                unos = unos + "X";
            Hesh=sha1.GetHash(unos.ToUpper());
            char[] parovi = new char[2];
            String izlaz = "";
            String[] enk = new String[unos.Length / 2];
            enk = getPairs(unos.ToUpper());

            int i = 0;
            while(i < enk.Length)
            {
                int a_i = 0;
                int a_j = 0;
                int b_i = 0;
                int b_j = 0;
                int aPos = 0;
                parovi[0] = enk[i].ElementAt(0);
                parovi[1] = enk[i].ElementAt(1);

                aPos = this.square13.IndexOf(parovi[0]);
                a_i = aPos / 5;
                a_j = aPos % 5;
                aPos = this.square13.IndexOf(parovi[1]);
                b_i = aPos / 5;
                b_j = aPos % 5;
                izlaz += (this.square2[a_i * 5 + b_j]).ToString() + (this.square4[b_i * 5 + a_j]).ToString();

                i++;
            }
            return izlaz;
        }

        public String Dekriptovanje(String s)
        {
            char[] parovi = new char[2];
            String izlaz = "";
            String[] dec = new String[s.Length / 2];
            dec = getPairs(s);
            int i = 0;
            while( i < dec.Length)
            {
                int a_i = 0;
                int a_j = 0;
                int b_i = 0;
                int b_j = 0;
                int aPos = 0;
                parovi[0] = dec[i].ElementAt(0);
                parovi[1] = dec[i].ElementAt(1);

                aPos = this.square2.IndexOf(parovi[0]);
                a_i = aPos / 5;
                a_j = aPos % 5;
                aPos = this.square4.IndexOf(parovi[1]);
                b_i = aPos / 5;
                b_j = aPos % 5;
                izlaz += (this.square13[a_i * 5 + b_j]).ToString() + (this.square13[b_i * 5 + a_j]).ToString();

                i++;
            }
            Hesh = sha1.GetHash(izlaz);
            return izlaz;
        }


        public String[] getPairs(String s)
        {
            String[] tekst = new String[s.Length / 2];

            int br = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                tekst[i] = "" + s.ElementAt(br) + s.ElementAt(br + 1);
                br = br + 2;
            }
            return tekst;
        }
    }
}
