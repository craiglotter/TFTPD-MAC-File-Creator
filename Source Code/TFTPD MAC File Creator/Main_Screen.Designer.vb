<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.cancelAsyncButton = New System.Windows.Forms.Button
        Me.startAsyncButton = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.ToolTip1.SetToolTip(Me.Button1, "Select gallery image source folder (Non-recursive)")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.Location = New System.Drawing.Point(18, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 20)
        Me.TextBox1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Gallery image source folder (Non-recursive)")
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'cancelAsyncButton
        '
        Me.cancelAsyncButton.Enabled = False
        Me.cancelAsyncButton.ForeColor = System.Drawing.Color.Black
        Me.cancelAsyncButton.Location = New System.Drawing.Point(410, 259)
        Me.cancelAsyncButton.Name = "cancelAsyncButton"
        Me.cancelAsyncButton.Size = New System.Drawing.Size(58, 23)
        Me.cancelAsyncButton.TabIndex = 40
        Me.cancelAsyncButton.Text = "Cancel"
        Me.cancelAsyncButton.UseVisualStyleBackColor = True
        '
        'startAsyncButton
        '
        Me.startAsyncButton.ForeColor = System.Drawing.Color.Black
        Me.startAsyncButton.Location = New System.Drawing.Point(346, 259)
        Me.startAsyncButton.Name = "startAsyncButton"
        Me.startAsyncButton.Size = New System.Drawing.Size(58, 23)
        Me.startAsyncButton.TabIndex = 39
        Me.startAsyncButton.Text = "Begin"
        Me.startAsyncButton.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(30, 259)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(310, 23)
        Me.ProgressBar1.TabIndex = 41
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 296)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(497, 22)
        Me.StatusStrip1.TabIndex = 42
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 229)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Inputs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Folder to put generated files in:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(390, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Browse"
        Me.ToolTip1.SetToolTip(Me.Button2, "Select gallery image source folder (Non-recursive)")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox2.Location = New System.Drawing.Point(19, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(365, 20)
        Me.TextBox2.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.TextBox2, "Gallery image source folder (Non-recursive)")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(18, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 91)
        Me.Panel1.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(436, 89)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = "default boot" & Global.Microsoft.VisualBasic.ChrW(10) & "prompt 0" & Global.Microsoft.VisualBasic.ChrW(10) & "say booting..." & Global.Microsoft.VisualBasic.ChrW(10) & "label boot" & Global.Microsoft.VisualBasic.ChrW(10) & "kernel memdisk" & Global.Microsoft.VisualBasic.ChrW(10) & "append initrd=loca" & _
            "l.imz floppy=1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(15, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Generated file content:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Text file containing MAC addresses:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "All Files|*.*"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select the folder to generate the files in"
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 318)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cancelAsyncButton)
        Me.Controls.Add(Me.startAsyncButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(505, 352)
        Me.MinimumSize = New System.Drawing.Size(505, 352)
        Me.Name = "Main_Screen"
        Me.Text = "TFTPD MAC File Creator"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private WithEvents cancelAsyncButton As System.Windows.Forms.Button
    Friend WithEvents startAsyncButton As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

End Class
