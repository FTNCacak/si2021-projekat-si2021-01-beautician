using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Unity;
using BeuticianBusiness;
using BeuticianData;
using Shared.Interfaces;

namespace BeuticianWeb
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = this.AddUnity();

            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<IOrderRepository, OrderRepository>();
            container.RegisterType<IOrderItemRepository, OrderItemRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IManufacturerRepository, ManufacturerRepository>();


            container.RegisterType<ICustomerBusiness, CustomerBusiness>();
            container.RegisterType<IOrderBusiness, OrderBusiness>();
            container.RegisterType<IOrderItemBusiness, OrderItemBusiness>();
            container.RegisterType<IProductBusiness, ProductBusiness>();
            container.RegisterType<ICategoryBusiness, CategoryBusiness>();
            container.RegisterType<IManufacturerBusiness, ManufacturerBusiness>();


        }
    }
}