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
    [Activity(Label = "IniciarSesion", MainLauncher = false, Icon = "@drawable/icon")]
    class ActIniciarSesion : Android.App.Activity
    {
        private EditText oEdtUsuario;
        private EditText oEdtContrasena;
        private Button oBtnLimpiar;
        private Button oBtnIngresar;
        private Button oBtnRecuperar;

        public ActIniciarSesion()
        {

        }

        
        private void mInstanciarControles()
        {
            oEdtUsuario    = this.FindViewById<EditText>(Resource.Id.EdtUsuario);
            oEdtContrasena = this.FindViewById<EditText>(Resource.Id.EdtConstrasena);
            oBtnLimpiar    = this.FindViewById<Button>(Resource.Id.BtnLimpiar);
            oBtnIngresar   = this.FindViewById<Button>(Resource.Id.BtnIngresar);
            oBtnRecuperar  = this.FindViewById<Button>(Resource.Id.BtnRecuperarContrasena);
        }

        private void mCrearEventos()
        {
            oBtnLimpiar.Click += delegate {
                Toast.MakeText(this, "Limpiar!", ToastLength.Short).Show();
                oEdtUsuario.SetText("", TextView.BufferType.Editable);
                oEdtContrasena.SetText("", TextView.BufferType.Editable);
            };
            oBtnIngresar.Click += delegate {
                Toast.MakeText(this, "Ingresar!", ToastLength.Short).Show();
            };
            oBtnRecuperar.Click += delegate
            {
                Toast.MakeText(this, "Recuperar!", ToastLength.Short).Show();
            };

        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.lytIniciarSesion);
            mInstanciarControles();
            mCrearEventos();
        }       
    }
}