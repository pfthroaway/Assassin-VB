' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Enemy.vb
' Description     : This class holds the statistics for an Enemy.

Option Strict On
Option Explicit On

Public Class Enemy
    Private _level As Integer       'level
    Private _name As String         'username
    Private _currWeapon As Weapon   'weapon
    Private _armor As Armor         'armor
    Private _currEnd As Integer     'current endurance
    Private _maxEnd As Integer      'maximum endurance
    Private _attack As Integer      'light weapon skill
    Private _blocking As Integer    'blocking skill
    Private _slipping As Integer    'slipping skill

    Public Property level As Integer
        Get
            Return _level
        End Get
        Set(value As Integer)
            _level = value
        End Set
    End Property

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property weapon As Weapon
        Get
            Return _currWeapon
        End Get
        Set(value As Weapon)
            _currWeapon = value
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

    Public Property attackSkill As Integer
        Get
            Return _attack
        End Get
        Set(value As Integer)
            _attack = value
        End Set
    End Property

    Public Property blocking As Integer
        Get
            Return _blocking
        End Get
        Set(value As Integer)
            _blocking = value
        End Set
    End Property

    Public Property slipping As Integer
        Get
            Return _slipping
        End Get
        Set(value As Integer)
            _slipping = value
        End Set
    End Property
End Class