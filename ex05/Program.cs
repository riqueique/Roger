// Calculadora que recebe 2 numeros e apresenta + - * /


Console.WriteLine("Escreva o primeiro numero: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine(" Escreva o segundo numero: ");
int numero2 = int.Parse(Console.ReadLine());


Console.Clear();
Console.WriteLine("+ : " + (numero1 + numero2));
Console.WriteLine(" - : " + (numero1 - numero2));
Console.WriteLine("* : " + (numero1 * numero2));

//verifica se o segundo numero é diferente de zero antes de realizar a divisão

if (numero2 != 0)
{
    Console.WriteLine("/ : " + (numero1 / numero2));

}
else
{
    Console.WriteLine("/ : DIVISÃO POR ZERO NÃO É PERMITIDA");
}


Console.WriteLine("==============================");
Console.WriteLine("Os numeros são iguas?" + (numero1 == numero2));
Console.WriteLine(" Numero1 é maior que o Numero2?" + (numero1 > numero2));
Console.WriteLine(" Numero1 é menor que o Numero2?" + (numero1 < numero2));
Console.WriteLine("Numero1 é maior igual Numero2?" + (numero1 >= numero2));
Console.WriteLine("Numero1 é menor igual Numero2?" + (numero1  <= numero2)); 

