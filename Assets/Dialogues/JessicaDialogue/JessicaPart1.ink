VAR affection = 0
VAR name = "Jessica"
-> start

=== start ===
Hey there... this is my first time stopping by, what do you recommend?
    * [I really love an iced latte! Since it's your first time it's on the house.]
        Omg! That's so sweet of you! 
        ~ affection++
    * [I just drink black coffee.]
        I don't know if I can do that haha... how about a latte instead?
    -
    
It's decorated so cute in here! The city needed a slay new spot like this. 
    * [I'm so glad you like it! I wanted to make this cafe as cozy and cute as possible.]
        You've definitely succeeded! I'll have to bring some of my friends by soon to check this place out.
        ~ affection++
    * [I tried to make it look nice.]
        You've done a great job with it!
    -
    
I'm Jessica, by the way. Jessica Star. What's your name?
    * [It's Georgie! Nice to meet you! I'm new to the city so it makes me happy to get to meet cool customers like yourself.]
        Aww, thanks babe! Welcome to the city-- I know it's intimidating moving here but you'll find your people in no time. 
        ~ affection++
    * [I'm Georgie.]
        Nice to meet you, Georgie.
    -
    
Did you have a cafe back where you're from?
    * [I didn't-- this is my first shop! I worked at a cafe run by my aunt back home and I wanna make her proud.]
        You seem to really have your life together... opening a cafe in a new town by yourself? That's so swag.
        ~ affection++
    * [Nope, this is my first cafe.]
        That's so exciting, I hope it continues to do well.
    -

Thanks so much-- this coffee looks delicious. And the latte art? So cute.
    * [I'm glad you like it! My latte art is a bit rusty... I'm trying to get making a rosetta design down.]
        I don't know how baristas do it, it's so cool you get to make coffee and art!
        ~ affection++
    * [You're welcome, have a good one!]
        Catch you later!
    -
    -> END
