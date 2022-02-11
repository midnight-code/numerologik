using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace numerologik
{

    public partial class Form1 : Form
    {
        int summa1 = 0, summa2 = 0, summa3 = 0, summa4 = 0, summa5 = 0, summa6 = 0;
        string[] massivSumm = new string[8];
        string[] massivInt = new string[13];
        string[] massivMatrix = new string[13];
        string[] itogiInt = new string[3];
        string[] itogiMatrix = new string[3];
        public Form1()
        {
            InitializeComponent();
        }
        private void raschet(string den, string mes, string god)
        {
            //суммируем все цифры даты рождения
            summa1 = Summirovanie(den.Trim()) + Summirovanie(mes.Trim()) + Summirovanie(god.Trim());
            summa2 = Summirovanie(summa1.ToString());
            string q = den[0].ToString();
            summa3 = summa1 - 2*(Convert.ToInt32(den[0].ToString()));
            summa4 = Summirovanie(summa3.ToString());
            summa5 = summa1 + summa3;
            summa6 = summa2 + summa4;
            lbl1.Text = summa2.ToString();
            lbl3.Text = summa4.ToString();
            //Выводим получившиеся на экран
            lblDate.Text = den.Trim() + "." + mes.Trim() + "." + god.Trim();
            lblMatrix.Text = summa1.ToString() + ", " + summa2.ToString() + ", " + summa3.ToString() + ", " + summa4.ToString() + " (" + summa5.ToString() + ", " + summa6.ToString() + ")";

            
            TableChisla(den.Trim() + "." + mes.Trim() + "." + god.Trim()+"." + summa1.ToString() + "." + summa2.ToString() + "." + summa3.ToString() + "." + summa4.ToString() + "/" + summa5.ToString() + "." + summa6.ToString());

        }

        private void TableChisla(string tableChisla)
        {
            //Регулярноевыражение для поиска совпадений цифр
            
            string[] str = tableChisla.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 13; i++)
            {
                System.Text.RegularExpressions.MatchCollection match = System.Text.RegularExpressions.Regex.Matches(str[0], i.ToString());
                foreach (System.Text.RegularExpressions.Match m in match)
                {
                    massivInt[i] += m.ToString();
                }
                match = System.Text.RegularExpressions.Regex.Matches(str[1], i.ToString());
                foreach (System.Text.RegularExpressions.Match m in match)
                {
                    massivMatrix[i] += m.ToString();
                }
            }
            
            int o = 0;
            for (int i = 1; i < 8; i++)
            {
                int itog = ConvertCharToInt((massivInt[i] != null) ? massivInt[i].ToCharArray() : "0".ToCharArray()) + ConvertCharToInt((massivInt[i + 1] != null) ? massivInt[i + 1].ToCharArray() : "0".ToCharArray()) + ConvertCharToInt((massivInt[i + 2] != null) ? massivInt[i + 2].ToCharArray() : "0".ToCharArray());
                int itogM = ConvertCharToInt((massivMatrix[i] != null) ? massivMatrix[i].ToCharArray() : "0".ToCharArray()) + ConvertCharToInt((massivMatrix[i + 1] != null) ? massivMatrix[i + 1].ToCharArray() : "0".ToCharArray()) + ConvertCharToInt((massivMatrix[i + 2] != null) ? massivMatrix[i + 2].ToCharArray() : "0".ToCharArray());
                do
                {
                    itog = ConvertCharToInt((itog.ToString()).ToCharArray());
                } while (itog > 9);
                do
                {
                    itogM = ConvertCharToInt((itogM.ToString()).ToCharArray());
                } while (itogM > 9);
                i = i + 2;
                itogiInt[o] = itog.ToString();
                itogiMatrix[o] = itogM.ToString();
                o++;
            }
        }
        private void AddToDisplay()
        {
            lbl2.Text = massivInt[0] + " (" + massivMatrix[0] + ")";
            lblchislo1.Text = massivInt[1] + " (" + massivMatrix[1] + ")";
            lblChislo2.Text = massivInt[2] + " (" + massivMatrix[2] + ")";
            lblChislo3.Text = massivInt[3] + " (" + massivMatrix[3] + ")";
            lblChislo4.Text = massivInt[4] + " (" + massivMatrix[4] + ")";
            lblChislo5.Text = massivInt[5] + " (" + massivMatrix[5] + ")";
            lblChislo6.Text = massivInt[6] + " (" + massivMatrix[6] + ")";
            lblChislo7.Text = massivInt[7] + " (" + massivMatrix[7] + ")";
            lblChislo8.Text = massivInt[8] + " (" + massivMatrix[8] + ")";
            lblChislo9.Text = massivInt[9] + " (" + massivMatrix[9] + ")";
            lblChislo10.Text = massivInt[10] + " (" + massivMatrix[10] + ")";
            lblChislo11.Text = massivInt[11] + " (" + massivMatrix[11] + ")";
            lblChislo12.Text = massivInt[12] + " (" + massivMatrix[12] + ")";
            lblChisloSumm.Text = itogiInt[0] + " (" + itogiMatrix[0] + ")";
            lblChisloSumm2.Text = itogiInt[1] + " (" + itogiMatrix[1] + ")";
            lblChisloSumm3.Text = itogiInt[2] + " (" + itogiMatrix[2] + ")";
        }

        private int ConvertCharToInt(char[] masiv)
        {

            int q = 0;
            for (int i = 0; i < masiv.Length; i++)
            {
                q += Convert.ToInt32(masiv[i].ToString());
            }
            return q;
        }
        private int Summirovanie(string chislo)
        {
            if (Convert.ToInt32(chislo) == 11 || Convert.ToInt32(chislo) == 12)
            {
                return Convert.ToInt32(chislo);
            }
            else
            {
                char[] st = chislo.ToCharArray();
                int i = 0;
                for (int y = 0; y < st.Length; y++)
                {
                    i += Convert.ToInt32(st[y].ToString());
                }
                return i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliring();
            raschet(txtDen.Text, txtMes.Text, txtGod.Text);
            AddToDisplay();
        }
        private void cliring()
        {
            summa1 = 0;
            summa2 = 0;
            summa3 = 0;
            summa4 = 0;
            summa5 = 0;
            summa6 = 0;
            massivSumm = new string[8];
            massivInt = new string[13];
            massivMatrix = new string[13];
            itogiInt = new string[3];
            itogiMatrix = new string[3];
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inform inf = new Inform();
            inf.ShowDialog();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') && (txtDen.Text.IndexOf(".") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') && (txtMes.Text.IndexOf(".") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        private void txtGod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') && (txtGod.Text.IndexOf(".") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }       
    }
}
