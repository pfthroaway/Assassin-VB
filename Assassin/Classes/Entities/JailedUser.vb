Option Strict On
Option Explicit On

Imports Assassin.Classes.Entities

''' <summary>Represents a <see cref="User"/> who is in Jail.</summary>
Public Class JailedUser

#Region "Modifying Properties"

    ''' <summary>Name of the <see cref="JailedUser"/>.</summary>
    Public Property Name As String

    ''' <summary>Reason the <see cref="JailedUser"/> is in Jail.</summary>
    Public Property Reason As Crime

    ''' <summary>Amount of gold required to release the <see cref="JailedUser"/> from Jail.</summary>
    Public Property Fine As Integer

    ''' <summary>Date the <see cref="JailedUser"/> was incarcerated in UTC.</summary>
    Public Property DateJailed As Date

#End Region

#Region "Helper Properties"

    ''' <summary>Date the <see cref="JailedUser"/> was incarcerated in local time.</summary>
    Public ReadOnly Property LocalDateJailed As Date
        Get
            Return TimeZone.CurrentTimeZone.ToLocalTime(DateJailed)
        End Get
    End Property

#End Region

#Region "Override Operators"

    Public Overloads Function Equals(left As JailedUser, right As JailedUser) As Boolean
        If left Is Nothing AndAlso right Is Nothing Then
            Return True
        End If
        If left Is Nothing Xor right Is Nothing Then
            Return False
        End If
        Return left.Name = right.Name AndAlso left.Reason = right.Reason AndAlso left.Fine = right.Fine AndAlso left.DateJailed = right.DateJailed
    End Function

    Public Overloads Function Equals(otherJailedUser As JailedUser) As Boolean
        Return Equals(Me, otherJailedUser)
    End Function

    Public Overloads Overrides Function Equals(obj As Object) As Boolean
        Return Equals(Me, TryCast(obj, JailedUser))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode() Xor 17
    End Function

    Public Shared Operator =(left As JailedUser, right As JailedUser) As Boolean
        Return left.Equals(right)
    End Operator

    Public Shared Operator <>(left As JailedUser, right As JailedUser) As Boolean
        Return Not left = right
    End Operator

    Public Overrides Function ToString() As String
        Return Name
    End Function

#End Region

#Region "Constructors"

    ''' <summary>Initializes a new Instance of <see cref="JailedUser"/>.</summary>
    ''' <param name="newName">Name of the <see cref="JailedUser"/></param>
    ''' <param name="newReason">Reason the <see cref="JailedUser"/> is in Jail</param>
    ''' <param name="newFine">Amount of gold required to release the <see cref="JailedUser"/> from Jail</param>
    ''' <param name="newDateJailed">Date the <see cref="JailedUser"/> was incarcerated in UTC</param>
    Public Sub New(newName As String, newReason As Crime, newFine As Integer, newDateJailed As Date)
        Name = newName
        Reason = newReason
        Fine = newFine
        DateJailed = newDateJailed
    End Sub

    ''' <summary>Replaces this instance of <see cref="JailedUser"/> with another instance.</summary>
    ''' <param name="other">Instance of <see cref="JailedUser"/> to replace this instance</param>
    Public Sub New(other As JailedUser)
        Name = other.Name
        Reason = other.Reason
        Fine = other.Fine
        DateJailed = other.DateJailed
    End Sub

#End Region

End Class