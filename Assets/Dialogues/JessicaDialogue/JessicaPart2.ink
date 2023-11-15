VAR affection = 0
VAR name = "Jessica"
-> start

=== start ===
Script 2
Hey there! Nice to see you! Can I please get a small latte?
    * [Of course! I'm glad you stopped by again.]
        Girl, you know it! The latte I got last time was magnifique.
        ~ affection++
    * [You've got it. Is whole milk fine?]
        Oatmilk please!
    -
    
How have things been going with the cafe?
    * [Better than I expected! My first customers have been coming back in, and it makes me so happy that people are enjoying my coffee. I really put my heart into it!]
        I can tell! Every coffee shop in the city is a chain, we needed a cafe with pizzazz. 
        ~ affection++
    * [Business has been slow, but it's getting better!]
        Don't worry, once word gets around about this place you'll have a line out the door. 
    -
    
I wish I had my own storefront...
    * [What do you do??]
        I'm a fashion designer... however right now I'm just selling clothes at a lame shop.
        ~ affection++
    * [It's hard to open a shop, the rent is sooo expensive.]
        Ugh, I know. If I was rich I would be unstoppable. 
    -
    
I've just been selling my fashions online as a side hustle until I save up enough to rent out a shop.
    * [That's a great place to start! Once you've built a brand, everyone will be so excited to shop your designs.]
        You really think so?? I've been working on a name for my business but one hasn't stuck yet.
        ~ affection++
    * [That's cool, I love online shopping.]
        It is convenient, but I only make like one sale a month.
    -


    * [Once again you slayed with the latte art. The flower is so cute!!]
        You're too kind-- I've been practicing a lot!
        ~ affection++
    * [Thanks for the coffee, I'll see you around.]
        Bye!
    -
    -> END
