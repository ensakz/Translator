using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        YandexTranslator yt;

        public Form1()
        {
            InitializeComponent();

            yt = new YandexTranslator();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string lang;

            if (ukEnRadioButton.Checked == true)
            {
                lang = "uk-en";
            }
            else
            {
                lang = "en-uk";
            }

            outputTextBox.Text = yt.Translate(inputTextBox.Text, lang);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}