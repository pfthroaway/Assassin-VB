Option Strict On
Option Explicit On

Imports Assassin.Classes.Entities

Namespace Classes.Items

    ''' <summary>Represents a <see cref="Food"/> which can be consumed to reduce a <see cref="User"/>'s hunger.</summary>
    Public Class Food
        Inherits Item

#Region "Properties"

        ''' <summary>Amount of hunger to be restored.</summary>
        Public Property RestoreHunger As Integer

#End Region

#Region "Override Operators"

        Public Overloads Shared Function Equals(left As Food, right As Food) As Boolean
            If left Is Nothing AndAlso right Is Nothing Then
                Return True
            End If
            If left Is Nothing Xor right Is Nothing Then
                Return False
            End If
            Return (left.Name = right.Name) AndAlso (left.RestoreHunger = right.RestoreHunger) AndAlso (left.Value = right.Value)
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            Return Equals(Me, TryCast(obj, Food))
        End Function

        Public Overloads Function Equals(otherFood As Food) As Boolean
            Return Equals(Me, otherFood)
        End Function

        Public Shared Operator =(left As Food, right As Food) As Boolean
            Return Equals(left, right)
        End Operator

        Public Shared Operator <>(left As Food, right As Food) As Boolean
            Return Not Equals(left, right)
        End Operator

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode() Xor 17
        End Function

        Public Overrides Function ToString() As String
            Return Name
        End Function

#End Region

#Region "Constructors"

        ''' <summary>Initializes a new instance of the <see cref="Food"/> class.</summary>
        Friend Sub New()
            Name = "None"
            RestoreHunger = 0
            Value = 0
        End Sub

        ''' <summary>Initializes a new instance of the <see cref="Food"/> class using Property values.</summary>
        ''' <param name="newName">Name of <see cref="Food"/></param>
        ''' <param name="newRestoreHunger">Amount the <see cref="Food"/> heals the <see cref="User"/></param>
        ''' <param name="newValue">Gold value of <see cref="Food"/></param>
        Friend Sub New(newName As String, newRestoreHunger As Integer, newValue As Integer)
            Name = newName
            RestoreHunger = newRestoreHunger
            Value = newValue
        End Sub

        ''' <summary>Initializes a new instance of the <see cref="Food"/> using another <see cref="Food"/>.</summary>
        ''' <param name="other"><see cref="Food"/> to replace this instance</param>
        Friend Sub New(other As Food)
            Me.New(other.Name, other.RestoreHunger, other.Value)
        End Sub

#End Region

    End Class

End Namespace