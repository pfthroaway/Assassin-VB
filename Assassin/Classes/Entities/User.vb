' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : User.vb
' Description     : This form contains the statistics for a User.

Option Strict On
Option Explicit On

Imports Assassin.Classes.Enums
Imports Assassin.Classes.Items

Namespace Classes.Entities

    ''' <summary>Represents a character in the game.</summary>
    Public Class User
        Inherits LivingEntity

#Region "Modifying Properties"

        Public Property Password As String

        Public Property Experience As Integer

        Public Property SkillPoints As Integer

        Public Property Alive As Boolean

        Public Property CurrentLocation As String

        Public Property Hunger As Integer

        Public Property Thirst As Integer

        Public Property CurrentWeaponType As WeaponType

        Public Property LightWeapon As Weapon

        Public Property HeavyWeapon As Weapon

        Public Property TwoHandedWeapon As Weapon

        Public Property Armor As New Armor()

        Public Property Potion As Potion

        Public Property Lockpicks As Integer

        Public Property Shovel As Boolean

        Public Property Lantern As Boolean

        Public Property Amulet As Boolean

        Public Property GoldInBank As Integer

        Public Property GoldOnLoan As Integer

        Public Property LightWeaponSkill As Integer

        Public Property HeavyWeaponSkill As Integer

        Public Property TwoHandedWeaponSkill As Integer

        Public Property Stealth As Integer

        Public Property HenchmenLevel1 As Integer

        Public Property HenchmenLevel2 As Integer

        Public Property HenchmenLevel3 As Integer

        Public Property HenchmenLevel4 As Integer

        Public Property HenchmenLevel5 As Integer

#End Region

#Region "Helper Properties"

        Public ReadOnly Property CurrentWeapon As Weapon
            Get
                Select Case (CurrentWeaponType)
                    Case WeaponType.Light
                        Return LightWeapon
                    Case WeaponType.Heavy
                        Return HeavyWeapon
                    Case WeaponType.TwoHanded
                        Return TwoHandedWeapon
                End Select
                Return New Weapon()
            End Get
        End Property

        Public ReadOnly Property CurrentWeaponSkill As Integer
            Get
                Select Case CurrentWeaponType
                    Case WeaponType.Light
                        Return LightWeaponSkill
                    Case WeaponType.Heavy
                        Return HeavyWeaponSkill
                    Case WeaponType.TwoHanded
                        Return TwoHandedWeaponSkill
                End Select
                Return 10
            End Get
        End Property

        Public ReadOnly Property Rank As String
            Get
                Return AllRanks(Level)
            End Get
        End Property

        Public ReadOnly Property SkillPointsToString As String
            Get
                Return $"{SkillPoints:N0} Skill Points Available"
            End Get
        End Property

        Public ReadOnly Property SelectedWeapon As Weapon
            Get
                Dim newWeapon As New Weapon()
                Select Case CurrentWeaponType
                    Case WeaponType.Light
                        newWeapon = LightWeapon
                        Exit Select

                    Case WeaponType.Heavy
                        newWeapon = HeavyWeapon
                        Exit Select

                    Case WeaponType.TwoHanded
                        newWeapon = TwoHandedWeapon
                        Exit Select
                End Select
                Return newWeapon
            End Get
        End Property

        Public ReadOnly Property GoldInBankToString As String
            Get
                Return GoldInBank.ToString("N0")
            End Get
        End Property

        Public ReadOnly Property GoldOnLoanToString As String
            Get
                Return GoldOnLoan.ToString("N0")
            End Get
        End Property

        Public ReadOnly Property GoldOnHandToString As String
            Get
                Return GoldOnHand.ToString("N0")
            End Get
        End Property

        Public ReadOnly Property LoanAvailable As Integer
            Get
                Return (Level * 250) - GoldOnLoan
            End Get
        End Property

        Public ReadOnly Property LoanAvailableToString As String
            Get
                Return ((Level * 250) - GoldOnLoan).ToString("N0")
            End Get
        End Property

#End Region

        ''' <summary>Gains experience for the User.</summary>
        ''' <param name="experienceGain">Experience gained</param>
        ''' <returns>String based on experience gain</returns>
        Friend Function GainExperience(experienceGain As Integer) As String
            Dim oldExperience As Integer = Experience
            Dim experienceText As String = $"You have earned {experienceGain} experience from the battle."
            Dim levelText As String = ""

            Experience += experienceGain
            If oldExperience / 10 < Experience / 10 Then
                Level += 1
                levelText = $" You have gained a level! You are now a {Rank}!"
            End If

            'if past maximum exp
            If Experience > 100 Then
                'set to maximum
                Experience = 100
            End If

            Return experienceText & levelText
        End Function

