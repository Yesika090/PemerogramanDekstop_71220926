<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.lblExt = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.lblOri = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.lvOri = New System.Windows.Forms.ListView()
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttribute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvPreview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPages = New System.Windows.Forms.TabControl()
        Me.tpFilename = New System.Windows.Forms.TabPage()
        Me.cbCaseF = New System.Windows.Forms.ComboBox()
        Me.txtInsertAfterF = New System.Windows.Forms.TextBox()
        Me.txtWithThisF = New System.Windows.Forms.TextBox()
        Me.txtRightCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtLeftCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeF = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisF = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithF = New System.Windows.Forms.TextBox()
        Me.lblWithThisF = New System.Windows.Forms.Label()
        Me.lblCaseF = New System.Windows.Forms.Label()
        Me.rbRightCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterF = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithF = New System.Windows.Forms.RadioButton()
        Me.tpExtension = New System.Windows.Forms.TabPage()
        Me.cbCaseE = New System.Windows.Forms.ComboBox()
        Me.txtInsertAfterE = New System.Windows.Forms.TextBox()
        Me.txtWithThisE = New System.Windows.Forms.TextBox()
        Me.txtRightCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtLeftCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeE = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisE = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithE = New System.Windows.Forms.TextBox()
        Me.lblWithThisE = New System.Windows.Forms.Label()
        Me.lblCaseE = New System.Windows.Forms.Label()
        Me.rbRightCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterE = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithE = New System.Windows.Forms.RadioButton()
        Me.tpAutonumber = New System.Windows.Forms.TabPage()
        Me.gbWith = New System.Windows.Forms.GroupBox()
        Me.nudIncrementBy = New System.Windows.Forms.NumericUpDown()
        Me.nudStartWithNumber = New System.Windows.Forms.NumericUpDown()
        Me.lblIncrementBy = New System.Windows.Forms.Label()
        Me.lblStartWithNumber = New System.Windows.Forms.Label()
        Me.gbPlace = New System.Windows.Forms.GroupBox()
        Me.rbBeforeFileName = New System.Windows.Forms.RadioButton()
        Me.rbAfterFileName = New System.Windows.Forms.RadioButton()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.TabPages.SuspendLayout()
        Me.tpFilename.SuspendLayout()
        Me.tpExtension.SuspendLayout()
        Me.tpAutonumber.SuspendLayout()
        Me.gbWith.SuspendLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlace.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(32, 28)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(50, 20)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Path: "
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(88, 25)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(688, 26)
        Me.txtPath.TabIndex = 1
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(782, 25)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(75, 30)
        Me.btnPath.TabIndex = 2
        Me.btnPath.Text = "..."
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'lblExt
        '
        Me.lblExt.AutoSize = True
        Me.lblExt.Location = New System.Drawing.Point(863, 31)
        Me.lblExt.Name = "lblExt"
        Me.lblExt.Size = New System.Drawing.Size(61, 20)
        Me.lblExt.TabIndex = 3
        Me.lblExt.Text = "File Ext"
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(930, 28)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(74, 26)
        Me.txtExt.TabIndex = 4
        Me.txtExt.Text = "*.*"
        '
        'lblOri
        '
        Me.lblOri.AutoSize = True
        Me.lblOri.Location = New System.Drawing.Point(32, 76)
        Me.lblOri.Name = "lblOri"
        Me.lblOri.Size = New System.Drawing.Size(91, 20)
        Me.lblOri.TabIndex = 5
        Me.lblOri.Text = "Original File"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(523, 76)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(92, 20)
        Me.lblPreview.TabIndex = 6
        Me.lblPreview.Text = "Preview File"
        '
        'lvOri
        '
        Me.lvOri.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName, Me.chExtension, Me.chAttribute, Me.chCreated, Me.chAccessed, Me.chModified})
        Me.lvOri.GridLines = True
        Me.lvOri.HideSelection = False
        Me.lvOri.Location = New System.Drawing.Point(36, 99)
        Me.lvOri.Name = "lvOri"
        Me.lvOri.Size = New System.Drawing.Size(477, 265)
        Me.lvOri.TabIndex = 7
        Me.lvOri.UseCompatibleStateImageBehavior = False
        Me.lvOri.View = System.Windows.Forms.View.Details
        '
        'chFileName
        '
        Me.chFileName.Text = "File Name"
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        '
        'chAttribute
        '
        Me.chAttribute.Text = "Attributes"
        '
        'chCreated
        '
        Me.chCreated.Text = "Created"
        '
        'chAccessed
        '
        Me.chAccessed.Text = "Accessed"
        '
        'chModified
        '
        Me.chModified.Text = "Modified"
        '
        'lvPreview
        '
        Me.lvPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvPreview.GridLines = True
        Me.lvPreview.HideSelection = False
        Me.lvPreview.Location = New System.Drawing.Point(527, 99)
        Me.lvPreview.Name = "lvPreview"
        Me.lvPreview.Size = New System.Drawing.Size(477, 265)
        Me.lvPreview.TabIndex = 8
        Me.lvPreview.UseCompatibleStateImageBehavior = False
        Me.lvPreview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Extension"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Attributes"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Created"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Accessed"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Modified"
        '
        'TabPages
        '
        Me.TabPages.Controls.Add(Me.tpFilename)
        Me.TabPages.Controls.Add(Me.tpExtension)
        Me.TabPages.Controls.Add(Me.tpAutonumber)
        Me.TabPages.Location = New System.Drawing.Point(36, 370)
        Me.TabPages.Name = "TabPages"
        Me.TabPages.SelectedIndex = 0
        Me.TabPages.Size = New System.Drawing.Size(862, 174)
        Me.TabPages.TabIndex = 9
        '
        'tpFilename
        '
        Me.tpFilename.Controls.Add(Me.cbCaseF)
        Me.tpFilename.Controls.Add(Me.txtInsertAfterF)
        Me.tpFilename.Controls.Add(Me.txtWithThisF)
        Me.tpFilename.Controls.Add(Me.txtRightCropNCharF)
        Me.tpFilename.Controls.Add(Me.txtLeftCropNCharF)
        Me.tpFilename.Controls.Add(Me.txtInsertBeforeF)
        Me.tpFilename.Controls.Add(Me.txtReplaceThisF)
        Me.tpFilename.Controls.Add(Me.txtReplaceWithF)
        Me.tpFilename.Controls.Add(Me.lblWithThisF)
        Me.tpFilename.Controls.Add(Me.lblCaseF)
        Me.tpFilename.Controls.Add(Me.rbRightCropNCharF)
        Me.tpFilename.Controls.Add(Me.rbLeftCropNCharF)
        Me.tpFilename.Controls.Add(Me.rbInsertAfterF)
        Me.tpFilename.Controls.Add(Me.rbInsertBeforeF)
        Me.tpFilename.Controls.Add(Me.rbReplaceThisF)
        Me.tpFilename.Controls.Add(Me.rbReplaceWithF)
        Me.tpFilename.Location = New System.Drawing.Point(4, 29)
        Me.tpFilename.Name = "tpFilename"
        Me.tpFilename.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFilename.Size = New System.Drawing.Size(854, 141)
        Me.tpFilename.TabIndex = 0
        Me.tpFilename.Text = "Filename"
        Me.tpFilename.UseVisualStyleBackColor = True
        '
        'cbCaseF
        '
        Me.cbCaseF.FormattingEnabled = True
        Me.cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseF.Location = New System.Drawing.Point(664, 8)
        Me.cbCaseF.Name = "cbCaseF"
        Me.cbCaseF.Size = New System.Drawing.Size(156, 28)
        Me.cbCaseF.TabIndex = 15
        '
        'txtInsertAfterF
        '
        Me.txtInsertAfterF.Location = New System.Drawing.Point(573, 68)
        Me.txtInsertAfterF.Name = "txtInsertAfterF"
        Me.txtInsertAfterF.ReadOnly = True
        Me.txtInsertAfterF.Size = New System.Drawing.Size(247, 26)
        Me.txtInsertAfterF.TabIndex = 14
        '
        'txtWithThisF
        '
        Me.txtWithThisF.Location = New System.Drawing.Point(612, 38)
        Me.txtWithThisF.Name = "txtWithThisF"
        Me.txtWithThisF.ReadOnly = True
        Me.txtWithThisF.Size = New System.Drawing.Size(208, 26)
        Me.txtWithThisF.TabIndex = 13
        '
        'txtRightCropNCharF
        '
        Me.txtRightCropNCharF.Location = New System.Drawing.Point(612, 101)
        Me.txtRightCropNCharF.Name = "txtRightCropNCharF"
        Me.txtRightCropNCharF.ReadOnly = True
        Me.txtRightCropNCharF.Size = New System.Drawing.Size(156, 26)
        Me.txtRightCropNCharF.TabIndex = 12
        '
        'txtLeftCropNCharF
        '
        Me.txtLeftCropNCharF.Location = New System.Drawing.Point(173, 100)
        Me.txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        Me.txtLeftCropNCharF.ReadOnly = True
        Me.txtLeftCropNCharF.Size = New System.Drawing.Size(156, 26)
        Me.txtLeftCropNCharF.TabIndex = 11
        '
        'txtInsertBeforeF
        '
        Me.txtInsertBeforeF.Location = New System.Drawing.Point(173, 68)
        Me.txtInsertBeforeF.Name = "txtInsertBeforeF"
        Me.txtInsertBeforeF.ReadOnly = True
        Me.txtInsertBeforeF.Size = New System.Drawing.Size(247, 26)
        Me.txtInsertBeforeF.TabIndex = 10
        '
        'txtReplaceThisF
        '
        Me.txtReplaceThisF.Location = New System.Drawing.Point(173, 39)
        Me.txtReplaceThisF.Name = "txtReplaceThisF"
        Me.txtReplaceThisF.ReadOnly = True
        Me.txtReplaceThisF.Size = New System.Drawing.Size(326, 26)
        Me.txtReplaceThisF.TabIndex = 9
        '
        'txtReplaceWithF
        '
        Me.txtReplaceWithF.Location = New System.Drawing.Point(173, 9)
        Me.txtReplaceWithF.Name = "txtReplaceWithF"
        Me.txtReplaceWithF.ReadOnly = True
        Me.txtReplaceWithF.Size = New System.Drawing.Size(390, 26)
        Me.txtReplaceWithF.TabIndex = 8
        '
        'lblWithThisF
        '
        Me.lblWithThisF.AutoSize = True
        Me.lblWithThisF.Location = New System.Drawing.Point(522, 41)
        Me.lblWithThisF.Name = "lblWithThisF"
        Me.lblWithThisF.Size = New System.Drawing.Size(74, 20)
        Me.lblWithThisF.TabIndex = 7
        Me.lblWithThisF.Text = "With This"
        '
        'lblCaseF
        '
        Me.lblCaseF.AutoSize = True
        Me.lblCaseF.Location = New System.Drawing.Point(593, 12)
        Me.lblCaseF.Name = "lblCaseF"
        Me.lblCaseF.Size = New System.Drawing.Size(50, 20)
        Me.lblCaseF.TabIndex = 6
        Me.lblCaseF.Text = "Case:"
        '
        'rbRightCropNCharF
        '
        Me.rbRightCropNCharF.AutoSize = True
        Me.rbRightCropNCharF.Location = New System.Drawing.Point(449, 101)
        Me.rbRightCropNCharF.Name = "rbRightCropNCharF"
        Me.rbRightCropNCharF.Size = New System.Drawing.Size(161, 24)
        Me.rbRightCropNCharF.TabIndex = 5
        Me.rbRightCropNCharF.TabStop = True
        Me.rbRightCropNCharF.Text = "Right Crop n Char"
        Me.rbRightCropNCharF.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharF
        '
        Me.rbLeftCropNCharF.AutoSize = True
        Me.rbLeftCropNCharF.Location = New System.Drawing.Point(16, 99)
        Me.rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        Me.rbLeftCropNCharF.Size = New System.Drawing.Size(151, 24)
        Me.rbLeftCropNCharF.TabIndex = 4
        Me.rbLeftCropNCharF.TabStop = True
        Me.rbLeftCropNCharF.Text = "Left Crop n Char"
        Me.rbLeftCropNCharF.UseVisualStyleBackColor = True
        '
        'rbInsertAfterF
        '
        Me.rbInsertAfterF.AutoSize = True
        Me.rbInsertAfterF.Location = New System.Drawing.Point(449, 70)
        Me.rbInsertAfterF.Name = "rbInsertAfterF"
        Me.rbInsertAfterF.Size = New System.Drawing.Size(114, 24)
        Me.rbInsertAfterF.TabIndex = 3
        Me.rbInsertAfterF.TabStop = True
        Me.rbInsertAfterF.Text = "Insert After"
        Me.rbInsertAfterF.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeF
        '
        Me.rbInsertBeforeF.AutoSize = True
        Me.rbInsertBeforeF.Location = New System.Drawing.Point(16, 69)
        Me.rbInsertBeforeF.Name = "rbInsertBeforeF"
        Me.rbInsertBeforeF.Size = New System.Drawing.Size(127, 24)
        Me.rbInsertBeforeF.TabIndex = 2
        Me.rbInsertBeforeF.TabStop = True
        Me.rbInsertBeforeF.Text = "Insert Before"
        Me.rbInsertBeforeF.UseVisualStyleBackColor = True
        '
        'rbReplaceThisF
        '
        Me.rbReplaceThisF.AutoSize = True
        Me.rbReplaceThisF.Location = New System.Drawing.Point(16, 39)
        Me.rbReplaceThisF.Name = "rbReplaceThisF"
        Me.rbReplaceThisF.Size = New System.Drawing.Size(126, 24)
        Me.rbReplaceThisF.TabIndex = 1
        Me.rbReplaceThisF.TabStop = True
        Me.rbReplaceThisF.Text = "Replace This"
        Me.rbReplaceThisF.UseVisualStyleBackColor = True
        '
        'rbReplaceWithF
        '
        Me.rbReplaceWithF.AutoSize = True
        Me.rbReplaceWithF.Location = New System.Drawing.Point(16, 9)
        Me.rbReplaceWithF.Name = "rbReplaceWithF"
        Me.rbReplaceWithF.Size = New System.Drawing.Size(129, 24)
        Me.rbReplaceWithF.TabIndex = 0
        Me.rbReplaceWithF.TabStop = True
        Me.rbReplaceWithF.Text = "Replace With"
        Me.rbReplaceWithF.UseVisualStyleBackColor = True
        '
        'tpExtension
        '
        Me.tpExtension.Controls.Add(Me.cbCaseE)
        Me.tpExtension.Controls.Add(Me.txtInsertAfterE)
        Me.tpExtension.Controls.Add(Me.txtWithThisE)
        Me.tpExtension.Controls.Add(Me.txtRightCropNCharE)
        Me.tpExtension.Controls.Add(Me.txtLeftCropNCharE)
        Me.tpExtension.Controls.Add(Me.txtInsertBeforeE)
        Me.tpExtension.Controls.Add(Me.txtReplaceThisE)
        Me.tpExtension.Controls.Add(Me.txtReplaceWithE)
        Me.tpExtension.Controls.Add(Me.lblWithThisE)
        Me.tpExtension.Controls.Add(Me.lblCaseE)
        Me.tpExtension.Controls.Add(Me.rbRightCropNCharE)
        Me.tpExtension.Controls.Add(Me.rbLeftCropNCharE)
        Me.tpExtension.Controls.Add(Me.rbInsertAfterE)
        Me.tpExtension.Controls.Add(Me.rbInsertBeforeE)
        Me.tpExtension.Controls.Add(Me.rbReplaceThisE)
        Me.tpExtension.Controls.Add(Me.rbReplaceWithE)
        Me.tpExtension.Location = New System.Drawing.Point(4, 29)
        Me.tpExtension.Name = "tpExtension"
        Me.tpExtension.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExtension.Size = New System.Drawing.Size(854, 141)
        Me.tpExtension.TabIndex = 1
        Me.tpExtension.Text = "Extension"
        Me.tpExtension.UseVisualStyleBackColor = True
        '
        'cbCaseE
        '
        Me.cbCaseE.FormattingEnabled = True
        Me.cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseE.Location = New System.Drawing.Point(673, 11)
        Me.cbCaseE.Name = "cbCaseE"
        Me.cbCaseE.Size = New System.Drawing.Size(156, 28)
        Me.cbCaseE.TabIndex = 31
        '
        'txtInsertAfterE
        '
        Me.txtInsertAfterE.Location = New System.Drawing.Point(582, 71)
        Me.txtInsertAfterE.Name = "txtInsertAfterE"
        Me.txtInsertAfterE.ReadOnly = True
        Me.txtInsertAfterE.Size = New System.Drawing.Size(247, 26)
        Me.txtInsertAfterE.TabIndex = 30
        '
        'txtWithThisE
        '
        Me.txtWithThisE.Location = New System.Drawing.Point(621, 41)
        Me.txtWithThisE.Name = "txtWithThisE"
        Me.txtWithThisE.ReadOnly = True
        Me.txtWithThisE.Size = New System.Drawing.Size(208, 26)
        Me.txtWithThisE.TabIndex = 29
        '
        'txtRightCropNCharE
        '
        Me.txtRightCropNCharE.Location = New System.Drawing.Point(621, 104)
        Me.txtRightCropNCharE.Name = "txtRightCropNCharE"
        Me.txtRightCropNCharE.ReadOnly = True
        Me.txtRightCropNCharE.Size = New System.Drawing.Size(156, 26)
        Me.txtRightCropNCharE.TabIndex = 28
        '
        'txtLeftCropNCharE
        '
        Me.txtLeftCropNCharE.Location = New System.Drawing.Point(182, 103)
        Me.txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        Me.txtLeftCropNCharE.ReadOnly = True
        Me.txtLeftCropNCharE.Size = New System.Drawing.Size(156, 26)
        Me.txtLeftCropNCharE.TabIndex = 27
        '
        'txtInsertBeforeE
        '
        Me.txtInsertBeforeE.Location = New System.Drawing.Point(182, 71)
        Me.txtInsertBeforeE.Name = "txtInsertBeforeE"
        Me.txtInsertBeforeE.ReadOnly = True
        Me.txtInsertBeforeE.Size = New System.Drawing.Size(247, 26)
        Me.txtInsertBeforeE.TabIndex = 26
        '
        'txtReplaceThisE
        '
        Me.txtReplaceThisE.Location = New System.Drawing.Point(182, 42)
        Me.txtReplaceThisE.Name = "txtReplaceThisE"
        Me.txtReplaceThisE.ReadOnly = True
        Me.txtReplaceThisE.Size = New System.Drawing.Size(326, 26)
        Me.txtReplaceThisE.TabIndex = 25
        '
        'txtReplaceWithE
        '
        Me.txtReplaceWithE.Location = New System.Drawing.Point(182, 12)
        Me.txtReplaceWithE.Name = "txtReplaceWithE"
        Me.txtReplaceWithE.ReadOnly = True
        Me.txtReplaceWithE.Size = New System.Drawing.Size(390, 26)
        Me.txtReplaceWithE.TabIndex = 24
        '
        'lblWithThisE
        '
        Me.lblWithThisE.AutoSize = True
        Me.lblWithThisE.Location = New System.Drawing.Point(531, 44)
        Me.lblWithThisE.Name = "lblWithThisE"
        Me.lblWithThisE.Size = New System.Drawing.Size(74, 20)
        Me.lblWithThisE.TabIndex = 23
        Me.lblWithThisE.Text = "With This"
        '
        'lblCaseE
        '
        Me.lblCaseE.AutoSize = True
        Me.lblCaseE.Location = New System.Drawing.Point(602, 15)
        Me.lblCaseE.Name = "lblCaseE"
        Me.lblCaseE.Size = New System.Drawing.Size(50, 20)
        Me.lblCaseE.TabIndex = 22
        Me.lblCaseE.Text = "Case:"
        '
        'rbRightCropNCharE
        '
        Me.rbRightCropNCharE.AutoSize = True
        Me.rbRightCropNCharE.Location = New System.Drawing.Point(458, 104)
        Me.rbRightCropNCharE.Name = "rbRightCropNCharE"
        Me.rbRightCropNCharE.Size = New System.Drawing.Size(161, 24)
        Me.rbRightCropNCharE.TabIndex = 21
        Me.rbRightCropNCharE.TabStop = True
        Me.rbRightCropNCharE.Text = "Right Crop n Char"
        Me.rbRightCropNCharE.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharE
        '
        Me.rbLeftCropNCharE.AutoSize = True
        Me.rbLeftCropNCharE.Location = New System.Drawing.Point(25, 102)
        Me.rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        Me.rbLeftCropNCharE.Size = New System.Drawing.Size(151, 24)
        Me.rbLeftCropNCharE.TabIndex = 20
        Me.rbLeftCropNCharE.TabStop = True
        Me.rbLeftCropNCharE.Text = "Left Crop n Char"
        Me.rbLeftCropNCharE.UseVisualStyleBackColor = True
        '
        'rbInsertAfterE
        '
        Me.rbInsertAfterE.AutoSize = True
        Me.rbInsertAfterE.Location = New System.Drawing.Point(458, 73)
        Me.rbInsertAfterE.Name = "rbInsertAfterE"
        Me.rbInsertAfterE.Size = New System.Drawing.Size(114, 24)
        Me.rbInsertAfterE.TabIndex = 19
        Me.rbInsertAfterE.TabStop = True
        Me.rbInsertAfterE.Text = "Insert After"
        Me.rbInsertAfterE.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeE
        '
        Me.rbInsertBeforeE.AutoSize = True
        Me.rbInsertBeforeE.Location = New System.Drawing.Point(25, 72)
        Me.rbInsertBeforeE.Name = "rbInsertBeforeE"
        Me.rbInsertBeforeE.Size = New System.Drawing.Size(127, 24)
        Me.rbInsertBeforeE.TabIndex = 18
        Me.rbInsertBeforeE.TabStop = True
        Me.rbInsertBeforeE.Text = "Insert Before"
        Me.rbInsertBeforeE.UseVisualStyleBackColor = True
        '
        'rbReplaceThisE
        '
        Me.rbReplaceThisE.AutoSize = True
        Me.rbReplaceThisE.Location = New System.Drawing.Point(25, 42)
        Me.rbReplaceThisE.Name = "rbReplaceThisE"
        Me.rbReplaceThisE.Size = New System.Drawing.Size(126, 24)
        Me.rbReplaceThisE.TabIndex = 17
        Me.rbReplaceThisE.TabStop = True
        Me.rbReplaceThisE.Text = "Replace This"
        Me.rbReplaceThisE.UseVisualStyleBackColor = True
        '
        'rbReplaceWithE
        '
        Me.rbReplaceWithE.AutoSize = True
        Me.rbReplaceWithE.Location = New System.Drawing.Point(25, 12)
        Me.rbReplaceWithE.Name = "rbReplaceWithE"
        Me.rbReplaceWithE.Size = New System.Drawing.Size(129, 24)
        Me.rbReplaceWithE.TabIndex = 16
        Me.rbReplaceWithE.TabStop = True
        Me.rbReplaceWithE.Text = "Replace With"
        Me.rbReplaceWithE.UseVisualStyleBackColor = True
        '
        'tpAutonumber
        '
        Me.tpAutonumber.Controls.Add(Me.gbWith)
        Me.tpAutonumber.Controls.Add(Me.gbPlace)
        Me.tpAutonumber.Location = New System.Drawing.Point(4, 29)
        Me.tpAutonumber.Name = "tpAutonumber"
        Me.tpAutonumber.Size = New System.Drawing.Size(854, 141)
        Me.tpAutonumber.TabIndex = 2
        Me.tpAutonumber.Text = "Autonumber"
        Me.tpAutonumber.UseVisualStyleBackColor = True
        '
        'gbWith
        '
        Me.gbWith.Controls.Add(Me.nudIncrementBy)
        Me.gbWith.Controls.Add(Me.nudStartWithNumber)
        Me.gbWith.Controls.Add(Me.lblIncrementBy)
        Me.gbWith.Controls.Add(Me.lblStartWithNumber)
        Me.gbWith.Location = New System.Drawing.Point(268, 7)
        Me.gbWith.Name = "gbWith"
        Me.gbWith.Size = New System.Drawing.Size(362, 122)
        Me.gbWith.TabIndex = 1
        Me.gbWith.TabStop = False
        Me.gbWith.Text = "With:"
        '
        'nudIncrementBy
        '
        Me.nudIncrementBy.Location = New System.Drawing.Point(193, 69)
        Me.nudIncrementBy.Name = "nudIncrementBy"
        Me.nudIncrementBy.Size = New System.Drawing.Size(120, 26)
        Me.nudIncrementBy.TabIndex = 3
        Me.nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudStartWithNumber
        '
        Me.nudStartWithNumber.Location = New System.Drawing.Point(193, 39)
        Me.nudStartWithNumber.Name = "nudStartWithNumber"
        Me.nudStartWithNumber.Size = New System.Drawing.Size(120, 26)
        Me.nudStartWithNumber.TabIndex = 2
        Me.nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblIncrementBy
        '
        Me.lblIncrementBy.AutoSize = True
        Me.lblIncrementBy.Location = New System.Drawing.Point(29, 72)
        Me.lblIncrementBy.Name = "lblIncrementBy"
        Me.lblIncrementBy.Size = New System.Drawing.Size(105, 20)
        Me.lblIncrementBy.TabIndex = 1
        Me.lblIncrementBy.Text = "Increment by:"
        '
        'lblStartWithNumber
        '
        Me.lblStartWithNumber.AutoSize = True
        Me.lblStartWithNumber.Location = New System.Drawing.Point(29, 39)
        Me.lblStartWithNumber.Name = "lblStartWithNumber"
        Me.lblStartWithNumber.Size = New System.Drawing.Size(138, 20)
        Me.lblStartWithNumber.TabIndex = 0
        Me.lblStartWithNumber.Text = "Start with number:"
        '
        'gbPlace
        '
        Me.gbPlace.Controls.Add(Me.rbBeforeFileName)
        Me.gbPlace.Controls.Add(Me.rbAfterFileName)
        Me.gbPlace.Location = New System.Drawing.Point(13, 7)
        Me.gbPlace.Name = "gbPlace"
        Me.gbPlace.Size = New System.Drawing.Size(230, 122)
        Me.gbPlace.TabIndex = 0
        Me.gbPlace.TabStop = False
        Me.gbPlace.Text = "Place:"
        '
        'rbBeforeFileName
        '
        Me.rbBeforeFileName.AutoSize = True
        Me.rbBeforeFileName.Location = New System.Drawing.Point(35, 72)
        Me.rbBeforeFileName.Name = "rbBeforeFileName"
        Me.rbBeforeFileName.Size = New System.Drawing.Size(151, 24)
        Me.rbBeforeFileName.TabIndex = 1
        Me.rbBeforeFileName.TabStop = True
        Me.rbBeforeFileName.Text = "Before Filename"
        Me.rbBeforeFileName.UseVisualStyleBackColor = True
        '
        'rbAfterFileName
        '
        Me.rbAfterFileName.AutoSize = True
        Me.rbAfterFileName.Location = New System.Drawing.Point(35, 39)
        Me.rbAfterFileName.Name = "rbAfterFileName"
        Me.rbAfterFileName.Size = New System.Drawing.Size(138, 24)
        Me.rbAfterFileName.TabIndex = 0
        Me.rbAfterFileName.TabStop = True
        Me.rbAfterFileName.Text = "After Filename"
        Me.rbAfterFileName.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(904, 406)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(100, 33)
        Me.btnPreview.TabIndex = 10
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(904, 460)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(100, 33)
        Me.btnRename.TabIndex = 11
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(904, 511)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(100, 33)
        Me.btnUndo.TabIndex = 12
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 557)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.TabPages)
        Me.Controls.Add(Me.lvPreview)
        Me.Controls.Add(Me.lvOri)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.lblOri)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.lblExt)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblPath)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mass Renamer"
        Me.TabPages.ResumeLayout(False)
        Me.tpFilename.ResumeLayout(False)
        Me.tpFilename.PerformLayout()
        Me.tpExtension.ResumeLayout(False)
        Me.tpExtension.PerformLayout()
        Me.tpAutonumber.ResumeLayout(False)
        Me.gbWith.ResumeLayout(False)
        Me.gbWith.PerformLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlace.ResumeLayout(False)
        Me.gbPlace.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TabPages As TabControl
    Friend WithEvents tpFilename As TabPage
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents tpExtension As TabPage
    Friend WithEvents tpAutonumber As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents lblCaseF As Label
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents lblCaseE As Label
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label
End Class
