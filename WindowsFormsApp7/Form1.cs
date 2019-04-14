using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Encrypt(string EncrKey)
        {
            int keyIndex = 0;

            foreach (char a in normText.Text)
            {
                if (char.IsLetter(a))
                {
                    if(keyIndex == EncrKey.Length)
                    {
                        keyIndex = 0;
                    }
                    encrText.Text += (char)(a + EncrKey[keyIndex]);
                }
            }
        }

        private void encrBtn_Click(object sender, EventArgs e)
        {
            string key = keyBox.Text;
            
         
            if (String.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Ключ не был введен");
            }
            else
            {
                
                bool isKeyCorrect = true;

                foreach (char a in key)
                {
                    if (!char.IsLetter(a))
                    {
                        isKeyCorrect = false;
                        break;
                    }
                }
                if (!isKeyCorrect)
                {
                    MessageBox.Show("Ключ содержит недопустимые символы");
                }
                else
                {
                    Encrypt(key);
                }


            }
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
