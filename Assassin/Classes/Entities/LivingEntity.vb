﻿Option Strict On
Option Explicit On

Imports Extensions.DataTypeHelpers

''' <summary>Represents a living entity in Assassin.</summary>
Public MustInherit Class LivingEntity

#Region "Modifying Properties"

    ''' <summary>Name of the Entity.</summary>
    Public Property Name As String

    ''' <summary>Level of the Entity.</summary>
    Public Property Level As Integer

    ''' <summary>Current Endurance of the Entity.</summary>
    Public Property CurrentEndurance As Integer

    ''' <summary>Maximum Endurance of the Entity.</summary>
    Public Property MaximumEndurance As Integer

    ''' <summary>Gold the Entity has on hand.</summary>
    Public Property GoldOnHand As Integer

    ''' <summary>Blocking skill of the Entity.</summary>
    Public Property Blocking As Integer

    ''' <summary>Slipping skill of the Entity.</summary>
    Public Property Slipping As Integer

#End Region

#Region "Helper Properties"

    ''' <summary>Level of the Entity.</summary>
    Public ReadOnly Property EnduranceToString As String
        Get
            Return $"{CurrentEndurance:N0} / {MaximumEndurance:N0}"
        End Get
    End Property

    ''' <summary>Ratio of current to maximum endurance.</summary>
    Public ReadOnly Property EnduranceRatio As Decimal
        Get
            Return DecimalHelper.Parse(CurrentEndurance / MaximumEndurance)
        End Get
    End Property

#End Region

End Class