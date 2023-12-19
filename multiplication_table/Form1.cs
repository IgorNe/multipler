using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplication_table
{
    public partial class Form1 : Form
    {
        private int operand1;
        private int operand2;

        public Form1()
        {
            InitializeComponent();
            GenerateRandomOperands();
            DisplayQuestion();
        }

        private void GenerateRandomOperands()
        {
            Random random = new Random();
            operand1 = random.Next(1, 11);
            operand2 = random.Next(1, 11);
        }

        private void DisplayQuestion()
        {
            questionLabel.Text = $"Сколько будет {operand1} умножить на {operand2}?";
            answerTextBox.Clear();
        }

        private void CheckAnswer()
        {
            // Получаем ответ пользователя
            int userAnswer;
            if (int.TryParse(answerTextBox.Text, out userAnswer))
            {
                // Проверяем ответ и выводим результат
                int correctAnswer = operand1 * operand2;
                if (userAnswer == correctAnswer)
                {
                    resultLabel.Text = "Правильно!";
                }
                else
                {
                    resultLabel.Text = $"Неправильно. Правильный ответ: {correctAnswer}";
                }

                // Генерируем новые операнды и задаем новый вопрос
                GenerateRandomOperands();
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Введите корректный числовой ответ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }
    }

}
