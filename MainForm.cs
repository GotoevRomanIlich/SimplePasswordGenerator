using System;
using System.Windows.Forms;

namespace SimplePasswordGenerator
{
    public partial class MainForm : Form
    {
        private readonly string VERSION = "ver. 1.0.0";

        Random random = new Random();

        char[] specialSymbol = new char[] { '%', '*', ')', '(', '?', '#', '$', '^', '&', '~' };

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Простой генератор паролей. " + VERSION;
        }

        void CreatePassword(object sender, EventArgs e)
        {
            if (checkedListBoxPassword.CheckedItems.Count == 0) return;

            string password = "";

            for (int i = 0; i < numericUpDownPassword.Value; i++)
            {
                int position = random.Next(0, checkedListBoxPassword.CheckedItems.Count);
                string getSettings = checkedListBoxPassword.CheckedItems[position].ToString();

                switch (getSettings)
                {
                    case "Цифры":
                        password += random.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(random.Next(65, 88));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(random.Next(97, 122));
                        break;
                    default:
                        password += specialSymbol[random.Next(specialSymbol.Length)];
                        break;
                }
            }
            textBoxPassword.Clear();
            textBoxPassword.AppendText(password);
            Clipboard.SetText(password);
        }
    }
}
