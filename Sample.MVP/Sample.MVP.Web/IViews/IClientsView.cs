using System.Collections.Generic;
using Sample.MVP.Web.Models;
using Sample.MVP.Web.MVP;

namespace Sample.MVP.Web.IViews
{
    public interface IClientsView : IView
    {
        string ContentTitle { get; set; }
        List<Client> Clients {  set; }
    }
}