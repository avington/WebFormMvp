using System.Collections.Generic;
using Sample.MVP.Web.IViews;
using Sample.MVP.Web.Models;
using Sample.MVP.Web.MVP;
using Sample.MVP.Web.Services;

namespace Sample.MVP.Web.Presenter
{
    public class ClientsPresenter : Presenter<IClientsView>
    {
        private readonly IClientsService _clientsService;

        public ClientsPresenter(IClientsService clientsService)
        {
            _clientsService = clientsService;
        }

        public override void OnViewInitialized()
        {
            View.ContentTitle = "Client List";
            List<Client> clients = _clientsService.GetAll();
            View.Clients = clients;
        }

        public override void OnViewLoaded()
        {
        }
    }
}