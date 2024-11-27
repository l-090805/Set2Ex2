namespace Set2Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente din secventa: ");
            int n = int.Parse(Console.ReadLine());

            int contorNeg = 0;
            int contorPos = 0;
            int contorNull = 0;

            Console.Write($"Introduceti cele {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                int numere = int.Parse(Console.ReadLine());

                if( numere > 0)
                {
                    contorPos++;
                }

                if(numere < 0)
                {
                    contorNeg++;
                }

                if(numere == 0)
                {
                    contorNull++;
                }

            }
            Console.WriteLine($"In secventa exista {contorPos} numere pozitive, {contorNull} numar/numere egale cu 0 si {contorNeg} numere negative");
        }
    }
}
