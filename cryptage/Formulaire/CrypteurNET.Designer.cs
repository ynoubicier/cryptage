namespace cryptage.Formulaire
{
    partial class frm_CrypteurNET
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
            this.lblTexteACrypter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTexteACrypter = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtTexteCrypte = new System.Windows.Forms.TextBox();
            this.txtTexteDecrypte = new System.Windows.Forms.TextBox();
            this.btnCryptPerso = new System.Windows.Forms.Button();
            this.btnCryptNet = new System.Windows.Forms.Button();
            this.btnDecryptNet = new System.Windows.Forms.Button();
            this.btnDecryptPer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTexteACrypter
            // 
            this.lblTexteACrypter.AutoSize = true;
            this.lblTexteACrypter.Location = new System.Drawing.Point(44, 55);
            this.lblTexteACrypter.Name = "lblTexteACrypter";
            this.lblTexteACrypter.Size = new System.Drawing.Size(83, 15);
            this.lblTexteACrypter.TabIndex = 0;
            this.lblTexteACrypter.Text = "Texte à crypter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Texte crypté";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Texte décrypté";
            // 
            // txtTexteACrypter
            // 
            this.txtTexteACrypter.Location = new System.Drawing.Point(144, 51);
            this.txtTexteACrypter.Name = "txtTexteACrypter";
            this.txtTexteACrypter.Size = new System.Drawing.Size(287, 23);
            this.txtTexteACrypter.TabIndex = 4;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(144, 96);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(180, 23);
            this.txtKey.TabIndex = 5;
            // 
            // txtTexteCrypte
            // 
            this.txtTexteCrypte.Location = new System.Drawing.Point(144, 205);
            this.txtTexteCrypte.Name = "txtTexteCrypte";
            this.txtTexteCrypte.Size = new System.Drawing.Size(287, 23);
            this.txtTexteCrypte.TabIndex = 6;
            // 
            // txtTexteDecrypte
            // 
            this.txtTexteDecrypte.Location = new System.Drawing.Point(144, 314);
            this.txtTexteDecrypte.Name = "txtTexteDecrypte";
            this.txtTexteDecrypte.Size = new System.Drawing.Size(287, 23);
            this.txtTexteDecrypte.TabIndex = 7;
            // 
            // btnCryptPerso
            // 
            this.btnCryptPerso.Location = new System.Drawing.Point(144, 140);
            this.btnCryptPerso.Name = "btnCryptPerso";
            this.btnCryptPerso.Size = new System.Drawing.Size(131, 44);
            this.btnCryptPerso.TabIndex = 8;
            this.btnCryptPerso.Text = "Cryptage personnel";
            this.btnCryptPerso.UseVisualStyleBackColor = true;
            this.btnCryptPerso.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCryptNet
            // 
            this.btnCryptNet.Location = new System.Drawing.Point(300, 140);
            this.btnCryptNet.Name = "btnCryptNet";
            this.btnCryptNet.Size = new System.Drawing.Size(131, 44);
            this.btnCryptNet.TabIndex = 9;
            this.btnCryptNet.Text = "Cryptage .Net";
            this.btnCryptNet.UseVisualStyleBackColor = true;
            this.btnCryptNet.Click += new System.EventHandler(this.btnCryptNet_Click);
            // 
            // btnDecryptNet
            // 
            this.btnDecryptNet.Location = new System.Drawing.Point(300, 249);
            this.btnDecryptNet.Name = "btnDecryptNet";
            this.btnDecryptNet.Size = new System.Drawing.Size(131, 44);
            this.btnDecryptNet.TabIndex = 11;
            this.btnDecryptNet.Text = "Décryptage .Net";
            this.btnDecryptNet.UseVisualStyleBackColor = true;
            this.btnDecryptNet.Click += new System.EventHandler(this.btnDecryptNet_Click);
            // 
            // btnDecryptPer
            // 
            this.btnDecryptPer.Location = new System.Drawing.Point(144, 249);
            this.btnDecryptPer.Name = "btnDecryptPer";
            this.btnDecryptPer.Size = new System.Drawing.Size(131, 44);
            this.btnDecryptPer.TabIndex = 10;
            this.btnDecryptPer.Text = "Décryptage personnel";
            this.btnDecryptPer.UseVisualStyleBackColor = true;
            this.btnDecryptPer.Click += new System.EventHandler(this.btnDecryptPer_Click);
            // 
            // frm_CrypteurNET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 379);
            this.Controls.Add(this.btnDecryptNet);
            this.Controls.Add(this.btnDecryptPer);
            this.Controls.Add(this.btnCryptNet);
            this.Controls.Add(this.btnCryptPerso);
            this.Controls.Add(this.txtTexteDecrypte);
            this.Controls.Add(this.txtTexteCrypte);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtTexteACrypter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTexteACrypter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CrypteurNET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypteur";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTexteACrypter;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTexteACrypter;
        private TextBox txtKey;
        private TextBox txtTexteCrypte;
        private TextBox txtTexteDecrypte;
        private Button btnCryptPerso;
        private Button btnCryptNet;
        private Button btnDecryptNet;
        private Button btnDecryptPer;
    }
}