''' <summary>
''' LinqToObjectのサンプル(VB.Net)
''' </summary>
Public Class LinqToObjectSample

    ''' <summary>
    ''' Whereのサンプル
    ''' </summary>
    ''' <param name="src">参照元データ</param>
    ''' <returns>主キーが10以上のデータ</returns>
    Public Shared Function WhereSample(ByVal src As List(Of Commons.LinqToObjectTest)) As List(Of Commons.LinqToObjectTest)

        Return src.Where(Function(item) item.PrimaryKey >= 10).ToList()

    End Function
End Class
