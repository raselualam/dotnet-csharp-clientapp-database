using System.Collections.Generic;

namespace DataService.Interface
{
    public interface IClientDataService
    {
        //Single Client
        Client GetSingleClient(int id);

        //All Clients
        List<Client> GetAllClients();

        //Create
        bool CreateClient(Client newClient);

        //Update
        bool UpdateClient(Client updatedClient);

        //Delete
        bool DeleteClient(int id);

    }
}
