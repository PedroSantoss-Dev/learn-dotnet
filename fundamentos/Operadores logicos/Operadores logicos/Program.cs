namespace Operadores_logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool teste = true;
            int A = 6; 
            

            if(A> 3 ||  teste)
            {
                Console.WriteLine("Passou");
            }
            else
            {
                Console.WriteLine("Falhou");

            }

            if (A > 3 && teste)
            {
                Console.WriteLine("Passou");
            }
            else
            {
                Console.WriteLine("Falhou");

            }

            if (!teste)
            {
                Console.WriteLine("Passou");
            }
            else
            {
                Console.WriteLine("Falhou");

            }
            Console.ReadKey();    
        }   
    }
}