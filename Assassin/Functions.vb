' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Functions.vb
' Description     : This class contains many methods used across multiple forms.

Option Strict On
Option Explicit On
Imports System.Data.OleDb

Public Class Functions
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;" 'database provider
    Dim dbSource As String = "Data Source=Assassin.mdb"             'database source
    Dim con As New OleDbConnection                                  'database connection
    Dim da As New OleDbDataAdapter                                  'DataAdapter

    Public Function ByteToString(ByVal arrInput() As Byte) As String
        '* * * * *
        '* This function converts a byte array into a hex string.
        '* * * * *

        Dim strOutput As New System.Text.StringBuilder(arrInput.Length)

        For i As Integer = 0 To arrInput.Length - 1
            strOutput.Append(arrInput(i).ToString("X2"))
        Next

        Return strOutput.ToString().ToLower
    End Function

    Public Function fillDS(ByVal sql As String, ByVal tableName As String) As DataSet
        '* * * * *
        '* This method handles reading from the database and filling the DataSet
        '* * * * *

        Dim dbProvider As String = "Provider=Microsoft.ACE.oledb.12.0;" 'database provider
        Dim dbSource As String = "Data Source=Assassin.mdb"             'database source
        Dim con As New OleDbConnection                                  'database connection
        Dim da As New OleDbDataAdapter                                  'DataAdapter
        Dim ds As New DataSet

        Try
            con.ConnectionString = dbProvider & dbSource    'set connection type and location of database
            da = New OleDbDataAdapter(sql, con)             'establish connection
            da.Fill(ds, tableName)                              'fill table
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Assassin", MessageBoxButtons.OK)
        Finally
            con.Close()     'close connection
        End Try

        Return ds
    End Function

    Public Function getArmor(ByVal armorName As String) As Armor
        '* * * * *
        '* This method gets the armor of a user based on its name.
        '* * * * *

        Dim sql As String = "SELECT * FROM Armor WHERE ArmorName='" & armorName & "'"
        Dim table As String = "Armor"
        Dim ds As DataSet = fillDS(sql, table)

        Dim currArmor As New Armor                      'create new armor

        'save armor information
        currArmor.name = ds.Tables("Armor").Rows(0).Item("ArmorName").ToString
        Integer.TryParse(ds.Tables("Armor").Rows(0).Item("ArmorDefense").ToString, currArmor.defense)
        Integer.TryParse(ds.Tables("Armor").Rows(0).Item("ArmorValue").ToString, currArmor.value)

        Return currArmor
    End Function

    Public Function getEnemy(ByVal currUser As User) As Enemy
        '* * * * *
        '* This method generates an enemy based on a player's current level.
        '* * * * *

        Dim enemyNum As Integer = 0
        Dim enemy As Integer = random(1, 100)
        Select Case currUser.level
            Case 1, 2
                Select Case enemy
                    Case 1 To 55        '55%
                        enemyNum = 1
                    Case 56 To 95       '40%
                        enemyNum = 2
                    Case 96 To 98       '3%
                        enemyNum = 3
                    Case 99 To 100       '2%
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

        Dim sql As String = "SELECT * FROM Enemies WHERE Level=" & (enemyNum)
        Dim table As String = "Enemy"
        Dim ds As DataSet = fillDS(sql, table)
        Dim currEnemy As New Enemy

        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Level").ToString, currEnemy.level)
        currEnemy.name = ds.Tables("Enemy").Rows(0).Item("EnemyName").ToString

        Dim maxEnd As Integer
        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Endurance").ToString, maxEnd)
        currEnemy.maxEnd = random((maxEnd \ 5) * 4, maxEnd)
        currEnemy.currEnd = currEnemy.maxEnd

        currEnemy.weapon = getWeapon(ds.Tables("Enemy").Rows(0).Item("Weapon").ToString)
        currEnemy.armor = getArmor(ds.Tables("Enemy").Rows(0).Item("Armor").ToString)
        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Attack").ToString, currEnemy.attackSkill)
        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Blocking").ToString, currEnemy.blocking)
        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Slipping").ToString, currEnemy.slipping)

        Return currEnemy
    End Function

    Public Function getGuild(ByVal guildNum As Integer) As Guild
        Dim sql As String = "SELECT * FROM Guilds WHERE ID=" & guildNum
        Dim table As String = "Guilds"
        Dim ds As DataSet = fillDS(sql, table)
        Dim newGuild As New Guild

        Integer.TryParse(ds.Tables("Guilds").Rows(0).Item("ID").ToString, newGuild.id)
        newGuild.name = ds.Tables("Guilds").Rows(0).Item("GuildName").ToString
        newGuild.master = ds.Tables("Guilds").Rows(0).Item("Guildmaster").ToString
        Integer.TryParse(ds.Tables("Guilds").Rows(0).Item("GuildFee").ToString, newGuild.fee)
        Integer.TryParse(ds.Tables("Guilds").Rows(0).Item("GuildGold").ToString, newGuild.gold)
        Integer.TryParse(ds.Tables("Guilds").Rows(0).Item("Henchmen1").ToString, newGuild.hench1)
        Integer.TryParse(ds.Tables("Guilds").Rows(0).Item("Henchmen2").ToString, newGuild.hench2)
        Integer.TryParse(ds.Tables("Guilds").Rows(0).Item("Henchmen3").ToString, newGuild.hench3)
        Integer.TryParse(ds.Tables("Guilds").Rows(0).Item("Henchmen4").ToString, newGuild.hench4)
        Integer.TryParse(ds.Tables("Guilds").Rows(0).Item("Henchmen5").ToString, newGuild.hench5)

        Return newGuild
    End Function

    Public Function getHunger(ByVal hunger As Integer) As String
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

    Public Function getRank(ByVal currUser As User) As String
        '* * * * *
        '* This method gets the rank of a user and returns it as a String.
        '* * * * *

        Dim sql As String = "SELECT * FROM Ranks WHERE Rank=" & currUser.level & ""
        Dim table As String = "Ranks"
        Dim ds As DataSet

        ds = fillDS(sql, table)
        Return ds.Tables("Ranks").Rows(0).Item("RankName").ToString
    End Function

    Public Function getThirst(ByVal thirst As Integer) As String
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

    Public Function getWeapon(ByVal weaponName As String) As Weapon
        '* * * * *
        '* This method gets the weapon of a user based on its name.
        '* * * * *

        Dim sql As String = "SELECT * FROM Weapons WHERE WeaponName='" & weaponName & "'"
        Dim table As String = "Weapon"
        Dim ds As DataSet = fillDS(sql, table)

        Dim currWeapon As New Weapon                    'create new weapon

        'save weapon information
        currWeapon.name = ds.Tables("Weapon").Rows(0).Item("WeaponName").ToString
        Integer.TryParse(ds.Tables("Weapon").Rows(0).Item("WeaponDamage").ToString, currWeapon.damage)
        Integer.TryParse(ds.Tables("Weapon").Rows(0).Item("WeaponValue").ToString, currWeapon.value)
        currWeapon.type = ds.Tables("Weapon").Rows(0).Item("WeaponType").ToString

        Return currWeapon
    End Function

    Public Function getWeapon(ByVal weaponName As String, ByVal weaponType As String) As Weapon
        '* * * * *
        '* This method gets the weapon of a user based on its name.
        '* * * * *

        Dim sql As String = "SELECT * FROM Weapons WHERE WeaponName='" & weaponName & "' AND WeaponType='" & weaponType & "'"
        Dim table As String = "Weapon"
        Dim ds As DataSet = fillDS(sql, table)

        Dim currWeapon As New Weapon                    'create new weapon

        'save weapon information
        currWeapon.name = ds.Tables("Weapon").Rows(0).Item("WeaponName").ToString
        Integer.TryParse(ds.Tables("Weapon").Rows(0).Item("WeaponDamage").ToString, currWeapon.damage)
        Integer.TryParse(ds.Tables("Weapon").Rows(0).Item("WeaponValue").ToString, currWeapon.value)
        currWeapon.type = ds.Tables("Weapon").Rows(0).Item("WeaponType").ToString

        Return currWeapon
    End Function

    Public Function MD5Hash(ByVal strPass As String) As String
        '* * * * *
        '* Encrypts a password using MD5 hash.
        '* * * * *

        Dim objMD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim arrData(), arrHash() As Byte

        arrData = System.Text.Encoding.UTF8.GetBytes(strPass)   'convert the string to bytes using UTF8
        arrHash = objMD5.ComputeHash(arrData)                   'hash contents of the byte array
        objMD5 = Nothing                                        'why do I do this?

        Return ByteToString(arrHash)                              'return formatted hash
    End Function

    Public Function random(ByVal min As Integer, ByVal max As Integer) As Integer
        '* * * * *
        '* This method randomly generates a number based on variables.
        '* * * * *

        Threading.Thread.Sleep(1)                               'sleep so random number won't be the same
        Dim randomGen As New Random(Now.Millisecond)            'create random generator
        Dim result As Integer = randomGen.Next(min, max + 1)    'assign result of generator to variable
        Threading.Thread.Sleep(1)                               'sleep so random number won't be the same
        Return result
    End Function

    'Public Sub adminPass(ByVal newPass As String)

    '    Dim ds As New DataSet
    '    Dim sql As String = "SELECT * FROM Admin"
    '    Dim table As String = "Admin"
    '    ds = fillDS(sql, table)

    '    ds.Tables("Admin").Rows(0).Item("AdminPassword") = newPass
    '    updateRecord(sql, table, ds)
    'End Sub

    Public Sub deleteRecord(ByVal sql As String, ByVal tableName As String, ByVal ds As DataSet)
        '* * * * *
        '* This method handles reading from the database and filling the DataSet
        '* * * * *

        Try
            con.ConnectionString = dbProvider & dbSource    'set connection type and location of database
            da = New OleDbDataAdapter(sql, con)             'establish connection
            Dim cb As New OleDb.OleDbCommandBuilder(da)     'create a way to commit changes to the database
            ds.Tables(tableName).Rows(0).Delete()               'delete row
            da.Update(ds, tableName)                            'update database
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Assassin", MessageBoxButtons.OK)
        Finally
            con.Close()     'close connection
        End Try
    End Sub

    Public Sub joinGuild(ByVal username As String, ByVal guildNum As Integer)
        '* * * * *
        '* This method allows a player to join a guild.
        '* * * * *

        Dim sql As String = "SELECT * FROM Guild" & guildNum & "Members WHERE Username='" & username & "'"
        Dim table As String = "Members"
        Dim ds As New DataSet

        ds = fillDS(sql, table)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables("Members").NewRow()    'create new row
        dsNewRow.Item("Username") = username        'add username to members

        ds.Tables("Members").Rows.Add(dsNewRow)     'add new row to table

        updateRecord(sql, table, ds)
    End Sub

    Public Sub newUser(ByVal newUser As User)
        '* * * * *
        '* This method saves the user.
        '* * * * *

        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Dim sql As String = "SELECT * FROM Users WHERE Username='" & newUser.name & "'"
        Dim table As String = "User"
        ds = fillDS(sql, table)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(table).NewRow()                  'create new row

        'character
        dsNewRow.Item("Username") = newUser.name
        dsNewRow.Item("Pswd") = newUser.password
        dsNewRow.Item("UserLevel") = newUser.level
        dsNewRow.Item("Exp") = newUser.exp
        dsNewRow.Item("SkillPts") = newUser.skillPts
        dsNewRow.Item("Alive") = newUser.alive
        dsNewRow.Item("CurrEnd") = newUser.currEnd
        dsNewRow.Item("Location") = newUser.currLoc
        dsNewRow.Item("MaxEnd") = newUser.maxEnd
        dsNewRow.Item("Hunger") = newUser.hunger
        dsNewRow.Item("Thirst") = newUser.thirst

        'inventory
        dsNewRow.Item("CurrWeapon") = newUser.currWeapon
        dsNewRow.Item("LightWeapon") = newUser.lightWeapon.name
        dsNewRow.Item("HeavyWeapon") = newUser.heavyWeapon.name
        dsNewRow.Item("TwoHWeapon") = newUser.twoHWeapon.name
        dsNewRow.Item("Armor") = newUser.armor.name
        dsNewRow.Item("Potion") = newUser.potion
        dsNewRow.Item("Lockpicks") = newUser.lockpicks
        dsNewRow.Item("GoldOnHand") = newUser.goldOnHand
        dsNewRow.Item("GoldInBank") = newUser.goldInBank
        dsNewRow.Item("GoldOnLoan") = newUser.goldOnLoan
        dsNewRow.Item("Shovel") = newUser.shovel
        dsNewRow.Item("Lantern") = newUser.lantern
        dsNewRow.Item("Amulet") = newUser.amulet

        'skills
        dsNewRow.Item("LightWeaponSkill") = newUser.lightWeaponSkill
        dsNewRow.Item("HeavyWeaponSkill") = newUser.heavyWeaponSkill
        dsNewRow.Item("TwoHWeaponSkill") = newUser.twoHWeaponSkill
        dsNewRow.Item("Blocking") = newUser.blocking
        dsNewRow.Item("Slipping") = newUser.slipping
        dsNewRow.Item("Stealth") = newUser.stealth

        'henchmen
        dsNewRow.Item("Henchmen1") = newUser.hench1
        dsNewRow.Item("Henchmen2") = newUser.hench2
        dsNewRow.Item("Henchmen3") = newUser.hench3
        dsNewRow.Item("Henchmen4") = newUser.hench4
        dsNewRow.Item("Henchmen5") = newUser.hench5

        Dim dbProvider As String = "Provider=Microsoft.ACE.oledb.12.0;" 'database provider
        Dim dbSource As String = "Data Source=Assassin.mdb"             'database source
        Dim con As New OleDbConnection                                  'database connection

        Try
            con.ConnectionString = dbProvider & dbSource                'set connection type and location of database
            da = New OleDbDataAdapter(sql, con)                         'establish connection

            Dim cb As New OleDb.OleDbCommandBuilder(da)

            ds.Tables(table).Rows.Add(dsNewRow)                         'add new row to Dataset
            da.Update(ds, table)                                        'update database
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Assassin", MessageBoxButtons.OK)
            Exit Sub
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub save(ByVal currUser As User)
        '* * * * *
        '* This method saves the user.
        '* * * * *

        Dim ds As New DataSet
        Dim sql As String = "SELECT * FROM Users WHERE Username='" & currUser.name & "'"
        Dim table As String = "User"
        ds = fillDS(sql, table)

        'character
        ds.Tables("User").Rows(0).Item("Username") = currUser.name
        ds.Tables("User").Rows(0).Item("Pswd") = currUser.password
        ds.Tables("User").Rows(0).Item("UserLevel") = currUser.level
        ds.Tables("User").Rows(0).Item("Exp") = currUser.exp
        ds.Tables("User").Rows(0).Item("SkillPts") = currUser.skillPts
        ds.Tables("User").Rows(0).Item("Alive") = currUser.alive
        ds.Tables("User").Rows(0).Item("CurrEnd") = currUser.currEnd
        ds.Tables("User").Rows(0).Item("Location") = currUser.currLoc
        ds.Tables("User").Rows(0).Item("MaxEnd") = currUser.maxEnd
        ds.Tables("User").Rows(0).Item("Hunger") = currUser.hunger
        ds.Tables("User").Rows(0).Item("Thirst") = currUser.thirst

        'inventory
        ds.Tables("User").Rows(0).Item("CurrWeapon") = currUser.currWeapon
        ds.Tables("User").Rows(0).Item("LightWeapon") = currUser.lightWeapon.name
        ds.Tables("User").Rows(0).Item("HeavyWeapon") = currUser.heavyWeapon.name
        ds.Tables("User").Rows(0).Item("TwoHWeapon") = currUser.twoHWeapon.name
        ds.Tables("User").Rows(0).Item("Armor") = currUser.armor.name
        ds.Tables("User").Rows(0).Item("Potion") = currUser.potion
        ds.Tables("User").Rows(0).Item("Lockpicks") = currUser.lockpicks
        ds.Tables("User").Rows(0).Item("GoldOnHand") = currUser.goldOnHand
        ds.Tables("User").Rows(0).Item("GoldInBank") = currUser.goldInBank
        ds.Tables("User").Rows(0).Item("GoldOnLoan") = currUser.goldOnLoan
        ds.Tables("User").Rows(0).Item("Shovel") = currUser.shovel
        ds.Tables("User").Rows(0).Item("Lantern") = currUser.lantern
        ds.Tables("User").Rows(0).Item("Amulet") = currUser.amulet

        'skills
        ds.Tables("User").Rows(0).Item("LightWeaponSkill") = currUser.lightWeaponSkill
        ds.Tables("User").Rows(0).Item("HeavyWeaponSkill") = currUser.heavyWeaponSkill
        ds.Tables("User").Rows(0).Item("TwoHWeaponSkill") = currUser.twoHWeaponSkill
        ds.Tables("User").Rows(0).Item("Blocking") = currUser.blocking
        ds.Tables("User").Rows(0).Item("Slipping") = currUser.slipping
        ds.Tables("User").Rows(0).Item("Stealth") = currUser.stealth

        'henchmen
        ds.Tables("User").Rows(0).Item("Henchmen1") = currUser.hench1
        ds.Tables("User").Rows(0).Item("Henchmen2") = currUser.hench2
        ds.Tables("User").Rows(0).Item("Henchmen3") = currUser.hench3
        ds.Tables("User").Rows(0).Item("Henchmen4") = currUser.hench4
        ds.Tables("User").Rows(0).Item("Henchmen5") = currUser.hench5

        updateRecord(sql, table, ds)
    End Sub

    Public Sub save(ByVal currUser As User, ByVal oldName As String)
        '* * * * *
        '* This method saves the user, specifically from the admin form when changing names.
        '* * * * *

        Dim ds As New DataSet
        Dim sql As String = "SELECT * FROM Users WHERE Username='" & oldName & "'"
        Dim table As String = "User"
        ds = fillDS(sql, table)

        'character
        ds.Tables("User").Rows(0).Item("Username") = currUser.name
        ds.Tables("User").Rows(0).Item("Pswd") = currUser.password
        ds.Tables("User").Rows(0).Item("UserLevel") = currUser.level
        ds.Tables("User").Rows(0).Item("Exp") = currUser.exp
        ds.Tables("User").Rows(0).Item("SkillPts") = currUser.skillPts
        ds.Tables("User").Rows(0).Item("Alive") = currUser.alive
        ds.Tables("User").Rows(0).Item("CurrEnd") = currUser.currEnd
        ds.Tables("User").Rows(0).Item("Location") = currUser.currLoc
        ds.Tables("User").Rows(0).Item("MaxEnd") = currUser.maxEnd
        ds.Tables("User").Rows(0).Item("Hunger") = currUser.hunger
        ds.Tables("User").Rows(0).Item("Thirst") = currUser.thirst

        'inventory
        ds.Tables("User").Rows(0).Item("CurrWeapon") = currUser.currWeapon
        ds.Tables("User").Rows(0).Item("LightWeapon") = currUser.lightWeapon.name
        ds.Tables("User").Rows(0).Item("HeavyWeapon") = currUser.heavyWeapon.name
        ds.Tables("User").Rows(0).Item("TwoHWeapon") = currUser.twoHWeapon.name
        ds.Tables("User").Rows(0).Item("Armor") = currUser.armor.name
        ds.Tables("User").Rows(0).Item("Potion") = currUser.potion
        ds.Tables("User").Rows(0).Item("Lockpicks") = currUser.lockpicks
        ds.Tables("User").Rows(0).Item("GoldOnHand") = currUser.goldOnHand
        ds.Tables("User").Rows(0).Item("GoldInBank") = currUser.goldInBank
        ds.Tables("User").Rows(0).Item("GoldOnLoan") = currUser.goldOnLoan
        ds.Tables("User").Rows(0).Item("Shovel") = currUser.shovel
        ds.Tables("User").Rows(0).Item("Lantern") = currUser.lantern
        ds.Tables("User").Rows(0).Item("Amulet") = currUser.amulet


        'skills
        ds.Tables("User").Rows(0).Item("LightWeaponSkill") = currUser.lightWeaponSkill
        ds.Tables("User").Rows(0).Item("HeavyWeaponSkill") = currUser.heavyWeaponSkill
        ds.Tables("User").Rows(0).Item("TwoHWeaponSkill") = currUser.twoHWeaponSkill
        ds.Tables("User").Rows(0).Item("Blocking") = currUser.blocking
        ds.Tables("User").Rows(0).Item("Slipping") = currUser.slipping
        ds.Tables("User").Rows(0).Item("Stealth") = currUser.stealth

        'henchmen
        ds.Tables("User").Rows(0).Item("Henchmen1") = currUser.hench1
        ds.Tables("User").Rows(0).Item("Henchmen2") = currUser.hench2
        ds.Tables("User").Rows(0).Item("Henchmen3") = currUser.hench3
        ds.Tables("User").Rows(0).Item("Henchmen4") = currUser.hench4
        ds.Tables("User").Rows(0).Item("Henchmen5") = currUser.hench5

        updateRecord(sql, table, ds)
    End Sub

    Public Sub saveGuild(ByVal currGuild As Guild)
        Dim sql As String = "SELECT * FROM Guilds WHERE ID=" & currGuild.id
        Dim table As String = "Guilds"
        Dim ds As DataSet = fillDS(sql, table)

        ds.Tables("Guilds").Rows(0).Item("ID") = currGuild.id
        ds.Tables("Guilds").Rows(0).Item("GuildName") = currGuild.name
        ds.Tables("Guilds").Rows(0).Item("Guildmaster") = currGuild.master
        ds.Tables("Guilds").Rows(0).Item("GuildFee") = currGuild.fee
        ds.Tables("Guilds").Rows(0).Item("GuildGold") = currGuild.gold
        ds.Tables("Guilds").Rows(0).Item("Henchmen1") = currGuild.hench1
        ds.Tables("Guilds").Rows(0).Item("Henchmen2") = currGuild.hench2
        ds.Tables("Guilds").Rows(0).Item("Henchmen3") = currGuild.hench3
        ds.Tables("Guilds").Rows(0).Item("Henchmen4") = currGuild.hench4
        ds.Tables("Guilds").Rows(0).Item("Henchmen5") = currGuild.hench5

        updateRecord(sql, table, ds)
    End Sub

    Public Sub updateRecord(ByVal sql As String, ByVal tableName As String, ByVal ds As DataSet)
        '* * * * *
        '* This method updates a record in the database
        '* * * * *

        Try
            con.ConnectionString = dbProvider & dbSource                'set connection type and location of database
            da = New OleDbDataAdapter(sql, con)                         'establish connection

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            da.Update(ds, tableName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Assassin", MessageBoxButtons.OK)
            Exit Sub
        Finally
            con.Close()
        End Try
    End Sub
End Class