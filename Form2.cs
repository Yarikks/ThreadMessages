using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace ThreadMessages
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Location = new Point(800, 0);
            StartPosition = FormStartPosition.Manual;
        }

        static public TextBox GetTextBox()
        {
            return textBox2;
        }

        private void SendButtonUser2_Click(object sender, EventArgs e)
        {
            Invoke((Action)(() =>
            {
                Form1.GetTextBox().Text += $"Новое сообщение: {textBox1.Text}\r\n";

                textBox2.Text += $"Отправлено: {textBox1.Text}\r\n";

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = "";
                }
            }));
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
