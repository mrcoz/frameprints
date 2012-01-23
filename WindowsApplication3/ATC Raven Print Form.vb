Public Class TrailerPrintDialog

    'Dim strDirectory = "X:\Frames - standard\Ravens\REL\PDF\"
    'Dim strDirectory = "\\TS-SERV\Master Records\Stock PDFs\"
    Dim strDirectory = "\\ERPSERV\Master\M Drive Data\Master Records\Stock PDFs\"

    'Dim vinDirectory = "X:\Engineers\MarkCosby\VIN\"
    'Dim vinDirectory = "\\TS-SERV\Master Records\Temp VINs\"
    Dim vinDirectory = "\\ERPSERV\Master\M Drive Data\Master Records\Temp VINs\"
    'Dim vinDirectory = "\\ERPSERV\Master\Frames - standard\Ravens\Temp VINs\"

    Public Declare Auto Function FindExecutable Lib "shell32.dll" (ByVal lpFile As String, ByVal lpDirectory As String, ByVal lpResult As String) As Int32
    Public DL As String
    Public FolderDir As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim FileName As String
        FileName = "M:\Master Records\Temp VINs\194571\194571.xml"
        Dim VIN = XDocument.Load(FileName)
        Dim price As Double
        If System.IO.File.Exists(FileName) = True Then
            'MsgBox("File Does Exist")
        Else
            'MsgBox("File Does Not Exist") ' This does not work!!!
            'End
        End If
        'Console.WriteLine("Order: ")
        Dim f = VIN...<Order>
        For Each item In f
            'Console.WriteLine("Notes (non allowed): " & item.@notes) ' Attribute Value
            'MsgBox("Notes (non allowed): " & item.@notes) ' Attribute Value
        Next

        Dim Product_Name As String

        'Console.WriteLine("Trailer Model: ")
        Dim b = VIN...<Product>
        For Each item In b
            Product_Name = item.@name
            'MsgBox(Product_Name)

            'Console.WriteLine(item.@id & " " & item.@name & " " & item.@notes) ' Attribute Value
        Next

        'Dim e = VIN...<Product>
        'For Each item In e
        'price = CDbl(item.@price)
        'Console.WriteLine(item.@price & " " & item.@name) ' Attribute Value
        'Next

        'Console.WriteLine("Trailer Options: ")
        Dim Option_Name As String
        Dim Option_id As String
        Dim Option_string As String

        Dim c = VIN...<Option>
        For Each item In c
            Option_Name = item.@name
            Option_id = item.@id
            Option_string = (Option_id & " " & Option_Name)
            'MsgBox(Option_string)
            'Console.WriteLine(item.@id & " " & item.@name) ' Attribute Value
        Next

        Dim d = VIN...<Option>
        For Each item In d
            price = price + CDbl(item.@price)
            'Console.WriteLine(item.@overridden & " " & item.@price & " " & item.@notes) ' Attribute Value
        Next

        'Console.WriteLine("Total Price: " & price)

        Console.ReadLine()
        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Items.Clear()
        CB_Trailer.Text = "SELECT MODEL"
        CB_Trailer.Items.Add("RAVEN LITE CARGO (STEEL)")
        CB_Trailer.Items.Add("RAVAN LITE CARGO (ALUMINUM)")
        'CB_Trailer.Items.Add("MSX()")
        'CB_Trailer.Items.Add("SS (SUPER SPORT)")
    End Sub

    Private Sub TB_CB_VIN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_CB_VIN.TextChanged

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        'CB_Trailer.Enabled = True

        CB_Width.Items.Clear()
        CB_Width.Text = "Width"
        CB_Width.Items.Add("5.0")
        CB_Width.Items.Add("6.0")
        CB_Width.Items.Add("7.0")
        CB_Width.Items.Add("8.5")
        CB_Length.Items.Clear()
        CB_Length.Text = "Length"
        CB_Height.Items.Clear()
        CB_Height.Text = "Height"
        CB_CrossMember.Items.Clear()
        CB_CrossMember.Text = "CenterDist"
        CB_WallCrossMember.Items.Clear()
        CB_WallCrossMember.Text = "CenterDist"
        CB_RoofCrossMember.Items.Clear()
        CB_RoofCrossMember.Text = "CenterDist"
        CB_Nose.Items.Clear()
        CB_Nose.Text = "Nose Construction"

        CB_Trailer.Items.Clear()
        CB_Trailer.Text = "SELECT MODEL"
        CB_Trailer.Items.Add("RAVEN LITE CARGO (STEEL)")
        CB_Trailer.Items.Add("RAVAN LITE CARGO (ALUMINUM)")
        'CB_Trailer.Items.Add("MSX()")
        'CB_Trailer.Items.Add("SS (SUPER SPORT)")
        'CB_Trailer.Enabled = False
    End Sub

    Private Sub CB_VIN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True

        CB_Trailer.Items.Clear()
        CB_Trailer.Text = "SELECT MODEL"
        CB_Trailer.Items.Add("RAVEN LITE CARGO (STEEL)")
        CB_Trailer.Items.Add("RAVAN LITE CARGO (ALUMINUM)")
        'CB_Trailer.Items.Add("MSX()")
        'CB_Trailer.Items.Add("SS (SUPER SPORT)")

    End Sub

    Private Sub CBox_CkVIN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBox_CkVIN.CheckedChanged

        Dim Dirtst As String
        'Dim FolderDir As String

        FolderDir = vinDirectory + TB_CB_VIN.Text

        Dirtst = System.IO.Directory.Exists(FolderDir)

        'MsgBox(Dirtst + FolderDir)

        If System.IO.Directory.Exists(FolderDir) Then
        Else
            System.IO.Directory.CreateDirectory(FolderDir)
        End If

        'If CB_VIN.Text = "194" Then
        'vinDirectory = "X:\Master Records\194 VINS"
        'ElseIf CB_VIN.Text = "170" Then
        'vinDirectory = "X:\Master Records\170 VINS"
        'End If

        CB_Trailer.Enabled = True
    End Sub

    Private Sub CB_Trailer_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Trailer.SelectedValueChanged

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True
        CB_Width.Enabled = True

        CB_Width.Items.Clear()
        CB_Width.Text = "Width"
        CB_Width.Items.Add("5.0")
        CB_Width.Items.Add("6.0")
        CB_Width.Items.Add("7.0")
        CB_Width.Items.Add("8.5")
        CB_Length.Items.Clear()
        CB_Length.Text = "Length"
        CB_Height.Items.Clear()
        CB_Height.Text = "Height"
        CB_CrossMember.Items.Clear()
        CB_CrossMember.Text = "CenterDist"
        CB_WallCrossMember.Items.Clear()
        CB_WallCrossMember.Text = "CenterDist"
        CB_RoofCrossMember.Items.Clear()
        CB_RoofCrossMember.Text = "CenterDist"
        CB_Nose.Items.Clear()
        CB_Nose.Text = "Nose Construction"

    End Sub

    Private Sub CB_Width_Selected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Width.SelectedValueChanged

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True
        CB_Width.Enabled = True
        CB_Length.Enabled = True

        CB_Length.Items.Clear()
        CB_Length.Text = "Length"
        CB_Height.Items.Clear()
        CB_Height.Text = "Height"
        CB_CrossMember.Items.Clear()
        CB_CrossMember.Text = "CenterDist"
        CB_WallCrossMember.Items.Clear()
        CB_WallCrossMember.Text = "CenterDist"
        CB_RoofCrossMember.Items.Clear()
        CB_RoofCrossMember.Text = "CenterDist"
        CB_Nose.Items.Clear()
        CB_Nose.Text = "Nose Construction"

        If CB_Width.Text = "5.0" Then
            CB_Length.Items.Add("08")
            '       CBox_Door.Enabled = True
        ElseIf CB_Width.Text = "6.0" Then
            CB_Length.Items.Add("10")
            CB_Length.Items.Add("12")
            '      CBox_Door.Enabled = False
        ElseIf CB_Width.Text = "7.0" Then
            CB_Length.Items.Add("14")
            CB_Length.Items.Add("16")
        ElseIf CB_Width.Text = "8.5" Then
            CB_Length.Items.Add("16")
            CB_Length.Items.Add("18")
            CB_Length.Items.Add("20")
            CB_Length.Items.Add("22")
            CB_Length.Items.Add("24")
        End If

    End Sub

    Private Sub CB_Length_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Length.SelectedValueChanged

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True
        CB_Width.Enabled = True
        CB_Length.Enabled = True
        CB_Height.Enabled = True

        CB_Height.Items.Clear()
        CB_Height.Text = "Height"
        CB_CrossMember.Items.Clear()
        CB_CrossMember.Text = "CenterDist"
        CB_WallCrossMember.Items.Clear()
        CB_WallCrossMember.Text = "CenterDist"
        CB_RoofCrossMember.Items.Clear()
        CB_RoofCrossMember.Text = "CenterDist"
        CB_Nose.Items.Clear()
        CB_Nose.Text = "Nose Construction"

        If CB_Width.Text = "5.0" Then
            'CB_Height.Items.Add("66")
            'CB_Height.Items.Add("72")
            CB_Height.Items.Add("5.5")
            CB_Height.Items.Add("6.0")
        ElseIf CB_Width.Text = "6.0" Or CB_Width.Text = "7.0" Then
            'CB_Height.Items.Add("72")
            'CB_Height.Items.Add("78")
            CB_Height.Items.Add("6.0")
            CB_Height.Items.Add("6.5")
        ElseIf CB_Width.Text = "8.5" Then
            'CB_Height.Items.Add("72")
            'CB_Height.Items.Add("78")
            CB_Height.Items.Add("6.0")
            CB_Height.Items.Add("6.5")
            CB_Height.Items.Add("7.0")
        End If

    End Sub

    Private Sub CB_Height_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Height.SelectedValueChanged

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True
        CB_Width.Enabled = True
        CB_Length.Enabled = True
        CB_Height.Enabled = True
        CB_CrossMember.Enabled = True

        CB_CrossMember.Items.Clear()

        CB_CrossMember.Text = "CenterDist"
        CB_CrossMember.Items.Add("16")
        CB_CrossMember.Items.Add("24")
        CB_WallCrossMember.Items.Clear()
        CB_WallCrossMember.Text = "CenterDist"
        CB_RoofCrossMember.Items.Clear()
        CB_RoofCrossMember.Text = "CenterDist"
        CB_Nose.Items.Clear()
        CB_Nose.Text = "Nose Construction"

    End Sub

    Private Sub CB_CrossMember_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CrossMember.SelectedIndexChanged

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True
        CB_Width.Enabled = True
        CB_Length.Enabled = True
        CB_Height.Enabled = True
        CB_CrossMember.Enabled = True
        'CB_Nose.Enabled = True

        'CB_Nose.Items.Clear()
        CB_WallCrossMember.Items.Clear()
        CB_RoofCrossMember.Items.Clear()
        'CB_Nose.Text = "Nose Construction"
        'CB_Nose.Items.Add("Flat Nose (+0)")
        'CB_Nose.Items.Add("Wedge Nose (+2)")

        If CB_Width.Text <> "8.5" Then
            CB_WallCrossMember.Text = "24"
            CB_RoofCrossMember.Text = "24"
            CB_WallCrossMember.Enabled = True
            CB_WallCrossMember.Text = "CenterDist"
            CB_WallCrossMember.Items.Add("16")
            CB_WallCrossMember.Items.Add("24")
        Else
            CB_WallCrossMember.Enabled = True
            CB_RoofCrossMember.Enabled = True
            CB_WallCrossMember.Text = "CenterDist"
            CB_WallCrossMember.Items.Add("16")
            CB_WallCrossMember.Items.Add("24")
            CB_RoofCrossMember.Text = "CenterDist"
            CB_RoofCrossMember.Items.Add("16")
            CB_RoofCrossMember.Items.Add("24")
        End If
       
    End Sub
    Private Sub CB_WallCrossMember_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WallCrossMember.SelectedIndexChanged
        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True
        CB_Width.Enabled = True
        CB_Length.Enabled = True
        CB_Height.Enabled = True
        CB_CrossMember.Enabled = True
        CB_Nose.Enabled = True

        If CB_Width.Text <> "8.5" And CB_CrossMember.Enabled = True Then
            CB_WallCrossMember.Enabled = True
        ElseIf CB_CrossMember.Enabled = True Then
            CB_WallCrossMember.Enabled = True
            CB_RoofCrossMember.Enabled = True
        Else
        End If

        CB_Nose.Items.Clear()
        'CB_WallCrossMember.Items.Clear()
        'CB_RoofCrossMember.Items.Clear()
        CB_Nose.Text = "Nose Construction"
        CB_Nose.Items.Add("Flat Nose (+0)")
        CB_Nose.Items.Add("Wedge Nose (+2)")

    End Sub

    Private Sub CB_RoofCrossMember_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_RoofCrossMember.SelectedIndexChanged

    End Sub
    Private Sub CB_Nose_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Nose.SelectedValueChanged

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True
        CB_Width.Enabled = True
        CB_Length.Enabled = True
        CB_Height.Enabled = True
        CB_CrossMember.Enabled = True
        CB_Nose.Enabled = True
        CB_RearDoorOpt.Enabled = True

        If CB_Width.Text <> "8.5" And CB_CrossMember.Enabled = True Then
            CB_WallCrossMember.Enabled = True
        ElseIf CB_CrossMember.Enabled = True Then
            CB_WallCrossMember.Enabled = True
            CB_RoofCrossMember.Enabled = True
        Else
        End If

        CB_RearDoorOpt.Items.Clear()
        CB_RearDoorOpt.Text = "Rear Door Option"
        CB_RearDoorOpt.Items.Add("Cargo Doors")
        CB_RearDoorOpt.Items.Add("Ramp Doors")

    End Sub

    Private Sub CB_RearDoorOpt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_RearDoorOpt.SelectedIndexChanged

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "Off"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True
        CB_RearDoorOpt.Enabled = True
        CB_Width.Enabled = True
        CB_Length.Enabled = True
        CB_Height.Enabled = True
        CB_CrossMember.Enabled = True
        CB_Nose.Enabled = True
        CB_CC.Enabled = True

        If CB_Width.Text <> "8.5" And CB_CrossMember.Enabled = True Then
            CB_WallCrossMember.Enabled = True
        ElseIf CB_CrossMember.Enabled = True Then
            CB_WallCrossMember.Enabled = True
            CB_RoofCrossMember.Enabled = True
        Else
        End If

        CB_CC.Items.Clear()
        CB_CC.Text = "Cast Corner Option"
        If CB_Nose.Text = "Flat Nose (+0)" And CB_Width.Text = "8.5" Then
            CB_CC.Items.Add("+CC")
            CB_CC.Items.Add("-CC")
        ElseIf CB_Nose.Text = "Wedge Nose (+2)" Then
            CB_CC.Items.Add("-CC")
        Else
            CB_CC.Items.Add("-CC")
        End If
        
    End Sub

    Private Sub CB_Nose_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Nose.SelectedIndexChanged

    End Sub

    Private Sub CB_CC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CC.SelectedIndexChanged

        Dim PRNST As String
        Dim tmpvar As String
        PRNST = "On"
        tmpvar = SetPrintMenu(PRNST)

        CB_Trailer.Enabled = True
        CB_Width.Enabled = True
        CB_Length.Enabled = True
        CB_Height.Enabled = True
        CB_RearDoorOpt.Enabled = True
        CB_CrossMember.Enabled = True
        CB_Nose.Enabled = True
        CB_CC.Enabled = True
        CB_TorsionAxle.Enabled = True

        If CB_Width.Text <> "8.5" And CB_CrossMember.Enabled = True Then
            CB_WallCrossMember.Enabled = True
        ElseIf CB_CrossMember.Enabled = True Then
            CB_WallCrossMember.Enabled = True
            CB_RoofCrossMember.Enabled = True
        Else
        End If

    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click

        Dim tmpvar As String
        DL = "ALL"
        tmpvar = PrintDwg(DL)

    End Sub

    Private Sub B_PrintFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_PrintFrame.Click

        Dim tmpvar As String
        DL = "FRM"
        tmpvar = PrintDwg(DL)

    End Sub

    Function SetPrintMenu(ByVal PrintStatus As String)

        CB_Trailer.Enabled = False
        CBox_Screwless.Enabled = False
        CB_Width.Enabled = False
        CB_Length.Enabled = False
        CB_Height.Enabled = False
        CB_CrossMember.Enabled = False
        CB_WallCrossMember.Enabled = False
        CB_RoofCrossMember.Enabled = False
        CB_Nose.Enabled = False
        CB_AxleLoc.Enabled = False
        CB_AxleNo.Enabled = False
        CB_AxleSize.Enabled = False
        CB_AxleSpacing.Enabled = False
        CB_RearDoorOpt.Enabled = False
        CB_Trailer.Enabled = False
        CB_TorsionAxle.Enabled = False
        'CBox_Door.Enabled = False
        'CBox_Door.Checked = False
        'CBox_48Door.Enabled = False
        'CBox_48Door.Checked = False
        'CBox_BeaverTail.Enabled = False
        'CBox_BeaverTail.Checked = False
        CBox_Color.Enabled = False
        'CBox_5IN_TONGUE.Enabled = False

        If PrintStatus = "Off" Then
            Print.Enabled = False
            B_PrintFrame.Enabled = False
            B_PrintSideWall.Enabled = False
            B_PrintRoof.Enabled = False
            B_PrintFRW.Enabled = False
            B_PrintRRW.Enabled = False
            B_PrintWoodList.Enabled = False
            B_PrintMetalList.Enabled = False
            B_PrintRamp.Enabled = False
        Else
            If CB_RearDoorOpt.Text = "Ramp Doors" Then
                B_PrintRamp.Enabled = True
            ElseIf CB_RearDoorOpt.Text = "Cargo Doors" Then
                B_PrintRamp.Enabled = False
            End If

            Print.Enabled = True
            B_PrintFrame.Enabled = True
            B_PrintSideWall.Enabled = True
            B_PrintRoof.Enabled = True
            B_PrintFRW.Enabled = True
            B_PrintRRW.Enabled = True
            B_PrintWoodList.Enabled = True
            B_PrintMetalList.Enabled = True
        End If

        If CB_Width.Text = "5.0" Then
            CBox_Screwless.Enabled = True
            CBox_Door.Enabled = True
            CBox_5IN_TONGUE.Enabled = False
            CBox_5IN_TONGUE.Checked = False
            CBox_48Door.Enabled = False
            CBox_48Door.Checked = False
            CBox_BeaverTail.Enabled = False
            CBox_BeaverTail.Checked = False
        ElseIf CB_Width.Text = "6.0" Then
            CBox_Screwless.Enabled = True
            CBox_Door.Enabled = False
            CBox_Door.Checked = False
            CBox_5IN_TONGUE.Enabled = False
            CBox_5IN_TONGUE.Checked = False
            CBox_48Door.Enabled = False
            CBox_48Door.Checked = False
            CBox_BeaverTail.Enabled = False
            CBox_BeaverTail.Checked = False
        ElseIf CB_Width.Text = "7.0" Then
            CBox_Screwless.Enabled = True
            CBox_Door.Enabled = False
            CBox_Door.Checked = False
            CBox_5IN_TONGUE.Enabled = True
            CBox_48Door.Enabled = False
            CBox_48Door.Checked = False
            CBox_BeaverTail.Enabled = False
            CBox_BeaverTail.Checked = False
        ElseIf CB_Width.Text = "8.5" Then
            CBox_Screwless.Enabled = True
            CBox_Door.Enabled = False
            CBox_Door.Checked = False
            CBox_5IN_TONGUE.Enabled = False
            CBox_5IN_TONGUE.Checked = False
            CBox_48Door.Enabled = True
            'CBox_48Door.Checked = False
            CBox_BeaverTail.Enabled = True
            'CBox_BeaverTail.Checked = False
        Else
            CBox_Screwless.Enabled = False
            CBox_Screwless.Checked = False
            CBox_Door.Enabled = False
            CBox_Door.Checked = False
            CBox_5IN_TONGUE.Enabled = False
            CBox_5IN_TONGUE.Checked = False
            CBox_48Door.Enabled = False
            CBox_48Door.Checked = False
            CBox_BeaverTail.Enabled = False
            CBox_BeaverTail.Checked = False
        End If

    End Function

    Function PrintDwg(ByVal DL As String)
        Dim strFile As String
        Dim psi As New ProcessStartInfo
        Dim fn(10) As String
        Dim printcnt As Double
        Dim NoseConfig As String
        Dim dirfn As String
        Dim TlrHt As Double
        Dim RampROHeight As Double
        Dim RampROWidth As Double
        Dim RampOpt As String
        Dim DoorOpt As String
        Dim BeaverTail As String
        ' VARIABLES FOR MTL CUT LIST
        Dim MTL_CTL_RS_1 As String
        Dim MTL_HT As Integer
        Dim MTL_STD_WIDTH As Integer
        Dim RS_STD_PC_CNT As Double
        printcnt = 0
        NoseConfig = "0"

        If CB_Nose.Text = "Flat Nose (+0)" Then
            NoseConfig = "+0"
        ElseIf CB_Nose.Text = "Wedge Nose (+2)" Then
            NoseConfig = "+2"
        Else
            MsgBox("Error Nose Config")
        End If

        If CB_RearDoorOpt.Text = "Ramp Doors" Then
            RampOpt = "+R"
        Else
            RampOpt = "-R"
        End If

        If CBox_Door.Checked Then
            DoorOpt = "+DR"
        Else
            DoorOpt = "-DR"
        End If

        If CBox_BeaverTail.Checked Then
            BeaverTail = "+BT"
        Else
            BeaverTail = "-BT"
        End If

        TlrHt = CDbl(CB_Height.Text) * 12        ' *** Interior Height in inches ***
        ' ************************************************************************************ mtl cut list
        MTL_HT = TlrHt + 7
        MTL_STD_WIDTH = 49
        'RS_STD_PC_CNT = CB_Length / 4

        'MsgBox(RS_STD_PC_CNT)

        MTL_CTL_RS_1 = CStr(MTL_STD_WIDTH) + " x " + CStr(MTL_HT)

        'MsgBox(MTL_CTL_RS_1)
        ' ************************************************************************************

        If CBox_BeaverTail.Checked Then
            RampROHeight = TlrHt + 0.5                 ' *** Ramp Rough Opening Height, for 8.5 Wide Only ***
            RampROHeight = RampROHeight - 1.0
        Else
            RampROHeight = TlrHt - 2.5                 ' *** Ramp Rough Opening Height, for 8.5 Wide Only ***
        End If

        RampROWidth = (CDbl(CB_Width.Text) * 12) - 12.0   ' *** Ramp Rought Opening Width, for 8.5 Wide Only ***

        'MsgBox(RampROWidth.ToString("0.0"))

        Dim strFileCk As String
        Dim MAT As String

        If CB_Trailer.Text = "RAVEN LITE CARGO (STEEL)" Then
            MAT = "ST"
        ElseIf CB_Trailer.Text = "RAVAN LITE CARGO (ALUMINUM)" Then
            MAT = "AL"

            If ((DL = "ALL") Or (DL = "FRM")) And CB_TorsionAxle.Checked Then
            Else
                printcnt = printcnt + 1
                If CB_Width.Text = "7.0" Or CB_Width.Text = "8.5" Then
                    fn(printcnt) = "AXLE MOUNT BRKT, ST - 64.0.PDF"
                Else
                    If CB_Length.Text = "12" Or CB_CrossMember.Text = "16" Then
                        fn(printcnt) = "AXLE MOUNT BRKT, ST - 31.0x4.5x20.5.PDF"
                    ElseIf CB_Length.Text = "10" And CB_CrossMember.Text = "24" Then
                        'MsgBox(CB_Length.Text)
                        fn(printcnt) = "AXLE MOUNT BRKT, ST - 31.0x12.5.PDF"
                    ElseIf CB_Length.Text = "08" And CB_CrossMember.Text = "24" Then
                        'MsgBox(CB_Length.Text)
                        fn(printcnt) = "AXLE MOUNT BRKT, ST - 31.0x4.5x28.5.PDF"
                    End If
                End If
            End If

        End If

        If (DL = "ALL") Or (DL = "MTL") Then ' *** METAL CUT LIST ***
            If CB_Width.Text = "5.0" Or CB_Width.Text = "6.0" Then
                printcnt = printcnt + 1
                fn(printcnt) = "MTLCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + DoorOpt + ".PDF"
            ElseIf CB_Width.Text = "8.5" Then
                printcnt = printcnt + 1
                fn(printcnt) = "MTLCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + CB_CC.Text + BeaverTail + ".PDF"
                'MTLCL - 8.5x16x78+0+R+CC+BT
            Else
                printcnt = printcnt + 1
                fn(printcnt) = "MTLCL, " + MAT + " - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
                ' MTLCL, AL - 5.0x08x66+0-R-DR  
            End If
        End If

        If (DL = "ALL") Or (DL = "WOOD") Then ' *** WOOD CUT LIST ***
            If CB_Width.Text = "5.0" Then
                printcnt = printcnt + 1
                fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + DoorOpt + ".PDF"
            ElseIf CB_Width.Text = "6.0" Then
                printcnt = printcnt + 1
                fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
            ElseIf CB_Width.Text = "7.0" Then
                printcnt = printcnt + 1
                fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
            ElseIf CB_Width.Text = "8.5" Then
                printcnt = printcnt + 1
                fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
            End If
        End If

        If (DL = "ALL") Or (DL = "ROF") Then ' ****** ROOF ******
            printcnt = printcnt + 1
            If CB_Width.Text = "8.5" Then
                fn(printcnt) = "ROF, " + MAT + " - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_RoofCrossMember.Text + "OC.PDF"
            Else
                fn(printcnt) = "ROF, " + MAT + " - " + CB_Width.Text + "x" + CB_Length.Text + ".PDF"
            End If
        End If

        If (DL = "ALL") Or (DL = "FRW") Then ' ****** FRONT WALL ******
            printcnt = printcnt + 1
            fn(printcnt) = "FRW, " + MAT + " - " + CB_Width.Text + "" + CStr(NoseConfig) + "" + CB_CC.Text + ".PDF"
        End If

        If (DL = "ALL") Or (DL = "RRW") Then ' ****** REAR WALL ******
            printcnt = printcnt + 1
            fn(printcnt) = "RRW, " + MAT + " - " + CB_Width.Text + "x" + CStr(TlrHt) + BeaverTail + ".PDF"
        End If

        If (DL = "ALL") Or (DL = "RMP") Then ' ****** RAMP ******
            If CB_RearDoorOpt.Text = "Ramp Doors" Then
                printcnt = printcnt + 1
                If CB_Width.Text = "8.5" Then
                    fn(printcnt) = "RMP, " + MAT + " - " + RampROWidth.ToString("0") + "x" + CStr(TlrHt) + BeaverTail + "+BH.PDF"
                Else
                    fn(printcnt) = "RMP, " + MAT + " - " + CB_Width.Text + "x" + CStr(TlrHt) + ".PDF"
                End If
            End If
        End If

        If (DL = "ALL") Or (DL = "SDW") Then ' *** Side Wall ***
            printcnt = printcnt + 1
            If CB_Width.Text = "5.0" Then
                If CBox_Door.Checked Then
                    fn(printcnt) = "SDW, " + MAT + " - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC+DR-OA.PDF"
                Else
                    fn(printcnt) = "SDW, " + MAT + " - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC-DR-OA.PDF"
                End If
            ElseIf CB_Width.Text = "8.5" Then
                fn(printcnt) = "SDW, " + MAT + " - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC.PDF"
            Else
                fn(printcnt) = "SDW, " + MAT + " - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC-OA.PDF"
            End If
        End If


        If (DL = "ALL") Or (DL = "FRM") Then ' *** Frame ***
            printcnt = printcnt + 1
            If CBox_5IN_TONGUE.Checked Then
                fn(printcnt) = "FRM, " + MAT + " - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC+2x5TNG.PDF"
            ElseIf CB_Width.Text = "8.5" Then
                If CBox_BeaverTail.Checked Then
                    fn(printcnt) = "FRM, " + MAT + " - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC+BT.PDF"
                Else
                    fn(printcnt) = "FRM, " + MAT + " - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC-BT.PDF"
                End If
            Else
                fn(printcnt) = "FRM, " + MAT + " - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC.PDF"
            End If
        End If

        For i As Integer = 1 To printcnt
            strFile = strDirectory + fn(i)
            strFileCk = FileIO.FileSystem.FileExists(strFile)
            If System.IO.File.Exists(strFile) Then
                If System.IO.Directory.Exists(FolderDir) Then
                    'System.IO.File.Copy(strFile, )
                Else
                    System.IO.Directory.CreateDirectory(FolderDir)
                End If
                dirfn = FolderDir + "\" + fn(i)

                If System.IO.File.Exists(dirfn) Then
                    System.IO.File.Delete(dirfn)
                    System.IO.File.Copy(strFile, dirfn)
                Else
                    System.IO.File.Copy(strFile, dirfn)
                End If

                'strFile = strDirectory + fn(i)
                psi.UseShellExecute = True
                psi.Verb = "print"
                psi.WindowStyle = ProcessWindowStyle.Hidden
                psi.FileName = strFile
                Process.Start(psi)
            Else
                MsgBox("Drawing does not Exist" + strFile + " " + strFileCk)
            End If
        Next
    End Function

    Function PrintDwg_old(ByVal DL As String)
        Dim strFile As String
        Dim psi As New ProcessStartInfo
        Dim fn(10) As String
        Dim printcnt As Double
        Dim NoseConfig As String
        Dim dirfn As String
        Dim TlrHt As Double
        Dim RampROHeight As Double
        Dim RampROWidth As Double
        Dim RampOpt As String
        Dim DoorOpt As String
        Dim BeaverTail As String
        ' VARIABLES FOR MTL CUT LIST
        Dim MTL_CTL_RS_1 As String
        Dim MTL_HT As Integer
        Dim MTL_STD_WIDTH As Integer
        Dim RS_STD_PC_CNT As Double
        printcnt = 0
        NoseConfig = "0"

        If CB_Nose.Text = "Flat Nose (+0)" Then
            NoseConfig = "+0"
        ElseIf CB_Nose.Text = "Wedge Nose (+2)" Then
            NoseConfig = "+2"
        Else
            MsgBox("Error Nose Config")
        End If

        If CB_RearDoorOpt.Text = "Ramp Doors" Then
            RampOpt = "+R"
        Else
            RampOpt = "-R"
        End If

        If CBox_Door.Checked Then
            DoorOpt = "+DR"
        Else
            DoorOpt = "-DR"
        End If

        If CBox_BeaverTail.Checked Then
            BeaverTail = "+BT"
        Else
            BeaverTail = "-BT"
        End If

        TlrHt = CDbl(CB_Height.Text) * 12        ' *** Interior Height in inches ***
        ' ************************************************************************************ mtl cut list
        MTL_HT = TlrHt + 7
        MTL_STD_WIDTH = 49
        'RS_STD_PC_CNT = CB_Length / 4

        'MsgBox(RS_STD_PC_CNT)

        MTL_CTL_RS_1 = CStr(MTL_STD_WIDTH) + " x " + CStr(MTL_HT)

        'MsgBox(MTL_CTL_RS_1)
        ' ************************************************************************************

        If CBox_BeaverTail.Checked Then
            RampROHeight = TlrHt + 0.5                 ' *** Ramp Rough Opening Height, for 8.5 Wide Only ***
            RampROHeight = RampROHeight - 1.0
        Else
            RampROHeight = TlrHt - 2.5                 ' *** Ramp Rough Opening Height, for 8.5 Wide Only ***
        End If

        RampROWidth = (CDbl(CB_Width.Text) * 12) - 12.0   ' *** Ramp Rought Opening Width, for 8.5 Wide Only ***

        'MsgBox(RampROWidth.ToString("0.0"))

        Dim strFileCk As String

        If CB_Trailer.Text = "RAVEN LITE CARGO (STEEL)" Then

            If (DL = "ALL") Or (DL = "MTL") Then ' *** METAL CUT LIST ***
                If CB_Width.Text = "5.0" Or CB_Width.Text = "6.0" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "MTLCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + DoorOpt + ".PDF"
                ElseIf CB_Width.Text = "8.5" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "MTLCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + CB_CC.Text + BeaverTail + ".PDF"
                    'MTLCL - 8.5x16x78+0+R+CC+BT
                Else
                    printcnt = printcnt + 1
                    fn(printcnt) = "MTLCL, ST - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
                    ' MTLCL, AL - 5.0x08x66+0-R-DR  
                End If
            End If

            If (DL = "ALL") Or (DL = "WOOD") Then ' *** METAL CUT LIST ***
                If CB_Width.Text = "5.0" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + DoorOpt + ".PDF"
                ElseIf CB_Width.Text = "6.0" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
                ElseIf CB_Width.Text = "7.0" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
                ElseIf CB_Width.Text = "8.5" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
                End If
            End If

            If (DL = "ALL") Or (DL = "FRM") Then ' *** Frame ***
                printcnt = printcnt + 1
                If CBox_5IN_TONGUE.Checked Then
                    fn(printcnt) = "FRM, ST - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC+2x5TNG.PDF"
                ElseIf CB_Width.Text = "8.5" Then
                    If CBox_BeaverTail.Checked Then
                        fn(printcnt) = "FRM, ST - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC+BT.PDF"
                    Else
                        fn(printcnt) = "FRM, ST - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC-BT.PDF"
                    End If
                Else
                    fn(printcnt) = "FRM, ST - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC.PDF"
                End If
            End If

            If (DL = "ALL") Or (DL = "SDW") Then ' *** Side Wall ***
                printcnt = printcnt + 1
                If CB_Width.Text = "5.0" Then
                    If CBox_Door.Checked Then
                        fn(printcnt) = "SDW, ST - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC+DR-OA.PDF"
                    Else
                        fn(printcnt) = "SDW, ST - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC-DR-OA.PDF"
                    End If
                ElseIf CB_Width.Text = "8.5" Then
                    fn(printcnt) = "SDW, ST - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC.PDF"
                Else
                    fn(printcnt) = "SDW, ST - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC-OA.PDF"
                End If
            End If

            If (DL = "ALL") Or (DL = "RMP") Then ' *** Ramp ***
                If CB_RearDoorOpt.Text = "Ramp Doors" Then
                    printcnt = printcnt + 1
                    If CB_Width.Text = "8.5" Then
                        fn(printcnt) = "RMP, ST - " + RampROWidth.ToString("0") + "x" + CStr(TlrHt) + BeaverTail + "+BH.PDF"
                        'fn(printcnt) = "RMP, ST - " + CStr(RampROWidth) + "x" + CStr(RampROHeight) + ", BH.PDF"
                        'fn(printcnt) = "RMP, ST - " + RampROWidth.ToString("0.0") + "x" + RampROHeight.ToString("0.0") + ", BH.PDF"
                    Else
                        fn(printcnt) = "RMP, ST - " + CB_Width.Text + "x" + CStr(TlrHt) + ".PDF"
                    End If
                End If
            End If

            If (DL = "ALL") Or (DL = "ROF") Then ' *** Roof ***
                printcnt = printcnt + 1
                If CB_Width.Text = "8.5" Then
                    fn(printcnt) = "ROF, ST - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_RoofCrossMember.Text + "OC.PDF"
                Else
                    fn(printcnt) = "ROF, ST - " + CB_Width.Text + "x" + CB_Length.Text + ".PDF"
                End If

            End If

            If (DL = "ALL") Or (DL = "FRW") Then ' *** Front Wall ***
                printcnt = printcnt + 1
                fn(printcnt) = "FRW, ST - " + CB_Width.Text + "" + CStr(NoseConfig) + "" + CB_CC.Text + ".PDF"
            End If

            If (DL = "ALL") Or (DL = "RRW") Then ' *** Rear Wall ***
                printcnt = printcnt + 1
                fn(printcnt) = "RRW, ST - " + CB_Width.Text + "x" + CStr(TlrHt) + BeaverTail + ".PDF"
            End If

            ' *** RAVEN LITE ALUMINUM TRAILER *************************************************************************************************
        ElseIf CB_Trailer.Text = "RAVAN LITE CARGO (ALUMINUM)" Then

            If (DL = "ALL") Or (DL = "MTL") Then ' *** METAL CUT LIST ***
                If CB_Width.Text = "5.0" Or CB_Width.Text = "6.0" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "MTLCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + DoorOpt + ".PDF"
                ElseIf CB_Width.Text = "8.5" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "MTLCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + CB_CC.Text + BeaverTail + ".PDF"
                    'MTLCL - 8.5x16x78+0+R+CC+BT
                Else
                    printcnt = printcnt + 1
                    fn(printcnt) = "MTLCL, AL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
                    ' MTLCL, AL - 5.0x08x66+0-R-DR  
                End If
            End If

            If (DL = "ALL") Or (DL = "WOOD") Then ' *** METAL CUT LIST ***
                If CB_Width.Text = "5.0" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + DoorOpt + ".PDF"
                ElseIf CB_Width.Text = "6.0" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
                ElseIf CB_Width.Text = "7.0" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
                ElseIf CB_Width.Text = "8.5" Then
                    printcnt = printcnt + 1
                    fn(printcnt) = "WDCL - " + CB_Width.Text + "x" + CB_Length.Text + "x" + CStr(TlrHt) + NoseConfig + RampOpt + ".PDF"
                End If
            End If

            If (DL = "ALL") Or (DL = "FRM") Then ' ****** FRAME ******
                printcnt = printcnt + 1
                If CB_Width.Text = "8.5" Then
                    If CBox_BeaverTail.Checked Then
                        fn(printcnt) = "FRM, AL - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC+BT.PDF"
                    Else
                        fn(printcnt) = "FRM, AL - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC-BT.PDF"
                    End If
                Else
                    fn(printcnt) = "FRM, AL - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_CrossMember.Text + "OC.PDF"
                End If

                If CB_TorsionAxle.Checked Then
                Else
                    printcnt = printcnt + 1
                    If CB_Width.Text = "7.0" Or CB_Width.Text = "8.5" Then
                        fn(printcnt) = "AXLE MOUNT BRKT, ST - 64.0.PDF"
                    Else
                        If CB_Length.Text = "12" Or CB_CrossMember.Text = "16" Then
                            fn(printcnt) = "AXLE MOUNT BRKT, ST - 31.0x4.5x20.5.PDF"
                        ElseIf CB_Length.Text = "10" And CB_CrossMember.Text = "24" Then
                            'MsgBox(CB_Length.Text)
                            fn(printcnt) = "AXLE MOUNT BRKT, ST - 31.0x12.5.PDF"
                        ElseIf CB_Length.Text = "08" And CB_CrossMember.Text = "24" Then
                            'MsgBox(CB_Length.Text)
                            fn(printcnt) = "AXLE MOUNT BRKT, ST - 31.0x4.5x28.5.PDF"
                        End If
                    End If
                End If
            End If

            If (DL = "ALL") Or (DL = "SDW") Then ' *** Side Wall ***
                printcnt = printcnt + 1
                If CB_Width.Text = "5.0" Then
                    If CBox_Door.Checked Then
                        fn(printcnt) = "SDW, AL - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC+DR-OA.PDF"
                    Else
                        fn(printcnt) = "SDW, AL - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC-DR-OA.PDF"
                    End If
                ElseIf CB_Width.Text = "8.5" Then
                    fn(printcnt) = "SDW, AL - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC.PDF"
                Else
                    fn(printcnt) = "SDW, AL - " + CB_Length.Text + "x" + CStr(TlrHt) + "-" + CB_WallCrossMember.Text + "OC-OA.PDF"
                End If
            End If

            If (DL = "ALL") Or (DL = "RMP") Then ' ****** RAMP ******
                If CB_RearDoorOpt.Text = "Ramp Doors" Then
                    printcnt = printcnt + 1
                    If CB_Width.Text = "8.5" Then
                        fn(printcnt) = "RMP, AL - " + RampROWidth.ToString("0.0") + "x" + RampROHeight.ToString("0.0") + "+BH.PDF"
                    Else
                        fn(printcnt) = "RMP, AL - " + CB_Width.Text + "x" + CStr(TlrHt) + ".PDF"
                    End If
                End If
            End If

            If (DL = "ALL") Or (DL = "ROF") Then ' ****** ROOF ******
                printcnt = printcnt + 1
                If CB_Width.Text = "8.5" Then
                    fn(printcnt) = "ROF, AL - " + CB_Width.Text + "x" + CB_Length.Text + "-" + CB_RoofCrossMember.Text + "OC.PDF"
                Else
                    fn(printcnt) = "ROF, AL - " + CB_Width.Text + "x" + CB_Length.Text + ".PDF"
                End If
            End If

            If (DL = "ALL") Or (DL = "FRW") Then ' ****** FRONT WALL ******
                printcnt = printcnt + 1
                fn(printcnt) = "FRW, AL - " + CB_Width.Text + "" + CStr(NoseConfig) + "" + CB_CC.Text + ".PDF"
            End If

            If (DL = "ALL") Or (DL = "RRW") Then ' ****** REAR WALL ******
                printcnt = printcnt + 1
                fn(printcnt) = "RRW, AL - " + CB_Width.Text + "x" + CStr(TlrHt) + BeaverTail + ".PDF"
            End If
        Else
            MsgBox("Your Mistake, try again")
        End If

        For i As Integer = 1 To printcnt
            strFile = strDirectory + fn(i)
            strFileCk = FileIO.FileSystem.FileExists(strFile)
            If System.IO.File.Exists(strFile) Then
                If System.IO.Directory.Exists(FolderDir) Then
                    'System.IO.File.Copy(strFile, )
                Else
                    System.IO.Directory.CreateDirectory(FolderDir)
                End If
                dirfn = FolderDir + "\" + fn(i)

                If System.IO.File.Exists(dirfn) Then
                    System.IO.File.Delete(dirfn)
                    System.IO.File.Copy(strFile, dirfn)
                Else
                    System.IO.File.Copy(strFile, dirfn)
                End If

                'strFile = strDirectory + fn(i)
                psi.UseShellExecute = True
                psi.Verb = "print"
                psi.WindowStyle = ProcessWindowStyle.Hidden
                psi.FileName = strFile
                Process.Start(psi)
            Else
                MsgBox("Drawing does not Exist" + strFile + " " + strFileCk)
            End If
        Next
    End Function

    Private Sub B_PrintSideWall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_PrintSideWall.Click

        Dim tmpvar As String
        DL = "SDW"
        tmpvar = PrintDwg(DL)

    End Sub

    Private Sub B_PrintRoof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_PrintRoof.Click

        Dim tmpvar As String
        DL = "ROF"
        tmpvar = PrintDwg(DL)

    End Sub

    Private Sub B_PrintFRW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_PrintFRW.Click

        Dim tmpvar As String
        DL = "FRW"
        tmpvar = PrintDwg(DL)

    End Sub

    Private Sub B_PrintRamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_PrintRamp.Click

        Dim tmpvar As String
        DL = "RMP"
        tmpvar = PrintDwg(DL)

    End Sub


    Private Sub B_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Exit.Click
        Me.Close()
    End Sub

    Private Sub B_PrintRRW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_PrintRRW.Click
        Dim tmpvar As String
        DL = "RRW"
        tmpvar = PrintDwg(DL)
    End Sub

    Private Sub CBox_BeaverTail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBox_BeaverTail.CheckedChanged

    End Sub

    Private Sub B_PrintMetalList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_PrintMetalList.Click
        Dim tmpvar As String
        DL = "MTL"
        tmpvar = PrintDwg(DL)

    End Sub

    Private Sub B_PrintWoodList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_PrintWoodList.Click
        Dim tmpvar As String
        DL = "WOOD"
        tmpvar = PrintDwg(DL)
    End Sub

    Private Sub CBox_Color_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBox_Color.SelectedIndexChanged

    End Sub

    Private Sub CB_AxleSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_AxleSize.SelectedIndexChanged

    End Sub



    Private Sub CB_TORSION_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_TorsionAxle.CheckedChanged

    End Sub



End Class
