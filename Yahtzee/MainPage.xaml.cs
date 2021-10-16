using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Yahtzee
{
    public partial class MainPage : ContentPage
    {

        int diceRoll1 = 0;
        int diceRoll2 = 0;
        int diceRoll3 = 0;
        int diceRoll4 = 0;
        int diceRoll5 = 0;

        Random random;

        public MainPage()
        {
            InitializeComponent();
        }

        private void lowerSection()
        {
            int oneSum = 0;
            int twoSum = 0;
            int threeSum = 0;
            int fourSum = 0;
            int fiveSum = 0;
            int sixSum = 0;

            //calc for one combo
            if (diceRoll1 == 1)
            {
                oneSum = oneSum + diceRoll1;
            }
            if (diceRoll2 == 1)
            {
                oneSum = oneSum + diceRoll2;
            }
            if (diceRoll3 == 1)
            {
                oneSum = oneSum + diceRoll3;
            }
            if (diceRoll4 == 1)
            {
                oneSum = oneSum + diceRoll4;
            }
            if (diceRoll5 == 1)
            {
                oneSum = oneSum + diceRoll5;
            }

            oneValue.Text = oneSum.ToString();

            //calc for two combo
            if (diceRoll1 == 2)
            {
                twoSum = twoSum + diceRoll1;
            }
            if (diceRoll2 == 2)
            {
                twoSum = twoSum + diceRoll2;
            }
            if (diceRoll3 == 2)
            {
                twoSum = twoSum + diceRoll3;
            }
            if (diceRoll4 == 2)
            {
                twoSum = twoSum + diceRoll4;
            }
            if (diceRoll5 == 3)
            {
                twoSum = twoSum + diceRoll5;
            }
  
            twoValue.Text = twoSum.ToString();

            //calc for three combo
            if (diceRoll1 == 3)
            {
                threeSum = threeSum + diceRoll1;
            }
            if (diceRoll2 == 3)
            {
                threeSum = threeSum + diceRoll2;
            }
            if (diceRoll3 == 3)
            {
                threeSum = threeSum + diceRoll3;
            }
            if (diceRoll4 == 3)
            {
                threeSum = threeSum + diceRoll4;
            }
            if (diceRoll5 == 3)
            {
                threeSum = threeSum + diceRoll5;
            }

            threeValue.Text = threeSum.ToString();

            //calc for four combo
            if (diceRoll1 == 4)
            {
                fourSum = fourSum + diceRoll1;
            }
            if (diceRoll2 == 4)
            {
                fourSum = fourSum + diceRoll2;
            }
            if (diceRoll3 == 4)
            {
                fourSum = fourSum + diceRoll3;
            }
            if (diceRoll4 == 4)
            {
                fourSum = fourSum + diceRoll4;
            }
            if (diceRoll5 == 4)
            {
                fourSum = fourSum + diceRoll5;
            }

            fourValue.Text = fourSum.ToString();

            //calc for five combo
            if (diceRoll1 == 5)
            {
                fiveSum = fiveSum + diceRoll1;
            }
            if (diceRoll2 == 5)
            {
                fiveSum = fiveSum + diceRoll2;
            }
            if (diceRoll3 == 5)
            {
                fiveSum = fiveSum + diceRoll3;
            }
            if (diceRoll4 == 5)
            {
                fiveSum = fiveSum + diceRoll4;
            }
            if (diceRoll5 == 5)
            {
                fiveSum = fiveSum + diceRoll5;
            }

            fiveValue.Text = fiveSum.ToString();

            //calc for six combo
            if (diceRoll1 == 6)
            {
                sixSum = sixSum + diceRoll1;
            }
            if (diceRoll2 == 6)
            {
                sixSum = sixSum + diceRoll2;
            }
            if (diceRoll3 == 6)
            {
                sixSum = sixSum + diceRoll3;
            }
            if (diceRoll4 == 6)
            {
                sixSum = sixSum + diceRoll4;
            }
            if (diceRoll5 == 6)
            {
                sixSum = sixSum + diceRoll5;
            }

            sixValue.Text = sixSum.ToString();

        }

        private void BtnDiceRollClicked(object sender, EventArgs e)
        {

            // generate a random number between 1 and 6
            if (random == null)
            {
                random = new Random();
            }

            diceRoll1 = random.Next(1, 7);
            diceRoll2 = random.Next(1, 7);
            diceRoll3 = random.Next(1, 7);
            diceRoll4 = random.Next(1, 7);
            diceRoll5 = random.Next(1, 7);

            Dice1.Text = diceRoll1.ToString();
            Dice2.Text = diceRoll2.ToString();
            Dice3.Text = diceRoll3.ToString();
            Dice4.Text = diceRoll4.ToString();
            Dice5.Text = diceRoll5.ToString();

            lowerSection();  
        }


    }//End of public class
}//End namespace
