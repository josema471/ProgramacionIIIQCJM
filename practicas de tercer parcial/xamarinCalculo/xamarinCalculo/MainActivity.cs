using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace xamarinCalculo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);



            RadioGroup operaciones = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            EditText a = FindViewById<EditText>(Resource.Id.editTextA);
            EditText b = FindViewById<EditText>(Resource.Id.editTextB);
            Button BotonCalcular = FindViewById<Button>(Resource.Id.button1);
            TextView resultado = FindViewById<TextView>(Resource.Id.txtResultado);



            BotonCalcular.Click += (sender, e) => {



                int seleccionadoOperacionID = operaciones.CheckedRadioButtonId;
                RadioButton seleccionadoTipo = FindViewById<RadioButton>(seleccionadoOperacionID);












            
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}