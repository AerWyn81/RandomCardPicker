using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using RandomCardChooser.Core;

namespace RandomCardChooser.UI
{
    class CardAdapter : ArrayAdapter<Card>
    {
        public const int RESOURCE_LAYOUT = Resource.Layout.item_card;
        private List<Card> cards;
        private Context c;

        public CardAdapter(Context context, List<Card> objects)
            : base(context, 0, objects)
        {
            cards = objects;
            c = Context;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null)
            {
                convertView = LayoutInflater.FromContext(Context).Inflate(RESOURCE_LAYOUT, null, false);
            }

            Card currentItem = GetItem(position);

            TextView pickedCard = convertView.FindViewById<TextView>(Resource.Id.pickedCardValue);
            TextView cardDiscard = convertView.FindViewById<TextView>(Resource.Id.cardRemainingValue);
            ImageView cardImage = convertView.FindViewById<ImageView>(Resource.Id.imageCard);

            pickedCard.Text = currentItem.cardName.ToString();
            cardDiscard.Text = currentItem.nbCardDirscard.ToString();
            cardImage.SetImageDrawable(c.GetDrawable(currentItem.drawCardNb));

            return convertView;
        }

        public override int Count => cards.Count;

        public new Card GetItem(int position)
        {
            return cards[position];
        }
    }
}