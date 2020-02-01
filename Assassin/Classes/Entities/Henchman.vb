' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Henchmanm.vb
' Description     : This forms contains the statistics of Henchmen for raiding.

Option Strict On
Option Explicit On

Namespace Classes.Entities

    Public Class Henchman
        Dim _level As Integer       'current highest henchman level

        Public Property Level As Integer
            Get
                Return _level
            End Get
            Set(value As Integer)
                _level = value
                Health = value * 2
                Damage = value
                WeaponSkill = value * 2
                Blocking = value
            End Set
        End Property

        Public Property Health As Integer

        Public Property Damage As Integer

        Public Property WeaponSkill As Integer

        Public Property Blocking As Integer

        Public Property Number As Integer

        Public Property HenchmenLevel1 As Integer

        Public Property HenchmenLevel2 As Integer

        Public Property HenchmenLevel3 As Integer

        Public Property HenchmenLevel4 As Integer

        Public Property HenchmenLevel5 As Integer

    End Class

End Namespace