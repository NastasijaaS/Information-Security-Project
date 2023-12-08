using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nastasija_Stankovic_17955_ZI
{
    class OFB
    {
        byte[] initializationVector;
        bool IVPostavljena;
        XXTEA xxtea;


        public OFB()
        {
            xxtea = new XXTEA();
        }

        public byte[] InitializationVector
        {
            get
            {
                return this.initializationVector;
            }
            set
            {
                this.initializationVector = value;
                IVPostavljena = true;
            }
        }

        public string EnkriptujOFB(string unos)
        {
            if (!IVPostavljena)
            {

                MessageBox.Show("Morate da unesete IV vektor!",
                            "Notification",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                return null;
            }

            Encoding.UTF8.GetBytes(unos);
            int br = unos.Length / 8;
            if (unos.Length % 8 != 0) br++;

            byte[] kljuc = new byte[br * 8];
            byte[] izlaz1 = new byte[unos.Length];
            byte[] IVenk = Encoding.UTF8.GetBytes(xxtea.Kriptovanje(initializationVector).Take(8).ToArray());

            Buffer.BlockCopy(IVenk, 0, kljuc, 0, 8);

            for (int i = 1; i < br; i++)
            {
                byte[] blok = new byte[8];
                Buffer.BlockCopy(kljuc, (i - 1) * 8, blok, 0, 8);
                blok = Encoding.UTF8.GetBytes(xxtea.Kriptovanje(blok).Take(8).ToArray());
                Buffer.BlockCopy(blok, 0, kljuc, i * 8, 8);
            }

            for (int i = 0; i < unos.Length; i++)
            {
                izlaz1[i] = (byte)(unos[i] ^ kljuc[i]);
            }

            string izlaz=Encoding.UTF8.GetString(izlaz1);

            return izlaz;
        }
        public string DekriptujOFB(string data)
        {
            return EnkriptujOFB(data);
        }


    }
}
