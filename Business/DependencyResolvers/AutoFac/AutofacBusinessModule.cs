using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Helpers.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfAboutDal>().As<IAboutDal>().SingleInstance();
            builder.RegisterType<AboutManager>().As<IAboutService>().SingleInstance();
            builder.RegisterType<EfServiceDal>().As<IServiceDal>().SingleInstance();
            builder.RegisterType<ServiceManager>().As<IService>().SingleInstance();

            builder.RegisterType<EfServiceAboutDal>().As<IServiceAboutDal>().SingleInstance();
            builder.RegisterType<ServiceAboutManager>().As<IServiceAbout>().SingleInstance();
            builder.RegisterType<EfPartnerDal>().As<IPartnerDal>().SingleInstance();
            builder.RegisterType<PartnerManager>().As<IPartnerService>().SingleInstance();

            builder.RegisterType<EfTeamDal>().As<ITeamDal>().SingleInstance();
            builder.RegisterType<TeamManager>().As<ITeamService>().SingleInstance();
            builder.RegisterType<EfClientDal>().As<IClientDal>().SingleInstance();
            builder.RegisterType<ClientsManager>().As<IClientsService>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
