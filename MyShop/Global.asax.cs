using MyShop.Models;
using MyShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyShop
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
          //DatabaseSeed();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void DatabaseSeed()
        {
            using (MyShopContext db = new MyShopContext())
            {
                db.Categories.Add(new Category() { CategoryName = "Electronics" });
                db.Products.Add(new Product() { ProductName="SimpleProduct"});

                db.SaveChanges();
            }
        }
    }
}
