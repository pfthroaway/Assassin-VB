﻿Imports Assassin.Classes.Database
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Items
Imports Extensions
Imports System.IO
Imports System.Linq
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
            If String.IsNullOrWhiteSpace(tb.Text) Then
                tb.Text = newText
            Else
                tb.Text = $"{tb.Text}{nl}{nl}{newText}"
            End If
            tb.Select(tb.Text.Length - 1, 0)
            tb.ScrollToCaret()
        End Sub

#End Region

#Region "Display Stuff"

        ''' <summary>Generates an enemy based on a player's current level.</summary>
        Public Sub GetEnemy()
            '* * * * *
            '* This method generates an enemy based on a player's current level.
            '* * * * *

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

            CurrentEnemy = New Enemy(AllEnemies(enemyNum))
        End Sub

        ''' <summary>Gets the hunger of a user and returns it as a String.</summary>
        ''' <param name="hunger">Current hunger</param>
        ''' <returns>String regarding hunger</returns>
        Public Function GetHunger(hunger As Integer) As String
            '* * * * *
            '* This method gets the hunger of a user and returns it as a String.
            '* * * * *

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
            '* * * * *
            '* This method gets the thirst of a user and returns it as a String.
            '* * * * *

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

            VerifyDatabaseIntegrity()
        End Sub

        ''' <summary>Verifies that the requested database exists and that its file size is greater than zero. If not, it extracts the embedded database file to the local output folder.</summary>
        Public Sub VerifyDatabaseIntegrity()
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
        Public Async Function LoadAdminPasssword() As Task
            AdminPassword = Await DatabaseInteraction.LoadAdminPasssword()
        End Function

        ''' <summary>Loads almost everything required from the database.</summary>
        Public Async Function LoadAll() As Task
            FileManagement()
            Await LoadAdminPasssword()
            Await LoadArmor()
            Await LoadGuilds()
            Await LoadFood()
            Await LoadDrinks()
            Await LoadPotions()
            Await LoadRanks()
            Await LoadWeapons()
            Await LoadEnemies()
            AllArmor = AllArmor.OrderBy(Function(obj) obj.Value)
            AllGuilds = AllGuilds.OrderBy(Function(obj) obj.ID)
            AllFood = AllFood.OrderBy(Function(obj) obj.Value)
            AllDrinks = AllDrinks.OrderBy(Function(obj) obj.Value)
            AllPotions = AllPotions.OrderBy(Function(obj) obj.Value)
            AllWeapons = AllWeapons.OrderBy(Function(obj) obj.Value)
            AllEnemies = AllEnemies.OrderBy(Function(obj) obj.Level)
        End Function

        '''<summary>Loads all Armor from the database.</summary>
        ''' <returns>All Armor</returns>
        Public Async Function LoadArmor() As Task
            AllArmor = Await DatabaseInteraction.LoadArmor()
        End Function

        ''' <summary>Loads all Enemies from the database.</summary>
        ''' <returns>All Enemies</returns>
        Public Async Function LoadEnemies() As Task
            AllEnemies = Await DatabaseInteraction.LoadEnemies()
        End Function

        ''' <summary>Loads all Guilds from the database.</summary>
        ''' <returns>All Guilds</returns>
        Public Async Function LoadGuilds() As Task
            AllGuilds = Await DatabaseInteraction.LoadGuilds()
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

        ''' <summary>Loads all Food from the database.</summary>
        ''' <returns>All Food</returns>
        Public Async Function LoadFood() As Task
            AllFood = Await DatabaseInteraction.LoadFood()
        End Function

        ''' <summary> Loads all Drinks from the database.</summary>
        ''' <returns>All Drinks</returns>
        Public Async Function LoadDrinks() As Task
            AllDrinks = Await DatabaseInteraction.LoadDrinks()
        End Function

        ''' <summary>Loads all Potions from the database.</summary>
        ''' <returns>All Potions</returns>
        Public Async Function LoadPotions() As Task
            AllPotions = Await DatabaseInteraction.LoadPotions()
        End Function

        ''' <summary>Loads all Ranks from the database.</summary>
        ''' <returns>All Ranks</returns>
        Public Async Function LoadRanks() As Task
            AllRanks = Await DatabaseInteraction.LoadRanks()
        End Function

        ''' <summary>Loads a User from the database.</summary>
        ''' <param name="name">User to be loaded</param>
        ''' <returns>User</returns>
        Public Async Function LoadUser(name As String) As Task(Of User)
            Return Await DatabaseInteraction.LoadUser((name))
        End Function

        ''' <summary>Loads all Users from the database.</summary>
        ''' <returns>All Users</returns>
        Public Async Function LoadUsers() As Task(Of List(Of User))
            Return Await DatabaseInteraction.LoadUsers()
        End Function

        ''' <summary>Loads all Weapons from the database.</summary>
        ''' <returns>All Weapons</returns>
        Public Async Function LoadWeapons() As Task
            AllWeapons = Await DatabaseInteraction.LoadWeapons()
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
            Return Await DatabaseInteraction.MemberLeavesGuild(leaveUser, leaveGuild)
        End Function

        ''' <summary>Saves a Guild.</summary>
        ''' <param name="guildSave">Guild to be saved</param>
        Public Async Function SaveGuild(guildSave As Guild) As Task(Of Boolean)
            Return Await DatabaseInteraction.SaveGuild(guildSave)
        End Function

#End Region

    End Module

End Namespace