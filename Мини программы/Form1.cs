using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Test : Form
    {

        int count = 0;
        Dictionary<string, double> metrika;
        Random rnd;
        char[] spec_chars = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };

        public Test()
        {
            InitializeComponent();
            rnd = new Random();
            metrika = new Dictionary<string, double>();
            metrika.Add ("мм", 1);
            metrika.Add("см", 10);
            metrika.Add("дм", 100);
            metrika.Add("м", 1000);
            metrika.Add("км", 1000000);
            metrika.Add("мили", 1609344);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Developed by Cheef", "About");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            LbCount.Text = count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (count>0)
            {
                count--;
                LbCount.Text = count.ToString();
            }
           

         
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            LbCount.Text = count.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            lblRandom.Text = n.ToString();
            if (cbRandom.Checked)
            {
                int i = 0;
               while(txtgnrtr.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                 
                    i++;
                    if (i > 1000) break;
                }
               if (i<=1000) txtgnrtr.AppendText(n + "\n");
            }
            else txtgnrtr.AppendText(n + "\n");

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lblRandom_Click(object sender, EventArgs e)
        {
            
                
                }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtgnrtr.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtgnrtr.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsimInsData_Click(object sender, EventArgs e)
        {
            rtbxNotebad .AppendText ( DateTime.Now.ToShortDateString()+"\n");
        }

        private void tsmiInsTime_Click(object sender, EventArgs e)
        {
            rtbxNotebad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiTimeDate_Click(object sender, EventArgs e)
        {
            rtbxNotebad.AppendText(DateTime.Now.ToString()+"\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbxNotebad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении","ERROR");
            }

        }
    void LoadNotepad ()
        {
            try
            {
                rtbxNotebad.LoadFile("notepad.rtf");
            }

            catch
            {
                MessageBox.Show("Ошибка при загрузке", "ERROR");
            }
        }
        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            LoadNotepad();
            clbGenerate.SetItemChecked(0, true);
            clbGenerate.SetItemChecked(1, true);
            clbGenerate.SetItemChecked(2, true);
            clbGenerate.SetItemChecked(3, true);
        }

        private void nudPassLenght_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bGeneratePass_Click(object sender, EventArgs e)
        {
            if (clbGenerate.CheckedItems.Count == 0) return;
            {
                string password = "";
                for (int i = 0; i < nudPassLenght.Value; i++)
                {
                    int n = rnd.Next(0, clbGenerate.CheckedItems.Count);
                    string s = clbGenerate.CheckedItems[n].ToString();
                    switch (s)
                    {
                        case "Цифры": password += rnd.Next(10).ToString();
                            break;
                        case "Прописные буквы": password += Convert.ToChar(rnd.Next(65, 88));
                            break;
                        case "Строчные буквы": password += Convert.ToChar(rnd.Next(97, 122));
                            break;


                        default:
                            password += spec_chars[rnd.Next(spec_chars.Length)];
                                break;



                    }
                    tbPassword.Text = password;
                    Clipboard.SetText(password);
                }
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConvertTo_Click(object sender, EventArgs e)
        {
            double m1 = metrika[cbConvertFrom.Text];
            double m2 = metrika[cbConvertTo.Text];
            double n = Convert.ToDouble(tBFrom.Text);
            tbTo .Text = (n * m1 / m2).ToString();
        }

        private void btnChangeConv_Click(object sender, EventArgs e)
        {
            string t = cbConvertFrom.Text;
            cbConvertFrom.Text = cbConvertTo.Text;
            cbConvertTo .Text = t;
        }

        private void cbMetrik_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetrik.Text)
            {
                case "Длина":

                    metrika.Clear();
                    metrika.Add("мм", 1);
                    metrika.Add("см", 10);
                    metrika.Add("дм", 100);
                    metrika.Add("м", 1000);
                    metrika.Add("км", 1000000);
                    metrika.Add("мили", 1609344);
                    cbConvertFrom.Items.Clear();
                    cbConvertFrom.Items.Add("мм");
                    cbConvertFrom.Items.Add("см");
                    cbConvertFrom.Items.Add("дм");
                    cbConvertFrom.Items.Add("м");
                    cbConvertFrom.Items.Add("км");
                    cbConvertFrom.Items.Add("мили");
                    cbConvertTo.Items.Clear();
                    cbConvertTo.Items.Add("мм");
                    cbConvertTo.Items.Add("см");
                    cbConvertTo.Items.Add("дм");
                    cbConvertTo.Items.Add("м");
                    cbConvertTo.Items.Add("км");
                    cbConvertTo.Items.Add("мили");


                    cbConvertFrom.Text = "мм";
                    cbConvertTo.Text = "мм";


                    break;



                case "Вес":

                    metrika.Clear();
                    metrika.Add("грамм", 1);
                    metrika.Add("кг", 1000);
                    metrika.Add("т", 1000000);
                    metrika.Add("фунт", 453.6);
                   
                   
                    cbConvertFrom.Items.Clear();
                    cbConvertFrom.Items.Add("грамм");
                    cbConvertFrom.Items.Add("кг");
                    cbConvertFrom.Items.Add("т");
                    cbConvertFrom.Items.Add("фунт");
                    
                    cbConvertTo.Items.Clear();
                    cbConvertTo.Items.Add("грамм");
                    cbConvertTo.Items.Add("кг");
                    cbConvertTo.Items.Add("т");
                    cbConvertTo.Items.Add("фунт");

                    cbConvertFrom.Text = "грамм";
                    cbConvertTo.Text = "грамм";



                    break;
                    






                default:
                    break;

            }

            
                
            }
        }
    }

