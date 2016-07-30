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

namespace ArrendApp.Droid
{
    class ActReportes : Android.Support.V4.App.Fragment
    {
        public ActReportes()
        {

        }
        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            ActReportes busrouteFragment = new ActReportes();
            return busrouteFragment;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.lytReportes, null);
            return root;
        }
    }
}