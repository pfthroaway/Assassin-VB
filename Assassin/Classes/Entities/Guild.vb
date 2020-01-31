' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Guild Form.vb
' Description     : This forms contains the statistics of a Guild.

Option Strict On
Option Explicit On

Namespace Classes.Entities

    Public Class Guild

        Private _id As Integer, _fee As Integer, _gold As Integer, _henchmenLevel1 As Integer, _henchmenLevel2 As Integer, _henchmenLevel3 As Integer,
                _henchmenLevel4 As Integer, _henchmenLevel5 As Integer

        Private _name As String, _master As String
        Private _members As New List(Of String)()

        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set
                _id = Value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set
                _name = Value
            End Set
        End Property

        Public Property Master() As String
            Get
                Return _master
            End Get
            Set
                _master = Value
            End Set
        End Property

        Public Property Fee() As Integer
            Get
                Return _fee
            End Get
            Set
                _fee = Value
            End Set
        End Property

        Public Property Gold() As Integer
            Get
                Return _gold
            End Get
            Set
                _gold = Value
            End Set
        End Property

        Public Property Members() As List(Of String)
            Get
                Return _members
            End Get
            Set
                _members = Value
            End Set
        End Property

        Public Property HenchmenLevel1() As Integer
            Get
                Return _henchmenLevel1
            End Get
            Set
                _henchmenLevel1 = Value
            End Set
        End Property

        Public Property HenchmenLevel2() As Integer
            Get
                Return _henchmenLevel2
            End Get
            Set
                _henchmenLevel2 = Value
            End Set
        End Property

        Public Property HenchmenLevel3() As Integer
            Get
                Return _henchmenLevel3
            End Get
            Set
                _henchmenLevel3 = Value
            End Set
        End Property

        Public Property HenchmenLevel4() As Integer
            Get
                Return _henchmenLevel4
            End Get
            Set
                _henchmenLevel4 = Value
            End Set
        End Property

        Public Property HenchmenLevel5() As Integer
            Get
                Return _henchmenLevel5
            End Get
            Set
                _henchmenLevel5 = Value
            End Set
        End Property

        ''' <summary>Initializes a new instance of the Guild class.</summary>
        Friend Sub New()
            ID = 0
            Name = ""
            Master = "Computer"
            Fee = 50
            Gold = 500
            Members = New List(Of String)()
            HenchmenLevel1 = 0
            HenchmenLevel2 = 0
            HenchmenLevel3 = 0
            HenchmenLevel4 = 0
            HenchmenLevel5 = 0
        End Sub

        ''' <summary>Initializes a new instance of the Guild class using Property values.</summary>
        ''' <param name="newID">ID of Guild</param>
        ''' <param name="newName">Name of Guild</param>
        ''' <param name="newMaster">Name of Guildmaster</param>
        ''' <param name="newFee">Fee to enter Guild</param>
        ''' <param name="newGold">Amount of Gold owned by Guild</param>
        ''' <param name="newMembers">Names of Users who are a member of the Guild</param>
        ''' <param name="newHenchmenLevel1">Amount of Level 1 Henchmen the Guild employs</param>
        ''' <param name="newHenchmenLevel2">Amount of Level 2 Henchmen the Guild employs</param>
        ''' <param name="newHenchmenLevel3">Amount of Level 3 Henchmen the Guild employs</param>
        ''' <param name="newHenchmenLevel4">Amount of Level 4 Henchmen the Guild employs</param>
        ''' <param name="newHenchmenLevel5">Amount of Level 5 Henchmen the Guild employs</param>
        Friend Sub New(newID As Integer, newName As String, newMaster As String, newFee As Integer, newGold As Integer, newMembers As List(Of [String]), newHenchmenLevel1 As Integer, newHenchmenLevel2 As Integer, newHenchmenLevel3 As Integer, newHenchmenLevel4 As Integer, newHenchmenLevel5 As Integer)
            ID = newID
            Name = newName
            Master = newMaster
            Fee = newFee
            Gold = newGold
            Members = newMembers
            HenchmenLevel1 = newHenchmenLevel1
            HenchmenLevel2 = newHenchmenLevel2
            HenchmenLevel3 = newHenchmenLevel3
            HenchmenLevel4 = newHenchmenLevel4
            HenchmenLevel5 = newHenchmenLevel5
        End Sub

    End Class

End Namespace