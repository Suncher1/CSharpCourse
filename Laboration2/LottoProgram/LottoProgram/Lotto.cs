using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoProgram
{
    public partial class Lotto : Form
    {
        bool isAmountOfPullsBoxValid = false;
        int[] lottoRow = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        

        public Lotto()
        {
            InitializeComponent();
        }
        private void CheckLottoRowNumber(int lottoRowPosition, TextBox selectedTextBox)
        {
            //Sätter index positionen till aktuell plats i lottoRaden för klarhet i koden
            int lottoRowIndexPosition = lottoRowPosition - 1;

            //Nollställer talet i position 0 i array lottoRow
            lottoRow[lottoRowIndexPosition] = 0;
            try
            {
                //Parsar texten till en int
                int number = int.Parse(selectedTextBox.Text);

                //Kollar om talet är mellan 1 till 35 och att talet är unikt
                if (number >= 1 && number <= 35 && !lottoRow.Contains(number))
                {
                    //Ändrar bakgrundsfärgen till gröngul på raderna och lägger in de inmatade nummerena i rätt position
                    selectedTextBox.BackColor = Color.GreenYellow;
                    lottoRow[lottoRowIndexPosition] = number;
                }
                else
                {
                    //Ändrar bakgrundsfärgen till indianred om man matar in mer än 35
                    selectedTextBox.BackColor = Color.IndianRed;
                }
            }
            catch
            {
                //Ändrar bakgrundsfärgen till indianred när man matar in fel typ av input
                selectedTextBox.BackColor = Color.IndianRed;
            }
            CheckIfEnableStartLottoButton();
        }

        private void CheckIfEnableStartLottoButton()
        {
            if (!lottoRow.Contains(0) && isAmountOfPullsBoxValid == true)
            {
                LottoStartButton.Enabled = true;
            }
            else
            {
                LottoStartButton.Enabled = false;
            }
        }
        private void LottoRowNumberBox1_TextChanged(object sender, EventArgs e)
        {
            CheckLottoRowNumber(1, LottoRowNumberBox1);
            ////Nollställer talet i position 0 i array lottoRow
            //lottoRow[0] = 0;
            //try
            //{
            //    int number = int.Parse(LottoRowNumberBox1.Text);

            //    //Kollar om talet är mellan 1 till 35 och att talet är unikt
            //    if (number >= 1 && number <= 35 && !lottoRow.Contains(number)) 
            //    {
            //        LottoRowNumberBox1.BackColor = Color.GreenYellow;
            //        lottoRow[0] = number;
            //    }
            //    else
            //    {
            //        LottoRowNumberBox1.BackColor = Color.IndianRed;
            //    }
            //}
            //catch
            //{
            //    LottoRowNumberBox1.BackColor = Color.IndianRed;
            //}
        }
        private void LottoRowNumberBox2_TextChanged(object sender, EventArgs e)
        {
            CheckLottoRowNumber(2, LottoRowNumberBox2);
        }

        private void LottoRowNumberBox3_TextChanged(object sender, EventArgs e)
        {
            CheckLottoRowNumber(3, LottoRowNumberBox3);
        }

        private void LottoRowNumberBox4_TextChanged(object sender, EventArgs e)
        {
            CheckLottoRowNumber(4, LottoRowNumberBox4);
        }

        private void LottoRowNumberBox5_TextChanged(object sender, EventArgs e)
        {
            CheckLottoRowNumber(5, LottoRowNumberBox5);
        }

        private void LottoRowNumberBox6_TextChanged(object sender, EventArgs e)
        {
            CheckLottoRowNumber(6, LottoRowNumberBox6);
        }

        private void LottoRowNumberBox7_TextChanged(object sender, EventArgs e)
        {
            CheckLottoRowNumber(7, LottoRowNumberBox7);
        }

        private void AmountOfPullsBox_TextChanged(object sender, EventArgs e)
        {
            isAmountOfPullsBoxValid = false;
            try
            {
                int number = int.Parse(AmountOfPullsBox.Text);

                //Kollar om talet är mellan 1 till 999 999
                if (number >= 1 && number <= 999999)
                {
                    AmountOfPullsBox.BackColor = Color.GreenYellow;
                    isAmountOfPullsBoxValid = true;
                }
                else
                {
                    AmountOfPullsBox.BackColor = Color.IndianRed;
                }
            }
            catch
            {
                AmountOfPullsBox.BackColor = Color.IndianRed;
            }
            CheckIfEnableStartLottoButton();
        }

        private void LottoStartButton_Click(object sender, EventArgs e)
        {
            //Kolla hur många dragningar som ska göras (En eller x antal dragningar)
            int numberOfPulls = int.Parse(AmountOfPullsBox.Text);
            int rightAnswersFive = 0;
            int rightAnswersSix = 0;
            int rightAnswersSeven = 0;
            LottoStartButton.Enabled = false;

            //Lopa igenom för varje dragning
            for (int i = 0; i < numberOfPulls; i++)
            {
                //Generera en lottoRad per dragning
                int storedNumber;
                int[] randomLottoRow = new int[7];

                Random rand = new Random();

                for (int row = 0; row < 7; row++)
                {
                    do
                    {
                        storedNumber = rand.Next(1, 35);
                    }
                    while (randomLottoRow.Contains(storedNumber));
                    randomLottoRow[row] = storedNumber;
                }

                IEnumerable<int> alikeNumbers = lottoRow.Intersect(randomLottoRow);
                int rightAnswers = alikeNumbers.Count();

                //Kolla hur många lottoDragningar som hade 5 rätt mot lottoraden som är inskriven
                if (rightAnswers == 5)
                {
                    rightAnswersFive++;
                }
                //Kolla hur många lottoDragningar som hade 6 rätt mot lottoraden som är inskriven
                else if (rightAnswers == 6)
                {
                    rightAnswersSix++;
                }
                //Kolla hur många lottoDragningar som hade 7 rätt mot lottoraden som är inskriven
                else if (rightAnswers == 7)
                {
                    rightAnswersSeven++;
                }
            }

            LottoStartButton.Enabled = true;

            //Sätt hur många rätt det blev i de olika boxarna
            string rightAnsersFiveText = rightAnswersFive.ToString();
            string rightAnsersSixText = rightAnswersSix.ToString();
            string rightAnsersSevenText = rightAnswersSeven.ToString();

            FiveRightBox.Text = rightAnsersFiveText;
            SixRightBox.Text = rightAnsersSixText;
            SevenRightBox.Text = rightAnsersSevenText;
        }

        private void Lotto_Load(object sender, EventArgs e)
        {

        }
    }
}
