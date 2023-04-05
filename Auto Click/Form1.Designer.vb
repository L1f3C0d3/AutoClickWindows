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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Right_Button_Pic = New System.Windows.Forms.PictureBox()
        Me.Left_Button_Pic = New System.Windows.Forms.PictureBox()
        Me.Left_Radio_Button = New System.Windows.Forms.RadioButton()
        Me.Right_Radio_Button = New System.Windows.Forms.RadioButton()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Time_Active_CheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Timer_Counter_Label = New System.Windows.Forms.Label()
        Me.Secound_Label = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Escape_Label = New System.Windows.Forms.Label()
        Me.Start_Label = New System.Windows.Forms.Label()
        Me.Hide_Pic = New System.Windows.Forms.PictureBox()
        CType(Me.Right_Button_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Left_Button_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hide_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Right_Button_Pic
        '
        Me.Right_Button_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Right_Button_Pic.Image = Global.Auto_Click.My.Resources.Resources.mouse_right_click_127px
        Me.Right_Button_Pic.Location = New System.Drawing.Point(256, 12)
        Me.Right_Button_Pic.Name = "Right_Button_Pic"
        Me.Right_Button_Pic.Size = New System.Drawing.Size(127, 127)
        Me.Right_Button_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Right_Button_Pic.TabIndex = 4
        Me.Right_Button_Pic.TabStop = False
        '
        'Left_Button_Pic
        '
        Me.Left_Button_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Left_Button_Pic.Image = Global.Auto_Click.My.Resources.Resources.left_click_127px
        Me.Left_Button_Pic.Location = New System.Drawing.Point(50, 12)
        Me.Left_Button_Pic.Name = "Left_Button_Pic"
        Me.Left_Button_Pic.Size = New System.Drawing.Size(127, 127)
        Me.Left_Button_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Left_Button_Pic.TabIndex = 5
        Me.Left_Button_Pic.TabStop = False
        '
        'Left_Radio_Button
        '
        Me.Left_Radio_Button.AutoSize = True
        Me.Left_Radio_Button.Checked = True
        Me.Left_Radio_Button.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Left_Radio_Button.Location = New System.Drawing.Point(61, 145)
        Me.Left_Radio_Button.Name = "Left_Radio_Button"
        Me.Left_Radio_Button.Size = New System.Drawing.Size(103, 17)
        Me.Left_Radio_Button.TabIndex = 6
        Me.Left_Radio_Button.TabStop = True
        Me.Left_Radio_Button.Text = "Left Button Click"
        Me.Left_Radio_Button.UseVisualStyleBackColor = True
        '
        'Right_Radio_Button
        '
        Me.Right_Radio_Button.AutoSize = True
        Me.Right_Radio_Button.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Right_Radio_Button.Location = New System.Drawing.Point(275, 145)
        Me.Right_Radio_Button.Name = "Right_Radio_Button"
        Me.Right_Radio_Button.Size = New System.Drawing.Size(110, 17)
        Me.Right_Radio_Button.TabIndex = 7
        Me.Right_Radio_Button.Text = "Right Button Click"
        Me.Right_Radio_Button.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Auto Click Mouse."
        Me.NotifyIcon1.Visible = True
        '
        'Time_Active_CheckBox
        '
        Me.Time_Active_CheckBox.AutoSize = True
        Me.Time_Active_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Time_Active_CheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Time_Active_CheckBox.Location = New System.Drawing.Point(54, 187)
        Me.Time_Active_CheckBox.Name = "Time_Active_CheckBox"
        Me.Time_Active_CheckBox.Size = New System.Drawing.Size(82, 17)
        Me.Time_Active_CheckBox.TabIndex = 8
        Me.Time_Active_CheckBox.Text = "Active Time"
        Me.Time_Active_CheckBox.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Timer_Counter_Label)
        Me.GroupBox1.Controls.Add(Me.Secound_Label)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(50, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 112)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Your Time."
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(14, 51)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 3
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Timer_Counter_Label
        '
        Me.Timer_Counter_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_Counter_Label.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Timer_Counter_Label.Location = New System.Drawing.Point(140, 40)
        Me.Timer_Counter_Label.Name = "Timer_Counter_Label"
        Me.Timer_Counter_Label.Size = New System.Drawing.Size(185, 41)
        Me.Timer_Counter_Label.TabIndex = 2
        Me.Timer_Counter_Label.Text = "00:00:00"
        Me.Timer_Counter_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Secound_Label
        '
        Me.Secound_Label.AutoSize = True
        Me.Secound_Label.Location = New System.Drawing.Point(11, 31)
        Me.Secound_Label.Name = "Secound_Label"
        Me.Secound_Label.Size = New System.Drawing.Size(58, 13)
        Me.Secound_Label.TabIndex = 0
        Me.Secound_Label.Text = "Secounds:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"})
        Me.ComboBox1.Location = New System.Drawing.Point(262, 187)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(264, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Hotkey Start:"
        '
        'Escape_Label
        '
        Me.Escape_Label.AutoSize = True
        Me.Escape_Label.BackColor = System.Drawing.Color.Transparent
        Me.Escape_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Escape_Label.ForeColor = System.Drawing.Color.Salmon
        Me.Escape_Label.Location = New System.Drawing.Point(47, 331)
        Me.Escape_Label.Name = "Escape_Label"
        Me.Escape_Label.Size = New System.Drawing.Size(150, 17)
        Me.Escape_Label.TabIndex = 12
        Me.Escape_Label.Text = "Press ESC to Disable: "
        '
        'Start_Label
        '
        Me.Start_Label.BackColor = System.Drawing.Color.Transparent
        Me.Start_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Start_Label.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Start_Label.Location = New System.Drawing.Point(220, 330)
        Me.Start_Label.Name = "Start_Label"
        Me.Start_Label.Size = New System.Drawing.Size(165, 17)
        Me.Start_Label.TabIndex = 13
        Me.Start_Label.Text = "Press F2 to Start: "
        Me.Start_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Hide_Pic
        '
        Me.Hide_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Hide_Pic.Image = Global.Auto_Click.My.Resources.Resources.Hide_24px
        Me.Hide_Pic.Location = New System.Drawing.Point(207, 18)
        Me.Hide_Pic.Name = "Hide_Pic"
        Me.Hide_Pic.Size = New System.Drawing.Size(24, 24)
        Me.Hide_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Hide_Pic.TabIndex = 14
        Me.Hide_Pic.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(434, 370)
        Me.Controls.Add(Me.Hide_Pic)
        Me.Controls.Add(Me.Start_Label)
        Me.Controls.Add(Me.Escape_Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Time_Active_CheckBox)
        Me.Controls.Add(Me.Right_Radio_Button)
        Me.Controls.Add(Me.Left_Radio_Button)
        Me.Controls.Add(Me.Left_Button_Pic)
        Me.Controls.Add(Me.Right_Button_Pic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Click"
        Me.TopMost = True
        CType(Me.Right_Button_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Left_Button_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hide_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Right_Button_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Left_Button_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Left_Radio_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Right_Radio_Button As System.Windows.Forms.RadioButton
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Time_Active_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer_Counter_Label As System.Windows.Forms.Label
    Friend WithEvents Secound_Label As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Escape_Label As System.Windows.Forms.Label
    Friend WithEvents Start_Label As System.Windows.Forms.Label
    Friend WithEvents Hide_Pic As System.Windows.Forms.PictureBox

End Class
