using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CoffeeShopApp
{
    public class Shop_Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Drawable Image { get; set; }
    }
}