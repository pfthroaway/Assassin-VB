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
        ReadOnly DatabaseInteraction As New SQLiteDatabaseInteraction

#Region "Control Manipulation"

        ''' <summary>Adds a blank line between a TextBox's current text and the text to be added.</summary>
        ''' <param name="tb">TextBox</param>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddTextToTextBox(tb As TextBox, newText As String)
            Dim nl As String = Environment.NewLine
            tb.Text = If(String.IsNullOrWhiteSpace(tb.Text), newText, $"{tb.Text}{nl}{nl}{newText}")
            tb.Select(tb.Text.Length - 1, 0)
            tb.ScrollToCaret()
        End Sub

#End Region

#Region "Display Stuff"

        ''' <summary>Generates an enemy based on a player's current level.</summary>
        Public Sub GetEnemy()
            Dim enemyNum As Integer = 0
            Dim enemy As Integer = Functions.GenerateRandomNumber(1, 100)
            Select Case CurrentUser.Level
                Case 1, 2
                    Select Case enemy
                        Case 1 To 55        '55%
                            enemyNum = 1
                        Case 56 To 95       '40%
                            enemyNum = 2
                        Case 96 To 98       '3%
                            enemyNum = 3
                        Case 99 To 100      '2%
                            enemyNum = 4
                    End Select
                Case 3, 4
                    Select Case enemy
                        Case 1 To 12        '12%
                            enemyNum = 1
                        Case 13 To 24       '12%
                            enemyNum = 2
                        Case 25 To 50       '26%
                            enemyNum = 3
                        Case 51 To 76       '26%
                            enemyNum = 4
                        Case 77 To 88       '12%
                            enemyNum = 5
                        Case 89 To 100      '12%
                            enemyNum = 6
                    End Select
                Case 5, 6
                    Select Case enemy
                        Case 1 To 6         '6%
                            enemyNum = 1
                        Case 7 To 12        '6%
                            enemyNum = 2
                        Case 13 To 24       '12%
                            enemyNum = 3
                        Case 25 To 36       '12%
                            enemyNum = 4
                        Case 37 To 50       '14%
                            enemyNum = 5
                        Case 51 To 64       '14%
                            enemyNum = 6
                        Case 65 To 76       '12%
                            enemyNum = 7
                        Case 77 To 88       '12%
                            enemyNum = 8
                        Case 89 To 94       '6%
                            enemyNum = 9
                        Case 95 To 100      '6%
                            enemyNum = 10
                    End Select
                Case 7, 8
                    Select Case enemy
                        Case 1 To 4         '4%
                            enemyNum = 1
                        Case 5 To 8         '4%
                            enemyNum = 2
                        Case 9 To 16        '8%
                            enemyNum = 3
                        Case 17 To 24       '8%
                            enemyNum = 4
                        Case 25 To 36       '12%
                            enemyNum = 5
                        Case 37 To 48       '12%
                            enemyNum = 6
                        Case 49 To 64       '16%
                            enemyNum = 7
                        Case 65 To 80       '16%
                            enemyNum = 8
                        Case 81 To 90       '10%
                            enemyNum = 9
                        Case 91 To 100      '10%
                            enemyNum = 10
                    End Select
                Case 9, 10
                    Select Case enemy
                        Case 1 To 4         '4%
                            enemyNum = 1
                        Case 5 To 8         '4%
                            enemyNum = 2
                        Case 9 To 14        '6%
                            enemyNum = 3
                        Case 15 To 20       '6%
                            enemyNum = 4
                        Case 21 To 30       '10%
                            enemyNum = 5
                        Case 31 To 40       '10%
                            enemyNum = 6
                        Case 41 To 52       '12%
                            enemyNum = 7
                        Case 53 To 64       '12%
                            enemyNum = 8
                        Case 65 To 82       '18%
                            enemyNum = 9
                        Case 83 To 100      '18%
                            enemyNum = 10
                    End Select
                Case 11
                    Select Case enemy
                        Case 1 To 4         '4%
                            enemyNum = 1
                        Case 4 To 8         '4%
                            enemyNum = 2
                        Case 9 To 12        '4%
                            enemyNum = 3
                        Case 13 To 16       '4%
                            enemyNum = 4
                        Case 17 To 24       '8%
                            enemyNum = 5
                        Case 25 To 32       '8%
                            enemyNum = 6
                        Case 33 To 44       '12%
                            enemyNum = 7
                        Case 45 To 56       '12%
                            enemyNum = 8
                        Case 57 To 78       '22%
                            enemyNum = 9
                        Case 79 To 100      '22%
                            enemyNum = 10
                    End Select
            End Select

            CurrentEnemy = New Enemy(AllEnemies(enemyNum - 1))
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
            AllArmor = Await LoadArmor()
            AllGuilds = Await LoadGuilds()
            AllFood = Await LoadFood()
            AllDrinks = Await LoadDrinks()
            AllPotions = Await LoadPotions()
            AllRanks = Await LoadRanks()
            AllWeapons = Await LoadWeapons()
            AllEnemies = Await LoadEnemies()
            AllUsers = Await LoadUsers()
            AllArmor = AllArmor.OrderBy(Function(obj) obj.Value).ToList()
            AllGuilds = AllGuilds.OrderBy(Function(obj) obj.ID).ToList()
            AllFood = AllFood.OrderBy(Function(obj) obj.Value).ToList()
            AllDrinks = AllDrinks.OrderBy(Function(obj) obj.Value).ToList()
            AllPotions = AllPotions.OrderBy(Function(obj) obj.Value).ToList()
            AllWeapons = AllWeapons.OrderBy(Function(obj) obj.Value).ToList()
            AllEnemies = AllEnemies.OrderBy(Function(obj) obj.Level).ToList()
        End Function

        '''<summary>Loads all Armor from the database.</summary>
        ''' <returns>All Armor</returns>
        Public Async Function LoadArmor() As Task(Of List(Of Armor))
            Return Await DatabaseInteraction.LoadArmor()
        End Function

        ''' <summary>Loads all Enemies from the database.</summary>
        ''' <returns>All Enemies</returns>
        Public Async Function LoadEnemies() As Task(Of List(Of Enemy))
            Return Await DatabaseInteraction.LoadEnemies()
        End Function

        ''' <summary>Loads all <see cref="Guild"/>s from the database.</summary>
        ''' <returns>All <see cref="Guild"/>s</returns>
        Public Async Function LoadGuilds() As Task(Of List(Of Guild))
            Return Await DatabaseInteraction.LoadGuilds()
        End Function

        ''' <summary>Loads all applicants for a selected <see cref="Guild"/>.</summary>
        ''' <param name="currentGuild"><see cref="Guild"/> whose applicants are to be loaded</param>
        ''' <returns>All applicants for a selected <see cref="Guild"/></returns>
        Public Async Function LoadGuildApplicants(currentGuild As Guild) As Task(Of List(Of String))
            Return Await DatabaseInteraction.LoadGuildApplicants(currentGuild)
        End Function

        Public Async Function LoadMessages(loadUser As User) As Task(Of List(Of Message))
            Return Await DatabaseInteraction.LoadMessages(loadUser)
        End Function

        ''' <summary>Loads all <see cref="Food"/> from the database.</summary>
        ''' <returns>All <see cref="Food"/></returns>
        Public Async Function LoadFood() As Task(Of List(Of Food))
            Return Await DatabaseInteraction.LoadFood()
        End Function

        ''' <summary> Loads all <see cref="Drink"/>s from the database.</summary>
        ''' <returns>All <see cref="Drink"/>s</returns>
        Public Async Function LoadDrinks() As Task(Of List(Of Drink))
            Return Await DatabaseInteraction.LoadDrinks()
        End Function

        ''' <summary>Loads all <see cref="Potion"/>s from the database.</summary>
        ''' <returns>All <see cref="Potion"/>s</returns>
        Public Async Function LoadPotions() As Task(Of List(Of Potion))
            Return Await DatabaseInteraction.LoadPotions()
        End Function

        ''' <summary>Loads all Ranks from the database.</summary>
        ''' <returns>All Ranks</returns>
        Public Async Function LoadRanks() As Task(Of List(Of String))
            Return Await DatabaseInteraction.LoadRanks()
        End Function

        ''' <summary>Loads a <see cref="User"/> from the database.</summary>
        ''' <param name="name"><see cref="User"/> to be loaded</param>
        ''' <returns><see cref="User"/></returns>
        Public Async Function LoadUser(name As String) As Task(Of User)
            Return Await DatabaseInteraction.LoadUser(name)
        End Function

        ''' <summary>Loads all <see cref="User"/>s from the database.</summary>
        ''' <returns>All <see cref="User"/>s</returns>
        Public Async Function LoadUsers() As Task(Of List(Of User))
            Return Await DatabaseInteraction.LoadUsers()
        End Function

        ''' <summary>Loads all <see cref="Weapon"/>s from the database.</summary>
        ''' <returns>All <see cref="Weapon"/>s</returns>
        Public Async Function LoadWeapons() As Task(Of List(Of Weapon))
            Return Await DatabaseInteraction.LoadWeapons()
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

#Region "Enemy Management"

        ''' <summary>Saves an Enemy to the database.</summary>
        ''' <param name="enemySave">Enemy to be saved</param>
        ''' <returns>True if successful</returns>
        Public Async Function SaveEnemy(enemySave As Enemy) As Task(Of Boolean)
            Return Await DatabaseInteraction.SaveEnemy(enemySave)
        End Function

        ''' <summary>Changes an Enemy's name and then saves the Enemy to the database.</summary>
        ''' <param name="enemySave">Enemy to be saved</param>
        ''' <param name="newName">New name for Enemy</param>
        ''' <returns>True if successful</returns>
        Public Async Function SaveEnemy(enemySave As Enemy, newName As String) As Task(Of Boolean)
            Return Await DatabaseInteraction.SaveEnemy(enemySave, newName)
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