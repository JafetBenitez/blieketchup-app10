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
using Android.Gms.Maps.Model;

namespace App10
{
    public class MapsFragment : Fragment
    {

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
            //SetupMap();
            //this.fragment = new MpFrg();
            //FragmentManager.BeginTransaction()
            //.Replace(Resource.Id.content_frame, fragment)
            //.Commit();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            return inflater.Inflate(Resource.Layout.maps_fragment, container, false);

            //return base.OnCreateView(inflater, container, savedInstanceState);
        }


        //private void SetupMap() {
        //    if (cMap == null) {
        //        FragmentManager.FindFragmentById<MapFragment>(Resource.Layout.mpfrg).GetMapAsync(this);
        //    }
        //}
    }
}