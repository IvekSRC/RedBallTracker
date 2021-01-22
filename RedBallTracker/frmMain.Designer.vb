<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.tlpOuter = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpInner = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPauseOrResume = New System.Windows.Forms.Button()
        Me.txtXYRadius = New System.Windows.Forms.TextBox()
        Me.ibOriginal = New Emgu.CV.UI.ImageBox()
        Me.ibThresh = New Emgu.CV.UI.ImageBox()
        Me.tlpOuter.SuspendLayout()
        Me.tlpInner.SuspendLayout()
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ibThresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpOuter
        '
        Me.tlpOuter.ColumnCount = 2
        Me.tlpOuter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpOuter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpOuter.Controls.Add(Me.tlpInner, 0, 1)
        Me.tlpOuter.Controls.Add(Me.ibOriginal, 0, 0)
        Me.tlpOuter.Controls.Add(Me.ibThresh, 1, 0)
        Me.tlpOuter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOuter.Location = New System.Drawing.Point(0, 0)
        Me.tlpOuter.Name = "tlpOuter"
        Me.tlpOuter.RowCount = 2
        Me.tlpOuter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpOuter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpOuter.Size = New System.Drawing.Size(1260, 592)
        Me.tlpOuter.TabIndex = 0
        '
        'tlpInner
        '
        Me.tlpInner.ColumnCount = 2
        Me.tlpOuter.SetColumnSpan(Me.tlpInner, 2)
        Me.tlpInner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpInner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInner.Controls.Add(Me.btnPauseOrResume, 0, 0)
        Me.tlpInner.Controls.Add(Me.txtXYRadius, 1, 0)
        Me.tlpInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInner.Location = New System.Drawing.Point(3, 476)
        Me.tlpInner.Name = "tlpInner"
        Me.tlpInner.RowCount = 1
        Me.tlpInner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInner.Size = New System.Drawing.Size(1254, 113)
        Me.tlpInner.TabIndex = 0
        '
        'btnPauseOrResume
        '
        Me.btnPauseOrResume.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPauseOrResume.AutoSize = True
        Me.btnPauseOrResume.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPauseOrResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseOrResume.Location = New System.Drawing.Point(3, 39)
        Me.btnPauseOrResume.Name = "btnPauseOrResume"
        Me.btnPauseOrResume.Size = New System.Drawing.Size(83, 35)
        Me.btnPauseOrResume.TabIndex = 0
        Me.btnPauseOrResume.Text = "Pause "
        Me.btnPauseOrResume.UseVisualStyleBackColor = True
        '
        'txtXYRadius
        '
        Me.txtXYRadius.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtXYRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXYRadius.Location = New System.Drawing.Point(92, 3)
        Me.txtXYRadius.Multiline = True
        Me.txtXYRadius.Name = "txtXYRadius"
        Me.txtXYRadius.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXYRadius.Size = New System.Drawing.Size(1159, 107)
        Me.txtXYRadius.TabIndex = 1
        Me.txtXYRadius.WordWrap = False
        '
        'ibOriginal
        '
        Me.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ibOriginal.Enabled = False
        Me.ibOriginal.Location = New System.Drawing.Point(3, 3)
        Me.ibOriginal.Name = "ibOriginal"
        Me.ibOriginal.Size = New System.Drawing.Size(624, 467)
        Me.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ibOriginal.TabIndex = 2
        Me.ibOriginal.TabStop = False
        '
        'ibThresh
        '
        Me.ibThresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ibThresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ibThresh.Enabled = False
        Me.ibThresh.Location = New System.Drawing.Point(633, 3)
        Me.ibThresh.Name = "ibThresh"
        Me.ibThresh.Size = New System.Drawing.Size(624, 467)
        Me.ibThresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ibThresh.TabIndex = 2
        Me.ibThresh.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 592)
        Me.Controls.Add(Me.tlpOuter)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.tlpOuter.ResumeLayout(False)
        Me.tlpInner.ResumeLayout(False)
        Me.tlpInner.PerformLayout()
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ibThresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpOuter As TableLayoutPanel
    Friend WithEvents tlpInner As TableLayoutPanel
    Friend WithEvents btnPauseOrResume As Button
    Friend WithEvents txtXYRadius As TextBox
    Friend WithEvents ibOriginal As Emgu.CV.UI.ImageBox
    Friend WithEvents ibThresh As Emgu.CV.UI.ImageBox
End Class
