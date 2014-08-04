Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Threading
Imports System.ComponentModel

Public Class Main_Screen

    Private busyworking As Boolean = False

    Private lastinputline As String = ""
    Private inputlines As Long = 0
    Private highestPercentageReached As Integer = 0
    Private inputlinesprecount As Long = 0
    Private pretestdone As Boolean = False
    Private primary_PercentComplete As Integer = 0
    Private percentComplete As Integer

    Private SelectedIndex As Integer = 0

    Private Sub Error_Handler(ByVal ex As Exception, Optional ByVal identifier_msg As String = "")
        Try
            If ex.Message.IndexOf("Thread was being aborted") < 0 Then
                Dim Display_Message1 As New Display_Message()
                Display_Message1.Message_Textbox.Text = "The Application encountered the following problem: " & vbCrLf & identifier_msg & ":" & ex.Message.ToString

                Display_Message1.Timer1.Interval = 1000
                Display_Message1.ShowDialog()
                Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
                If dir.Exists = False Then
                    dir.Create()
                End If
                dir = Nothing
                Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs\" & Format(Now(), "yyyyMMdd") & "_Error_Log.txt", True)
                filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & identifier_msg & ":" & ex.ToString)
                filewriter.Flush()
                filewriter.Close()
                filewriter = Nothing
            End If
            ex = Nothing
            identifier_msg = Nothing
        Catch exc As Exception
            MsgBox("An error occurred in the application's error handling routine. The application will try to recover from this serious error.", MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = OpenFileDialog1.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub



    Private Sub cancelAsyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelAsyncButton.Click

        ' Cancel the asynchronous operation.
        Me.BackgroundWorker1.CancelAsync()

        ' Disable the Cancel button.
        cancelAsyncButton.Enabled = False
        sender = Nothing
        e = Nothing
    End Sub 'cancelAsyncButton_Click

    Private Sub PreCount_Function()
        Try
            inputlinesprecount = 0
            Dim filereader As StreamReader = New StreamReader(OpenFileDialog1.FileName)
            While filereader.Peek() <> -1
                filereader.ReadLine()
                inputlinesprecount = inputlinesprecount + 1
            End While
            filereader.Close()
            filereader = Nothing

        Catch ex As Exception
            Error_Handler(ex, "PreCount_Function")
        End Try
    End Sub

    Private Sub startAsyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startAsyncButton.Click
        Try
            If OpenFileDialog1.FileName.Length < 1 Or FolderBrowserDialog1.SelectedPath.Length < 1 Then
                Dim Display_Message1 As New Display_Message()
                Display_Message1.Message_Textbox.Text = "Please ensure that you select a valid file containing all the MAC addresses to process as well as the folder in which to generate the new files in."
                Display_Message1.Timer1.Interval = 1000
                Display_Message1.ShowDialog()

            Else
                If busyworking = False Then
                    busyworking = True


                    inputlines = 0
                    lastinputline = ""
                    highestPercentageReached = 0
                    inputlinesprecount = 0
                    pretestdone = False

                    TextBox1.Enabled = False
                    Button1.Enabled = False
                    TextBox2.Enabled = False
                    Button2.Enabled = False
                    RichTextBox1.Enabled = False
                    startAsyncButton.Enabled = False
                    cancelAsyncButton.Enabled = True
                    ' Start the asynchronous operation.

                    BackgroundWorker1.RunWorkerAsync(TextBox1.Text)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "StartWorker")
        End Try
    End Sub

    ' This event handler is where the actual work is done.
    Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        ' Get the BackgroundWorker object that raised this event.
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        ' Assign the result of the computation
        ' to the Result property of the DoWorkEventArgs
        ' object. This is will be available to the 
        ' RunWorkerCompleted eventhandler.
        e.Result = MainWorkerFunction(worker, e)
        sender = Nothing
        e = Nothing
        worker.Dispose()
        worker = Nothing
    End Sub 'backgroundWorker1_DoWork

    ' This event handler deals with the results of the
    ' background operation.
    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        busyworking = False
        ' First, handle the case where an exception was thrown.
        If Not (e.Error Is Nothing) Then
            Error_Handler(e.Error, "backgroundWorker1_RunWorkerCompleted")
        ElseIf e.Cancelled Then
            ' Next, handle the case where the user canceled the 
            ' operation.
            ' Note that due to a race condition in 
            ' the DoWork event handler, the Cancelled
            ' flag may not have been set, even though
            ' CancelAsync was called.
            Me.ProgressBar1.Value = 0

        Else
            ' Finally, handle the case where the operation succeeded.

            Me.ProgressBar1.Value = 100
        End If

        TextBox1.Enabled = True
        Button1.Enabled = True
        TextBox2.Enabled = True
        Button2.Enabled = True
        RichTextBox1.Enabled = True

        startAsyncButton.Enabled = True
        cancelAsyncButton.Enabled = False

        sender = Nothing
        e = Nothing


    End Sub 'backgroundWorker1_RunWorkerCompleted

    Private Sub backgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged


        Me.ProgressBar1.Value = e.ProgressPercentage
        Me.ToolStripStatusLabel1.Text = lastinputline & "   (" & inputlines & " of " & inputlinesprecount & ")"

        sender = Nothing
        e = Nothing
    End Sub

    Function MainWorkerFunction(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean
        Dim result As Boolean = False
        Try
            If Me.pretestdone = False Then
                primary_PercentComplete = 0
                worker.ReportProgress(0)
                PreCount_Function()
                Me.pretestdone = True
            End If

            If worker.CancellationPending Then
                e.Cancel = True
                Return False
            End If

            primary_PercentComplete = 0
            worker.ReportProgress(0)

            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath) = False Then
                My.Computer.FileSystem.CreateDirectory(FolderBrowserDialog1.SelectedPath)
            End If

            Dim filereader As StreamReader = New StreamReader(OpenFileDialog1.FileName)
            Dim lineread As String = ""
            While filereader.Peek() <> -1
                Try
                    If worker.CancellationPending Then
                        e.Cancel = True
                        filereader.Close()
                        filereader = Nothing
                        Return False
                    End If

                    lineread = filereader.ReadLine().Trim
                    If lineread.Length = 12 Then

                        For i As Integer = 10 To 2 Step -2
                            lineread = lineread.Insert(i, "-")
                        Next
                        lineread = "01-" & lineread
                        Dim filewriter As StreamWriter = New StreamWriter((FolderBrowserDialog1.SelectedPath & "\" & lineread).Replace("\\", "\"), False)
                        For Each str As String In RichTextBox1.Lines
                            filewriter.WriteLine(str)
                        Next



                        filewriter.Flush()
                        filewriter.Close()
                        filewriter = Nothing


                        lastinputline = "Processed: " & lineread
                        inputlines = inputlines + 1

                        ' Report progress as a percentage of the total task.
                        percentComplete = 0
                        If inputlinesprecount > 0 Then
                            percentComplete = CSng(inputlines) / CSng(inputlinesprecount) * 100
                        Else
                            percentComplete = 100
                        End If
                        primary_PercentComplete = percentComplete
                        If percentComplete > highestPercentageReached Then
                            highestPercentageReached = percentComplete
                            worker.ReportProgress(percentComplete)
                        End If
                    End If

                Catch ex As Exception
                    Error_Handler(ex, "MainWorkerFunctionImageHandler")
                End Try


            End While
            filereader.Close()
            filereader = Nothing

        Catch ex As Exception
            Error_Handler(ex, "MainWorkerFunction")
        End Try
        worker.Dispose()
        worker = Nothing
        e = Nothing
        Return result

    End Function

    Private Sub Form1_Close(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If TextBox2.Text.Length > 0 Then
                Dim dinfo As DirectoryInfo = New DirectoryInfo(TextBox2.Text)
                If dinfo.Exists Then
                    My.Settings.ImageFolder = TextBox2.Text
                    My.Settings.Save()
                End If
                dinfo = Nothing
            End If
            If TextBox1.Text.Length > 0 Then
                Dim finfo As FileInfo = New FileInfo(TextBox1.Text)
                If finfo.Exists Then
                    My.Settings.ImageFile = TextBox1.Text
                    My.Settings.Save()
                End If
                finfo = Nothing
            End If
        Catch ex As Exception
            Error_Handler(ex, "Application Close")
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Me.Text = "TFTPD MAC File Creator " & My.Application.Info.Version.Major & Format(My.Application.Info.Version.Minor, "00") & Format(My.Application.Info.Version.Build, "00") & "." & My.Application.Info.Version.Revision
            If Not My.Settings.ImageFolder = Nothing Then
                If My.Settings.ImageFolder.Length > 0 Then
                    Dim dinfo As DirectoryInfo = New DirectoryInfo(My.Settings.ImageFolder)
                    If dinfo.Exists Then
                        FolderBrowserDialog1.SelectedPath = My.Settings.ImageFolder
                        TextBox2.Text = My.Settings.ImageFolder
                    End If
                    dinfo = Nothing
                End If
            End If
            If Not My.Settings.ImageFile = Nothing Then
                If My.Settings.ImageFile.Length > 0 Then
                    Dim finfo As FileInfo = New FileInfo(My.Settings.ImageFile)
                    If finfo.Exists Then
                        OpenFileDialog1.FileName = My.Settings.ImageFile
                        TextBox1.Text = My.Settings.ImageFile
                    End If
                    finfo = Nothing
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Application Load")
        End Try

    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = FolderBrowserDialog1.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class
