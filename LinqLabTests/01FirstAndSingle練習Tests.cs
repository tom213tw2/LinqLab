using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace LinqLab.Tests
{
    [TestClass()]
    public class FirstAndSingle練習Tests
    {

        [TestMethod()]
        public void 搜尋UserName等於demo的資料使用FirstTest()
        {
            var expected =
                new Sample
                {
                    Id = 1,
                    UserName = "demo",
                    CreateTime = new DateTime(2016, 1, 20),
                    Price = 800,
                    Item = new List<int> { 97, 92, 81, 60 }
                }.ToExpectedObject();

            var actual = new FirstAndSingleLab().搜尋UserName等於demo的資料使用First();

            expected.ShouldEqual(actual);

        }

        [TestMethod()]
        public void 搜尋UserName等於skilltree的資料使用FirstOrDefaultTest()
        {
            Sample expected = null;
            var actual = new FirstAndSingleLab().搜尋UserName等於skilltree的資料使用FirstOrDefault();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void 搜尋UserName等於skilltree的資料使用FirstTest()
        {
            var actual = new FirstAndSingleLab().搜尋UserName等於skilltree的資料使用First();
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void 搜尋UserName等於demo的資料使用SingleTest()
        {
            var actual = new FirstAndSingleLab().搜尋UserName等於demo的資料使用Single();
        }

        [TestMethod()]
        public void 搜尋UserName等於bill的資料使用SingleTest()
        {
            var expected =
                new Sample
                {
                    Id = 9,
                    UserName = "bill",
                    CreateTime = new DateTime(2016, 8, 20),
                    Price = 2000,
                    Item = new List<int> { 68, 79, 88, 92 }
                }.ToExpectedObject();

            var actual = new FirstAndSingleLab().搜尋UserName等於bill的資料使用Single();

            expected.ShouldEqual(actual);
        }

        [TestMethod()]
        public void 搜尋UserName等於bill的資料使用SingleOrDefaultTest()
        {
            var expected =
                new Sample
                {
                    Id = 9,
                    UserName = "bill",
                    CreateTime = new DateTime(2016, 8, 20),
                    Price = 2000,
                    Item = new List<int> { 68, 79, 88, 92 }
                }.ToExpectedObject();

            var actual = new FirstAndSingleLab().搜尋UserName等於bill的資料使用SingleOrDefault();

            expected.ShouldEqual(actual);
        }

        [TestMethod()]
        public void 搜尋UserName等於skilltree的資料使用SingleOrDefaultTest()
        {
            Sample expected = null;

            var actual = new FirstAndSingleLab().搜尋UserName等於skilltree的資料使用SingleOrDefault();

            Assert.AreEqual(expected, actual);

        }
    }
}