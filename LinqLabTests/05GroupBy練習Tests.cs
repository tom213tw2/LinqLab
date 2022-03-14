using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqLab.練習題;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace LinqLab.練習題.Tests
{
    [TestClass()]
    public class GroupBy練習Tests
    {
        [TestMethod()]
        public void 使用UserName作為群組依據Test()
        {
            var expected =
                new Dictionary<string, int>()
                {
                    {"demo", 4},
                    {"joey", 3},
                    {"dino", 1},
                    {"bill", 1},
                    {"maduka", 1}
                }.ToExpectedObject();

            var actual = new GroupByLab().使用UserName作為群組依據();

            expected.ShouldEqual(actual.ToDictionary(d => d.Key, d => d.Count()));
        }

        [TestMethod()]
        public void 使用UserName和CreateTime作為群組依據Test()
        {
            var expected =
                new List<string>()
                {
                    {"demo2016-01-20"},
                    {"demo2016-02-20"},
                    {"demo2016-03-20"},
                    {"demo2016-03-20"},
                    {"joey2016-04-20"},
                    {"joey2016-05-20"},
                    {"joey2016-06-20"},
                    {"dino2016-07-20"},
                    {"bill2016-08-20"},
                    {"maduka2016-01-20"},
                }.ToExpectedObject();

            var actual = new GroupByLab().使用UserName和CreateTime作為群組依據();

            expected.ShouldEqual(actual.Select(d => d.Key.UserName + "" + d.Key.CreateTime.ToString("yyyy-MM-dd")).ToList());

        }
    }
}