Namespace Classes.Items

    ''' <summary>Represents an <see cref="Item"/> that can be carried or used.</summary>
    Public Class Item

#Region "Modifying Properties"

        ''' <summary>The name of the <see cref="Item"/>.</summary>
        Public Property Name As String

        ''' <summary>The value of the <see cref="Item"/>.</summary>
        Public Property Value As Integer

        ''' <summary>Is the <see cref="Item"/> hidden from being sold?</summary>
        Public Property Hidden As Boolean

#End Region

#Region "Helper Properties"

        ''' <summary>The value of the <see cref="Item"/>, formatted.</summary>
        Public ReadOnly Property ValueToString As String
            Get
                Return Value.ToString("N0")
            End Get
        End Property
        ''' <summary>The sell value of the <see cref="Item"/>.</summary>
        Public ReadOnly Property SellValue As Integer
            Get
                Return Value \ 2
            End Get
        End Property

        ''' <summary>The sell value of the <see cref="Item"/>, formatted.</summary>
        Public ReadOnly Property SellValueToString As String
            Get
                Return SellValue.ToString("N0")
            End Get
        End Property
#End Region

    End Class

End Namespace