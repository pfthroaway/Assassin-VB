Imports Assassin.Classes.Entities

''' <summary>Represents a <see cref="Message"/> sent to a <see cref="User"/>.</summary>
Public Class Message

    ''' <summary><see cref="User"/> who sent the <see cref="Message"/>.</summary>
    Public Property UserFrom As String

    ''' <summary><see cref="User"/> to whom the <see cref="Message"/> is written.</summary>
    Public Property UserTo As String

    ''' <summary>What the <see cref="Message"/> says.</summary>
    Public Property Contents As String

    ''' <summary>Date the <see cref="Message"/> was sent.</summary>
    Public Property DateSent As Date

    ''' <summary>Was this <see cref="Message"/> sent by a guild leader?</summary>
    Public Property GuildMessage As Boolean

    ''' <summary>Constructs a new instance of <see cref="Message"/> by assigning property values.</summary>
    ''' <param name="sentFrom"><see cref="User"/> who sent the <see cref="Message"/></param>
    ''' <param name="sentTo"><see cref="User"/> to whom the <see cref="Message"/> is written</param>
    ''' <param name="msg">What the <see cref="Message"/> says</param>
    ''' <param name="sent">Date the <see cref="Message"/> was sent</param>
    ''' <param name="guildMsg">Was this <see cref="Message"/> sent by a guild leader?</param>
    Public Sub New(sentFrom As String, sentTo As String, msg As String, sent As Date, guildMsg As Boolean)
        UserFrom = sentFrom
        UserTo = sentTo
        Contents = msg
        DateSent = sent
        GuildMessage = guildMsg
    End Sub

    ''' <summary>Constructs a new instance of <see cref="Message"/> by copying another <see cref="Message"/>.</summary>
    ''' <param name="other"><see cref="Message"/> to be copied</param>
    Public Sub New(other As Message)
        UserFrom = other.UserFrom
        UserTo = other.UserTo
        Contents = other.Contents
        DateSent = other.DateSent
        GuildMessage = other.GuildMessage
    End Sub

End Class