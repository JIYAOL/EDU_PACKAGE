
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

namespace Project1
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.main1);
            string price = Intent.GetStringExtra("d");
            TextView textView = FindViewById<TextView>(Resource.Id.textView2);
            textView.Text = "$"+ price;

            Button button = FindViewById<Button>(Resource.Id.button2);

            button.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);

            };
        }
    }
}
