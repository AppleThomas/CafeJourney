VAR affection = 0
VAR name = "Jennie"
VAR coffee = ""
-> start

=== start ===
Hey girl! How are you? I'm gonna get my {coffee} today. 
    * [I'm well! One {coffee} coming right up.]
        Thank you so much!
        ~ affection++
    * [...remind me of your order one more time?]
        Oh, sorry-- it's {coffee}.
    -
    
I finally have a tracklist for my album! Now it's time for me to start recording my songs. 
    * [Do you have any band members or will it just be solo?]
        I haven't thought about it yet, do you know any good musicians? Aside from me of course, haha.
        ~ affection++
    * [That's exciting, what are you gonna do about getting a band?]
        I'm working on that...
    -
    
Do you play any instruments?
    * [I don't play any very well at least.]
        You should.
    * [I still have my old guitar I used to play in high school.]
        That's killer, you must've been quite the rocker
        ~ affection++
    -
    
Well, I don't have a lot of connections with other musicians in the area, so if you know anyone who'd be interested in playing with me let me know!
    * [I'd be down to play some background guitar for you]
        That would be awesome!! Let's try to hang out sometime to practice. 
        ~ affection++
    * [I'll let you know if any musicians come into the cafe.]
        Thanks Georgie!
    -

Thanks again for the coffee and conversation. Stopping by your cafe is one of the highlights of my day.
    * [Take care, Jennie.]
        Thanks, see you soon.
     * [I'm so glad, it's comforting to have you stop by]
        Of course -- see you soon Georgie!
        ~ affection++
    -
    -> END
