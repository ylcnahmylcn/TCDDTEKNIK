using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers_BağımlılıkÇözümleyici_.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<FaultManager>().As<IFaultService>().SingleInstance();
           builder.RegisterType<EfFaultDal>().As<IFaultDal>().SingleInstance();
           builder.RegisterType<FaultOffManager>().As<IFaultOffService>().SingleInstance();
           builder.RegisterType<EfFaultOffDal>().As<IFaultOffDal>().SingleInstance();


        }
    }
}
