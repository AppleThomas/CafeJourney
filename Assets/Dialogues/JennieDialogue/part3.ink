VAR affection = 0
VAR name = "Jennie"
-> start

=== start ===
Script 3
Hey Georgie! Could I get an iced americano with cream?
    * [Of course! Switching up your order a bit today I see!]
        You're right, I usually always get it black but I wanted to try something new.
        ~ affection++
    * [You got it!]
        Thanks!
    -
    
I wanted to update you... my audition went really well! The label gave me an offer!
    * [Oh my gosh, that's amazing! You really manifested that!]
        I can't believe my dreams are finally becoming a reality.
        ~ affection++
    * [I've never heard of anyone getting signed to a label so quickly.]
        I can't believe it myself. I guess I managed to impress them!
    -
    
Enough about me... how have things been going for you?
    * [I'm trying my best to run this shop, but it's all so new. My dream for years was to own a place like this, but now that I'm doing it I'm scared to mess it up.]
        I know you're going to do great. Since I came in for the first time, I can see that business is really picking up!
        ~ affection++
    * [I'm doing okay.]
        That's good!
    -
    
What made you dream of running a coffee shop? 
    * [Honestly it's been a goal of mine for a really long time. My aunt owned a coffee shop back in the day in my hometown, and it helped me meet so many incredible people. I wanted to make a place for people in the city to feel that kind of community.]
        That's so sweet! You're right, it can get hard to meet friends in such a huge place like this city.
        ~ affection++
    * [My family owned a cafe.]
        That's cool!
    -

I'll see you soon, Georgie! Thanks for the coffee, it's sooo good here.
    * [I'm happy to hear that, I want to make the best quality coffee that I can.]
        Well, keep doing what you're doing!
        ~ affection++
    * [Glad you like it.]
        Bye!!
    -
    -> END
