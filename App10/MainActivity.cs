using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.Design.Widget;

namespace App10
{
    [Activity(Label = "App10", MainLauncher = true, Icon = "@drawable/icon", Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

           var bottomNav = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNav.NavigationItemSelected += (s, e) =>
            {
                switch (e.Item.ItemId)
                {
                    case Resource.Id.action_preferences:
                        Toast.MakeText(this, "klk1", ToastLength.Long).Show();
                        
                        break;
                    case Resource.Id.action_map:
                        Toast.MakeText(this, "klk1", ToastLength.Long).Show();
                        break;
                    case Resource.Id.action_recomendations:
                        Toast.MakeText(this, "klk1", ToastLength.Long).Show();
                        break;
                }
            };

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

