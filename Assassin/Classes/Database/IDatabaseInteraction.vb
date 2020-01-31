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

#Region "Load"

        ''' <summary>Loads the Admin password from the database.</summary>
        ''' <returns>Admin password</returns>
        Function LoadAdminPasssword() As Task(Of String)

        ''' <summary>Loads all Armor from the database.</summary>
        ''' <returns>All Armor</returns>
        Function LoadArmor() As Task(Of List(Of Armor))

        ''' <summary>Loads all Enemies from the database.</summary>
        ''' <returns>All Enemies</returns>
        Function LoadEnemies() As Task(Of List(Of Enemy))

        ''' <summary>Loads all Guilds from the database.</summary>
        ''' <returns>All Guilds</returns>
        Function LoadGuilds() As Task(Of List(Of Guild))

        ''' <summary>Loads all Food from the database.</summary>
        ''' <returns>All Food</returns>
        Function LoadFood() As Task(Of List(Of Food))

        ''' <summary>Loads all Drinks from the database.</summary>
        ''' <returns>All Drinks</returns>
        Function LoadDrinks() As Task(Of List(Of Drink))

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

#Region "User Management"

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

#Region "Enemy Management"

        ''' <summary>Changes an Enemy's name and then saves the Enemy to the database.</summary>
        ''' <param name="enemySave">Enemy to be saved</param>
        ''' <param name="newName">New name for Enemy</param>
        ''' <returns>True if successful</returns>
        Function SaveEnemy(enemySave As Enemy, newName As String) As Task(Of Boolean)

        ''' <summary>Saves an Enemy to the database.</summary>
        ''' <param name="enemySave">Enemy to be saved</param>
        ''' <returns>True if successful</returns>
        Function SaveEnemy(enemySave As Enemy) As Task(Of Boolean)

#End Region

#Region "Guild Management"

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

    End Interface

End Namespace