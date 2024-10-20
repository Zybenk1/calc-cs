using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                var currenButton = sender as Button;
                textBox1.Text += currenButton.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                var d = new DataTable();
                textBox1.Text = d.Compute(textBox1.Text, "").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                var str = "";
                for (int i = 0; i < textBox1.Text.Length - 1; i++)
                {
                    str += textBox1.Text[i];
                }
                textBox1.Text = str;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button21_Click(object sender, EventArgs e) // tg
        {
            try
            {
                double angle = GetAngleFromTextBox();

                if (Math.Cos(angle) == 0)
                {
                    MessageBox.Show("Угловое значение не подходит для тангенса, братан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = Math.Tan(angle);
                textBox1.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button20_Click(object sender, EventArgs e) // ctg
        {
            try
            {
                double angle = GetAngleFromTextBox();

                if (Math.Sin(angle) == 0)
                {
                    MessageBox.Show("Угловое значение не подходит для котангенса, братан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = 1.0 / Math.Tan(angle);
                textBox1.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e) // sin
        {
            try
            {
                if (!IsInputValid()) return;

                double angle = GetAngleFromTextBox();
                double result = Math.Sin(angle);
                textBox1.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e) // cos
        {
            try
            {
                double angle = GetAngleFromTextBox();
                double result = Math.Cos(angle);
                textBox1.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetAngleFromTextBox()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Ошибка ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

                if (!double.TryParse(textBox1.Text, out double degrees))
                {
                    MessageBox.Show("Ошибка ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

                return degrees * (Math.PI / 180.0);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private bool IsInputValid()
        {
            try
            {
                if (!double.TryParse(textBox1.Text, out _))
                {
                    MessageBox.Show("Эй, Ошибка ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Math.PI.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return;

                double number = double.Parse(textBox1.Text);

                if (number < 0)
                {
                    MessageBox.Show("Корень из отрицательного числа нельзя взять, братан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double sqrtResult = Math.Sqrt(number);
                textBox1.Text = sqrtResult.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return;

                double number = double.Parse(textBox1.Text);

                if (number <= 0)
                {
                    MessageBox.Show("Для натурального логарифма число должно быть больше нуля, братан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double lnResult = Math.Log(number);
                textBox1.Text = lnResult.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button28_Click(object sender, EventArgs e)
{
            try
            {
                if (!IsInputValid()) return;

                double number = double.Parse(textBox1.Text);

                if (number <= 0)
                {
                    MessageBox.Show("Для десятичного логарифма число должно быть больше нуля, братан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double logResult = Math.Log10(number);
                textBox1.Text = logResult.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return;

                double number = double.Parse(textBox1.Text);
                double percent = number / 100.0;
                textBox1.Text = percent.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ссылка на сайт
            string url = "https://t.me/melixovh";

            // Открытие ссылки в браузере
            System.Diagnostics.Process.Start(url);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return; // Проверка на корректный ввод

                double number = double.Parse(textBox1.Text); // Читаем число из textBox1
                double result = Math.Pow(number, 2); // Возводим в квадрат
                textBox1.Text = result.ToString(); // Выводим результат в textBox1
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return; // Проверка на корректный ввод

                double number = double.Parse(textBox1.Text); // Читаем число из textBox1
                double result = Math.Pow(number, 3); // Возводим в куб
                textBox1.Text = result.ToString(); // Выводим результат в textBox1
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return; // Проверка на корректный ввод

                double degrees = double.Parse(textBox1.Text); // Читаем число из textBox1
                double radians = degrees * (Math.PI / 180.0); // Преобразуем градусы в радианы
                textBox1.Text = radians.ToString(); // Выводим результат в textBox1
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return; // Проверка на корректный ввод

                double number = double.Parse(textBox1.Text); // Читаем число из textBox1

                if (number == 0) // Проверяем, чтобы не делить на ноль
                {
                    MessageBox.Show("Ошибка: нельзя взять обратное значение от нуля, братан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = 1.0 / number; // Вычисляем обратное значение
                textBox1.Text = result.ToString(); // Выводим результат в textBox1
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
