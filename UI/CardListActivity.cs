using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;
using RandomCardChooser.Core;

namespace RandomCardChooser.UI
{
    [Activity(Label = "CardListActivity")]
    public class CardListActivity : Activity
    {
        private List<Card> cards;
        private CardAdapter adapter;
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cardListView);
            initViews();

            if (Intent.Extras != null)
            {
                cards = JsonConvert.DeserializeObject<List<Card>>(Intent.Extras.GetString("cards"));
                if (cards != null && cards.Count > 0)
                {
                    adapter = new CardAdapter(this, cards);
                    mListView.Adapter = adapter;
                    return;
                }
                Toast.MakeText(this, Resource.String.noCardDiscarded, ToastLength.Short).Show();
            }
        }

        private void initViews()
        {
            mListView = FindViewById<ListView>(Resource.Id.mListView);
        }
    }
}