<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrailerPrintDialog
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
        Me.CB_Length = New System.Windows.Forms.ComboBox()
        Me.TrailerLength = New System.Windows.Forms.Label()
        Me.L_TrailerModel = New System.Windows.Forms.Label()
        Me.CB_Trailer = New System.Windows.Forms.ComboBox()
        Me.L_VIN = New System.Windows.Forms.Label()
        Me.TrailerWidth = New System.Windows.Forms.Label()
        Me.TrailerHeight = New System.Windows.Forms.Label()
        Me.NoseConstruction = New System.Windows.Forms.Label()
        Me.AxleNumber = New System.Windows.Forms.Label()
        Me.AxleSize = New System.Windows.Forms.Label()
        Me.AxleSpacing = New System.Windows.Forms.Label()
        Me.FrameCrossMember = New System.Windows.Forms.Label()
        Me.AxleLocation = New System.Windows.Forms.Label()
        Me.CB_Width = New System.Windows.Forms.ComboBox()
        Me.CB_Height = New System.Windows.Forms.ComboBox()
        Me.CB_Nose = New System.Windows.Forms.ComboBox()
        Me.CB_AxleNo = New System.Windows.Forms.ComboBox()
        Me.CB_AxleSize = New System.Windows.Forms.ComboBox()
        Me.CB_AxleSpacing = New System.Windows.Forms.ComboBox()
        Me.CB_CrossMember = New System.Windows.Forms.ComboBox()
        Me.CB_AxleLoc = New System.Windows.Forms.ComboBox()
        Me.Print = New System.Windows.Forms.Button()
        Me.B_Exit = New System.Windows.Forms.Button()
        Me.B_PrintFrame = New System.Windows.Forms.Button()
        Me.B_PrintSideWall = New System.Windows.Forms.Button()
        Me.B_PrintRoof = New System.Windows.Forms.Button()
        Me.B_PrintFRW = New System.Windows.Forms.Button()
        Me.B_PrintRamp = New System.Windows.Forms.Button()
        Me.CB_RearDoorOpt = New System.Windows.Forms.ComboBox()
        Me.RearDoor = New System.Windows.Forms.Label()
        Me.CBox_CkVIN = New System.Windows.Forms.CheckBox()
        Me.CBox_Door = New System.Windows.Forms.CheckBox()
        Me.TB_CB_VIN = New System.Windows.Forms.TextBox()
        Me.CBox_5IN_TONGUE = New System.Windows.Forms.CheckBox()
        Me.B_PrintRRW = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_WallCrossMember = New System.Windows.Forms.ComboBox()
        Me.CB_RoofCrossMember = New System.Windows.Forms.ComboBox()
        Me.CBox_48Door = New System.Windows.Forms.CheckBox()
        Me.CBox_BeaverTail = New System.Windows.Forms.CheckBox()
        Me.B_PrintWoodList = New System.Windows.Forms.Button()
        Me.B_PrintMetalList = New System.Windows.Forms.Button()
        Me.CBox_Screwless = New System.Windows.Forms.CheckBox()
        Me.CBox_Color = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_CC = New System.Windows.Forms.ComboBox()
        Me.CB_TorsionAxle = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CB_Length
        '
        Me.CB_Length.FormattingEnabled = True
        Me.CB_Length.Items.AddRange(New Object() {"08", "10", "12", "14", "16"})
        Me.CB_Length.Location = New System.Drawing.Point(134, 119)
        Me.CB_Length.Name = "CB_Length"
        Me.CB_Length.Size = New System.Drawing.Size(121, 21)
        Me.CB_Length.TabIndex = 0
        Me.CB_Length.Text = "Length"
        '
        'TrailerLength
        '
        Me.TrailerLength.AutoSize = True
        Me.TrailerLength.Location = New System.Drawing.Point(27, 122)
        Me.TrailerLength.Name = "TrailerLength"
        Me.TrailerLength.Size = New System.Drawing.Size(94, 13)
        Me.TrailerLength.TabIndex = 1
        Me.TrailerLength.Tag = ""
        Me.TrailerLength.Text = "Trailer Length (FT)"
        '
        'L_TrailerModel
        '
        Me.L_TrailerModel.AutoSize = True
        Me.L_TrailerModel.Location = New System.Drawing.Point(56, 68)
        Me.L_TrailerModel.Name = "L_TrailerModel"
        Me.L_TrailerModel.Size = New System.Drawing.Size(68, 13)
        Me.L_TrailerModel.TabIndex = 3
        Me.L_TrailerModel.Text = "Trailer Model"
        '
        'CB_Trailer
        '
        Me.CB_Trailer.FormattingEnabled = True
        Me.CB_Trailer.Items.AddRange(New Object() {"RAVEN LITE CARGO (STEEL)", "RAVAN LITE CARGO (ALUMINUM)", "MSX", "SS (SUPER SPORT)"})
        Me.CB_Trailer.Location = New System.Drawing.Point(134, 65)
        Me.CB_Trailer.Name = "CB_Trailer"
        Me.CB_Trailer.Size = New System.Drawing.Size(180, 21)
        Me.CB_Trailer.TabIndex = 4
        Me.CB_Trailer.Text = "SELECT MODEL"
        '
        'L_VIN
        '
        Me.L_VIN.AutoSize = True
        Me.L_VIN.Location = New System.Drawing.Point(96, 41)
        Me.L_VIN.Name = "L_VIN"
        Me.L_VIN.Size = New System.Drawing.Size(25, 13)
        Me.L_VIN.TabIndex = 5
        Me.L_VIN.Text = "VIN"
        '
        'TrailerWidth
        '
        Me.TrailerWidth.AutoSize = True
        Me.TrailerWidth.Location = New System.Drawing.Point(32, 95)
        Me.TrailerWidth.Name = "TrailerWidth"
        Me.TrailerWidth.Size = New System.Drawing.Size(89, 13)
        Me.TrailerWidth.TabIndex = 7
        Me.TrailerWidth.Text = "Trailer Width (FT)"
        '
        'TrailerHeight
        '
        Me.TrailerHeight.AutoSize = True
        Me.TrailerHeight.Location = New System.Drawing.Point(29, 149)
        Me.TrailerHeight.Name = "TrailerHeight"
        Me.TrailerHeight.Size = New System.Drawing.Size(92, 13)
        Me.TrailerHeight.TabIndex = 8
        Me.TrailerHeight.Text = "Trailer Height (FT)"
        '
        'NoseConstruction
        '
        Me.NoseConstruction.AutoSize = True
        Me.NoseConstruction.Location = New System.Drawing.Point(27, 260)
        Me.NoseConstruction.Name = "NoseConstruction"
        Me.NoseConstruction.Size = New System.Drawing.Size(94, 13)
        Me.NoseConstruction.TabIndex = 9
        Me.NoseConstruction.Text = "Nose Construction"
        '
        'AxleNumber
        '
        Me.AxleNumber.AutoSize = True
        Me.AxleNumber.Location = New System.Drawing.Point(51, 359)
        Me.AxleNumber.Name = "AxleNumber"
        Me.AxleNumber.Size = New System.Drawing.Size(67, 13)
        Me.AxleNumber.TabIndex = 10
        Me.AxleNumber.Text = "Axle Number"
        '
        'AxleSize
        '
        Me.AxleSize.AutoSize = True
        Me.AxleSize.Location = New System.Drawing.Point(68, 387)
        Me.AxleSize.Name = "AxleSize"
        Me.AxleSize.Size = New System.Drawing.Size(50, 13)
        Me.AxleSize.TabIndex = 11
        Me.AxleSize.Text = "Axle Size"
        '
        'AxleSpacing
        '
        Me.AxleSpacing.AutoSize = True
        Me.AxleSpacing.Location = New System.Drawing.Point(49, 417)
        Me.AxleSpacing.Name = "AxleSpacing"
        Me.AxleSpacing.Size = New System.Drawing.Size(69, 13)
        Me.AxleSpacing.TabIndex = 12
        Me.AxleSpacing.Text = "Axle Spacing"
        '
        'FrameCrossMember
        '
        Me.FrameCrossMember.AutoSize = True
        Me.FrameCrossMember.Location = New System.Drawing.Point(15, 180)
        Me.FrameCrossMember.Name = "FrameCrossMember"
        Me.FrameCrossMember.Size = New System.Drawing.Size(106, 13)
        Me.FrameCrossMember.TabIndex = 13
        Me.FrameCrossMember.Text = "Frame Cross Member"
        '
        'AxleLocation
        '
        Me.AxleLocation.AutoSize = True
        Me.AxleLocation.Location = New System.Drawing.Point(47, 443)
        Me.AxleLocation.Name = "AxleLocation"
        Me.AxleLocation.Size = New System.Drawing.Size(71, 13)
        Me.AxleLocation.TabIndex = 14
        Me.AxleLocation.Text = "Axle Location"
        '
        'CB_Width
        '
        Me.CB_Width.FormattingEnabled = True
        Me.CB_Width.Items.AddRange(New Object() {"5.0", "6.0", "7.0"})
        Me.CB_Width.Location = New System.Drawing.Point(134, 92)
        Me.CB_Width.Name = "CB_Width"
        Me.CB_Width.Size = New System.Drawing.Size(121, 21)
        Me.CB_Width.TabIndex = 15
        Me.CB_Width.Text = "Width"
        '
        'CB_Height
        '
        Me.CB_Height.Enabled = False
        Me.CB_Height.FormattingEnabled = True
        Me.CB_Height.Items.AddRange(New Object() {"66", "72", "78"})
        Me.CB_Height.Location = New System.Drawing.Point(134, 146)
        Me.CB_Height.Name = "CB_Height"
        Me.CB_Height.Size = New System.Drawing.Size(121, 21)
        Me.CB_Height.TabIndex = 16
        Me.CB_Height.Text = "Height"
        '
        'CB_Nose
        '
        Me.CB_Nose.FormattingEnabled = True
        Me.CB_Nose.Items.AddRange(New Object() {"Flat Nose (+0)", "Wedge Nose (+2)"})
        Me.CB_Nose.Location = New System.Drawing.Point(134, 256)
        Me.CB_Nose.Name = "CB_Nose"
        Me.CB_Nose.Size = New System.Drawing.Size(121, 21)
        Me.CB_Nose.TabIndex = 17
        Me.CB_Nose.Text = "Nose Construction"
        '
        'CB_AxleNo
        '
        Me.CB_AxleNo.Enabled = False
        Me.CB_AxleNo.FormattingEnabled = True
        Me.CB_AxleNo.Items.AddRange(New Object() {"Single", "Double"})
        Me.CB_AxleNo.Location = New System.Drawing.Point(134, 355)
        Me.CB_AxleNo.Name = "CB_AxleNo"
        Me.CB_AxleNo.Size = New System.Drawing.Size(121, 21)
        Me.CB_AxleNo.TabIndex = 18
        Me.CB_AxleNo.Text = "Single"
        '
        'CB_AxleSize
        '
        Me.CB_AxleSize.Enabled = False
        Me.CB_AxleSize.FormattingEnabled = True
        Me.CB_AxleSize.Items.AddRange(New Object() {"3500"})
        Me.CB_AxleSize.Location = New System.Drawing.Point(134, 382)
        Me.CB_AxleSize.Name = "CB_AxleSize"
        Me.CB_AxleSize.Size = New System.Drawing.Size(121, 21)
        Me.CB_AxleSize.TabIndex = 19
        Me.CB_AxleSize.Text = "3500"
        '
        'CB_AxleSpacing
        '
        Me.CB_AxleSpacing.Enabled = False
        Me.CB_AxleSpacing.FormattingEnabled = True
        Me.CB_AxleSpacing.Items.AddRange(New Object() {"Standard"})
        Me.CB_AxleSpacing.Location = New System.Drawing.Point(134, 409)
        Me.CB_AxleSpacing.Name = "CB_AxleSpacing"
        Me.CB_AxleSpacing.Size = New System.Drawing.Size(121, 21)
        Me.CB_AxleSpacing.TabIndex = 20
        Me.CB_AxleSpacing.Text = "Standard"
        '
        'CB_CrossMember
        '
        Me.CB_CrossMember.FormattingEnabled = True
        Me.CB_CrossMember.Items.AddRange(New Object() {"16", "24"})
        Me.CB_CrossMember.Location = New System.Drawing.Point(134, 173)
        Me.CB_CrossMember.Name = "CB_CrossMember"
        Me.CB_CrossMember.Size = New System.Drawing.Size(121, 21)
        Me.CB_CrossMember.TabIndex = 21
        Me.CB_CrossMember.Text = "CenterDist"
        '
        'CB_AxleLoc
        '
        Me.CB_AxleLoc.Enabled = False
        Me.CB_AxleLoc.FormattingEnabled = True
        Me.CB_AxleLoc.Items.AddRange(New Object() {"60%"})
        Me.CB_AxleLoc.Location = New System.Drawing.Point(134, 436)
        Me.CB_AxleLoc.Name = "CB_AxleLoc"
        Me.CB_AxleLoc.Size = New System.Drawing.Size(121, 21)
        Me.CB_AxleLoc.TabIndex = 22
        Me.CB_AxleLoc.Text = "60%"
        '
        'Print
        '
        Me.Print.Location = New System.Drawing.Point(700, 362)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(158, 23)
        Me.Print.TabIndex = 23
        Me.Print.Text = "Print All Drawings"
        Me.Print.UseVisualStyleBackColor = True
        '
        'B_Exit
        '
        Me.B_Exit.Location = New System.Drawing.Point(760, 391)
        Me.B_Exit.Name = "B_Exit"
        Me.B_Exit.Size = New System.Drawing.Size(75, 23)
        Me.B_Exit.TabIndex = 24
        Me.B_Exit.Text = "Close"
        Me.B_Exit.UseVisualStyleBackColor = True
        '
        'B_PrintFrame
        '
        Me.B_PrintFrame.Location = New System.Drawing.Point(700, 95)
        Me.B_PrintFrame.Name = "B_PrintFrame"
        Me.B_PrintFrame.Size = New System.Drawing.Size(158, 23)
        Me.B_PrintFrame.TabIndex = 26
        Me.B_PrintFrame.Text = "Print Frame Drawing"
        Me.B_PrintFrame.UseVisualStyleBackColor = True
        '
        'B_PrintSideWall
        '
        Me.B_PrintSideWall.Location = New System.Drawing.Point(700, 124)
        Me.B_PrintSideWall.Name = "B_PrintSideWall"
        Me.B_PrintSideWall.Size = New System.Drawing.Size(158, 23)
        Me.B_PrintSideWall.TabIndex = 27
        Me.B_PrintSideWall.Text = "Print SideWall Drawing"
        Me.B_PrintSideWall.UseVisualStyleBackColor = True
        '
        'B_PrintRoof
        '
        Me.B_PrintRoof.Location = New System.Drawing.Point(700, 153)
        Me.B_PrintRoof.Name = "B_PrintRoof"
        Me.B_PrintRoof.Size = New System.Drawing.Size(158, 23)
        Me.B_PrintRoof.TabIndex = 28
        Me.B_PrintRoof.Text = "Print Roof Drawing"
        Me.B_PrintRoof.UseVisualStyleBackColor = True
        '
        'B_PrintFRW
        '
        Me.B_PrintFRW.Location = New System.Drawing.Point(700, 182)
        Me.B_PrintFRW.Name = "B_PrintFRW"
        Me.B_PrintFRW.Size = New System.Drawing.Size(158, 23)
        Me.B_PrintFRW.TabIndex = 29
        Me.B_PrintFRW.Text = "Print Front Wall Drawing"
        Me.B_PrintFRW.UseVisualStyleBackColor = True
        '
        'B_PrintRamp
        '
        Me.B_PrintRamp.Location = New System.Drawing.Point(700, 240)
        Me.B_PrintRamp.Name = "B_PrintRamp"
        Me.B_PrintRamp.Size = New System.Drawing.Size(158, 23)
        Me.B_PrintRamp.TabIndex = 30
        Me.B_PrintRamp.Text = "Print Ramp Drawing"
        Me.B_PrintRamp.UseVisualStyleBackColor = True
        '
        'CB_RearDoorOpt
        '
        Me.CB_RearDoorOpt.FormattingEnabled = True
        Me.CB_RearDoorOpt.Location = New System.Drawing.Point(134, 283)
        Me.CB_RearDoorOpt.Name = "CB_RearDoorOpt"
        Me.CB_RearDoorOpt.Size = New System.Drawing.Size(121, 21)
        Me.CB_RearDoorOpt.TabIndex = 31
        Me.CB_RearDoorOpt.Text = "Rear Door Option"
        '
        'RearDoor
        '
        Me.RearDoor.AutoSize = True
        Me.RearDoor.Location = New System.Drawing.Point(28, 286)
        Me.RearDoor.Name = "RearDoor"
        Me.RearDoor.Size = New System.Drawing.Size(90, 13)
        Me.RearDoor.TabIndex = 32
        Me.RearDoor.Text = "Rear Door Option"
        '
        'CBox_CkVIN
        '
        Me.CBox_CkVIN.AutoSize = True
        Me.CBox_CkVIN.Location = New System.Drawing.Point(259, 42)
        Me.CBox_CkVIN.Name = "CBox_CkVIN"
        Me.CBox_CkVIN.Size = New System.Drawing.Size(123, 17)
        Me.CBox_CkVIN.TabIndex = 33
        Me.CBox_CkVIN.Text = "Check VIN Directory"
        Me.CBox_CkVIN.UseVisualStyleBackColor = True
        '
        'CBox_Door
        '
        Me.CBox_Door.AutoSize = True
        Me.CBox_Door.Location = New System.Drawing.Point(319, 101)
        Me.CBox_Door.Name = "CBox_Door"
        Me.CBox_Door.Size = New System.Drawing.Size(167, 17)
        Me.CBox_Door.TabIndex = 34
        Me.CBox_Door.Text = "SIDE DOOR (5' WIDE ONLY)"
        Me.CBox_Door.UseVisualStyleBackColor = True
        '
        'TB_CB_VIN
        '
        Me.TB_CB_VIN.Location = New System.Drawing.Point(134, 38)
        Me.TB_CB_VIN.Name = "TB_CB_VIN"
        Me.TB_CB_VIN.Size = New System.Drawing.Size(121, 20)
        Me.TB_CB_VIN.TabIndex = 1
        Me.TB_CB_VIN.Text = "ADD VIN"
        '
        'CBox_5IN_TONGUE
        '
        Me.CBox_5IN_TONGUE.AutoSize = True
        Me.CBox_5IN_TONGUE.Location = New System.Drawing.Point(319, 121)
        Me.CBox_5IN_TONGUE.Name = "CBox_5IN_TONGUE"
        Me.CBox_5IN_TONGUE.Size = New System.Drawing.Size(210, 17)
        Me.CBox_5IN_TONGUE.TabIndex = 35
        Me.CBox_5IN_TONGUE.Text = "5IN TONGUE (7' WIDE STEEL ONLY)"
        Me.CBox_5IN_TONGUE.UseVisualStyleBackColor = True
        '
        'B_PrintRRW
        '
        Me.B_PrintRRW.Location = New System.Drawing.Point(700, 211)
        Me.B_PrintRRW.Name = "B_PrintRRW"
        Me.B_PrintRRW.Size = New System.Drawing.Size(158, 23)
        Me.B_PrintRRW.TabIndex = 36
        Me.B_PrintRRW.Text = "Print Rear Wall Drawing"
        Me.B_PrintRRW.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Wall Cross Member"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Roof Cross Member"
        '
        'CB_WallCrossMember
        '
        Me.CB_WallCrossMember.FormattingEnabled = True
        Me.CB_WallCrossMember.Items.AddRange(New Object() {"16", "24"})
        Me.CB_WallCrossMember.Location = New System.Drawing.Point(134, 200)
        Me.CB_WallCrossMember.Name = "CB_WallCrossMember"
        Me.CB_WallCrossMember.Size = New System.Drawing.Size(121, 21)
        Me.CB_WallCrossMember.TabIndex = 39
        Me.CB_WallCrossMember.Text = "CenterDist"
        '
        'CB_RoofCrossMember
        '
        Me.CB_RoofCrossMember.FormattingEnabled = True
        Me.CB_RoofCrossMember.Items.AddRange(New Object() {"16", "24"})
        Me.CB_RoofCrossMember.Location = New System.Drawing.Point(134, 228)
        Me.CB_RoofCrossMember.Name = "CB_RoofCrossMember"
        Me.CB_RoofCrossMember.Size = New System.Drawing.Size(121, 21)
        Me.CB_RoofCrossMember.TabIndex = 40
        Me.CB_RoofCrossMember.Text = "CenterDist"
        '
        'CBox_48Door
        '
        Me.CBox_48Door.AutoSize = True
        Me.CBox_48Door.Location = New System.Drawing.Point(319, 169)
        Me.CBox_48Door.Name = "CBox_48Door"
        Me.CBox_48Door.Size = New System.Drawing.Size(115, 17)
        Me.CBox_48Door.TabIndex = 41
        Me.CBox_48Door.Text = "48 IN SIDE DOOR"
        Me.CBox_48Door.UseVisualStyleBackColor = True
        '
        'CBox_BeaverTail
        '
        Me.CBox_BeaverTail.AutoSize = True
        Me.CBox_BeaverTail.Location = New System.Drawing.Point(319, 146)
        Me.CBox_BeaverTail.Name = "CBox_BeaverTail"
        Me.CBox_BeaverTail.Size = New System.Drawing.Size(136, 17)
        Me.CBox_BeaverTail.TabIndex = 42
        Me.CBox_BeaverTail.Text = "BEAVERTAIL OPTION"
        Me.CBox_BeaverTail.UseVisualStyleBackColor = True
        '
        'B_PrintWoodList
        '
        Me.B_PrintWoodList.Location = New System.Drawing.Point(700, 269)
        Me.B_PrintWoodList.Name = "B_PrintWoodList"
        Me.B_PrintWoodList.Size = New System.Drawing.Size(158, 23)
        Me.B_PrintWoodList.TabIndex = 43
        Me.B_PrintWoodList.Text = "Print Wood Cut List"
        Me.B_PrintWoodList.UseVisualStyleBackColor = True
        '
        'B_PrintMetalList
        '
        Me.B_PrintMetalList.Location = New System.Drawing.Point(700, 298)
        Me.B_PrintMetalList.Name = "B_PrintMetalList"
        Me.B_PrintMetalList.Size = New System.Drawing.Size(158, 23)
        Me.B_PrintMetalList.TabIndex = 44
        Me.B_PrintMetalList.Text = "Print Metal Cut List"
        Me.B_PrintMetalList.UseVisualStyleBackColor = True
        '
        'CBox_Screwless
        '
        Me.CBox_Screwless.AutoSize = True
        Me.CBox_Screwless.Location = New System.Drawing.Point(319, 192)
        Me.CBox_Screwless.Name = "CBox_Screwless"
        Me.CBox_Screwless.Size = New System.Drawing.Size(151, 17)
        Me.CBox_Screwless.TabIndex = 45
        Me.CBox_Screwless.Text = "SCREWLESS EXTERIOR"
        Me.CBox_Screwless.UseVisualStyleBackColor = True
        '
        'CBox_Color
        '
        Me.CBox_Color.Enabled = False
        Me.CBox_Color.FormattingEnabled = True
        Me.CBox_Color.Items.AddRange(New Object() {"60%"})
        Me.CBox_Color.Location = New System.Drawing.Point(134, 463)
        Me.CBox_Color.Name = "CBox_Color"
        Me.CBox_Color.Size = New System.Drawing.Size(121, 21)
        Me.CBox_Color.TabIndex = 47
        Me.CBox_Color.Text = "Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Metal Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Cast Corners"
        '
        'CB_CC
        '
        Me.CB_CC.Enabled = False
        Me.CB_CC.FormattingEnabled = True
        Me.CB_CC.Items.AddRange(New Object() {"Standard"})
        Me.CB_CC.Location = New System.Drawing.Point(134, 310)
        Me.CB_CC.Name = "CB_CC"
        Me.CB_CC.Size = New System.Drawing.Size(121, 21)
        Me.CB_CC.TabIndex = 50
        Me.CB_CC.Text = "Select Option"
        '
        'CB_TorsionAxle
        '
        Me.CB_TorsionAxle.AutoSize = True
        Me.CB_TorsionAxle.Location = New System.Drawing.Point(319, 215)
        Me.CB_TorsionAxle.Name = "CB_TorsionAxle"
        Me.CB_TorsionAxle.Size = New System.Drawing.Size(105, 17)
        Me.CB_TorsionAxle.TabIndex = 51
        Me.CB_TorsionAxle.Text = "TORSION AXLE"
        Me.CB_TorsionAxle.UseVisualStyleBackColor = True
        '
        'TrailerPrintDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 528)
        Me.Controls.Add(Me.CB_TorsionAxle)
        Me.Controls.Add(Me.CB_CC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBox_Color)
        Me.Controls.Add(Me.CBox_Screwless)
        Me.Controls.Add(Me.B_PrintMetalList)
        Me.Controls.Add(Me.B_PrintWoodList)
        Me.Controls.Add(Me.CBox_BeaverTail)
        Me.Controls.Add(Me.CBox_48Door)
        Me.Controls.Add(Me.CB_RoofCrossMember)
        Me.Controls.Add(Me.CB_WallCrossMember)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_PrintRRW)
        Me.Controls.Add(Me.CBox_5IN_TONGUE)
        Me.Controls.Add(Me.TB_CB_VIN)
        Me.Controls.Add(Me.CBox_Door)
        Me.Controls.Add(Me.CBox_CkVIN)
        Me.Controls.Add(Me.RearDoor)
        Me.Controls.Add(Me.CB_RearDoorOpt)
        Me.Controls.Add(Me.B_PrintRamp)
        Me.Controls.Add(Me.B_PrintFRW)
        Me.Controls.Add(Me.B_PrintRoof)
        Me.Controls.Add(Me.B_PrintSideWall)
        Me.Controls.Add(Me.B_PrintFrame)
        Me.Controls.Add(Me.B_Exit)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.CB_AxleLoc)
        Me.Controls.Add(Me.CB_CrossMember)
        Me.Controls.Add(Me.CB_AxleSpacing)
        Me.Controls.Add(Me.CB_AxleSize)
        Me.Controls.Add(Me.CB_AxleNo)
        Me.Controls.Add(Me.CB_Nose)
        Me.Controls.Add(Me.CB_Height)
        Me.Controls.Add(Me.CB_Width)
        Me.Controls.Add(Me.AxleLocation)
        Me.Controls.Add(Me.FrameCrossMember)
        Me.Controls.Add(Me.AxleSpacing)
        Me.Controls.Add(Me.AxleSize)
        Me.Controls.Add(Me.AxleNumber)
        Me.Controls.Add(Me.NoseConstruction)
        Me.Controls.Add(Me.TrailerHeight)
        Me.Controls.Add(Me.TrailerWidth)
        Me.Controls.Add(Me.L_VIN)
        Me.Controls.Add(Me.CB_Trailer)
        Me.Controls.Add(Me.L_TrailerModel)
        Me.Controls.Add(Me.TrailerLength)
        Me.Controls.Add(Me.CB_Length)
        Me.Name = "TrailerPrintDialog"
        Me.Text = "Raven Trailer Print Dialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_Length As System.Windows.Forms.ComboBox
    Friend WithEvents TrailerLength As System.Windows.Forms.Label
    Friend WithEvents L_TrailerModel As System.Windows.Forms.Label
    Friend WithEvents CB_Trailer As System.Windows.Forms.ComboBox
    Friend WithEvents L_VIN As System.Windows.Forms.Label
    Friend WithEvents TrailerWidth As System.Windows.Forms.Label
    Friend WithEvents TrailerHeight As System.Windows.Forms.Label
    Friend WithEvents NoseConstruction As System.Windows.Forms.Label
    Friend WithEvents AxleNumber As System.Windows.Forms.Label
    Friend WithEvents AxleSize As System.Windows.Forms.Label
    Friend WithEvents AxleSpacing As System.Windows.Forms.Label
    Friend WithEvents FrameCrossMember As System.Windows.Forms.Label
    Friend WithEvents AxleLocation As System.Windows.Forms.Label
    Friend WithEvents CB_Width As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Height As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Nose As System.Windows.Forms.ComboBox
    Friend WithEvents CB_AxleNo As System.Windows.Forms.ComboBox
    Friend WithEvents CB_AxleSize As System.Windows.Forms.ComboBox
    Friend WithEvents CB_AxleSpacing As System.Windows.Forms.ComboBox
    Friend WithEvents CB_CrossMember As System.Windows.Forms.ComboBox
    Friend WithEvents CB_AxleLoc As System.Windows.Forms.ComboBox
    Friend WithEvents Print As System.Windows.Forms.Button
    Friend WithEvents B_Exit As System.Windows.Forms.Button
    Friend WithEvents B_PrintFrame As System.Windows.Forms.Button
    Friend WithEvents B_PrintSideWall As System.Windows.Forms.Button
    Friend WithEvents B_PrintRoof As System.Windows.Forms.Button
    Friend WithEvents B_PrintFRW As System.Windows.Forms.Button
    Friend WithEvents B_PrintRamp As System.Windows.Forms.Button
    Friend WithEvents CB_RearDoorOpt As System.Windows.Forms.ComboBox
    Friend WithEvents RearDoor As System.Windows.Forms.Label
    Friend WithEvents CBox_CkVIN As System.Windows.Forms.CheckBox
    Friend WithEvents CBox_Door As System.Windows.Forms.CheckBox
    Friend WithEvents TB_CB_VIN As System.Windows.Forms.TextBox
    Friend WithEvents CBox_5IN_TONGUE As System.Windows.Forms.CheckBox
    Friend WithEvents B_PrintRRW As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CB_WallCrossMember As System.Windows.Forms.ComboBox
    Friend WithEvents CB_RoofCrossMember As System.Windows.Forms.ComboBox
    Friend WithEvents CBox_48Door As System.Windows.Forms.CheckBox
    Friend WithEvents CBox_BeaverTail As System.Windows.Forms.CheckBox
    Friend WithEvents B_PrintWoodList As System.Windows.Forms.Button
    Friend WithEvents B_PrintMetalList As System.Windows.Forms.Button
    Friend WithEvents CBox_Screwless As System.Windows.Forms.CheckBox
    Friend WithEvents CBox_Color As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CB_CC As System.Windows.Forms.ComboBox
    Friend WithEvents CB_TorsionAxle As System.Windows.Forms.CheckBox

End Class
