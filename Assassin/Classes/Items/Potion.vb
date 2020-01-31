Namespace Classes.Items

    Public Class Potion
        Inherits Item
        Private _healAmount As Integer

#Region "Properties"

        Public Property HealAmount As Integer
            Get
                Return _healAmount
            End Get
            Set
                _healAmount = Value
            End Set
        End Property

#End Region

#Region "Override Operators"

        Public Overloads Shared Function Equals(left As Potion, right As Potion) As Boolean
            If ReferenceEquals(Nothing, left) AndAlso ReferenceEquals(Nothing, right) Then
                Return True
            End If
            If ReferenceEquals(Nothing, left) Xor ReferenceEquals(Nothing, right) Then
                Return False
            End If
            Return (left.Name = right.Name) AndAlso (left.HealAmount = right.HealAmount) AndAlso (left.Value = right.Value)
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            Return Equals(Me, TryCast(obj, Potion))
        End Function

        Public Overloads Function Equals(otherPotion As Potion) As Boolean
            Return Equals(Me, otherPotion)
        End Function

        Public Shared Operator =(left As Potion, right As Potion) As Boolean
            Return Equals(left, right)
        End Operator

        Public Shared Operator <>(left As Potion, right As Potion) As Boolean
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

        ''' <summary>Initializes a new instance of the Potion class.</summary>
        Friend Sub New()
            Name = "None"
            HealAmount = 0
            Value = 0
        End Sub

        ''' <summary>Initializes a new instance of the Potion class using Property values.</summary>
        ''' <param name="newName">Name of Potion</param>
        ''' <param name="newHealAmount">Amount the Potion heals the User</param>
        ''' <param name="newValue">Gold value of Potion</param>
        Friend Sub New(newName As String, newHealAmount As Integer, newValue As Integer)
            Name = newName
            HealAmount = newHealAmount
            Value = newValue
        End Sub

        ''' <summary>Initializes a new instance of the Potion using another Potion.</summary>
        ''' <param name="other">Potion to replace this instance</param>
        Friend Sub New(other As Potion)
            Me.New(other.Name, other.HealAmount, other.Value)
        End Sub

#End Region

    End Class

End Namespace