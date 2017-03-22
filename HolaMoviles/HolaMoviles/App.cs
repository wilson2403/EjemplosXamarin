using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HolaMoviles
{
    public class App : Application
    {
        // stvansolano@outlook.com
        public App()
        {
            var label = new Label()
            {
                Text = "Hola mundo"
                //, TextColor = Color.Red, BackgroundColor = Color.Black
            };

            var boton = new Button() {
                Text = "Haga click"
            };
            var texto = new Entry() { Placeholder = "Su nombre aqui" };
            var content = new ContentPage
            {
                Title = "HolaMoviles",
                Content = new StackLayout()
                {
                    Orientation = StackOrientation.Vertical,
                    Children = { label, texto, boton }
                }
            };

            boton.Clicked += async (s, e) =>
            {
                var mensaje = "Hola " + texto.Text;
                await content.DisplayAlert("Mensaje", mensaje, "Cancelar");

                label.Text = mensaje;
            };
            MainPage = content;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }
    }
}
