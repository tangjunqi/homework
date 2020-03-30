using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace project10._2test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void QueryTest1()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            OrderService forder = new OrderService();
            forder.Add(new Order(2, "jun", items2));
            forder.Add(new Order(1, "tang", items1));
            CollectionAssert.AreEqual(order.Query(3), forder);
        }
        [TestMethod]
        public void QueryTest2()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            Assert.IsNull(order.Query(3));
        }
        [TestMethod]
        public void QuerybynumberTest1()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            OrderService forder = new OrderService();
            forder.Add(new Order(2, "jun", items2));
            CollectionAssert.AreEqual(order.Querybynumber(2), forder);
        }
        [TestMethod]
        public void QuerybynumberTest2()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            Assert.IsNull(order.Querybynumber(3));
        }
        [TestMethod]
        public void QuerybynameTest1()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            OrderService forder = new OrderService();
            forder.Add(new Order(2, "jun", items2));
            CollectionAssert.AreEqual(order.Querybyname("jun"), forder);
        }
        [TestMethod]
        public void QuerybynameTest2()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            Assert.IsNull(order.Querybyname(""));
        }
        [TestMethod]
        public void Compare1Test()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            order.Compare1();
            Assert.IsTrue(order.List[0].Id == 1 && order.List[1].Id == 2);
        }
        [TestMethod]
        public void Compare2Test()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            order.Compare2();
            Assert.IsTrue(order.List[0].Id == 2 && order.List[1].Id == 1);
        }
        [TestMethod]
        public void AddTest()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            Assert.IsTrue(order.List.Count == 1);
        }
        [TestMethod]
        public void DeleteTest()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Delet();
            Assert.IsNull(order);
        }
        [TestMethod]
        public void ExportTest()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            myService.Export("路径");
            String s1 = File.ReadAllText("路径");
            String s2 = File.ReadAllText("创建好的相同xml");
            Assert.IsTrue(s1 == s2);
        }
        [TestMethod]
        public void ImportTest()
        {
            List<OrderItem> items1 = new List<OrderItem>();
            List<OrderItem> items2 = new List<OrderItem>();
            items1.Add(new OrderItem(1000, 2, "bigcar"));
            items1.Add(new OrderItem(100000, 3, "expensivecar"));
            items1.Add(new OrderItem(500, 2, "cheapcar"));
            items2.Add(new OrderItem(1000, 1, "bigcar"));
            items2.Add(new OrderItem(100000, 1, "expensivecar"));
            items2.Add(new OrderItem(500, 1, "cheapcar"));
            OrderService order = new OrderService();
            order.Add(new Order(1, "tang", items1));
            order.Add(new Order(2, "jun", items2));
            List<Order> forder = myService.Import("xml");
            bool x = true;
            for (int i = 0; i < forder.Count; i++)
                if (!(forder[i].Equals(order.List[i])))
                {
                    x = false;
                    break;
                }
            Assert.IsTrue(x);
        }
    }
}
