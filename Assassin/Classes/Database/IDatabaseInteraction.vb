Option Strict On
Option Explicit On

Imports Assassin.Classes.Entities
Imports Assassin.Classes.Items
Imports System.Threading.Tasks

Namespace Classes.Database

    Public Interface IDatabaseInteraction

        ''' <summary>Verifies that the requested database exists and that its file size is greater than zero. If not, it extracts the embedded database file to the local output folder.</summary>
        Sub VerifyDatabaseIntegrity()

        ''' <summary>Changes the admin password in the database.</summary>
        ''' <param name="newPass">New password</param>
        ''' <returns>True if successful</returns>
        Function ChangeAdminPassword(newPass As String) As Task(Of Boolean)

#Region "Enemy Management"

        ''' <summary>Deletes an <see cref="Enemy"/> from the database.</summary>
        ''' <param name="enemyDelete"><see cref="Enemy"/> to be deleted from the database</param>
        ''' <returns>True if successful</returns>
        Function DeleteEnemy(enemyDelete As Enemy) As Task(Of Boolean)

        ''' <summary>Adds a new <see cref="Enemy"/> to the database.</summary>
        ''' <param name="enemyNew"><see cref="Enemy"/> to be added to the database</param>
        ''' <returns>True if successful</returns>
        Function NewEnemy(enemyNew As Enemy) As Task(Of Boolean)

        ''' <summary>Saves an Enemy to the database.</summary>
        ''' <param name="oldEnemy">Enemy to be replaced</param>
        ''' <param name="newEnemy">Enemy to be saved</param>
        ''' <returns>True if successful</returns>
        Function SaveEnemy(oldEnemy As Enemy, newEnemy As Enemy) As Task(Of Boolean)

#End Region

#Region "Guild Management"

        ''' <summary><see cref="User"/> applies for membership with a <see cref="Guild"/>.</summary>
        ''' <param name="joinUser"><see cref="User"/> applying to join the <see cref="Guild"/>.</param>
        ''' <param name="joinGuild"><see cref="Guild"/> being applied to</param>
        ''' <returns>True if successful</returns>
        Function ApplyToGuild(joinUser As User, joinGuild As Guild) As Task(Of Boolean)

        ''' <summary><see cref="User"/> is approved for membership with a <see cref="Guild"/>.</summary>
        ''' <param name="approveUser"><see cref="User"/> approved to join the <see cref="Guild"/>.</param>
        ''' <param name="approveGuild"><see cref="Guild"/> being joined</param>
        ''' <returns>True if successful</returns>
        Function ApproveGuildApplication(approveUser As User, approveGuild As Guild) As Task(Of Boolean)

        ''' <summary>Deletes a <see cref="User"/>'s application to a <see cref="Guild"/>.</summary>
        ''' <param name="deleteUser"><see cref="User"/> whose application is deleted</param>
        ''' <param name="deleteGuild"><see cref="Guild"/> from which the <see cref="User"/>'s application was deleted</param>
        ''' <returns>True if successful</returns>
        Function DeleteGuildApplication(deleteUser As User, deleteGuild As Guild) As Task(Of Boolean)

        ''' <summary>Denies a <see cref="User"/>'s application to a <see cref="Guild"/>.</summary>
        ''' <param name="denyUser"><see cref="User"/> whose application is denied</param>
        ''' <param name="denyGuild"><see cref="Guild"/> from which the <see cref="User"/>'s application was denied</param>
        ''' <returns>True if successful</returns>
        Function DenyGuildApplication(denyUser As User, denyGuild As Guild) As Task(Of Boolean)

        ''' <summary>Checks whether the <see cref="User"/> has applied to the selected <see cref="Guild"/>.</summary>
        ''' <param name="checkUser"><see cref="User"/> to check if has applied to the <see cref="Guild"/>.</param>
        ''' <param name="checkGuild"><see cref="Guild"/> being joined</param>
        ''' <returns>True if has applied</returns>
        Function HasAppliedToGuild(checkUser As User, checkGuild As Guild) As Task(Of Boolean)

        ''' <summary>Member of a Guild gains membership with that Guild, applied to database.</summary>
        ''' <param name="joinUser">User joining the Guild.</param>
        ''' <param name="joinGuild">Guild being joined</param>
        ''' <returns>True if successful</returns>
        Function MemberJoinsGuild(joinUser As User, joinGuild As Guild) As Task(Of Boolean)

        ''' <summary>Member of a Guild terminates membership with that Guild, applied to database.</summary>
        ''' <param name="leaveUser">User leaving the Guild.</param>
        ''' <param name="leaveGuild">Guild being left</param>
        ''' <returns>True if successful</returns>
        Function MemberLeavesGuild(leaveUser As User, leaveGuild As Guild) As Task(Of Boolean)

        ''' <summary>Saves a Guild.</summary>
        ''' <param name="guildSave">Guild to be saved</param>
        Function SaveGuild(guildSave As Guild) As Task(Of Boolean)

#End Region

