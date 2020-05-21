using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U12
{
    public partial class Form1 : Form
    {
        string teksti = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShkronjatEVogla_Click(object sender, EventArgs e)
        {
            teksti = txtTeksti.Text;
            MessageBox.Show("Numri i shkronjave te vogla eshte: " + NumriIShkronjaveTeVogla(teksti));
        }

     

        private void btnShkronjatEMedha_Click(object sender, EventArgs e)
        {
            teksti = txtTeksti.Text;
            MessageBox.Show("Numri i shkronjave te medha eshte: " + NumriIShkronjaveTeMedha(teksti));
        }

        private void btnNumeroNumrat_Click(object sender, EventArgs e)
        {
            teksti = txtTeksti.Text;
            MessageBox.Show("Numrat e gjetur ne tekst: " + CountDigits(teksti));
        }

        private void btnNumeroShkronja_Click(object sender, EventArgs e)
        {
            teksti = txtTeksti.Text;
            MessageBox.Show("Numri i shkronjave eshte: " + CountLetters(teksti));
        }

        #region Extras
        private int NumriIShkronjaveTeVogla(string teksti)
        {
            int numriIShkronjaveTeVogla = 0;
            for (int i = 0; i < teksti.Length; i++)
            {
                if (Char.IsLower(teksti[i]))
                {
                    numriIShkronjaveTeVogla++;
                }
            }
            return numriIShkronjaveTeVogla;
        }

        private int NumriIShkronjaveTeMedha(string teksti)
        {
            int numriIShkronjaveTeMedha = 0;
            for (int i = 0; i < teksti.Length; i++)
            {
                if (Char.IsUpper(teksti[i]))
                {
                    numriIShkronjaveTeMedha++;
                }
            }
            return numriIShkronjaveTeMedha;
        }

        private int CountLetters(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    count++;
                }
            }
            return count;
        }

        private int CountDigits(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    count++;
                }
            }
            return count;
        }

        private string CapitalizeWord(string word)
        {
            string fristLetter = word.Substring(0, 1);
            string otherPart = word.Substring(1, word.Length - 1);
            return fristLetter.ToUpper() + otherPart.ToLower();
        }
        #endregion

        private void btnCapitalize_Click(object sender, EventArgs e)
        {
            teksti = txtTeksti.Text;
            txtTeksti.Text = CapitalizeWord(teksti);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            string fjalaEKerkuar = txtFjala.Text;
            teksti = txtTeksti.Text;

            string refexi = @"" + fjalaEKerkuar;
            Regex regex = new Regex(refexi);
            Match match = regex.Match(teksti);
            if (match.Success)
            {
                MessageBox.Show("Fjala e kerkuar ekziston");
            }
            else
            {
                MessageBox.Show("Fjala e kerkuar nuk ekziston");
            }
        }
    }
}
