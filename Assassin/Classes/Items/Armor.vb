' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Armor.vb
' Description     : This class contains the statistics of Armor.

Option Strict On
Option Explicit On

Namespace Classes.Items

    Public Class Armor
        Inherits Item

        ''' <summary>The amount of defense the <see cref="Armor"/> has.</summary>
        Public Property Defense As Integer

        ''' <summary>The amount of defense the <see cref="Armor"/> has, formatted.</summary>
        Public ReadOnly Property DefenseToString As String
            Get
                Return Defense.ToString("N0")
            End Get
        End Property

#Region "Override Operators"

        Public Overloads Function Equals(left As Armor, right As Armor) As Boolean
            If left Is Nothing AndAlso right Is Nothing Then
                Return True
            End If
            If left Is Nothing Xor right Is Nothing Then
                Return False
            End If
            Return (left.Name = right.Name) AndAlso (left.Defense = right.Defense) AndAlso (left.Value = right.Value) AndAlso (left.Hidden = right.Hidden)
        End Function

        Public Overloads Function Equals(otherArmor As Armor) As Boolean
            Return Equals(Me, otherArmor)
        End Function

        Public Overloads Overrides Function Equals(obj As Object) As Boolean
            Return Equals(Me, TryCast(obj, Armor))
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode() Xor 17
        End Function

        Public Shared Operator =(left As Armor, right As Armor) As Boolean
            Return left.Equals(right)
        End Operator

        Public Shared Operator <>(left As Armor, right As Armor) As Boolean
            Return Not left = right
        End Operator

        Public Overrides Function ToString() As String
            Return Name
        End Function

#End Region

#Region "Constructors"

        ''' <summary>Initializes a default instance of <see cref="Armor"/>.</summary>
        Public Sub New()
            Name = "Clothes"
            Defense = 4
            Value = 0
            Hidden = False
        End Sub

        ''' <summary>Initializes a new instance of <see cref="Armor"/> by assigning Property values.</summary>
        ''' <param name="newName">Name</param>
        ''' <param name="newDefense">Defense</param>
        ''' <param name="newValue">Value</param>
        ''' <param name="newHidden">Hidden?</param>
        Public Sub New(newName As String, newDefense As Integer, newValue As Integer, newHidden As Boolean)
            Name = newName
            Defense = newDefense
            Value = newValue
            Hidden = newHidden
        End Sub

        ''' <summary>Replaces this instance of <see cref="Armor"/> with a new instance.</summary>
        ''' <param name="otherArmor">Instance of <see cref="Armor"/> to replace this instance.</param>
        Public Sub New(otherArmor As Armor)
            Name = otherArmor.Name
            Defense = otherArmor.Defense
            Value = otherArmor.Value
            Hidden = otherArmor.Hidden
        End Sub

#End Region

    End Class

End Namespace