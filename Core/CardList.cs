using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RandomCardChooser.Core
{
    public class CardList
    {
        public static String getNomCarte(int idDrawable)
        {
            switch (idDrawable)
            {
                case 2130837504 : return "2 of clubs";
                case 2130837505 : return "8 of diamonds";
                case 2130837506 : return "8 of hearts";
                case 2130837507 : return "8 of spades";
                case 2130837508 : return "9 of clubs";
                case 2130837509 : return "9 of diamonds";
                case 2130837510 : return "9 of hearts";
                case 2130837511 : return "9 of spades";
                case 2130837512 : return "10 of clubs";
                case 2130837513 : return "10 of diamonds";
                case 2130837514 : return "10 of hearts";
                case 2130837515 : return "10 of spades";
                case 2130837516 : return "Ace of clubs";
                case 2130837517 : return "Ace of diamonds";
                case 2130837518 : return "Ace of hearts";
                case 2130837519 : return "Ace of spades";
                case 2130837520 : return "Knave of clubs";
                case 2130837521 : return "Knave of diamonds";
                case 2130837522 : return "Knave of hearts";
                case 2130837523 : return "4 of hearts";
                case 2130837524 : return "King of clubs";
                case 2130837525 : return "King of diamonds";
                case 2130837526 : return "King of hearts";
                case 2130837527 : return "King of spades";
                case 2130837528 : return "Queen of clubs";
                case 2130837529 : return "Queen of diamonds";
                case 2130837530 : return "2 of diamonds";
                case 2130837531 : return "Queen of hearts";
                case 2130837532 : return "Queen of spades";
                case 2130837533 : return "Joker";
                case 2130837534 : return "Joker";
                case 2130837535 : return "2 of hearts";
                case 2130837536 : return "2 of spades";
                case 2130837537 : return "3 of clubs";
                case 2130837538 : return "3 of diamonds";
                case 2130837539 : return "3 of hearts";
                case 2130837540 : return "3 of spades";
                case 2130837541 : return "4 of clubs";
                case 2130837542 : return "4 of diamonds";
                case 2130837543 : return "Knave of spades";
                case 2130837544 : return "4 of spades";
                case 2130837545 : return "5 of clubs";
                case 2130837546 : return "5 of diamonds";
                case 2130837547 : return "5 of hearts";
                case 2130837548 : return "5 of spades";
                case 2130837549 : return "6 of clubs";
                case 2130837550 : return "6 of diamonds";
                case 2130837551 : return "6 of hearts";
                case 2130837552 : return "6 of spades";
                case 2130837553 : return "7 of clubs";
                case 2130837554 : return "7 of diamonds";
                case 2130837555 : return "7 of hearts";
                case 2130837556 : return "7 of spades";
                case 2130837557 : return "8 of clubs";

            }

            return null;
        }
    }
}