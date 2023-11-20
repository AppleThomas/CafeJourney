VAR affection = 0
VAR name = "Jessica"
VAR coffee = ""
-> start

=== start ===
Hey girl, good to see you!!
    * [You too!]
        Could I get a {coffee} please?
    * [Good morning Jess, your outfit is so cute!]
        Omg thank you, I made this dress! Can I get a {coffee} please
        ~ affection++
    -
    
Georgie...I've already gotten five sales today!!
    * [Is that more than usual?]
        Yeah...I hadn't had a sale in my online shop for over a month until today.
    * [Dude that's amazing! Do you think it has to do with the flyers?]
        It has to be! I even got a boost in my Instagram followers.
        ~ affection++
    -
    
Apparently there's a lot of fashion girlies that come into your cafe! I have to meet them somehow.
    * [There are a lot of customers with good style here.]
        For sure!
    * [Maybe you could host some kind of event in the cafe?]
        That would be so slay...like a little fashion show maybe!
        ~ affection++
    -
    
What if I hosted a fashion show here for local designers? I know it might sound weird having it in a cafe, but I think it would be so cute.
    * [That sounds awesome! We could have it after the shop is closed]
        You are so cool Georgie, thanks for being willing to help with my crazy ideas!
        ~ affection++
    * [It might seem a bit odd but I guess we could do it]
        I promise we'll make it so cool!
    -

Well, I've gotta get started on packing up the orders for my shop! I'm so excited-- I think big things are coming soon!
    * [Thanks for letting me be a part of your journey.]
        Of course girl-- I'll see you tomorrow!
        ~ affection++
    * [Good luck!!]
        See you soon Georgie, thanks for everything. 
    -
    -> END
