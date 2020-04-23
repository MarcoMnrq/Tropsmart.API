using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TropsmartAPI.Domain.Models;

namespace TropsmartAPI.Domain.Services
{
    public interface IClientService
    {
        public List<Client> GetClients();
        public Client AddClient(Client client);
        public Client UpdateClient(int id, Client client);
        public int DeleteClient(int id);
    }
}