#Region "Health Manipulation"

        ''' <summary>The User heals damage.</summary>
        ''' <param name="healAmount">Amount of health restored.</param>
        ''' <returns>String saying you took damage</returns>
        Friend Function Heal(healAmount As Integer) As String
            CurrentEndurance += healAmount
            If CurrentEndurance > MaximumEndurance Then
                CurrentEndurance = MaximumEndurance
            End If
            Return $"You heal for {healAmount:N0} damage."
        End Function

        ''' <summary>The User takes damage.</summary>
        ''' <param name="damage">Amount of damage taken.</param>
        ''' <returns>String saying you took damage</returns>
        Friend Function TakeDamage(damage As Integer) As String
            CurrentEndurance -= damage
            Return $"You take {damage:N0} damage."
        End Function

#End Region

#Region "Override Operators"

        Public Overloads Function Equals(left As User, right As User) As Boolean
            If ReferenceEquals(Nothing, left) AndAlso ReferenceEquals(Nothing, right) Then
                Return True
            End If
            If ReferenceEquals(Nothing, left) Xor ReferenceEquals(Nothing, right) Then
                Return False
            End If
            Return (left.Name = right.Name) AndAlso (left.Password = right.Password) AndAlso (left.Level = right.Level) AndAlso (left.Experience = right.Experience) AndAlso (left.SkillPoints = right.SkillPoints) AndAlso (left.Alive = right.Alive) AndAlso (left.CurrentLocation = right.CurrentLocation) AndAlso (left.CurrentEndurance = right.CurrentEndurance) AndAlso (left.MaximumEndurance = right.MaximumEndurance) AndAlso (left.Hunger = right.Hunger) AndAlso (left.Thirst = right.Thirst) AndAlso (left.CurrentWeaponType = right.CurrentWeaponType) AndAlso (left.LightWeapon = right.LightWeapon) AndAlso (left.HeavyWeapon = right.HeavyWeapon) AndAlso (left.TwoHandedWeapon = right.TwoHandedWeapon) AndAlso (left.Armor = right.Armor) AndAlso (left.Potion = right.Potion) AndAlso (left.Lockpicks = right.Lockpicks) AndAlso (left.GoldOnHand = right.GoldOnHand) AndAlso (left.GoldInBank = right.GoldInBank) AndAlso (left.GoldOnLoan = right.GoldOnLoan) AndAlso (left.Shovel = right.Shovel) AndAlso (left.Lantern = right.Lantern) AndAlso (left.Amulet = right.Amulet) AndAlso (left.LightWeaponSkill = right.LightWeaponSkill) AndAlso (left.HeavyWeaponSkill = right.HeavyWeaponSkill) AndAlso (left.TwoHandedWeaponSkill = right.TwoHandedWeaponSkill) AndAlso (left.Blocking = right.Blocking) AndAlso (left.Slipping = right.Slipping) AndAlso (left.Stealth = right.Stealth) AndAlso (left.HenchmenLevel1 = right.HenchmenLevel1) AndAlso (left.HenchmenLevel2 = right.HenchmenLevel2) AndAlso (left.HenchmenLevel3 = right.HenchmenLevel3) AndAlso (left.HenchmenLevel4 = right.HenchmenLevel4) AndAlso (left.HenchmenLevel5 = right.HenchmenLevel5)
        End Function

        Public Overloads Function Equals(otherUser As User) As Boolean
            '* * * * *
            '* This method overloads the Equals function with a more simple comparison.
            '* * * * *

            Return Equals(Me, otherUser)
        End Function

        Public Overloads Overrides Function Equals(obj As Object) As Boolean
            '* * * * *
            '* This method overloads the Equals function with a more simple comparison.
            '* * * * *

            Return Equals(Me, TryCast(obj, User))
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode() Xor 17
        End Function

        Public Shared Operator =(left As User, right As User) As Boolean
            Return left.Equals(right)
        End Operator

        Public Shared Operator <>(left As User, right As User) As Boolean
            Return Not (left = right)
        End Operator

        Public Overrides Function ToString() As String
            Return Name
        End Function

#End Region

