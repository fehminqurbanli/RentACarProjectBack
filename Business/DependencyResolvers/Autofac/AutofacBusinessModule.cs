﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BrandDal>().As<IBrandDal>().SingleInstance();
            builder.RegisterType<CarDal>().As<ICarDal>().SingleInstance();
            builder.RegisterType<ColorDal>().As<IColorDal>().SingleInstance();
            builder.RegisterType<CustomerDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<RentalDal>().As<IRentalDal>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<CarImageDal>().As<ICarImageDal>().SingleInstance();

            builder.RegisterType<BrandManager>().As<IBrandSevice>().SingleInstance();
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<RentalManager>().As<IRentalService>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<CarImageManager>().As<ICarImageService>().SingleInstance();


            builder.RegisterType<UserClaimManager>().As<IUserClaimService>();
            builder.RegisterType<UserClaimDal>().As<IUserClaimDal>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }
    }
}
