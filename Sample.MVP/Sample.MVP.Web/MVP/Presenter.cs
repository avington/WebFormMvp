namespace Sample.MVP.Web.MVP
{
    public abstract class Presenter<TView>
    {
        public TView View { get; set; }

        public abstract void OnViewInitialized();

        public abstract void OnViewLoaded();

    }
}