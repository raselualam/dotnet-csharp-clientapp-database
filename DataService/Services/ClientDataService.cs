using DataService.Interface;
using System.Collections.Generic;
using System.Linq;

namespace DataService.Services
{
    public class ClientDataService : IClientDataService
    {
        private DatabaseToClassesDataContext _db;

        public ClientDataService()
        {
            _db = new DatabaseToClassesDataContext();
        }

        public bool CreateClient(Client newClient)
        {
            try
            {
                _db.Clients.InsertOnSubmit(newClient);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteClient(int id)
        {
            try
            {
                var clientToBeDeleted = GetSingleClient(id);
                _db.Clients.DeleteOnSubmit(clientToBeDeleted);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Client> GetAllClients()
        {
            var clients = _db.Clients;
            return clients.ToList();
        }

        public Client GetSingleClient(int id)
        {
            var client = _db.Clients
                         .Where(row => row.Id == id)
                         .Single();
            return client;
        }

        public bool UpdateClient(Client updatedClient)
        {
            try
            {
                var oldClient = GetSingleClient(updatedClient.Id);
                oldClient.Address = updatedClient.Address;
                oldClient.BirthDate = updatedClient.BirthDate;
                oldClient.FirstName = updatedClient.FirstName;
                oldClient.LastName = updatedClient.LastName;
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
