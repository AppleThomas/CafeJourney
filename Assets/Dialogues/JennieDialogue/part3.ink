VAR affection = 0
VAR name = "Jennie"
VAR coffee = ""
-> start

=== start ===
Hey Georgie! Could I get a {coffee}?
    * [Of course! You seem a bit more upbeat today]
        You're right!
        ~ affection++
    * [You got it!]
        Thanks!
    -
    
I wanted to update you... my audition went really well! The label gave me an offer!
    * [I've never heard of anyone getting signed to a label so quickly.]
        I can't believe it myself. I guess I managed to impress them!
    * [Oh my gosh, that's amazing! You really manifested that!]
        I can't believe my dreams are finally becoming a reality.
        ~ affection++
    -
    
Enough about me... how have things been going for you?
    * [I'm scared to mess it up.]
        I know you're going to do great. Since I came in for the first time, I can see that business is really picking up!
        ~ affection++
    * [I'm doing okay.]
        That's good!
    -
    
What made you dream of running a coffee shop? 
    * [My family owned a cafe.]
        That's cool!
    * [I wanted to make a place for people in the city to feel that kind of community.]
        That's so sweet! You're right, it can get hard to meet friends in such a huge place like this city.
        ~ affection++
    -

I'll see you soon, Georgie! Thanks for the coffee, it's sooo good here.
    * [Glad you like it.]
        Bye!!
    * [I'm happy to hear that, I want to make the best quality coffee that I can.]
        Well, keep doing what you're doing!
        ~ affection++
    -
    -> END
