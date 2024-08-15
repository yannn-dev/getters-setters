namespace getters_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400); //Utilizando o construtor de classe setando a velocidade do carro

            car.Speed = 1000000; //Tentando ultrapassar a velocidade limite

            Console.WriteLine(car.Speed); //Exibe a velocidade 500
            Console.ReadKey();
        }
    }


    class Car //Cria a classe car
    {
        private int speed; //Define a variável "speed" como privada

        public Car(int speed) //Construindo a classe publica com requisito da variável speed
        {
            Speed = speed; //Definindo a propriedade Speed, que recebe o valor de speed
        }
        public int Speed //Definindo a propriedade Speed como uma variável pública
        {
            get { return speed; } //Lê e retorna o valor de speed original
            set
            {
                if(value > 500) //Se o valor for maior que 500, automaticamente redefine para 500
                {
                    speed = 500;
                } else
                {
                    speed = value; //Passa o valor para a variável speed
                }
            }
        }
    }
}