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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TiemposDeEsperaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L4AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiemposDeEsperaToolStripMenuItem, Me.GenerarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(495, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TiemposDeEsperaToolStripMenuItem
        '
        Me.TiemposDeEsperaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L4AToolStripMenuItem, Me.L4ToolStripMenuItem, Me.L5ToolStripMenuItem, Me.L2ToolStripMenuItem})
        Me.TiemposDeEsperaToolStripMenuItem.Name = "TiemposDeEsperaToolStripMenuItem"
        Me.TiemposDeEsperaToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.TiemposDeEsperaToolStripMenuItem.Text = "Generar mt.conf"
        '
        'L4AToolStripMenuItem
        '
        Me.L4AToolStripMenuItem.Name = "L4AToolStripMenuItem"
        Me.L4AToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.L4AToolStripMenuItem.Text = "L2"
        '
        'L4ToolStripMenuItem
        '
        Me.L4ToolStripMenuItem.Name = "L4ToolStripMenuItem"
        Me.L4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.L4ToolStripMenuItem.Text = "L4"
        '
        'L5ToolStripMenuItem
        '
        Me.L5ToolStripMenuItem.Name = "L5ToolStripMenuItem"
        Me.L5ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.L5ToolStripMenuItem.Text = "L4A"
        '
        'L2ToolStripMenuItem
        '
        Me.L2ToolStripMenuItem.Name = "L2ToolStripMenuItem"
        Me.L2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.L2ToolStripMenuItem.Text = "L5"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.GenerarToolStripMenuItem.Text = "Generar ptar.conf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(495, 444)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Orianna V.1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TiemposDeEsperaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L4AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
