' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Manual Form.vb
' Description     : This form allows the player to read information about the game.

Public Class frmManual
    Private Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *
        Dim nl As String = ControlChars.NewLine

        txtManual.Text += newText & nl
        txtManual.Select(0, 0)
        txtManual.ScrollToCaret()
    End Sub

    Private Sub city()
        '* * * * *
        '* This method displays information about the City.
        '* * * * *

        addText(" * * * THE CITY * * * ")
        addText("")

        addText("ASSASSINATE - This command puts your assassin in the position to watch for a promising target.")
        addText("If you are successful, you will gain experience, skill, and money.")
        addText("If not, you maybe lucky to escape with your life!")
        addText("")

        addText("BANK - For your finacial needs the bank is here.")
        addText("You can take out a loan, make a deposit to your account, check your current balances, as well as a few other interesting things.")
        addText("")

        addText("GUILDS - Guilds provide a fairly safe place to stay overnight, as well as opportunities to get paid for assassinations.")
        addText("You can even begin recruiting the henchmen you will need later in the game.")
        addText("Each guild has an initiation fee you must pay to join.")
        addText("All new players are given a complimentary membership to the Master's Tavern.")
        addText("This should be taken advantage of.")
        addText("One advantage is that the job offerings provided give a good source of income.")
        addText("")

        addText("INN - After a hard day of assassinations and walking around the city, an assassin tends to get tired and worn out.")
        addText("The Inn is here to serve your full needs for protection and privacy.")
        addText("You can either nap to regain some lost endurance or spend the night and be well protected.")
        addText("Inns also provide a messenger service, along with the daily newspaper.")

        addText("JAIL - Take a look at all the Assassin's who've been caught in their illegal activities.  You can even BAIL them out!")
        addText("")

        addText("ALCHEMIST'S LABORATORY - The lab is here for those that wish a speedy recovery after a long, grueling battle.")
        addText("They currently are working on potions that will cause your system to heal quickly.")
        addText("If you purchase a potion, you can either drink it there or take it along until you may really need it.")
        addText("Be warned though, not all potions are beneficial.  Some can even be harmful!")
        addText("")

        addText("OTHER ASSASSINS - This will give you a list of all the living assassins that currently make their stay in the city and that you may encounter in the future.")
        addText("")

        addText("PUB - When you are hungry or thirsty, stop by the pub, it aims to please.")

        addText("ROB SOMEONE - If you need some money, you may prefer to steal it rather than fight for it.")
        addText("Your methods are simple: Waylay an opponent, or Pickpocket your victim.")
        addText("Waylaying usually yields more than picking, but pickpocketing is far less dangerous.")

        addText("SHOPS - More than likely you will visit here a good few times.")
        addText("There are many places to shop, to satisfy many needs.")
        addText("Window-shopping is acceptable, however stealing is quite punishable.")

        addText("TRAINING GROUNDS - Here's where you begin and should visit often during the game.")
        addText("The training grounds offer courses in offensive and defensive skills by using your accumulated skill points for training sessions.")

    End Sub

    Private Sub clear()
        '* * * * *
        '* This method clears the Textbox.
        '* * * * *

        txtManual.Clear()
    End Sub

    Private Sub combat()
        '* * * * *
        '* This method displays information about Combat.
        '* * * * *

        addText(" * * * COMBAT * * * ")
        addText("")

        addText("In all assassinations and even some raids you may find yourself locked into mortal combat.")
        addText("To destroy or be destroyed, that is your goal.")
        addText("First, you will get to ready one of your weapons.")
        addText("Status displays will be the next thing that you see.")
        addText("These give you an overall status of you and your opponent.")
        addText("The levels of status are: Healthy, Wounded, Heavily Wounded, Seriously Wounded, and Critical.")
        addText("At times you may notice the status of Stunned as combat ensues.")
        addText("If you are stunned, you will not be able to do anything except wait until you recover.")
        addText("If your opponent is stunned you may wish to take advantage of the situation.")
        addText("Get in a few good swings, or, if your opponent is too formidable, Flee.")
        addText("")

        addText("You will also notice a fatigue level.")
        addText("If you become too fatigued, you will not be able to fight until you gain stamina back.")
        addText("The rate of fatigue increases quicker by going Berserk and decreases by Defending.")
        addText("")

        addText("Your attack options include:")

        addText("ATTACK - A normal attack.")
        addText("BERSERK - This options put your assassin in a totally uncontrollable rage.")
        addText("Your attacks do twice the damage, but will fatigue you twice as quickly.")
        addText("PARRY - Attempt to counter your opponent's attack, increasing the chance they will become stunned.")
        addText("DEFEND - Increase your chance to block or dodge an enemy's attack.")
        addText("This option also recovers fatigue.")
        addText("FLEE - Attempt to escape from the battle.")
        addText("")
        addText("You will also have the option of drinking a potion to recover Endurance during the battle.")
        addText("You can also change your weapon if it proves ineffective during the battle.")
    End Sub

    Private Sub intro()
        '* * * * *
        '* This method displays introductory information about the game.
        '* * * * *

        addText(" * * * ASSASSIN * * *")
        addText("")
        addText("Lightning crackles through the the stormy skies, as screams are heard in the distance.")
        addText("War continues on between nobles, as they send their soldiers and mercenaries to do their bidding, to gain more land and power.")
        addText("The church watches quietly, patiently, waiting to take a chunk of the newly won land.")
        addText("Death covers the land, as another age of darkness approaches.")
        addText("Life is basically wretched for most.")
        addText("They are not fulfilled, or not even given enough to survive, most being the latter.")
        addText("The standard of life is worthless.")
        addText("Many take second jobs as highwaymen, stealing from others so that they can survive.")
        addText("Others serve the war efforts, which proves only slightly better, since most do not survive from skirmish to skirmish.")
        addText("The few survivors gain living wages.")
        addText("A few elite warriors manage to make it up the perilous ladder, only to lose their hard-won gains to a rival noble.")
        addText("There is a possible hope coming, which is known as magic, but some believe this same life-restoring power is part of the problem.")
        addText("A few smart commoners have learned of another calling.")
        addText("There is indeed need of people to eliminate problems such as rival nobles, and power hungry clergy members.")
        addText("Instead of fighting forces of insurmountable odds, they fight for the one cause.")
        addText("These wanted persons being Assassins...")
        addText("")
        addText("ASSASSIN is a role-playing game that takes place in a time similar to the dark ages, where assassins work to make their fortune.")
        addText("You, as a player, fight to gain experience, gold, and the control of your own guild as you try to become the most powerful assassin in the city.")
        addText("As the game progresses, you will learn of other missions to complete.")
    End Sub

    Private Sub playing()
        '* * * * *
        '* This method displays information about how to play the game.
        '* * * * *

        addText(" * * * PLAYING THE GAME * * * ")
        addText("")

        addText("The value on which all assassins are based is their experience.")
        addText("Experience is gained through successful assassinations and other events.")
        addText("It controls many factors in an assassin's life, such as prestige, infamy, knowledge, and ability.")
        addText("For every ten experience points, an assassin achieves a new level of mastery.")
        addText("At each level of mastery, assassins become more and more advanced.")
        addText("Some of these enhancements are blending into the surroundings striking with deadlier force, and skill with unusual and unknown weapons.")
        addText("")

        addText("The bread and butter of all assassins is assassination (isn't that obvious?)")
        addText("It is done in two phases: the stalking and then the actual attack.")
        addText("The first phase is done in one of three ways.")
        addText("")

        addText("The first method is simply look around for a promising victim, one of the appropriate level and of the proper prestige.")
        addText("This method provides only a small amount of coins, and a weapon.")
        addText("")

        addText("The second method is to be hired by someone.")
        addText("This usually provides a larger amount of coins, but the weapon must be given to the employer as proof of the slain opponent.")
        addText("")
        addText("The third method is the full blown assassination.")
        addText("This method is employed against other assassins")
        addText("It is a battle first against the opponent's henchmen, followed by a final conflict between the two assassins.")
        addText("")

        addText("Raids are used to gain wealth and fame, as well as prove you are better than other assassins.")
        addText("Usually raids are between guildmasters, however sometimes raids are against city banks.")
        addText("")
        addText("Raids against guilds are simple.")
        addText("You group your assassin and henchmen against a guild, then storm in, wreaking as much havoc and damage as possible, then looting the remains and taking it over yourself.")
        addText("")
        addText("Raids against banks are just as simple, with the exception that you are not trying to permanently take over the bank, but rather take it over temporarily so that you can steal as much as possible.")
        addText("However, raiding banks can prove more challenging and hazardous since all gains are earned through others' accounts.")
        addText("")

        addText("A common establishment an assassin will encounter is the Guild.")
        addText("Any promising assassin will eventually find his or her path leading there.")
        addText("A guild can be located from anywhere from a Tavern to a Hotel.")
        addText("At first you must choose which guild to go to.")
        addText("A list of the available guilds will be displayed from which to choose.")
        addText("Once inside, your options available will depend on your status.")
        addText("Non-members may wish to send an application to join the guild.")
        addText("Each guild is controlled by a guildmaster, who may be another player's character.")
        addText("Computer-controlled guildmasters always allow players to join if they qualify.")
        addText("Applicants to player-controlled guilds have to wait for a response from the guildmaster.")
        addText("In most guilds, the player can challenge the guildmaster for control of the guild.")
        addText("The ensuing battle will pit the player's henchmen against the guild's henchmen.")
        addText("If the player's henchmen defeat the guild's henchmen, the player will face the guildmaster in one-on-one combat.")
        addText("If the player defeats the guildmaster, the player takes control of the guild. If the player fails, he is ejected from the guild.")
        addText("The Master's Tavern, the guild new players are automatically entered into, can not be controlled by a player.")
        addText("After a player reaches level 6, the player will be ejected from The Master's Tavern, as they are too experienced.")
        addText("")

        addText("The alley is where you can find the toughest, possibly most dangerous assassins around, or perhaps ones that don't have a place to shelter overnight.")
        addText("It is an Arena where only the strongest survive and even then sometimes they don't live to see the next day.")


    End Sub

    Private Sub skills()
        '* * * * *
        '* This method displays information about Skills.
        '* * * * *

        addText(" * * * SKILLS * * * ")
        addText("")

        addText("Skill is gained through battles and through certain events.")
        addText("Skill points will be gained if the assassin is successful, and sometimes even when he fails an attempt.")
        addText("Skill points can be redeemed at the Training Grounds.")
        addText("")

        addText("ENDURANCE is your ability to withstand punishment.")
        addText("The more of this you have, the longer you can endure.")
        addText("")

        addText("LIGHT WEAPON skill relates to the dexterity of the individual.")
        addText("This ability is used to manipulate cutting weapons and items that weigh up to ten pounds.")
        addText("Light weapons are meant to be used to cut the opponent and try to sever a major vein.")
        addText("Weapons in the category of light weapon include daggers and most types of swords.")
        addText("")

        addText("HEAVY WEAPON skill relates to the strength of the individual.")
        addText("The ability is used to manipulate bashing weapons and items up to twenty pounds efficiently.")
        addText("Heavier weapons are not meant to be used in the way of swords.")
        addText("Instead, they are be used to make a major impact upon the opponent and break them.")
        addText("Heavier weapons include clubs, maces, flails, morning stars and most axes.")
        addText("")

        addText("TWO-HANDED WEAPON skill relates to the the ability to quickly manipulate larger sized items.")
        addText("These weapons are usually held with both hands; hence the name.")
        addText("When used, the weapon gives a superior edge both in defense and damage due to the concentrated effort.")
        addText("Two-handed weapons include staves, warhammers, halberds, and great weapons.")
        addText("")

        addText("BLOCKING is a defensive skill in which the assassin uses an item to block oncoming attacks.")
        addText("This defense is used against weapons by countering the force of the blow with an equal or better force.")
        addText("Blocking is also used in determining your ability to prevent an enemy from fleeing.")

        addText("SLIPPING is the defensive skill used to maneuver out of the way of a blow before it strikes.")
        addText("Slipping is also used in determining how well you can escape a fight.")
        addText("")

        addText("STEALTH is the ability to hide in shadows, to escape when being pursued and generally disappear when the tough needs to get going.")
        addText("Stealth is a statistic used throughout the game, from sneaking a first blow to pickpocketing an unsuspecting victim.")
        addText("The more stealth you have, the better you will fare.")
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnCity_Click(sender As System.Object, e As System.EventArgs) Handles btnCity.Click
        '* * * * *
        '* This method displays information about the City.
        '* * * * *

        clear()
        city()
    End Sub

    Private Sub btnCombat_Click(sender As System.Object, e As System.EventArgs) Handles btnCombat.Click
        '* * * * *
        '* This method displays information about Combat.
        '* * * * *

        clear()
        combat()
    End Sub

    Private Sub btnIntro_Click(sender As System.Object, e As System.EventArgs) Handles btnIntro.Click
        '* * * * *
        '* This method displays introductory information about the game.
        '* * * * *

        clear()
        intro()
    End Sub

    Private Sub btnPlaying_Click(sender As System.Object, e As System.EventArgs) Handles btnPlaying.Click
        '* * * * *
        '* This method displays information about how to play the game.
        '* * * * *

        clear()
        playing()
    End Sub

    Private Sub btnSkills_Click(sender As System.Object, e As System.EventArgs) Handles btnSkills.Click
        '* * * * *
        '* This method displays information about Skills.
        '* * * * *

        clear()
        skills()
    End Sub


    Private Sub frmManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '* * * * *
        '* This method displays introductory information about the game when the form loads.
        '* * * * *

        intro()
    End Sub

    Private Sub frmManual_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method displays the main form on form closing.
        '* * * * *

        frmMain.Show()
    End Sub
End Class