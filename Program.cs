namespace tipo_nulo;

class Program
{
    static void Main(string[] args)
    {
        MetodoHasValue();
        MetodoGetValueOrDefault();
        MetodoValue();

    }


    static void MetodoValue()
    {
        Console.WriteLine("Metodo Value");
        int? x = null;
        x = 100;
        int y = 0;
        try
        {
            y = x.Value;
            Console.WriteLine("Ahora Y´ tiene valor de :" + y);
        }
        catch
        {
            Console.WriteLine("Operacion No Valida");
        }
      

    }






    static void MetodoGetValueOrDefault()
    {
        Console.WriteLine("Get value Or Default");
        int? i = null;
        i = 10; 
        Boolean? b = null;
        b = true;
        Console.WriteLine(i.GetValueOrDefault() );
        Console.WriteLine(b.GetValueOrDefault() );


    }





    static void MetodoHasValue()
    {
        Console.WriteLine("Has Value");
        int? i = null;
      //  i = 10;
        if (i.HasValue)
            Console.WriteLine("Tiene valor : " + i.Value);
        else
            Console.WriteLine("Tiene valor NULL");

    }
}

