
namespace yazilim_mimarisi
{
    partial class Kayit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_AD = new System.Windows.Forms.TextBox();
            this.Txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.txt_Kullanici = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kayıt_Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_AD
            // 
            this.txt_AD.Location = new System.Drawing.Point(130, 27);
            this.txt_AD.Name = "txt_AD";
            this.txt_AD.Size = new System.Drawing.Size(201, 20);
            this.txt_AD.TabIndex = 7;
            // 
            // Txt_Soyad
            // 
            this.Txt_Soyad.Location = new System.Drawing.Point(130, 63);
            this.Txt_Soyad.Name = "Txt_Soyad";
            this.Txt_Soyad.Size = new System.Drawing.Size(201, 20);
            this.Txt_Soyad.TabIndex = 8;
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(130, 95);
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(201, 20);
            this.txt_Tc.TabIndex = 9;
            // 
            // txt_Kullanici
            // 
            this.txt_Kullanici.Location = new System.Drawing.Point(130, 132);
            this.txt_Kullanici.Name = "txt_Kullanici";
            this.txt_Kullanici.Size = new System.Drawing.Size(201, 20);
            this.txt_Kullanici.TabIndex = 10;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(130, 169);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(201, 20);
            this.txt_Sifre.TabIndex = 11;
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zaten hesabın var mı?";
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(377, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Kullanici);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.Txt_Soyad);
            this.Controls.Add(this.txt_AD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_AD;
        private System.Windows.Forms.TextBox Txt_Soyad;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.TextBox txt_Kullanici;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label6;
    }
}