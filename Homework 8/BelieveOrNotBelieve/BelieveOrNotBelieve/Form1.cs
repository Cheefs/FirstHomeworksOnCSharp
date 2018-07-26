// Слюсаренко Вячеслав

//      1. а) создать приложение показанное на уроке;
//         б) изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов, и добавив
//            другие косметические улучшения на свое усмотрение;
//         в) добавить в приложение меню “О программе” с информацией о программе (автор, версия,
//            авторские права и др.);
//         г) добавить в приложение сообщение с предупреждением при попытке удалить вопрос;
//         д) добавить пункт меню Save As в котором можно выбрать имя для сохранения базы данных
//           (элемент SaveFileDialog);

//      2. *Используя полученные знания и класс TrueFalse, разработать игру “Верю-Не верю” 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BelieveOrNotBelieve;

namespace BelieveOrNotBelieve
{
    public partial class Hw8 : Form
    {
      
        #region Task 1
        TrueFalse database;  
        public Hw8()
        {
            InitializeComponent();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Слюсаренко Вячеслав\nКурс -Разработчик C#\nПрограмма BeliveOrNotBelive v.0.1", "About");
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            }
            catch (Exception)
            {

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (database != null)

            {
                database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
                database.Save();
            }

            else MessageBox.Show("База данных не создана");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                var Result = MessageBox.Show("Вы хотите удалить данный элемент?", "Warning", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    if (nudNumber.Maximum == 1 || database == null) return;
                    database.Remove((int)nudNumber.Value);
                    nudNumber.Maximum--;
                    if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
                }
            }


        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
                tboxQuestion.Text = nudNumber.Value.ToString();

            }

        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }


        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
                sfdSaveAs.ShowDialog();
            }
            else MessageBox.Show("База данных не создана");

        }

        #endregion

        int total = 0;
      
        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (database != null)
                {
                    lblGameTrue.Text = "";
                    lblGameFalse.Text = "";

                    if (database[(int)nudNumGame.Value - 1].trueFalse == true)
                    {
                        
                        lblGameTrue.Text = "Верный ответ";
                        total++;
                        lblTotal.Text = "Верных ответов: " + total;
                    }
                    else lblGameFalse.Text = "Не верный ответ"; ;
                    nudNumGame.Value++;
                }
                else MessageBox.Show("Подключите базу данных, в меню  Open!","Opps");
             
            }
            catch (Exception)
            {

            }

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            try
            {
           
                if (database != null)
                {
                  lblGameTrue.Text = "";
                  lblGameFalse.Text = "";
                    if (database[(int)nudNumGame.Value - 1].trueFalse != true)
                    {
                        lblGameTrue.Text = "Верный ответ";
                        total++;
                        lblTotal.Text = "Верных ответов: " + total;
                    }
                    else lblGameFalse.Text = "Не верный ответ";
                    nudNumGame.Value++;
                }
                else MessageBox.Show("Подключите базу данных, в меню  Open!","Oops");
                
               
            }
            catch (Exception)
            {

            }
           
            
        }

        private void nudNumGame_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (database != null)
                {
                    txbGame.Text = database[(int)nudNumGame.Value - 1].text;

                }
                else MessageBox.Show("Подключите базу данных, в меню  Open!","Oops");

            }
            catch (Exception)
            {

            }

        }
    }
}
