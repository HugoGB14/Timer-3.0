<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim TreeNode1 As TreeNode = New TreeNode("Secounds")
        Dim TreeNode2 As TreeNode = New TreeNode("Minutes")
        Dim TreeNode3 As TreeNode = New TreeNode("Hours")
        Dim TreeNode4 As TreeNode = New TreeNode("Mode", New TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Delta = New Timer(components)
        ModeTree = New TreeView()
        TimeText = New Label()
        AddButton = New Button()
        SubButton = New Button()
        StartButton = New Button()
        StopButton = New Button()
        ResetButton = New Button()
        SuspendLayout()
        ' 
        ' Delta
        ' 
        Delta.Enabled = True
        Delta.Interval = 1000
        ' 
        ' ModeTree
        ' 
        ModeTree.Anchor = AnchorStyles.None
        ModeTree.Location = New Point(361, 202)
        ModeTree.Name = "ModeTree"
        TreeNode1.Name = "Sec"
        TreeNode1.NodeFont = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TreeNode1.Text = "Secounds"
        TreeNode2.Name = "Min"
        TreeNode2.NodeFont = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TreeNode2.Text = "Minutes"
        TreeNode3.Name = "Hours"
        TreeNode3.NodeFont = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TreeNode3.Text = "Hours"
        TreeNode4.Name = "Root"
        TreeNode4.NodeFont = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TreeNode4.Text = "Mode"
        ModeTree.Nodes.AddRange(New TreeNode() {TreeNode4})
        ModeTree.Size = New Size(121, 76)
        ModeTree.TabIndex = 0
        ' 
        ' TimeText
        ' 
        TimeText.AutoSize = True
        TimeText.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point)
        TimeText.Location = New Point(146, 103)
        TimeText.Name = "TimeText"
        TimeText.Size = New Size(204, 65)
        TimeText.TabIndex = 1
        TimeText.Text = "00:00:00"
        TimeText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AddButton
        ' 
        AddButton.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        AddButton.Location = New Point(356, 114)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(45, 54)
        AddButton.TabIndex = 2
        AddButton.Text = ">"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' SubButton
        ' 
        SubButton.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        SubButton.Location = New Point(95, 114)
        SubButton.Name = "SubButton"
        SubButton.Size = New Size(45, 54)
        SubButton.TabIndex = 3
        SubButton.Text = "<"
        SubButton.UseVisualStyleBackColor = True
        ' 
        ' StartButton
        ' 
        StartButton.Location = New Point(146, 220)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(75, 23)
        StartButton.TabIndex = 4
        StartButton.Text = "Start"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' StopButton
        ' 
        StopButton.Location = New Point(275, 220)
        StopButton.Name = "StopButton"
        StopButton.Size = New Size(75, 23)
        StopButton.TabIndex = 5
        StopButton.Text = "Stop"
        StopButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(210, 249)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(75, 23)
        ResetButton.TabIndex = 6
        ResetButton.Text = "Reset"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(494, 290)
        Controls.Add(ResetButton)
        Controls.Add(StopButton)
        Controls.Add(StartButton)
        Controls.Add(SubButton)
        Controls.Add(AddButton)
        Controls.Add(TimeText)
        Controls.Add(ModeTree)
        Name = "Form1"
        Text = "Timer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Delta As Timer
    Friend WithEvents ModeTree As TreeView
    Friend WithEvents TimeText As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents SubButton As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ResetButton As Button
End Class
