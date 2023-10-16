// okay so for each player, we have like 5 dialogues. I think we can grab the affection amount
// from that dialogue and add it to an external variable for player controlled by a separate tracker script.
//The script will also let us know what script to play based on the affection (includes our generic one too).

// for the days, we can have an overarching script be created that keeps track of all days, and then creates
// a stack of all the npc's we'll have to serve coffee for, includes certain amount of basic npc ones that
// rise to more days pass.

// 4 npc's times 5 = 20 meetings, with 30 days
// for the stack. I'm thinking 2 characters a day. If we can min max it, you can theoretically do it in 10 days, how are we
// gonna deal with this... hmm...

// what if we go lowest score first for who you'll talk to, it'll give you time to meet everyone without rushing one person
// in 5 days...

// to end an interaction, you finish a dialogue, go to coffee maker, make coffee, and then return it to npc
// this might be kept in track by how many "valid" times you click I (interact) with the player, where once you do dialogue,
// it goes up by 1, and if 1 without coffee, you can't talk again. 1 with coffee you talk, and if 2, they leave.

// or we can do a simple check with coffee, hmm...

// okay better plan, we do dialogue, and then we check if dialogue finished AND coffee given, then we end the
// interaction AFTER the dialogue finishes.