using StructureMap;

namespace Sample.MVP.Web.App_Start
{
    public class StructureMapConfig
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(x => x.AddRegistry(new DefaultRegistry()));
        }
    }
}