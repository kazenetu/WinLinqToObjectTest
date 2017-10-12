using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSampleCSharp
{
    /// <summary>
    /// LinqToObjectのサンプル(C#)
    /// </summary>
    public class LinqToObjectSample
    {
        /// <summary>
        /// フィルタのサンプル
        /// </summary>
        /// <param name="src">参照元データ</param>
        /// <returns>主キーが10以上のデータ</returns>
        public static List<Commons.LinqToObjectTest > WhereSample(List<Commons.LinqToObjectTest> src)
        {
            return src.Where((item) => item.PrimaryKey >= 10).ToList();
        }
    }
}
