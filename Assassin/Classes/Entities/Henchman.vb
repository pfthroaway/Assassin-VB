' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Henchmanm.vb
' Description     : This forms contains the statistics of Henchmen for raiding.

Option Strict On
Option Explicit On

Namespace Classes.Entities

    Public Class Henchman
        Dim _level As Integer       'current highest henchman level
        Dim _health As Integer      'health of henchman
        Dim _damage As Integer      'damage henchman can do
        Dim _toHit As Integer       'chance to hit
        Dim _blocking As Integer    'chance to block
        Dim _number As Integer      'number of henchmen at current level
        Dim _henchmenLevel1 As Integer      'level 1 henchmen
        Dim _henchmenLevel2 As Integer      'level 2 henchmen
        Dim _henchmenLevel3 As Integer      'level 3 henchmen
        Dim _henchmenLevel4 As Integer      'level 4 henchmen
        Dim _henchmenLevel5 As Integer      'level 5 henchmen

        Public Property Level As Integer
            Get
                Return _level
            End Get
            Set(value As Integer)
                _level = value
                _health = value * 2
                _damage = value
                _toHit = value * 2
                _blocking = value
            End Set
        End Property

        Public Property Health As Integer
            Get
                Return _health
            End Get
            Set(value As Integer)
                _health = value
            End Set
        End Property

        Public Property Damage As Integer
            Get
                Return _damage
            End Get
            Set(value As Integer)
                _damage = value
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

        Public Property Blocking As Integer
            Get
                Return _blocking
            End Get
            Set(value As Integer)
                _blocking = value
            End Set
        End Property

        Public Property Number As Integer
            Get
                Return _number
            End Get
            Set(value As Integer)
                _number = value
            End Set
        End Property

        Public Property HenchmenLevel1 As Integer
            Get
                Return _henchmenLevel1
            End Get
            Set(value As Integer)
                _henchmenLevel1 = value
            End Set
        End Property

        Public Property HenchmenLevel2 As Integer
            Get
                Return _henchmenLevel2
            End Get
            Set(value As Integer)
                _henchmenLevel2 = value
            End Set
        End Property

        Public Property HenchmenLevel3 As Integer
            Get
                Return _henchmenLevel3
            End Get
            Set(value As Integer)
                _henchmenLevel3 = value
            End Set
        End Property

        Public Property HenchmenLevel4 As Integer
            Get
                Return _henchmenLevel4
            End Get
            Set(value As Integer)
                _henchmenLevel4 = value
            End Set
        End Property

        Public Property HenchmenLevel5 As Integer
            Get
                Return _henchmenLevel5
            End Get
            Set(value As Integer)
                _henchmenLevel5 = value
            End Set
        End Property

    End Class

End Namespace