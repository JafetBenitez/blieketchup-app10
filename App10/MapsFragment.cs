using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Gms.Maps;

namespace App10
{
    public class MapsFragment : Fragment, IOnMapReadyCallback
    {
        public GoogleMap cMap;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
            SetupMap();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            return inflater.Inflate(Resource.Layout.maps_fragment, container, false);

            //return base.OnCreateView(inflater, container, savedInstanceState);
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            //googleMap.SetMapStyle(MapS);
            this.cMap = googleMap;
        }

        private void SetupMap() {
            if (cMap == null) {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.darkMap).GetMapAsync(this);
            }
        }
    }
}