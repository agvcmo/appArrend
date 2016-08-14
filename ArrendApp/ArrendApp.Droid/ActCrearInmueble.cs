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
    [Activity(Label = "CrearInmuebles", MainLauncher = false, Icon = "@drawable/icon")]
    class ActCrearInmueble : Android.App.Activity
    {
        private EditText oEdtArrendador;
        private EditText oEdtArrendatario;
        private EditText oEdtTelefono;
        private EditText oEdtDireccion;
        private Button oBtnIngresar;
        private Button oBtnLimpiar;

        public ActCrearInmueble()
        {

        }
        private void mInstanciarControles()
        {
            oEdtArrendador    = this.FindViewById<EditText>(Resource.Id.EdtNombres);
            oEdtArrendatario  = this.FindViewById<EditText>(Resource.Id.EdtPApellido);
            oEdtTelefono      = this.FindViewById<EditText>(Resource.Id.EdtTelefono);
            oEdtDireccion     = this.FindViewById<EditText>(Resource.Id.EdtDireccion);
            oBtnLimpiar    = this.FindViewById<Button>(Resource.Id.BtnLimpiar);
            oBtnIngresar   = this.FindViewById<Button>(Resource.Id.BtnIngresar);
        }
        private void mCrearEventos()
        {
            oBtnLimpiar.Click += delegate {
                Toast.MakeText(this, "Limpiar!", ToastLength.Short).Show();
                oEdtArrendador.SetText  ("", TextView.BufferType.Editable);
                oEdtArrendatario.SetText("", TextView.BufferType.Editable);
                oEdtTelefono.SetText    ("", TextView.BufferType.Editable);
                oEdtDireccion.SetText   ("", TextView.BufferType.Editable);
            };
            oBtnIngresar.Click += delegate {
                Toast.MakeText(this, "Ingresar!", ToastLength.Short).Show();
            };
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.lytCrearUsuario);
            mInstanciarControles();
            mCrearEventos();
        }
    }
    
}