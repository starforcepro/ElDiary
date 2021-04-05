using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ElDiary.Builders;
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
            kernel.Bind<INotesService>().To<NotesService>();
            kernel.Bind<IContactHandler>().To<ContactHandler>();
            kernel.Bind<INoteModelBuilder>().To<NoteModelBuilder>();
            kernel.Bind<INoteHandler>().To<NoteHandler>();
            kernel.Bind<INoteModelFactory>().To<NoteModelFactory>();
            kernel.Bind<IContactModelFactory>().To<ContactModelFactory>();
            kernel.Bind<IContactService>().To<ContactService>();
            kernel.Bind<INoteFactory>().To<NoteFactory>();
            kernel.Bind<IContactFactory>().To<ContactFactory>();
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