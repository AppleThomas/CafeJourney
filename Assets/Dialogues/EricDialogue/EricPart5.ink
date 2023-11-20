VAR affection = 0
VAR name = "Eric"
VAR coffee = ""
-> start

=== start ===
Good morning!! I'd love to get a cup of that new {coffee}.
    * [Of course. It's on me today!]
        You're awesome, thank you!
        ~ affection++
    * [You got it.]
        Thanks!
    -
    
Georgie I was wondering, since you went to business school, do you know anyone cool that I would wanna work for?
    * [Yeah for sure!! I can reach out to some people, but...I was wondering if you would wanna help me out with some of the business tasks here?]
        Omg...really??? That would be amazing!
        ~ affection++
    * [Would you maybe wanna help out here?]
        Oh wow...maybe!!
    -
    
What type of help would you need?
    * [I could use some help with the finances of the shop!]
        Of course!
    * [Well, I know you wanted to work somewhere you'd be interested in. Maybe you could help me with finances, but also I could teach you some stuff about coffee?]
        Wow...I'd love that!!!
        ~ affection++
    -
    
I know I haven't known you very long, but I'm so glad we met. I would love to talk more with you about this opportunity!
    * [I'm happy to have met you too! With business growing, I could really use some help]
        Hell yeah!
        ~ affection++
    * [Let's plan a meeting soon.]
        Sounds good!
    -

Thanks for everything, Georgie. Good luck with the rest of your shift!
    * [Have a great day!]
        You too!
    * [Thanks Eric! I'm happy to be here.]
        See you soon!
        ~ affection++
    -
    -> END
