' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Weapon.vb
' Description     : This form contains the statistics for a Weapon.

Option Strict On
Option Explicit On

Public Class Weapon
    Private funcs As New Functions
    Private _name As String     'weapon name
    Private _type As String     'weapon type
    Private _damage As Integer  'weapon damage
    Private _value As Integer   'weapon value

    Public Property name() As String
        Get
            Return _name
        End Get
        Set(val As String)
            _name = val
        End Set
    End Property

    Public Property type() As String
        Get
            Return _type
        End Get
        Set(val As String)
            _type = val
        End Set
    End Property

    Public Property damage As Integer
        Get
            Return _damage
        End Get
        Set(val As Integer)
            _damage = val
        End Set
    End Property

    Public Property value As Integer
        Get
            Return _value
        End Get
        Set(val As Integer)
            _value = val
        End Set
    End Property


    Public Overloads Function Equals(newWeapon As Weapon) As Boolean
        '* * * * *
        '* This method overloads the Equals function and replaces it with a simple comparison.
        '* * * * *

        Return _name = newWeapon.name AndAlso _type = newWeapon.type
    End Function

    Public Function purchase(ByVal newWeapon As Weapon) As Integer
        '* * * * *
        '* This function purchases a new Weapon.
        '* * * * *

        _name = newWeapon.name
        _type = newWeapon.type
        _damage = newWeapon.damage
        _value = newWeapon.value

        Return _value
    End Function

    Public Function sell() As Integer
        '* * * * *
        '* This function sells a Weapon.
        '* * * * *

        Dim val As Integer = _value
        _name = "Hands"
        getDamage(_name, _type)
        _value = 0

        Return (val \ 2)
    End Function


    Private Sub getDamage(name As String, type As String)
        '* * * * *
        '* This method gets a weapon's damage from the database.
        '* * * * *

        Dim sql As String = "SELECT * FROM Weapons Where WeaponName='" & _name & "' AND WeaponType='" & _type & "'"
        Dim table As String = "Weapon"
        Dim ds As DataSet = funcs.fillDS(sql, table)
        Integer.TryParse(ds.Tables("Weapon").Rows(0).Item("WeaponDamage").ToString, _damage)
    End Sub

    Public Sub New()
        '* * * * *
        '* This function creates a new weapon.
        '* * * * *

        _name = "Hands"
        _type = "Light"
        getDamage(_name, _type)
        _value = 0
    End Sub

    Public Sub New(weaponType As String)
        '* * * * *
        '* This function creates a new weapon with a specific weapon type.
        '* * * * *

        _name = "Hands"
        _type = weaponType
        getDamage(_name, _type)
        _value = 0
    End Sub

    Public Sub New(ByVal newWeapon As Weapon)
        '* * * * *
        '* This function creates a new weapon.
        '* * * * *

        _name = newWeapon.name
        _type = newWeapon.type
        _damage = newWeapon.damage
        _value = newWeapon.value
    End Sub

    Public Sub New(ByVal name As String, ByVal type As String, ByVal damage As Integer, ByVal val As Integer)
        '* * * * *
        '* This function creates a new weapon with everything specified.
        '* * * * *

        _name = name
        _type = type
        _damage = damage
        _value = val
    End Sub
End Class