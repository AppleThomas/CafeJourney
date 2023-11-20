VAR affection = 0
VAR name = "Eric"
VAR coffee = ""
-> start

=== start ===
Hi there, could I just get a {coffee}?
    * [Coming right up!]
        Thanks so much.
        
    * [Of course! We have a really yummy light roast on brew right now, is that good?]
        Sure thing, I trust you! I don't know too much about {coffee}.
        ~ affection++
    -
    
I haven't seen this place before, how long has this cafe been open?
    * [Only a few weeks! I'm the owner!]
        Wow, that's amazing! You must be a great businesswoman doing this on your own!
        ~ affection++
    * [Just a few weeks now.]
        That's cool. I don't explore the city too much, but this place is really neat.
    -
    
What's your name? I'm Eric, by the way.
    * [It's Georgie, nice to meet you! Do you work in the area?]
        Yeah I do! I work over in the super tall building right across from the shop.
            ~ affection++
    * [My name's Georgie!]
        Nice to meet you Georgie.
    -
    
Working at a place like this seems so nice. You get to talk to new people all the time.
    * [I really do love it. It's helping me to get to know new friends, since I just moved to the city to open the shop.]
        That's perfect then! It can be hard to get to know people in a place this big.
        ~ affection++
    * [It's nice, but it can be draining.]
        I bet.
    -

The black coffee I usually get tastes like burning...but at least it has caffeine. I'll let you do your thing now.
    * [I hope you'll like it!]
        Have a good one!
    * [I try to source the best beans I can so I'm sure you'll like it.]
        I can tell!! Thanks so much.
        ~ affection++
    -
    -> END
