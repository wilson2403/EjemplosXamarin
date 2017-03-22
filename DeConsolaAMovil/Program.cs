using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DeConsolaAMovil
{
    class Program
    {
        public abstract class Persona : IContrato
        {
            private string _nombre;

            public string Nombre {
                get { return _nombre; }

                protected set { _nombre = value; }
            }


            public virtual void Firmar()
            {
                Console.WriteLine("nombre");
                Console.WriteLine("apellido");
            }
        }


        public interface IContrato
        {
            void Firmar();
        }


        public class Contratista : Persona
        {
            public event EventHandler Contratado;

            public void Contratar()
            {
                Contratado?.Invoke(this, new EventArgs());
            }
        }
        
        public class Abogado : Persona
        {
            public override void Firmar()
            {
                base.Firmar();

                Console.WriteLine("telefono");

                Nombre = "Gustavo";
            }
        }

        public static void Ejecutar(Action unaAccion)
        {

        }

        static void Main(string[] args)
        {
            var a = 1;
            var b = "abc";
            var primerNombre = "esteban";
            string nombreCompleto = $"{primerNombre}";

            object c = null;

            Persona abogado = new Abogado();
            // abogado.Firmar();

            var pablo = new Contratista();
            pablo.Contratado += (s, e) => {

                abogado.Firmar();
                
            };

            Action accion1 = () => {
                Console.WriteLine("escriba 1");
            };
            
            Action accion2 = () => {
                Console.WriteLine("escriba 2");
            };

            var arreglo = new [] { 1,2,3,4,5 };


            Func<int, bool> filtro = (int parametro1) => parametro1 > 3;

            var resultado = arreglo.Average();

            if (arreglo.Any())
            {

            }

            if (c == null)
            {
                Console.WriteLine("nada");

            }
            Console.WriteLine(c ?? "nada");

            //pablo.Contratar();

            Console.ReadKey();
        }
    }
}