#Region "Jail Management"

        ''' <summary>Frees a <see cref="JailedUser"/> from Jail.</summary>
        ''' <param name="jailUser"><see cref="JailedUser"/> to be freed</param>
        ''' <returns>True if successful</returns>
        Function FreeFromJail(jailUser As JailedUser) As Task(Of Boolean)

        ''' <summary>Sends a <see cref="JailedUser"/> to Jail.</summary>
        ''' <param name="jailUser"><see cref="JailedUser"/> to be jailed</param>
        ''' <returns>True if successful</returns>
        Function SendToJail(jailUser As JailedUser) As Task(Of Boolean)

#End Region

#Region "Load"

        ''' <summary>Loads the Admin password from the database.</summary>
        ''' <returns>Admin password</returns>
        Function LoadAdminPasssword() As Task(Of String)

        ''' <summary>Loads all Armor from the database.</summary>
        ''' <returns>All Armor</returns>
        Function LoadArmor() As Task(Of List(Of Armor))

        ''' <summary>Loads all Drinks from the database.</summary>
        ''' <returns>All Drinks</returns>
        Function LoadDrinks() As Task(Of List(Of Drink))

        ''' <summary>Loads all Enemies from the database.</summary>
        ''' <returns>All Enemies</returns>
        Function LoadEnemies() As Task(Of List(Of Enemy))

        ''' <summary>Loads all Food from the database.</summary>
        ''' <returns>All Food</returns>
        Function LoadFood() As Task(Of List(Of Food))

        ''' <summary>Loads all Guilds from the database.</summary>
        ''' <returns>All Guilds</returns>
        Function LoadGuilds() As Task(Of List(Of Guild))

        ''' <summary>Loads all applicants for a selected <see cref="Guild"/>.</summary>
        ''' <param name="currentGuild"><see cref="Guild"/> whose applicants are to be loaded</param>
        ''' <returns>All applicants for a selected <see cref="Guild"/></returns>
        Function LoadGuildApplicants(currentGuild As Guild) As Task(Of List(Of String))

        ''' <summary>Loads all <see cref="JailedUser"/>s.</summary>
        ''' <returns>All <see cref="JailedUser"/>s</returns>
        Function LoadJailedUsers() As Task(Of List(Of JailedUser))

        ''' <summary>Loads all <see cref="Message"/>s for specified <see cref="User"/>.</summary>
        ''' <param name="loadUser"><see cref="User"/> whose <see cref="Message"/>s are to be loaded</param>
        ''' <returns>List of all <see cref="Message"/>s for the specified <see cref="User"/></returns>
        Function LoadMessages(loadUser As User) As Task(Of List(Of Message))

        ''' <summary>Loads all Potions from the database.</summary>
        ''' <returns>All Potions</returns>
        Function LoadPotions() As Task(Of List(Of Potion))

        ''' <summary>Loads all Ranks from the database.</summary>
        ''' <returns>All Ranks</returns>
        Function LoadRanks() As Task(Of List(Of String))

        ''' <summary>Loads a User from the database.</summary>
        ''' <param name="name">User to be loaded</param>
        ''' <returns>User</returns>
        Function LoadUser(name As String) As Task(Of User)

        ''' <summary>Loads all Users from the database.</summary>
        ''' <returns>All Users</returns>
        Function LoadUsers() As Task(Of List(Of User))

        ''' <summary>Loads all Weapons from the database.</summary>
        ''' <returns>All Weapons</returns>
        Function LoadWeapons() As Task(Of List(Of Weapon))

#End Region

#Region "Message Management"

        ''' <summary>Deletes a <see cref="Message"/> from the database.</summary>
        ''' <param name="message"><see cref="Message"/> to be deleted</param>
        ''' <returns>True if successful</returns>
        Function DeleteMessage(message As Message) As Task(Of Boolean)

        ''' <summary>Sends a <see cref="Message"/> between <see cref="User"/>s.</summary>
        ''' <param name="message"><see cref="Message"/> sent</param>
        ''' <returns>True if successful</returns>
        Function SendMessage(message As Message) As Task(Of Boolean)

#End Region

#Region "User Management"

        ''' <summary>Deletes a <see cref="User"/> from the database.</summary>
        ''' <param name="userDelete"><see cref="User"/> to be deleted.</param>
        ''' <returns>True if successful</returns>
        Function DeleteUser(userDelete As User) As Task(Of Boolean)

        ''' <summary>Adds a User.</summary>
        ''' <param name="userNew">User to be added</param>
        ''' <returns>True if successful</returns>
        Function NewUser(userNew As User) As Task(Of Boolean)

        ''' <summary>Saves a User.</summary>
        ''' <param name="userSave">User to be saved</param>
        ''' <returns>True if successful</returns>
        Function SaveUser(userSave As User) As Task(Of Boolean)

        ''' <summary>Changes an User's name and then saves the User to the database.</summary>
        ''' <param name="userSave">User to be saved</param>
        ''' <param name="newName">New name for User</param>
        ''' <returns>True if successful</returns>
        Function SaveUser(userSave As User, newName As String) As Task(Of Boolean)

#End Region

    End Interface

End Namespace