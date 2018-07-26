//                          Слюсаренко Вячеслав
//#region Task1
//      1. а) Добавить в программу “Удвоитель” подсчет количества отданных команд удвоителю.
//         б) Добавить меню и команду “Играть”. При нажатии появляется сообщение, какое число
//            должен получить игрок.Игрок должен постараться получить это число за минимальное
//            количество ходов.
//         в) * Добавить кнопку “Отменить”, которая отменяет последние ходы.
//Region Task2
//      2. Используя Windows Forms, разработать игру “Угадай число”. Компьютер загадывает число от 1
//         до 100, а человек пытается его угадать за минимальное число попыток.Для ввода данных от
//         человека используется элемент TextBox.
//#region Task3 (нереализован код)
//      3. * Реализовать программу из предыдущего урока с шаблоном документа на отпуск в Windows
//          Forms.Сделать несколько текстовых полей(TextBox), куда человек вводит данные, а по
//          нажатии кнопки “Сделать” - видит готовое заявление на отпуск.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {

        #region FormConfig
        public Form1()
        {
            InitializeComponent();
        }

        private void TSIMBAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Слюсаренко Вячеслав\nКурс - Разработчик С#", "About");
        }

        private void TSIMexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TBSignature_TextChanged(object sender, EventArgs e)
        {
            sender = Console.ReadLine();
        }
        #endregion


        #region Task1
        int tryCount = 1;
        int count = 0;
        int lastButton;
        int perfektScore = 0;
        int goalValue = 0;

        private void BtnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            count++;
            lblCount.Text = count.ToString();
            lastButton = int.Parse(btnCommand1.Text);
            if (tryCount == 0) tryCount++;
            if (lblNumber.Text == lblGoal.Text)
            {
                MessageBox.Show("Вы достигли заданного числа, за: " + lblCount.Text + " попыток!\nБудет произведенн авто сброс", "Victory!");
                lblCount.Text = "0";
                lblNumber.Text = "0";
                lblGoal.Text = "*";
                count = 0;
            }
        }
        private void BtnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            count++;
            lblCount.Text = count.ToString();
            lastButton = int.Parse(lblCount.Text) / 2;
            if (tryCount == 0) tryCount++;
            if (lblNumber.Text == lblGoal.Text)
            {
                MessageBox.Show("Вы достигли заданного числа, за: " + lblCount.Text + " попыток!\nБудет произведенн авто сброс", "Victory!");
                lblCount.Text = "0";
                lblNumber.Text = "0";
                lblGoal.Text = "*";
                count = 0;
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";

        }
        private void LblCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = count.ToString();
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {

            Random goal = new Random();
            lblGoal.Text = goal.Next(1, 100).ToString();

            MessageBox.Show("Вам нужно получить число: " + lblGoal.Text, "Start");
            lblCount.Text = "0";
            lblNumber.Text = "0";
            LblNeedToGoal.Text = "0";
            goalValue = int.Parse(lblGoal.Text);
            count = 0;
            perfektScore = 0;

            do
            {
                if (goalValue % 2 == 0)
                {
                    goalValue = goalValue / 2;
                    perfektScore++;
                }
                if (goalValue % 2 != 0)
                {
                    goalValue = goalValue - 1;
                    perfektScore++;
                }

            }
            while (goalValue != 0);

            LblNeedToGoal.Text = perfektScore.ToString();
        }

        private void BtnCancelStep_Click(object sender, EventArgs e)
        {
            if (lastButton == int.Parse(btnCommand1.Text) & tryCount == 1)
            {
                int PreStep = int.Parse(lblNumber.Text) - lastButton;

                lblNumber.Text = PreStep.ToString();
                tryCount--;
            }
            else if (lastButton == int.Parse(lblCount.Text) / 2 & tryCount == 1)
            {
                int PreStep = int.Parse(lblNumber.Text) / 2;

                lblNumber.Text = PreStep.ToString();
                tryCount--;
            }
        }

        #endregion


        #region Task2
        int countTask2=3;
        int NumTask2;
        int from =0;
        int to =10;
        int uAnswer = 0;
        int rndNum;

        private void BtnConfigTask2_Click(object sender, EventArgs e)
        {
            from = int.Parse(TbFrom.Text);
            to = int.Parse(TbTo.Text);
            countTask2 = int.Parse(TxbUserTryCount.Text);
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(@"Компьютер загадал число, от: " + from + " до: " + to +
           " У вас есть: " + countTask2 + " попыток чтоб угадать", "Start");
            Random rnd = new Random();
            rndNum = rnd.Next(from, to);
            NumTask2 = rndNum;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (countTask2 > 0)
            {
                countTask2--;
                if (countTask2 <= 0)
                {
                    MessageBox.Show("Проигрыш. У вас закончились попытки", "Lost");
                }
                if (NumTask2.ToString() == TxbAnswer.Text && countTask2 != 0)
                {
                    countTask2 = -1;
                    MessageBox.Show("Отлично, победа!", "Victory");
                }
                if (NumTask2.ToString() != TxbAnswer.Text & countTask2 != 0)
                {
                    MessageBox.Show("Неверный ответ, осталось попыток: " + countTask2, "Warning");
                }
                else
                {
                    MessageBox.Show("Перезапустите игру", "GameOver");
                }
                uAnswer = int.Parse(TxbAnswer.Text);
                if (CbxHelp.Checked)
                {
                    if ((NumTask2) > uAnswer)
                    {
                        MessageBox.Show("Загаданное число больше вашего!", "Help");
                    }
                    if (NumTask2 < uAnswer)
                    {
                        MessageBox.Show("Загаданное число меньше вашего!", "Help");
                    }

                }
            }
        }

        #endregion

        #region Task3 (Код Не Реализован)

        #endregion
        // Немогу разобратся, как вывести отформатированный текст на экран,в MessegeBox неудобно 
        // форматировать по левому краю, по центру и тд.
    }
}
