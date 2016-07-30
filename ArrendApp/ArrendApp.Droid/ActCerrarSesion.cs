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
    class ActCerrarSesion : Android.Support.V4.App.Fragment
    {
        public ActCerrarSesion()
        {

        }
        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            ActCerrarSesion busrouteFragment = new ActCerrarSesion();
            return busrouteFragment;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.lytCerrarSesion, null);
            return root;
        }
    }
}