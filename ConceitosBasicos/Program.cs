using ConceitosBasicos;
using System;

int num1 = 20;
int num2 = 11;
int result;

Somador soma; //ctrl ctrl dps
soma = new Somador();

//Conversor conversor = new Conversor();

result = soma.Soma(num1, num2);

Console.WriteLine($"A soma dos números {num1} + {num2} é {result}");
//Console.WriteLine(num1 "+" num2 "é" result);
double metros = 1.76;
Console.WriteLine("A medida {0} metros corresponde a {1}", metros, Conversor.MetrosMilimetros(1.76));
//Console.WriteLine($"A medida {Conversor.MetrosMilimetros} em metros corresponde a {Conversor.MetrosMilimetros(1.76)}");