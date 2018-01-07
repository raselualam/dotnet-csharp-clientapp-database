using ServiceLayer.Client;
using System;

namespace ConsoleUI
{
    class Program
    {
        static ClientService cs = new ClientService();
        static void Main(string[] args)
        {
            bool keepAsking = true;
           
            do
            {
                string input = Console.ReadLine();
                switch(input)
                 {
                    case "client --all":
                        GetAllClients();
                        break;

                    case "client --single":
                        GetSingleClient();
                        break;

                    case "client --create":
                        CreateClient();
                        break;

                    case "client --delete":
                        DeleteClient();
                        break;

                    case "client --update":
                        UpdateClient();
                        break;

                    case "exit":
                        keepAsking = false;
                        break;
                 }

            } while (keepAsking);
        }

        private static void DeleteClient()
        {
            Console.WriteLine("Provide the ID of the user you want to delete");

            int idInput = int.Parse(Console.ReadLine());

            if(cs.DeleteClient(idInput))
            {
                Console.WriteLine("Client deleted");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private static void UpdateClient()
        {
            //Not Completed yet, need to work on it
        }

        private static void CreateClient()
        {
            var newClient = new DataService.Client();

            Console.WriteLine("What's the client name:");
            newClient.FirstName = Console.ReadLine();

            Console.WriteLine("What's the client last name:");
            newClient.LastName = Console.ReadLine();

            Console.WriteLine("What's the client birthday (mm/dd/yyyy):");
            newClient.BirthDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("What's the client address:");
            newClient.Address = Console.ReadLine();

            if(cs.CreateClient(newClient))
            {
                Console.WriteLine("Client added to the Database");
            }
            else
            {
                Console.WriteLine("Sorry, client was not saved. Try again");
            }
        }

        private static void GetSingleClient()
        {
            Console.WriteLine("Provide with the Client unique Id");

            int inputID = int.Parse(Console.ReadLine());

            try
            {
                var singleClient = cs.GetSingleClient(inputID);
                Console.WriteLine($"{singleClient.FirstName} {singleClient.LastName} {singleClient.BirthDate}");
            }
            catch
            {
                Console.WriteLine("The ID provided doesn't match the records");
            }
        }

        private static void GetAllClients()
        {
            var clients = cs.GetAllClients();
            foreach(var c in clients)
            {
                Console.WriteLine($"{c.Id} {c.FirstName} {c.BirthDate}");
            }
        }
    }
}
