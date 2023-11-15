VAR affection = 0
VAR name = "Jessica"
-> start

=== start ===
Script 4
Good morning Georgie!!
    * [Hey Jess! Are you getting your oatmilk latte?]
        You know it!
        ~ affection++
    * [Hi Jess! What can I get for you?]
        Just a small oat latte, thanks!
    -
    
Girl, I need the caffeine this morning...I stayed up soooo late designing my flyer!
    * [I'll throw an extra shot in your latte!]
        Thank you so much!
        ~ affection++
    * [That's rough.]
        It is what it is.
    -
    
Let me show you... here's the flyer!!
    * [Omg it's so cute!! It really showcases the essence of your fashion style.]
        Thanks Georgie, I really put time into it. I hope it catches peoples' eyes!
        ~ affection++
    * [That's cool!]
        Thanks!
    -
    
I'm gonna leave my flyers here on the counter for customers to see if that's okay!
    * [Of course-- I'll encourage customers to take one.]
        You're the best.
        ~ affection++
    * [Sounds good.]
        Yay!
    -

Let me know if anyone asks about my shop! Thanks again for the latte!
    * [Of course, have a great day Jess.]
        You too queen!
        ~ affection++
    * [You got it.]
        See ya!
    -
    -> END
