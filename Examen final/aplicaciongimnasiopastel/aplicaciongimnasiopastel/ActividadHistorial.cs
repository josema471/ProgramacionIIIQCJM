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

namespace aplicaciongimnasiopastel
{
    [Activity(Label = "ActividadHistorial")]
    public class ActividadHistorial : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Historial);
            // Create your application here
            gimnasio gym = gimnasio.getinstance();
            TextView salida = FindViewById<TextView>(Resource.Id.textsalida);
            salida.Text = gym.Mostraratletas();
        }
    }
}