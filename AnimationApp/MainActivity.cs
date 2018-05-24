using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Android.Views.Animations;

namespace AnimationApp
{
    [Activity(Label = "AnimationApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
        }

        public override void OnWindowFocusChanged(bool hasFocus)
        {
            if (hasFocus)
            {
                ImageView imageView = FindViewById<ImageView>(Resource.Id.animatedImageView);
                AnimationDrawable animation = (AnimationDrawable)imageView.Drawable;
                animation.Start();
            }
        }
    }
}

