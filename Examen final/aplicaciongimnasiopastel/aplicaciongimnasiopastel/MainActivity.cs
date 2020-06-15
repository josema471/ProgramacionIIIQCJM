using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace aplicaciongimnasiopastel
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


            gimnasio gym = gimnasio.getinstance();
            EditText precio = FindViewById<EditText>(Resource.Id.editText1);
            EditText nombre = FindViewById<EditText>(Resource.Id.editText2);
            RadioGroup RGsexo = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            EditText edad = FindViewById<EditText>(Resource.Id.editText3);
            EditText peso = FindViewById<EditText>(Resource.Id.editText4);
            EditText altura = FindViewById<EditText>(Resource.Id.editText5);
            Button entrar = FindViewById<Button>(Resource.Id.button1);
            Button historial = FindViewById<Button>(Resource.Id.button2);

            string Precio = precio.Text;
            string Edad = edad.Text;
            string Peso = peso.Text;
            string Altura = altura.Text;
        

            entrar.Click += (sender, e) =>
            {
                int seleccionadoSexoID = RGsexo.CheckedRadioButtonId;
                RadioButton seleccionadoSexo = FindViewById<RadioButton>(seleccionadoSexoID);
                Sexo sexo;
                string strTipo = seleccionadoSexo.Text;
                Enum.TryParse(strTipo, out sexo);

                atleta a = new atleta(Precio, nombre.Text, sexo, Edad, Peso, Altura);
                gym.Insertaratleta(a);
            
            };
            historial.Click += (sender, e) =>
            {

                var histo = new Intent(this, typeof(ActividadHistorial));
                StartActivity(histo);


            };







        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}