' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : User.vb
' Description     : This form contains the statistics for a User.

Option Strict On
Option Explicit On

Public Class User
    Private _name As String                 'username
    Private _password As String             'password
    Private _level As Integer               'current level
    Private _exp As Integer                 'current experience
    Private _skillPts As Integer            'current skill points
    Private _alive As Boolean               'currently alive
    Private _currLoc As String              'current location
    Private _currEnd As Integer             'current endurance
    Private _maxEnd As Integer              'maximum endurance
    Private _hunger As Integer              'hunger
    Private _thirst As Integer              'thirst

    'inventory
    Private _currWeapon As String           'weapon
    Private _lightWeapon As Weapon          'weapon
    Private _heavyWeapon As Weapon          'weapon
    Private _twoHWeapon As Weapon           'weapon
    Private _armor As Armor                 'armor
    Private _potion As String               'special item
    Private _lockpicks As Integer           'lockpicks
    Private _shovel As Boolean              'shovel
    Private _lantern As Boolean             'lantern
    Private _amulet As Boolean              'amulet
    Private _goldOnHand As Integer          'gold on hand
    Private _goldInBank As Integer          'gold in bank
    Private _goldOnLoan As Integer          'gold loaned to player

    'skills
    Private _lightWeaponSkill As Integer    'light weapon skill
    Private _heavyWeaponSkill As Integer    'heavy weapon skill
    Private _twoHWeaponSkill As Integer     'two handed weapon skill
    Private _blocking As Integer            'blocking skill
    Private _slipping As Integer            'slipping skill
    Private _stealth As Integer             'stealth skill

    'henchmen
    Private _hench1 As Integer           'number of level 1 henchman
    Private _hench2 As Integer           'number of level 2 henchman
    Private _hench3 As Integer           'number of level 3 henchman
    Private _hench4 As Integer           'number of level 4 henchman
    Private _hench5 As Integer           'number of level 5 henchman

    Private Function ByteToString(ByVal arrInput() As Byte) As String
        '* * * * *
        '* This function converts a byte array into a hex string.
        '* * * * *

        Dim strOutput As New System.Text.StringBuilder(arrInput.Length)

        For i As Integer = 0 To arrInput.Length - 1
            strOutput.Append(arrInput(i).ToString("X2"))
        Next

        Return strOutput.ToString().ToLower
    End Function

    Public Function MD5Hash(ByVal strPass As String) As String
        '* * * * *
        '* Encrypts a password using MD5 hash.
        '* * * * *

        Dim objMD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim arrData(), arrHash() As Byte

        arrData = System.Text.Encoding.UTF8.GetBytes(strPass)   'convert the string to bytes using UTF8
        arrHash = objMD5.ComputeHash(arrData)                   'hash contents of the byte array
        objMD5 = Nothing                                        'why do I do this?

        Return ByteToString(arrHash)                              'return formatted hash
    End Function


    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property level As Integer
        Get
            Return _level
        End Get
        Set(value As Integer)
            _level = value
        End Set
    End Property

    Public Property exp As Integer
        Get
            Return _exp
        End Get
        Set(value As Integer)
            _exp = value
        End Set
    End Property

    Public Property skillPts As Integer
        Get
            Return _skillPts
        End Get
        Set(value As Integer)
            _skillPts = value
        End Set
    End Property

    Public Property alive As Boolean
        Get
            Return _alive
        End Get
        Set(value As Boolean)
            _alive = value
        End Set
    End Property

    Public Property currLoc As String
        Get
            Return _currLoc
        End Get
        Set(value As String)
            _currLoc = value
        End Set
    End Property

    Public Property currEnd As Integer
        Get
            Return _currEnd
        End Get
        Set(value As Integer)
            _currEnd = value
        End Set
    End Property

    Public Property maxEnd As Integer
        Get
            Return _maxEnd
        End Get
        Set(value As Integer)
            _maxEnd = value
        End Set
    End Property

    Public Property hunger As Integer
        Get
            Return _hunger
        End Get
        Set(value As Integer)
            _hunger = value
        End Set
    End Property

    Public Property thirst As Integer
        Get
            Return _thirst
        End Get
        Set(value As Integer)
            _thirst = value
        End Set
    End Property

    Public Property currWeapon As String
        Get
            Return _currWeapon
        End Get
        Set(value As String)
            _currWeapon = value
        End Set
    End Property

    Public Property lightWeapon As Weapon
        Get
            Return _lightWeapon
        End Get
        Set(value As Weapon)
            _lightWeapon = value
        End Set
    End Property

    Public Property heavyWeapon As Weapon
        Get
            Return _heavyWeapon
        End Get
        Set(value As Weapon)
            _heavyWeapon = value
        End Set
    End Property

    Public Property twoHWeapon As Weapon
        Get
            Return _twoHWeapon
        End Get
        Set(value As Weapon)
            _twoHWeapon = value
        End Set
    End Property

    Public Property armor As Armor
        Get
            Return _armor
        End Get
        Set(value As Armor)
            _armor = value
        End Set
    End Property

    Public Property potion As String
        Get
            Return _potion
        End Get
        Set(value As String)
            _potion = value
        End Set
    End Property

    Public Property lockpicks As Integer
        Get
            Return _lockpicks
        End Get
        Set(value As Integer)
            _lockpicks = value
        End Set
    End Property

    Public Property shovel As Boolean
        Get
            Return _shovel
        End Get
        Set(value As Boolean)
            _shovel = value
        End Set
    End Property

    Public Property lantern As Boolean
        Get
            Return _lantern
        End Get
        Set(value As Boolean)
            _lantern = value
        End Set
    End Property

    Public Property amulet As Boolean
        Get
            Return _amulet
        End Get
        Set(value As Boolean)
            _amulet = value
        End Set
    End Property

    Public Property goldOnHand As Integer
        Get
            Return _goldOnHand
        End Get
        Set(value As Integer)
            _goldOnHand = value
        End Set
    End Property

    Public Property goldInBank As Integer
        Get
            Return _goldInBank
        End Get
        Set(value As Integer)
            _goldInBank = value
        End Set
    End Property

    Public Property goldOnLoan As Integer
        Get
            Return _goldOnLoan
        End Get
        Set(value As Integer)
            _goldOnLoan = value
        End Set
    End Property

    Public Property lightWeaponSkill As Integer
        Get
            Return _lightWeaponSkill
        End Get
        Set(value As Integer)
            _lightWeaponSkill = value
        End Set
    End Property

    Public Property heavyWeaponSkill As Integer
        Get
            Return _heavyWeaponSkill
        End Get
        Set(value As Integer)
            _heavyWeaponSkill = value
        End Set
    End Property

    Public Property twoHWeaponSkill As Integer
        Get
            Return _twoHWeaponSkill
        End Get
        Set(value As Integer)
            _twoHWeaponSkill = value
        End Set
    End Property

    Public Property blocking As Integer
        Get
            Return _blocking
        End Get
        Set(value As Integer)
            _blocking = value
        End Set
    End Property

    Public Property slipping As Integer
        Get
            Return _slipping
        End Get
        Set(value As Integer)
            _slipping = value
        End Set
    End Property

    Public Property stealth As Integer
        Get
            Return _stealth
        End Get
        Set(value As Integer)
            _stealth = value
        End Set
    End Property

    Public Property hench1 As Integer
        Get
            Return _hench1
        End Get
        Set(value As Integer)
            _hench1 = value
        End Set
    End Property

    Public Property hench2 As Integer
        Get
            Return _hench2
        End Get
        Set(value As Integer)
            _hench2 = value
        End Set
    End Property

    Public Property hench3 As Integer
        Get
            Return _hench3
        End Get
        Set(value As Integer)
            _hench3 = value
        End Set
    End Property

    Public Property hench4 As Integer
        Get
            Return _hench4
        End Get
        Set(value As Integer)
            _hench4 = value
        End Set
    End Property

    Public Property hench5 As Integer
        Get
            Return _hench5
        End Get
        Set(value As Integer)
            _hench5 = value
        End Set
    End Property


    Public Sub New()
        _name = ""                  'username
        _password = ""              'password
        _level = 1                  'current level
        _exp = 0                    'current experience
        _skillPts = 5               'current skill points
        _alive = True               'currently alive
        _currLoc = "Streets"        'current location
        _currEnd = 100              'current endurance
        _maxEnd = 100               'maximum endurance
        _hunger = 0                 'hunger
        _thirst = 0                 'thirst

        'inventory
        _currWeapon = "Light"       'weapon
        _lightWeapon = New Weapon   'weapon
        _heavyWeapon = New Weapon   'weapon
        _twoHWeapon = New Weapon    'weapon
        _armor = New Armor          'armor
        _potion = "None"            'special item
        _lockpicks = 0              'lockpicks
        _goldOnHand = 100           'gold on hand
        _goldInBank = 0             'gold in bank
        _goldOnLoan = 0             'gold loaned to player
        _shovel = False             'shovel
        _lantern = False            'lantern
        _amulet = False             'amulet

        'skills
        _lightWeaponSkill = 10      'light weapon skill
        _heavyWeaponSkill = 10      'heavy weapon skill
        _twoHWeaponSkill = 10       'two handed weapon skill
        _blocking = 10              'blocking skill
        _slipping = 10              'slipping skill
        _stealth = 10               'stealth skill

        'henchmen
        _hench1 = 0              'number of level 1 henchman
        _hench2 = 0              'number of level 2 henchman
        _hench3 = 0              'number of level 3 henchman
        _hench4 = 0              'number of level 4 henchman
        _hench5 = 0              'number of level 5 henchman
    End Sub

    Public Sub New(newUser As User)
        _name = newUser.name                            'username
        _password = newUser.password                    'password
        _level = newUser.level                          'current level
        _exp = newUser.exp                              'current experience
        _skillPts = newUser.skillPts                    'current skill points
        _alive = newUser.alive                          'currently alive
        _currLoc = newUser.currLoc                      'current location
        _currEnd = newUser.currEnd                      'current endurance
        _maxEnd = newUser.maxEnd                        'maximum endurance
        _hunger = newUser.hunger                        'hunger
        _thirst = newUser.thirst                        'thirst

        'inventory
        _currWeapon = newUser.currWeapon                'weapon
        _lightWeapon = newUser.lightWeapon              'weapon
        _heavyWeapon = newUser.heavyWeapon              'weapon
        _twoHWeapon = newUser.twoHWeapon                'weapon
        _armor = newUser.armor                          'armor
        _potion = newUser.potion                        'special item
        _lockpicks = newUser.lockpicks                  'lockpicks
        _goldOnHand = newUser.goldOnHand                'gold on hand
        _goldInBank = newUser.goldInBank                'gold in bank
        _goldOnLoan = newUser.goldOnLoan                'gold loaned to player
        _shovel = newUser.shovel                        'shovel
        _lantern = newUser.lantern                      'lantern
        _amulet = newUser.amulet                        'amulet

        'skills
        _lightWeaponSkill = newUser.lightWeaponSkill    'light weapon skill
        _heavyWeaponSkill = newUser.heavyWeaponSkill    'heavy weapon skill
        _twoHWeaponSkill = newUser.twoHWeaponSkill      'two handed weapon skill
        _blocking = newUser.blocking                    'blocking skill
        _slipping = newUser.slipping                    'slipping skill
        _stealth = newUser.stealth                      'stealth skill

        'henchmen
        _hench1 = newUser.hench1                  'number of level 1 henchman
        _hench2 = newUser.hench2                  'number of level 2 henchman
        _hench3 = newUser.hench3                  'number of level 3 henchman
        _hench4 = newUser.hench4                  'number of level 4 henchman
        _hench5 = newUser.hench5                  'number of level 5 henchman
    End Sub
End Class