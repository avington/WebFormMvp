using System.Collections.Generic;
using Sample.MVP.Web.Models;

namespace Sample.MVP.Web.Services
{
    public class ClientsService : IClientsService
    {
        public List<Client> GetAll()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientEmail = "GeorgeWashington@president.com",
                    ClientId = 1,
                    ClientName = "George Washington",
                    ContactName = "Paul Revere"
                },
                new Client
                {
                    ClientEmail = "JognAdams@president.com",
                    ClientId = 1,
                    ClientName = "John Adams",
                    ContactName = "Bugs Bunny"
                },
                new Client
                {
                    ClientEmail = "ThomasJefferson@president.com",
                    ClientId = 1,
                    ClientName = "Thomas Jefferson",
                    ContactName = "Ma Bell"
                },
                new Client
                {
                    ClientEmail = "AbeLincoln@president.com",
                    ClientId = 1,
                    ClientName = "Abe Lincoln",
                    ContactName = "Johnny Carson"
                }
            };
        }
    }
}