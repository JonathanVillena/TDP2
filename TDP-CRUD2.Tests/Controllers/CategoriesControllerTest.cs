﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TDP_CRUD2.Controllers;
using TDP_CRUD2.DAL;
using TDP_CRUD2.Models;


namespace TDP_CRUD2.Tests.Controllers
{
    [TestClass]
    class CategoriesControllerTest
    {
        [TestMethod]
        public void Insert()
        {
            // Arrang
            var Contex = new TdpContext();
            // Act           

            Category cate = new Category();
            cate.Name = "limpieza";
            cate.Description = "Todos lo productos de Limpieza";

            Contex.Categories.Add(cate);

            String LAST = Contex.Categories.Last().Name;

            // Assert
            Assert.AreEqual(cate.Name, LAST);
        }
        [TestMethod()]
        public void List()
        {
            var Contex = new TdpContext();
             List<Category> listCate= Contex.Categories.ToList();

            if (listCate.Count != 0)
                Equals(true);
            else
                Equals(false);
        }
        [TestMethod]
        public void About()
        {
            var Contex = new TdpContext();
            int cant = Contex.Categories.ToList().Count;

            Contex.Categories.Remove(Contex.Categories.Last());
            int befor= Contex.Categories.ToList().Count;
            if (cant>befor)
                Equals(true);
            else
                Equals(false);
        }


    }
}
