' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Enemy.vb
' Description     : This class holds the statistics for an Enemy.

Option Strict On
Option Explicit On

Imports Assassin.Classes.Items

Namespace Classes.Entities

    Public Class Enemy
        Private _name As String

        Private _level As Integer, _currentEndurance As Integer, _maximumEndurance As Integer, _goldOnHand As Integer, _weaponSkill As Integer, _blocking As Integer,
                _slipping As Integer

        Private _weapon As New Weapon()
        Private _armor As New Armor()

#Region "Properties"

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set
                _name = Value
            End Set
        End Property

        Public Property Level() As Integer
            Get
                Return _level
            End Get
            Set
                _level = Value
            End Set
        End Property

        Public Property CurrentEndurance() As Integer
            Get
                Return _currentEndurance
            End Get
            Set
                _currentEndurance = Value
            End Set
        End Property

        Public Property MaximumEndurance() As Integer
            Get
                Return _maximumEndurance
            End Get
            Set
                _maximumEndurance = Value
            End Set
        End Property

        Public ReadOnly Property EnduranceToString() As String
            Get
                Return CurrentEndurance.ToString("N0") + " / " + MaximumEndurance.ToString("N0")
            End Get
        End Property

        Public Property Weapon() As Weapon
            Get
                Return _weapon
            End Get
            Set
                _weapon = Value
            End Set
        End Property

        Public Property Armor() As Armor
            Get
                Return _armor
            End Get
            Set
                _armor = Value
            End Set
        End Property

        Public Property GoldOnHand() As Integer
            Get
                Return _goldOnHand
            End Get
            Set
                _goldOnHand = Value
            End Set
        End Property

        Public Property WeaponSkill() As Integer
            Get
                Return _weaponSkill
            End Get
            Set
                _weaponSkill = Value
            End Set
        End Property

        Public Property Blocking() As Integer
            Get
                Return _blocking
            End Get
            Set
                _blocking = Value
            End Set
        End Property

        Public Property Slipping() As Integer
            Get
                Return _slipping
            End Get
            Set
                _slipping = Value
            End Set
        End Property

#End Region

#Region "Health Manipulation"

        ''' <summary>The Enemy takes damage.</summary>
        ''' <param name="damage">Amount of damage taken.</param>
        ''' <returns>String saying the Enemy took damage</returns>
        Friend Function TakeDamage(damage As Integer) As String
            CurrentEndurance -= damage
            Return $"The {Name} takes {damage:N0} damage."
        End Function

#End Region

#Region "Override Operators"

        Public Overloads Function Equals(left As Enemy, right As Enemy) As Boolean
            If ReferenceEquals(Nothing, left) AndAlso ReferenceEquals(Nothing, right) Then
                Return True
            End If
            If ReferenceEquals(Nothing, left) Xor ReferenceEquals(Nothing, right) Then
                Return False
            End If
            Return (left.Name = right.Name) AndAlso (left.Level = right.Level) AndAlso (left.CurrentEndurance = right.CurrentEndurance) AndAlso (left.MaximumEndurance = right.MaximumEndurance) AndAlso (left.Weapon = right.Weapon) AndAlso (left.Armor = right.Armor) AndAlso (left.GoldOnHand = right.GoldOnHand) AndAlso (left.WeaponSkill = right.WeaponSkill) AndAlso (left.Blocking = right.Blocking) AndAlso (left.Slipping = right.Slipping)
        End Function

        Public Overloads Function Equals(otherEnemy As Enemy) As Boolean
            '* * * * *
            '* This method overloads the Equals function with a more simple comparison.
            '* * * * *

            Return Equals(Me, otherEnemy)
        End Function

        Public Overloads Overrides Function Equals(obj As Object) As Boolean
            '* * * * *
            '* This method overloads the Equals function with a more simple comparison.
            '* * * * *

            Return Equals(Me, TryCast(obj, Enemy))
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode() Xor 17
        End Function

        Public Shared Operator =(left As Enemy, right As Enemy) As Boolean
            Return left.Equals(right)
        End Operator

        Public Shared Operator <>(left As Enemy, right As Enemy) As Boolean
            Return Not (left = right)
        End Operator

        Public Overrides Function ToString() As String
            Return Name
        End Function

#End Region

#Region "Constructors"

        ''' <summary>Initializes a new instance of the Enemy class.</summary>
        Friend Sub New()
            Name = ""
            Level = 1
            CurrentEndurance = 100
            MaximumEndurance = 100
            Weapon = New Weapon()
            Armor = New Armor()
            GoldOnHand = 100
            WeaponSkill = 10
            Blocking = 10
            Slipping = 10
        End Sub

        ''' <summary>Initializes a new instance of the Enemy class by assigning Property values.</summary>
        ''' <param name="newName">Name of Enemy</param>
        ''' <param name="newLevel">Level of Enemy</param>
        ''' <param name="newCurrentEndurance">Amount of Endurance the Enemy currently has</param>
        ''' <param name="newMaximumEndurance">Maximum amount of Endurance the Enemy can have</param>
        ''' <param name="newWeapon">Weapon equipped by the Enemy</param>
        ''' <param name="newArmor">Armor equipped by the Enemy</param>
        ''' <param name="newGoldOnHand">Amount of Gold the Enemy is currently carrying</param>
        ''' <param name="newWeaponSkill">Amount of skill the Enemy has with their Weapon</param>
        ''' <param name="newBlocking">Amount of skill the Enemy has with blocking incoming attacks</param>
        ''' <param name="newSlipping">Amount of skill the Enemy has with dodging attacks and fleeing battles</param>
        Friend Sub New(newName As String, newLevel As Integer, newCurrentEndurance As Integer, newMaximumEndurance As Integer, newWeapon As Weapon, newArmor As Armor, newGoldOnHand As Integer, newWeaponSkill As Integer, newBlocking As Integer, newSlipping As Integer)
            Name = newName
            Level = newLevel
            CurrentEndurance = newCurrentEndurance
            MaximumEndurance = newMaximumEndurance
            Weapon = newWeapon
            Armor = newArmor
            GoldOnHand = newGoldOnHand
            WeaponSkill = newWeaponSkill
            Blocking = newBlocking
            Slipping = newSlipping
        End Sub

        ''' <summary>
        ''' Replaces this instance of Enemy with another instance.
        ''' </summary>
        ''' <param name="otherEnemy">Enemy to replace this instance</param>
        Friend Sub New(otherEnemy As Enemy)
            Name = otherEnemy.Name
            Level = otherEnemy.Level
            CurrentEndurance = otherEnemy.CurrentEndurance
            MaximumEndurance = otherEnemy.MaximumEndurance
            Weapon = otherEnemy.Weapon
            Armor = otherEnemy.Armor
            GoldOnHand = otherEnemy.GoldOnHand
            WeaponSkill = otherEnemy.WeaponSkill
            Blocking = otherEnemy.Blocking
            Slipping = otherEnemy.Slipping
        End Sub

#End Region

    End Class

End Namespace