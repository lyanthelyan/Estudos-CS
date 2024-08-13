using System;

namespace QuartosAlugados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Quartos[] rooms = new Quartos[10 + 1];

            Console.Write("How many rooms will be rented: ");
            int numberOfRooms = int.Parse(Console.ReadLine());

            if (numberOfRooms > 10)
            {
                Console.WriteLine("Number of rooms more than what we have!");
                return;
            }

            for (int i = 0; i < numberOfRooms; i++)
            {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                Thread.Sleep(1000);
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Thread.Sleep(1000);
                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());
                if (roomNumber > 10)
                {
                    Console.WriteLine("Number of rooms more than what we have!");
                    return;
                }


                // Criar uma instância de Quartos com o número do quarto, Quando o usuário insere o número do quarto, ele geralmente pensa em números começando do 1. No entanto, o array rooms está indexado a partir de zero. Portanto, ao usar roomNumber - 1, estamos ajustando o número do quarto para corresponder ao índice correto no array rooms.
                rooms[roomNumber] = new Quartos(name, email, roomNumber);

                /*rooms[0] = null
                rooms[1] = { Name = "Alice", Email = "alice@example.com", Room = 2 }
                rooms[2] = null
                rooms[3] = null
                rooms[4] = { Name = "Bob", Email = "bob@example.com", Room = 5 }
                rooms[5] = null
                rooms[6] = null
                rooms[7] = null
                rooms[8] = { Name = "Carol", Email = "carol@example.com", Room = 8 }
                rooms[9] = null*/

                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10 + 1; i++)
            {// (Neste trecho, percorremos o array rooms de 0 a 9, que representa os números dos quartos de 1 a 10. Para cada elemento do array, verificamos se ele é diferente de null, o que significa que um quarto foi alugado nessa posição. Se não for null, imprimimos as informações do quarto (nome do locatário e e-mail) juntamente com o número do quarto.ortanto, como estamos percorrendo o array na ordem natural, do menor para o maior índice, e cada índice do array representa o número do quarto, os quartos alugados são impressos na ordem correta, do menor para o maior número de quarto.)
                if (rooms[i] != null)
                {
                    Console.WriteLine($"Room {rooms[i].Room}: {rooms[i].Name}, {rooms[i].Email}");
                }
            }
        }
    }
}