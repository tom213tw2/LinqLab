using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class SkipAndTakeLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public SkipAndTakeLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> 跳過五筆資料()
        {
            var result = new List<Sample>();
            result = Source.Skip(5).ToList();
            return result;
        }

        public List<Sample> 取得五筆資料()
        {
            var result = new List<Sample>();
            result = Source.Take(5).ToList();
            return result;
        }

        public List<Sample> 跳過五筆取得兩筆()
        {
            var result = new List<Sample>();
            result = Source.Skip(5).Take(2).ToList();
            return result;

        }
    }
}
