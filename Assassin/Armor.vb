' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Armor.vb
' Description     : This class contains the statistics of Armor.

Option Strict On
Option Explicit On

Public Class Armor
    Private funcs As New Functions  'new Functions instance
    Private _name As String         'armor name
    Private _defense As Integer     'armor defense
    Private _value As Integer       'armor value

    Public Property name() As String
        Get
            Return _name
        End Get
        Set(val As String)
            _name = val
        End Set
    End Property

    Public Property defense As Integer
        Get
            Return _defense
        End Get
        Set(val As Integer)
            _defense = val
        End Set
    End Property

    Public Property value As Integer
        Get
            Return _value
        End Get
        Set(val As Integer)
            _value = val
        End Set
    End Property


    Public Overloads Function Equals(ByVal newArmor As Armor) As Boolean
        '* * * * *
        '* This method overloads the Equals function with a more simple comparison.
        '* * * * *

        Return _name = newArmor.name
    End Function

    Public Function purchase(ByVal newArmor As Armor) As Integer
        '* * * * *
        '* This method purchases a new armor.
        '* * * * *

        _name = newArmor.name
        _defense = newArmor.defense
        _value = newArmor.value

        Return _value
    End Function

    Public Function sell() As Integer
        '* * * * *
        '* This method sells the current armor.
        '* * * * *

        Dim val As Integer = _value
        _name = "Clothes"
        getDefense()
        _value = 0

        Return (val \ 2)
    End Function


    Private Sub getDefense()
        '* * * * *
        '* This method gets the defensive value of the current armor.
        '* * * * *

        Dim sql As String = "SELECT * FROM Armor Where ArmorName='" & _name & "'"
        Dim table As String = "Armor"
        Dim ds As DataSet = funcs.fillDS(sql, table)
        Integer.TryParse(ds.Tables("Armor").Rows(0).Item("ArmorDefense").ToString, _defense)
    End Sub

    Public Sub New()
        '* * * * *
        '* This method gets a new armor.
        '* * * * *

        _name = "Clothes"
        getDefense()
        _value = 0
    End Sub

    Public Sub New(ByVal newArmor As Armor)
        '* * * * *
        '* This method gets a new armor based on another armor.
        '* * * * *

        _name = newArmor.name
        _defense = newArmor.defense
        _value = newArmor.value
    End Sub

    Public Sub New(ByVal name As String, ByVal defense As Integer, ByVal val As Integer)
        '* * * * *
        '* This method gets a new armor with everything specified.
        '* * * * *

        _name = name
        _defense = defense
        _value = val
    End Sub
End Class