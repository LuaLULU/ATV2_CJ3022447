namespace ATV2_CJ3022447
{
    internal class Program
    {
        static void Main(string[] args)
        {//projeto 1 
            float valor, salario, novo_salario, soma;




            Console.WriteLine("Qual é o seu salário?");
            salario = float.Parse(Console.ReadLine());
            valor = (salario / 100) * 25;
            novo_salario = valor + salario;
            Console.WriteLine("seu novo salario é: {0}", novo_salario);

            //projeto 2
            int n, n1, n2, resul;
            Console.WriteLine("Digite um numero.");
            n = int.Parse(Console.ReadLine());
            n1 = n * 3 + 1;
            n2 = n * 2 - 1;
            resul = n1 + n2;
            Console.WriteLine("a soma dos valores são: {0}", resul);

            //projeto 3 
            float v, v2;
            Console.WriteLine("o valor inicial dos seus investimentos é de R$ 1000,00");

            v = 1000;
            v2 = (v / 100) * 3.4f;
            v = v - v2;
            v2 = (v / 100) * 2.8f;
            v = v + v2;
            v2 = (v / 100) * 14;
            v = v + v2;
            v2 = (v / 100) * 8.5f;
            v = v - v2;

            Console.WriteLine("o valor atual de seus investimentos é de R$ {0}", v); 




        }
    }
}
