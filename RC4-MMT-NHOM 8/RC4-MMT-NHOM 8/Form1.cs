using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC4_MMT_NHOM_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private byte[] RC4(byte[] data, byte[] key)
        {
            byte[] S = new byte[256];
            for (int i = 0; i < 256; i++)
                S[i] = (byte)i;

            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + S[i] + key[i % key.Length]) % 256;
                Swap(S, i, j);
            }

            byte[] result = new byte[data.Length];
            int iIndex = 0, jIndex = 0;

            for (int k = 0; k < data.Length; k++)
            {
                iIndex = (iIndex + 1) % 256;
                jIndex = (jIndex + S[iIndex]) % 256;

                Swap(S, iIndex, jIndex);

                int t = (S[iIndex] + S[jIndex]) % 256;
                byte keystreamByte = S[t];

                result[k] = (byte)(data[k] ^ keystreamByte);
            }

            return result;
        }

        private void Swap(byte[] array, int i, int j)
        {
            byte temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string plaintext = txtPlaintext.Text;
            string key = txtKey.Text;

            if (string.IsNullOrEmpty(plaintext) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Plaintext và Key!");
                return;
            }

            byte[] plaintextBytes = Encoding.ASCII.GetBytes(plaintext);
            byte[] keyBytes = Encoding.ASCII.GetBytes(key);
            byte[] resultBytes = RC4(plaintextBytes, keyBytes);

            // Hiển thị kết quả dưới dạng Hex cho dễ nhìn
            txtCyberText.Text = BitConverter.ToString(resultBytes).Replace("-", " ");
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCybertext_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaintext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
