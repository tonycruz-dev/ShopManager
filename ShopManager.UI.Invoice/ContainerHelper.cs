using AutoMapper;
using ShopManager.UI.Invoice.Repository;
using Unity;
using Unity.Lifetime;

namespace ShopManager.UI.Invoice
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
            _container.RegisterType<IOrderRepository, OrderRepository>(new ContainerControlledLifetimeManager());
            _container.RegisterInstance<IMapper>(config.CreateMapper());

        }

        public static IUnityContainer Container
        {
            get { return _container; }
        }
    }
}