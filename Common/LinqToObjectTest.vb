''' <summary>
''' LinqToObject用クラス
''' </summary>
Public Class LinqToObjectTest

#Region "プロパティ"

    ''' <summary>
    ''' 主キー
    ''' </summary>
    ''' <returns>1からの連番</returns>
    Public Property PrimaryKey As Integer

    ''' <summary>
    ''' 親の主キー
    ''' </summary>
    ''' <returns>親の主キー</returns>
    ''' <remarks>存在しない場合は0</remarks>
    Public Property ParentPrimaryKey As Integer

    ''' <summary>
    ''' 表示順番
    ''' </summary>
    ''' <returns>1からの連番</returns>
    Public Property DispleyOrder As Integer

    ''' <summary>
    ''' データ名
    ''' </summary>
    ''' <returns>文字列</returns>
    Public Property DataName As String

#End Region

#Region "コンストラクタ"

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="primaryKey">主キー</param>
    ''' <param name="displeyOrder">表示順番</param>
    ''' <param name="dataName">データ名</param>
    ''' <param name="parentPrimaryKey">親の主キー</param>
    Public Sub New(ByVal primaryKey As Integer,
                    ByVal displeyOrder As Integer,
                    ByVal dataName As String,
                    Optional ByVal parentPrimaryKey As Integer = 0)

        Me.PrimaryKey = primaryKey
        Me.DispleyOrder = displeyOrder
        Me.DataName = dataName
        Me.ParentPrimaryKey = parentPrimaryKey
    End Sub

#End Region


End Class
