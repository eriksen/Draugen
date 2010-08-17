using Draugen.Data;
using Draugen.Data.Repositories;
using Microsoft.Practices.Unity;

namespace Draugen.Web
{
    public class DraugenUnityContainer : UnityContainer
    {
        public DraugenUnityContainer()
        {
            this.RegisterInstance(this);
            this.RegisterInstance(new DraugenConfiguration().GetSessionFactory());
            this.RegisterType<IRepository<Fangst>, Repository<Fangst>>();
        }
    }
}