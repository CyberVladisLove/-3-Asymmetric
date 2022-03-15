using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsymmetricEncryption
{
    public partial class Form1 : Form
    {
        public ASCIIEncoding ByteConverter = new ASCIIEncoding();
        private Channel _ch;
        public Form1()
        {
            InitializeComponent();
            _ch = new Channel(new Me(), new Neighbour());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ch.me.InitRSA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ch.me.SavePrivateKeyToXML();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            _ch.me.SavePublicKeyToXML();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0) return;

            byte[] cypherbytes = _ch.EncryptedData;
            byte[] plainbytes = _ch.me.Decrypt(cypherbytes);
            richTextBox2.Text = ByteConverter.GetString(plainbytes); ;              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _ch.n.InitRSA();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox3.Text.Length == 0) return;

            byte[] plainbytes = ByteConverter.GetBytes(richTextBox3.Text);
            byte[] cypherbytes = _ch.LetsEncryptByNeighbour(plainbytes);
            richTextBox1.Text = ByteConverter.GetString(cypherbytes);
            richTextBox4.Text = richTextBox1.Text;

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = _ch.n.ReadOriginalContent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)//to decrypt
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)//original
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)//encrypted data
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)//decrypted data
        {

        }

        
    }
}
