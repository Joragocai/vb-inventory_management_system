<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblManageItems = New System.Windows.Forms.Label()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.pbRefresh = New System.Windows.Forms.PictureBox()
        Me.ItemDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogOutt = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearr = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeletee = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditt = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSavee = New Guna.UI2.WinForms.Guna2Button()
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cboCategories = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblCategories = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Guna2MessageDialog1 = New Guna.UI2.WinForms.Guna2MessageDialog()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblManageItems
        '
        Me.lblManageItems.AutoSize = True
        Me.lblManageItems.BackColor = System.Drawing.Color.Transparent
        Me.lblManageItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblManageItems.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManageItems.Location = New System.Drawing.Point(15, 6)
        Me.lblManageItems.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblManageItems.Name = "lblManageItems"
        Me.lblManageItems.Size = New System.Drawing.Size(111, 22)
        Me.lblManageItems.TabIndex = 3
        Me.lblManageItems.Text = "INVENTORY"
        Me.lblManageItems.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboSearch
        '
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"Casual", "Semi-Formal", "Formal", "Sports", "Travel", "Kid", "Summer Type", "Winter ", "Fall", "Streetwear"})
        Me.cboSearch.Location = New System.Drawing.Point(697, 70)
        Me.cboSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(244, 26)
        Me.cboSearch.TabIndex = 19
        '
        'pbRefresh
        '
        Me.pbRefresh.BackColor = System.Drawing.Color.White
        Me.pbRefresh.Image = CType(resources.GetObject("pbRefresh.Image"), System.Drawing.Image)
        Me.pbRefresh.Location = New System.Drawing.Point(953, 70)
        Me.pbRefresh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbRefresh.Name = "pbRefresh"
        Me.pbRefresh.Size = New System.Drawing.Size(33, 30)
        Me.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRefresh.TabIndex = 16
        Me.pbRefresh.TabStop = False
        '
        'ItemDGV
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.ItemDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ItemDGV.ColumnHeadersHeight = 40
        Me.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemDGV.DefaultCellStyle = DataGridViewCellStyle9
        Me.ItemDGV.GridColor = System.Drawing.Color.White
        Me.ItemDGV.Location = New System.Drawing.Point(383, 149)
        Me.ItemDGV.Name = "ItemDGV"
        Me.ItemDGV.ReadOnly = True
        Me.ItemDGV.RowHeadersVisible = False
        Me.ItemDGV.RowHeadersWidth = 62
        Me.ItemDGV.Size = New System.Drawing.Size(733, 465)
        Me.ItemDGV.TabIndex = 22
        Me.ItemDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ItemDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ItemDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ItemDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ItemDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ItemDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ItemDGV.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.ItemDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black
        Me.ItemDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ItemDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ItemDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ItemDGV.ThemeStyle.HeaderStyle.Height = 40
        Me.ItemDGV.ThemeStyle.ReadOnly = True
        Me.ItemDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ItemDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ItemDGV.ThemeStyle.RowsStyle.Height = 22
        Me.ItemDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.ItemDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.ItemDGV)
        Me.Panel2.Controls.Add(Me.pbRefresh)
        Me.Panel2.Controls.Add(Me.cboSearch)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1152, 712)
        Me.Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(693, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "STOCK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(491, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 22)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "FILTER BY CATEGORY"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-122, -113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(528, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1150, 50)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogOutt)
        Me.Panel1.Controls.Add(Me.btnClearr)
        Me.Panel1.Controls.Add(Me.btnDeletee)
        Me.Panel1.Controls.Add(Me.btnEditt)
        Me.Panel1.Controls.Add(Me.btnSavee)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.txtQuantity)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.cboCategories)
        Me.Panel1.Controls.Add(Me.lblCategories)
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.lblQuantity)
        Me.Panel1.Controls.Add(Me.lblItemName)
        Me.Panel1.Controls.Add(Me.lblManageItems)
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 661)
        Me.Panel1.TabIndex = 23
        '
        'btnLogOutt
        '
        Me.btnLogOutt.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOutt.BorderRadius = 10
        Me.btnLogOutt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogOutt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogOutt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogOutt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogOutt.FillColor = System.Drawing.Color.Transparent
        Me.btnLogOutt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogOutt.ForeColor = System.Drawing.Color.White
        Me.btnLogOutt.Image = CType(resources.GetObject("btnLogOutt.Image"), System.Drawing.Image)
        Me.btnLogOutt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogOutt.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnLogOutt.Location = New System.Drawing.Point(3, 521)
        Me.btnLogOutt.Name = "btnLogOutt"
        Me.btnLogOutt.Size = New System.Drawing.Size(42, 44)
        Me.btnLogOutt.TabIndex = 40
        Me.btnLogOutt.Text = "   "
        '
        'btnClearr
        '
        Me.btnClearr.BackColor = System.Drawing.Color.Transparent
        Me.btnClearr.BorderRadius = 10
        Me.btnClearr.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClearr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClearr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearr.FillColor = System.Drawing.Color.Gray
        Me.btnClearr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearr.ForeColor = System.Drawing.Color.White
        Me.btnClearr.Image = CType(resources.GetObject("btnClearr.Image"), System.Drawing.Image)
        Me.btnClearr.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClearr.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnClearr.Location = New System.Drawing.Point(172, 354)
        Me.btnClearr.Name = "btnClearr"
        Me.btnClearr.Size = New System.Drawing.Size(121, 37)
        Me.btnClearr.TabIndex = 39
        Me.btnClearr.Text = "   CLEAR"
        '
        'btnDeletee
        '
        Me.btnDeletee.BackColor = System.Drawing.Color.Transparent
        Me.btnDeletee.BorderRadius = 10
        Me.btnDeletee.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeletee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeletee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeletee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeletee.FillColor = System.Drawing.Color.Gray
        Me.btnDeletee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeletee.ForeColor = System.Drawing.Color.White
        Me.btnDeletee.Image = CType(resources.GetObject("btnDeletee.Image"), System.Drawing.Image)
        Me.btnDeletee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDeletee.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDeletee.Location = New System.Drawing.Point(35, 354)
        Me.btnDeletee.Name = "btnDeletee"
        Me.btnDeletee.Size = New System.Drawing.Size(121, 37)
        Me.btnDeletee.TabIndex = 38
        Me.btnDeletee.Text = "   DELETE"
        '
        'btnEditt
        '
        Me.btnEditt.BackColor = System.Drawing.Color.Transparent
        Me.btnEditt.BorderRadius = 10
        Me.btnEditt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditt.FillColor = System.Drawing.Color.Gray
        Me.btnEditt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditt.ForeColor = System.Drawing.Color.White
        Me.btnEditt.Image = CType(resources.GetObject("btnEditt.Image"), System.Drawing.Image)
        Me.btnEditt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEditt.Location = New System.Drawing.Point(172, 311)
        Me.btnEditt.Name = "btnEditt"
        Me.btnEditt.Size = New System.Drawing.Size(121, 37)
        Me.btnEditt.TabIndex = 37
        Me.btnEditt.Text = "   EDIT"
        '
        'btnSavee
        '
        Me.btnSavee.BackColor = System.Drawing.Color.Transparent
        Me.btnSavee.BorderRadius = 10
        Me.btnSavee.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSavee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSavee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSavee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSavee.FillColor = System.Drawing.Color.Gray
        Me.btnSavee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSavee.ForeColor = System.Drawing.Color.White
        Me.btnSavee.Image = CType(resources.GetObject("btnSavee.Image"), System.Drawing.Image)
        Me.btnSavee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSavee.Location = New System.Drawing.Point(35, 311)
        Me.btnSavee.Name = "btnSavee"
        Me.btnSavee.Size = New System.Drawing.Size(121, 37)
        Me.btnSavee.TabIndex = 36
        Me.btnSavee.Text = "   SAVE"
        '
        'txtItemName
        '
        Me.txtItemName.BorderRadius = 10
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.DefaultText = ""
        Me.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.FillColor = System.Drawing.Color.Gainsboro
        Me.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.txtItemName.ForeColor = System.Drawing.Color.Black
        Me.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.Location = New System.Drawing.Point(19, 75)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.PlaceholderText = ""
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.Size = New System.Drawing.Size(304, 30)
        Me.txtItemName.TabIndex = 35
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderRadius = 10
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FillColor = System.Drawing.Color.Gainsboro
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(19, 134)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.PlaceholderText = ""
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.Size = New System.Drawing.Size(304, 30)
        Me.txtQuantity.TabIndex = 34
        '
        'txtPrice
        '
        Me.txtPrice.BorderRadius = 10
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FillColor = System.Drawing.Color.Gainsboro
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(19, 187)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.Size = New System.Drawing.Size(304, 30)
        Me.txtPrice.TabIndex = 33
        '
        'cboCategories
        '
        Me.cboCategories.BackColor = System.Drawing.Color.Transparent
        Me.cboCategories.BorderColor = System.Drawing.Color.Gainsboro
        Me.cboCategories.BorderRadius = 10
        Me.cboCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategories.FillColor = System.Drawing.Color.LightGray
        Me.cboCategories.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCategories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCategories.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategories.ForeColor = System.Drawing.Color.Black
        Me.cboCategories.ItemHeight = 30
        Me.cboCategories.Items.AddRange(New Object() {"Casual", "Semi-Formal", "Formal", "Sports", "Travel", "Kid", "Summer Type", "Winter ", "Fall", "Streetwear"})
        Me.cboCategories.Location = New System.Drawing.Point(19, 246)
        Me.cboCategories.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.Size = New System.Drawing.Size(305, 36)
        Me.cboCategories.TabIndex = 32
        '
        'lblCategories
        '
        Me.lblCategories.AutoSize = True
        Me.lblCategories.BackColor = System.Drawing.Color.Transparent
        Me.lblCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCategories.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategories.Location = New System.Drawing.Point(15, 222)
        Me.lblCategories.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategories.Name = "lblCategories"
        Me.lblCategories.Size = New System.Drawing.Size(115, 22)
        Me.lblCategories.TabIndex = 31
        Me.lblCategories.Text = "CATEGORIES"
        Me.lblCategories.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPrice.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(15, 162)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(61, 22)
        Me.lblPrice.TabIndex = 29
        Me.lblPrice.Text = "PRICE"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblQuantity.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(15, 104)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(93, 22)
        Me.lblQuantity.TabIndex = 27
        Me.lblQuantity.Text = "QUANTITY"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblItemName.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(15, 46)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(104, 22)
        Me.lblItemName.TabIndex = 20
        Me.lblItemName.Text = "ITEM NAME"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Guna2MessageDialog1
        '
        Me.Guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.Guna2MessageDialog1.Caption = Nothing
        Me.Guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.Guna2MessageDialog1.Parent = Nothing
        Me.Guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.Guna2MessageDialog1.Text = Nothing
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 637)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblManageItems As Label
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents pbRefresh As PictureBox
    Friend WithEvents ItemDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblItemName As Label
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Guna2MessageDialog1 As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents cboCategories As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblCategories As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSavee As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearr As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeletee As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogOutt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
