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
using Android.Gms.Maps;
using Android.Support.Design.Widget;

namespace App10
{
    [Activity(Label = "Map", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Map : Activity, IOnMapReadyCallback
    {

        private GoogleMap Gmap;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Map);
            var bottomNav = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation2);
            bottomNav.NavigationItemSelected += (s, e) =>
            {
                LoadFragment(e.Item.ItemId);

            };
            SetupMap();
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

        private void SetupMap()
        {
            if (Gmap == null)
            {

                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.googlemap).GetMapAsync(this);
            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            Gmap = googleMap;
        }
    }
}