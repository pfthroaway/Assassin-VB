Imports Assassin.Classes.Entities

Namespace Classes.Items

    ''' <summary>Represents a <see cref="Potion"/> that can be consumed to heal a <see cref="LivingEntity"/>.</summary>
    Public Class Potion
        Inherits Item

#Region "Properties"

        ''' <summary>The amount of health the <see cref="Potion"/> will heal.</summary>
        Public Property HealAmount As Integer

#End Region

#Region "Override Operators"

        Public Overloads Shared Function Equals(left As Potion, right As Potion) As Boolean
            If left Is Nothing AndAlso right Is Nothing Then
                Return True
            End If
            If left Is Nothing Xor right Is Nothing Then
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

        ''' <summary>Initializes a new instance of the <see cref="Potion"/> class.</summary>
        Friend Sub New()
            Name = "None"
            HealAmount = 0
            Value = 0
        End Sub

        ''' <summary>Initializes a new instance of the <see cref="Potion"/> class using Property values.</summary>
        ''' <param name="newName">Name of the <see cref="Potion"/></param>
        ''' <param name="newHealAmount">Amount of health the <see cref="Potion"/> will heal</param>
        ''' <param name="newValue">Gold value of <see cref="Potion"/></param>
        Friend Sub New(newName As String, newHealAmount As Integer, newValue As Integer)
            Name = newName
            HealAmount = newHealAmount
            Value = newValue
        End Sub

        ''' <summary>Initializes a new instance of the <see cref="Potion"/> using another <see cref="Potion"/>.</summary>
        ''' <param name="other"><see cref="Potion"/> to replace this instance</param>
        Friend Sub New(other As Potion)
            Me.New(other.Name, other.HealAmount, other.Value)
        End Sub

#End Region

    End Class

End Namespace