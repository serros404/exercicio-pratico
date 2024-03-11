namespace ExercicioPratico
    {
    internal class Carro
        {

        public string? Modelo;
        public string? Montadora;
        public string? Marca;
        private int ano;
        public int Ano { 
            get { return ano; }
            set
                {
                if (ano < 2000)
                    value = 2000;
                else if (ano > 2022)
                    value = 2022;
                else
                    ano = value;
                }
            }
        public int Potencia;
        public static double ValorIpva;

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

        // Ao utilizar esse construtor, os valores atribuídos a Marca, Ano e Potência serão os valores padrões
        // do compilador
        public Carro(string? modelo, string? montadora)
            {
            Modelo = modelo;
            Montadora = montadora;
            }

        // Método VelocidadeMáxima que retorna um valor ao método chamador com o
        // valor do tipo definido pelo método (double)
        public double VelocidadeMaxima(int potencia)
            {
            return potencia * 1.75;
            }


        public int AumentarPotencia(int potencia)
            {
           potencia += 3;
            return potencia;
            }

        public int AumentarPotencia(ref int potencia)
            {
            potencia += 5;
            return potencia;
            }

        public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
            {
            potencia += 7;
            velocidade = potencia * 1.75;
            return potencia;

            }

        public void ExibirInfo(string? Modelo, string? Montadora, string? Marca, int Potencia, int Ano = 2022)
            {
            Console.WriteLine(Modelo);
            Console.WriteLine(Montadora);
            Console.WriteLine(Marca);
            Console.WriteLine(Potencia);
            Console.WriteLine(Ano);
            }

        public static void ObterValorIpva()
            {
            ValorIpva = 4;
            }


        }


}
