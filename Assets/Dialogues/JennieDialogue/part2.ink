VAR affection = 0
VAR name = "Jennie"
VAR coffee = ""
-> start

=== start ===
Good morning, how are you?
    * [I'm doing well, your name is Jennie, right?]
        Yeah it is! It's so sweet you remembered! Your name is Georgie, right? Could I get a {coffee}?
        ~ affection++
    * [Not awesome...]
        Oof, sorry to hear that...is there any way I can get a {coffee}?
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
    * [You're right, that sounds pretty intimidating]
        Yeah, I've never done anything like this.
    * [You've got this!!]
        ...yyou really think so?
        ~ affection++
    -
    
I've been thinking about what songs I should perform for the record label. I don't know what would impress them.
    * [I think you should pick songs that really show your personality and what type of music inspires you.]
        You're right! Instead of just thinking about what the judges would like, I should pick something I really love performing.
        ~ affection++
    * [How do you know what the label is looking for?]
        That's my problem...
    -

Well, I'd better be off. My audition is in 20 minutes!
    * [Goodbye!]
        See you!
    * [Good luck, see you soon Jennie!]
        Thanks so much Georgie, you're the best!
        ~ affection++
    -
    -> END
