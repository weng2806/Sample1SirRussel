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
        user = New TextBox()
        checker = New TextBox()
        btnCheckingaa = New Button()
        Label1 = New Label()
        named = New TextBox()
        section = New TextBox()
        SuspendLayout()
        ' 
        ' user
        ' 
        user.Location = New Point(219, 119)
        user.Name = "user"
        user.Size = New Size(100, 23)
        user.TabIndex = 0
        ' 
        ' checker
        ' 
        checker.Location = New Point(504, 119)
        checker.Name = "checker"
        checker.Size = New Size(100, 23)
        checker.TabIndex = 1
        ' 
        ' btnCheckingaa
        ' 
        btnCheckingaa.Location = New Point(380, 201)
        btnCheckingaa.Name = "btnCheckingaa"
        btnCheckingaa.Size = New Size(75, 23)
        btnCheckingaa.TabIndex = 2
        btnCheckingaa.Text = "Check"
        btnCheckingaa.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(201, 338)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 3
        ' 
        ' named
        ' 
        named.Location = New Point(219, 276)
        named.Name = "named"
        named.Size = New Size(100, 23)
        named.TabIndex = 4
        ' 
        ' section
        ' 
        section.Location = New Point(504, 276)
        section.Name = "section"
        section.Size = New Size(100, 23)
        section.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(867, 450)
        Controls.Add(section)
        Controls.Add(named)
        Controls.Add(Label1)
        Controls.Add(btnCheckingaa)
        Controls.Add(checker)
        Controls.Add(user)
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents user As TextBox
    Friend WithEvents checker As TextBox
    Friend WithEvents btnCheckingaa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents named As TextBox
    Friend WithEvents section As TextBox

End Class
