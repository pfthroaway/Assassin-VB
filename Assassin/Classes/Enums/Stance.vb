Namespace Classes.Enums

    ''' <summary>Represents a <see cref="Stance"/> that can be taken during a round of battle.</summary>
    Public Enum Stance

        ''' <summary>1 stamina cost, 1x weapon damage</summary>
        Normal

        ''' <summary>2 stamina cost, 2x weapon damage</summary>
        Berserk

        ''' <summary>1 stamina cost, 1.5x damage, 1/2 defense</summary>
        Lunge

        ''' <summary>0 stamina cost, potentially 1x damage</summary>
        Parry

        ''' <summary>1 stamina cost, chance to run away</summary>
        Flee

        ''' <summary>Regain 1 stamina, 2x defense</summary>
        Defend

    End Enum

End Namespace