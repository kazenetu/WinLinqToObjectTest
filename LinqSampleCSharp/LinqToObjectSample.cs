﻿using System;
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
        /// <returns>参照元データの主キーが参照元サブデータの親主キーが紐づくデータ</returns>
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

        /// <summary>
        /// グループ(外部参照)のサンプル
        /// </summary>
        /// <param name="src">参照元データ</param>
        /// <param name="srcSub">参照元サブデータ</param>
        /// <returns>参照元データの主キーが参照元サブデータの親主キーに存在するか否かを追加したデータ</returns>
        public static IEnumerable<Object> GroupJoinSample(List<Commons.LinqToObjectTest> src, List<Commons.LinqToObjectTest> srcSub)
        {
            return src.GroupJoin(srcSub, (srcItem) => srcItem.PrimaryKey, (subSrcItem) => subSrcItem.ParentPrimaryKey,
                            (srcItem, subSrcItem) =>
                                new {
                                    PrimaryKey = srcItem.PrimaryKey,
                                    DispleyOrder = srcItem.DispleyOrder,
                                    DataName = srcItem.DataName,
                                    existsSubItem = subSrcItem.Any()
                                }
                            ).ToList();
        }

        /// <summary>
        /// グルーピングのサンプル
        /// </summary>
        /// <param name="src">参照元データ</param>
        /// <returns>「主キー/10」でグループされたデータ</returns>
        public static IEnumerable<Object> GroupSample(List<Commons.LinqToObjectTest> src)
        {
            return src.GroupBy((srcItem) => Math.Floor(srcItem.PrimaryKey / 10D),
                            (srcItem, elements) =>
                                new
                                {
                                    PrimaryKeyPer10 = srcItem.ToString(),
                                    Count = elements.Count()
                                }
                            ).ToList();
        }
    }
}
