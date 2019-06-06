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
using Newtonsoft.Json;
using Xamarin.Essentials;


namespace CoffeeShopApp
{
    public class Shop_Item_Adapter : BaseAdapter<string>
    {

        readonly List<Shop_Item> shopItems;
        readonly Activity context;

        public Shop_Item_Adapter(Activity context, List<Shop_Item> items) : base()
        {
            this.context = context;
            this.shopItems = items;
        }

        public override string this[int position]
        {
            get { return shopItems[position].Name.ToString(); }
        }

        public override int Count
        {
            get
            {
                return shopItems.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.ShopItem, null);

            view.FindViewById<TextView>(Resource.Id.item_name).Text = " " + shopItems[position].Name;
            view.FindViewById<TextView>(Resource.Id.item_description).Text = " " + shopItems[position].Description;
            view.FindViewById<TextView>(Resource.Id.item_price).Text = shopItems[position].Price.ToString() + " €";
            

            //view.FindViewById<TextView>(Resource.Id.price_display).Text = Total.ToString() + " €";


            //view.FindViewById<ImageView>(Resource.Id.item_image).SetImageResource(shopItems[position].Image);

            if (shopItems[position].Image != null)
            {
                view.FindViewById<ImageView>(Resource.Id.item_add).SetImageDrawable(shopItems[position].Image);
            }
            else
            {
                view.FindViewById<ImageView>(Resource.Id.item_add).SetImageDrawable(null);
            }
            
            

            view.FindViewById<ImageView>(Resource.Id.item_add).Click += (s, e) =>
            {
                Preferences.Set("my_key", "6.00");

                

            };

            return view;
        }

        public void RestartActivity()
        {
            Intent productsList = new Intent(this, typeof(Products_List_Activity));
            StartActivity(productsList);
        }

    }
}