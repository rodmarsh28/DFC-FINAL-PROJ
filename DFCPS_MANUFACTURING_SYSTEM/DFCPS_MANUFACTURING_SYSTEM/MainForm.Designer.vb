﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBLID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBLNAME = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBLPOS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANAGEACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTERACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYSTEMREPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REQUESTEDFORAPPROVALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYSTEMSETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPurchasing = New MetroFramework.Controls.MetroButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSales = New MetroFramework.Controls.MetroButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProd = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHR = New MetroFramework.Controls.MetroButton()
        Me.btnInventory = New MetroFramework.Controls.MetroButton()
        Me.btnAccounting = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.LBLID, Me.ToolStripStatusLabel3, Me.LBLNAME, Me.ToolStripStatusLabel5, Me.LBLPOS})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 610)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1263, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel1.Text = "USER ID :"
        '
        'LBLID
        '
        Me.LBLID.ForeColor = System.Drawing.Color.White
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(18, 17)
        Me.LBLID.Text = "ID"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel3.Text = "NAME :"
        '
        'LBLNAME
        '
        Me.LBLNAME.ForeColor = System.Drawing.Color.White
        Me.LBLNAME.Name = "LBLNAME"
        Me.LBLNAME.Size = New System.Drawing.Size(41, 17)
        Me.LBLNAME.Text = "NAME"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabel5.Text = "POSITION :"
        '
        'LBLPOS
        '
        Me.LBLPOS.ForeColor = System.Drawing.Color.White
        Me.LBLPOS.Name = "LBLPOS"
        Me.LBLPOS.Size = New System.Drawing.Size(59, 17)
        Me.LBLPOS.Text = "POSITION"
        '
        'ACCOUNTToolStripMenuItem
        '
        Me.ACCOUNTToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ACCOUNTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANAGEACCOUNTToolStripMenuItem, Me.REGISTERACCOUNTToolStripMenuItem})
        Me.ACCOUNTToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ACCOUNTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ACCOUNTToolStripMenuItem.Name = "ACCOUNTToolStripMenuItem"
        Me.ACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.ACCOUNTToolStripMenuItem.Text = "ACCOUNT"
        '
        'MANAGEACCOUNTToolStripMenuItem
        '
        Me.MANAGEACCOUNTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MANAGEACCOUNTToolStripMenuItem.Name = "MANAGEACCOUNTToolStripMenuItem"
        Me.MANAGEACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.MANAGEACCOUNTToolStripMenuItem.Text = "MANAGE ACCOUNTS"
        '
        'REGISTERACCOUNTToolStripMenuItem
        '
        Me.REGISTERACCOUNTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.REGISTERACCOUNTToolStripMenuItem.Name = "REGISTERACCOUNTToolStripMenuItem"
        Me.REGISTERACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.REGISTERACCOUNTToolStripMenuItem.Text = "REGISTER ACCOUNTS"
        '
        'SYSTEMREPORTSToolStripMenuItem
        '
        Me.SYSTEMREPORTSToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SYSTEMREPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTSToolStripMenuItem, Me.LOGSToolStripMenuItem, Me.REQUESTEDFORAPPROVALToolStripMenuItem})
        Me.SYSTEMREPORTSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SYSTEMREPORTSToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SYSTEMREPORTSToolStripMenuItem.Name = "SYSTEMREPORTSToolStripMenuItem"
        Me.SYSTEMREPORTSToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.SYSTEMREPORTSToolStripMenuItem.Text = "SYSTEM"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'LOGSToolStripMenuItem
        '
        Me.LOGSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LOGSToolStripMenuItem.Name = "LOGSToolStripMenuItem"
        Me.LOGSToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.LOGSToolStripMenuItem.Text = "LOGS"
        '
        'REQUESTEDFORAPPROVALToolStripMenuItem
        '
        Me.REQUESTEDFORAPPROVALToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TRANSACTIONToolStripMenuItem})
        Me.REQUESTEDFORAPPROVALToolStripMenuItem.Name = "REQUESTEDFORAPPROVALToolStripMenuItem"
        Me.REQUESTEDFORAPPROVALToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.REQUESTEDFORAPPROVALToolStripMenuItem.Text = "REQUESTED FOR APPROVAL"
        '
        'TRANSACTIONToolStripMenuItem
        '
        Me.TRANSACTIONToolStripMenuItem.Name = "TRANSACTIONToolStripMenuItem"
        Me.TRANSACTIONToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.TRANSACTIONToolStripMenuItem.Text = "TRANSACTION"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ABOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SYSTEMSETTINGSToolStripMenuItem})
        Me.ABOUTToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ABOUTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.ABOUTToolStripMenuItem.Text = "OPTIONS"
        '
        'SYSTEMSETTINGSToolStripMenuItem
        '
        Me.SYSTEMSETTINGSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SYSTEMSETTINGSToolStripMenuItem.Name = "SYSTEMSETTINGSToolStripMenuItem"
        Me.SYSTEMSETTINGSToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.SYSTEMSETTINGSToolStripMenuItem.Text = "SYSTEM SETTINGS"
        '
        'ABOUTToolStripMenuItem1
        '
        Me.ABOUTToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ABOUTToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem})
        Me.ABOUTToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ABOUTToolStripMenuItem1.Name = "ABOUTToolStripMenuItem1"
        Me.ABOUTToolStripMenuItem1.Size = New System.Drawing.Size(76, 25)
        Me.ABOUTToolStripMenuItem1.Text = "ABOUT"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCOUNTToolStripMenuItem, Me.SYSTEMREPORTSToolStripMenuItem, Me.ABOUTToolStripMenuItem, Me.ABOUTToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1263, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 581)
        Me.Panel1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(41, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SIGN OUT"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(26, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EDIT ACCOUNT"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(26, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1063, 88)
        Me.Panel2.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "| DFC MANAGEMENT SYSTEM |"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnPurchasing)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnSales)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.btnProd)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnHR)
        Me.Panel3.Controls.Add(Me.btnInventory)
        Me.Panel3.Controls.Add(Me.btnAccounting)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(-36, -196)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1299, 828)
        Me.Panel3.TabIndex = 21
        '
        'btnPurchasing
        '
        Me.btnPurchasing.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPurchasing.AutoSize = True
        Me.btnPurchasing.BackgroundImage = CType(resources.GetObject("btnPurchasing.BackgroundImage"), System.Drawing.Image)
        Me.btnPurchasing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPurchasing.Location = New System.Drawing.Point(1015, 605)
        Me.btnPurchasing.Name = "btnPurchasing"
        Me.btnPurchasing.Size = New System.Drawing.Size(174, 181)
        Me.btnPurchasing.TabIndex = 29
        Me.btnPurchasing.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1011, 576)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Purchases / Requisition"
        '
        'btnSales
        '
        Me.btnSales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSales.AutoSize = True
        Me.btnSales.BackgroundImage = CType(resources.GetObject("btnSales.BackgroundImage"), System.Drawing.Image)
        Me.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSales.Location = New System.Drawing.Point(671, 606)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(174, 181)
        Me.btnSales.TabIndex = 27
        Me.btnSales.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(675, 574)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 31)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Sales"
        '
        'btnProd
        '
        Me.btnProd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnProd.AutoSize = True
        Me.btnProd.BackgroundImage = CType(resources.GetObject("btnProd.BackgroundImage"), System.Drawing.Image)
        Me.btnProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProd.Location = New System.Drawing.Point(320, 605)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(174, 181)
        Me.btnProd.TabIndex = 25
        Me.btnProd.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 571)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 31)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Production System"
        '
        'btnHR
        '
        Me.btnHR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHR.AutoSize = True
        Me.btnHR.BackgroundImage = CType(resources.GetObject("btnHR.BackgroundImage"), System.Drawing.Image)
        Me.btnHR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHR.ForeColor = System.Drawing.Color.Transparent
        Me.btnHR.Location = New System.Drawing.Point(1013, 356)
        Me.btnHR.Name = "btnHR"
        Me.btnHR.Size = New System.Drawing.Size(174, 181)
        Me.btnHR.TabIndex = 23
        Me.btnHR.UseSelectable = True
        '
        'btnInventory
        '
        Me.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInventory.AutoSize = True
        Me.btnInventory.BackgroundImage = CType(resources.GetObject("btnInventory.BackgroundImage"), System.Drawing.Image)
        Me.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInventory.Location = New System.Drawing.Point(669, 356)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(174, 181)
        Me.btnInventory.TabIndex = 22
        Me.btnInventory.UseSelectable = True
        '
        'btnAccounting
        '
        Me.btnAccounting.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAccounting.AutoSize = True
        Me.btnAccounting.BackgroundImage = CType(resources.GetObject("btnAccounting.BackgroundImage"), System.Drawing.Image)
        Me.btnAccounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAccounting.Location = New System.Drawing.Point(317, 356)
        Me.btnAccounting.Name = "btnAccounting"
        Me.btnAccounting.Size = New System.Drawing.Size(174, 181)
        Me.btnAccounting.TabIndex = 21
        Me.btnAccounting.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1011, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 31)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "HR Information System"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(671, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 31)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Inventory System"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Accounting"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 632)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LBLID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LBLNAME As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LBLPOS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MANAGEACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTERACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SYSTEMREPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SYSTEMSETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnPurchasing As MetroFramework.Controls.MetroButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSales As MetroFramework.Controls.MetroButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnProd As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnHR As MetroFramework.Controls.MetroButton
    Friend WithEvents btnInventory As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAccounting As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REQUESTEDFORAPPROVALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSACTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
