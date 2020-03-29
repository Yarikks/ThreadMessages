using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadMessages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        static public TextBox GetTextBox()
        {
            return ReceiveTextBoxUser1;
        }

        private void SendButtonUser1_Click(object sender, EventArgs e)
        {
            Invoke((Action)(() =>
            {
                Form2.GetTextBox().Text += $"Новое сообщение: {SendTextBoxUser1.Text}\r\n";

                ReceiveTextBoxUser1.Text += $"Отправлено: {SendTextBoxUser1.Text}\r\n";

                if (!string.IsNullOrEmpty(SendTextBoxUser1.Text))
                {
                    SendTextBoxUser1.Text = "";
                }
            }));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
