using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace ArrendApp.Droid
{
    [Activity(Label = "CrearUsuarios", MainLauncher = false, Icon = "@drawable/icon")]
    class ActCrearUsuario : Android.App.Activity
    {
        private ViewGroup oView;
        private EditText oEdtNombre;
        private EditText oEdtPApellido;
        private EditText oEdtSApellido;
        private EditText oEdtContrasena;
        private EditText oEdtTelefono;
        private EditText oEdtCelular;
        private EditText oEdtEdad;
        private EditText oEdtNombreUsuario;
        private EditText oEdtDireccion;
        private Button oBtnIngresar;
        private Button oBtnLimpiar;
        //private Usuario LUsuario;

        public ActCrearUsuario()
        {

        }

        private void mInstanciarControles()
        {
            oEdtNombre        = this.FindViewById<EditText>(Resource.Id.EdtNombres);
            oEdtPApellido     = this.FindViewById<EditText>(Resource.Id.EdtPApellido);
            oEdtSApellido     = this.FindViewById<EditText>(Resource.Id.EdtSApellido);
            oEdtContrasena    = this.FindViewById<EditText>(Resource.Id.EdtClave);
            oEdtTelefono      = this.FindViewById<EditText>(Resource.Id.EdtTelefono);
            oEdtCelular       = this.FindViewById<EditText>(Resource.Id.EdtCelular);
            oEdtEdad          = this.FindViewById<EditText>(Resource.Id.EdtEdad);
            oEdtNombreUsuario = this.FindViewById<EditText>(Resource.Id.EdtNombreUsuario);
            oEdtDireccion     = this.FindViewById<EditText>(Resource.Id.EdtDireccion);
            oBtnLimpiar    = this.FindViewById<Button>(Resource.Id.BtnLimpiar);
            oBtnIngresar   = this.FindViewById<Button>(Resource.Id.BtnIngresar);
        }
        private void mCrearEventos()
        {
            oBtnLimpiar.Click += delegate {
                Toast.MakeText(this, "Limpiar!", ToastLength.Short).Show();
                oEdtNombre.SetText       ("", TextView.BufferType.Editable);
                oEdtPApellido.SetText    ("", TextView.BufferType.Editable);
                oEdtSApellido.SetText    ("", TextView.BufferType.Editable);
                oEdtContrasena.SetText   ("", TextView.BufferType.Editable);
                oEdtTelefono.SetText     ("", TextView.BufferType.Editable);
                oEdtCelular.SetText      ("", TextView.BufferType.Editable);
                oEdtEdad.SetText         ("", TextView.BufferType.Editable);
                oEdtNombreUsuario.SetText("", TextView.BufferType.Editable);                
                oEdtDireccion.SetText    ("", TextView.BufferType.Editable);
                oBtnLimpiar.SetText      ("", TextView.BufferType.Editable);
                oBtnIngresar.SetText     ("", TextView.BufferType.Editable);
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