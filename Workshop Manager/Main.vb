'-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
'Workshop Manager Project By David
'-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

Public Class Main

    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    'Declaration of Variables
    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    'Bool for dragging of program
    Dim draggable As Boolean
    'Mouse locations for dragging
    Dim mouseX As Integer
    Dim mouseY As Integer


    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    'Application Control
    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-


    'Controls for moving the application
    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        'Sets draggable variable to true
        draggable = True
        'Gets current position of the cursor
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top

    End Sub

    'Runs on mouse movement
    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        'Checks if the panel is being clicked
        If draggable Then
            'Moves the application to the position of the mouse
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    'runes on mouse click being released
    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp
        'turns off draggable to stop the program being moved when it is no longer being clicked
        draggable = False
    End Sub

    'Runs when close button is clicked
    Private Sub pbxClose_Click(sender As Object, e As EventArgs) Handles pbxClose.Click
        'Closes the program
        Me.Close()
    End Sub

    'Runs when minimise button is clicked
    Private Sub pbxMinimise_Click(sender As Object, e As EventArgs) Handles pbxMinimise.Click
        'Minimises the program
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class
