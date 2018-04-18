using Android.App;
using Android.Widget;
using Android.OS;

namespace DalekBob
{
    [Activity(Label = "DalekBob", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Comment to cause changes
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

