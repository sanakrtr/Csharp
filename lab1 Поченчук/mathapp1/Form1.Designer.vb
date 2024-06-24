<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        methodBox = New ComboBox()
        XBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        addXY = New Button()
        Button3 = New Button()
        YBox = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        XYList = New Label()
        SuspendLayout()
        ' 
        ' methodBox
        ' 
        methodBox.FormattingEnabled = True
        methodBox.Items.AddRange(New Object() {"Впорядкувати від початку координат", "Впорядкувати за кутом"})
        methodBox.Location = New Point(29, 203)
        methodBox.Name = "methodBox"
        methodBox.Size = New Size(193, 23)
        methodBox.TabIndex = 0
        ' 
        ' XBox
        ' 
        XBox.Location = New Point(46, 67)
        XBox.Name = "XBox"
        XBox.Size = New Size(35, 23)
        XBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 15)
        Label1.TabIndex = 2
        Label1.Text = "Введіть координати"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(13, 15)
        Label2.TabIndex = 3
        Label2.Text = "x"
        ' 
        ' addXY
        ' 
        addXY.Location = New Point(147, 67)
        addXY.Name = "addXY"
        addXY.Size = New Size(75, 23)
        addXY.TabIndex = 7
        addXY.Text = "Додати"
        addXY.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(29, 232)
        Button3.Name = "Button3"
        Button3.Size = New Size(193, 23)
        Button3.TabIndex = 8
        Button3.Text = "Впорядкувати"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' YBox
        ' 
        YBox.Location = New Point(106, 67)
        YBox.Name = "YBox"
        YBox.Size = New Size(35, 23)
        YBox.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(87, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(13, 15)
        Label4.TabIndex = 10
        Label4.Text = "y"
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(255, 233)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 23)
        Button1.TabIndex = 11
        Button1.Text = "Очистити"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(266, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 15)
        Label5.TabIndex = 12
        Label5.Text = "Координати:"
        ' 
        ' XYList
        ' 
        XYList.AutoSize = True
        XYList.Location = New Point(266, 54)
        XYList.Name = "XYList"
        XYList.Size = New Size(41, 15)
        XYList.TabIndex = 13
        XYList.Text = "Label3"
        XYList.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(536, 280)
        Controls.Add(XYList)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(YBox)
        Controls.Add(Button3)
        Controls.Add(addXY)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(XBox)
        Controls.Add(methodBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents methodBox As ComboBox
    Friend WithEvents XBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addXY As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents YBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents XYList As Label

End Class
