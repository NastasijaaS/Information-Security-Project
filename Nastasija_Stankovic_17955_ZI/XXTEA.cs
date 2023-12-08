using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nastasija_Stankovic_17955_ZI
{
    class XXTEA
    {
        private uint[] kljuc;
        private bool validanK;
        uint delta = 0x9e3779b9;

        private string enkriptovan;

        public XXTEA()
        {
            kljuc = new UInt32[4];
        }

        public bool ValidnostKljuca
        {
            get
            {
                return this.validanK;
            }
            set
            {
                this.validanK = value;
            }
        }
        public String[] Kljuc
        {
            get
            {
                String[] s = new String[4];
                s[0] = kljuc[0].ToString();
                s[1] = kljuc[1].ToString();
                s[2] = kljuc[2].ToString();
                s[3] = kljuc[3].ToString();
                return s;
            }
            set
            {
                if (value.Length != 4)
                {
                    validanK = false;
                    return;
                }
                bool ok = uint.TryParse(value[0], out kljuc[0]);
                ok &= uint.TryParse(value[1], out kljuc[1]);
                ok &= uint.TryParse(value[2], out kljuc[2]);
                ok &= uint.TryParse(value[3], out kljuc[3]);
                validanK = ok;
            }
        }

        public string[] PostaviDifoltniKljuc()
        {
            try
            {
                string[] dif = new string[4];
                dif[0] = "4802340";
                dif[1] = "0534002";
                dif[2] = "9040241";
                dif[3] = "4384010";

                Kljuc = dif;
                return dif;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        public string Kriptovanje<T>(T source)
        {
            string input = source.ToString();
            uint[] v = PretvoriByteToUInt(Encoding.UTF8.GetBytes(input));

            if (v.Length < 2)
            {
                MessageBox.Show("Unesite tekst koji sadrzi vise od 4 karaktera.",
                            "Notification",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return null;
            }

            int n = v.Length;
            int q = Convert.ToInt32(Math.Floor(Convert.ToDecimal(6 + 52 / n)));

            uint z = v[n - 1], y = v[0];
            uint e, sum = 0;

            while (q-- > 0)
            {
                sum += delta;
                e = sum >> 2 & 3;
                for (int p = 0; p < n; p++)
                {
                    y = v[(p + 1) % n];
                    z = v[p] += MX(sum, y, z, p, e, kljuc);
                }
            }
            byte[] arr = PretvoriUIntUByte(v);
            return Convert.ToBase64String(arr);
        }

        public string Dekriptovanje<T>(T source)
        {

            string input = source.ToString();

            uint[] v = PretvoriByteToUInt(Convert.FromBase64String(input));
            int n = v.Length;

            uint q = Convert.ToUInt32(Math.Floor(Convert.ToDecimal(6 + 52 / n)));

            uint z = v[n - 1], y = v[0];
            uint mx, e, sum = q * delta;

            while (sum != 0)
            {
                e = sum >> 2 & 3;
                for (int p = n - 1; p >= 0; p--)
                {
                    z = v[p > 0 ? p - 1 : n - 1];
                    mx = MX(sum, y, z, p, e, kljuc);
                    y = v[p] -= mx;
                }
                sum -= delta;
            }

            byte[] arr = PretvoriUIntUByte(v);
            return Encoding.ASCII.GetString(arr);
        }

        private static UInt32 MX(UInt32 sum, UInt32 y, UInt32 z, Int32 p, UInt32 e, UInt32[] k)
        {
            return (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
        }

        public byte[] EncryptBMP(string path)
        {
            byte[] bmpPodaci = File.ReadAllBytes(path);
            byte[] header = bmpPodaci.Take(54).ToArray();
            byte[] podaci = bmpPodaci.Skip(54).ToArray();

            string enkriptovanPodatak = Kriptovanje(Encoding.UTF8.GetString(podaci));
            enkriptovan = enkriptovanPodatak;

            byte[] enkPodaci = Encoding.UTF8.GetBytes(enkriptovanPodatak);

            byte[] data = new byte[header.Length + enkPodaci.Length];
            Array.Copy(header, data, header.Length);
            Array.Copy(enkPodaci, 0, data, header.Length, enkPodaci.Length);

            return data;
        }

        public byte[] DecryptBMP(string path)
        {
            byte[] bmpData = File.ReadAllBytes(path);
            byte[] header = bmpData.Take(54).ToArray();

            string dekriptovanPodatak = Dekriptovanje(enkriptovan);
            byte[] dekript = Encoding.UTF8.GetBytes(dekriptovanPodatak);

            byte[] dekPodaci = new byte[header.Length + dekript.Length];
            Array.Copy(header, dekPodaci, header.Length);
            Array.Copy(dekript, 0, dekPodaci, header.Length, dekript.Length);

            return dekPodaci;
        }

        private uint[] PretvoriByteToUInt(byte[] niz)
        {
            int duzina_niz = niz.Length;
            int duzina = duzina_niz / 4;
            if (duzina_niz % 4 != 0)
                duzina++;
            uint[] povratna_vrendost = new uint[duzina];
            int j = 0;
            byte[] pom = new byte[4];
            for (int i = 0; i < duzina_niz; i = i + 4)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (i + k < duzina_niz)
                        pom[k] = niz[i + k];
                    else
                        pom[k] = 0;
                }
                povratna_vrendost[j++] = BitConverter.ToUInt32(pom, 0);
            }
            return povratna_vrendost;
        }

        public byte[] PretvoriUIntUByte(uint[] niz)
        {
            int broj_bajtova = niz.Length * 4;
            byte[] povratna_vrednost = new byte[broj_bajtova];
            byte[] intBytes;
            int j = 0;
            for (int i = 0; i < broj_bajtova; i = i + 4)
            {
                intBytes = BitConverter.GetBytes(niz[j++]);
                povratna_vrednost[i] = intBytes[0];
                povratna_vrednost[i + 1] = intBytes[1];
                povratna_vrednost[i + 2] = intBytes[2];
                povratna_vrednost[i + 3] = intBytes[3];
            }
            return povratna_vrednost;
        }

    }
}

