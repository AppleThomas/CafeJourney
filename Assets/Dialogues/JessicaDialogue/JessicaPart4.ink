VAR affection = 0
VAR name = "Jessica"
VAR coffee = ""
-> start

=== start ===
Good morning Georgie!!
    * [Hey Jess! Are you getting your {coffee}?]
        You know it!
        ~ affection++
    * [Hi Jess! What can I get for you?]
        Just a {coffee}, thanks!
    -
    
Girl, I need the caffeine this morning...I stayed up soooo late designing my flyer!
    * [That's rough.]
        It is what it is.
    * [This coffee should do the trick!]
        Thank you so much!
        ~ affection++
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