#Region "Constructors"

        ''' <summary>Initializes a new instance of the User class.</summary>
        Friend Sub New()
            Name = ""
            Password = ""
            Level = 1
            Experience = 0
            SkillPoints = 5
            Alive = True
            CurrentLocation = "Streets"
            CurrentEndurance = 100
            MaximumEndurance = 100
            Hunger = 0
            Thirst = 0

            CurrentWeaponType = WeaponType.Light
            LightWeapon = New Weapon()
            HeavyWeapon = New Weapon()
            TwoHandedWeapon = New Weapon()
            Armor = New Armor()
            Potion = New Potion()
            Lockpicks = 0
            GoldOnHand = 100
            GoldInBank = 0
            GoldOnLoan = 0
            Shovel = False
            Lantern = False
            Amulet = False

            LightWeaponSkill = 10
            HeavyWeaponSkill = 10
            TwoHandedWeaponSkill = 10
            Blocking = 10
            Slipping = 10
            Stealth = 10

            HenchmenLevel1 = 0
            HenchmenLevel2 = 0
            HenchmenLevel3 = 0
            HenchmenLevel4 = 0
            HenchmenLevel5 = 0
        End Sub

        ''' <summary>Initializes a new instance of the User class using Property values.</summary>
        ''' <param name="newName">Name of User</param>
        ''' <param name="newPassword">Hashed password of User</param>
        ''' <param name="newLevel">Level of User</param>
        ''' <param name="newExperience">Amount of experience the User has</param>
        ''' <param name="newSkillPoints">Amount of skill points the User has</param>
        ''' <param name="newAlive">Is the User alive?</param>
        ''' <param name="newCurrentLocation">Location the User slept at last</param>
        ''' <param name="newCurrentEndurance">Amount of Endurance the User currently has</param>
        ''' <param name="newMaximumEndurance">Maximum amount of Endurance the User can have at the moment</param>
        ''' <param name="newHunger">Amount of hunger the User currently has</param>
        ''' <param name="newThirst">Amount of thirst the User currently has</param>
        ''' <param name="newCurrentWeapon">Type of Weapon the User currently has equipped</param>
        ''' <param name="newLightWeapon">Weapon the User has in their Light Weapon slot</param>
        ''' <param name="newHeavyWeapon">Weapon the User has in their Heavy Weapon slot</param>
        ''' <param name="newTwoHandedWeapon">Weapon the User has in their Two-Handed Weapon slot</param>
        ''' <param name="newArmor">Armor the User has equipped</param>
        ''' <param name="newPotion">Potion the User is carrying</param>
        ''' <param name="newLockpicks">Amount of lockpicks the User currently has</param>
        ''' <param name="newGoldOnHand">Amount of gold the User is currently carrying</param>
        ''' <param name="newGoldInBank">Amount of gold the User has stored in the Bank</param>
        ''' <param name="newGoldOnLoan">Amount of unpaid gold the User has borrowed from the Bank</param>
        ''' <param name="newShovel">Does the User own a shovel?</param>
        ''' <param name="newLantern">Does the User own a lantern?</param>
        ''' <param name="newAmulet">Does the User own an amulet?</param>
        ''' <param name="newLightWeaponSkill">Amount of skill the User has with Light Weapons</param>
        ''' <param name="newHeavyWeaponSkill">Amount of skill the User has with Heavy Weapons</param>
        ''' <param name="newTwoHandedWeaponSkill">Amount of skill the User has with Two-Handed Weapons</param>
        ''' <param name="newBlocking">Amount of skill the User has with blocking incoming attacks</param>
        ''' <param name="newSlipping">Amount of skill the User has with dodging attacks and fleeing battles</param>
        ''' <param name="newStealth">Amount of skill the User has with surprising opponents, theft, and hiding</param>
        ''' <param name="newHenchmenLevel1">Amount of Level 1 Henchmen employed by the User</param>
        ''' <param name="newHenchmenLevel2">Amount of Level 2 Henchmen employed by the User</param>
        ''' <param name="newHenchmenLevel3">Amount of Level 3 Henchmen employed by the User</param>
        ''' <param name="newHenchmenLevel4">Amount of Level 4 Henchmen employed by the User</param>
        ''' <param name="newHenchmenLevel5">Amount of Level 5 Henchmen employed by the User</param>
        Friend Sub New(newName As String, newPassword As String, newLevel As Integer, newExperience As Integer, newSkillPoints As Integer, newAlive As Boolean, newCurrentLocation As String, newCurrentEndurance As Integer, newMaximumEndurance As Integer, newHunger As Integer, newThirst As Integer, newCurrentWeapon As WeaponType, newLightWeapon As Weapon, newHeavyWeapon As Weapon, newTwoHandedWeapon As Weapon, newArmor As Armor, newPotion As Potion, newLockpicks As Integer, newGoldOnHand As Integer, newGoldInBank As Integer, newGoldOnLoan As Integer, newShovel As Boolean, newLantern As Boolean, newAmulet As Boolean, newLightWeaponSkill As Integer, newHeavyWeaponSkill As Integer, newTwoHandedWeaponSkill As Integer, newBlocking As Integer, newSlipping As Integer, newStealth As Integer, newHenchmenLevel1 As Integer, newHenchmenLevel2 As Integer, newHenchmenLevel3 As Integer, newHenchmenLevel4 As Integer, newHenchmenLevel5 As Integer)
            Name = newName
            Password = newPassword
            Level = newLevel
            Experience = newExperience
            SkillPoints = newSkillPoints
            Alive = newAlive
            CurrentLocation = newCurrentLocation
            CurrentEndurance = newCurrentEndurance
            MaximumEndurance = newMaximumEndurance
            Hunger = newHunger
            Thirst = newThirst

            CurrentWeaponType = newCurrentWeapon
            LightWeapon = newLightWeapon
            HeavyWeapon = newHeavyWeapon
            TwoHandedWeapon = newTwoHandedWeapon
            Armor = newArmor
            Potion = newPotion
            Lockpicks = newLockpicks
            GoldOnHand = newGoldOnHand
            GoldInBank = newGoldInBank
            GoldOnLoan = newGoldOnLoan
            Shovel = newShovel
            Lantern = newLantern
            Amulet = newAmulet

            LightWeaponSkill = newLightWeaponSkill
            HeavyWeaponSkill = newHeavyWeaponSkill
            TwoHandedWeaponSkill = newTwoHandedWeaponSkill
            Blocking = newBlocking
            Slipping = newSlipping
            Stealth = newStealth

            HenchmenLevel1 = newHenchmenLevel1
            HenchmenLevel2 = newHenchmenLevel2
            HenchmenLevel3 = newHenchmenLevel3
            HenchmenLevel4 = newHenchmenLevel4
            HenchmenLevel5 = newHenchmenLevel5
        End Sub

        ''' <summary>Initializes a new instance of the User class using another User.</summary>
        ''' <param name="otherUser">User to replace this instance.</param>
        Friend Sub New(otherUser As User)
            Name = otherUser.Name
            Password = otherUser.Password
            Level = otherUser.Level
            Experience = otherUser.Experience
            SkillPoints = otherUser.SkillPoints
            Alive = otherUser.Alive
            CurrentLocation = otherUser.CurrentLocation
            CurrentEndurance = otherUser.CurrentEndurance
            MaximumEndurance = otherUser.MaximumEndurance
            Hunger = otherUser.Hunger
            Thirst = otherUser.Thirst

            CurrentWeaponType = otherUser.CurrentWeaponType
            LightWeapon = otherUser.LightWeapon
            HeavyWeapon = otherUser.HeavyWeapon
            TwoHandedWeapon = otherUser.TwoHandedWeapon
            Armor = otherUser.Armor
            Potion = otherUser.Potion
            Lockpicks = otherUser.Lockpicks
            GoldOnHand = otherUser.GoldOnHand
            GoldInBank = otherUser.GoldInBank
            GoldOnLoan = otherUser.GoldOnLoan
            Shovel = otherUser.Shovel
            Lantern = otherUser.Lantern
            Amulet = otherUser.Amulet

            LightWeaponSkill = otherUser.LightWeaponSkill
            HeavyWeaponSkill = otherUser.HeavyWeaponSkill
            TwoHandedWeaponSkill = otherUser.TwoHandedWeaponSkill
            Blocking = otherUser.Blocking
            Slipping = otherUser.Slipping
            Stealth = otherUser.Stealth

            HenchmenLevel1 = otherUser.HenchmenLevel1
            HenchmenLevel2 = otherUser.HenchmenLevel2
            HenchmenLevel3 = otherUser.HenchmenLevel3
            HenchmenLevel4 = otherUser.HenchmenLevel4
            HenchmenLevel5 = otherUser.HenchmenLevel5
        End Sub

#End Region

    End Class

End Namespace