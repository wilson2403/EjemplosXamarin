using System;
namespace HolaMoviles
{
	public abstract class Persona : IContrato
	{
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}


		public virtual void Firmar()
		{
			
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
			Nombre = "Gustavo";
		}
	}}
