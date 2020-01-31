' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Functions.vb
' Description     : This class contains many methods used across multiple forms.

Option Strict On
Option Explicit On

Namespace Classes

    'Public Class Functions
    '    Dim _dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;" 'database provider
    '    Dim _dbSource As String = "Data Source=Assassin.mdb"             'database source
    '    Dim con As New OleDbConnection                                  'database connection
    '    Dim _da As New OleDbDataAdapter                                  'DataAdapter
    '    Dim _databasename As String = "Assassin.sqlite"
    '    Dim _con As String = $"Data Source = {_databasename};Version=3"

    '    Public Function ByteToString(ByVal arrInput() As Byte) As String
    '        '* * * * *
    '        '* This function converts a byte array into a hex string.
    '        '* * * * *

    '        Dim strOutput As New System.Text.StringBuilder(arrInput.Length)

    '        For i As Integer = 0 To arrInput.Length - 1
    '            strOutput.Append(arrInput(i).ToString("X2"))
    '        Next

    '        Return strOutput.ToString().ToLower
    '    End Function

    '    Public Async Function FillDs(ByVal sql As String, ByVal tableName As String) As Task(Of DataSet)
    '        '* * * * *
    '        '* This method handles reading from the database and filling the DataSet
    '        '* * * * *

    '        Return Await SQLite.FillDataSet(sql, _con)
    '    End Function

    '    Public Async Function GetArmor(ByVal armorName As String) As Task(Of Armor)
    '        '* * * * *
    '        '* This method gets the armor of a user based on its name.
    '        '* * * * *

    '        Dim sql As String = "SELECT * FROM Armor WHERE ArmorName='" & armorName & "'"
    '        Dim table As String = "Armor"
    '        Dim ds As DataSet = Await FillDs(sql, table)

    '        Dim currArmor As New Armor                      'create new armor

    '        'save armor information
    '        currArmor.Name = ds.Tables(0).Rows(0).Item("ArmorName").ToString
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("ArmorDefense").ToString, currArmor.Defense)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("ArmorValue").ToString, currArmor.Value)

    '        Return currArmor
    '    End Function

    '    Public Async Function GetEnemy(ByVal CurrentUser As User) As Task(Of Enemy)
    '        '* * * * *
    '        '* This method generates an enemy based on a player's current level.
    '        '* * * * *

    '        Dim enemyNum As Integer = 0
    '        Dim enemy As Integer = Functions.GenerateRandomNumber(1, 100)
    '        Select Case CurrentUser.Level
    '            Case 1, 2
    '                Select Case enemy
    '                    Case 1 To 55        '55%
    '                        enemyNum = 1
    '                    Case 56 To 95       '40%
    '                        enemyNum = 2
    '                    Case 96 To 98       '3%
    '                        enemyNum = 3
    '                    Case 99 To 100       '2%
    '                        enemyNum = 4
    '                End Select
    '            Case 3, 4
    '                Select Case enemy
    '                    Case 1 To 12        '12%
    '                        enemyNum = 1
    '                    Case 13 To 24       '12%
    '                        enemyNum = 2
    '                    Case 25 To 50       '26%
    '                        enemyNum = 3
    '                    Case 51 To 76       '26%
    '                        enemyNum = 4
    '                    Case 77 To 88       '12%
    '                        enemyNum = 5
    '                    Case 89 To 100      '12%
    '                        enemyNum = 6
    '                End Select
    '            Case 5, 6
    '                Select Case enemy
    '                    Case 1 To 6         '6%
    '                        enemyNum = 1
    '                    Case 7 To 12        '6%
    '                        enemyNum = 2
    '                    Case 13 To 24       '12%
    '                        enemyNum = 3
    '                    Case 25 To 36       '12%
    '                        enemyNum = 4
    '                    Case 37 To 50       '14%
    '                        enemyNum = 5
    '                    Case 51 To 64       '14%
    '                        enemyNum = 6
    '                    Case 65 To 76       '12%
    '                        enemyNum = 7
    '                    Case 77 To 88       '12%
    '                        enemyNum = 8
    '                    Case 89 To 94       '6%
    '                        enemyNum = 9
    '                    Case 95 To 100      '6%
    '                        enemyNum = 10
    '                End Select
    '            Case 7, 8
    '                Select Case enemy
    '                    Case 1 To 4         '4%
    '                        enemyNum = 1
    '                    Case 5 To 8         '4%
    '                        enemyNum = 2
    '                    Case 9 To 16        '8%
    '                        enemyNum = 3
    '                    Case 17 To 24       '8%
    '                        enemyNum = 4
    '                    Case 25 To 36       '12%
    '                        enemyNum = 5
    '                    Case 37 To 48       '12%
    '                        enemyNum = 6
    '                    Case 49 To 64       '16%
    '                        enemyNum = 7
    '                    Case 65 To 80       '16%
    '                        enemyNum = 8
    '                    Case 81 To 90       '10%
    '                        enemyNum = 9
    '                    Case 91 To 100      '10%
    '                        enemyNum = 10
    '                End Select
    '            Case 9, 10
    '                Select Case enemy
    '                    Case 1 To 4         '4%
    '                        enemyNum = 1
    '                    Case 5 To 8         '4%
    '                        enemyNum = 2
    '                    Case 9 To 14        '6%
    '                        enemyNum = 3
    '                    Case 15 To 20       '6%
    '                        enemyNum = 4
    '                    Case 21 To 30       '10%
    '                        enemyNum = 5
    '                    Case 31 To 40       '10%
    '                        enemyNum = 6
    '                    Case 41 To 52       '12%
    '                        enemyNum = 7
    '                    Case 53 To 64       '12%
    '                        enemyNum = 8
    '                    Case 65 To 82       '18%
    '                        enemyNum = 9
    '                    Case 83 To 100      '18%
    '                        enemyNum = 10
    '                End Select
    '            Case 11
    '                Select Case enemy
    '                    Case 1 To 4         '4%
    '                        enemyNum = 1
    '                    Case 4 To 8         '4%
    '                        enemyNum = 2
    '                    Case 9 To 12        '4%
    '                        enemyNum = 3
    '                    Case 13 To 16       '4%
    '                        enemyNum = 4
    '                    Case 17 To 24       '8%
    '                        enemyNum = 5
    '                    Case 25 To 32       '8%
    '                        enemyNum = 6
    '                    Case 33 To 44       '12%
    '                        enemyNum = 7
    '                    Case 45 To 56       '12%
    '                        enemyNum = 8
    '                    Case 57 To 78       '22%
    '                        enemyNum = 9
    '                    Case 79 To 100      '22%
    '                        enemyNum = 10
    '                End Select
    '        End Select

    '        Dim sql As String = "SELECT * FROM Enemies WHERE Level=" & (enemyNum)
    '        Dim table As String = "Enemy"
    '        Dim ds As DataSet = Await FillDs(sql, table)
    '        Dim currEnemy As New Enemy

    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("Level").ToString, currEnemy.Level)
    '        currEnemy.Name = ds.Tables(0).Rows(0).Item("EnemyName").ToString

    '        Dim maxEnd As Integer
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("Endurance").ToString, maxEnd)
    '        currEnemy.MaximumEndurance = Functions.GenerateRandomNumber((maxEnd \ 5) * 4, maxEnd)
    '        currEnemy.CurrentEndurance = currEnemy.MaximumEndurance

    '        currEnemy.Weapon = Await getWeapon(ds.Tables(0).Rows(0).Item("Weapon").ToString)
    '        currEnemy.Armor = Await GetArmor(ds.Tables(0).Rows(0).Item("Armor").ToString)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("Attack").ToString, currEnemy.AttackSkill)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("Blocking").ToString, currEnemy.Blocking)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("Slipping").ToString, currEnemy.Slipping)

    '        Return currEnemy
    '    End Function

    '    Public Async Function GetGuild(ByVal guildNum As Integer) As Task(Of Guild)
    '        Dim sql As String = "SELECT * FROM Guilds WHERE ID=" & guildNum
    '        Dim table As String = "Guilds"
    '        Dim ds As DataSet = Await FillDs(sql, table)
    '        Dim newGuild As New Guild

    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("ID").ToString, newGuild.ID)
    '        newGuild.Name = ds.Tables(0).Rows(0).Item("GuildName").ToString
    '        newGuild.Master = ds.Tables(0).Rows(0).Item("Guildmaster").ToString
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("GuildFee").ToString, newGuild.Fee)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("GuildGold").ToString, newGuild.Gold)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("HenchmenLevel1").ToString, newGuild.HenchmenLevel1)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("HenchmenLevel2").ToString, newGuild.HenchmenLevel2)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("HenchmenLevel3").ToString, newGuild.HenchmenLevel3)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("HenchmenLevel4").ToString, newGuild.HenchmenLevel4)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("HenchmenLevel5").ToString, newGuild.HenchmenLevel5)

    '        Return newGuild
    '    End Function

    '    Public Function GetHunger(ByVal hunger As Integer) As String
    '        '* * * * *
    '        '* This method gets the hunger of a user and returns it as a String.
    '        '* * * * *

    '        Select Case hunger
    '            Case 0 To 4
    '                Return "Full"
    '            Case 5 To 9
    '                Return "Hungry"
    '            Case 10 To 14
    '                Return "Very Hungry"
    '            Case 14 To 19
    '                Return "Famished"
    '            Case 20 To 24
    '                Return "Starving"
    '            Case Else
    '                Return "BROKEN"
    '        End Select
    '    End Function

    '    Public Async Function GetRank(ByVal CurrentUser As User) As Task(Of String)
    '        '* * * * *
    '        '* This method gets the rank of a user and returns it as a String.
    '        '* * * * *

    '        Dim sql As String = "SELECT * FROM Ranks WHERE Rank=" & CurrentUser.Level & ""
    '        Dim table As String = "Ranks"
    '        Dim ds As DataSet

    '        ds = Await FillDs(sql, table)
    '        Return ds.Tables(0).Rows(0).Item("RankName").ToString
    '    End Function

    '    Public Function GetThirst(ByVal thirst As Integer) As String
    '        '* * * * *
    '        '* This method gets the thirst of a user and returns it as a String.
    '        '* * * * *

    '        Select Case thirst
    '            Case 0 To 4
    '                Return "Quenched"
    '            Case 5 To 9
    '                Return "Thirsty"
    '            Case 10 To 14
    '                Return "Very Thirsty"
    '            Case 14 To 19
    '                Return "Parched"
    '            Case 20 To 24
    '                Return "Dehydrated"
    '            Case Else
    '                Return "BROKEN"
    '        End Select
    '    End Function

    '    Public Async Function getWeapon(ByVal weaponName As String) As Task(Of Weapon)
    '        '* * * * *
    '        '* This method gets the weapon of a user based on its name.
    '        '* * * * *

    '        Dim sql As String = "SELECT * FROM Weapons WHERE WeaponName='" & weaponName & "'"
    '        Dim table As String = "Weapon"
    '        Dim ds As DataSet = Await FillDs(sql, table)

    '        Dim currWeapon As New Weapon                    'create new weapon

    '        'save weapon information
    '        currWeapon.Name = ds.Tables(0).Rows(0).Item("WeaponName").ToString
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("WeaponDamage").ToString, currWeapon.Damage)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("WeaponValue").ToString, currWeapon.Value)
    '        Dim type As WeaponType
    '        [Enum].TryParse(ds.Tables(0).Rows(0).Item("WeaponType").ToString, type)
    '        currWeapon.Type = type

    '        Return currWeapon
    '    End Function

    '    Public Async Function getWeapon(ByVal weaponName As String, ByVal weaponType As String) As Task(Of Weapon)
    '        '* * * * *
    '        '* This method gets the weapon of a user based on its name.
    '        '* * * * *

    '        Dim sql As String = "SELECT * FROM Weapons WHERE WeaponName='" & weaponName & "' AND WeaponType='" & weaponType & "'"
    '        Dim table As String = "Weapon"
    '        Dim ds As DataSet = Await FillDs(sql, table)

    '        Dim currWeapon As New Weapon                    'create new weapon

    '        'save weapon information
    '        currWeapon.Name = ds.Tables(0).Rows(0).Item("WeaponName").ToString
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("WeaponDamage").ToString, currWeapon.Damage)
    '        Integer.TryParse(ds.Tables(0).Rows(0).Item("WeaponValue").ToString, currWeapon.Value)
    '        Dim type As WeaponType
    '        [Enum].TryParse(ds.Tables(0).Rows(0).Item("WeaponType").ToString, type)
    '        currWeapon.Type = type

    '        Return currWeapon
    '    End Function

    '    Public Function Md5Hash(ByVal strPass As String) As String
    '        Return Extensions.Encryption.MD5.HashMD5(strPass)
    '    End Function

    '    Public Function Functions.GenerateRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
    '        Return Extensions.Functions.GenerateRandomNumber(min, max)
    '    End Function

    '    'Public Sub adminPass(ByVal newPass As String)

    '    '    Dim ds As New DataSet
    '    '    Dim sql As String = "SELECT * FROM Admin"
    '    '    Dim table As String = "Admin"
    '    '    ds = fillDS(sql, table)

    '    '    ds.Tables(0).Rows(0).Item("AdminPassword") = newPass
    '    '    updateRecord(sql, table, ds)
    '    'End Sub

    '    Public Sub DeleteRecord(ByVal sql As String, ByVal tableName As String, ByVal ds As DataSet)
    '        '* * * * *
    '        '* This method handles reading from the database and filling the DataSet
    '        '* * * * *

    '        Try
    '            con.ConnectionString = _dbProvider & _dbSource    'set connection type and location of database
    '            _da = New OleDbDataAdapter(sql, con)             'establish connection
    '            Dim cb As New OleDb.OleDbCommandBuilder(_da)     'create a way to commit changes to the database
    '            ds.Tables(tableName).Rows(0).Delete()               'delete row
    '            _da.Update(ds, tableName)                            'update database
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Assassin", MessageBoxButtons.OK)
    '        Finally
    '            con.Close()     'close connection
    '        End Try
    '    End Sub

    '    Public Async Sub JoinGuild(ByVal username As String, ByVal guildNum As Integer)
    '        '* * * * *
    '        '* This method allows a player to join a guild.
    '        '* * * * *

    '        Dim sql As String = "SELECT * FROM Guild" & guildNum & "Members WHERE Username='" & username & "'"
    '        Dim table As String = "Members"
    '        Dim ds As New DataSet

    '        ds = Await FillDs(sql, table)

    '        Dim dsNewRow As DataRow
    '        dsNewRow = ds.Tables(0).NewRow()    'create new row
    '        dsNewRow.Item("Username") = username        'add username to members

    '        ds.Tables(0).Rows.Add(dsNewRow)     'add new row to table

    '        UpdateRecord(sql, table, ds)
    '    End Sub

    '    ''' <summary>Adds a new user to the database.</summary>
    '    ''' <param name="newUser">User to be added</param>
    '    Public Async Sub NewUser(ByVal newUser As User)
    '        Dim ds As New DataSet
    '        Dim da As New OleDbDataAdapter
    '        Dim sql As String = "SELECT * FROM Users WHERE Username='" & newUser.Name & "'"
    '        Dim table As String = "User"
    '        ds = Await FillDs(sql, table)

    '        Dim dsNewRow As DataRow
    '        dsNewRow = ds.Tables(table).NewRow()                  'create new row

    '        'character
    '        dsNewRow.Item("Username") = newUser.Name
    '        dsNewRow.Item("UserPassword") = newUser.Password
    '        dsNewRow.Item("Level") = newUser.Level
    '        dsNewRow.Item("Experience") = newUser.Experience
    '        dsNewRow.Item("SkillPoints") = newUser.SkillPoints
    '        dsNewRow.Item("Alive") = newUser.Alive
    '        dsNewRow.Item("CurrentEndurance") = newUser.CurrentEndurance
    '        dsNewRow.Item("Location") = newUser.CurrentLocation
    '        dsNewRow.Item("MaximumEndurance") = newUser.MaximumEndurance
    '        dsNewRow.Item("Hunger") = newUser.Hunger
    '        dsNewRow.Item("Thirst") = newUser.Thirst

    '        'inventory
    '        dsNewRow.Item("CurrentWeapon") = newUser.CurrentWeapon
    '        dsNewRow.Item("LightWeapon") = newUser.LightWeapon.Name
    '        dsNewRow.Item("HeavyWeapon") = newUser.HeavyWeapon.Name
    '        dsNewRow.Item("TwoHandedWeapon") = newUser.TwoHandedWeapon.Name
    '        dsNewRow.Item("Armor") = newUser.Armor.Name
    '        dsNewRow.Item("Potion") = newUser.Potion
    '        dsNewRow.Item("Lockpicks") = newUser.Lockpicks
    '        dsNewRow.Item("GoldOnHand") = newUser.GoldOnHand
    '        dsNewRow.Item("GoldInBank") = newUser.GoldInBank
    '        dsNewRow.Item("GoldOnLoan") = newUser.GoldOnLoan
    '        dsNewRow.Item("Shovel") = newUser.Shovel
    '        dsNewRow.Item("Lantern") = newUser.Lantern
    '        dsNewRow.Item("Amulet") = newUser.Amulet

    '        'skills
    '        dsNewRow.Item("LightWeaponSkill") = newUser.LightWeaponSkill
    '        dsNewRow.Item("HeavyWeaponSkill") = newUser.HeavyWeaponSkill
    '        dsNewRow.Item("TwoHandedWeaponSkill") = newUser.TwoHandedWeaponSkill
    '        dsNewRow.Item("Blocking") = newUser.Blocking
    '        dsNewRow.Item("Slipping") = newUser.Slipping
    '        dsNewRow.Item("Stealth") = newUser.Stealth

    '        'henchmen
    '        dsNewRow.Item("HenchmenLevel1") = newUser.HenchmenLevel1
    '        dsNewRow.Item("HenchmenLevel2") = newUser.HenchmenLevel2
    '        dsNewRow.Item("HenchmenLevel3") = newUser.HenchmenLevel3
    '        dsNewRow.Item("HenchmenLevel4") = newUser.HenchmenLevel4
    '        dsNewRow.Item("HenchmenLevel5") = newUser.HenchmenLevel5

    '        Dim dbProvider As String = "Provider=Microsoft.ACE.oledb.12.0;" 'database provider
    '        Dim dbSource As String = "Data Source=Assassin.mdb"             'database source
    '        Dim con As New OleDbConnection                                  'database connection

    '        Try
    '            con.ConnectionString = dbProvider & dbSource                'set connection type and location of database
    '            da = New OleDbDataAdapter(sql, con)                         'establish connection

    '            Dim cb As New OleDb.OleDbCommandBuilder(da)

    '            ds.Tables(table).Rows.Add(dsNewRow)                         'add new row to Dataset
    '            da.Update(ds, table)                                        'update database
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Assassin", MessageBoxButtons.OK)
    '            Exit Sub
    '        Finally
    '            con.Close()
    '        End Try
    '    End Sub

    '    Public Async Sub Save(ByVal saveUser As User)
    '        Dim success As Boolean = False
    '        Dim cmd As New SQLiteCommand With {.CommandText = "UPDATE Users SET [Level] = @level, [Experience] = @experience, [SkillPoints] = @skillPoints, [Alive] = @alive, [Location] = location, [CurrentEndurance] = @currentEndurance, [MaximumEndurance] = @maximumEndurance, [Hunger] = @hunger, [Thirst] = @thirst, [CurrentWeapon] = @currentWeapon, [LightWeapon] = @lightWeapon, [HeavyWeapon] = @heavyWeapon, [TwoHandedWeapon] = @twoHandedWeapon, [Armor] = @armor, [Potion] = @potion, [Lockpicks] = @lockpicks, [GoldOnHand] = @goldOnHand, [GoldInBank] = @goldInBank, [GoldOnLoan] = @goldOnLoan, [Shovel] = @shovel, [Lantern] = @lantern, [Amulet] = @amulet, [LightWeaponSkill] = @lightWeaponSkill, [HeavyWeaponSkill] = @heavyWeaponSkill, [TwoHandedWeaponSkill] = @twoHandedWeaponSkill, [Blocking] = @blocking, [Slipping] = @slipping, [Stealth] = @stealth, [HenchmenLevel1] = @henchmenLevel1, [HenchmenLevel2] = @henchmenLevel2, [HenchmenLevel3] = @henchmenLevel3, [HenchmenLevel4] = @henchmenLevel4, [HenchmenLevel5] = @henchmenLevel5 WHERE [Username] = @name"}

    '        cmd.Parameters.AddWithValue("@level", saveUser.Level)
    '        cmd.Parameters.AddWithValue("@experience", saveUser.Experience.ToString())
    '        cmd.Parameters.AddWithValue("@skillPoints", saveUser.SkillPoints.ToString())
    '        cmd.Parameters.AddWithValue("@alive", Int32Helper.Parse(saveUser.Alive))
    '        cmd.Parameters.AddWithValue("@location", saveUser.CurrentLocation)
    '        cmd.Parameters.AddWithValue("@currentEndurance", saveUser.CurrentEndurance.ToString())
    '        cmd.Parameters.AddWithValue("@maximumEndurance", saveUser.MaximumEndurance.ToString())
    '        cmd.Parameters.AddWithValue("@hunger", saveUser.Hunger.ToString())
    '        cmd.Parameters.AddWithValue("@thirst", saveUser.Thirst.ToString())
    '        cmd.Parameters.AddWithValue("@currentWeapon", saveUser.CurrentWeapon)
    '        cmd.Parameters.AddWithValue("@lightWeapon", saveUser.LightWeapon.Name)
    '        cmd.Parameters.AddWithValue("@heavyWeapon", saveUser.HeavyWeapon.Name)
    '        cmd.Parameters.AddWithValue("@twoHandedWeapon", saveUser.TwoHandedWeapon.Name)
    '        cmd.Parameters.AddWithValue("@armor", saveUser.Armor.Name)
    '        cmd.Parameters.AddWithValue("@potion", saveUser.Potion)
    '        cmd.Parameters.AddWithValue("@lockpicks", saveUser.Lockpicks.ToString())
    '        cmd.Parameters.AddWithValue("@goldOnHand", saveUser.GoldOnHand.ToString())
    '        cmd.Parameters.AddWithValue("@goldInBank", saveUser.GoldInBank.ToString())
    '        cmd.Parameters.AddWithValue("@goldOnLoan", saveUser.GoldOnLoan.ToString())
    '        cmd.Parameters.AddWithValue("@shovel", Int32Helper.Parse(saveUser.Shovel))
    '        cmd.Parameters.AddWithValue("@lantern", Int32Helper.Parse(saveUser.Lantern))
    '        cmd.Parameters.AddWithValue("@amulet", Int32Helper.Parse(saveUser.Amulet))
    '        cmd.Parameters.AddWithValue("@lightWeaponSkill", saveUser.LightWeaponSkill.ToString())
    '        cmd.Parameters.AddWithValue("@heavyWeaponSkill", saveUser.HeavyWeaponSkill.ToString())
    '        cmd.Parameters.AddWithValue("@twoHandedWeaponSkill", saveUser.TwoHandedWeaponSkill.ToString())
    '        cmd.Parameters.AddWithValue("@blocking", saveUser.Blocking.ToString())
    '        cmd.Parameters.AddWithValue("@slipping", saveUser.Slipping.ToString())
    '        cmd.Parameters.AddWithValue("@stealth", saveUser.Stealth.ToString())
    '        cmd.Parameters.AddWithValue("@henchmenLevel1", saveUser.HenchmenLevel1.ToString())
    '        cmd.Parameters.AddWithValue("@henchmenLevel2", saveUser.HenchmenLevel2.ToString())
    '        cmd.Parameters.AddWithValue("@henchmenLevel3", saveUser.HenchmenLevel3.ToString())
    '        cmd.Parameters.AddWithValue("@henchmenLevel4", saveUser.HenchmenLevel4.ToString())
    '        cmd.Parameters.AddWithValue("@henchmenLevel5", saveUser.HenchmenLevel5.ToString())
    '        cmd.Parameters.AddWithValue("@name", saveUser.Name)

    '        Await SQLite.ExecuteCommand(_con, cmd)
    '    End Sub

    '    Public Async Sub save(ByVal CurrentUser As User, ByVal oldName As String)
    '        '* * * * *
    '        '* This method saves the user, specifically from the admin form when changing names.
    '        '* * * * *

    '        Dim ds As New DataSet
    '        Dim sql As String = "SELECT * FROM Users WHERE Username='" & oldName & "'"
    '        Dim table As String = "User"
    '        ds = Await FillDs(sql, table)

    '        'character
    '        ds.Tables(0).Rows(0).Item("Username") = CurrentUser.Name
    '        ds.Tables(0).Rows(0).Item("UserPassword") = CurrentUser.Password
    '        ds.Tables(0).Rows(0).Item("Level") = CurrentUser.Level
    '        ds.Tables(0).Rows(0).Item("Experience") = CurrentUser.Experience
    '        ds.Tables(0).Rows(0).Item("SkillPoints") = CurrentUser.SkillPoints
    '        ds.Tables(0).Rows(0).Item("Alive") = CurrentUser.Alive
    '        ds.Tables(0).Rows(0).Item("CurrentEndurance") = CurrentUser.CurrentEndurance
    '        ds.Tables(0).Rows(0).Item("Location") = CurrentUser.CurrentLocation
    '        ds.Tables(0).Rows(0).Item("MaximumEndurance") = CurrentUser.MaximumEndurance
    '        ds.Tables(0).Rows(0).Item("Hunger") = CurrentUser.Hunger
    '        ds.Tables(0).Rows(0).Item("Thirst") = CurrentUser.Thirst

    '        'inventory
    '        ds.Tables(0).Rows(0).Item("CurrentWeapon") = CurrentUser.CurrentWeapon
    '        ds.Tables(0).Rows(0).Item("LightWeapon") = CurrentUser.LightWeapon.Name
    '        ds.Tables(0).Rows(0).Item("HeavyWeapon") = CurrentUser.HeavyWeapon.Name
    '        ds.Tables(0).Rows(0).Item("TwoHandedWeapon") = CurrentUser.TwoHandedWeapon.Name
    '        ds.Tables(0).Rows(0).Item("Armor") = CurrentUser.Armor.Name
    '        ds.Tables(0).Rows(0).Item("Potion") = CurrentUser.Potion
    '        ds.Tables(0).Rows(0).Item("Lockpicks") = CurrentUser.Lockpicks
    '        ds.Tables(0).Rows(0).Item("GoldOnHand") = CurrentUser.GoldOnHand
    '        ds.Tables(0).Rows(0).Item("GoldInBank") = CurrentUser.GoldInBank
    '        ds.Tables(0).Rows(0).Item("GoldOnLoan") = CurrentUser.GoldOnLoan
    '        ds.Tables(0).Rows(0).Item("Shovel") = CurrentUser.Shovel
    '        ds.Tables(0).Rows(0).Item("Lantern") = CurrentUser.Lantern
    '        ds.Tables(0).Rows(0).Item("Amulet") = CurrentUser.Amulet

    '        'skills
    '        ds.Tables(0).Rows(0).Item("LightWeaponSkill") = CurrentUser.LightWeaponSkill
    '        ds.Tables(0).Rows(0).Item("HeavyWeaponSkill") = CurrentUser.HeavyWeaponSkill
    '        ds.Tables(0).Rows(0).Item("TwoHandedWeaponSkill") = CurrentUser.TwoHandedWeaponSkill
    '        ds.Tables(0).Rows(0).Item("Blocking") = CurrentUser.Blocking
    '        ds.Tables(0).Rows(0).Item("Slipping") = CurrentUser.Slipping
    '        ds.Tables(0).Rows(0).Item("Stealth") = CurrentUser.Stealth

    '        'henchmen
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel1") = CurrentUser.HenchmenLevel1
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel2") = CurrentUser.HenchmenLevel2
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel3") = CurrentUser.HenchmenLevel3
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel4") = CurrentUser.HenchmenLevel4
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel5") = CurrentUser.HenchmenLevel5

    '        UpdateRecord(sql, table, ds)
    '    End Sub

    '    Public Async Sub SaveGuild(ByVal currGuild As Guild)
    '        Dim sql As String = "SELECT * FROM Guilds WHERE ID=" & currGuild.ID
    '        Dim table As String = "Guilds"
    '        Dim ds As DataSet = Await FillDs(sql, table)

    '        ds.Tables(0).Rows(0).Item("ID") = currGuild.ID
    '        ds.Tables(0).Rows(0).Item("GuildName") = currGuild.Name
    '        ds.Tables(0).Rows(0).Item("Guildmaster") = currGuild.Master
    '        ds.Tables(0).Rows(0).Item("GuildFee") = currGuild.Fee
    '        ds.Tables(0).Rows(0).Item("GuildGold") = currGuild.Gold
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel1") = currGuild.HenchmenLevel1
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel2") = currGuild.HenchmenLevel2
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel3") = currGuild.HenchmenLevel3
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel4") = currGuild.HenchmenLevel4
    '        ds.Tables(0).Rows(0).Item("HenchmenLevel5") = currGuild.HenchmenLevel5

    '        UpdateRecord(sql, table, ds)
    '    End Sub

    '    Public Sub UpdateRecord(ByVal sql As String, ByVal tableName As String, ByVal ds As DataSet)
    '        '* * * * *
    '        '* This method updates a record in the database
    '        '* * * * *

    '        Try
    '            con.ConnectionString = _dbProvider & _dbSource                'set connection type and location of database
    '            _da = New OleDbDataAdapter(sql, con)                         'establish connection

    '            Dim cb As New OleDb.OleDbCommandBuilder(_da)
    '            _da.Update(ds, tableName)
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Assassin", MessageBoxButtons.OK)
    '            Exit Sub
    '        Finally
    '            con.Close()
    '        End Try
    '    End Sub

    'End Class

End Namespace