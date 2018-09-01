using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Project1
{
    [Activity(Label = "Project", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            EditText editText1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText editText2 = FindViewById<EditText>(Resource.Id.editText2);
            EditText editText3 = FindViewById<EditText>(Resource.Id.editText3);
            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate
            {
                int a = int.Parse(editText1.Text);

                int b = int.Parse(editText2.Text);
                int c = int.Parse(editText3.Text);
                int d = 11*a + 14*b + 12*c;
                string e = d.ToString();
                var intent = new Intent(this, typeof(Activity1));
                intent.PutExtra("d",e);
                StartActivity(intent);

            };
        }
    }
}

