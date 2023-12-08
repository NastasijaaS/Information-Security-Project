using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nastasija_Stankovic_17955_ZI
{
    class OTP
    {
        private string kljuc;

        private string kljucPutanja;
        private string tekstPutanja;
        private string tekstIzlaz;


        public OTP()
        {
        }

        public String Kljuc
        {
            get
            {
                return kljuc;
            }
            set
            {
                this.kljuc = value;
            }
        }
        public string PostaviDifoltniKljuc()
        {
            try
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] randomNumbers = new byte[16];
                rng.GetNonZeroBytes(randomNumbers);
                string dif= Encoding.Default.GetString(randomNumbers);

                Kljuc = dif;
                return dif;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public string KriptovanjeDekriptovanje<T>(T ulaz)
        {
    
            string unos = ulaz.ToString();

            byte[] unosB = Encoding.ASCII.GetBytes(unos);
            byte[] k = Encoding.ASCII.GetBytes(kljuc);
            byte[] rez = new byte[unosB.Length];

            int i = 0;
            while( i < unos.Length)
            {
                rez[i] = (byte)(unosB[i] ^ k[0]);
                Array.Copy(k, 1, k, 0, k.Length - 1);
                k[k.Length - 1] = (byte)(k[2 % k.Length] ^ k[3 % k.Length]);
                i++;
            }
            string rezultat;
            rezultat = Encoding.ASCII.GetString(rez);
            return rezultat;
        }

        public byte[] OTPEnkriptujDekriptujP(byte[] kljuc, byte[] podaci)
        {

            byte[] rez = new byte[podaci.Length];

            int i = 0;
            while (i < podaci.Length)
            {
                rez[i] = (byte)(podaci[i] ^ kljuc[i]);

                i++;
            }
            return rez;

        }

        public void EnkriptujDekriptujNit(int broj,int blokV)
        {
            FileStream kljuc = new FileStream(kljucPutanja, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream podaci = new FileStream(tekstPutanja, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream izlaz = new FileStream(tekstIzlaz, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);

            byte[] p = new byte[blokV];
            byte[] k = new byte[blokV];

            podaci.Position = broj * blokV;
            podaci.Read(p, 0, blokV);

            kljuc.Position = broj * blokV;
            kljuc.Read(k, 0, blokV);

            p = OTPEnkriptujDekriptujP(k, p);

            izlaz.Position = broj * blokV;
            izlaz.Write(p, 0, blokV);

            kljuc.Close();
            podaci.Close();
            izlaz.Close();

        }

        public void ParallelOTP(int brojNiti,string kljucPutanja,string tekstPutanja,string tekstIzlaz)
        {
            this.kljucPutanja = kljucPutanja;
            this.tekstPutanja = tekstPutanja;
            this.tekstIzlaz = tekstIzlaz;

            FileStream kljuc = new FileStream(kljucPutanja, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream podaci = new FileStream(tekstPutanja, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream izlaz = new FileStream(tekstIzlaz, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);

            Thread[] niti = new Thread[brojNiti];

            int blokS = (int)(podaci.Length / brojNiti);

            for (int i = 0; i < brojNiti; i++)
            {
                int pom = i;
                niti[i] = new Thread(new ThreadStart(() => { EnkriptujDekriptujNit(pom, blokS); }));
            }

            for (int i = 0; i < brojNiti; i++)
            {
                niti[i].Start();
            }

            for (int i = 0; i < brojNiti; i++)
            {
                niti[i].Join();
            }

            int lastL = (int)podaci.Length - brojNiti * blokS;

            byte[] k = new byte[lastL];
            byte[] p = new byte[lastL];

            podaci.Position = podaci.Length - lastL;
            podaci.Read(p, 0, lastL);

            kljuc.Position = kljuc.Length - lastL;
            kljuc.Read(k, 0, lastL);

            p = OTPEnkriptujDekriptujP(k, p);
            izlaz.Position = (int)podaci.Length - lastL;
            izlaz.Write(p, 0, lastL);

            kljuc.Close();
            podaci.Close();
            izlaz.Close();
        }

    }
}
