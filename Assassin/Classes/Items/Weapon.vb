' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Weapon.vb
' Description     : This form contains the statistics for a Weapon.

Option Strict On
Option Explicit On

Imports Assassin.Classes.Enums

Namespace Classes.Items

    Public Class Weapon
        Inherits Item
        Private _damage As Integer
        Private _type As WeaponType

        Public Property Damage As Integer
            Get
                Return _damage
            End Get
            Set(val As Integer)
                _damage = val
            End Set
        End Property

        Public Property Type As WeaponType
            Get
                Return _type
            End Get
            Set
                _type = Value
            End Set
        End Property

#Region "Override Operators"

        Public Overloads Function Equals(left As Weapon, right As Weapon) As Boolean
            If ReferenceEquals(Nothing, left) AndAlso ReferenceEquals(Nothing, right) Then
                Return True
            End If
            If ReferenceEquals(Nothing, left) Xor ReferenceEquals(Nothing, right) Then
                Return False
            End If
            Return (left.Name = right.Name) AndAlso (left.Damage = right.Damage) AndAlso (left.Value = right.Value) AndAlso (left.Hidden = right.Hidden)
        End Function

        Public Overloads Function Equals(otherWeapon As Weapon) As Boolean
            '* * * * *
            '* This method overloads the Equals function with a more simple comparison.
            '* * * * *

            Return Equals(Me, otherWeapon)
        End Function

        Public Overloads Overrides Function Equals(obj As Object) As Boolean
            '* * * * *
            '* This method overloads the Equals function with a more simple comparison.
            '* * * * *

            Return Equals(Me, TryCast(obj, Weapon))
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode() Xor 17
        End Function

        Public Shared Operator =(left As Weapon, right As Weapon) As Boolean
            Return left.Equals(right)
        End Operator

        Public Shared Operator <>(left As Weapon, right As Weapon) As Boolean
            Return Not (left = right)
        End Operator

        Public Overrides Function ToString() As String
            Return Name
        End Function

#End Region

#Region "Constructors"

        ''' <summary>Initializes a default instance of Weapon.</summary>
        Public Sub New()
            Name = "Hands"
            Damage = 4
            Value = 0
            Hidden = False
        End Sub

        ''' <summary>Initializes a new instance of Weapon by assigning Property values.</summary>
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

        ''' <summary>Replaces this instance of Weapon with a new instance.</summary>
        ''' <param name="otherWeapon">Instance of Weapon to replace this instance.</param>
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