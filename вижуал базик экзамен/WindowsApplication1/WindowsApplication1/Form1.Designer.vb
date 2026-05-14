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
        Me.СоздаьФормуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РасположениеФормToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КаскадToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ГоризонтальноToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВертикальноToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФормаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФормаToolStripMenuItem
        '
        Me.ФормаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоздаьФормуToolStripMenuItem, Me.РасположениеФормToolStripMenuItem})
        Me.ФормаToolStripMenuItem.Name = "ФормаToolStripMenuItem"
        Me.ФормаToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ФормаToolStripMenuItem.Text = "Форма"
        '
        'СоздаьФормуToolStripMenuItem
        '
        Me.СоздаьФормуToolStripMenuItem.Name = "СоздаьФормуToolStripMenuItem"
        Me.СоздаьФормуToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.СоздаьФормуToolStripMenuItem.Text = "Создать форму"
        '
        'РасположениеФормToolStripMenuItem
        '
        Me.РасположениеФормToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КаскадToolStripMenuItem, Me.ГоризонтальноToolStripMenuItem, Me.ВертикальноToolStripMenuItem})
        Me.РасположениеФормToolStripMenuItem.Name = "РасположениеФормToolStripMenuItem"
        Me.РасположениеФормToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.РасположениеФормToolStripMenuItem.Text = "Расположение форм"
        '
        'КаскадToolStripMenuItem
        '
        Me.КаскадToolStripMenuItem.Name = "КаскадToolStripMenuItem"
        Me.КаскадToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.КаскадToolStripMenuItem.Text = "Каскад"
        '
        'ГоризонтальноToolStripMenuItem
        '
        Me.ГоризонтальноToolStripMenuItem.Name = "ГоризонтальноToolStripMenuItem"
        Me.ГоризонтальноToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ГоризонтальноToolStripMenuItem.Text = "Горизонтально "
        '
        'ВертикальноToolStripMenuItem
        '
        Me.ВертикальноToolStripMenuItem.Name = "ВертикальноToolStripMenuItem"
        Me.ВертикальноToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ВертикальноToolStripMenuItem.Text = "Вертикально"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 367)
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
    Friend WithEvents СоздаьФормуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РасположениеФормToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КаскадToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ГоризонтальноToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВертикальноToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
