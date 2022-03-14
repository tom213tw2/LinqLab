using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> 搜尋Id大於8的資料()
        {
            var result = new List<Sample>();
            result = Source.Where(s => s.Id > 8).ToList();
            return result;
        }

        public List<Sample> 搜尋Price等於200的資料()
        {
            var result = new List<Sample>();
            result = Source.Where(s => s.Price.Equals(200)).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName開頭為d的資料()
        {
            var result = new List<Sample>();
            result = Source.Where(s => s.UserName.StartsWith("d")).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName包含e的資料()
        {
            var result = new List<Sample>();
            result = Source.Where(s => s.UserName.Contains("e")).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName結尾為o的資料()
        {
            var result = new List<Sample>();
            result = Source.Where(s => s.UserName.EndsWith("o")).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName是demo和joey的資料()
        {
            var whereStr = new[] { "demo", "joey" };
            var result = new List<Sample>();
            result = Source.Where(s => whereStr.Contains(s.UserName)).ToList();
            return result;
        }

        public bool 判斷是否有Id等於99的資料()
        {
            var result = true;
            result = Source.Any(s => s.Id.Equals(99));
            return result;
        }


        public int SumOfPriceOfOneUser(string username)
        {
            var result = 0;
            result = Source.Where(s => s.UserName.Equals(username)).Select(s => s.Price).Sum();
            return result;
        }

        public List<Sample> SampleFromYearMonth(DateTime dateTime)
        {
            var result = new List<Sample>();
            result = Source.Where(s => s.CreateTime.ToString("yyyyMM").Equals(dateTime.ToString("yyyyMM"))).ToList();
            return result;
        }

        public int NumberOfSampleWithIn30Days(DateTime dateTime)
        {
            var result = 0;
            result = Source.Count(s =>
                (s.CreateTime - dateTime).TotalDays <= 31 && (s.CreateTime - dateTime).TotalDays >= 0);
            return result;
        }

        public int NumberOfPeopleHaveItem(int itemId)
        {
            var result = 0;
            result = Source.Where(s => s.Item.Any(x => x.Equals(itemId))).Select(s => s.UserName).Distinct().Count();
            return result;
        }
    }
}
