<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FormDragPanel = New System.Windows.Forms.Panel()
        Me.FormDragLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.FormDrag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.LanguageChoose = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.PostData = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Headers = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Url = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RequestType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.RequestLIB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BuildButton = New Guna.UI2.WinForms.Guna2Button()
        Me.RequestInfo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelDrag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.CopyButton = New Guna.UI2.WinForms.Guna2Button()
        Me.HeadersListBox = New System.Windows.Forms.ListBox()
        Me.URL2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Icon = New System.Windows.Forms.PictureBox()
        Me.About = New Guna.UI2.WinForms.Guna2Button()
        Me.Minimization = New Guna.UI2.WinForms.Guna2Button()
        Me.FormDragPanel.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        CType(Me.Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormDragPanel
        '
        Me.FormDragPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormDragPanel.Controls.Add(Me.Minimization)
        Me.FormDragPanel.Controls.Add(Me.Icon)
        Me.FormDragPanel.Controls.Add(Me.FormDragLabel)
        Me.FormDragPanel.Controls.Add(Me.CloseButton)
        Me.FormDragPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormDragPanel.Location = New System.Drawing.Point(0, 0)
        Me.FormDragPanel.Name = "FormDragPanel"
        Me.FormDragPanel.Size = New System.Drawing.Size(725, 23)
        Me.FormDragPanel.TabIndex = 0
        '
        'FormDragLabel
        '
        Me.FormDragLabel.AutoSize = True
        Me.FormDragLabel.Location = New System.Drawing.Point(21, 5)
        Me.FormDragLabel.Name = "FormDragLabel"
        Me.FormDragLabel.Size = New System.Drawing.Size(175, 13)
        Me.FormDragLabel.TabIndex = 1
        Me.FormDragLabel.Text = "RequestBuilder V1.0.0 | By Ronih"
        '
        'CloseButton
        '
        Me.CloseButton.Animated = True
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CloseButton.CheckedState.Parent = Me.CloseButton
        Me.CloseButton.CustomImages.Parent = Me.CloseButton
        Me.CloseButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.HoverState.Parent = Me.CloseButton
        Me.CloseButton.Location = New System.Drawing.Point(702, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(23, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "X"
        '
        'FormDrag
        '
        Me.FormDrag.TargetControl = Me.FormDragPanel
        '
        'LanguageChoose
        '
        Me.LanguageChoose.Animated = True
        Me.LanguageChoose.BackColor = System.Drawing.Color.Transparent
        Me.LanguageChoose.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LanguageChoose.DisplayMember = "Language"
        Me.LanguageChoose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LanguageChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LanguageChoose.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LanguageChoose.FocusedColor = System.Drawing.Color.Empty
        Me.LanguageChoose.FocusedState.Parent = Me.LanguageChoose
        Me.LanguageChoose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LanguageChoose.ForeColor = System.Drawing.Color.White
        Me.LanguageChoose.FormattingEnabled = True
        Me.LanguageChoose.HoverState.Parent = Me.LanguageChoose
        Me.LanguageChoose.ItemHeight = 20
        Me.LanguageChoose.Items.AddRange(New Object() {"Visual Basic", "Python", "C#", "cURL"})
        Me.LanguageChoose.ItemsAppearance.Parent = Me.LanguageChoose
        Me.LanguageChoose.Location = New System.Drawing.Point(4, 3)
        Me.LanguageChoose.Name = "LanguageChoose"
        Me.LanguageChoose.ShadowDecoration.Parent = Me.LanguageChoose
        Me.LanguageChoose.Size = New System.Drawing.Size(131, 26)
        Me.LanguageChoose.TabIndex = 1
        Me.LanguageChoose.Tag = "Language"
        Me.LanguageChoose.ValueMember = "Language"
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.LeftPanel.Controls.Add(Me.PostData)
        Me.LeftPanel.Controls.Add(Me.Headers)
        Me.LeftPanel.Controls.Add(Me.Url)
        Me.LeftPanel.Controls.Add(Me.RequestType)
        Me.LeftPanel.Controls.Add(Me.URL2)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 23)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(319, 407)
        Me.LeftPanel.TabIndex = 2
        '
        'PostData
        '
        Me.PostData.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PostData.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PostData.DefaultText = ""
        Me.PostData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PostData.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.PostData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PostData.DisabledState.Parent = Me.PostData
        Me.PostData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PostData.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.PostData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PostData.FocusedState.Parent = Me.PostData
        Me.PostData.ForeColor = System.Drawing.Color.White
        Me.PostData.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PostData.HoverState.Parent = Me.PostData
        Me.PostData.Location = New System.Drawing.Point(4, 279)
        Me.PostData.Multiline = True
        Me.PostData.Name = "PostData"
        Me.PostData.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PostData.PlaceholderText = "Post Data"
        Me.PostData.SelectedText = ""
        Me.PostData.ShadowDecoration.Parent = Me.PostData
        Me.PostData.Size = New System.Drawing.Size(311, 124)
        Me.PostData.TabIndex = 6
        '
        'Headers
        '
        Me.Headers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Headers.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Headers.DefaultText = ""
        Me.Headers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Headers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Headers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Headers.DisabledState.Parent = Me.Headers
        Me.Headers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Headers.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Headers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Headers.FocusedState.Parent = Me.Headers
        Me.Headers.ForeColor = System.Drawing.Color.White
        Me.Headers.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Headers.HoverState.Parent = Me.Headers
        Me.Headers.Location = New System.Drawing.Point(4, 32)
        Me.Headers.Multiline = True
        Me.Headers.Name = "Headers"
        Me.Headers.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Headers.PlaceholderText = "Headers"
        Me.Headers.SelectedText = ""
        Me.Headers.ShadowDecoration.Parent = Me.Headers
        Me.Headers.Size = New System.Drawing.Size(311, 244)
        Me.Headers.TabIndex = 6
        '
        'Url
        '
        Me.Url.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Url.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Url.DefaultText = ""
        Me.Url.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Url.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Url.DisabledState.Parent = Me.Url
        Me.Url.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Url.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Url.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Url.FocusedState.Parent = Me.Url
        Me.Url.ForeColor = System.Drawing.Color.White
        Me.Url.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Url.HoverState.Parent = Me.Url
        Me.Url.Location = New System.Drawing.Point(97, 3)
        Me.Url.Name = "Url"
        Me.Url.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Url.PlaceholderText = "URL"
        Me.Url.SelectedText = ""
        Me.Url.ShadowDecoration.Parent = Me.Url
        Me.Url.Size = New System.Drawing.Size(216, 26)
        Me.Url.TabIndex = 5
        '
        'RequestType
        '
        Me.RequestType.Animated = True
        Me.RequestType.BackColor = System.Drawing.Color.Transparent
        Me.RequestType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.RequestType.DisplayMember = "Language"
        Me.RequestType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RequestType.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.RequestType.FocusedColor = System.Drawing.Color.Empty
        Me.RequestType.FocusedState.Parent = Me.RequestType
        Me.RequestType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RequestType.ForeColor = System.Drawing.Color.White
        Me.RequestType.FormattingEnabled = True
        Me.RequestType.HoverState.Parent = Me.RequestType
        Me.RequestType.ItemHeight = 20
        Me.RequestType.Items.AddRange(New Object() {"GET", "POST"})
        Me.RequestType.ItemsAppearance.Parent = Me.RequestType
        Me.RequestType.Location = New System.Drawing.Point(4, 3)
        Me.RequestType.Name = "RequestType"
        Me.RequestType.ShadowDecoration.Parent = Me.RequestType
        Me.RequestType.Size = New System.Drawing.Size(90, 26)
        Me.RequestType.TabIndex = 4
        Me.RequestType.Tag = "Language"
        Me.RequestType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RequestType.ValueMember = "Language"
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.RequestLIB)
        Me.TopPanel.Controls.Add(Me.BuildButton)
        Me.TopPanel.Controls.Add(Me.LanguageChoose)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(319, 23)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(406, 32)
        Me.TopPanel.TabIndex = 3
        '
        'RequestLIB
        '
        Me.RequestLIB.Animated = True
        Me.RequestLIB.BackColor = System.Drawing.Color.Transparent
        Me.RequestLIB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.RequestLIB.DisplayMember = "Language"
        Me.RequestLIB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RequestLIB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RequestLIB.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.RequestLIB.FocusedColor = System.Drawing.Color.Empty
        Me.RequestLIB.FocusedState.Parent = Me.RequestLIB
        Me.RequestLIB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RequestLIB.ForeColor = System.Drawing.Color.White
        Me.RequestLIB.FormattingEnabled = True
        Me.RequestLIB.HoverState.Parent = Me.RequestLIB
        Me.RequestLIB.ItemHeight = 20
        Me.RequestLIB.Items.AddRange(New Object() {"Normal", "RestSharp", "PyCurl"})
        Me.RequestLIB.ItemsAppearance.Parent = Me.RequestLIB
        Me.RequestLIB.Location = New System.Drawing.Point(137, 3)
        Me.RequestLIB.Name = "RequestLIB"
        Me.RequestLIB.ShadowDecoration.Parent = Me.RequestLIB
        Me.RequestLIB.Size = New System.Drawing.Size(131, 26)
        Me.RequestLIB.TabIndex = 9
        Me.RequestLIB.Tag = "Language"
        Me.RequestLIB.ValueMember = "Language"
        '
        'BuildButton
        '
        Me.BuildButton.Animated = True
        Me.BuildButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BuildButton.CheckedState.Parent = Me.BuildButton
        Me.BuildButton.CustomImages.Parent = Me.BuildButton
        Me.BuildButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BuildButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BuildButton.ForeColor = System.Drawing.Color.White
        Me.BuildButton.HoverState.Parent = Me.BuildButton
        Me.BuildButton.Location = New System.Drawing.Point(270, 3)
        Me.BuildButton.Name = "BuildButton"
        Me.BuildButton.ShadowDecoration.Parent = Me.BuildButton
        Me.BuildButton.Size = New System.Drawing.Size(131, 26)
        Me.BuildButton.TabIndex = 4
        Me.BuildButton.Text = "Build"
        '
        'RequestInfo
        '
        Me.RequestInfo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.RequestInfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RequestInfo.DefaultText = ""
        Me.RequestInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RequestInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RequestInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RequestInfo.DisabledState.Parent = Me.RequestInfo
        Me.RequestInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RequestInfo.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.RequestInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.RequestInfo.FocusedState.Parent = Me.RequestInfo
        Me.RequestInfo.ForeColor = System.Drawing.Color.White
        Me.RequestInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.RequestInfo.HoverState.Parent = Me.RequestInfo
        Me.RequestInfo.Location = New System.Drawing.Point(323, 55)
        Me.RequestInfo.Multiline = True
        Me.RequestInfo.Name = "RequestInfo"
        Me.RequestInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RequestInfo.PlaceholderText = "Request Info"
        Me.RequestInfo.ReadOnly = True
        Me.RequestInfo.SelectedText = ""
        Me.RequestInfo.ShadowDecoration.Parent = Me.RequestInfo
        Me.RequestInfo.Size = New System.Drawing.Size(398, 341)
        Me.RequestInfo.TabIndex = 7
        '
        'LabelDrag
        '
        Me.LabelDrag.TargetControl = Me.FormDragLabel
        '
        'CopyButton
        '
        Me.CopyButton.Animated = True
        Me.CopyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CopyButton.CheckedState.Parent = Me.CopyButton
        Me.CopyButton.CustomImages.Parent = Me.CopyButton
        Me.CopyButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CopyButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CopyButton.ForeColor = System.Drawing.Color.White
        Me.CopyButton.HoverState.Parent = Me.CopyButton
        Me.CopyButton.Location = New System.Drawing.Point(323, 400)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.ShadowDecoration.Parent = Me.CopyButton
        Me.CopyButton.Size = New System.Drawing.Size(263, 26)
        Me.CopyButton.TabIndex = 8
        Me.CopyButton.Text = "Copy"
        '
        'HeadersListBox
        '
        Me.HeadersListBox.FormattingEnabled = True
        Me.HeadersListBox.Location = New System.Drawing.Point(726, 138)
        Me.HeadersListBox.Name = "HeadersListBox"
        Me.HeadersListBox.Size = New System.Drawing.Size(120, 95)
        Me.HeadersListBox.TabIndex = 7
        '
        'URL2
        '
        Me.URL2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.URL2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.URL2.DefaultText = ""
        Me.URL2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.URL2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.URL2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.URL2.DisabledState.Parent = Me.URL2
        Me.URL2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.URL2.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.URL2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.URL2.FocusedState.Parent = Me.URL2
        Me.URL2.ForeColor = System.Drawing.Color.White
        Me.URL2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.URL2.HoverState.Parent = Me.URL2
        Me.URL2.Location = New System.Drawing.Point(209, 3)
        Me.URL2.Name = "URL2"
        Me.URL2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.URL2.PlaceholderText = "URL2"
        Me.URL2.SelectedText = ""
        Me.URL2.ShadowDecoration.Parent = Me.URL2
        Me.URL2.Size = New System.Drawing.Size(105, 26)
        Me.URL2.TabIndex = 9
        '
        'Icon
        '
        Me.Icon.Image = CType(resources.GetObject("Icon.Image"), System.Drawing.Image)
        Me.Icon.Location = New System.Drawing.Point(2, 2)
        Me.Icon.Name = "Icon"
        Me.Icon.Size = New System.Drawing.Size(18, 18)
        Me.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Icon.TabIndex = 10
        Me.Icon.TabStop = False
        '
        'About
        '
        Me.About.Animated = True
        Me.About.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.About.CheckedState.Parent = Me.About
        Me.About.CustomImages.Parent = Me.About
        Me.About.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.About.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.About.ForeColor = System.Drawing.Color.White
        Me.About.HoverState.Parent = Me.About
        Me.About.Location = New System.Drawing.Point(590, 400)
        Me.About.Name = "About"
        Me.About.ShadowDecoration.Parent = Me.About
        Me.About.Size = New System.Drawing.Size(130, 26)
        Me.About.TabIndex = 9
        Me.About.Text = "About"
        '
        'Minimization
        '
        Me.Minimization.Animated = True
        Me.Minimization.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Minimization.CheckedState.Parent = Me.Minimization
        Me.Minimization.CustomImages.Parent = Me.Minimization
        Me.Minimization.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Minimization.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Minimization.ForeColor = System.Drawing.Color.White
        Me.Minimization.HoverState.Parent = Me.Minimization
        Me.Minimization.Location = New System.Drawing.Point(679, 0)
        Me.Minimization.Name = "Minimization"
        Me.Minimization.ShadowDecoration.Parent = Me.Minimization
        Me.Minimization.Size = New System.Drawing.Size(23, 23)
        Me.Minimization.TabIndex = 10
        Me.Minimization.Text = "–"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(725, 430)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.HeadersListBox)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.RequestInfo)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.FormDragPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "RequestBuilder V1.0.0 - Ronih"
        Me.FormDragPanel.ResumeLayout(False)
        Me.FormDragPanel.PerformLayout()
        Me.LeftPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        CType(Me.Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormDragPanel As Panel
    Friend WithEvents FormDragLabel As Label
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FormDrag As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents LanguageChoose As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents PostData As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Headers As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Url As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RequestType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TopPanel As Panel
    Friend WithEvents BuildButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RequestInfo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelDrag As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents CopyButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RequestLIB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents HeadersListBox As ListBox
    Friend WithEvents URL2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Icon As PictureBox
    Friend WithEvents About As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Minimization As Guna.UI2.WinForms.Guna2Button
End Class
