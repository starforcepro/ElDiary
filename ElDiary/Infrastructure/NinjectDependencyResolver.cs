using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ElDiary.Factories;
using ElDiary.Handlers;
using ElDiary.Services;
using Ninject;

namespace ElDiary.Infrastructure
{
    public struct NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;

            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IContactHandler>().To<ContactHandler>();
            kernel.Bind<IContactModelFactory>().To<ContactModelFactory>();
            kernel.Bind<IContactsService>().To<ContactsService>();
            kernel.Bind<IContactFactory>().To<ContactFactory>();
            kernel.Bind<IContactDtoFactory>().To<ContactDtoFactory>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}