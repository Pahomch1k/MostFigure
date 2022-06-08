using System;

namespace Dz_9._2_MostFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Color color;

            color = new Red(new Circle());
            client.ClientCode(color);

            Console.WriteLine();

            color = new Blue(new Square());
            client.ClientCode(color);

            Console.WriteLine();

            color = new Color(new Square());
            client.ClientCode(color);
        }
    }
}
