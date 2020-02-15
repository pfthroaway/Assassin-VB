Option Strict On
Option Explicit On

Imports Assassin.Classes.Entities
Imports Assassin.Classes.Enums
Imports Assassin.Classes.Items
Imports Extensions
Imports Extensions.DatabaseHelp
Imports Extensions.DataTypeHelpers
Imports System.Data.SQLite
Imports System.IO
Imports System.Reflection
Imports System.Threading.Tasks

Namespace Classes.Database

    ''' <summary>Represents all SQLite database interactions required by the game.</summary>
    Public Class SQLiteDatabaseInteraction
        Implements IDatabaseInteraction

        Private Const _databasename As String = "Assassin.sqlite"
        ReadOnly DatabaseLocation As String = Path.Combine(AppData.Location, _databasename)
        ReadOnly _con As String = $"Data Source = {DatabaseLocation}; foreign keys = TRUE; Version=3"

        ''' <summary>Verifies that the requested database exists and that its file size is greater than zero. If not, it extracts the embedded database file to the local output folder.</summary>
        Public Sub VerifyDatabaseIntegrity() Implements IDatabaseInteraction.VerifyDatabaseIntegrity
            Functions.VerifyFileIntegrity(
                Assembly.GetExecutingAssembly().GetManifestResourceStream($"Assassin.{_databasename}"), _databasename, AppData.Location)
        End Sub

        ''' <summary>Changes the admin password in the database.</summary>
        ''' <param name="newPass">New password</param>
        ''' <returns>True if successful</returns>
        Public Async Function ChangeAdminPassword(newPass As String) As Task(Of Boolean) Implements IDatabaseInteraction.ChangeAdminPassword
            Dim cmd As New SQLiteCommand With {.CommandText = "UPDATE Admin SET AdminPassword = @newPass"}
            cmd.Parameters.AddWithValue("@newPass", newPass)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

#Region "Enemy Management"

        ''' <summary>Deletes an <see cref="Enemy"/> from the database.</summary>
        ''' <param name="enemyDelete"><see cref="Enemy"/> to be deleted from the database</param>
        ''' <returns>True if successful</returns>
        Public Async Function DeleteEnemy(enemyDelete As Enemy) As Task(Of Boolean) Implements IDatabaseInteraction.DeleteEnemy
            Dim cmd As New SQLiteCommand With {.CommandText = "DELETE FROM Enemies WHERE [EnemyName] = @name"}
            cmd.Parameters.AddWithValue("@name", enemyDelete.Name)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Adds a new <see cref="Enemy"/> to the database.</summary>
        ''' <param name="enemyNew"><see cref="Enemy"/> to be added to the database</param>
        ''' <returns>True if successful</returns>
        Public Async Function NewEnemy(enemyNew As Enemy) As Task(Of Boolean) Implements IDatabaseInteraction.NewEnemy
            Dim cmd As New SQLiteCommand With {.CommandText = "INSERT INTO Enemies([EnemyName], [Level], [Endurance], [Weapon], [Armor], [Gold], [WeaponSkill], [Blocking], [Slipping])VALUES(@name, @level, @endurance, @weapon, @armor, @gold, @weaponSkill, @blocking, @slipping)"}

            cmd.Parameters.AddWithValue("@name", enemyNew.Name)
            cmd.Parameters.AddWithValue("@level", enemyNew.Level)
            cmd.Parameters.AddWithValue("@endurance", enemyNew.MaximumEndurance)
            cmd.Parameters.AddWithValue("@weapon", enemyNew.Weapon.Name)
            cmd.Parameters.AddWithValue("@armor", enemyNew.Armor.Name)
            cmd.Parameters.AddWithValue("@gold", enemyNew.GoldOnHand)
            cmd.Parameters.AddWithValue("@weaponSkill", enemyNew.WeaponSkill)
            cmd.Parameters.AddWithValue("@blocking", enemyNew.Blocking)
            cmd.Parameters.AddWithValue("@slipping", enemyNew.Slipping)

            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Saves an <see cref="Enemy"/> to the database.</summary>
        ''' <param name="oldEnemy">Enemy to be replaced</param>
        ''' <param name="newEnemy">Enemy to be saved</param>
        ''' <returns>True if successful</returns>
        Public Async Function SaveEnemy(newEnemy As Enemy, oldEnemy As Enemy) As Task(Of Boolean) Implements IDatabaseInteraction.SaveEnemy
            Dim cmd As New SQLiteCommand With {.CommandText = "UPDATE Enemies SET [EnemyName] = @name, [Level] = @level, [Endurance] = @endurance, [Weapon] = @weapon, [Armor] = @armor, [Gold] = @gold, [WeaponSkill] = @weaponSkill, [Blocking] = @blocking, [Slipping] = @slipping WHERE [EnemyName] = @oldName"}

            cmd.Parameters.AddWithValue("@name", newEnemy.Name)
            cmd.Parameters.AddWithValue("@level", newEnemy.Level)
            cmd.Parameters.AddWithValue("@endurance", newEnemy.MaximumEndurance)
            cmd.Parameters.AddWithValue("@weapon", newEnemy.Weapon.Name)
            cmd.Parameters.AddWithValue("@armor", newEnemy.Armor.Name)
            cmd.Parameters.AddWithValue("@gold", newEnemy.GoldOnHand)
            cmd.Parameters.AddWithValue("@weaponSkill", newEnemy.WeaponSkill)
            cmd.Parameters.AddWithValue("@blocking", newEnemy.Blocking)
            cmd.Parameters.AddWithValue("@slipping", newEnemy.Slipping)
            cmd.Parameters.AddWithValue("@oldName", oldEnemy.Name)

            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

#End Region

#Region "Guild Management"

        ''' <summary><see cref="User"/> applies for membership with a <see cref="Guild"/>.</summary>
        ''' <param name="joinUser"><see cref="User"/> applying to join the <see cref="Guild"/>.</param>
        ''' <param name="joinGuild"><see cref="Guild"/> being applied to</param>
        ''' <returns>True if successful</returns>
        Public Async Function ApplyToGuild(joinUser As User, joinGuild As Guild) As Task(Of Boolean) Implements IDatabaseInteraction.ApplyToGuild
            Dim guildID As String = $"Guild{joinGuild.ID}Members"
            Dim cmd As New SQLiteCommand With {.CommandText = $"INSERT INTO Applications([Username], [Guild])VALUES(@name, @guild)"}
            cmd.Parameters.AddWithValue("@name", joinUser.Name)
            cmd.Parameters.AddWithValue("@guild", joinGuild.ID)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary><see cref="User"/> is approved for membership with a <see cref="Guild"/>.</summary>
        ''' <param name="approveUser"><see cref="User"/> approved to join the <see cref="Guild"/>.</param>
        ''' <param name="approveGuild"><see cref="Guild"/> being joined</param>
        ''' <returns>True if successful</returns>
        Public Async Function ApproveGuildApplication(approveUser As User, approveGuild As Guild) As Task(Of Boolean) Implements IDatabaseInteraction.ApproveGuildApplication
            Return Await DeleteGuildApplication(approveUser, approveGuild) AndAlso Await SendMessage(New Message(Await SQLiteHelper.GetNextIndex(_con, "Messages"), approveGuild.Name, approveUser.Name, $"Your application to join the {approveGuild.Name.Replace("'", "''")} guild has been approved. Welcome!", Now, True)) AndAlso Await MemberJoinsGuild(approveUser, approveGuild)
        End Function

        ''' <summary>Deletes a <see cref="User"/>'s application to a <see cref="Guild"/>.</summary>
        ''' <param name="deleteUser"><see cref="User"/> whose application is deleted</param>
        ''' <param name="deleteGuild"><see cref="Guild"/> from which the <see cref="User"/>'s application was deleted</param>
        ''' <returns>True if successful</returns>
        Public Async Function DeleteGuildApplication(deleteUser As User, deleteGuild As Guild) As Task(Of Boolean) Implements IDatabaseInteraction.DeleteGuildApplication
            Dim cmd As New SQLiteCommand With {.CommandText = $"DELETE FROM Applications WHERE [Username] = @name AND [Guild] = @guild"}
            cmd.Parameters.AddWithValue("@name", deleteUser.Name)
            cmd.Parameters.AddWithValue("@guild", deleteGuild.ID)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Denies a <see cref="User"/>'s application to a <see cref="Guild"/>.</summary>
        ''' <param name="denyUser"><see cref="User"/> whose application is denied</param>
        ''' <param name="denyGuild"><see cref="Guild"/> from which the <see cref="User"/>'s application was denied</param>
        ''' <returns>True if successful</returns>
        Public Async Function DenyGuildApplication(denyUser As User, denyGuild As Guild) As Task(Of Boolean) Implements IDatabaseInteraction.DenyGuildApplication
            Return Await DeleteGuildApplication(denyUser, denyGuild) AndAlso Await SendMessage(New Message(Await SQLiteHelper.GetNextIndex(_con, "Messages"), denyGuild.Name, denyUser.Name, $"Your application to join the {denyGuild.Name.Replace("'", "''")} guild has been denied.", Now, True))
        End Function

        ''' <summary>Checks whether the <see cref="User"/> has applied to the selected <see cref="Guild"/>.</summary>
        ''' <param name="checkUser"><see cref="User"/> to check if has applied to the <see cref="Guild"/>.</param>
        ''' <param name="checkGuild"><see cref="Guild"/> being joined</param>
        ''' <returns>True if has applied</returns>
        Public Async Function HasAppliedToGuild(checkUser As User, checkGuild As Guild) As Task(Of Boolean) Implements IDatabaseInteraction.HasAppliedToGuild
            Dim guildID As String = $"Guild{checkGuild.ID}Members"
            Dim cmd As New SQLiteCommand With {.CommandText = $"SELECT * FROM {guildID} Where [Username] = @name"}
            cmd.Parameters.AddWithValue("@name", checkUser.Name)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, cmd)
            Return ds.Tables(0).Rows.Count > 0
        End Function

        ''' <summary>Member of a <see cref="Guild"/> gains membership with that <see cref="Guild"/>, applied to database.</summary>
        ''' <param name="joinUser"><see cref="User"/> joining the <see cref="Guild"/>.</param>
        ''' <param name="joinGuild"><see cref="Guild"/> being joined</param>
        ''' <returns>True if successful</returns>
        Public Async Function MemberJoinsGuild(joinUser As User, joinGuild As Guild) As Task(Of Boolean) Implements IDatabaseInteraction.MemberJoinsGuild
            Dim guildID As String = $"Guild{joinGuild.ID}Members"
            Dim cmd As New SQLiteCommand With {.CommandText = $"INSERT INTO {guildID}([Username])VALUES(@name)"}
            cmd.Parameters.AddWithValue("@name", joinUser.Name)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Member of a <see cref="Guild"/> terminates membership with that <see cref="Guild"/>, applied to database.</summary>
        ''' <param name="leaveUser"><see cref="User"/> leaving the <see cref="Guild"/>.</param>
        ''' <param name="leaveGuild"><see cref="Guild"/> being left</param>
        ''' <returns>True if successful</returns>
        Public Async Function MemberLeavesGuild(leaveUser As User, leaveGuild As Guild) As Task(Of Boolean) Implements IDatabaseInteraction.MemberLeavesGuild
            Dim guildID As String = $"Guild{leaveGuild.ID}Members"
            Dim cmd As New SQLiteCommand With {.CommandText = $"DELETE FROM {guildID} WHERE [Username] = @name"}
            cmd.Parameters.AddWithValue("@name", leaveUser.Name)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Saves a <see cref="Guild"/>.</summary>
        ''' <param name="guildSave"><see cref="Guild"/> to be saved</param>
        Public Async Function SaveGuild(guildSave As Guild) As Task(Of Boolean) Implements IDatabaseInteraction.SaveGuild
            Dim cmd As New SQLiteCommand With {.CommandText = "UPDATE Guilds SET [GuildName] = @guildName, [Guildmaster] = @guildmaster, [GuildFee] = @guildFee, [GuildGold] = @guildGold, [HenchmenLevel1] = @henchmenLevel1, [HenchmenLevel2] = @henchmenLevel2, [HenchmenLevel3] = @henchmenLevel3, [HenchmenLevel4] = @henchmenLevel4, [HenchmenLevel5] = @henchmenLevel5 WHERE [ID] = @id"}

            cmd.Parameters.AddWithValue("@guildName", guildSave.Name)
            cmd.Parameters.AddWithValue("@guildmaster", guildSave.Master)
            cmd.Parameters.AddWithValue("@guildFee", guildSave.Fee)
            cmd.Parameters.AddWithValue("@guildGold", guildSave.Gold)
            cmd.Parameters.AddWithValue("@henchmenLevel1", guildSave.HenchmenLevel1.ToString())
            cmd.Parameters.AddWithValue("@henchmenLevel2", guildSave.HenchmenLevel2.ToString())
            cmd.Parameters.AddWithValue("@henchmenLevel3", guildSave.HenchmenLevel3.ToString())
            cmd.Parameters.AddWithValue("@henchmenLevel4", guildSave.HenchmenLevel4.ToString())
            cmd.Parameters.AddWithValue("@henchmenLevel5", guildSave.HenchmenLevel5.ToString())
            cmd.Parameters.AddWithValue("@id", guildSave.ID)

            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

#End Region

#Region "Jail Management"

        ''' <summary>Frees a <see cref="JailedUser"/> from Jail.</summary>
        ''' <param name="jailUser"><see cref="JailedUser"/> to be freed</param>
        ''' <returns>True if successful</returns>
        Public Async Function FreeFromJail(jailUser As JailedUser) As Task(Of Boolean) Implements IDatabaseInteraction.FreeFromJail
            Dim cmd As New SQLiteCommand With {.CommandText = $"DELETE FROM Jail WHERE [Username] = @name"}
            cmd.Parameters.AddWithValue("@name", jailUser.Name)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Sends a <see cref="JailedUser"/> to Jail.</summary>
        ''' <param name="jailUser"><see cref="JailedUser"/> to be jailed</param>
        ''' <returns>True if successful</returns>
        Public Async Function SendToJail(jailUser As JailedUser) As Task(Of Boolean) Implements IDatabaseInteraction.SendToJail
            Dim cmd As New SQLiteCommand With {.CommandText = $"INSERT INTO Jail([Username], [Reason], [Fine], [DateJailed])VALUES(@name, @reason, @fine, @dateJailed)"}
            cmd.Parameters.AddWithValue("@name", jailUser.Name)
            cmd.Parameters.AddWithValue("@reason", jailUser.Reason)
            cmd.Parameters.AddWithValue("@fine", jailUser.Fine)
            cmd.Parameters.AddWithValue("@dateJailed", jailUser.DateJailed)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

#End Region

#Region "Load"

        ''' <summary>Loads the Admin password from the database.</summary>
        ''' <returns>Admin password</returns>
        Public Async Function LoadAdminPasssword() As Task(Of String) Implements IDatabaseInteraction.LoadAdminPasssword
            Dim pass As String = ""
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Admin")
            If ds.Tables(0).Rows.Count > 0 Then
                pass = ds.Tables(0).Rows(0)("AdminPassword").ToString()
            End If
            Return pass
        End Function

        ''' <summary>Loads all <see cref="Armor"/> from the database.</summary>
        ''' <returns>All <see cref="Armor"/></returns>
        Public Async Function LoadArmor() As Task(Of List(Of Armor)) Implements IDatabaseInteraction.LoadArmor
            Dim allArmor As List(Of Armor) = New List(Of Armor)()
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Armor")
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim newArmor As New Armor(ds.Tables(0).Rows(i)("ArmorName").ToString(), Int32Helper.Parse(ds.Tables(0).Rows(i)("ArmorDefense")), Int32Helper.Parse(ds.Tables(0).Rows(i)("ArmorValue")), BoolHelper.Parse(ds.Tables(0).Rows(i)("Hidden")))

                    allArmor.Add(newArmor)
                Next
            End If
            Return allArmor
        End Function

        ''' <summary>Loads all <see cref="Drink"/>s from the database.</summary>
        ''' <returns>All <see cref="Drink"/>s</returns>
        Public Async Function LoadDrinks() As Task(Of List(Of Drink)) Implements IDatabaseInteraction.LoadDrinks
            Dim allDrinks As New List(Of Drink)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Drinks")
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim newDrink As New Drink(ds.Tables(0).Rows(i)("DrinkName").ToString(), Int32Helper.Parse(ds.Tables(0).Rows(i)("RestoreThirst")), Int32Helper.Parse(ds.Tables(0).Rows(i)("DrinkValue")))

                    allDrinks.Add(newDrink)
                Next
            End If

            Return allDrinks
        End Function

        ''' <summary>Loads all <see cref="Enemy"/>s from the database.</summary>
        ''' <returns>All <see cref="Enemy"/>s</returns>
        Public Async Function LoadEnemies() As Task(Of List(Of Enemy)) Implements IDatabaseInteraction.LoadEnemies
            Dim allEnemies As New List(Of Enemy)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Enemies")
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    Dim newEnemy As New Enemy With {
                            .Name = dr("EnemyName").ToString(),
                            .Level = Int32Helper.Parse(dr("Level")),
                            .MaximumEndurance = Int32Helper.Parse(dr("Endurance")),
                            .CurrentEndurance = .MaximumEndurance,
                            .Weapon = AllWeapons.Find(Function(newWeapon) newWeapon.Name = dr("Weapon").ToString),
                            .Armor = AllArmor.Find(Function(newArmor) newArmor.Name = dr("Armor").ToString),
                            .GoldOnHand = Int32Helper.Parse(dr("Gold")),
                            .WeaponSkill = Int32Helper.Parse(dr("WeaponSkill")),
                            .Blocking = Int32Helper.Parse(dr("Blocking")),
                            .Slipping = Int32Helper.Parse(dr("Slipping"))
                    }
                    allEnemies.Add(newEnemy)
                Next
            End If

            allEnemies = allEnemies.OrderBy(Function(enemy) enemy.Level).ToList()
            Return allEnemies
        End Function

        ''' <summary>Loads all <see cref="Food"/> from the database.</summary>
        ''' <returns>All <see cref="Food"/></returns>
        Public Async Function LoadFood() As Task(Of List(Of Food)) Implements IDatabaseInteraction.LoadFood
            Dim allFood As New List(Of Food)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Food")
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim newFood As New Food(ds.Tables(0).Rows(i)("FoodName").ToString(), Int32Helper.Parse(ds.Tables(0).Rows(i)("RestoreHunger")), Int32Helper.Parse(ds.Tables(0).Rows(i)("FoodValue")))

                    allFood.Add(newFood)
                Next
            End If

            Return allFood
        End Function

        ''' <summary>Loads all <see cref="Guild"/>s from the database.</summary>
        ''' <returns>All <see cref="Guild"/>s</returns>
        Public Async Function LoadGuilds() As Task(Of List(Of Guild)) Implements IDatabaseInteraction.LoadGuilds
            Dim allGuilds As New List(Of Guild)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Guilds")

            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    Dim newGuild As New Guild(Int32Helper.Parse(dr("ID")), dr("GuildName").ToString(), dr("Guildmaster").ToString(), Int32Helper.Parse(dr("GuildFee")), Int32Helper.Parse(dr("GuildGold")), New List(Of String)(), Int32Helper.Parse(dr("HenchmenLevel1")), Int32Helper.Parse(dr("HenchmenLevel2")), Int32Helper.Parse(dr("HenchmenLevel3")), Int32Helper.Parse(dr("HenchmenLevel4")), Int32Helper.Parse(dr("HenchmenLevel5")))
                    Dim members As String = $"Guild{Int32Helper.Parse(dr("ID"))}Members"
                    Dim membersDS As DataSet = Await SQLiteHelper.FillDataSet(_con, $"SELECT * FROM {members}")
                    If membersDS.Tables(0).Rows.Count > 0 Then
                        For Each drM As DataRow In membersDS.Tables(0).Rows
                            newGuild.Members.Add(drM("Username").ToString())
                        Next
                    End If
                    allGuilds.Add(newGuild)
                Next
            End If
            Return allGuilds
        End Function

        ''' <summary>Loads all applicants for a selected <see cref="Guild"/>.</summary>
        ''' <param name="currentGuild"><see cref="Guild"/> whose applicants are to be loaded</param>
        ''' <returns>All applicants for a selected <see cref="Guild"/></returns>
        Public Async Function LoadGuildApplicants(currentGuild As Guild) As Task(Of List(Of String)) Implements IDatabaseInteraction.LoadGuildApplicants
            Dim applicants As New List(Of String)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, $"SELECT * FROM Applications WHERE Guild=""{currentGuild.ID}""")

            If ds.Tables(0).Rows.Count > 0 Then
                For Each applicant As String In ds.Tables(0).Rows
                    applicants.Add(applicant)
                Next
            End If
            Return applicants
        End Function

        ''' <summary>Loads all <see cref="JailedUser"/>s.</summary>
        ''' <returns>All <see cref="JailedUser"/>s</returns>
        Public Async Function LoadJailedUsers() As Task(Of List(Of JailedUser)) Implements IDatabaseInteraction.LoadJailedUsers
            Dim jailedUsers As New List(Of JailedUser)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, $"SELECT * FROM Jail")

            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    jailedUsers.Add(New JailedUser(dr("Username").ToString(), EnumHelper.Parse(Of Crime)(dr("Reason").ToString()), Int32Helper.Parse(dr("Fine")), DateTimeHelper.Parse(dr("DateJailed"))))
                Next
            End If
            Return jailedUsers
        End Function

        ''' <summary>Loads all <see cref="Message"/>s for specified <see cref="User"/>.</summary>
        ''' <param name="loadUser"><see cref="User"/> whose <see cref="Message"/>s are to be loaded</param>
        ''' <returns>List of all <see cref="Message"/>s for the specified <see cref="User"/></returns>
        Public Async Function LoadMessages(loadUser As User) As Task(Of List(Of Message)) Implements IDatabaseInteraction.LoadMessages
            Dim _messages As List(Of Message) = New List(Of Message)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, $"SELECT * FROM Messages WHERE UserTo=""{loadUser.Name}""")

            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    _messages.Add(New Message(Int32Helper.Parse(dr("ID")), dr("UserFrom").ToString, loadUser.Name, dr("Message").ToString, DateTimeHelper.Parse(dr("DateSent").ToString), BoolHelper.Parse("GuildMessage")))
                Next
            End If
            Return _messages
        End Function

        ''' <summary>Loads all <see cref="Potion"/>s from the database.</summary>
        ''' <returns>All <see cref="Potion"/>s</returns>
        Public Async Function LoadPotions() As Task(Of List(Of Potion)) Implements IDatabaseInteraction.LoadPotions
            Dim allPotions As New List(Of Potion)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Potions")
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim newPotion As New Potion(ds.Tables(0).Rows(i)("PotionName").ToString(), Int32Helper.Parse(ds.Tables(0).Rows(i)("PotionHeal")), Int32Helper.Parse(ds.Tables(0).Rows(i)("PotionValue")))

                    allPotions.Add(newPotion)
                Next
            End If

            Return allPotions
        End Function

        ''' <summary>Loads all Ranks from the database.</summary>
        ''' <returns>All Ranks</returns>
        Public Async Function LoadRanks() As Task(Of List(Of String)) Implements IDatabaseInteraction.LoadRanks
            Dim allRanks As New List(Of String)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Ranks")
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    allRanks.Add(ds.Tables(0).Rows(i)("RankName").ToString())
                Next
            End If
            Return allRanks
        End Function

        ''' <summary>Loads a <see cref="User"/> from the database.</summary>
        ''' <param name="name"><see cref="User"/> to be loaded</param>
        ''' <returns><see cref="User"/></returns>
        Public Async Function LoadUser(name As String) As Task(Of User) Implements IDatabaseInteraction.LoadUser
            Dim newUser As New User
            Dim cmd As New SQLiteCommand With {.CommandText = "SELECT * FROM Users Where [Username] = @name"}
            cmd.Parameters.AddWithValue("@name", name)
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, cmd)
            If ds.Tables(0).Rows.Count > 0 Then
                newUser = AssignUserFromDataRow(ds.Tables(0).Rows(0))
            End If
            Return newUser
        End Function

        ''' <summary>Loads all <see cref="User"/>s from the database.</summary>
        ''' <returns>All <see cref="User"/>s</returns>
        Public Async Function LoadUsers() As Task(Of List(Of User)) Implements IDatabaseInteraction.LoadUsers
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Users")
            Dim allUsers As New List(Of User)
            If ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    allUsers.Add(AssignUserFromDataRow(dr))
                Next
            End If
            Return allUsers
        End Function

        ''' <summary>Loads all <see cref="Weapon"/>s from the database.</summary>
        ''' <returns>All <see cref="Weapon"/>s</returns>
        Public Async Function LoadWeapons() As Task(Of List(Of Weapon)) Implements IDatabaseInteraction.LoadWeapons
            Dim allWeapons As List(Of Weapon) = New List(Of Weapon)()
            Dim ds As DataSet = Await SQLiteHelper.FillDataSet(_con, "SELECT * FROM Weapons")
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim type As WeaponType
                    [Enum].TryParse(ds.Tables(0).Rows(i).Item("WeaponType").ToString(), type)
                    Dim newWeapons As New Weapon(ds.Tables(0).Rows(i)("WeaponName").ToString(), Int32Helper.Parse(ds.Tables(0).Rows(i)("WeaponDamage")), Int32Helper.Parse(ds.Tables(0).Rows(i)("WeaponValue")), BoolHelper.Parse(ds.Tables(0).Rows(i)("Hidden")), type)

                    allWeapons.Add(newWeapons)
                Next
            End If
            Return allWeapons
        End Function

#End Region

#Region "Message Management"

        ''' <summary>Deletes a <see cref="Message"/> from the database.</summary>
        ''' <param name="message"><see cref="Message"/> to be deleted</param>
        ''' <returns>True if successful</returns>
        Public Async Function DeleteMessage(message As Message) As Task(Of Boolean) Implements IDatabaseInteraction.DeleteMessage
            Dim cmd As New SQLiteCommand With {.CommandText = $"DELETE FROM Messages WHERE [ID] = @id"}
            cmd.Parameters.AddWithValue("@id", message.ID)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Sends a <see cref="Message"/> between <see cref="User"/>s.</summary>
        ''' <param name="message"><see cref="Message"/> sent</param>
        ''' <returns>True if successful</returns>
        Public Async Function SendMessage(message As Message) As Task(Of Boolean) Implements IDatabaseInteraction.SendMessage
            Dim cmd As New SQLiteCommand With {.CommandText = $"INSERT INTO Messages([UserTo], [UserFrom], [Message], [DateSent], [GuildMessage])VALUES(@userTo, @userFrom, @message, @dateSent, @guildMessage)"}
            cmd.Parameters.AddWithValue("@userTo", message.UserTo)
            cmd.Parameters.AddWithValue("@userFrom", message.UserFrom)
            cmd.Parameters.AddWithValue("@message", message.Contents)
            cmd.Parameters.AddWithValue("@dateSent", message.DateSent)
            cmd.Parameters.AddWithValue("@guildMessage", Int32Helper.Parse(message.GuildMessage))
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

#End Region

#Region "User Management"

        ''' <summary>Assigns a <see cref="User"/> from a DataRow.</summary>
        ''' <param name="dr">DataRow containing <see cref="User"/></param>
        ''' <returns>Assigned <see cref="User"/></returns>
        Private Function AssignUserFromDataRow(dr As DataRow) As User
            'character
            Dim type As WeaponType
            [Enum].TryParse(dr.Item("CurrentWeapon").ToString(), type)

            Dim newUser As New User With {
                .Name = dr.Item("Username").ToString(),
                .Password = dr.Item("Password").ToString(),
                .Level = Int32Helper.Parse(dr.Item("Level").ToString()),
                .Experience = Int32Helper.Parse(dr.Item("Experience").ToString()),
                .SkillPoints = Int32Helper.Parse(dr.Item("SkillPoints").ToString()),
                .Alive = BoolHelper.Parse(dr.Item("Alive")),
                .CurrentEndurance = Int32Helper.Parse(dr.Item("CurrentEndurance").ToString()),
                .CurrentLocation = EnumHelper.Parse(Of SleepLocation)(dr.Item("Location").ToString()),
                .MaximumEndurance = Int32Helper.Parse(dr.Item("MaximumEndurance").ToString()),
                .Hunger = Int32Helper.Parse(dr.Item("Hunger").ToString()),
                .Thirst = Int32Helper.Parse(dr.Item("Thirst").ToString()),
                .CurrentWeaponType = type,
                .LightWeapon = AllWeapons.Find(Function(newWeapon) newWeapon.Name = dr.Item("LightWeapon").ToString()),
                .HeavyWeapon = AllWeapons.Find(Function(newWeapon) newWeapon.Name = dr.Item("HeavyWeapon").ToString()),
                .TwoHandedWeapon = AllWeapons.Find(Function(newWeapon) newWeapon.Name = dr.Item("TwoHandedWeapon").ToString()),
                .Armor = AllArmor.Find(Function(newArmor) newArmor.Name = dr.Item("Armor").ToString()),
                .Potion = AllPotions.Find(Function(newPotion) newPotion.Name = dr("Potion").ToString()),
                .Lockpicks = Int32Helper.Parse(dr.Item("Lockpicks").ToString()),
                .GoldOnHand = Int32Helper.Parse(dr.Item("GoldOnHand").ToString()),
                .GoldInBank = Int32Helper.Parse(dr.Item("GoldInBank").ToString()),
                .GoldOnLoan = Int32Helper.Parse(dr.Item("GoldOnLoan").ToString()),
                .Shovel = BoolHelper.Parse(dr.Item("Shovel")),
                .Lantern = BoolHelper.Parse(dr.Item("Lantern")),
                .Amulet = BoolHelper.Parse(dr.Item("Amulet")),
                .LightWeaponSkill = Int32Helper.Parse(dr.Item("LightWeaponSkill").ToString()),
                .HeavyWeaponSkill = Int32Helper.Parse(dr.Item("HeavyWeaponSkill").ToString()),
                .TwoHandedWeaponSkill = Int32Helper.Parse(dr.Item("TwoHandedWeaponSkill").ToString()),
                .Blocking = Int32Helper.Parse(dr.Item("Blocking").ToString()),
                .Slipping = Int32Helper.Parse(dr.Item("Slipping").ToString()),
                .Stealth = Int32Helper.Parse(dr.Item("Stealth").ToString()),
                .HenchmenLevel1 = Int32Helper.Parse(dr.Item("HenchmenLevel1").ToString()),
                .HenchmenLevel2 = Int32Helper.Parse(dr.Item("HenchmenLevel2").ToString()),
                .HenchmenLevel3 = Int32Helper.Parse(dr.Item("HenchmenLevel3").ToString()),
                .HenchmenLevel4 = Int32Helper.Parse(dr.Item("HenchmenLevel4").ToString()),
                .HenchmenLevel5 = Int32Helper.Parse(dr.Item("HenchmenLevel5").ToString())
            }

            'inventory

            Return newUser
        End Function

        ''' <summary>Deletes a <see cref="User"/> from the database.</summary>
        ''' <param name="userDelete"><see cref="User"/> to be deleted.</param>
        ''' <returns>True if successful</returns>
        Public Async Function DeleteUser(userDelete As User) As Task(Of Boolean) Implements IDatabaseInteraction.DeleteUser
            Dim cmd As New SQLiteCommand With {.CommandText = "DELETE FROM Users WHERE [Username] = @name"}
            cmd.Parameters.AddWithValue("@name", userDelete.Name)
            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Adds a <see cref="User"/> to the database.</summary>
        ''' <param name="userNew"><see cref="User"/> to be added</param>
        ''' <returns>True if successful</returns>
        Public Async Function NewUser(userNew As User) As Task(Of Boolean) Implements IDatabaseInteraction.NewUser
            Dim cmd As New SQLiteCommand With {.CommandText = "INSERT INTO Users([Username], [Password], [Level], [Experience], [SkillPoints], [Alive], [Location], [CurrentEndurance], [MaximumEndurance], [Hunger], [Thirst], [CurrentWeapon], [LightWeapon], [HeavyWeapon], [TwoHandedWeapon], [Armor], [Potion], [Lockpicks], [GoldOnHand], [GoldInBank], [GoldOnLoan], [Shovel], [Lantern], [Amulet], [LightWeaponSkill], [HeavyWeaponSkill], [TwoHandedWeaponSkill], [Blocking], [Slipping], [Stealth], [HenchmenLevel1], [HenchmenLevel2], [HenchmenLevel3], [HenchmenLevel4], [HenchmenLevel5])VALUES(@name, @password, @level, @experience, @skillPoints, @alive, @location, @currentEndurance, @maximumEndurance, @hunger, @thirst, @currentWeapon, @lightWeapon, @heavyWeapon, @twoHandedWeapon, @armor, @potion, @lockpicks, @goldOnHand, @goldInBank, @goldOnLoan, @shovel, @lantern, @amulet, @lightWeaponSkill, @heavyWeaponSkill, @twoHandedWeaponSkill, @blocking, @slipping, @stealth, @henchmenLevel1, @henchmenLevel2, @henchmenLevel3, @henchmenLevel4, @henchmenLevel5)"}

            cmd.Parameters.AddWithValue("@name", userNew.Name)
            cmd.Parameters.AddWithValue("@password", userNew.Password.Replace("\0", ""))
            cmd.Parameters.AddWithValue("@level", userNew.Level)
            cmd.Parameters.AddWithValue("@experience", userNew.Experience.ToString())
            cmd.Parameters.AddWithValue("@skillPoints", userNew.SkillPoints.ToString())
            cmd.Parameters.AddWithValue("@alive", Int32Helper.Parse(userNew.Alive))
            cmd.Parameters.AddWithValue("@location", userNew.CurrentLocation)
            cmd.Parameters.AddWithValue("@currentEndurance", userNew.CurrentEndurance.ToString())
            cmd.Parameters.AddWithValue("@maximumEndurance", userNew.MaximumEndurance.ToString())
            cmd.Parameters.AddWithValue("@hunger", userNew.Hunger.ToString())
            cmd.Parameters.AddWithValue("@thirst", userNew.Thirst.ToString())
            cmd.Parameters.AddWithValue("@currentWeapon", userNew.CurrentWeaponType.ToString())
            cmd.Parameters.AddWithValue("@lightWeapon", userNew.LightWeapon.Name)
            cmd.Parameters.AddWithValue("@heavyWeapon", userNew.HeavyWeapon.Name)
            cmd.Parameters.AddWithValue("@twoHandedWeapon", userNew.TwoHandedWeapon.Name)
            cmd.Parameters.AddWithValue("@armor", userNew.Armor.Name)
            cmd.Parameters.AddWithValue("@potion", userNew.Potion.Name)
            cmd.Parameters.AddWithValue("@lockpicks", userNew.Lockpicks.ToString())
            cmd.Parameters.AddWithValue("@goldOnHand", userNew.GoldOnHand.ToString())
            cmd.Parameters.AddWithValue("@goldInBank", userNew.GoldInBank.ToString())
            cmd.Parameters.AddWithValue("@goldOnLoan", userNew.GoldOnLoan.ToString())
            cmd.Parameters.AddWithValue("@shovel", Int32Helper.Parse(userNew.Shovel))
            cmd.Parameters.AddWithValue("@lantern", Int32Helper.Parse(userNew.Lantern))
            cmd.Parameters.AddWithValue("@amulet", Int32Helper.Parse(userNew.Amulet))
            cmd.Parameters.AddWithValue("@lightWeaponSkill", userNew.LightWeaponSkill.ToString())
            cmd.Parameters.AddWithValue("@heavyWeaponSkill", userNew.HeavyWeaponSkill.ToString())
            cmd.Parameters.AddWithValue("@twoHandedWeaponSkill", userNew.TwoHandedWeaponSkill.ToString())
            cmd.Parameters.AddWithValue("@blocking", userNew.Blocking.ToString())
            cmd.Parameters.AddWithValue("@slipping", userNew.Slipping.ToString())
            cmd.Parameters.AddWithValue("@stealth", userNew.Stealth.ToString())
            cmd.Parameters.AddWithValue("@henchmenLevel1", userNew.HenchmenLevel1.ToString())
            cmd.Parameters.AddWithValue("@henchmenLevel2", userNew.HenchmenLevel2.ToString())
            cmd.Parameters.AddWithValue("@henchmenLevel3", userNew.HenchmenLevel3.ToString())
            cmd.Parameters.AddWithValue("@henchmenLevel4", userNew.HenchmenLevel4.ToString())
            cmd.Parameters.AddWithValue("@henchmenLevel5", userNew.HenchmenLevel5.ToString())

            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Saves a <see cref="User"/> to the database.</summary>
        ''' <param name="userSave"><see cref="User"/> to be saved</param>
        ''' <returns>True if successful</returns>
        Public Async Function SaveUser(userSave As User) As Task(Of Boolean) Implements IDatabaseInteraction.SaveUser
            Dim cmd As New SQLiteCommand With {.CommandText = "UPDATE Users SET [Password] = @password, [Level] = @level, [Experience] = @experience, [SkillPoints] = @skillPoints, [Alive] = @alive, [Location] = @location, [CurrentEndurance] = @currentEndurance, [MaximumEndurance] = @maximumEndurance, [Hunger] = @hunger, [Thirst] = @thirst, [CurrentWeapon] = @currentWeapon, [LightWeapon] = @lightWeapon, [HeavyWeapon] = @heavyWeapon, [TwoHandedWeapon] = @twoHandedWeapon, [Armor] = @armor, [Potion] = @potion, [Lockpicks] = @lockpicks, [GoldOnHand] = @goldOnHand, [GoldInBank] = @goldInBank, [GoldOnLoan] = @goldOnLoan, [Shovel] = @shovel, [Lantern] = @lantern, [Amulet] = @amulet, [LightWeaponSkill] = @lightWeaponSkill, [HeavyWeaponSkill] = @heavyWeaponSkill, [TwoHandedWeaponSkill] = @twoHandedWeaponSkill, [Blocking] = @blocking, [Slipping] = @slipping, [Stealth] = @stealth, [HenchmenLevel1] = @henchmenLevel1, [HenchmenLevel2] = @henchmenLevel2, [HenchmenLevel3] = @henchmenLevel3, [HenchmenLevel4] = @henchmenLevel4, [HenchmenLevel5] = @henchmenLevel5 WHERE [Username] = @name"}

            cmd.Parameters.AddWithValue("@password", userSave.Password.Replace("\0", ""))
            cmd.Parameters.AddWithValue("@level", userSave.Level)
            cmd.Parameters.AddWithValue("@experience", userSave.Experience)
            cmd.Parameters.AddWithValue("@skillPoints", userSave.SkillPoints)
            cmd.Parameters.AddWithValue("@alive", Int32Helper.Parse(userSave.Alive))
            cmd.Parameters.AddWithValue("@location", userSave.CurrentLocation.ToString())
            cmd.Parameters.AddWithValue("@currentEndurance", userSave.CurrentEndurance)
            cmd.Parameters.AddWithValue("@maximumEndurance", userSave.MaximumEndurance)
            cmd.Parameters.AddWithValue("@hunger", userSave.Hunger)
            cmd.Parameters.AddWithValue("@thirst", userSave.Thirst)
            cmd.Parameters.AddWithValue("@currentWeapon", userSave.CurrentWeaponType.ToString())
            cmd.Parameters.AddWithValue("@lightWeapon", userSave.LightWeapon.Name)
            cmd.Parameters.AddWithValue("@heavyWeapon", userSave.HeavyWeapon.Name)
            cmd.Parameters.AddWithValue("@twoHandedWeapon", userSave.TwoHandedWeapon.Name)
            cmd.Parameters.AddWithValue("@armor", userSave.Armor.Name)
            cmd.Parameters.AddWithValue("@potion", userSave.Potion.Name)
            cmd.Parameters.AddWithValue("@lockpicks", userSave.Lockpicks)
            cmd.Parameters.AddWithValue("@goldOnHand", userSave.GoldOnHand)
            cmd.Parameters.AddWithValue("@goldInBank", userSave.GoldInBank)
            cmd.Parameters.AddWithValue("@goldOnLoan", userSave.GoldOnLoan)
            cmd.Parameters.AddWithValue("@shovel", Int32Helper.Parse(userSave.Shovel))
            cmd.Parameters.AddWithValue("@lantern", Int32Helper.Parse(userSave.Lantern))
            cmd.Parameters.AddWithValue("@amulet", Int32Helper.Parse(userSave.Amulet))
            cmd.Parameters.AddWithValue("@lightWeaponSkill", userSave.LightWeaponSkill)
            cmd.Parameters.AddWithValue("@heavyWeaponSkill", userSave.HeavyWeaponSkill)
            cmd.Parameters.AddWithValue("@twoHandedWeaponSkill", userSave.TwoHandedWeaponSkill)
            cmd.Parameters.AddWithValue("@blocking", userSave.Blocking)
            cmd.Parameters.AddWithValue("@slipping", userSave.Slipping)
            cmd.Parameters.AddWithValue("@stealth", userSave.Stealth)
            cmd.Parameters.AddWithValue("@henchmenLevel1", userSave.HenchmenLevel1)
            cmd.Parameters.AddWithValue("@henchmenLevel2", userSave.HenchmenLevel2)
            cmd.Parameters.AddWithValue("@henchmenLevel3", userSave.HenchmenLevel3)
            cmd.Parameters.AddWithValue("@henchmenLevel4", userSave.HenchmenLevel4)
            cmd.Parameters.AddWithValue("@henchmenLevel5", userSave.HenchmenLevel5)
            cmd.Parameters.AddWithValue("@name", userSave.Name)

            Return Await SQLiteHelper.ExecuteCommand(_con, cmd)
        End Function

        ''' <summary>Changes an <see cref="User"/>'s name and then saves the <see cref="User"/> to the database.</summary>
        ''' <param name="userSave"><see cref="User"/> to be saved</param>
        ''' <param name="newName">New name for <see cref="User"/></param>
        ''' <returns>True if successful</returns>
        Public Async Function SaveUser(userSave As User, newName As String) As Task(Of Boolean) Implements IDatabaseInteraction.SaveUser
            If userSave.Name <> newName Then
                Dim cmd As New SQLiteCommand With {.CommandText = "UPDATE Users SET [Username] = @newName WHERE [Username] = @oldName"}
                cmd.Parameters.AddWithValue("@newName", newName)
                cmd.Parameters.AddWithValue("@oldName", userSave.Name)
                If (Await SQLiteHelper.ExecuteCommand(_con, cmd)) Then
                    userSave.Name = newName
                    Return Await SaveUser(userSave)
                End If
                Return False
            End If
            Return True
        End Function

#End Region

    End Class

End Namespace