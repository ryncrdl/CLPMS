<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROPERTYMANAGEMENTADD
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpermit = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdescription = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtamenities = New MetroFramework.Controls.MetroTextBox()
        Me.txtsq = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdate = New MetroFramework.Controls.MetroDateTime()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(182, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "Create Property"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.Label9)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.Black
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(-37, -2)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(453, 47)
        Me.Guna2GradientPanel2.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Date of Establish"
        '
        'txtpermit
        '
        '
        '
        '
        Me.txtpermit.CustomButton.Image = Nothing
        Me.txtpermit.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtpermit.CustomButton.Name = ""
        Me.txtpermit.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtpermit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpermit.CustomButton.TabIndex = 1
        Me.txtpermit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpermit.CustomButton.UseSelectable = True
        Me.txtpermit.CustomButton.Visible = False
        Me.txtpermit.Lines = New String(-1) {}
        Me.txtpermit.Location = New System.Drawing.Point(30, 270)
        Me.txtpermit.MaxLength = 32767
        Me.txtpermit.Name = "txtpermit"
        Me.txtpermit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpermit.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpermit.SelectedText = ""
        Me.txtpermit.SelectionLength = 0
        Me.txtpermit.SelectionStart = 0
        Me.txtpermit.ShortcutsEnabled = True
        Me.txtpermit.Size = New System.Drawing.Size(335, 30)
        Me.txtpermit.TabIndex = 162
        Me.txtpermit.UseSelectable = True
        Me.txtpermit.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpermit.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "Permit"
        '
        'txtdescription
        '
        '
        '
        '
        Me.txtdescription.CustomButton.Image = Nothing
        Me.txtdescription.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtdescription.CustomButton.Name = ""
        Me.txtdescription.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtdescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdescription.CustomButton.TabIndex = 1
        Me.txtdescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdescription.CustomButton.UseSelectable = True
        Me.txtdescription.CustomButton.Visible = False
        Me.txtdescription.Lines = New String(-1) {}
        Me.txtdescription.Location = New System.Drawing.Point(30, 211)
        Me.txtdescription.MaxLength = 32767
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdescription.SelectedText = ""
        Me.txtdescription.SelectionLength = 0
        Me.txtdescription.SelectionStart = 0
        Me.txtdescription.ShortcutsEnabled = True
        Me.txtdescription.Size = New System.Drawing.Size(335, 30)
        Me.txtdescription.TabIndex = 160
        Me.txtdescription.UseSelectable = True
        Me.txtdescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Amenities"
        '
        'txtamenities
        '
        '
        '
        '
        Me.txtamenities.CustomButton.Image = Nothing
        Me.txtamenities.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtamenities.CustomButton.Name = ""
        Me.txtamenities.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtamenities.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtamenities.CustomButton.TabIndex = 1
        Me.txtamenities.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtamenities.CustomButton.UseSelectable = True
        Me.txtamenities.CustomButton.Visible = False
        Me.txtamenities.Lines = New String(-1) {}
        Me.txtamenities.Location = New System.Drawing.Point(30, 151)
        Me.txtamenities.MaxLength = 32767
        Me.txtamenities.Name = "txtamenities"
        Me.txtamenities.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamenities.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtamenities.SelectedText = ""
        Me.txtamenities.SelectionLength = 0
        Me.txtamenities.SelectionStart = 0
        Me.txtamenities.ShortcutsEnabled = True
        Me.txtamenities.Size = New System.Drawing.Size(335, 30)
        Me.txtamenities.TabIndex = 158
        Me.txtamenities.UseSelectable = True
        Me.txtamenities.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtamenities.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtsq
        '
        '
        '
        '
        Me.txtsq.CustomButton.Image = Nothing
        Me.txtsq.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtsq.CustomButton.Name = ""
        Me.txtsq.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtsq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsq.CustomButton.TabIndex = 1
        Me.txtsq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsq.CustomButton.UseSelectable = True
        Me.txtsq.CustomButton.Visible = False
        Me.txtsq.Lines = New String(-1) {}
        Me.txtsq.Location = New System.Drawing.Point(30, 89)
        Me.txtsq.MaxLength = 32767
        Me.txtsq.Name = "txtsq"
        Me.txtsq.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsq.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsq.SelectedText = ""
        Me.txtsq.SelectionLength = 0
        Me.txtsq.SelectionStart = 0
        Me.txtsq.ShortcutsEnabled = True
        Me.txtsq.Size = New System.Drawing.Size(335, 30)
        Me.txtsq.TabIndex = 156
        Me.txtsq.UseSelectable = True
        Me.txtsq.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsq.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "Square meter"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCancel.FillColor = System.Drawing.Color.DimGray
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(208, 389)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(157, 45)
        Me.BtnCancel.TabIndex = 151
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnAdd
        '
        Me.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAdd.FillColor = System.Drawing.Color.DimGray
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(30, 389)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(157, 45)
        Me.BtnAdd.TabIndex = 150
        Me.BtnAdd.Text = "Confirm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 29)
        Me.Label3.TabIndex = 146
        '
        'txtdate
        '
        Me.txtdate.CustomFormat = "dd/MM/yyy"
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdate.Location = New System.Drawing.Point(29, 325)
        Me.txtdate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(336, 29)
        Me.txtdate.TabIndex = 166
        '
        'PROPERTYMANAGEMENTADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CLPMS.My.Resources.Resources.CLPMSplain
        Me.ClientSize = New System.Drawing.Size(395, 460)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpermit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtamenities)
        Me.Controls.Add(Me.txtsq)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PROPERTYMANAGEMENTADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create new property"
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpermit As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtamenities As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtsq As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdate As MetroFramework.Controls.MetroDateTime
End Class
