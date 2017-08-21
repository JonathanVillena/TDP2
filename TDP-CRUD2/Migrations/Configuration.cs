namespace TDP_CRUD2.Migrations
{
    using DAL;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TdpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TDP_CRUD2.DAL.TdpContext context)
        {

          context.Products.AddOrUpdate(x => x.ID,
            new Product{ID=1 ,Name="Aqualight",Description="botella de agua sin gas", categoryID = 1 },
            new Product{ID = 2, Name ="Doritos",Description="piqueos", categoryID = 2 },
            new Product{ID = 3, Name ="Cusqueña",Description="Bebida con alcohol", categoryID = 3}
            );


            context.Categories.AddOrUpdate(x => x.CategoryID,
            
            new Category{CategoryID = 1,Name="Bebidas",Description="Bebidas refrescantes" },
            new Category{ CategoryID = 2, Name ="piqueos", Description="Snacks para picar"},
            new Category{ CategoryID = 3, Name ="Tragos", Description="Bebidas con alcohol"}

            );
        }
    }
}
