using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nastasija_Stankovic_17955_ZI
{
    class SHA1
    {
        private uint h0, h1, h2, h3, h4;
      
        public SHA1()
        {
            h0 = 0x67452301;
            h1 = 0xEFCDAB89;
            h2 = 0x98BADCFE;
            h3 = 0x10325476;
            h4 = 0xC3D2E1F0;

        }

        public string GetHash(string unos)
        {
            byte[] file = Encoding.UTF8.GetBytes(unos);
            long length = 8 * file.Length;
            byte[] duzina = BitConverter.GetBytes(length);
            Array.Reverse(duzina);
            byte[] newFile = new byte[file.Length + 1];
            file.CopyTo(newFile, 0);
            byte prvi = 1;
            byte drugi = 0;
            newFile[file.Length] = prvi;

            while (newFile.Length % 64 != 56)
            {
                int oldSize = newFile.Length;
                Array.Resize(ref newFile, oldSize + 1);
                newFile[oldSize] = drugi;
            }
            Array.Resize(ref newFile, newFile.Length + 8);
            System.Buffer.BlockCopy(duzina, 0, newFile, newFile.Length - 8, 8);

            int brBlokova = newFile.Length / 64;
            byte[][] nizBlokova = new byte[brBlokova][];

            for (int i = 0; i < brBlokova; i++)
            {
                nizBlokova[i] = new byte[64];
                nizBlokova[i] = newFile.Skip(i * 64).Take(64).ToArray();
            }

            return ComputeHash(nizBlokova);
        }

        public string ComputeHash(byte[][] niz) 
        {
            int brBlokova = niz.Length;
            for (int i = 0; i < brBlokova; i++)
            {
                uint[] inicijalniBlok = new uint[16];
                inicijalniBlok = PretvoriUUint(niz[i]);

                uint[] blok = new uint[80];
                Array.Copy(inicijalniBlok, 0, blok, 0, 16);
                int j;
                for (j = 16; j < 80; j++)
                {
                    blok[j] = RotirajLevo((blok[j - 3] ^ blok[j - 8] ^ blok[j - 14] ^ blok[j - 16]), 1);
                }
                uint a = h0, b = h1, c = h2, d = h3, e = h4;
                uint f, k, temp;
                for (j = 0; j < 80; j++) 
                {
                    if (j <= 19)
                    {
                        f = (b & c) | (~b & d);
                        k = 0x5A827999;
                    }
                    else if ((j >= 20) && (j <= 39))
                    {
                        f = b ^ c ^ d;
                        k = 0x6ED9EBA1;
                    }
                    else if ((j >= 40) && (j <= 59))
                    {
                        f = (b & c) | (b & d) | (c & d);
                        k = 0x8F1BBCDC;
                    }
                    else
                    {
                        f = b ^ c ^ d;
                        k = 0xCA62C1D6;
                    }
                    temp = RotirajLevo(a, 5) + f + e + k + blok[j];
                    e = d;
                    d = c;
                    c = RotirajLevo(b, 30);
                    b = a;
                    a = temp;
                }
                h0 = h0 + a;
                h1 = h1 + b;
                h2 = h2 + c;
                h3 = h3 + d;
                h4 = h4 + e;
            }

            uint[] hash = new uint[5];
            hash[0] = h0;
            hash[1] = h1;
            hash[2] = h2;
            hash[3] = h3;
            hash[4] = h4;
            byte[] h = PretvoriUIntUByte(hash);

            string s=Encoding.UTF8.GetString(h);
            return s;
        }

        public byte[] PretvoriUIntUByte(uint[] niz)
        {
            int duzina = niz.Length * 4;
            byte[] povratna_vrednost = new byte[duzina];
            Buffer.BlockCopy(niz, 0, povratna_vrednost, 0, duzina);
            return povratna_vrednost;
        }

        public uint[] PretvoriUUint(byte[] niz)
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

        public uint RotirajLevo(uint vrednost, int brojac)
        {
            return (vrednost << brojac) | (vrednost >> (32 - brojac));
        }
    }
}

