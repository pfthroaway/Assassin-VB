' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Guild Form.vb
' Description     : This forms contains the statistics of a Guild.

Option Strict On
Option Explicit On

Public Class Guild
    Dim _id As Integer      'Guild ID
    Dim _name As String     'Guild name
    Dim _master As String   'Guildmaster
    Dim _fee As Integer     'Guild fee
    Dim _gold As Integer    'Guild's gold
    Dim _hench1 As Integer  'Henchmen Level 1
    Dim _hench2 As Integer  'Henchmen Level 2
    Dim _hench3 As Integer  'Henchmen Level 3
    Dim _hench4 As Integer  'Henchmen Level 4
    Dim _hench5 As Integer  'Henchmen Level 5

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property master As String
        Get
            Return _master
        End Get
        Set(value As String)
            _master = value
        End Set
    End Property

    Public Property fee As Integer
        Get
            Return _fee
        End Get
        Set(value As Integer)
            _fee = value
        End Set
    End Property

    Public Property gold As Integer
        Get
            Return _gold
        End Get
        Set(value As Integer)
            _gold = value
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