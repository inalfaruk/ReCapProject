using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBussinesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {  //biri iproduct isterse ona productmanager ver    //singleinstance data tutulmayacak veri için kullanıyoruz
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
        
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
        }
    }
}