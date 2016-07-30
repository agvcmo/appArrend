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
    class ActCrearInmueble : Android.Support.V4.App.Fragment
    {
            public ActCrearInmueble()
            {

            }
            public static Android.Support.V4.App.Fragment newInstance(Context context)
            {
                ActCrearInmueble busrouteFragment = new ActCrearInmueble();
                return busrouteFragment;
            }
            public override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);

            }
            public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
            {
                ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.lytCrearInmueble, null);
                return root;
            }
        }
    
}