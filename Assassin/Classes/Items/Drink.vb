Namespace Classes.Items

    Public Class Drink
        Inherits Item

        Private _restoreThirst As Integer

#Region "Properties"

        Public Property RestoreThirst As Integer
            Get
                Return _restoreThirst
            End Get
            Set
                _restoreThirst = Value
            End Set
        End Property

#End Region

#Region "Override Operators"

        Public Overloads Shared Function Equals(left As Drink, right As Drink) As Boolean
            If ReferenceEquals(Nothing, left) AndAlso ReferenceEquals(Nothing, right) Then
                Return True
            End If
            If ReferenceEquals(Nothing, left) Xor ReferenceEquals(Nothing, right) Then
                Return False
            End If
            Return (left.Name = right.Name) AndAlso (left.RestoreThirst = right.RestoreThirst) AndAlso (left.Value = right.Value)
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            Return Equals(Me, TryCast(obj, Drink))
        End Function

        Public Overloads Function Equals(otherDrink As Drink) As Boolean
            Return Equals(Me, otherDrink)
        End Function

        Public Shared Operator =(left As Drink, right As Drink) As Boolean
            Return Equals(left, right)
        End Operator

        Public Shared Operator <>(left As Drink, right As Drink) As Boolean
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

        ''' <summary>Initializes a new instance of the Drink class.</summary>
        Friend Sub New()
            Name = "None"
            RestoreThirst = 0
            Value = 0
        End Sub

        ''' <summary>Initializes a new instance of the Drink class using Property values.</summary>
        ''' <param name="newName">Name of Drink</param>
        ''' <param name="newRestoreThirst">Amount the Drink heals the User</param>
        ''' <param name="newValue">Gold value of Drink</param>
        Friend Sub New(newName As String, newRestoreThirst As Integer, newValue As Integer)
            Name = newName
            RestoreThirst = newRestoreThirst
            Value = newValue
        End Sub

        ''' <summary>Initializes a new instance of the Drink using another Drink.</summary>
        ''' <param name="other">Drink to replace this instance</param>
        Friend Sub New(other As Drink)
            Me.New(other.Name, other.RestoreThirst, other.Value)
        End Sub

#End Region

    End Class

End Namespace