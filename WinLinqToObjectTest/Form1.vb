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

        ' サブデータ作成
        Dim subData = New List(Of LinqToObjectTest)()
        subData.Add(New LinqToObjectTest(100, 1, String.Format("SubName{0}", 100), 5))
        subData.Add(New LinqToObjectTest(101, 2, String.Format("SubName{0}", 101), 15))
        Me.subGrid.DataSource = subData

    End Sub

#Region "VB版サンプル"

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

    ''' <summary>
    ''' 主キーの降順データを表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub runOrder_Click(sender As Object, e As EventArgs) Handles runOrder.Click

        ' 元データを取得
        Dim srcMainData = DirectCast(Me.mainGrid.DataSource, List(Of LinqToObjectTest))

        ' 主キーの降順データを表示
        Me.resultGrid.DataSource = LinqSampleVB.LinqToObjectSample.OrderSample(srcMainData)

    End Sub

    ''' <summary>
    ''' グループデータを表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub runGroupJoin_Click(sender As Object, e As EventArgs) Handles runGroupJoin.Click

        ' 元データを取得
        Dim srcMainData = DirectCast(Me.mainGrid.DataSource, List(Of LinqToObjectTest))

        ' 元サブデータを取得
        Dim srcSubData = DirectCast(Me.subGrid.DataSource, List(Of LinqToObjectTest))

        ' グループデータを表示
        Me.resultGrid.DataSource = LinqSampleVB.LinqToObjectSample.GroupJoinSample(srcMainData, srcSubData)
    End Sub

    ''' <summary>
    ''' ジョインデータを表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub runJoin_Click(sender As Object, e As EventArgs) Handles runJoin.Click
        ' 元データを取得
        Dim srcMainData = DirectCast(Me.mainGrid.DataSource, List(Of LinqToObjectTest))

        ' 元サブデータを取得
        Dim srcSubData = DirectCast(Me.subGrid.DataSource, List(Of LinqToObjectTest))

        ' ジョインデータを表示
        Me.resultGrid.DataSource = LinqSampleVB.LinqToObjectSample.JoinSample(srcMainData, srcSubData)
    End Sub

    ''' <summary>
    ''' グルーピングデータを表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub runGroup_Click(sender As Object, e As EventArgs) Handles runGroup.Click

        ' 元データを取得
        Dim srcMainData = DirectCast(Me.mainGrid.DataSource, List(Of LinqToObjectTest))

        ' グルーピングデータを表示
        Me.resultGrid.DataSource = LinqSampleVB.LinqToObjectSample.GroupSample(srcMainData)
    End Sub

#End Region

#Region "C# 版サンプル"

    ''' <summary>
    ''' 主キーが10以上のデータを表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub runWhereCS_Click(sender As Object, e As EventArgs) Handles runWhereCS.Click

        ' 元データを取得
        Dim srcMainData = DirectCast(Me.mainGrid.DataSource, List(Of LinqToObjectTest))

        ' 主キーが10以上のデータを表示
        Me.resultGrid.DataSource = LinqSampleCSharp.LinqToObjectSample.WhereSample(srcMainData)

    End Sub

    ''' <summary>
    ''' 主キーの降順データを表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub runOrderCS_Click(sender As Object, e As EventArgs) Handles runOrderCS.Click

        ' 元データを取得
        Dim srcMainData = DirectCast(Me.mainGrid.DataSource, List(Of LinqToObjectTest))

        ' 主キーの降順データを表示
        Me.resultGrid.DataSource = LinqSampleCSharp.LinqToObjectSample.OrderSample(srcMainData)

    End Sub

#End Region

End Class
