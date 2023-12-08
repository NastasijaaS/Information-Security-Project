using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nastasija_Stankovic_17955_ZI
{
    public partial class FSCForm : Form
    {
        FSC fsc;

        bool kljucP;
        bool def_flag;

        byte[] ucitanFajl;
        string putanjaCitanje;
        string ucitaniHash="";
        public FSCForm()
        {
            fsc = new FSC();
            InitializeComponent();
        }

        private void FSCForm_Load(object sender, EventArgs e)
        {

        }

        private void SetKljucBtn_Click(object sender, EventArgs e)
        {
            bool prazno = string.IsNullOrEmpty(K1tb.Text);
            prazno |= string.IsNullOrEmpty(K2tb.Text);

            if (prazno)
            {
                MessageBox.Show("Popunite sva 4 polja za kljuceve.",
                        "Obavestenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }

            if (K1tb.Text.Length < 25 || K2tb.Text.Length<25)
            {
                MessageBox.Show("Morate da unesete 25 karaktera za oba kljuca.",
                        "Obavestenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }

            String k1;
            String k2;
            k1 = K1tb.Text;
            k2 = K2tb.Text;

            fsc.SetSquare(k1, k2);
            kljucP = true;

                 MessageBox.Show("Uspesno ste postavili kljuc.",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;

        }

        private void SetKeyTbx(string[] value)
        {
            K1tb.Text = value[0];
            K2tb.Text = value[1];
        }

        private void DifBtn_Click(object sender, EventArgs e)
        {
            string[] value = this.fsc.PostaviDifoltniSquare();
            SetKeyTbx(value);
            kljucP = true;
        }

        private void crpdecBtn_Click(object sender, EventArgs e)
        {
            if (!kljucP)
            {
                MessageBox.Show("Postavite kljuc!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            if (this.unosTB.Text.Length == 0)
            {
                MessageBox.Show("Unesite tekst.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }

            if (crpRbn.Checked == false && decRbn.Checked == false)
            {
                MessageBox.Show("Izaberite da li zelite kriptovanje/dekriptovanje.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }

            if (crpRbn.Checked == true)
                def_flag = true;
            else
                def_flag = false;
            if (def_flag == false)
            {
                if (ucitaniHash != "")
                {
                    if (String.Compare(ucitaniHash, fsc.Hesh) == 0)
                    {
                        MessageBox.Show("SHA1 validacija je uspela!",
                            "Notification",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("SHA1 validacija nije uspela!",
                             "Notification",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                    }
                }
            }

            this.izlazTB.Text = kljucP ? def_flag ? fsc.Kriptovanje(this.unosTB.Text) : fsc.Dekriptovanje(this.unosTB.Text) : "";


        }

        private void K1tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

        }

        private void K2tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void K1tb_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void K2tb_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void ucitajBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text|*.txt|All|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                putanjaCitanje = dialog.FileName;
                FileStream fajlZaCitanje = null;
                FileStream hashFajlZaCitanje = null;
                try
                {
                    fajlZaCitanje = new FileStream(putanjaCitanje, FileMode.Open);
                    int velicina = (int)fajlZaCitanje.Length;
                    byte[] nizBajtova = new byte[velicina];
                    fajlZaCitanje.Read(nizBajtova, 0, velicina);
                    ucitanFajl = nizBajtova;
                    unosTB.Text = Encoding.UTF8.GetString(ucitanFajl);
                    this.izlazTB.Text = "";


                    string currentDirectory = Path.GetDirectoryName(putanjaCitanje);
                    string fileName = Path.GetFileName(putanjaCitanje);
                    string newFolderName = "hes";

                    if (File.Exists(currentDirectory + "\\" + newFolderName + "\\" + fileName))
                    {

                        hashFajlZaCitanje = new FileStream(currentDirectory + "\\" + newFolderName + "\\" + fileName, FileMode.Open);

                        int velicinaHashajtova = (int)hashFajlZaCitanje.Length;
                        byte[] nizHashBajtova = new byte[velicinaHashajtova];
                        hashFajlZaCitanje.Read(nizHashBajtova, 0, velicinaHashajtova);
                        ucitanFajl = nizHashBajtova;
                        this.ucitaniHash = Encoding.UTF8.GetString(ucitanFajl);
                        hashFajlZaCitanje.Close();
                    }
                       
                }

                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString(),
                "Error",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                }
                finally
                {
                    fajlZaCitanje.Close();
                }
            }

        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog folderDialog = new SaveFileDialog();
            folderDialog.Filter = "Text|*.txt|All|*.*";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fajlZaUpis = null;
                FileStream hashFajlZaUpis = null;
                try
                {
                    byte[] tekstZaUpis = new byte[this.izlazTB.TextLength];
                    tekstZaUpis = Encoding.UTF8.GetBytes(this.izlazTB.Text);

                    fajlZaUpis = new FileStream(folderDialog.FileName, FileMode.Create);
                    fajlZaUpis.Write(tekstZaUpis, 0, tekstZaUpis.Length);

                    if (this.fsc.Hesh.Length != 0)
                    {
                        byte[] hashTekstZaUpis = new byte[this.fsc.Hesh.Length];
                        hashTekstZaUpis = Encoding.UTF8.GetBytes(this.fsc.Hesh);

                        string currentDirectory = Path.GetDirectoryName(folderDialog.FileName);
                        string fileName = Path.GetFileName(folderDialog.FileName);
                        string newFolderName = "hes";
                        Directory.CreateDirectory(currentDirectory + "\\" + newFolderName);
                        hashFajlZaUpis = new FileStream(currentDirectory + "\\" + newFolderName + "\\" + fileName, FileMode.Create);
                        hashFajlZaUpis.Write(hashTekstZaUpis, 0, hashTekstZaUpis.Length);
                    }

                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    fajlZaUpis.Close();
                    hashFajlZaUpis.Close();
                }
                MessageBox.Show("Uspesno ste sacuvali fajl.",
                "Obavestenje",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
            }
        }
    }
}
