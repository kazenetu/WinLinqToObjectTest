<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainGrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.subGrid = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.resultGrid = New System.Windows.Forms.DataGridView()
        Me.runWhere = New System.Windows.Forms.Button()
        Me.runOrder = New System.Windows.Forms.Button()
        CType(Me.mainGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainGrid
        '
        Me.mainGrid.AllowUserToAddRows = False
        Me.mainGrid.AllowUserToDeleteRows = False
        Me.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mainGrid.Location = New System.Drawing.Point(11, 27)
        Me.mainGrid.Name = "mainGrid"
        Me.mainGrid.ReadOnly = True
        Me.mainGrid.RowTemplate.Height = 21
        Me.mainGrid.Size = New System.Drawing.Size(520, 137)
        Me.mainGrid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "メインデータ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "サブデータ"
        '
        'subGrid
        '
        Me.subGrid.AllowUserToAddRows = False
        Me.subGrid.AllowUserToDeleteRows = False
        Me.subGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subGrid.Location = New System.Drawing.Point(11, 192)
        Me.subGrid.Name = "subGrid"
        Me.subGrid.ReadOnly = True
        Me.subGrid.RowTemplate.Height = 21
        Me.subGrid.Size = New System.Drawing.Size(520, 137)
        Me.subGrid.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "結果"
        '
        'resultGrid
        '
        Me.resultGrid.AllowUserToAddRows = False
        Me.resultGrid.AllowUserToDeleteRows = False
        Me.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resultGrid.Location = New System.Drawing.Point(11, 391)
        Me.resultGrid.Name = "resultGrid"
        Me.resultGrid.ReadOnly = True
        Me.resultGrid.RowTemplate.Height = 21
        Me.resultGrid.Size = New System.Drawing.Size(520, 137)
        Me.resultGrid.TabIndex = 4
        '
        'runWhere
        '
        Me.runWhere.Location = New System.Drawing.Point(556, 27)
        Me.runWhere.Name = "runWhere"
        Me.runWhere.Size = New System.Drawing.Size(118, 34)
        Me.runWhere.TabIndex = 6
        Me.runWhere.Text = "Where" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(主キーが10以上)"
        Me.runWhere.UseVisualStyleBackColor = True
        '
        'runOrder
        '
        Me.runOrder.Location = New System.Drawing.Point(556, 82)
        Me.runOrder.Name = "runOrder"
        Me.runOrder.Size = New System.Drawing.Size(118, 34)
        Me.runOrder.TabIndex = 7
        Me.runOrder.Text = "Order" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(主キーの降順)"
        Me.runOrder.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 557)
        Me.Controls.Add(Me.runOrder)
        Me.Controls.Add(Me.runWhere)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.resultGrid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.subGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mainGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.mainGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainGrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents subGrid As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents resultGrid As DataGridView
    Friend WithEvents runWhere As Button
    Friend WithEvents runOrder As Button
End Class
