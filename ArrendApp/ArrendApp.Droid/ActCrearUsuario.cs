using Android.Content;
using Android.OS;
using Android.Views;

namespace ArrendApp.Droid
{
    class ActCrearUsuario : Android.Support.V4.App.Fragment
    {
        public ActCrearUsuario()
        {

        }
        public static Android.Support.V4.App.Fragment newInstance(Context context)
        {
            ActCrearUsuario busrouteFragment = new ActCrearUsuario();
            return busrouteFragment;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup root = (ViewGroup)inflater.Inflate(Resource.Layout.lytCrearUsuario, null);
            return root;
        }
    }
}