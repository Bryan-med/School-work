using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace orientado_objetos
{
	public class Persona
	{
		
		
			//propiedades - atributos de persona (descripcion)
			string Nombre;
			string Color_ojos;
			string Color_pelo;
			float Altura;

            //métodos que realiza una persona (acciones)

			public void Caminar(int velocidad)
			{
				Console.WriteLine("Camina a :" + velocidad + "Km por hora");

			}

            public void Hablar()
			{
				Console.WriteLine("esta hablando");
			}

            //getter  Getter(obtener informacion)
            //setter Setter(modificar info de una propiedad)


            // ---------------getter---------------------------
            public string GetNombre()
			{
				return Nombre;
			}

            public string GetColorOjos()
            {
                return Color_ojos;
            }
            public string GetColorPelo()
            {
                return Color_pelo;
            }
			public float GetAlutra()
			{
				return Altura;
			}
			//---------------------setter-------------------------
			public void SetNombre(string n)
			{
				Nombre = n;
			}
            public void SetColorOjos(string Co)
            {
                Color_ojos = Co;
            }
            public void SetColorPelo(string Cp)
            {
                Color_pelo = Cp;
            }
            public void SetAltura(float A)
            {
                Altura = A;
            }
        

    }
}

