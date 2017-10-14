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

        /// <summary>
        /// ソートのサンプル
        /// </summary>
        /// <param name="src">参照元データ</param>
        /// <returns>主キーの降順でソートされたデータ</returns>
        public static List<Commons.LinqToObjectTest> OrderSample(List<Commons.LinqToObjectTest> src)
        {
            return src.OrderByDescending((item) => item.PrimaryKey).ToList();
        }

        /// <summary>
        /// ジョイン(内部参照)のサンプル
        /// </summary>
        /// <param name="src">参照元データ</param>
        /// <param name="srcSub">参照元サブデータ</param>
        /// <returns>主キーの降順でソートされたデータ</returns>
        public static List<Commons.LinqToObjectTest> JoinSample(List<Commons.LinqToObjectTest> src, List<Commons.LinqToObjectTest> srcSub)
        {
            return src.Join(srcSub, (srcItem) => srcItem.PrimaryKey, (subSrcItem) => subSrcItem.ParentPrimaryKey,
                            (srcItem, subSrcItem) => 
                                new Commons.LinqToObjectTest(
                                    subSrcItem.PrimaryKey,
                                    subSrcItem.DispleyOrder,
                                    srcItem.DataName + ":" + subSrcItem.DataName,
                                    subSrcItem.ParentPrimaryKey)
                            ).ToList();
        }
    }
}
