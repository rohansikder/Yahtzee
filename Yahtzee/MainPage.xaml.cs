// Rohan Sikder 
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
        int total;
        int bonus = 35;
        int rolls = 3;

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
        int upperTotal;

        int threeKindSum;
        int fourKindSum;
        int houseSum;
        int SstraightSum;
        int LStraightSum;
        int yahtzeeSum;
        int chanceSum;
        int lowerTotal;

        bool hold1 = true;
        bool hold2 = true;
        bool hold3 = true;
        bool hold4 = true;
        bool hold5 = true;

        bool keepOne = true;
        bool keepTwo = true;
        bool keepThree = true;
        bool keepFour = true;
        bool keepFive = true;
        bool keepSix = true;
        bool keepThreeKind = true;
        bool keepFourKind = true;
        bool keepFull = true;
        bool keepLarge = true;
        bool keepSmall = true;
        bool keepYahtzee = true;
        bool keepChance = true;


        Random random;

        public MainPage()
        {
            InitializeComponent();
        }


        #region Create methods to do Combination calculations and store
        /// <summary>
        /// Did the combination calculation and showed user
        /// </summary>
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
            if(keepOne == true)oneValue.Text = oneSum.ToString();

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
            if (diceRoll5 == 2)
            {
                twoSum = twoSum + diceRoll5;
            }
            if (keepTwo == true) twoValue.Text = twoSum.ToString();

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
            if (keepThree == true) threeValue.Text = threeSum.ToString();

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
            if (keepFour == true) fourValue.Text = fourSum.ToString();

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
            if (keepFive == true) fiveValue.Text = fiveSum.ToString();

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
            if (keepSix == true) sixValue.Text = sixSum.ToString();

        }

        private void lowerSection()
        {
            threeKindSum = 0;
            fourKindSum = 0;
            houseSum = 0;
            SstraightSum = 0;
            LStraightSum = 0;
            yahtzeeSum = 0;
            chanceSum = 0;

            //Note: use upperSection to calculate the rest
            //ThreeKind combo
            if (oneSum == 3 || twoSum == 6 || threeSum == 9 || fourSum == 12 || fiveSum == 15 || sixSum == 18)
            {
                threeKindSum = diceRoll1 + diceRoll2 + diceRoll3 + diceRoll4 + diceRoll5;
            }
            if (keepThreeKind == true) threeKindValue.Text = threeKindSum.ToString();

            //FourKind combo
            if (oneSum == 4 || twoSum == 8 || threeSum == 12 || fourSum == 16 || fiveSum == 20 || sixSum == 24)
            {
                fourKindSum = diceRoll1 + diceRoll2 + diceRoll3 + diceRoll4 + diceRoll5;
            }
            if (keepFourKind == true) fourKindValue.Text = fourKindSum.ToString();

            //FullHouse combo
            if ((oneSum == 3 || twoSum == 6 || threeSum == 9 || fourSum == 12 || fiveSum == 15 || sixSum == 18)
                && (oneSum == 2 || twoSum == 4 || threeSum == 6 || fourSum == 8 || fiveSum == 10 || sixSum == 12))
            {
                houseSum = 25;
            }
            if (keepFull == true) houseValue.Text = houseSum.ToString();

            //SmallStraight combo
            if ((oneSum == 1 && twoSum == 2 && threeSum == 3 && fourSum == 4) || (twoSum == 2 && threeSum == 3 && fourSum == 4 && fiveSum == 5)
                || (threeSum == 3 && fourSum == 4 && fiveSum == 5 && sixSum == 6))
            {
                SstraightSum = 30;
            }
            if (keepSmall == true) smallStraightValue.Text = SstraightSum.ToString();

            //LargeStraight Combo
            if ((oneSum == 1 && twoSum == 2 && threeSum == 3 && fourSum == 4 && fiveSum == 5)
                || (twoSum == 2 && threeSum == 3 && fourSum == 4 && fiveSum == 5 && sixSum == 6))
            {
                LStraightSum = 40;
            }
            if (keepLarge == true) largeStraightValue.Text = LStraightSum.ToString();

            //Yhatzee combo
            if (diceRoll1 == diceRoll2 && diceRoll2 == diceRoll3 && diceRoll3 == diceRoll4 && diceRoll4 == diceRoll5)
            {
                yahtzeeSum = 50;
            }
            if (keepYahtzee == true) yahtzeeValue.Text = yahtzeeSum.ToString();

            //chance combo
            chanceSum = diceRoll1 + diceRoll2 + diceRoll3 + diceRoll4 + diceRoll5;
            if (keepChance == true) chanceValue.Text = chanceSum.ToString();


        }
        #endregion

        #region Random generator for dice
        /// <summary>
        ///  Created rolls to count user dice 
        ///  Random generator for dice value
        ///  displayed dice to user and called calculations
        /// </summary>
        private void BtnDiceRollClicked(object sender, EventArgs e)
        {
            rolls--;
            Roll.Text = "Roll Dice: " + rolls;
            if (rolls >= 0)
            {
                // generate a random number between 1 and 6
                if (random == null)
                {
                    random = new Random();
                }

                /**/
                if (hold1 == true) diceRoll1 = random.Next(1, 7);
                if (hold2 == true) diceRoll2 = random.Next(1, 7);
                if (hold3 == true) diceRoll3 = random.Next(1, 7);
                if (hold4 == true) diceRoll4 = random.Next(1, 7);
                if (hold5 == true) diceRoll5 = random.Next(1, 7);

                dice1.Text = diceRoll1.ToString();
                dice2.Text = diceRoll2.ToString();
                dice3.Text = diceRoll3.ToString();
                dice4.Text = diceRoll4.ToString();
                dice5.Text = diceRoll5.ToString();

                upperSection();
                lowerSection();
            }
            else 
            {
                Roll.IsEnabled = false;
            }
            
        }
        #endregion

        #region Event Handlers for whne user clicks keep button
        /// <summary>
        /// checks if dice is not zero
        /// If user clicks hold button the this disables dice from changing
        /// </summary>
        private async void btnHold1_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
            else
            {
                if (hold1)
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
        }

        private async void btnHold2_Clicked(object sender, EventArgs e)
        {
            if (diceRoll2 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
            else
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
        }

        private async void btnHold3_Clicked(object sender, EventArgs e)
        {
            if (diceRoll3 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
            else
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

        }

        private async void btnHold4_Clicked(object sender, EventArgs e)
        {
            if (diceRoll4 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
            else
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

        }

        private async void btnHold5_Clicked(object sender, EventArgs e)
        {
            if (diceRoll5 == 0)
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
            else
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
        }
        #endregion

        #region
        /// <summary>
        /// 
        /// </summary>
        private async void btnOne_Clicked(object sender, EventArgs e)
        {
            
            if (diceRoll1 != 0)
            {
                total = oneSum + total;
                btnOne.IsEnabled = false;
                upperTotal = upperTotal + oneSum;
                keepOne = false;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnTwo_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = twoSum + total;
                btnTwo.IsEnabled = false;
                upperTotal = upperTotal + twoSum;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepTwo = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnThree_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != '0')
            {
                total = threeSum + total;
                btnThree.IsEnabled = false;
                upperTotal = upperTotal + threeSum;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepThree = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnFour_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = fourSum + total;
                btnFour.IsEnabled = false;
                upperTotal = upperTotal + fourSum;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepFour = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnFive_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = fiveSum + total;
                btnFive.IsEnabled = false;
                upperTotal = upperTotal + fiveSum;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepFive = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnSix_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = sixSum + total;
                btnSix.IsEnabled = false;
                upperTotal = upperTotal + sixSum;
                updateUpper();
                resetDice();
                resetHold();
                endGame();
                keepSix = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnThreeKind_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = threeKindSum + total;
                btnThreeKind.IsEnabled = false;
                lowerTotal = lowerTotal + threeKindSum;
                userTotal.Text = "Total: " + total;
                lblLowerTotal.Text = "Lower Total: " + lowerTotal;
                resetDice();
                resetHold();
                endGame();
                keepThreeKind = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnFourKind_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = fourKindSum + total;
                btnFourKind.IsEnabled = false;
                lowerTotal = lowerTotal + fourKindSum;
                userTotal.Text = "Total: " + total;
                lblLowerTotal.Text = "Lower Total: " + lowerTotal;
                resetDice();
                resetHold();
                endGame();
                keepFourKind = false;

            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnHouse_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = houseSum + total;
                btnHouse.IsEnabled = false;
                lowerTotal = lowerTotal + houseSum;
                userTotal.Text = "Total: " + total;
                lblLowerTotal.Text = "Lower Total: " + lowerTotal;
                resetDice();
                resetHold();
                endGame();
                keepFull = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnSmallStraight_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = SstraightSum + total;
                btnSmallStraight.IsEnabled = false;
                lowerTotal = lowerTotal + SstraightSum;
                userTotal.Text = "Total: " + total;
                lblLowerTotal.Text = "Lower Total: " + lowerTotal;
                resetDice();
                resetHold();
                endGame();
                keepSmall = false;
            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnLargeStraight_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
                {
                    total = LStraightSum + total;
                    btnLargeStraight.IsEnabled = false;
                    lowerTotal = lowerTotal + LStraightSum;
                    userTotal.Text = "Total: " + total;
                    lblLowerTotal.Text = "Lower Total: " + lowerTotal;
                    resetDice();
                    resetHold();
                    endGame();
                    keepLarge = false;

            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnYahtzee_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = yahtzeeSum + total;
                btnYahtzee.IsEnabled = false;
                lowerTotal = lowerTotal + yahtzeeSum;
                userTotal.Text = "Total: " + total;
                lblLowerTotal.Text = "Lower Total: " + lowerTotal;
                resetDice();
                resetHold();
                endGame();
                keepYahtzee = false;

            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }

        private async void btnChance_Clicked(object sender, EventArgs e)
        {
            if (diceRoll1 != 0)
            {
                total = chanceSum + total;
                btnChance.IsEnabled = false;
                lowerTotal = lowerTotal + chanceSum;
                userTotal.Text = "Total: " + total;
                lblLowerTotal.Text = "Lower Total: " + lowerTotal;
                resetDice();
                resetHold();
                endGame();
                keepChance = false;

            }
            else
            {
                await DisplayAlert("Roll Dice", "You have not rolled the dice yet, Please Roll by clicking roll dice at the bottom.", "Ok");
            }
        }
        #endregion

        private void updateUpper()
        {
            if (upperTotal >= 63) total = bonus + total;
            userTotal.Text = "Total: " + total;
            userBonus.Text = "Get total of 63: " + upperTotal;
            lblUpperTotal.Text = "Upper Total: " + upperTotal;
        }

        private void resetHold()
        {
            btnHold1.BackgroundColor = Color.DimGray;
            btnHold2.BackgroundColor = Color.DimGray;
            btnHold3.BackgroundColor = Color.DimGray;
            btnHold4.BackgroundColor = Color.DimGray;
            btnHold5.BackgroundColor = Color.DimGray;
            btnHold1.Text = "Hold";
            btnHold2.Text = "Hold";
            btnHold3.Text = "Hold";
            btnHold4.Text = "Hold";
            btnHold5.Text = "Hold";
            hold1 = true;
            hold2 = true;
            hold3 = true;
            hold4 = true;
            hold5 = true;
        }

        private void resetDice()
        {
            diceRoll1 = 0;
            diceRoll2 = 0;
            diceRoll3 = 0;
            diceRoll4 = 0;
            diceRoll5 = 0;

            rolls = 3;
            Roll.IsEnabled = true;
            Roll.Text = "Roll Dice: 3";

            dice1.Text = diceRoll1.ToString();
            dice2.Text = diceRoll2.ToString();
            dice3.Text = diceRoll3.ToString();
            dice4.Text = diceRoll4.ToString();
            dice5.Text = diceRoll5.ToString();
        }

        private void resetSum()
        {
            //Upper section
            oneSum = 0;
            twoSum = 0;
            threeSum = 0;
            fourSum = 0;
            fiveSum = 0;
            sixSum = 0;
            upperTotal = 0;

            //Lower Secetion
            threeKindSum = 0;
            fourKindSum = 0;
            houseSum = 0;
            SstraightSum = 0;
            LStraightSum = 0;
            yahtzeeSum = 0;
            chanceSum = 0;
            lowerTotal = 0;

            oneValue.Text = oneSum.ToString();
            twoValue.Text = twoSum.ToString();
            threeValue.Text = threeSum.ToString();
            fourValue.Text = fourSum.ToString();
            fiveValue.Text = fiveSum.ToString();
            sixValue.Text = sixSum.ToString();
            lblUpperTotal.Text = "Upper Total: 0";


            threeKindValue.Text = threeKindSum.ToString();
            fourKindValue.Text = fourKindSum.ToString();
            houseValue.Text = houseSum.ToString();
            smallStraightValue.Text = SstraightSum.ToString();
            largeStraightValue.Text = LStraightSum.ToString();
            yahtzeeValue.Text = yahtzeeSum.ToString();
            chanceValue.Text = chanceSum.ToString();
            lblLowerTotal.Text = "Lower Total: 0";

            keepOne = true;
            keepTwo = true;
            keepThree = true;
            keepFour = true;
            keepFive = true;
            keepSix = true;
            keepThreeKind = true;
            keepFourKind = true;
            keepFull = true;
            keepLarge = true;
            keepSmall = true;
            keepYahtzee = true;
            keepChance = true;
        }

        private async void Restart_Clicked(object sender, EventArgs e)
        {
            var confirmed = await DisplayAlert("Confirm", "Are you sure?", "Yes", "No");
            if (confirmed) 
            { 
                resetDice();
                resetHold();
                resetSum();
                rolls = 3;
                total = 0;
                bonus = 0;
                userTotal.Text = "Total: " + total;
                userBonus.Text = "Get total of 63: " + bonus;
                Roll.Text = "Roll Dice: 3";
                btnOne.IsEnabled = true;
                btnTwo.IsEnabled = true;
                btnThree.IsEnabled = true;
                btnFour.IsEnabled = true;
                btnFive.IsEnabled = true;
                btnSix.IsEnabled = true;
                btnThreeKind.IsEnabled = true;
                btnFourKind.IsEnabled = true;
                btnHouse.IsEnabled = true;
                btnSmallStraight.IsEnabled = true;
                btnLargeStraight.IsEnabled = true;
                btnYahtzee.IsEnabled = true;
                btnChance.IsEnabled = true;
                keepOne = true;
                keepTwo = true;
                keepThree = true;
                keepFour = true;
                keepFive = true;
                keepSix = true;
                keepThreeKind = true;
                keepFourKind = true;
                keepFull = true;
                keepLarge = true;
                keepSmall = true;
                keepYahtzee = true;
                keepChance = true;
            }
        }

        private async void endGame()
        {
            if (btnOne.IsEnabled == false && btnTwo.IsEnabled == false && btnThree.IsEnabled == false && btnFour.IsEnabled == false && btnFive.IsEnabled == false && btnSix.IsEnabled == false 
                && btnThreeKind.IsEnabled == false && btnFourKind.IsEnabled == false && btnHouse.IsEnabled == false && btnSmallStraight.IsEnabled == false && btnLargeStraight.IsEnabled == false 
                && btnYahtzee.IsEnabled == false && btnChance.IsEnabled == false)
            {
                await DisplayAlert("GAME FINISHED", "Your Total was " + total + ". \nYou scored " + lowerTotal + " in the Lower total.\nYou scored " + upperTotal + " in the Upper Total.", "Play again");
                resetDice();
                resetHold();
                resetSum();
                rolls = 3;
                total = 0;
                bonus = 0;
                userTotal.Text = "Total: " + total;
                userBonus.Text = "Get total of 63: " + bonus;
                Roll.Text = "Roll Dice: 3";
                btnOne.IsEnabled = true;
                btnTwo.IsEnabled = true;
                btnThree.IsEnabled = true;
                btnFour.IsEnabled = true;
                btnFive.IsEnabled = true;
                btnSix.IsEnabled = true;
                btnThreeKind.IsEnabled = true;
                btnFourKind.IsEnabled = true;
                btnHouse.IsEnabled = true;
                btnSmallStraight.IsEnabled = true;
                btnLargeStraight.IsEnabled = true;
                btnYahtzee.IsEnabled = true;
                btnChance.IsEnabled = true;
            }
        }

    }//End of public class
}//End namespace
