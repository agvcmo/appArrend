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
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using SupportFragment = Android.Support.V4.App.Fragment;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using System.Collections.Generic;


namespace ArrendApp.Droid
{
    class ActIniciarSesion : Android.Support.V4.App.Fragment
    {
        private View mView;
        private EditText mEdtUsuario;
        private EditText mEdtContrasena;
        private Button mBtnLimpiar;
        private Button mBtnIngresar;
        private Button mBtnRecuperar;

        public ActIniciarSesion()
        {

        }

        
        private void mCrearControles()
        {
            mEdtUsuario    = mView.FindViewById<EditText>(Resource.Id.EdtUsuario);
            mEdtContrasena = mView.FindViewById<EditText>(Resource.Id.EdtConstrasena);
            mBtnLimpiar    = mView.FindViewById<Button>(Resource.Id.BtnLimpiar);
            mBtnIngresar   = mView.FindViewById<Button>(Resource.Id.BtnIngresar);
            mBtnRecuperar  = mView.FindViewById<Button>(Resource.Id.BtnRecuperarContrasena);
        }

        private void mCrearEventos()
        {
            mBtnLimpiar.Click += delegate {
                mEdtUsuario.SetText("",TextView.BufferType.Editable);
                mEdtContrasena.SetText("", TextView.BufferType.Editable);
            };
        }

        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            ActIniciarSesion busrouteFragment = new ActIniciarSesion();
            return busrouteFragment;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            mView = (ViewGroup)inflater.Inflate(Resource.Layout.lytIniciarSesion, null);
            mCrearControles();
            return mView;
        }



       
    }
}