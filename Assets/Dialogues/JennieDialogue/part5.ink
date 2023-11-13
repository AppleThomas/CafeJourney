VAR affection = 0
VAR name = "Jennie"
-> start

=== start ===
Script 5
Hey girl! How are you? I'm gonna get my usual today. 
    * [I'm well! One iced americano with cream, coming right up.]
        Thank you so much!
        ~ affection++
    * [...remind me of your order one more time?]
        Oh, sorry-- it's an iced americano with cream.
    -
    
I finally have a tracklist for my album! Now it's time for me to start recording my songs. 
    * [Do you have any band members or will it just be solo? Either way I'm so exciting to hear it!]
        I haven't thought about it yet, do you know any good musicians? Aside from me of course, haha.
        ~ affection++
    * [That's exciting, what are you gonna do about getting a band?]
        I'm working on that...
    -
    
Do you play any instruments?
    * [It's been a few years... but I still have my old guitar I used to play in high school. Since moving here I've really been too busy to play much-- I'm pretty rusty.]
        response 1
        ~ affection++
    * [I don't play any very well at least.]
        response 2
    -
    
Well, I don't have a lot of connections with other musicians in the area, so if you know anyone who'd be interested in playing with me let me know!
    * [Honestly, I'd be down to play some background guitar for you, only if you need it...]
        That would be awesome!! Let's try to hang out sometime to practice. 
        ~ affection++
    * [I'll let you know if any musicians come into the cafe.]
        Thanks Georgie!
    -

Thanks again for the coffee and conversation. Stopping by your cafe is one of the highlights of my day.
    * [Thank you for coming in! I'm so glad that you enjoy stopping by my cafe, it's comforting to have some regular customers!]
        Of course -- see you soon Georgie!
        ~ affection++
    * [Take care, Jennie.]
        Thanks, see you soon.
    -
    -> END
