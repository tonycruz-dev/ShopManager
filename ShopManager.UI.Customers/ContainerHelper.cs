using AutoMapper;
using ShopManager.UI.Customers.Repository;
using Unity;
using Unity.Lifetime;


namespace ShopManager.UI.Customers
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
            _container.RegisterType<IAccountCustomersRepository, AccountCustomersRepository>(new ContainerControlledLifetimeManager());
            _container.RegisterInstance<IMapper>(config.CreateMapper());

        }

        public static IUnityContainer Container
        {
            get { return _container; }
        }
    }
}
