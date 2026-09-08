namespace orientado_objetos;

class Program
{
    static void Main(string[] args)
    {
        //crear un nuevo objeto persona y utilizar sus metodos

        Persona humano = new Persona();//constructor default

        humano.SetNombre("bryan");
        humano.SetColorPelo("Negro");
        humano.SetColorOjos("cafe");
        humano.SetAltura(1.7f);

        humano.Hablar();
        humano.Caminar(10);

        Console.WriteLine("la perosna con nombre:" +humano.GetNombre());
        Console.WriteLine("Tiene color de pelo:" + humano.GetColorPelo());
        Console.WriteLine("Tiene color de ojos :" + humano.GetColorOjos());
        Console.WriteLine("tiene una altura de :" + humano.GetAlutra());

        //persona con constructor 

        PersonaConstructor humano2 = new PersonaConstructor(  "Ivana","cafe","negro",1.65f);
        Console.WriteLine( "\nla perosna con nombre:" + humano2.GetNombre());
        Console.WriteLine("Tiene color de pelo:" + humano2.GetColorPelo());
        Console.WriteLine("Tiene color de ojos :" + humano2.GetColorOjos());
        Console.WriteLine("tiene una altura de :" + humano2.GetAlutra());

        humano2.Caminar(5);
        humano2.Hablar();

        hijoConstru humano3 = new hijoConstru("Gaby", "verdes", "cafe", 1.0f, "fran","erick");
        Console.WriteLine("\nla perosna con nombre:" + humano3.GetNombre());
        Console.WriteLine("Tiene color de pelo:" + humano3.GetColorPelo());
        Console.WriteLine("Tiene color de ojos :" + humano3.GetColorOjos());
        Console.WriteLine("tiene una altura de :" + humano3.GetAlutra());
        Console.WriteLine("su madre se llama :" + humano3.Getmadre());
        Console.WriteLine("su padre se llama :" + humano3.Getpadre());
        humano3.Llora();
        humano3.Caminar(1);
        humano3.Hablar();


    }
}

