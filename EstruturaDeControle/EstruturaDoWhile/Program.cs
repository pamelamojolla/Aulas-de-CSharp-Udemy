﻿// Estrutura DoWhile

string entrada;

do
{
    Console.WriteLine("Qual o seu nome?");
    entrada = Console.ReadLine();

    Console.WriteLine("Seja bem-vindo {0}", entrada);
    Console.WriteLine("Deseja continuar? (S/N)");
    entrada= Console.ReadLine();
}while(entrada.ToLower() == "s");//ToLower serve para não ter distincão de letra Maiuscula e minuscula na entrada de dados
