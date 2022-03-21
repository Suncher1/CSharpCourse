using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            MessageBox.Show($"{number}");
        }

        private void DollarText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(DollarText.Text);
                amount = amount * 10.0;
                ResultLabel.Text = $"Result: {amount} SEK";
            }
            catch
            {
                ResultLabel.Text = "Invalid input";
            }
        }
    }
}
