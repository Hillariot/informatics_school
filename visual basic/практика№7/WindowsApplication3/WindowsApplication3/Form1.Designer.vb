<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФормаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СпособыРасположенияФормToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытиеНовойФормыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ГоризонтальноеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВертикальноеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КаскадToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФормаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(407, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФормаToolStripMenuItem
        '
        Me.ФормаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СпособыРасположенияФормToolStripMenuItem, Me.ОткрытиеНовойФормыToolStripMenuItem})
        Me.ФормаToolStripMenuItem.Name = "ФормаToolStripMenuItem"
        Me.ФормаToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ФормаToolStripMenuItem.Text = "Форма"
        '
        'СпособыРасположенияФормToolStripMenuItem
        '
        Me.СпособыРасположенияФормToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ГоризонтальноеToolStripMenuItem, Me.ВертикальноеToolStripMenuItem, Me.КаскадToolStripMenuItem})
        Me.СпособыРасположенияФормToolStripMenuItem.Name = "СпособыРасположенияФормToolStripMenuItem"
        Me.СпособыРасположенияФормToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.СпособыРасположенияФормToolStripMenuItem.Text = "Способы расположения форм"
        '
        'ОткрытиеНовойФормыToolStripMenuItem
        '
        Me.ОткрытиеНовойФормыToolStripMenuItem.Name = "ОткрытиеНовойФормыToolStripMenuItem"
        Me.ОткрытиеНовойФормыToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ОткрытиеНовойФормыToolStripMenuItem.Text = "Открытие новой формы"
        '
        'ГоризонтальноеToolStripMenuItem
        '
        Me.ГоризонтальноеToolStripMenuItem.Name = "ГоризонтальноеToolStripMenuItem"
        Me.ГоризонтальноеToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ГоризонтальноеToolStripMenuItem.Text = "Горизонтальное"
        '
        'ВертикальноеToolStripMenuItem
        '
        Me.ВертикальноеToolStripMenuItem.Name = "ВертикальноеToolStripMenuItem"
        Me.ВертикальноеToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ВертикальноеToolStripMenuItem.Text = "Вертикальное"
        '
        'КаскадToolStripMenuItem
        '
        Me.КаскадToolStripMenuItem.Name = "КаскадToolStripMenuItem"
        Me.КаскадToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.КаскадToolStripMenuItem.Text = "Каскад"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФормаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СпособыРасположенияФормToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ГоризонтальноеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВертикальноеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КаскадToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОткрытиеНовойФормыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
