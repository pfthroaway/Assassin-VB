Option Strict On
Option Explicit On

Imports Assassin.Classes.Enums

Namespace Classes.Items

    ''' <summary>Represents a <see cref="Weapon"/> that can do damage in a battle.</summary>
    Public Class Weapon
        Inherits Item

        ''' <summary>Amount of damage the <see cref="Weapon"/> does.</summary>
        Public Property Damage As Integer

        ''' <summary>Amount of damage the <see cref="Armor"/> does, formatted.</summary>
        Public ReadOnly Property DamageToString As String
            Get
                Return Damage.ToString("N0")
            End Get
        End Property

        ''' <summary>The <see cref="WeaponType"/> of the <see cref="Weapon"/>.</summary>
        Public Property Type As WeaponType

#Region "Override Operators"

        Public Overloads Function Equals(left As Weapon, right As Weapon) As Boolean
            If left Is Nothing AndAlso right Is Nothing Then
                Return True
            End If
            If left Is Nothing Xor right Is Nothing Then
                Return False
            End If
            Return (left.Name = right.Name) AndAlso (left.Damage = right.Damage) AndAlso (left.Value = right.Value) AndAlso (left.Hidden = right.Hidden)
        End Function

        Public Overloads Function Equals(otherWeapon As Weapon) As Boolean
            Return Equals(Me, otherWeapon)
        End Function

        Public Overloads Overrides Function Equals(obj As Object) As Boolean
            Return Equals(Me, TryCast(obj, Weapon))
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode() Xor 17
        End Function

        Public Shared Operator =(left As Weapon, right As Weapon) As Boolean
            Return left.Equals(right)
        End Operator

        Public Shared Operator <>(left As Weapon, right As Weapon) As Boolean
            Return Not left = right
        End Operator

        Public Overrides Function ToString() As String
            Return Name
        End Function

#End Region

#Region "Constructors"

        ''' <summary>Initializes a default instance of <see cref="Weapon"/>.</summary>
        Public Sub New()
            Name = "Hands"
            Damage = 4
            Value = 0
            Hidden = False
        End Sub

        ''' <summary>Initializes a new instance of <see cref="Weapon"/> by assigning Property values.</summary>
        ''' <param name="newName">Name</param>
        ''' <param name="newDamage">Damage</param>
        ''' <param name="newValue">Value</param>
        ''' <param name="newHidden">Hidden?</param>
        ''' <param name="newType">Type</param>
        Public Sub New(newName As String, newDamage As Integer, newValue As Integer, newHidden As Boolean, newType As WeaponType)
            Name = newName
            Damage = newDamage
            Value = newValue
            Hidden = newHidden
            Type = newType
        End Sub

        ''' <summary>Replaces this instance of <see cref="Weapon"/> with a new instance.</summary>
        ''' <param name="otherWeapon">Instance of <see cref="Weapon"/> to replace this instance.</param>
        Public Sub New(otherWeapon As Weapon)
            Name = otherWeapon.Name
            Damage = otherWeapon.Damage
            Value = otherWeapon.Value
            Hidden = otherWeapon.Hidden
            Type = otherWeapon.Type
        End Sub

#End Region

    End Class

End Namespace