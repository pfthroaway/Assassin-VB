' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : BattleUser.vb
' Description     : This class contains the statistics of a BattleUser.

Option Strict On
Option Explicit On

Public Class BattleUser
    Dim _currEnd As Integer     'current endurance
    Dim _maxEnd As Integer      'maximum endurance
    Dim _weapon As New Weapon   'current weapon
    Dim _armor As New Armor     'current armor
    Dim _toHit As Integer       'chance to hit
    Dim _toBlock As Integer     'chance to block
    Dim _toFlee As Integer      'chance to flee
    Dim _stamina As Integer     'current stamina
    Dim _stance As String       'current stance

    Public Property currEnd As Integer
        Get
            Return _currEnd
        End Get
        Set(value As Integer)
            _currEnd = value
        End Set
    End Property

    Public Property maxEnd As Integer
        Get
            Return _maxEnd
        End Get
        Set(value As Integer)
            _maxEnd = value
        End Set
    End Property

    Public Property weapon As Weapon
        Get
            Return _weapon
        End Get
        Set(value As Weapon)
            _weapon = value
        End Set
    End Property

    Public Property armor As Armor
        Get
            Return _armor
        End Get
        Set(value As Armor)
            _armor = value
        End Set
    End Property

    Public Property toHit As Integer
        Get
            Return _toHit
        End Get
        Set(value As Integer)
            _toHit = value
        End Set
    End Property

    Public Property toBlock As Integer
        Get
            Return _toBlock
        End Get
        Set(value As Integer)
            _toBlock = value
        End Set
    End Property

    Public Property toFlee As Integer
        Get
            Return _toFlee
        End Get
        Set(value As Integer)
            _toFlee = value
        End Set
    End Property

    Public Property stamina As Integer
        Get
            Return _stamina
        End Get
        Set(value As Integer)
            _stamina = value
        End Set
    End Property

    Public Property stance As String
        Get
            Return _stance
        End Get
        Set(value As String)
            _stance = value
        End Set
    End Property
End Class