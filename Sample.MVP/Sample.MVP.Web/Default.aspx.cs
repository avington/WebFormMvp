using System;
using System.Collections.Generic;
using Sample.MVP.Web.IViews;
using Sample.MVP.Web.Models;
using Sample.MVP.Web.MVP;
using Sample.MVP.Web.Presenter;

namespace Sample.MVP.Web
{
    public partial class _Default : MvpBasePage<ClientsPresenter, IClientsView>, IClientsView
    {
        private List<Client> _clients;

        public string ContentTitle { get; set; }

        public List<Client> Clients
        {
            set
            {
                clientsRepeater.DataSource = value;
                clientsRepeater.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Presenter.OnViewInitialized();
            if (Page.IsCallback == false)
                Presenter.OnViewLoaded();
        }
    }
}