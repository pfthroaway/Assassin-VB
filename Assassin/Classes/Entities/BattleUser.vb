' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : BattleUser.vb
' Description     : This class contains the statistics of a BattleUser.

Option Strict On
Option Explicit On

Imports Assassin.Classes.Items

Namespace Classes.Entities

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

        Public Property CurrentEndurance As Integer
            Get
                Return _currEnd
            End Get
            Set(value As Integer)
                _currEnd = value
            End Set
        End Property

        Public Property MaximumEndurance As Integer
            Get
                Return _maxEnd
            End Get
            Set(value As Integer)
                _maxEnd = value
            End Set
        End Property

        Public Property Weapon As Weapon
            Get
                Return _weapon
            End Get
            Set(value As Weapon)
                _weapon = value
            End Set
        End Property

        Public Property Armor As Armor
            Get
                Return _armor
            End Get
            Set(value As Armor)
                _armor = value
            End Set
        End Property

        Public Property WeaponSkill As Integer
            Get
                Return _toHit
            End Get
            Set(value As Integer)
                _toHit = value
            End Set
        End Property

        Public Property ToBlock As Integer
            Get
                Return _toBlock
            End Get
            Set(value As Integer)
                _toBlock = value
            End Set
        End Property

        Public Property ToFlee As Integer
            Get
                Return _toFlee
            End Get
            Set(value As Integer)
                _toFlee = value
            End Set
        End Property

        Public Property Stamina As Integer
            Get
                Return _stamina
            End Get
            Set(value As Integer)
                _stamina = value
            End Set
        End Property

        Public Property Stance As String
            Get
                Return _stance
            End Get
            Set(value As String)
                _stance = value
            End Set
        End Property

    End Class

End Namespace