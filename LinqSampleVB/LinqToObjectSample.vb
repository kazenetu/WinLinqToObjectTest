''' <summary>
''' LinqToObjectのサンプル(VB.Net)
''' </summary>
Public Class LinqToObjectSample

    ''' <summary>
    ''' フィルタのサンプル
    ''' </summary>
    ''' <param name="src">参照元データ</param>
    ''' <returns>主キーが10以上のデータ</returns>
    Public Shared Function WhereSample(ByVal src As List(Of Commons.LinqToObjectTest)) As List(Of Commons.LinqToObjectTest)

        Return src.Where(Function(item) item.PrimaryKey >= 10).ToList()

    End Function

    ''' <summary>
    ''' ソートのサンプル
    ''' </summary>
    ''' <param name="src">参照元データ</param>
    ''' <returns>主キーの降順でソートされたデータ</returns>
    Public Shared Function OrderSample(ByVal src As List(Of Commons.LinqToObjectTest)) As List(Of Commons.LinqToObjectTest)

        Return src.OrderByDescending(Function(item) item.PrimaryKey).ToList()

    End Function

    ''' <summary>
    ''' ジョイン(内部参照)のサンプル
    ''' </summary>
    ''' <param name="src">参照元データ</param>
    ''' <param name="srcSub">参照元サブデータ</param>
    ''' <returns>参照元データの主キーが参照元サブデータの親主キーが紐づくデータ</returns>
    Public Shared Function JoinSample(ByVal src As List(Of Commons.LinqToObjectTest), ByVal srcSub As List(Of Commons.LinqToObjectTest)) As List(Of Commons.LinqToObjectTest)

        Return src.Join(srcSub, Function(ByVal item As Commons.LinqToObjectTest) item.PrimaryKey,
            Function(ByVal subItem As Commons.LinqToObjectTest) subItem.ParentPrimaryKey,
            Function(item, subItem) New Commons.LinqToObjectTest(
            subItem.PrimaryKey,
            subItem.DispleyOrder,
            item.DataName & ":" & subItem.DataName,
            subItem.ParentPrimaryKey
            )).ToList()

    End Function

    ''' <summary>
    ''' グループ(外部参照)のサンプル
    ''' </summary>
    ''' <param name="src">参照元データ</param>
    ''' <param name="srcSub">参照元サブデータ</param>
    ''' <returns>参照元データの主キーが参照元サブデータの親主キーに存在するか否かを追加したデータ</returns>
    Public Shared Function GroupJoinSample(ByVal src As List(Of Commons.LinqToObjectTest), ByVal srcSub As List(Of Commons.LinqToObjectTest)) As IEnumerable(Of Object)

        Return src.GroupJoin(srcSub, Function(ByVal item As Commons.LinqToObjectTest) item.PrimaryKey,
            Function(ByVal subItem As Commons.LinqToObjectTest) subItem.ParentPrimaryKey,
            Function(item, subItems) New With {
            Key .PrimaryKey = item.PrimaryKey,
            Key .DispleyOrder = item.DispleyOrder,
            Key .DataName = item.DataName,
            Key .existsSubItem = subItems.Any()
            }).ToList()

    End Function

    ''' <summary>
    ''' グルーピングのサンプル
    ''' </summary>
    ''' <param name="src">参照元データ</param>
    ''' <returns>「主キー/10」でグループされたデータ</returns>
    Public Shared Function GroupSample(ByVal src As List(Of Commons.LinqToObjectTest)) As IEnumerable(Of Object)

        Return src.GroupBy(Function(item) Math.Floor(item.PrimaryKey / 10),
            Function(item, element) New With {
            Key .PrimaryKeyPer10 = item.ToString(),
            Key .Count = element.Count()
            }).ToList()

    End Function

End Class
