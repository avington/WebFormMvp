using System;
using System.Diagnostics;
using System.Web.UI;
using StructureMap;

namespace Sample.MVP.Web.MVP
{
    public abstract class MvpBasePage<TPresenter, TView> : Page where TPresenter : Presenter<TView>
    {

        protected Presenter<TView> Presenter { get; set; }

        protected MvpBasePage()
        {
            if (!(this is TView))
                throw new InvalidOperationException("Must impliment the generic type TView");
            try
            {
                Presenter = ObjectFactory.GetInstance<TPresenter>();
                Presenter.View = (TView)((object)this);
            }
            catch
            {
                Trace.Write(ObjectFactory.WhatDoIHave());
                throw;
            }

            Debug.WriteLine(ObjectFactory.WhatDoIHave());
        }
    }
}