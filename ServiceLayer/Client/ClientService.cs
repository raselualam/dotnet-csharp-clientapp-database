using System.Collections.Generic;
using DataService.Interface;
using DataService.Services;

namespace ServiceLayer.Client
{
    public class ClientService
    {
        //Field
        IClientDataService _dataLayer; // DataService project offers

        //Constructor
        public ClientService()
        {
             _dataLayer = new ClientDataService();               //Database

            // _dataLayer = new ClientMockDataService();         //MockData
        }

        
        public bool CreateClient(DataService.Client newClient)
        {
          return  _dataLayer.CreateClient(newClient);
        }

        public bool DeleteClient(int id)
        {
            return _dataLayer.DeleteClient(id);
        }

        public bool UpdateClient(DataService.Client updatedClient)
        {
            return _dataLayer.UpdateClient(updatedClient);
        }

        //Get Single
        public DataService.Client GetSingleClient(int id)
        {
            return _dataLayer.GetSingleClient(id);
        }

        //Get All
        public List<DataService.Client> GetAllClients()
        {
            return _dataLayer.GetAllClients();
        }
    }
}
