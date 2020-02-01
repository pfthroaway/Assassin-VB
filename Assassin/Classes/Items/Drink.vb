Imports Assassin.Classes.Entities

Namespace Classes.Items

    ''' <summary>Represents a <see cref="Drink"/> which can be consumed to reduce a <see cref="User"/>'s thirst.</summary>
    Public Class Drink
        Inherits Item

#Region "Properties"

        ''' <summary>Amount of thirst to be restored.</summary>
        Public Property RestoreThirst As Integer

#End Region

#Region "Override Operators"

        Public Overloads Shared Function Equals(left As Drink, right As Drink) As Boolean
            If left Is Nothing AndAlso right Is Nothing Then
                Return True
            End If
            If left Is Nothing Xor right Is Nothing Then
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

        ''' <summary>Initializes a new instance of the <see cref="Drink"/> class.</summary>
        Friend Sub New()
            Name = "None"
            RestoreThirst = 0
            Value = 0
        End Sub

        ''' <summary>Initializes a new instance of the <see cref="Drink"/> class using Property values.</summary>
        ''' <param name="newName">Name of <see cref="Drink"/></param>
        ''' <param name="newRestoreThirst">Amount the <see cref="Drink"/> heals the <see cref="User"/></param>
        ''' <param name="newValue">Gold value of <see cref="Drink"/></param>
        Friend Sub New(newName As String, newRestoreThirst As Integer, newValue As Integer)
            Name = newName
            RestoreThirst = newRestoreThirst
            Value = newValue
        End Sub

        ''' <summary>Initializes a new instance of the <see cref="Drink"/> using another <see cref="Drink"/>.</summary>
        ''' <param name="other"><see cref="Drink"/> to replace this instance</param>
        Friend Sub New(other As Drink)
            Me.New(other.Name, other.RestoreThirst, other.Value)
        End Sub

#End Region

    End Class

End Namespace