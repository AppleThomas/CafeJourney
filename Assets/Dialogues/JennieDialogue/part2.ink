VAR affection = 0
VAR name = "Jennie"
-> start

=== start ===
Script 2
Good morning, how are you?
    * [I'm doing well, your name is Jennie, right?]
        Yeah it is! It's so sweet you remembered! Your name is Georgie, right? Could I get an iced americano?
        ~ affection++
    * [Not awesome...]
        Oof, sorry to hear that...is there any way I can get an iced americano?
    -
    
My show was last night!
    * [How was it?!]
        Honestly... it went better than expected! Turns out the kid's mom works for a record label company! 

        Even though I was just singing kids' songs and playing the ukulele, she saw some talent in me and invited me out to her
        company for an audition!
        ~ affection++
    * [That's cool.]
        Thanks...
    -
    
I'm so nervous to go to this audition though... this really could be the next step in my music career!
    * [You've got this!!]
        ...yyou really think so?
        ~ affection++
    * [You're right, that sounds pretty intimidating]
        Yeah, I've never done anything like this.
    -
    
I've been thinking about what songs I should perform for the record label. I don't know what would impress them.
    * [I think you should pick songs that really show your personality and what type of music inspires you.]
        You're right! Instead of just thinking about what the judges would like, I should pick something I really love performing.
        ~ affection++
    * [How do you know what the label is looking for?]
        That's my problem...
    -

Well, I'd better be off. My audition is in 20 minutes!
    * [Good luck, see you soon Jennie!]
        Thanks so much Georgie, you're the best!
        ~ affection++
    * [Goodbye!]
        See you!
    -
    -> END
