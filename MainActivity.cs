// Author : AerWyn81
// Latest release : 23/01/2018

using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;

namespace RandomCardChooser
{
    [Activity(Label = "RandomCardChooser", MainLauncher = true)]
    public class GetFields : Activity
    {
        private Button shoot, shuffle;
        private ImageView imgCards;
        private TextView tvDiscard, tvCardsLeft;
        private Random rnd;

        private int nbRandom, nbDiscardingCards, nbLeftCards;
        private List<int> listResId;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            InitViews();
            SetObjs();

            shoot.Click += delegate { ShootOnClick(); };
            shuffle.Click += delegate { ShuffleOnClick(); };
        }

        /// <summary>
        /// Set var's
        /// </summary>
        private void SetObjs()
        {
            rnd = new Random();
            listResId = new List<int>();
            fillListRes();
        }
        /// <summary>
        /// Reset number of cards on shuffle button click
        /// </summary>
        private void ShuffleOnClick()
        {
            listResId.Clear();
            fillListRes();
            tvDiscard.Text = nbDiscardingCards.ToString();
            tvCardsLeft.Text = nbLeftCards.ToString();

            imgCards.Visibility = Android.Views.ViewStates.Invisible;
        }

        /// <summary>
        /// Get a random card and update activity
        /// </summary>
        private void ShootOnClick()
        {
            nbRandom = GenRandomNumber();

            if (nbRandom != 999) {
                imgCards.Visibility = Android.Views.ViewStates.Visible;
                imgCards.SetImageResource(listResId[nbRandom]);
                listResId.RemoveAt(nbRandom);
                tvDiscard.Text = (nbDiscardingCards = nbDiscardingCards + 1).ToString();
                tvCardsLeft.Text = (nbLeftCards = nbLeftCards - 1).ToString();
            }
            else
            {
                Toast.MakeText(this, Resource.String.noCards, ToastLength.Short).Show();
            }
        }
        /// <summary>
        /// Get number of cards left
        /// </summary>
        /// <returns>Int: Nombre de cartes</returns>
        private int CardLeft()
        {
            return listResId.Count;
        }

        /// <summary>
        /// Get a random number between cards remaining.
        /// </summary>
        /// <returns>int: Return a number between 1 and 54</returns>
        private int GenRandomNumber()
        {
            if (CardLeft() != 0)
            {
                return rnd.Next(listResId.Count - 1);  
            }
            return 999; //if error listResId == 0
        }

        /// <summary>
        /// Init all views axml
        /// </summary>
        public void InitViews()
        {
            shoot = FindViewById<Button>(Resource.Id.btnShoot);
            shuffle = FindViewById<Button>(Resource.Id.btnShuffle);
            imgCards = FindViewById<ImageView>(Resource.Id.imgViews);
            tvDiscard = FindViewById<TextView>(Resource.Id.nbCartesDefausses);
            tvCardsLeft = FindViewById<TextView>(Resource.Id.nbCartesTotales);
        }

        /// <summary>
        /// Fill list of drawable resources and set variables cards to left and cards to discard
        /// </summary>
        public void fillListRes()
        {
            foreach (var f in typeof(Resource.Drawable).GetFields())
            {
                listResId.Add((int)f.GetValue(null));
            }

            nbDiscardingCards = 0;
            nbLeftCards = 54;
        }
    }
}

