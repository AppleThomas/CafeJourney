VAR affection = 0
VAR name = "Jennie"
-> start

=== start ===
Script 4
Hi Georgie, good to see you! Can I get what I got last time -- the americano with cream?
    * [Of course -- iced, right?]
        Yeah, that's perfect!
        ~ affection++
    * [choice 2]
        Coming right up!
    -
    
I'm so tired today... can I get an extra shot of espresso?
    * [Of course! How come you're extra tired?]
        I was up so late last night sorting through all my old songs. I've had some songs written for years, and I'm having a hard time deciding what to include on my first album.
        ~ affection++
    * [That'll be a dollar upcharge, sorry about that.]
        It's no problem.
    -
    
I've really been writing songs since I was a kid. Did you have any hobbies growing up?
    * [Actually, I've always loved to crochet and create things. My grandma taught me how to crochet when I was eight years old, and I've been hooked ever since.]
        That's so cool! Maybe you could show me how to crochet someday. 
        ~ affection++
    * [I like to crochet.]
        Nice.
    -
    
I just wish I had more time to focus on my music. I have to resort to staying up late, and drinking a lot of coffee to have the energy to work on it after work.
    * [Someday you could be doing music full time, I believe it.]
        You really think so?
        ~ affection++
    * [That's society for ya.]
        I guess you're right... work comes first.
    -

See you soon Georgie, hope the rest of your day goes well. 
    * [Thanks Jennie, get some rest!]
        I appreciate it. See ya tomorrow!
        ~ affection++
    * [Goodbye, see you.]
        Bye!
    -
    -> END
