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
using Xamarin.Essentials;


namespace CoffeeShopApp
{
    [Activity(Label = "Products_List_Activity")]
    public class Products_List_Activity : ListActivity
    {
        public static List<Shop_Item> shopItems;
        public double Total;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.products_list);

            if (shopItems == null) LoadProducts();

            ListAdapter = new Shop_Item_Adapter(this, shopItems);


            var UpdatePrice = FindViewById<TextView>(Resource.Id.price_display);
            var myValue = Preferences.Get("my_key", "default_value");
            UpdatePrice.Text = myValue;
            
            
            var PurchaseButton = FindViewById<Button>(Resource.Id.purchase_Button);
            PurchaseButton.Click += (s, e) =>
            {
                Intent purchaseScreen = new Intent(this, typeof(MainActivity));
                StartActivity(purchaseScreen);
            };
            


        }

        

        public void LoadProducts()
        {
            shopItems = new List<Shop_Item>();

            Shop_Item BlackCoffee = new Shop_Item
            {
                Name = "Black Coffee",
                Description = "Black coffee is actually regular coffee! All the other coffees you see are just black coffee with additives like sugar, creme, and all sorts of crazy stuff.",
                Price = 2.5,
                Image = this.GetDrawable(Resource.Drawable.black_coffee),

            };
            shopItems.Add(BlackCoffee);

            Shop_Item Americano = new Shop_Item
            {
                Name = "Americano",
                Description = "Caffè Americano or Americano is a type of coffee drink prepared by diluting an espresso with hot water, giving it a similar strength to, but different flavor from.",
                Price = 3,
                Image = this.GetDrawable(Resource.Drawable.americano),

            };
            shopItems.Add(Americano);

            Shop_Item Cappuccino = new Shop_Item
            {
                Name = "Cappuccino",
                Description = "A cappuccino is an espresso-based coffee drink that originated in Italy, and is traditionally prepared with steamed milk foam.",
                Price = 4,
                Image = this.GetDrawable(Resource.Drawable.cappuccino),

            };
            shopItems.Add(Cappuccino);

            Shop_Item Espresso = new Shop_Item
            {
                Name = "Espresso",
                Description = "Espresso is coffee of Italian origin, brewed by expressing or forcing a small amount of nearly boiling water under pressure through finely ground coffee beans",
                Price = 3,
                Image = this.GetDrawable(Resource.Drawable.espresso),

            };
            shopItems.Add(Espresso);

            Shop_Item Macchiato = new Shop_Item
            {
                Name = "Macchiato",
                Description = "Caffè macchiato, sometimes called espresso macchiato, is an espresso coffee drink with a small amount of milk, usually foamed.",
                Price = 4,
                Image = this.GetDrawable(Resource.Drawable.macchiato),

            };
            shopItems.Add(Macchiato);
        }
    }
}