' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Henchmanm.vb
' Description     : This forms contains the statistics of Henchmen for raiding.

Option Strict On
Option Explicit On

Public Class Henchman
    Dim _level As Integer       'current highest henchman level
    Dim _health As Integer      'health of henchman
    Dim _damage As Integer      'damage henchman can do
    Dim _toHit As Integer       'chance to hit
    Dim _blocking As Integer    'chance to block
    Dim _number As Integer      'number of henchmen at current level
    Dim _hench1 As Integer      'level 1 henchmen
    Dim _hench2 As Integer      'level 2 henchmen
    Dim _hench3 As Integer      'level 3 henchmen
    Dim _hench4 As Integer      'level 4 henchmen
    Dim _hench5 As Integer      'level 5 henchmen

    Public Property level As Integer
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

    Public Property health As Integer
        Get
            Return _health
        End Get
        Set(value As Integer)
            _health = value
        End Set
    End Property

    Public Property damage As Integer
        Get
            Return _damage
        End Get
        Set(value As Integer)
            _damage = value
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

    Public Property blocking As Integer
        Get
            Return _blocking
        End Get
        Set(value As Integer)
            _blocking = value
        End Set
    End Property

    Public Property number As Integer
        Get
            Return _number
        End Get
        Set(value As Integer)
            _number = value
        End Set
    End Property

    Public Property hench1 As Integer
        Get
            Return _hench1
        End Get
        Set(value As Integer)
            _hench1 = value
        End Set
    End Property

    Public Property hench2 As Integer
        Get
            Return _hench2
        End Get
        Set(value As Integer)
            _hench2 = value
        End Set
    End Property

    Public Property hench3 As Integer
        Get
            Return _hench3
        End Get
        Set(value As Integer)
            _hench3 = value
        End Set
    End Property

    Public Property hench4 As Integer
        Get
            Return _hench4
        End Get
        Set(value As Integer)
            _hench4 = value
        End Set
    End Property

    Public Property hench5 As Integer
        Get
            Return _hench5
        End Get
        Set(value As Integer)
            _hench5 = value
        End Set
    End Property
End Class