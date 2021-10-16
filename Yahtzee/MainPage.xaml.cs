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
        int rollCount = 3;

        int total;


        Random random;

        public MainPage()
        {
            InitializeComponent();
        }

        private void one()
        {

            

        }

        private void BtnDiceRollClicked(object sender, EventArgs e)
        {

            string ButtonText = ((Button)sender).Text;

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

        }


    }//End of public class
}//End namespace
