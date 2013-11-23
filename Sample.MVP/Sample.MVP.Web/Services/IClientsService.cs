using System.Collections.Generic;
using Sample.MVP.Web.Models;

namespace Sample.MVP.Web.Services
{
    public interface IClientsService
    {
        List<Client> GetAll();
    }
}