using System;
using Common;
using Microsoft.Practices.Unity;

namespace Dependency
{
    public class UnityConfig
    {
        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetUnityContainer()
        {
            return Container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            var registrationModuleAssemblyName = System.Configuration.ConfigurationManager.AppSettings["UnityRegistrationModule"];

            var type = Type.GetType(registrationModuleAssemblyName);

            var module = (IContainerRegistrationModule<IUnityContainer>)Activator.CreateInstance(type);

            module.Register(container);
        }
    }
}
