<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.btnShowForm = New System.Windows.Forms.Button()
        Me.lblHelloWorld = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowForm
        '
        Me.btnShowForm.Location = New System.Drawing.Point(120, 12)
        Me.btnShowForm.Name = "btnShowForm"
        Me.btnShowForm.Size = New System.Drawing.Size(261, 90)
        Me.btnShowForm.TabIndex = 0
        Me.btnShowForm.Text = "&Следующая форма"
        Me.btnShowForm.UseVisualStyleBackColor = True
        '
        'lblHelloWorld
        '
        Me.lblHelloWorld.AutoSize = True
        Me.lblHelloWorld.Location = New System.Drawing.Point(-3, 285)
        Me.lblHelloWorld.Name = "lblHelloWorld"
        Me.lblHelloWorld.Size = New System.Drawing.Size(73, 13)
        Me.lblHelloWorld.TabIndex = 1
        Me.lblHelloWorld.Text = "Привет, мир!"
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 322)
        Me.Controls.Add(Me.lblHelloWorld)
        Me.Controls.Add(Me.btnShowForm)
        Me.Name = "form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Окно№1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowForm As System.Windows.Forms.Button
    Friend WithEvents lblHelloWorld As System.Windows.Forms.Label

End Class
