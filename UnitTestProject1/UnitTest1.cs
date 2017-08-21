using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TDP_CRUD2.Controllers;
using TDP_CRUD2.DAL;
using TDP_CRUD2.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
    }
}
