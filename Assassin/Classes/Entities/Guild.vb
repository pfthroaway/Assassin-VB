' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Guild Form.vb
' Description     : This forms contains the statistics of a Guild.

Option Strict On
Option Explicit On

Namespace Classes.Entities

    ''' <summary>Represents a <see cref="Guild"/> that players can join.</summary>
    Public Class Guild

#Region "Properties"

        ''' <summary>The <see cref="Guild"/>'s ID.</summary>
        Public Property ID As Integer

        ''' <summary>The name of the <see cref="Guild"/>.</summary>
        Public Property Name As String

        ''' <summary>The master of the <see cref="Guild"/>.</summary>
        Public Property Master As String

        ''' <summary>The fee required to join the <see cref="Guild"/>.</summary>
        Public Property Fee As Integer

        ''' <summary>The amount of gold the <see cref="Guild"/> has.</summary>
        Public Property Gold As Integer

        ''' <summary>The members of the <see cref="Guild"/>.</summary>
        Public Property Members As New List(Of String)

        ''' <summary>The amount of level 1 Henchmen employed by the <see cref="Guild"/>.</summary>
        Public Property HenchmenLevel1 As Integer

        ''' <summary>The amount of level 2 Henchmen employed by the <see cref="Guild"/>.</summary>
        Public Property HenchmenLevel2 As Integer

        ''' <summary>The amount of level 3 Henchmen employed by the <see cref="Guild"/>.</summary>
        Public Property HenchmenLevel3 As Integer

        ''' <summary>The amount of level 4 Henchmen employed by the <see cref="Guild"/>.</summary>
        Public Property HenchmenLevel4 As Integer

        ''' <summary>The amount of level 5 Henchmen employed by the <see cref="Guild"/>.</summary>
        Public Property HenchmenLevel5 As Integer

#End Region

#Region "Override Operators"

        Public Overloads Function Equals(left As Guild, right As Guild) As Boolean
            If left Is Nothing AndAlso right Is Nothing Then
                Return True
            End If
            If left Is Nothing Xor right Is Nothing Then
                Return False
            End If
            Return left.ID = right.ID AndAlso left.Name = right.Name AndAlso left.Master = right.Master AndAlso left.Fee = right.Fee AndAlso left.Gold = right.Gold AndAlso left.HenchmenLevel1 = right.HenchmenLevel1 AndAlso left.HenchmenLevel2 = right.HenchmenLevel2 AndAlso left.HenchmenLevel3 = right.HenchmenLevel3 AndAlso left.HenchmenLevel4 = right.HenchmenLevel4 AndAlso left.HenchmenLevel5 = right.HenchmenLevel5 AndAlso Not left.Members.Except(right.Members).Any() AndAlso Not right.Members.Except(left.Members).Any()
        End Function

        Public Overloads Function Equals(otherGuild As Guild) As Boolean
            Return Equals(Me, otherGuild)
        End Function

        Public Overloads Overrides Function Equals(obj As Object) As Boolean
            Return Equals(Me, TryCast(obj, Guild))
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode() Xor 17
        End Function

        Public Shared Operator =(left As Guild, right As Guild) As Boolean
            Return left.Equals(right)
        End Operator

        Public Shared Operator <>(left As Guild, right As Guild) As Boolean
            Return Not left = right
        End Operator

        Public Overrides Function ToString() As String
            Return Name
        End Function

#End Region

        ''' <summary>Initializes a new instance of the Guild class.</summary>
        Friend Sub New()
            ID = 0
            Name = ""
            Master = "Computer"
            Fee = 50
            Gold = 500
            Members = New List(Of String)
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