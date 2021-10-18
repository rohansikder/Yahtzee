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

        int oneSum;
        int twoSum;
        int threeSum;
        int fourSum;
        int fiveSum;
        int sixSum;

        bool hold1 = true;
        bool hold2 = true;
        bool hold3 = true;
        bool hold4 = true;
        bool hold5 = true;

        Random random;

        public MainPage()
        {
            InitializeComponent();
        }

        private void upperSection()
        {
            oneSum = 0;
            twoSum = 0;
            threeSum = 0;
            fourSum = 0;
            fiveSum = 0;
            sixSum = 0;

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

        private void lowerSection()
        {
            int threeKindSum = 0;
            int fourKindSum = 0;
            int houseSum = 0;
            int SstraightSum = 0;
            int LStraightSum = 0;
            int yahtzeeSum = 0;
            int chanceSum;

            //Note: use upperSection to calculate the rest
            //ThreeKind combo
            if(oneSum == 3 || twoSum == 6 || threeSum == 9 || fourSum == 12 || fiveSum == 15 || sixSum == 16)
            {
                threeKindSum = diceRoll1 + diceRoll2 + diceRoll3 + diceRoll4 + diceRoll5;
            }
            threeKindValue.Text = threeKindSum.ToString();

            //FourKind combo
            if (oneSum == 4 || twoSum == 8 || threeSum == 12 || fourSum == 16 || fiveSum == 20 || sixSum == 24)
            {
                fourKindSum = diceRoll1 + diceRoll2 + diceRoll3 + diceRoll4 + diceRoll5;
            }
            fourKindValue.Text = fourKindSum.ToString();

            //FullHouse combo
            if ((oneSum == 3 || twoSum == 6 || threeSum == 9 || fourSum == 12 || fiveSum == 15 || sixSum == 16)
                && (oneSum == 2 || twoSum == 4 || threeSum == 6 || fourSum == 8 || fiveSum == 10 || sixSum == 12))
            {
                houseSum = 25;
            }
            houseValue.Text = houseSum.ToString();

            //SmallStraight combo
            if((oneSum == 1 && twoSum == 2 && threeSum == 3 && fourSum == 4) || (twoSum == 2 && threeSum == 3 && fourSum == 4 && fiveSum == 5) 
                || (threeSum == 3 && fourSum == 4 && fiveSum == 5 && sixSum == 6))
            {
                SstraightSum = 30;
            }
            smallStraightValue.Text = SstraightSum.ToString();

            //LargeStraight Combo
            if ((oneSum == 1 && twoSum == 2 && threeSum == 3 && fourSum == 4 && fiveSum == 5) 
                || (twoSum == 2 && threeSum == 3 && fourSum == 4 && fiveSum == 5 && sixSum == 6))
            {
                LStraightSum = 40;
            }
            largeStraightValue.Text = LStraightSum.ToString();

                //Yhatzee combo
                if (diceRoll1 == diceRoll2 && diceRoll2 == diceRoll3 && diceRoll3 == diceRoll4 && diceRoll4 == diceRoll5)
            {
                yahtzeeSum = 50;
            }
            yahtzeeValue.Text = yahtzeeSum.ToString();

            //chance combo
            chanceSum = diceRoll1 + diceRoll2 + diceRoll3 + diceRoll4 + diceRoll5;
            chanceValue.Text = chanceSum.ToString();


        }

        private void BtnDiceRollClicked(object sender, EventArgs e)
        {

            // generate a random number between 1 and 6
            if (random == null)
            {
                random = new Random();
            }

            /**/
            if(hold1 == true)diceRoll1 = random.Next(1, 7);
            if(hold2 == true)diceRoll2 = random.Next(1, 7);
            if(hold3 == true)diceRoll3 = random.Next(1, 7);
            if(hold4 == true)diceRoll4 = random.Next(1, 7);
            if(hold5 == true)diceRoll5 = random.Next(1, 7);
            

            /*Used To test if combinations are working
            diceRoll1 = 1;
            diceRoll2 = 2;
            diceRoll3 = 3;
            diceRoll4 = 4;
            diceRoll5 = 5;
            */

            dice1.Text = diceRoll1.ToString();
            dice2.Text = diceRoll2.ToString();
            dice3.Text = diceRoll3.ToString();
            dice4.Text = diceRoll4.ToString();
            dice5.Text = diceRoll5.ToString();

            upperSection();
            lowerSection();
            
        }

        private void btnHold1_Clicked(object sender, EventArgs e)
        {
            if(hold1)
            { 
            hold1 = false;
            btnHold1.BackgroundColor = Color.Red;
            btnHold1.Text = "Held";
            }
            else
            {
                hold1 = true;
                btnHold1.BackgroundColor = Color.Gray;
                btnHold1.Text = "Hold";
            }
        }

        private void btnHold2_Clicked(object sender, EventArgs e)
        {
            if (hold2)
            {
                hold2 = false;
                btnHold2.BackgroundColor = Color.Red;
                btnHold2.Text = "Held";
            }
            else
            {
                hold2 = true;
                btnHold2.BackgroundColor = Color.Gray;
                btnHold2.Text = "Hold";
            }
        }

        private void btnHold3_Clicked(object sender, EventArgs e)
        {
            if (hold3)
            {
                hold3 = false;
                btnHold3.BackgroundColor = Color.Red;
                btnHold3.Text = "Held";
            }
            else
            {
                hold3 = true;
                btnHold3.BackgroundColor = Color.Gray;
                btnHold3.Text = "Hold";
            }

        }

        private void btnHold4_Clicked(object sender, EventArgs e)
        {
            if (hold4)
            {
                hold4 = false;
                btnHold4.BackgroundColor = Color.Red;
                btnHold4.Text = "Held";
            }
            else
            {
                hold4 = true;
                btnHold4.BackgroundColor = Color.Gray;
                btnHold4.Text = "Hold";
            }

        }

        private void btnHold5_Clicked(object sender, EventArgs e)
        {
            if (hold5)
            {
                hold5 = false;
                btnHold5.BackgroundColor = Color.Red;
                btnHold5.Text = "Held";
            }
            else
            {
                hold5 = true;
                btnHold5.BackgroundColor = Color.Gray;
                btnHold5.Text = "Hold";
            }
        }
    }//End of public class
}//End namespace
