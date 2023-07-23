using cryptage.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptage.Formulaire
{
    public partial class frm_CrypteurNET : Form
    {
        private CLS_CryptPerso crypt;
        private byte[] cipher;

        public frm_CrypteurNET()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = txtTexteACrypter.Text;
            crypt = new CLS_CryptPerso();
            string encryptedMessage = crypt.EncryptedMessage(message);
            txtTexteCrypte.Text = encryptedMessage;
        }



        private void btnDecryptPer_Click(object sender, EventArgs e)
        {
            var decrypt = new CLS_CryptPerso();
            int[] encrypt = crypt.encrypted;
            int[,] key = crypt.key;
            string decryptedMessage = decrypt.DecryptMessage(key, encrypt);
            txtTexteDecrypte.Text = decryptedMessage;
        }

        private void btnCryptNet_Click(object sender, EventArgs e)
        {
            string message = txtTexteACrypter.Text;
            var cryptNET = new CLS_CryptAES();
            string key = txtKey.Text;
            cipher = cryptNET.Encrypt(message, key);
            txtTexteCrypte.Text = Convert.ToBase64String(cipher);
        }

        private void btnDecryptNet_Click(object sender, EventArgs e)
        {
            var decryptNET = new CLS_CryptAES();
            string key = txtKey.Text;
            var cipherdecrypt = decryptNET.Decrypt(cipher, key);
            txtTexteDecrypte.Text = cipherdecrypt;
        }
    }
}
