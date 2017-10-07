Imports Commons

Public Class Form1

    ''' <summary>
    ''' 初期表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown


        ' メインデータ作成
        Dim mainData = New List(Of LinqToObjectTest)()
        For index = 1 To 20
            mainData.Add(New LinqToObjectTest(index, index, String.Format("Name{0}", index)))
        Next
        Me.mainGrid.DataSource = mainData


    End Sub

    ''' <summary>
    ''' 主キーが10以上のデータを表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub runWhere_Click(sender As Object, e As EventArgs) Handles runWhere.Click

        ' 元データを取得
        Dim srcMainData = DirectCast(Me.mainGrid.DataSource, List(Of LinqToObjectTest))

        ' 主キーが10以上のデータを表示
        Me.resultGrid.DataSource = LinqSampleVB.LinqToObjectSample.WhereSample(srcMainData)

    End Sub
End Class
