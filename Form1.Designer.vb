<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Canvas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Canvas))
        Me.TextBoxInitialVelYComp = New System.Windows.Forms.TextBox()
        Me.PictureBoxCanvas = New System.Windows.Forms.PictureBox()
        Me.ButtonInfoTool = New System.Windows.Forms.Button()
        Me.TextBoxInitialVelXComp = New System.Windows.Forms.TextBox()
        Me.TextBoxYcor = New System.Windows.Forms.TextBox()
        Me.TextBoxXcor = New System.Windows.Forms.TextBox()
        Me.ToolTipPlayBtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBoxDensity = New System.Windows.Forms.TextBox()
        Me.TextBoxRadius = New System.Windows.Forms.TextBox()
        Me.ComboBoxColour = New System.Windows.Forms.ComboBox()
        Me.ButtonDeletePlanet = New System.Windows.Forms.Button()
        Me.ButtonClearAll = New System.Windows.Forms.Button()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.CheckBoxCollision = New System.Windows.Forms.CheckBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.CheckBoxToggleAdvanced = New System.Windows.Forms.CheckBox()
        Me.ButtonAddPlanet = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownSpeed = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxAdvMass = New System.Windows.Forms.TextBox()
        Me.Mass = New System.Windows.Forms.Label()
        Me.TextBoxAdvXpos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxAdvInitialY = New System.Windows.Forms.TextBox()
        Me.TextBoxAdvYpos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxAdvInitialX = New System.Windows.Forms.TextBox()
        Me.TextBoxMouseYcor = New System.Windows.Forms.TextBox()
        Me.TextBoxMouseXcor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxAdvDen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxAdvRad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBoxTrace = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDownSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxInitialVelYComp
        '
        Me.TextBoxInitialVelYComp.Location = New System.Drawing.Point(430, 382)
        Me.TextBoxInitialVelYComp.Name = "TextBoxInitialVelYComp"
        Me.TextBoxInitialVelYComp.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxInitialVelYComp.TabIndex = 19
        Me.TextBoxInitialVelYComp.TabStop = False
        '
        'PictureBoxCanvas
        '
        Me.PictureBoxCanvas.Image = CType(resources.GetObject("PictureBoxCanvas.Image"), System.Drawing.Image)
        Me.PictureBoxCanvas.InitialImage = Nothing
        Me.PictureBoxCanvas.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBoxCanvas.Name = "PictureBoxCanvas"
        Me.PictureBoxCanvas.Size = New System.Drawing.Size(1302, 1056)
        Me.PictureBoxCanvas.TabIndex = 0
        Me.PictureBoxCanvas.TabStop = False
        '
        'ButtonInfoTool
        '
        Me.ButtonInfoTool.Location = New System.Drawing.Point(26, 11)
        Me.ButtonInfoTool.Name = "ButtonInfoTool"
        Me.ButtonInfoTool.Size = New System.Drawing.Size(118, 23)
        Me.ButtonInfoTool.TabIndex = 28
        Me.ButtonInfoTool.TabStop = False
        Me.ButtonInfoTool.Tag = "hkjhkjhkhj"
        Me.ButtonInfoTool.Text = "Information Tool"
        Me.ToolTipPlayBtn.SetToolTip(Me.ButtonInfoTool, "Click on a planet with this tool selected (and with the advanced tab open) to see" & _
        " details about it")
        Me.ButtonInfoTool.UseVisualStyleBackColor = True
        '
        'TextBoxInitialVelXComp
        '
        Me.TextBoxInitialVelXComp.Location = New System.Drawing.Point(430, 360)
        Me.TextBoxInitialVelXComp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxInitialVelXComp.Name = "TextBoxInitialVelXComp"
        Me.TextBoxInitialVelXComp.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxInitialVelXComp.TabIndex = 22
        Me.TextBoxInitialVelXComp.TabStop = False
        '
        'TextBoxYcor
        '
        Me.TextBoxYcor.Location = New System.Drawing.Point(431, 431)
        Me.TextBoxYcor.Name = "TextBoxYcor"
        Me.TextBoxYcor.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxYcor.TabIndex = 19
        Me.TextBoxYcor.TabStop = False
        '
        'TextBoxXcor
        '
        Me.TextBoxXcor.Location = New System.Drawing.Point(431, 410)
        Me.TextBoxXcor.Name = "TextBoxXcor"
        Me.TextBoxXcor.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxXcor.TabIndex = 18
        Me.TextBoxXcor.TabStop = False
        '
        'TextBoxDensity
        '
        Me.TextBoxDensity.Location = New System.Drawing.Point(57, 87)
        Me.TextBoxDensity.Name = "TextBoxDensity"
        Me.TextBoxDensity.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDensity.TabIndex = 4
        Me.ToolTipPlayBtn.SetToolTip(Me.TextBoxDensity, "Specify the density of the planet you want to create. Must be integer between 1 a" & _
        "nd 1000")
        '
        'TextBoxRadius
        '
        Me.TextBoxRadius.Location = New System.Drawing.Point(57, 63)
        Me.TextBoxRadius.Name = "TextBoxRadius"
        Me.TextBoxRadius.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRadius.TabIndex = 3
        Me.ToolTipPlayBtn.SetToolTip(Me.TextBoxRadius, "Specify the radius of the planet you want to create. Must be integer between 1 an" & _
        "d 120")
        '
        'ComboBoxColour
        '
        Me.ComboBoxColour.FormattingEnabled = True
        Me.ComboBoxColour.Items.AddRange(New Object() {"Grey", "Green", "Blue", "Red", "Yellow"})
        Me.ComboBoxColour.Location = New System.Drawing.Point(57, 112)
        Me.ComboBoxColour.Name = "ComboBoxColour"
        Me.ComboBoxColour.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxColour.TabIndex = 5
        Me.ToolTipPlayBtn.SetToolTip(Me.ComboBoxColour, "Specify the colour of the planet you would like to create")
        '
        'ButtonDeletePlanet
        '
        Me.ButtonDeletePlanet.Location = New System.Drawing.Point(28, 34)
        Me.ButtonDeletePlanet.Name = "ButtonDeletePlanet"
        Me.ButtonDeletePlanet.Size = New System.Drawing.Size(118, 23)
        Me.ButtonDeletePlanet.TabIndex = 2
        Me.ButtonDeletePlanet.TabStop = False
        Me.ButtonDeletePlanet.Text = "Delete Planet Tool"
        Me.ToolTipPlayBtn.SetToolTip(Me.ButtonDeletePlanet, "This tool allows you to delete a planet when you click on it. Shift-D")
        Me.ButtonDeletePlanet.UseVisualStyleBackColor = True
        '
        'ButtonClearAll
        '
        Me.ButtonClearAll.Location = New System.Drawing.Point(26, 167)
        Me.ButtonClearAll.Name = "ButtonClearAll"
        Me.ButtonClearAll.Size = New System.Drawing.Size(118, 23)
        Me.ButtonClearAll.TabIndex = 7
        Me.ButtonClearAll.TabStop = False
        Me.ButtonClearAll.Text = "Clear All"
        Me.ToolTipPlayBtn.SetToolTip(Me.ButtonClearAll, "This button stops the model and deletes all objects")
        Me.ButtonClearAll.UseVisualStyleBackColor = True
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Location = New System.Drawing.Point(26, 138)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(118, 23)
        Me.ButtonPlay.TabIndex = 6
        Me.ButtonPlay.TabStop = False
        Me.ButtonPlay.Text = "Play"
        Me.ToolTipPlayBtn.SetToolTip(Me.ButtonPlay, "Click here to run simulation. Shift-R")
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'CheckBoxCollision
        '
        Me.CheckBoxCollision.AutoSize = True
        Me.CheckBoxCollision.Location = New System.Drawing.Point(33, 195)
        Me.CheckBoxCollision.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBoxCollision.Name = "CheckBoxCollision"
        Me.CheckBoxCollision.Size = New System.Drawing.Size(111, 17)
        Me.CheckBoxCollision.TabIndex = 23
        Me.CheckBoxCollision.Text = "Merge on collision"
        Me.ToolTipPlayBtn.SetToolTip(Me.CheckBoxCollision, "With this switched on planets will combine when they overlap")
        Me.CheckBoxCollision.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(28, 239)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(118, 23)
        Me.ButtonSave.TabIndex = 24
        Me.ButtonSave.Text = "Save Simulation"
        Me.ToolTipPlayBtn.SetToolTip(Me.ButtonSave, "Click to save your simulation")
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(28, 266)
        Me.ButtonLoad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(118, 23)
        Me.ButtonLoad.TabIndex = 25
        Me.ButtonLoad.Text = "Load Simulation"
        Me.ToolTipPlayBtn.SetToolTip(Me.ButtonLoad, "Click to open a saved simulation")
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'CheckBoxToggleAdvanced
        '
        Me.CheckBoxToggleAdvanced.AutoSize = True
        Me.CheckBoxToggleAdvanced.Location = New System.Drawing.Point(33, 292)
        Me.CheckBoxToggleAdvanced.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBoxToggleAdvanced.Name = "CheckBoxToggleAdvanced"
        Me.CheckBoxToggleAdvanced.Size = New System.Drawing.Size(105, 17)
        Me.CheckBoxToggleAdvanced.TabIndex = 27
        Me.CheckBoxToggleAdvanced.Text = "Show Advanced"
        Me.ToolTipPlayBtn.SetToolTip(Me.CheckBoxToggleAdvanced, "Gives details on the Mass, velocity and posistion of a selected planet")
        Me.CheckBoxToggleAdvanced.UseVisualStyleBackColor = True
        '
        'ButtonAddPlanet
        '
        Me.ButtonAddPlanet.Location = New System.Drawing.Point(28, 6)
        Me.ButtonAddPlanet.Name = "ButtonAddPlanet"
        Me.ButtonAddPlanet.Size = New System.Drawing.Size(118, 23)
        Me.ButtonAddPlanet.TabIndex = 1
        Me.ButtonAddPlanet.TabStop = False
        Me.ButtonAddPlanet.Tag = "hkjhkjhkhj"
        Me.ButtonAddPlanet.Text = "Add Planet Tool"
        Me.ToolTipPlayBtn.SetToolTip(Me.ButtonAddPlanet, "This tool will create a planet with the data specified below, when you click on t" & _
        "he canvas. Shift-A")
        Me.ButtonAddPlanet.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Radius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Density"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Colour"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ButtonInfoTool)
        Me.Panel1.Controls.Add(Me.NumericUpDownSpeed)
        Me.Panel1.Controls.Add(Me.TextBoxAdvMass)
        Me.Panel1.Controls.Add(Me.Mass)
        Me.Panel1.Controls.Add(Me.TextBoxAdvXpos)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TextBoxAdvInitialY)
        Me.Panel1.Controls.Add(Me.TextBoxAdvYpos)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TextBoxAdvInitialX)
        Me.Panel1.Controls.Add(Me.TextBoxMouseYcor)
        Me.Panel1.Controls.Add(Me.TextBoxMouseXcor)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBoxAdvDen)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBoxAdvRad)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(4, 313)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 288)
        Me.Panel1.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Simulation Speed"
        '
        'NumericUpDownSpeed
        '
        Me.NumericUpDownSpeed.Location = New System.Drawing.Point(118, 259)
        Me.NumericUpDownSpeed.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDownSpeed.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownSpeed.Name = "NumericUpDownSpeed"
        Me.NumericUpDownSpeed.Size = New System.Drawing.Size(34, 20)
        Me.NumericUpDownSpeed.TabIndex = 33
        '
        'TextBoxAdvMass
        '
        Me.TextBoxAdvMass.Location = New System.Drawing.Point(86, 190)
        Me.TextBoxAdvMass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxAdvMass.Name = "TextBoxAdvMass"
        Me.TextBoxAdvMass.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxAdvMass.TabIndex = 32
        '
        'Mass
        '
        Me.Mass.AutoSize = True
        Me.Mass.Location = New System.Drawing.Point(46, 193)
        Me.Mass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Mass.Name = "Mass"
        Me.Mass.Size = New System.Drawing.Size(32, 13)
        Me.Mass.TabIndex = 31
        Me.Mass.Text = "Mass"
        '
        'TextBoxAdvXpos
        '
        Me.TextBoxAdvXpos.Location = New System.Drawing.Point(86, 142)
        Me.TextBoxAdvXpos.Name = "TextBoxAdvXpos"
        Me.TextBoxAdvXpos.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxAdvXpos.TabIndex = 23
        Me.TextBoxAdvXpos.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 238)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Mouse Y Position"
        '
        'TextBoxAdvInitialY
        '
        Me.TextBoxAdvInitialY.Location = New System.Drawing.Point(86, 118)
        Me.TextBoxAdvInitialY.Name = "TextBoxAdvInitialY"
        Me.TextBoxAdvInitialY.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxAdvInitialY.TabIndex = 24
        Me.TextBoxAdvInitialY.TabStop = False
        '
        'TextBoxAdvYpos
        '
        Me.TextBoxAdvYpos.Location = New System.Drawing.Point(86, 167)
        Me.TextBoxAdvYpos.Name = "TextBoxAdvYpos"
        Me.TextBoxAdvYpos.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxAdvYpos.TabIndex = 25
        Me.TextBoxAdvYpos.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 214)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Mouse X Position"
        '
        'TextBoxAdvInitialX
        '
        Me.TextBoxAdvInitialX.Location = New System.Drawing.Point(86, 94)
        Me.TextBoxAdvInitialX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxAdvInitialX.Name = "TextBoxAdvInitialX"
        Me.TextBoxAdvInitialX.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxAdvInitialX.TabIndex = 26
        Me.TextBoxAdvInitialX.TabStop = False
        '
        'TextBoxMouseYcor
        '
        Me.TextBoxMouseYcor.Location = New System.Drawing.Point(119, 236)
        Me.TextBoxMouseYcor.Name = "TextBoxMouseYcor"
        Me.TextBoxMouseYcor.Size = New System.Drawing.Size(36, 20)
        Me.TextBoxMouseYcor.TabIndex = 28
        Me.TextBoxMouseYcor.TabStop = False
        '
        'TextBoxMouseXcor
        '
        Me.TextBoxMouseXcor.Location = New System.Drawing.Point(118, 214)
        Me.TextBoxMouseXcor.Name = "TextBoxMouseXcor"
        Me.TextBoxMouseXcor.Size = New System.Drawing.Size(36, 20)
        Me.TextBoxMouseXcor.TabIndex = 27
        Me.TextBoxMouseXcor.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 120)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Initial Velocity Y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 169)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Y Position"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 144)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "X Position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Initial Velocity X"
        '
        'TextBoxAdvDen
        '
        Me.TextBoxAdvDen.Location = New System.Drawing.Point(86, 72)
        Me.TextBoxAdvDen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxAdvDen.Name = "TextBoxAdvDen"
        Me.TextBoxAdvDen.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxAdvDen.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Density"
        '
        'TextBoxAdvRad
        '
        Me.TextBoxAdvRad.Location = New System.Drawing.Point(86, 44)
        Me.TextBoxAdvRad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxAdvRad.Name = "TextBoxAdvRad"
        Me.TextBoxAdvRad.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxAdvRad.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Radius"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CheckBoxTrace)
        Me.Panel2.Controls.Add(Me.CheckBoxToggleAdvanced)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.ButtonLoad)
        Me.Panel2.Controls.Add(Me.ButtonSave)
        Me.Panel2.Controls.Add(Me.CheckBoxCollision)
        Me.Panel2.Controls.Add(Me.ButtonPlay)
        Me.Panel2.Controls.Add(Me.ButtonAddPlanet)
        Me.Panel2.Controls.Add(Me.ButtonClearAll)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ButtonDeletePlanet)
        Me.Panel2.Controls.Add(Me.ComboBoxColour)
        Me.Panel2.Controls.Add(Me.TextBoxRadius)
        Me.Panel2.Controls.Add(Me.TextBoxDensity)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(614, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 664)
        Me.Panel2.TabIndex = 18
        '
        'CheckBoxTrace
        '
        Me.CheckBoxTrace.AutoSize = True
        Me.CheckBoxTrace.Location = New System.Drawing.Point(33, 217)
        Me.CheckBoxTrace.Name = "CheckBoxTrace"
        Me.CheckBoxTrace.Size = New System.Drawing.Size(92, 17)
        Me.CheckBoxTrace.TabIndex = 29
        Me.CheckBoxTrace.Text = "Trace Planets"
        Me.CheckBoxTrace.UseVisualStyleBackColor = True
        '
        'Canvas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 989)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBoxCanvas)
        Me.Controls.Add(Me.TextBoxXcor)
        Me.Controls.Add(Me.TextBoxInitialVelYComp)
        Me.Controls.Add(Me.TextBoxYcor)
        Me.Controls.Add(Me.TextBoxInitialVelXComp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Canvas"
        Me.Text = "Gravitas"
        CType(Me.PictureBoxCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDownSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxInitialVelYComp As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxYcor As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxXcor As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInitialVelXComp As TextBox
    Friend WithEvents ToolTipPlayBtn As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ButtonInfoTool As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDensity As TextBox
    Friend WithEvents TextBoxRadius As TextBox
    Friend WithEvents ComboBoxColour As ComboBox
    Friend WithEvents ButtonDeletePlanet As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonClearAll As Button
    Friend WithEvents ButtonPlay As Button
    Friend WithEvents CheckBoxCollision As CheckBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonLoad As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxAdvMass As TextBox
    Friend WithEvents Mass As Label
    Friend WithEvents TextBoxAdvXpos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxAdvInitialY As TextBox
    Friend WithEvents TextBoxAdvYpos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxAdvInitialX As TextBox
    Friend WithEvents TextBoxMouseYcor As TextBox
    Friend WithEvents TextBoxMouseXcor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxAdvDen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxAdvRad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBoxToggleAdvanced As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonAddPlanet As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDownSpeed As NumericUpDown
    Friend WithEvents CheckBoxTrace As System.Windows.Forms.CheckBox
End Class
