
namespace Nastasija_Stankovic_17955_ZI
{
    partial class Pocetna
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
            this.OTPbutton = new System.Windows.Forms.Button();
            this.FSCbutton = new System.Windows.Forms.Button();
            this.XXTEAbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OTPbutton
            // 
            this.OTPbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.OTPbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPbutton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OTPbutton.Location = new System.Drawing.Point(64, 189);
            this.OTPbutton.Name = "OTPbutton";
            this.OTPbutton.Size = new System.Drawing.Size(191, 52);
            this.OTPbutton.TabIndex = 0;
            this.OTPbutton.Text = "One Time Pad";
            this.OTPbutton.UseVisualStyleBackColor = false;
            this.OTPbutton.Click += new System.EventHandler(this.OTPbutton_Click);
            // 
            // FSCbutton
            // 
            this.FSCbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FSCbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSCbutton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FSCbutton.Location = new System.Drawing.Point(277, 189);
            this.FSCbutton.Name = "FSCbutton";
            this.FSCbutton.Size = new System.Drawing.Size(193, 52);
            this.FSCbutton.TabIndex = 1;
            this.FSCbutton.Text = "Foursquare cipher";
            this.FSCbutton.UseVisualStyleBackColor = false;
            this.FSCbutton.Click += new System.EventHandler(this.FSCbutton_Click);
            // 
            // XXTEAbtn
            // 
            this.XXTEAbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.XXTEAbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XXTEAbtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.XXTEAbtn.Location = new System.Drawing.Point(487, 189);
            this.XXTEAbtn.Name = "XXTEAbtn";
            this.XXTEAbtn.Size = new System.Drawing.Size(187, 52);
            this.XXTEAbtn.TabIndex = 2;
            this.XXTEAbtn.Text = "XXTEA";
            this.XXTEAbtn.UseVisualStyleBackColor = false;
            this.XXTEAbtn.Click += new System.EventHandler(this.XXTEAbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberite algoritam za sifrovanje";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(712, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XXTEAbtn);
            this.Controls.Add(this.FSCbutton);
            this.Controls.Add(this.OTPbutton);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OTPbutton;
        private System.Windows.Forms.Button FSCbutton;
        private System.Windows.Forms.Button XXTEAbtn;
        private System.Windows.Forms.Label label1;
    }
}

