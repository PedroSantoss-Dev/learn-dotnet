namespace variaveis_constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variáveis podem serem alteradas enquanto as constantes não podem sofrer alterações
            // exemplo de variável
            string nome;
            nome = "Pedro";
            int idade;
            idade = 25;
            bool feliz = true;
            Console.WriteLine($"Nome:{nome} \n Idade: {idade} \n Feliz: {feliz}  ");

            // exemplo de constante 
            const int idade2 = 28;
            Console.WriteLine(idade2);
            Console.ReadKey();
        }
    }
}