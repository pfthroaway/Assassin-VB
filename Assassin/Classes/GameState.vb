Imports Assassin.Classes.Database
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Items
Imports Extensions
Imports System.IO
Imports System.Threading.Tasks

Namespace Classes
    ''' <summary>Represents the current state of the game.</summary>
    Public Module GameState
        Friend AdminPassword As String
        Friend AllArmor As List(Of Armor)
        Friend AllWeapons As List(Of Weapon)
        Friend AllGuilds As List(Of Guild)
        Friend AllPotions As List(Of Potion)
        Friend AllFood As List(Of Food)
        Friend AllDrinks As List(Of Drink)
        Friend AllRanks As List(Of String)
        Friend AllEnemies As List(Of Enemy)
        Friend AllUsers As List(Of User)
        Friend CurrentUser As New User
        Friend CurrentEnemy As New Enemy
        Friend CurrentGuild As New Guild
        Friend AllJailedUsers As List(Of JailedUser)
        Public ReadOnly DatabaseInteraction As New SQLiteDatabaseInteraction

#Region "Control Manipulation"

        ''' <summary>Adds a blank line between a TextBox's current text and the text to be added.</summary>
        ''' <param name="tb">TextBox</param>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddTextToTextBox(tb As TextBox, newText As String)
            If Not String.IsNullOrWhiteSpace(newText) Then
                Dim nl As String = Environment.NewLine
                tb.Text = If(String.IsNullOrWhiteSpace(tb.Text), newText, $"{tb.Text}{nl}{nl}{newText}")
                tb.Select(tb.Text.Length, 0)
                tb.ScrollToCaret()
            End If
        End Sub

#End Region

#Region "Display Stuff"

        ''' <summary>Generates an enemy based on a player's current level.</summary>
        Public Sub GetEnemy()
            Dim level As Integer = 0
            Dim enemy As Integer = Functions.GenerateRandomNumber(1, 100)
            Select Case CurrentUser.Level
                Case 1, 2
                    Select Case enemy
                        Case 1 To 55        '55%
                            level = 1
                        Case 56 To 95       '40%
                            level = 2
                        Case 96 To 98       '3%
                            level = 3
                        Case 99 To 100      '2%
                            level = 4
                    End Select
                Case 3, 4
                    Select Case enemy
                        Case 1 To 12        '12%
                            level = 1
                        Case 13 To 24       '12%
                            level = 2
                        Case 25 To 50       '26%
                            level = 3
                        Case 51 To 76       '26%
                            level = 4
                        Case 77 To 88       '12%
                            level = 5
                        Case 89 To 100      '12%
                            level = 6
                    End Select
                Case 5, 6
                    Select Case enemy
                        Case 1 To 6         '6%
                            level = 1
                        Case 7 To 12        '6%
                            level = 2
                        Case 13 To 24       '12%
                            level = 3
                        Case 25 To 36       '12%
                            level = 4
                        Case 37 To 50       '14%
                            level = 5
                        Case 51 To 64       '14%
                            level = 6
                        Case 65 To 76       '12%
                            level = 7
                        Case 77 To 88       '12%
                            level = 8
                        Case 89 To 94       '6%
                            level = 9
                        Case 95 To 100      '6%
                            level = 10
                    End Select
                Case 7, 8
                    Select Case enemy
                        Case 1 To 4         '4%
                            level = 1
                        Case 5 To 8         '4%
                            level = 2
                        Case 9 To 16        '8%
                            level = 3
                        Case 17 To 24       '8%
                            level = 4
                        Case 25 To 36       '12%
                            level = 5
                        Case 37 To 48       '12%
                            level = 6
                        Case 49 To 64       '16%
                            level = 7
                        Case 65 To 80       '16%
                            level = 8
                        Case 81 To 90       '10%
                            level = 9
                        Case 91 To 100      '10%
                            level = 10
                    End Select
                Case 9, 10
                    Select Case enemy
                        Case 1 To 4         '4%
                            level = 1
                        Case 5 To 8         '4%
                            level = 2
                        Case 9 To 14        '6%
                            level = 3
                        Case 15 To 20       '6%
                            level = 4
                        Case 21 To 30       '10%
                            level = 5
                        Case 31 To 40       '10%
                            level = 6
                        Case 41 To 52       '12%
                            level = 7
                        Case 53 To 64       '12%
                            level = 8
                        Case 65 To 82       '18%
                            level = 9
                        Case 83 To 100      '18%
                            level = 10
                    End Select
                Case 11
                    Select Case enemy
                        Case 1 To 4         '4%
                            level = 1
                        Case 4 To 8         '4%
                            level = 2
                        Case 9 To 12        '4%
                            level = 3
                        Case 13 To 16       '4%
                            level = 4
                        Case 17 To 24       '8%
                            level = 5
                        Case 25 To 32       '8%
                            level = 6
                        Case 33 To 44       '12%
                            level = 7
                        Case 45 To 56       '12%
                            level = 8
                        Case 57 To 78       '22%
                            level = 9
                        Case 79 To 100      '22%
                            level = 10
                    End Select
            End Select

            Dim availableEnemies As List(Of Enemy) = AllEnemies.Where(Function(availEnemy) availEnemy.Level = level).ToList()
            If availableEnemies.Count = 0 Then
                Dim counter As Integer = 1
                While availableEnemies.Count = 0
                    availableEnemies = AllEnemies.Where(Function(availEnemy) level - counter >= availEnemy.Level AndAlso availEnemy.Level <= level + counter).ToList()
                    counter += 1
                End While
            End If
            CurrentEnemy = New Enemy(availableEnemies(Functions.GenerateRandomNumber(0, availableEnemies.Count - 1)))
            CurrentEnemy.GoldOnHand = Functions.GenerateRandomNumber(CurrentEnemy.GoldOnHand \ 2, CurrentEnemy.GoldOnHand)
        End Sub

        ''' <summary>Gets the hunger of a user and returns it as a String.</summary>
        ''' <param name="hunger">Current hunger</param>
        ''' <returns>String regarding hunger</returns>
        Public Function GetHunger(hunger As Integer) As String
            Select Case hunger
                Case 0 To 4
                    Return "Full"
                Case 5 To 9
                    Return "Hungry"
                Case 10 To 14
                    Return "Very Hungry"
                Case 14 To 19
                    Return "Famished"
                Case 20 To 24
                    Return "Starving"
                Case Else
                    Return "BROKEN"
            End Select
        End Function

        ''' <summary>Gets the thirst of a user and returns it as a String.</summary>
        ''' <param name="thirst">Current thirst</param>
        ''' <returns>String regarding thirst</returns>
        Public Function GetThirst(thirst As Integer) As String
            Select Case thirst
                Case 0 To 4
                    Return "Quenched"
                Case 5 To 9
                    Return "Thirsty"
                Case 10 To 14
                    Return "Very Thirsty"
                Case 14 To 19
                    Return "Parched"
                Case 20 To 24
                    Return "Dehydrated"
                Case Else
                    Return "BROKEN"
            End Select
        End Function

