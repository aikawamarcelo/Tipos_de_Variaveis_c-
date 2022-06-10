using System;

namespace Tipos_de_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //  i = "s";

            var x = 1;

            //  x = "333";


            char t = 'M';


            string t2 = "F"; // string nao aceita ''


            Console.WriteLine(t);
            Console.WriteLine(t2);


            string m = "Marcelo Aikawa";

            var m2 = "Marcelo 2";


            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.WriteLine(m);
            Console.WriteLine(m2);

            var f = 1.5f;

            float f2 = 2.0f;

            Console.WriteLine(f);
            Console.WriteLine(f2);

            var d = 1.5;
            double d2 = 2.0;


            Console.WriteLine(d);
            Console.WriteLine(d2);


            var bo = true;
            var bo2 = false;


            bool bol = true;
            bool bol2 = false;

            Console.WriteLine(bo);
            Console.WriteLine(bo2);
            Console.WriteLine(bol);
            Console.WriteLine(bol2);

            Boolean boolean = bool.Parse("false");
            bool boolean2 = Convert.ToBoolean("false");




            Console.WriteLine(boolean);
            Console.WriteLine(boolean2);

            Animal a = new Animal();
            Leao l = new Leao();

            //l = (Leao)a; // Animal não herda de Leão, Leão que herda de animal 

            a = l;


        }
    }

    public class Animal{
        
    }

    public class Leao : Animal
    {

    }



}
