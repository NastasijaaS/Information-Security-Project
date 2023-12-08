
namespace Nastasija_Stankovic_17955_ZI
{
    partial class FSCForm
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
            this.crpRbn = new System.Windows.Forms.RadioButton();
            this.decRbn = new System.Windows.Forms.RadioButton();
            this.sacuvajBtn = new System.Windows.Forms.Button();
            this.ucitajBtn = new System.Windows.Forms.Button();
            this.crpdecBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.K1tb = new System.Windows.Forms.TextBox();
            this.K2tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SetKljucBtn = new System.Windows.Forms.Button();
            this.DifBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Foursquare cipher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite tekst";
            // 
            // unosTB
            // 
            this.unosTB.Location = new System.Drawing.Point(305, 142);
            this.unosTB.Multiline = true;
            this.unosTB.Name = "unosTB";
            this.unosTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unosTB.Size = new System.Drawing.Size(613, 203);
            this.unosTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kriptovani/Dekriptovani tekst";
            // 
            // izlazTB
            // 
            this.izlazTB.Location = new System.Drawing.Point(293, 419);
            this.izlazTB.Multiline = true;
            this.izlazTB.Name = "izlazTB";
            this.izlazTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.izlazTB.Size = new System.Drawing.Size(613, 203);
            this.izlazTB.TabIndex = 4;
            // 
            // crpRbn
            // 
            this.crpRbn.AutoSize = true;
            this.crpRbn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.crpRbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crpRbn.Location = new System.Drawing.Point(924, 142);
            this.crpRbn.Name = "crpRbn";
            this.crpRbn.Size = new System.Drawing.Size(80, 28);
            this.crpRbn.TabIndex = 5;
            this.crpRbn.TabStop = true;
            this.crpRbn.Text = "Kriptuj";
            this.crpRbn.UseVisualStyleBackColor = false;
            // 
            // decRbn
            // 
            this.decRbn.AutoSize = true;
            this.decRbn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.decRbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decRbn.Location = new System.Drawing.Point(924, 176);
            this.decRbn.Name = "decRbn";
            this.decRbn.Size = new System.Drawing.Size(101, 28);
            this.decRbn.TabIndex = 6;
            this.decRbn.TabStop = true;
            this.decRbn.Text = "Dekriptuj";
            this.decRbn.UseVisualStyleBackColor = false;
            // 
            // sacuvajBtn
            // 
            this.sacuvajBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sacuvajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sacuvajBtn.Location = new System.Drawing.Point(912, 576);
            this.sacuvajBtn.Name = "sacuvajBtn";
            this.sacuvajBtn.Size = new System.Drawing.Size(183, 46);
            this.sacuvajBtn.TabIndex = 7;
            this.sacuvajBtn.Text = "Sacuvaj fajl/SHA1";
            this.sacuvajBtn.UseVisualStyleBackColor = false;
            this.sacuvajBtn.Click += new System.EventHandler(this.sacuvajBtn_Click);
            // 
            // ucitajBtn
            // 
            this.ucitajBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ucitajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucitajBtn.Location = new System.Drawing.Point(912, 524);
            this.ucitajBtn.Name = "ucitajBtn";
            this.ucitajBtn.Size = new System.Drawing.Size(183, 46);
            this.ucitajBtn.TabIndex = 8;
            this.ucitajBtn.Text = "Ucitaj fajl/SHA1";
            this.ucitajBtn.UseVisualStyleBackColor = false;
            this.ucitajBtn.Click += new System.EventHandler(this.ucitajBtn_Click);
            // 
            // crpdecBtn
            // 
            this.crpdecBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.crpdecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crpdecBtn.Location = new System.Drawing.Point(924, 295);
            this.crpdecBtn.Name = "crpdecBtn";
            this.crpdecBtn.Size = new System.Drawing.Size(157, 50);
            this.crpdecBtn.TabIndex = 9;
            this.crpdecBtn.Text = "Kriptuj/Dekriptuj";
            this.crpdecBtn.UseVisualStyleBackColor = false;
            this.crpdecBtn.Click += new System.EventHandler(this.crpdecBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unesite 25 karaktera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "K1:";
            // 
            // K1tb
            // 
            this.K1tb.Location = new System.Drawing.Point(60, 156);
            this.K1tb.MaxLength = 25;
            this.K1tb.Name = "K1tb";
            this.K1tb.Size = new System.Drawing.Size(229, 20);
            this.K1tb.TabIndex = 12;
            this.K1tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.K1tb_KeyPress);
            this.K1tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.K1tb_KeyUp);
            // 
            // K2tb
            // 
            this.K2tb.Location = new System.Drawing.Point(60, 193);
            this.K2tb.MaxLength = 25;
            this.K2tb.Name = "K2tb";
            this.K2tb.Size = new System.Drawing.Size(229, 20);
            this.K2tb.TabIndex = 13;
            this.K2tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.K2tb_KeyPress);
            this.K2tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.K2tb_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "K2:";
            // 
            // SetKljucBtn
            // 
            this.SetKljucBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SetKljucBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetKljucBtn.Location = new System.Drawing.Point(60, 234);
            this.SetKljucBtn.Name = "SetKljucBtn";
            this.SetKljucBtn.Size = new System.Drawing.Size(229, 49);
            this.SetKljucBtn.TabIndex = 15;
            this.SetKljucBtn.Text = "Postavite kljuceve";
            this.SetKljucBtn.UseVisualStyleBackColor = false;
            this.SetKljucBtn.Click += new System.EventHandler(this.SetKljucBtn_Click);
            // 
            // DifBtn
            // 
            this.DifBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.DifBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifBtn.Location = new System.Drawing.Point(60, 80);
            this.DifBtn.Name = "DifBtn";
            this.DifBtn.Size = new System.Drawing.Size(229, 37);
            this.DifBtn.TabIndex = 16;
            this.DifBtn.Text = "Difoltni kljuc";
            this.DifBtn.UseVisualStyleBackColor = false;
            this.DifBtn.Click += new System.EventHandler(this.DifBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(877, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(453, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hes vrednost  se pamti  kada se kriptovani fajl pamti uz pomoc Sacuvaj fajl.\r\nHes" +
    " validacija se vrsi kada se kriptovani fajl ucitava uz pomoc Ucitaj fajl.\r\n";
            // 
            // FSCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1353, 672);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DifBtn);
            this.Controls.Add(this.SetKljucBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.K2tb);
            this.Controls.Add(this.K1tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.crpdecBtn);
            this.Controls.Add(this.ucitajBtn);
            this.Controls.Add(this.sacuvajBtn);
            this.Controls.Add(this.decRbn);
            this.Controls.Add(this.crpRbn);
            this.Controls.Add(this.izlazTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unosTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FSCForm";
            this.Text = "FSCForm";
            this.Load += new System.EventHandler(this.FSCForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unosTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox izlazTB;
        private System.Windows.Forms.RadioButton crpRbn;
        private System.Windows.Forms.RadioButton decRbn;
        private System.Windows.Forms.Button sacuvajBtn;
        private System.Windows.Forms.Button ucitajBtn;
        private System.Windows.Forms.Button crpdecBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox K1tb;
        private System.Windows.Forms.TextBox K2tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SetKljucBtn;
        private System.Windows.Forms.Button DifBtn;
        private System.Windows.Forms.Label label7;
    }
}