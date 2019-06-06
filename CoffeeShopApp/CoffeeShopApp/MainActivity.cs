using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;
using Android.Views;
using SupportToolBar = Android.Support.V7.Widget.Toolbar;
using Android.Content;
using Xamarin.Essentials;

namespace CoffeeShopApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public static List<Shop_Item> shopItems;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);


            var ToListButton = FindViewById<Button>(Resource.Id.gotolist);

            

            ToListButton.Click += (s, e) =>
            {
                Intent productsList = new Intent(this, typeof(Products_List_Activity));
                StartActivity(productsList);
            };

        }

        
    }
}