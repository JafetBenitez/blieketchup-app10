using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Gms.Maps;

namespace App10
{
    [Activity(Label = "App10", MainLauncher = true, Icon = "@mipmap/ic_launcher", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity

    {
        


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

           var bottomNav = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNav.NavigationItemSelected += (s, e) =>
            {
                LoadFragment(e.Item.ItemId);

            };

            LoadFragment(Resource.Id.action_map);
            

        }



        void LoadFragment(int id)
                {
                    Fragment fragment = null;
                    switch (id)
                    {
                        case Resource.Id.action_preferences:
                            fragment = new PreferencesFragment();
                            break;
                        case Resource.Id.action_map:
                            StartActivity(typeof(Map));
                        break;
                        case Resource.Id.action_recomendations:
                            fragment = new RecomendationFragment();
                            break;
                    }

                    if (fragment == null)
                        return;

                    FragmentManager.BeginTransaction()
                        .Replace(Resource.Id.content_frame, fragment)
                        .Commit();
                }


    }
}

