<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_Details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BookCode = New System.Windows.Forms.TextBox()
        Me.BookName = New System.Windows.Forms.TextBox()
        Me.BookPrice = New System.Windows.Forms.TextBox()
        Me.BookAuthor = New System.Windows.Forms.TextBox()
        Me.BookStatus = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ViewBook = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bk_Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bk_Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bk_Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bk_Author"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Bk_Status"
        '
        'BookCode
        '
        Me.BookCode.Location = New System.Drawing.Point(98, 12)
        Me.BookCode.Name = "BookCode"
        Me.BookCode.Size = New System.Drawing.Size(100, 20)
        Me.BookCode.TabIndex = 9
        '
        'BookName
        '
        Me.BookName.Location = New System.Drawing.Point(98, 42)
        Me.BookName.Name = "BookName"
        Me.BookName.Size = New System.Drawing.Size(100, 20)
        Me.BookName.TabIndex = 10
        '
        'BookPrice
        '
        Me.BookPrice.Location = New System.Drawing.Point(98, 70)
        Me.BookPrice.Name = "BookPrice"
        Me.BookPrice.Size = New System.Drawing.Size(100, 20)
        Me.BookPrice.TabIndex = 11
        '
        'BookAuthor
        '
        Me.BookAuthor.Location = New System.Drawing.Point(98, 97)
        Me.BookAuthor.Name = "BookAuthor"
        Me.BookAuthor.Size = New System.Drawing.Size(100, 20)
        Me.BookAuthor.TabIndex = 12
        '
        'BookStatus
        '
        Me.BookStatus.Location = New System.Drawing.Point(98, 121)
        Me.BookStatus.Name = "BookStatus"
        Me.BookStatus.Size = New System.Drawing.Size(100, 20)
        Me.BookStatus.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(174, 191)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(93, 191)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 191)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Insert"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ViewBook
        '
        Me.ViewBook.Location = New System.Drawing.Point(18, 221)
        Me.ViewBook.Name = "ViewBook"
        Me.ViewBook.Size = New System.Drawing.Size(75, 23)
        Me.ViewBook.TabIndex = 17
        Me.ViewBook.Text = "View"
        Me.ViewBook.UseVisualStyleBackColor = True
        '
        'Book_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ViewBook)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.BookStatus)
        Me.Controls.Add(Me.BookAuthor)
        Me.Controls.Add(Me.BookPrice)
        Me.Controls.Add(Me.BookName)
        Me.Controls.Add(Me.BookCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Book_Details"
        Me.Text = "Book_Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BookCode As System.Windows.Forms.TextBox
    Friend WithEvents BookName As System.Windows.Forms.TextBox
    Friend WithEvents BookPrice As System.Windows.Forms.TextBox
    Friend WithEvents BookAuthor As System.Windows.Forms.TextBox
    Friend WithEvents BookStatus As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ViewBook As System.Windows.Forms.Button
End Class
