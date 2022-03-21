using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            ChangeButton.Text = "Thank you for clicking the other button!";
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            HelloButton.Text = "Why did you click the other button?";
            //this.Text = "Also new text";
        }

        private void ChangeButton_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeButton.Text = "Dont click me!";
        }

        private void HelloButton_MouseMove(object sender, MouseEventArgs e)
        {
            HelloButton.Text = "Please click me!";
        }
    }
}
