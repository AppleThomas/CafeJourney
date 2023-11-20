VAR affection = 0
VAR name = "Jessica"
VAR coffee = ""
-> start

=== start ===
Hey there! Nice to see you! Can I please get a {coffee}?
    * [Of course! I'm glad you stopped by again.]
        Girl, you know it! The drink I got last time was magnifique.
        ~ affection++
    * [You've got it. Is whole milk fine?]
        Oatmilk please!
    -
    
How have things been going with the cafe?
    * [Business has been slow, but it's getting better!]
        Don't worry, once word gets around about this place you'll have a line out the door. 
    * [Better than I expected! I'm glad people can enjoy the coffee I make]
        I can tell! Every coffee shop in the city is a chain, we needed a cafe with pizzazz. 
        ~ affection++
    -
    
I wish I had my own storefront...
    * [What do you do??]
        I'm a fashion designer... however right now I'm just selling clothes at a lame shop.
        ~ affection++
    * [It's hard to open a shop, the rent is sooo expensive.]
        Ugh, I know. If I was rich I would be unstoppable. 
    -
    
I've just been selling my fashions online as a side hustle until I save up enough to rent out a shop.
    * [I love online shopping.]
        It is convenient, but I only make like one sale a month.
    * [That's a great place to start!]
        You really think so?? I've been working on a name for my business but one hasn't stuck yet.
        ~ affection++
    -


    * [You really slay with the latte art, I bet this one will be adorbs too]
        You're too kind-- I've been practicing a lot!
        ~ affection++
    * [I'll see you around.]
        Bye!
    -
    -> END
