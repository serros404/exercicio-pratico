using ExercicioPratico;
using System.Collections.Concurrent;

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
Carro ford2 = new("SUV", "Ford");

// Valor da Potência aumentado por valor, mas não alterado
chevrolet.Exibir();
Console.Write("Aumentando a Potência (por valor : + 3 CV : ");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);
Console.Write("-> " + novaPotenciaChevrolet);
Console.WriteLine("\nO valor do campo Potência não foi alterado: " + chevrolet.Potencia + "\n");

// Valor da Potência aumentado e alterado por referência
ford.Exibir();
Console.Write("Aumentando a Potencia (por referência : +5CV) : ");
var novaPotenciaFord = ford.AumentarPotencia(ref ford.Potencia);
Console.Write("-> " + novaPotenciaFord);
Console.WriteLine("\nO valor do campo Potencia foi alterado : " + ford.Potencia + "\n");
Console.ReadKey();