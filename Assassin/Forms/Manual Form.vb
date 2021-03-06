﻿Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms

    Public Class FrmManual

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtManual, newText)
        End Sub

#Region "Display"

        ''' <summary>Displays information about the City.</summary>
        Private Sub City()
            AddText(" * * * THE CITY * * * ")
            AddText("")

            AddText("ASSASSINATE - This command puts your assassin in the position to watch for a promising target.")
            AddText("If you are successful, you will gain experience, skill, and money.")
            AddText("If not, you maybe lucky to escape with your life!")
            AddText("")

            AddText("BANK - For your finacial needs the bank is here.")
            AddText("You can take out a loan, make a deposit to your account, check your current balances, as well as a few other interesting things.")
            AddText("")

            AddText("GUILDS - Guilds provide a fairly safe place to stay overnight, as well as opportunities to get paid for assassinations.")
            AddText("You can even begin recruiting the henchmen you will need later in the game.")
            AddText("Each guild has an initiation fee you must pay to join.")
            AddText("All new players are given a complimentary membership to the Master's Tavern.")
            AddText("This should be taken advantage of.")
            AddText("One advantage is that the job offerings provided give a good source of income.")
            AddText("")

            AddText("INN - After a hard day of assassinations and walking around the city, an assassin tends to get tired and worn out.")
            AddText("The Inn is here to serve your full needs for protection and privacy.")
            AddText("You can either nap to regain some lost endurance or spend the night and be well protected.")
            AddText("Inns also provide a messenger service, along with the daily newspaper.")

            AddText("JAIL - Take a look at all the Assassin's who've been caught in their illegal activities.  You can even BAIL them out!")
            AddText("")

            AddText("ALCHEMIST'S LABORATORY - The lab is here for those that wish a speedy recovery after a long, grueling battle.")
            AddText("They currently are working on potions that will cause your system to heal quickly.")
            AddText("If you purchase a potion, you can either drink it there or take it along until you may really need it.")
            AddText("Be warned though, not all potions are beneficial.  Some can even be harmful!")
            AddText("")

            AddText("OTHER ASSASSINS - This will give you a list of all the living assassins that currently make their stay in the city and that you may encounter in the future.")
            AddText("")

            AddText("PUB - When you are hungry or thirsty, stop by the pub, it aims to please.")

            AddText("ROB SOMEONE - If you need some money, you may prefer to steal it rather than fight for it.")
            AddText("Your methods are simple: Waylay an opponent, or Pickpocket your victim.")
            AddText("Waylaying usually yields more than picking, but pickpocketing is far less dangerous.")

            AddText("SHOPS - More than likely you will visit here a good few times.")
            AddText("There are many places to shop, to satisfy many needs.")
            AddText("Window-shopping is acceptable, however stealing is quite punishable.")

            AddText("TRAINING GROUNDS - Here's where you begin and should visit often during the game.")
            AddText("The training grounds offer courses in offensive and defensive skills by using your accumulated skill points for training sessions.")

        End Sub

        ''' <summary>Clears the Textbox.</summary>
        Private Sub Clear()
            TxtManual.Clear()
        End Sub

        ''' <summary>Displays information about Combat.</summary>
        Private Sub Combat()
            AddText(" * * * COMBAT * * * ")
            AddText("")

            AddText("In all assassinations and even some raids you may find yourself locked into mortal combat.")
            AddText("To destroy or be destroyed, that is your goal.")
            AddText("First, you will get to ready one of your weapons.")
            AddText("Status displays will be the next thing that you see.")
            AddText("These give you an overall status of you and your opponent.")
            AddText("The levels of status are: Healthy, Wounded, Heavily Wounded, Seriously Wounded, and Critical.")
            AddText("At times you may notice the status of Stunned as combat ensues.")
            AddText("If you are stunned, you will not be able to do anything except wait until you recover.")
            AddText("If your opponent is stunned you may wish to take advantage of the situation.")
            AddText("Get in a few good swings, or, if your opponent is too formidable, Flee.")
            AddText("")

            AddText("You will also notice a fatigue level.")
            AddText("If you become too fatigued, you will not be able to fight until you gain stamina back.")
            AddText("The rate of fatigue increases quicker by going Berserk and decreases by Defending.")
            AddText("")

            AddText("Your attack options include:")

            AddText("ATTACK - A normal attack.")
            AddText("BERSERK - This options put your assassin in a totally uncontrollable rage.")
            AddText("Your attacks do twice the damage, but will fatigue you twice as quickly.")
            AddText("PARRY - Attempt to counter your opponent's attack, increasing the chance they will become stunned.")
            AddText("DEFEND - Increase your chance to block or dodge an enemy's attack.")
            AddText("This option also recovers fatigue.")
            AddText("FLEE - Attempt to escape from the battle.")
            AddText("")
            AddText("You will also have the option of drinking a potion to recover Endurance during the battle.")
            AddText("You can also change your weapon if it proves ineffective during the battle.")
        End Sub

        ''' <summary>Displays introductory information about the game.</summary>
        Private Sub Intro()
            AddText(" * * * ASSASSIN * * *")
            AddText("")
            AddText("Lightning crackles through the the stormy skies, as screams are heard in the distance.")
            AddText("War continues on between nobles, as they send their soldiers and mercenaries to do their bidding, to gain more land and power.")
            AddText("The church watches quietly, patiently, waiting to take a chunk of the newly won land.")
            AddText("Death covers the land, as another age of darkness approaches.")
            AddText("Life is basically wretched for most.")
            AddText("They are not fulfilled, or not even given enough to survive, most being the latter.")
            AddText("The standard of life is worthless.")
            AddText("Many take second jobs as highwaymen, stealing from others so that they can survive.")
            AddText("Others serve the war efforts, which proves only slightly better, since most do not survive from skirmish to skirmish.")
            AddText("The few survivors gain living wages.")
            AddText("A few elite warriors manage to make it up the perilous ladder, only to lose their hard-won gains to a rival noble.")
            AddText("There is a possible hope coming, which is known as magic, but some believe this same life-restoring power is part of the problem.")
            AddText("A few smart commoners have learned of another calling.")
            AddText("There is indeed need of people to eliminate problems such as rival nobles, and power hungry clergy members.")
            AddText("Instead of fighting forces of insurmountable odds, they fight for the one cause.")
            AddText("These wanted persons being Assassins...")
            AddText("")
            AddText("ASSASSIN is a role-playing game that takes place in a time similar to the dark ages, where assassins work to make their fortune.")
            AddText("You, as a player, fight to gain experience, gold, and the control of your own guild as you try to become the most powerful assassin in the city.")
            AddText("As the game progresses, you will learn of other missions to complete.")
        End Sub

        ''' <summary>Displays information about how to play the game.</summary>
        Private Sub Playing()
            AddText(" * * * PLAYING THE GAME * * * ")
            AddText("")

            AddText("The value on which all assassins are based is their experience.")
            AddText("Experience is gained through successful assassinations and other events.")
            AddText("It controls many factors in an assassin's life, such as prestige, infamy, knowledge, and ability.")
            AddText("For every ten experience points, an assassin achieves a new level of mastery.")
            AddText("At each level of mastery, assassins become more and more advanced.")
            AddText("Some of these enhancements are blending into the surroundings striking with deadlier force, and skill with unusual and unknown weapons.")
            AddText("")

            AddText("The bread and butter of all assassins is assassination (isn't that obvious?)")
            AddText("It is done in two phases: the stalking and then the actual attack.")
            AddText("The first phase is done in one of three ways.")
            AddText("")

            AddText("The first method is simply look around for a promising victim, one of the appropriate level and of the proper prestige.")
            AddText("This method provides only a small amount of coins, and a weapon.")
            AddText("")

            AddText("The second method is to be hired by someone.")
            AddText("This usually provides a larger amount of coins, but the weapon must be given to the employer as proof of the slain opponent.")
            AddText("")
            AddText("The third method is the full blown assassination.")
            AddText("This method is employed against other assassins")
            AddText("It is a battle first against the opponent's henchmen, followed by a final conflict between the two assassins.")
            AddText("")

            AddText("Raids are used to gain wealth and fame, as well as prove you are better than other assassins.")
            AddText("Usually raids are between guildmasters, however sometimes raids are against city banks.")
            AddText("")
            AddText("Raids against guilds are simple.")
            AddText("You group your assassin and henchmen against a guild, then storm in, wreaking as much havoc and damage as possible, then looting the remains and taking it over yourself.")
            AddText("")
            AddText("Raids against banks are just as simple, with the exception that you are not trying to permanently take over the bank, but rather take it over temporarily so that you can steal as much as possible.")
            AddText("However, raiding banks can prove more challenging and hazardous since all gains are earned through others' accounts.")
            AddText("")

            AddText("A common establishment an assassin will encounter is the Guild.")
            AddText("Any promising assassin will eventually find his or her path leading there.")
            AddText("A guild can be located from anywhere from a Tavern to a Hotel.")
            AddText("At first you must choose which guild to go to.")
            AddText("A list of the available guilds will be displayed from which to choose.")
            AddText("Once inside, your options available will depend on your status.")
            AddText("Non-members may wish to send an application to join the guild.")
            AddText("Each guild is controlled by a guildmaster, who may be another player's character.")
            AddText("Computer-controlled guildmasters always allow players to join if they qualify.")
            AddText("Applicants to player-controlled guilds have to wait for a response from the guildmaster.")
            AddText("In most guilds, the player can challenge the guildmaster for control of the guild.")
            AddText("The ensuing battle will pit the player's henchmen against the guild's henchmen.")
            AddText("If the player's henchmen defeat the guild's henchmen, the player will face the guildmaster in one-on-one combat.")
            AddText("If the player defeats the guildmaster, the player takes control of the guild. If the player fails, he is ejected from the guild.")
            AddText("The Master's Tavern, the guild new players are automatically entered into, can not be controlled by a player.")
            AddText("After a player reaches level 6, the player will be ejected from The Master's Tavern, as they are too experienced.")
            AddText("")

            AddText("The alley is where you can find the toughest, possibly most dangerous assassins around, or perhaps ones that don't have a place to shelter overnight.")
            AddText("It is an Arena where only the strongest survive and even then sometimes they don't live to see the next day.")

        End Sub

        ''' <summary>Displays information about Skills.</summary>
        Private Sub Skills()
            AddText(" * * * SKILLS * * * ")
            AddText("")

            AddText("Skill is gained through battles and through certain events.")
            AddText("Skill points will be gained if the assassin is successful, and sometimes even when he fails an attempt.")
            AddText("Skill points can be redeemed at the Training Grounds.")
            AddText("")

            AddText("ENDURANCE is your ability to withstand punishment.")
            AddText("The more of this you have, the longer you can endure.")
            AddText("")

            AddText("LIGHT WEAPON skill relates to the dexterity of the individual.")
            AddText("This ability is used to manipulate cutting weapons and items that weigh up to ten pounds.")
            AddText("Light weapons are meant to be used to cut the opponent and try to sever a major vein.")
            AddText("Weapons in the category of light weapon include daggers and most types of swords.")
            AddText("")

            AddText("HEAVY WEAPON skill relates to the strength of the individual.")
            AddText("The ability is used to manipulate bashing weapons and items up to twenty pounds efficiently.")
            AddText("Heavier weapons are not meant to be used in the way of swords.")
            AddText("Instead, they are be used to make a major impact upon the opponent and break them.")
            AddText("Heavier weapons include clubs, maces, flails, morning stars and most axes.")
            AddText("")

            AddText("TWO-HANDED WEAPON skill relates to the the ability to quickly manipulate larger sized items.")
            AddText("These weapons are usually held with both hands; hence the name.")
            AddText("When used, the weapon gives a superior edge both in defense and damage due to the concentrated effort.")
            AddText("Two-handed weapons include staves, warhammers, halberds, and great weapons.")
            AddText("")

            AddText("BLOCKING is a defensive skill in which the assassin uses an item to block oncoming attacks.")
            AddText("This defense is used against weapons by countering the force of the blow with an equal or better force.")
            AddText("Blocking is also used in determining your ability to prevent an enemy from fleeing.")

            AddText("SLIPPING is the defensive skill used to maneuver out of the way of a blow before it strikes.")
            AddText("Slipping is also used in determining how well you can escape a fight.")
            AddText("")

            AddText("STEALTH is the ability to hide in shadows, to escape when being pursued and generally disappear when the tough needs to get going.")
            AddText("Stealth is a statistic used throughout the game, from sneaking a first blow to pickpocketing an unsuspecting victim.")
            AddText("The more stealth you have, the better you will fare.")
        End Sub

#End Region

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnCity_Click(sender As Object, e As EventArgs) Handles BtnCity.Click
            Clear()
            City()
        End Sub

        Private Sub BtnCombat_Click(sender As Object, e As EventArgs) Handles BtnCombat.Click
            Clear()
            Combat()
        End Sub

        Private Sub BtnIntro_Click(sender As Object, e As EventArgs) Handles BtnIntro.Click
            Clear()
            Intro()
        End Sub

        Private Sub BtnPlaying_Click(sender As Object, e As EventArgs) Handles BtnPlaying.Click
            Clear()
            Playing()
        End Sub

        Private Sub BtnSkills_Click(sender As Object, e As EventArgs) Handles BtnSkills.Click
            Clear()
            Skills()
        End Sub

#End Region

#Region "Form Management"

        Private Sub FrmManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Intro()
        End Sub

        Private Sub FrmManual_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmMain.Show()
        End Sub

#End Region

    End Class

End Namespace