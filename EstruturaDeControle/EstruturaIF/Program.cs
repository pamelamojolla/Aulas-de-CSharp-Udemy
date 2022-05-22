// Estrutura IF


bool bomComportamento = false;
string entrada;

Console.WriteLine("Digite a nota do aluno: ");
entrada = Console.ReadLine();
double.TryParse(entrada, out double nota);


Console.WriteLine("Possui bom comportamento (S/N):");
entrada = Console.ReadLine();

if(entrada == "S" || entrada == "s")   // entre parente se chama expressão

{// setenção é o código inserido aqui
    bomComportamento = true;
}

if(nota >= 9.0 && bomComportamento)
{
    Console.WriteLine("Quadro de honra!");
}