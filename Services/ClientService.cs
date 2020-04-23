using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TropsmartAPI.Domain.Models;
using TropsmartAPI.Domain.Services;

namespace TropsmartAPI.Services
{
    public class ClientService : IClientService
    {

        private List<Client> clients;

        public ClientService()
        {
            clients = new List<Client>();
        }

        public List<Client> GetClients()
        {
            return clients;
        }

        public Client AddClient(Client client)
        {
            clients.Add(client);
            return client;
        }

        public Client UpdateClient(int id, Client client)
        {
            for (var index = clients.Count - 1; index >= 0; index--)
            {
                if (clients[index].id == id)
                {
                    clients[index] = client;
                }
            }
            return client;
        }

        public int DeleteClient(int id)
        {
            for (var index = clients.Count - 1; index >= 0; index--)
            {
                if (clients[index].id == id)
                {
                    clients.RemoveAt(index);
                }
            }

            return id;
        }


    }
}
