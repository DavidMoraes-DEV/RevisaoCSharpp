using System;
using System.Globalization; // Necessário para utilizar o . no lugar da vírgula

namespace RevisaoDeConceitosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // REVISÃO: TIPOS DE VARIÁVEIS: 

            Console.WriteLine("Hello World!");

            bool completo = false;
            char generoo = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;

            Console.WriteLine(completo);
            Console.WriteLine(generoo);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------");

            //REVIÇÃO SAÍDA DE DADOS:

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); //.ToString("F2") = Delimitar a quatidade de números após a vírgula.
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // CultureInfo.InvariantCulture -> Utiliza o '.' no lugar da ','

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------");

            //Utilizando PlaceHolders para montar uma frase
            Console.WriteLine("{0} tem {1} anos e possui R$: {2:F2} de saldo.", nome, idade, saldo);

            //Utilizando a Interpolação para montar uma frase
            Console.WriteLine($"{nome} tem {idade} anos e possui R$: {saldo:F2} de saldo");

            //Utilizando a Concatenação de Strings
            Console.WriteLine(nome + " tem " + idade + " anos e possui R$: " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " de saldo");

            /*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            EXERCÍCIO DE FIXAÇÃO: Em um novo programa, inicie as seguintes variáveis:

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Em seguida, usando os valores das variáveis, produza a seguinte saída na tela do console:

            Produtos:
            Computador, cujo preço é R$ 2100,00
            Mesa de escritório, cujo preço é R$ 650,50

            Registro: 30 anos de idade, código 5290 e gênero: M

            Medida com oito casas decimais: 53,23456700
            Arredondado (três casas decimais): 53,235
            Separador decimal invariant culture: 53.235
             */

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade2 = 30;
            int codigo = 5290;
            char genero2 = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("\n\nProdutos:");
            Console.WriteLine($"{produto1}, cujo preço é R$: {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R$: {preco2:F2}");
            Console.WriteLine($"\nRegistro: {idade2} anos de idade, código {codigo} e gênero: {genero2}\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

            /*REVISÃO: OPERADORES DE ATRIBUIÇÃO:
             
            EXEMPLOS:

            a = 10; -> a RECEBE 10
            a += 2; -> a RECEBE a + 2
            a -= 2; -> a RECEBE a - 2
            a *= 2; -> a RECEBE a * 2
            a /= 2; -> a RECEBE a / 2
            a %= 3; -> a RECEBE a % 3
            */
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------");

            /*REVISÃO: CONVERSÃO IMPLÍCITA E CASTING:
             
            - Conversão implícita entre tipos
            - Casting: conversão explícita entre tipos COMPATÍVEIS
             */

            //CONVERSÃO IMPLÍCITA: Nesse caso é plausível a conversão implícita pois o menor cabe dentro do maior então não tem necessidade de fazer um CASTING igual no exemplo abaixo
            float a1 = 4.5f; //Tem 4 bits
            double b1 = a1;  //Tem 8 bits

            //CONVERSÃO EXPLÍCITA E CASTING:
            double a; //Tem 8 bits
            float b;  //Tem 4 bits

            a = 5.1;
            b = (float)a; //Se não aplicar a CONVERSÃO ou CASTING não será aceito pois uma variável double é maior que uma variavel float causando perda de dados

            //REVISÃO: ENTRADA DE DADOS

            /* Checklist: (PARTE I)
            - 1) Ler um texto até a quebra de linha e armazenar em uma variável
            - 2) Ler três palavras, uma em cada linha, armazenando cada uma em uma variável
            - 3) Ler três palavras na mesma linha, separadas por espaço, armazenando cada uma em uma variável            
            */

            
            //1):
            Console.WriteLine("\n\nDigite Bom dia! e pressione Enter:");
            string frase = Console.ReadLine();
            Console.WriteLine($"Você digitou: {frase}");

            //2):
            Console.WriteLine("\n\nDigite agora 3 cores e pressione Enter no final de cada uma:");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine($"Você digitou: {x}, {y}, {z}.");

            //3):
            Console.WriteLine("\n\nDigite agora 3 frutas na mesma linha: ");
            string[] frutas = Console.ReadLine().Split(' ');

            Console.WriteLine($"Você Digitou as seguintes frutas:\n {frutas[0]}\n {frutas[1]}\n {frutas[2]}.");

            /*
             Checklist: (PARTE II)
            4) Ler um número inteiro
            5) Ler um Caractere
            6) Ler um número double
            7) Ler um nome (única palavra), sexo (caracter F ou M), idade (inteiro) e altura (double) na mesma linha, armazenando-os em quatro variáveis com os devidos tipos
             */

            //4):
            Console.WriteLine("\nDigite um número inteiro: ");
            int n7 = int.Parse(Console.ReadLine()); //(Comando ReadLine le apenas como string então tem que converter para o formato correto utilizando o .parse)
            Console.WriteLine($"Você Digitou: {n7}");

            //5):
            Console.WriteLine("\nDigite um Caracter: ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine($"Você Digitou: {ch}");

            //6):
            Console.WriteLine("\nDigite um número com casa decimal: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você Digitou: " + n.ToString("F2", CultureInfo.InvariantCulture));

            //7):
            Console.WriteLine("\nDigite seu nome, sexo, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade3 = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Seus dados são: Nome: {nome2}, Sexo: {sexo}, tem {idade3} anos e possui " + altura.ToString("F2", CultureInfo.InvariantCulture) + " de altura");
            
        }
    }
}