#End Region

#Region "Database"

        ''' <summary>Manages all the necessary files for the application.</summary>
        Public Sub FileManagement()

            If Not Directory.Exists(AppData.Location) Then
                Directory.CreateDirectory(AppData.Location)
            End If

            DatabaseInteraction.VerifyDatabaseIntegrity()
        End Sub

#End Region

        ''' <summary>Changes the admin password in the database.</summary>
        ''' <param name="newPass">New password</param>
        ''' <returns>True if successful</returns>
        Public Async Function ChangeAdminPassword(newPass As String) As Task(Of Boolean)
            Return Await DatabaseInteraction.ChangeAdminPassword(newPass)
        End Function

#Region "Load"

        ''' <summary>Loads the Admin password from the database.</summary>
        ''' <returns>Admin password</returns>
        Public Async Function LoadAdminPasssword() As Task(Of String)
            Return Await DatabaseInteraction.LoadAdminPasssword()
        End Function

        ''' <summary>Loads almost everything required from the database.</summary>
        Public Async Function LoadAll() As Task
            FileManagement()
            AdminPassword = Await LoadAdminPasssword()
            AllArmor = Await DatabaseInteraction.LoadArmor()
            AllGuilds = Await DatabaseInteraction.LoadGuilds()
            AllFood = Await DatabaseInteraction.LoadFood()
            AllDrinks = Await DatabaseInteraction.LoadDrinks()
            AllPotions = Await DatabaseInteraction.LoadPotions()
            AllRanks = Await DatabaseInteraction.LoadRanks()
            AllWeapons = Await DatabaseInteraction.LoadWeapons()
            AllEnemies = Await DatabaseInteraction.LoadEnemies()
            AllUsers = Await DatabaseInteraction.LoadUsers()
            AllJailedUsers = Await DatabaseInteraction.LoadJailedUsers()
            AllArmor = AllArmor.OrderBy(Function(obj) obj.Value).ToList()
            AllGuilds = AllGuilds.OrderBy(Function(obj) obj.ID).ToList()
            AllFood = AllFood.OrderBy(Function(obj) obj.Value).ToList()
            AllDrinks = AllDrinks.OrderBy(Function(obj) obj.Value).ToList()
            AllPotions = AllPotions.OrderBy(Function(obj) obj.Value).ToList()
            AllWeapons = AllWeapons.OrderBy(Function(obj) obj.Value).ToList()
            AllEnemies = AllEnemies.OrderBy(Function(obj) obj.Level).ThenBy(Function(enemy) enemy.Name).ToList()
        End Function

#End Region

#Region "Message Management"

        ''' <summary>Deletes a <see cref="Message"/> from the database.</summary>
        ''' <param name="message"><see cref="Message"/> to be deleted</param>
        ''' <returns>True if successful</returns>
        Public Async Function DeleteMessage(message As Message) As Task(Of Boolean)
            Return Await DatabaseInteraction.DeleteMessage(message)
        End Function

        ''' <summary>Sends a <see cref="Message"/> between <see cref="User"/>s.</summary>
        ''' <param name="message"><see cref="Message"/> sent</param>
        ''' <returns>True if successful</returns>
        Public Async Function SendMessage(message As Message) As Task(Of Boolean)
            Return Await DatabaseInteraction.SendMessage(message)
        End Function

#End Region

#Region "User Management"

        ''' <summary>Adds a User.</summary>
        ''' <param name="userNew">User to be added</param>
        ''' <returns>True if successful</returns>
        Public Async Function NewUser(userNew As User) As Task(Of Boolean)
            Return Await DatabaseInteraction.NewUser(userNew)
        End Function

        ''' <summary>Saves a User.</summary>
        ''' <param name="userSave">User to be saved</param>
        ''' <returns>True if successful</returns>
        Public Async Function SaveUser(userSave As User) As Task(Of Boolean)
            Return Await DatabaseInteraction.SaveUser(userSave)
        End Function

        ''' <summary>Changes an User's name and then saves the User to the database.</summary>
        ''' <param name="userSave">User to be saved</param>
        ''' <param name="newName">New name for User</param>
        ''' <returns>True if successful</returns>
        Public Async Function SaveUser(userSave As User, newName As String) As Task(Of Boolean)
            Return Await DatabaseInteraction.SaveUser(userSave, newName)
        End Function

#End Region

#Region "Guild Management"

        ''' <summary><see cref="User"/> applies for membership with a <see cref="Guild"/>.</summary>
        ''' <param name="joinUser"><see cref="User"/> applying to join the <see cref="Guild"/>.</param>
        ''' <param name="joinGuild"><see cref="Guild"/> being applied to</param>
        ''' <returns>True if successful</returns>
        Public Async Function ApplyToGuild(joinUser As User, joinGuild As Guild) As Task(Of Boolean)
            Return Await DatabaseInteraction.ApplyToGuild(joinUser, joinGuild)
        End Function

        ''' <summary><see cref="User"/> is approved for membership with a <see cref="Guild"/>.</summary>
        ''' <param name="approveUser"><see cref="User"/> approved to join the <see cref="Guild"/>.</param>
        ''' <param name="approveGuild"><see cref="Guild"/> being joined</param>
        ''' <returns>True if successful</returns>
        Public Async Function ApproveGuildApplication(approveUser As User, approveGuild As Guild) As Task(Of Boolean)
            Return Await DatabaseInteraction.ApproveGuildApplication(approveUser, approveGuild)
        End Function

        ''' <summary>Denies a <see cref="User"/>'s application to a <see cref="Guild"/>.</summary>
        ''' <param name="denyUser"><see cref="User"/> whose application is denied</param>
        ''' <param name="denyGuild"><see cref="Guild"/> from which the <see cref="User"/>'s application was denied</param>
        ''' <returns>True if successful</returns>
        Public Async Function DenyGuildApplication(denyUser As User, denyGuild As Guild) As Task(Of Boolean)
            Return Await DatabaseInteraction.DenyGuildApplication(denyUser, denyGuild)
        End Function

        ''' <summary>Checks whether the <see cref="User"/> has applied to the selected <see cref="Guild"/>.</summary>
        ''' <param name="joinUser">User joining the Guild.</param>
        ''' <param name="joinGuild">Guild being joined</param>
        ''' <returns>True if successful</returns>
        Public Async Function HasAppliedToGuild(joinUser As User, joinGuild As Guild) As Task(Of Boolean)
            Return Await DatabaseInteraction.HasAppliedToGuild(joinUser, joinGuild)
        End Function

        ''' <summary>Member of a Guild gains membership with that Guild, applied to database.</summary>
        ''' <param name="joinUser">User joining the Guild.</param>
        ''' <param name="joinGuild">Guild being joined</param>
        ''' <returns>True if successful</returns>
        Public Async Function MemberJoinsGuild(joinUser As User, joinGuild As Guild) As Task(Of Boolean)
            Return Await DatabaseInteraction.MemberJoinsGuild(joinUser, joinGuild)
        End Function

        ''' <summary>Member of a Guild terminates membership with that Guild, applied to database.</summary>
        ''' <param name="leaveUser">User leaving the Guild.</param>
        ''' <param name="leaveGuild">Guild being left</param>
        ''' <returns>True if successful</returns>
        Public Async Function MemberLeavesGuild(leaveUser As User, leaveGuild As Guild) As Task(Of Boolean)
            If Await DatabaseInteraction.MemberLeavesGuild(leaveUser, leaveGuild) Then
                leaveGuild.Members.Remove(leaveUser.Name)
                Return True
            End If
            Return False
        End Function

        ''' <summary>Saves a Guild.</summary>
        ''' <param name="guildSave">Guild to be saved</param>
        Public Async Function SaveGuild(guildSave As Guild) As Task(Of Boolean)
            Return Await DatabaseInteraction.SaveGuild(guildSave)
        End Function

#End Region

    End Module

End Namespace