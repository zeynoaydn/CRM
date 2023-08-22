using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ProductsManager>().As<IProductsService>().SingleInstance();
            builder.RegisterType<EfProductsDal>().As<IProductsDal>().SingleInstance();

            builder.RegisterType<CountriesManager>().As<ICountriesService>().SingleInstance();
            builder.RegisterType<EfCountriesDal>().As<ICountriesDal>().SingleInstance();

            builder.RegisterType<CitiesManager>().As<ICitiesService>().SingleInstance();
            builder.RegisterType<EfCitiesDal>().As<ICitiesDal>().SingleInstance();

            //builder.RegisterType<UsersManager>().As<IUsersService>().SingleInstance();
            //builder.RegisterType<EfUsersDal>().As<IUsersDal>().SingleInstance();

            //builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
