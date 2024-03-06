namespace ExercicioPratico
    {
    internal class Carro
        {

        public string? Modelo;
        public string? Montadora;
        public string? Marca;
        public int Ano;
        public int Potencia;

        // Construtor dos campos acima
        public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
            {
            Modelo = modelo;
            Montadora = montadora;
            Marca = marca;
            Ano = ano;
            Potencia = potencia;
            }


        // Método Exibir para exibir as informações dos carros

        public void Exibir()
            {
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Montadora: {Montadora}");
            Console.WriteLine($"Marca: {this.Marca}");
            Console.WriteLine($"Ano: {this.Ano}");
            Console.WriteLine($"Potência: {this.Potencia} KM/H");
            Acelerar();

        }


        // Método Acelerar
        public void Acelerar()
            {
            Console.WriteLine($"Acelerando o meu {this.Marca}");
            }
        }
    }
