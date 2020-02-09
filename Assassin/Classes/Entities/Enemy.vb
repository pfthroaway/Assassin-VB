Option Strict On
Option Explicit On

Imports Assassin.Classes.Items

Namespace Classes.Entities

    ''' <summary>Represents an <see cref="Enemy"/> that the <see cref="User"/> fights.</summary>
    Public Class Enemy
        Inherits LivingEntity

#Region "Modifying Properties"

        ''' <summary>The <see cref="Enemy"/>'s Weapon.</summary>
        Public Property Weapon As New Weapon()

        ''' <summary>The <see cref="Enemy"/>'s Armor.</summary>
        Public Property Armor As New Armor()

        ''' <summary>The <see cref="Enemy"/>'s skill with their Weapon.</summary>
        Public Property WeaponSkill As Integer

#End Region

#Region "Health Manipulation"

        ''' <summary>The <see cref="Enemy"/> takes damage.</summary>
        ''' <param name="damage">Amount of damage taken.</param>
        ''' <returns>String saying the <see cref="Enemy"/> took damage</returns>
        Friend Function TakeDamage(damage As Integer) As String
            CurrentEndurance -= damage
            Return $"The {Name} takes {damage:N0} damage."
        End Function

#End Region

#Region "Override Operators"

        Public Overloads Function Equals(left As Enemy, right As Enemy) As Boolean
            If left Is Nothing AndAlso right Is Nothing Then
                Return True
            End If
            If left Is Nothing Xor right Is Nothing Then
                Return False
            End If
            Return (left.Name = right.Name) AndAlso (left.Level = right.Level) AndAlso (left.CurrentEndurance = right.CurrentEndurance) AndAlso (left.MaximumEndurance = right.MaximumEndurance) AndAlso (left.Weapon = right.Weapon) AndAlso (left.Armor = right.Armor) AndAlso (left.GoldOnHand = right.GoldOnHand) AndAlso (left.WeaponSkill = right.WeaponSkill) AndAlso (left.Blocking = right.Blocking) AndAlso (left.Slipping = right.Slipping)
        End Function

        Public Overloads Function Equals(otherEnemy As Enemy) As Boolean
            Return Equals(Me, otherEnemy)
        End Function

        Public Overloads Overrides Function Equals(obj As Object) As Boolean
            Return Equals(Me, TryCast(obj, Enemy))
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode() Xor 17
        End Function

        Public Shared Operator =(left As Enemy, right As Enemy) As Boolean
            Return left.Equals(right)
        End Operator

        Public Shared Operator <>(left As Enemy, right As Enemy) As Boolean
            Return Not left = right
        End Operator

        Public Overrides Function ToString() As String
            Return Name
        End Function

#End Region

#Region "Constructors"

        ''' <summary>Initializes a new instance of the <see cref="Enemy"/> class.</summary>
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

        ''' <summary>Initializes a new instance of the <see cref="Enemy"/> class by assigning Property values.</summary>
        ''' <param name="newName">Name of <see cref="Enemy"/></param>
        ''' <param name="newLevel">Level of <see cref="Enemy"/></param>
        ''' <param name="newCurrentEndurance">Amount of Endurance the <see cref="Enemy"/> currently has</param>
        ''' <param name="newMaximumEndurance">Maximum amount of Endurance the <see cref="Enemy"/> can have</param>
        ''' <param name="newWeapon">Weapon equipped by the <see cref="Enemy"/></param>
        ''' <param name="newArmor">Armor equipped by the <see cref="Enemy"/></param>
        ''' <param name="newGoldOnHand">Amount of Gold the <see cref="Enemy"/> is currently carrying</param>
        ''' <param name="newWeaponSkill">Amount of skill the <see cref="Enemy"/> has with their Weapon</param>
        ''' <param name="newBlocking">Amount of skill the <see cref="Enemy"/> has with blocking incoming attacks</param>
        ''' <param name="newSlipping">Amount of skill the <see cref="Enemy"/> has with dodging attacks and fleeing battles</param>
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

        ''' <summary>Replaces this instance of <see cref="Enemy"/> with another instance.</summary>
        ''' <param name="otherEnemy"><see cref="Enemy"/> to replace this instance</param>
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