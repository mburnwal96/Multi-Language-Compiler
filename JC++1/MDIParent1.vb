Imports System.Windows.Forms

Public Class MDIParent1
    Dim str As String
    Public doc, actchild As Form1
    
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        '' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        Clipboard.SetText(Me.actchild.RichTextBox1.SelectedText)
        Me.actchild.RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click

        If (doc.RichTextBox1.SelectionLength = 0) Then
            MsgBox("Select First...")
        Else
            Clipboard.SetText(Me.actchild.RichTextBox1.SelectedText)
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
        Me.actchild.RichTextBox1.SelectedText = Clipboard.GetText
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub PrintPreviewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CFILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFILEToolStripMenuItem.Click

        SaveFileDialog1.Filter = "C File|*.c"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            doc = New Form1
            doc.MdiParent = Me
            doc.Text = My.Computer.FileSystem.GetName(SaveFileDialog1.FileName)
            str = My.Computer.FileSystem.GetParentPath(SaveFileDialog1.FileName)
            doc.RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            doc.Icon = My.Resources.c
            doc.TextBox1.Text = SaveFileDialog1.FileName
            doc.Show()
        End If
    End Sub

    Private Sub CPPFILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPPFILEToolStripMenuItem.Click

        SaveFileDialog1.Filter = "CPP File|*.cpp"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            doc = New Form1
            doc.MdiParent = Me
            doc.Text = My.Computer.FileSystem.GetName(SaveFileDialog1.FileName)
            str = My.Computer.FileSystem.GetParentPath(SaveFileDialog1.FileName)
            doc.RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            doc.Icon = My.Resources.Cpp
            doc.TextBox1.Text = SaveFileDialog1.FileName
            doc.Show()
        End If
    End Sub

    Private Sub JAVAFILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JAVAFILEToolStripMenuItem.Click
        SaveFileDialog1.Filter = "JAVA File|*.java"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            doc = New Form1
            doc.MdiParent = Me
            doc.Text = My.Computer.FileSystem.GetName(SaveFileDialog1.FileName)
            str = My.Computer.FileSystem.GetParentPath(SaveFileDialog1.FileName)
            doc.RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            doc.TextBox1.Text = SaveFileDialog1.FileName
            doc.Text = SaveFileDialog1.FileName
            doc.Icon = My.Resources.JavaR
            doc.Show()
        End If
    End Sub

    Private Sub CFileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFileToolStripMenuItem1.Click
        OpenFileDialog1.Filter = "C File|*.c"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            doc = New Form1
            doc.MdiParent = Me
            doc.Text = My.Computer.FileSystem.GetName(OpenFileDialog1.FileName)
            str = My.Computer.FileSystem.GetParentPath(OpenFileDialog1.FileName)
            doc.RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            doc.TextBox1.Text = OpenFileDialog1.FileName
            doc.Text = OpenFileDialog1.FileName
            doc.Icon = My.Resources.c
            doc.Show()
        End If
    End Sub

    Private Sub CppFileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CppFileToolStripMenuItem1.Click
        OpenFileDialog1.Filter = "CPP File|*.cpp"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            doc = New Form1
            doc.MdiParent = Me
            doc.Text = My.Computer.FileSystem.GetName(OpenFileDialog1.FileName)
            str = My.Computer.FileSystem.GetParentPath(OpenFileDialog1.FileName)
            doc.RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            doc.TextBox1.Text = OpenFileDialog1.FileName
            doc.Icon = My.Resources.Cpp
            doc.Show()
        End If
    End Sub

    Private Sub JavaFileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JavaFileToolStripMenuItem1.Click
        OpenFileDialog1.Filter = "JAVA File|*.java"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            doc = New Form1
            doc.MdiParent = Me
            doc.Text = My.Computer.FileSystem.GetName(OpenFileDialog1.FileName)
            str = My.Computer.FileSystem.GetParentPath(OpenFileDialog1.FileName)
            doc.RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            doc.TextBox1.Text = OpenFileDialog1.FileName
            doc.Icon = My.Resources.JavaR
            doc.Show()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        My.Computer.FileSystem.WriteAllText(Me.actchild.TextBox1.Text, Me.actchild.RichTextBox1.Text, False, System.Text.Encoding.ASCII)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Form1.Text = My.Computer.FileSystem.GetName(SaveFileDialog1.FileName)
            doc.TextBox1.Text = OpenFileDialog1.FileName

            actchild.RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            Me.actchild.Show()
        End If
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        
        Me.actchild.RichTextBox1.SelectAll()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Me.actchild.RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        Me.actchild.RichTextBox1.Redo()
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.Filter = "C File|*.c|CPP File|*.cpp|JAVA File|*.java"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            doc = New Form1
            doc.MdiParent = Me
            doc.Text = My.Computer.FileSystem.GetName(SaveFileDialog1.FileName)
            doc.RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            doc.TextBox1.Text = OpenFileDialog1.FileName
            doc.Text = OpenFileDialog1.FileName
            doc.Icon = My.Resources.c
            doc.Show()
        End If
    End Sub

    Private Sub BuildToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildToolStripMenuItem.Click

        actchild = Me.ActiveMdiChild
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\compile.bat") = True Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\compile.bat")
        End If
        str = My.Computer.FileSystem.GetParentPath(actchild.TextBox1.Text)

        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\compile.bat", "cd " & str & vbNewLine, True, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\compile.bat", Microsoft.VisualBasic.Left(str, 2) & vbNewLine, True)
        
        If LCase(Microsoft.VisualBasic.Right(actchild.TextBox1.Text, 1)) = "c" Or LCase(Microsoft.VisualBasic.Right(actchild.TextBox1.Text, 3)) = "cpp" Then
            ToolStripStatusLabel.Text = "Compiling..."
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\compile.bat", """" & Application.StartupPath & "\MinGW\bin\gcc" & """" & " " & """" & actchild.TextBox1.Text & """" & " " & "-c" & " > " & """" & Application.StartupPath & "\buildlog.txt" & """" & " 2>&1" & vbNewLine, True, System.Text.Encoding.ASCII)
            'Process.Start(Application.StartupPath & "\compile.bat")
            ShellandWait(Application.StartupPath & "\compile.bat", "Hidden", True)
            ToolStripStatusLabel.Text = "Compiling Complete"

        ElseIf LCase(Microsoft.VisualBasic.Right(actchild.TextBox1.Text, 4)) = "java" Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\compile.bat", """" & Application.StartupPath & "\jdk8\bin\javac" & """" & " -g " & " " & """" & actchild.TextBox1.Text & """" & " " & " > " & """" & Application.StartupPath & "\buildlog.txt" & """" & " 2>&1" & vbNewLine, True, System.Text.Encoding.ASCII)
            'My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\compile.bat", "pause", True, System.Text.Encoding.ASCII)
            Process.Start(Application.StartupPath & "\compile.bat")
        Else
            MsgBox("Does not support this type Program.Please Execute only C,CPP and JAVA Program")
        End If
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click

        actchild = Me.ActiveMdiChild
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\run.bat") = True Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\run.bat")
        End If
        str = My.Computer.FileSystem.GetParentPath(actchild.TextBox1.Text)

        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\run.bat", "cd " & str & vbNewLine, True, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\run.bat", Microsoft.VisualBasic.Left(str, 2) & vbNewLine, True)

        If LCase(Microsoft.VisualBasic.Right(actchild.TextBox1.Text, 1)) = "c" Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\run.bat", """" & Application.StartupPath & "\MinGW\bin\g++" & """" & " " & """" & Mid(actchild.TextBox1.Text, 1, Len(actchild.TextBox1.Text) - 2) & ".o" & """" & " " & "-static-libgcc -static-libstdc++" & " " & "-o" & " " & """" & Mid(actchild.TextBox1.Text, 1, Len(actchild.TextBox1.Text) - 2) & ".exe" & """" & " > " & """" & Application.StartupPath & "\buildlog.txt" & """" & " 2>&1" & vbNewLine, True, System.Text.Encoding.ASCII)
            'Process.Start(Application.StartupPath & "\run.bat")
            ShellandWait(Application.StartupPath & "\run.bat", "Hidden", True)
            Process.Start(Mid(actchild.TextBox1.Text, 1, Len(actchild.TextBox1.Text) - 2) & ".exe")

        ElseIf LCase(Microsoft.VisualBasic.Right(actchild.TextBox1.Text, 3)) = "cpp" Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\run.bat", """" & Application.StartupPath & "\MinGW\bin\g++" & """" & " " & """" & Mid(actchild.TextBox1.Text, 1, Len(actchild.TextBox1.Text) - 4) & ".o" & """" & " " & "-static-libgcc -static-libstdc++" & " " & "-o" & " " & """" & Mid(actchild.TextBox1.Text, 1, Len(actchild.TextBox1.Text) - 4) & ".exe" & """" & " > " & """" & Application.StartupPath & "\buildlog.txt" & """" & " 2>&1" & vbNewLine, True, System.Text.Encoding.ASCII)
            'Process.Start(Application.StartupPath & "\run.bat")
            ShellandWait(Application.StartupPath & "\run.bat", "Hidden", True)
            Process.Start(Mid(actchild.TextBox1.Text, 1, Len(actchild.TextBox1.Text) - 4) & ".exe")

        ElseIf LCase(Microsoft.VisualBasic.Right(actchild.TextBox1.Text, 4)) = "java" Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\run.bat", "@echo off" & vbNewLine, True, System.Text.Encoding.ASCII)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\run.bat", """" & Application.StartupPath & "\jdk8\bin\java" & """" & " " & Mid(My.Computer.FileSystem.GetName(actchild.TextBox1.Text), 1, Len(My.Computer.FileSystem.GetName(actchild.TextBox1.Text)) - 5) & vbNewLine, True, System.Text.Encoding.ASCII)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\run.bat", "pause", True, System.Text.Encoding.ASCII)
            Process.Start(Application.StartupPath & "\run.bat")
        Else
            MsgBox("Does not support this type Program.Please Execute only C,CPP and JAVA Program")
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        doc.RichTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem.Click
        actchild = Me.ActiveMdiChild
        MsgBox(actchild.Text)
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShellandWait(ByVal ProcessPath As String, ByVal Mode As String, ByVal Wait As Boolean)

        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath

            If Mode = "Hidden" Then
                objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            ElseIf Mode = "Normal" Then
                objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            ElseIf Mode = "Minimized" Then
                objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
            ElseIf Mode = "Maximized" Then
                objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
            End If

            objProcess.Start()

            If Wait = True Then
                'Wait until the process passes back an exit code 
                objProcess.WaitForExit()
            End If

            'Free resources associated with this process
            objProcess.Close()
        Catch
            MessageBox.Show("Could not start process " & ProcessPath, "Error")
        End Try

    End Sub
End Class
