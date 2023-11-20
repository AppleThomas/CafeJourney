VAR affection = 0
VAR name = "Jessica"
VAR coffee = ""
-> start

=== start ===
Good morning Georgie!
    * [Aw, you remembered my name! Yours is Jess, right?]
        Yeah!! It's Jessica, but I prefer my nickname Jess! Can I get a {coffee}
        ~ affection++
    * [Good morning...Jessica?]
        You got it! Could I get a {coffee}?
    -
    
I've been brainstorming ways on how to get the word out about my online clothing business. You'd think people at the clothing store I work at would be interested, but they're all sooooo...old.
    * [Hm...maybe you could advertise at a place where young people hang out.]
        You're right. I need to think about where the hip baddies hang out.
        ~ affection++
    * [Maybe older people would like it too?]
        I'm not sure someone over the age of 50 would wanna wear a bedazzled crop top...
    -
    
This might be weird... but I was wondering if there's any way I could put a flyer up for my shop in the cafe? I know cool girls love coffee shops, so maybe it would help my store get exposure.
    * [I don't have a bulletin board, but you could leave it here on the counter.]
        That works!!
    * [Of course, I'd love that! I've been wanting to collab with businesses]
        Thanks so much Georgie!! I'll design the cutest flyer I can and bring it in tomorrow.
        ~ affection++
    -
    
You'd think it would be easy to connect with other fashionistas, but despite my confident exterior, I get too intimidated to talk to them sometimes. 
    * [I know, it's pretty intimidating talking to strangers]
        I guess I just need more practice.
    * [You were able to make a connection with me so easily!!]
        You're too sweet-- I'm glad to have gotten to meet you!
        ~ affection++
    -

I've gotta run! I wanna get home as soon as I can to get working on my flyer. 
    * [See you later!]
        Goodbye!
    * [Good luck! With your eye for design I know you'll create something cool.]
        Thanks for everything, see you tomorrow!
        ~ affection++
    -
    -> END
