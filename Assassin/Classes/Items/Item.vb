Namespace Classes.Items

    Public Class Item
        Dim _name As String
        Dim _value As Integer
        Dim _hidden As Boolean

#Region "Modifying Properties"

        Public Property Name As String
            Get
                Return _name
            End Get
            Set
                _name = Value
            End Set
        End Property

        Public Property Value As Integer
            Get
                Return _value
            End Get
            Set
                _value = Value
            End Set
        End Property

        Public Property Hidden As Boolean
            Get
                Return _hidden
            End Get
            Set
                _hidden = Value
            End Set
        End Property

#End Region

#Region "Helper Properties"

        Public ReadOnly Property ValueToString As String
            Get
                Return Value.ToString("N0")
            End Get
        End Property

#End Region

    End Class

End Namespace