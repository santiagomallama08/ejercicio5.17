
namespace Ejercicio5_17
{
    class Program
    {
        public static void Main()
        {
            string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] decenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] miles = { "", "M", "MM", "MMM" };


            Console.WriteLine("Ingrese el número que desea transformar a números romanos");

            double numero = Convert.ToDouble(Console.ReadLine());
            Math.Truncate(numero);
            if (numero <= 0 || numero >= 3000)
            {
                Console.WriteLine("Valor no permitido");
                return;
            }

            int m = (int)(numero / 1000);
            int restante = (int)(numero % 1000);
            int с = restante / 100;
            restante = restante % 100;
            int d = restante / 10;
            restante = restante % 10;
            int u = restante;

            Console.WriteLine(miles.ElementAtOrDefault(m) + centenas.ElementAtOrDefault(с) + decenas.ElementAtOrDefault(d) + unidades.ElementAtOrDefault(u));

        }
    }
}