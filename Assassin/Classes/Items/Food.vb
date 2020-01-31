Namespace Classes.Items

    Public Class Food
        Inherits Item

        Private _restoreHunger As Integer

#Region "Properties"

        Public Property RestoreHunger As Integer
            Get
                Return _restoreHunger
            End Get
            Set
                _restoreHunger = Value
            End Set
        End Property

#End Region

#Region "Override Operators"

        Public Overloads Shared Function Equals(left As Food, right As Food) As Boolean
            If ReferenceEquals(Nothing, left) AndAlso ReferenceEquals(Nothing, right) Then
                Return True
            End If
            If ReferenceEquals(Nothing, left) Xor ReferenceEquals(Nothing, right) Then
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

        ''' <summary>Initializes a new instance of the Food class.</summary>
        Friend Sub New()
            Name = "None"
            RestoreHunger = 0
            Value = 0
        End Sub

        ''' <summary>Initializes a new instance of the Food class using Property values.</summary>
        ''' <param name="newName">Name of Food</param>
        ''' <param name="newRestoreHunger">Amount the Food heals the User</param>
        ''' <param name="newValue">Gold value of Food</param>
        Friend Sub New(newName As String, newRestoreHunger As Integer, newValue As Integer)
            Name = newName
            RestoreHunger = newRestoreHunger
            Value = newValue
        End Sub

        ''' <summary>Initializes a new instance of the Food using another Food.</summary>
        ''' <param name="other">Food to replace this instance</param>
        Friend Sub New(other As Food)
            Me.New(other.Name, other.RestoreHunger, other.Value)
        End Sub

#End Region

    End Class

End Namespace