using AutoMapper;
using Microsoft.Practices.Unity;
using ShopManager.Repository;


namespace ShopManager.UI
{
    public static class ContainerHelper
    {
        private static IUnityContainer _container;
        static ContainerHelper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfiles());
            });
            _container = new UnityContainer();
            _container.RegisterType<ICustomersRepository, CustomersRepository>(new ContainerControlledLifetimeManager());
            _container.RegisterInstance<IMapper>(config.CreateMapper());
           
        }

        public static IUnityContainer Container
        {
            get { return _container; }
        }
    }
}
