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
        Title = New Label()
        Author = New Label()
        Yearpublished = New Label()
        Genre = New Label()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        txtYearPublished = New TextBox()
        txtGenre = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btndelete = New Button()
        btnClear = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Title.Location = New Point(28, 27)
        Title.Name = "Title"
        Title.Size = New Size(43, 20)
        Title.TabIndex = 0
        Title.Text = "Title"
        ' 
        ' Author
        ' 
        Author.AutoSize = True
        Author.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Author.Location = New Point(28, 72)
        Author.Name = "Author"
        Author.Size = New Size(60, 20)
        Author.TabIndex = 1
        Author.Text = "Author"
        ' 
        ' Yearpublished
        ' 
        Yearpublished.AutoSize = True
        Yearpublished.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Yearpublished.Location = New Point(28, 119)
        Yearpublished.Name = "Yearpublished"
        Yearpublished.Size = New Size(120, 20)
        Yearpublished.TabIndex = 2
        Yearpublished.Text = "Year Published"
        ' 
        ' Genre
        ' 
        Genre.AutoSize = True
        Genre.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        Genre.Location = New Point(28, 160)
        Genre.Name = "Genre"
        Genre.Size = New Size(53, 20)
        Genre.TabIndex = 3
        Genre.Text = "Genre"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(200, 27)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(124, 27)
        txtTitle.TabIndex = 4
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(204, 72)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(120, 27)
        txtAuthor.TabIndex = 5
        ' 
        ' txtYearPublished
        ' 
        txtYearPublished.Location = New Point(203, 119)
        txtYearPublished.Name = "txtYearPublished"
        txtYearPublished.Size = New Size(121, 27)
        txtYearPublished.TabIndex = 6
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(204, 160)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(120, 27)
        txtGenre.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(400, 27)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 32)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnUpdate.Location = New Point(400, 70)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btndelete.Location = New Point(400, 110)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 29)
        btndelete.TabIndex = 10
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold)
        btnClear.Location = New Point(400, 160)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 27)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AccessibleName = ""
        DataGridView1.BackgroundColor = SystemColors.HighlightText
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 214)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(580, 189)
        DataGridView1.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnClear)
        Controls.Add(btndelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtGenre)
        Controls.Add(txtYearPublished)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(Genre)
        Controls.Add(Yearpublished)
        Controls.Add(Author)
        Controls.Add(Title)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Author As Label
    Friend WithEvents Yearpublished As Label
    Friend WithEvents Genre As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents DataGridView1 As DataGridView




End Class
