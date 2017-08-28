Public Class Form2
    Private Sub ZerglingInfo_Click(sender As Object, e As EventArgs) Handles ZerglingInfo.Click
        ImageBox.BackgroundImage = My.Resources.Zergling
        TextBox.Text =
            "Name: Zergling" & vbNewLine &
            "Use: Fast melee skirmisher." & vbNewLine &
            "Production cost: 25 minerals" & vbNewLine &
            "Base Stats" & vbNewLine &
            "HP: 35" & vbNewLine &
            "Damage: 5" & vbNewLine &
            "Attack Speed: 0.5" & vbNewLine &
            "Target priority: 20" & vbNewLine &
            "Strong against: Hydralisks, Marauders, Stalkers" & vbNewLine &
            "Weak against: Hellions, Archons, Banelings, Ultralisks" & vbNewLine & vbNewLine &
            "Lore: Zerglings form the most numerous of the zerg mutations—their simple DNA (distilled from the dune runners' genetic code to its most simple form) allows two zerglings to be spawned from a single larva. The larvae get the genetic information from the 'primordial ooze' of spawning pools. Zergling replication is so efficient that they thrive even when exposed to exceedingly high mortality rates,  which are greater than almost all other zerg strains." & vbNewLine &
            "Zerglings are the smallest zerg strain apart from the larvae, and equivalent in size to a large dog, zerglings are one meter tall and possess webbed feet. Further mutations may be made to zergling DNA, namely the alteration of their physiology through a metabolic boost to increase their reflexes and rate of movement and the mutation of their adrenal glands, changing their glandular balance to induce a battle frenzy. These adrenal glands have been observed to be unusually large for a creature of the zergling's size. Further analysis has revealed evidence of genetic manipulation, which also increased zergling aggression, driving them into a state of frenzy. In such a state, zerglings can bring down armored vehicles and structures with ease." & vbNewLine &
            "The rapid genesis modification to zergling cells allows their gestation to proceed at remarkable speed. Zerglings have tough, adaptable, leathery skin which prevents moisture loss, while still allowing fluid circulation to keep the zergling's body temperature at appropriate levels. As per their origins, zerglings have an efficient nutrient storage system. Zerglings can derive the necessary compounds for life (even water) from anything they eat. This allows zerglings to operate away from a hive cluster for extended periods of time." & vbNewLine &
            "Zerglings are physically adaptable creatures, able to climb near vertical surfaces and are extraordinarily fast, though they are generally easy to exterminate, one ending up as roadkill after being run over by a recon vehicle. Zerglings have a complex optical structure, and their eyes have an optical aperture which allows them to see in the dark. This ability is further enhanced by a layer of tissue that reflects light, and the production of a substance which, depending on saturation levels, makes a zergling's eyes glow orange or red. This glow is an indicator that a zergling's vision has fully adapted to whatever low-light conditions it has found itself in. However, zergling eyes have also appeared as pure black in such conditions." & vbNewLine &
            "The zergling's spiked tail allows the creature to maintain balance while running at high speeds. The spikes that extend from the tip have no discernable purpose, and Dominion scientists have speculated that it is vestigal from their dune runner forebears. Spikes jut from the bodies of Leviathan Brood zerglings as a byproduct of their extremely simplified DNA. These spikes are retained even when Leviathan zerglings metamorphose into banelings."
    End Sub

    Private Sub BaneInfo_Click(sender As Object, e As EventArgs) Handles BaneInfo.Click
        ImageBox.BackgroundImage = My.Resources.Baneling
        TextBox.Text =
            "Name: Baneling" & vbNewLine &
            "Use: Suicide unit." & vbNewLine &
            "Production cost: 25 minerals/ 25 gas" & vbNewLine &
            "Base Stats" & vbNewLine &
            "HP: 30" & vbNewLine &
            "Damage: 20 (+15 vs Light)" & vbNewLine &
            "Damage (Special): 80 (vs structures)" & vbNewLine &
            "Attack Speed: 0.59" & vbNewLine &
            "Target priority: 20" & vbNewLine &
            "Strong against: Marines, Zealots, Zerglings" & vbNewLine &
            "Weak against: Roaches, Stalkers, Thors, Siege Tanks (Siege Mode), High Templar (Psi Storm). Sentries (Force Fields)" & vbNewLine & vbNewLine &
            "Lore: Banelings were first observed during the Siege of Cask on Sorona, in 2503. Its defenders held out against the zerg long enough so that it came to pass that only minor breeds such as zerglings continued to be spawned to be sent into battle. However, queens drove the development of a new strain, via zerglings incorporating an acidic native mold into themselves. Because of its mass, the baneling's legs are thicker than the zergling's, in order to stabilize itself. Its feet are replaced by sharp spikes that allow them to navigate rough terrain, albeit at a slower pace. The Swarm was able to increase the baneling's speed despite these imperfections. Yet due to their bloated nature, banelings are barely able to walk. They have been observed to tuck into a ball and roll. Banelings also possess a rudimentary sonar system—Dominion scientists have theorized that this is a degeneration of the zergling's complex optical structure. This system consists of a transmitter in the center of the baneling's skull, along with two evenly spaced receivers to the sides. The transmitter emits pulses that map the baneling's surrounding area, and echoes back to the receiver, feeding the baneling with a continuous stream of spatial information." & vbNewLine &
            "Leviathan Brood banelings retain the spine-like growths of the zerglings that metemorphosed into them. As all Soronan mold amino acids exist in banelings , they are capable of surviving on minimal oxygen and moisture." & vbNewLine & "When a baneling gets close enough to an enemy, it triggers a reaction within its volatile chemical payload, causing the creature to explode with a shower of searing acid. The explosion destroys the baneling but also inflicts terrible damage to its enemies, highly effective against both structures and ground forces. In fact, a clutch of them is capable of wiping out a group of vehicles and infantry in the blink of an eye. The banelings' lethality is further enhanced by the zerg predilection for burrowing. An apparently safe area can soon turn into a deathtrap as these monstrosities erupt beneath their foes, giving enemies virtually no time to react"
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class