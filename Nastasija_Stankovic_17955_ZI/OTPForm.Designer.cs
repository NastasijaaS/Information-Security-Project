
namespace Nastasija_Stankovic_17955_ZI
{
    partial class OTPForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unosTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.izlazTB = new System.Windows.Forms.TextBox();
            this.btnCrpDe = new System.Windows.Forms.Button();
            this.sacuvajBtn = new System.Windows.Forms.Button();
            this.UcitajBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKljuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tekstTb = new System.Windows.Forms.TextBox();
            this.kljucTb = new System.Windows.Forms.TextBox();
            this.upisTb = new System.Windows.Forms.TextBox();
            this.KDParallel = new System.Windows.Forms.Button();
            this.srcKljuc = new System.Windows.Forms.Button();
            this.destParallel = new System.Windows.Forms.Button();
            this.srcParallel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "One time pad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite tekst";
            // 
            // unosTB
            // 
            this.unosTB.Location = new System.Drawing.Point(228, 143);
            this.unosTB.Multiline = true;
            this.unosTB.Name = "unosTB";
            this.unosTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unosTB.Size = new System.Drawing.Size(350, 203);
            this.unosTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kriptovani/Dekriptovani tekst";
            // 
            // izlazTB
            // 
            this.izlazTB.Location = new System.Drawing.Point(584, 143);
            this.izlazTB.Multiline = true;
            this.izlazTB.Name = "izlazTB";
            this.izlazTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.izlazTB.Size = new System.Drawing.Size(333, 203);
            this.izlazTB.TabIndex = 4;
            // 
            // btnCrpDe
            // 
            this.btnCrpDe.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrpDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrpDe.Location = new System.Drawing.Point(923, 143);
            this.btnCrpDe.Name = "btnCrpDe";
            this.btnCrpDe.Size = new System.Drawing.Size(188, 49);
            this.btnCrpDe.TabIndex = 7;
            this.btnCrpDe.Text = "Kriptuj/Dekriptuj";
            this.btnCrpDe.UseVisualStyleBackColor = false;
            this.btnCrpDe.Click += new System.EventHandler(this.btnCrpDe_Click);
            // 
            // sacuvajBtn
            // 
            this.sacuvajBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sacuvajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sacuvajBtn.Location = new System.Drawing.Point(923, 291);
            this.sacuvajBtn.Name = "sacuvajBtn";
            this.sacuvajBtn.Size = new System.Drawing.Size(156, 54);
            this.sacuvajBtn.TabIndex = 8;
            this.sacuvajBtn.Text = "Sacuvaj fajl";
            this.sacuvajBtn.UseVisualStyleBackColor = false;
            this.sacuvajBtn.Click += new System.EventHandler(this.sacuvajBtn_Click);
            // 
            // UcitajBtn
            // 
            this.UcitajBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UcitajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcitajBtn.Location = new System.Drawing.Point(923, 232);
            this.UcitajBtn.Name = "UcitajBtn";
            this.UcitajBtn.Size = new System.Drawing.Size(156, 53);
            this.UcitajBtn.TabIndex = 9;
            this.UcitajBtn.Text = "Ucitaj fajl";
            this.UcitajBtn.UseVisualStyleBackColor = false;
            this.UcitajBtn.Click += new System.EventHandler(this.UcitajBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unesite kljuc:";
            // 
            // tbKljuc
            // 
            this.tbKljuc.Location = new System.Drawing.Point(3, 192);
            this.tbKljuc.Name = "tbKljuc";
            this.tbKljuc.Size = new System.Drawing.Size(208, 20);
            this.tbKljuc.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Postavi kljuc";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Random kljuc";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "One time pad Parallel";
            // 
            // tekstTb
            // 
            this.tekstTb.Location = new System.Drawing.Point(329, 409);
            this.tekstTb.Multiline = true;
            this.tekstTb.Name = "tekstTb";
            this.tekstTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tekstTb.Size = new System.Drawing.Size(295, 79);
            this.tekstTb.TabIndex = 15;
            // 
            // kljucTb
            // 
            this.kljucTb.Location = new System.Drawing.Point(12, 409);
            this.kljucTb.Multiline = true;
            this.kljucTb.Name = "kljucTb";
            this.kljucTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kljucTb.Size = new System.Drawing.Size(302, 79);
            this.kljucTb.TabIndex = 16;
            // 
            // upisTb
            // 
            this.upisTb.Location = new System.Drawing.Point(642, 409);
            this.upisTb.Multiline = true;
            this.upisTb.Name = "upisTb";
            this.upisTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.upisTb.Size = new System.Drawing.Size(287, 79);
            this.upisTb.TabIndex = 17;
            // 
            // KDParallel
            // 
            this.KDParallel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.KDParallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KDParallel.Location = new System.Drawing.Point(935, 409);
            this.KDParallel.Name = "KDParallel";
            this.KDParallel.Size = new System.Drawing.Size(176, 52);
            this.KDParallel.TabIndex = 18;
            this.KDParallel.Text = "Kriptuj/Dekriptuj";
            this.KDParallel.UseVisualStyleBackColor = false;
            this.KDParallel.Click += new System.EventHandler(this.KDParallel_Click);
            // 
            // srcKljuc
            // 
            this.srcKljuc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.srcKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcKljuc.Location = new System.Drawing.Point(70, 509);
            this.srcKljuc.Name = "srcKljuc";
            this.srcKljuc.Size = new System.Drawing.Size(155, 47);
            this.srcKljuc.TabIndex = 19;
            this.srcKljuc.Text = "Ucitaj kljuc";
            this.srcKljuc.UseVisualStyleBackColor = false;
            this.srcKljuc.Click += new System.EventHandler(this.srcKljuc_Click);
            // 
            // destParallel
            // 
            this.destParallel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.destParallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destParallel.Location = new System.Drawing.Point(707, 511);
            this.destParallel.Name = "destParallel";
            this.destParallel.Size = new System.Drawing.Size(158, 45);
            this.destParallel.TabIndex = 20;
            this.destParallel.Text = "Sacuvaj fajl";
            this.destParallel.UseVisualStyleBackColor = false;
            this.destParallel.Click += new System.EventHandler(this.destParallel_Click);
            // 
            // srcParallel
            // 
            this.srcParallel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.srcParallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcParallel.Location = new System.Drawing.Point(389, 510);
            this.srcParallel.Name = "srcParallel";
            this.srcParallel.Size = new System.Drawing.Size(160, 46);
            this.srcParallel.TabIndex = 21;
            this.srcParallel.Text = "Ucitaj fajl";
            this.srcParallel.UseVisualStyleBackColor = false;
            this.srcParallel.Click += new System.EventHandler(this.srcParallel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Kljuc i tekst moraju da budu iste duzine!";
            // 
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1156, 675);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.srcParallel);
            this.Controls.Add(this.destParallel);
            this.Controls.Add(this.srcKljuc);
            this.Controls.Add(this.KDParallel);
            this.Controls.Add(this.upisTb);
            this.Controls.Add(this.kljucTb);
            this.Controls.Add(this.tekstTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbKljuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UcitajBtn);
            this.Controls.Add(this.sacuvajBtn);
            this.Controls.Add(this.btnCrpDe);
            this.Controls.Add(this.izlazTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unosTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OTPForm";
            this.Text = "OTPForm";
            this.Load += new System.EventHandler(this.OTPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unosTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox izlazTB;
        private System.Windows.Forms.Button btnCrpDe;
        private System.Windows.Forms.Button sacuvajBtn;
        private System.Windows.Forms.Button UcitajBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKljuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tekstTb;
        private System.Windows.Forms.TextBox kljucTb;
        private System.Windows.Forms.TextBox upisTb;
        private System.Windows.Forms.Button KDParallel;
        private System.Windows.Forms.Button srcKljuc;
        private System.Windows.Forms.Button destParallel;
        private System.Windows.Forms.Button srcParallel;
        private System.Windows.Forms.Label label7;
    }
}