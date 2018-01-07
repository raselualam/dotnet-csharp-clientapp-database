using DataService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataService.Mock
{
    public class ClientMockDataService : IClientDataService
    {
        //Field
        private List<Client> _mock;

        //Constructor
        public ClientMockDataService()
        {
            _mock = new List<Client>()
            {
                new Client {Id=1, Address= "123 Main Street", BirthDate = new DateTime(2000, 03, 24), FirstName ="Erik", LastName="Zambrand"},
                new Client {Id=2, Address= "223 Main Street", BirthDate = new DateTime(2001, 03, 24), FirstName ="Erik1", LastName="Zambrand1"},
                new Client {Id=3, Address= "323 Main Street", BirthDate = new DateTime(2002, 03, 24), FirstName ="Erik2", LastName="Zambrand2"},
                new Client {Id=4, Address= "423 Main Street", BirthDate = new DateTime(2003, 03, 24), FirstName ="Erik3", LastName="Zambrand3"},
                new Client {Id=5, Address= "523 Main Street", BirthDate = new DateTime(2004, 03, 24), FirstName ="Erik4", LastName="Zambrand4"},
            };
        }

        public bool CreateClient(Client newClient)
        {
            _mock.Add(newClient);
            return true;
        }

        public bool DeleteClient(int id)
        {
            var clientToBeDeleted = GetSingleClient(id);
            _mock.Remove(clientToBeDeleted);
            return true;
        }

        public List<Client> GetAllClients()
        {
            return _mock;
        }

        public Client GetSingleClient(int id)
        {
            return _mock.Single(client => client.Id == id);
        }

        public bool UpdateClient(Client updatedClient)
        {
            var oldClient = GetSingleClient(updatedClient.Id);

            _mock.Remove(oldClient);
            _mock.Add(updatedClient);

            return true; 
        }
    }
}
