VAR affection = 0
VAR name = "Eric"
-> start

=== start ===
Script 2
Good morning! Georgie, is it?
    * [Yep! Eric, right?]
        You got it! Good to see you. Can I get the same black coffee I had the other day?
        ~ affection++
    * [Yeah, good morning! What can I get for you?]
        Just a black coffee--light roast, please!
    -
    
How's business going? I remember you said that you run this place yourself.
    * [Pretty good! It can get kind of overwhelming but this is my passion.]
        That makes sense. If you're passionate about something it can make the work worth it!
        ~ affection++
    * [Not too bad!]
        Good to hear.
    -
    
Did you go to school for anything or did you know you were gonna open a cafe?
    * [Both! I went to school for business since I knew I would have to be pretty business-savvy.]
        That's so cool...you know how to run all the different aspects of a cafe.
        ~ affection++
    * [I went to university but it wasn't a great time.]
        Damn, sorry to hear that. At least you found success after!
    -
    
I'm actually in business school right now...alongside my internship. Unpaid, of course. 
    * [That's rough-- hopefully you're getting really good experience since it's unpaid.]
        It's alright...I just wish I could work a regular job already. Interning sucks.
        ~ affection++
    * [That sounds like a lot.]
        Yup.
    -

Thanks for the coffee. It really helps keep me to get through my internship days.
    * [I'm happy it can help! You're working super hard, good luck with everything!]
        Thanks, Georgie-- you too!
        ~ affection++
    * [Have a good day!]
        Thank you!
    -
    -> END
