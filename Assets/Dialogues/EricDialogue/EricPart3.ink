VAR affection = 0
VAR name = "Eric"
-> start

=== start ===
Script 3
Good morning Georgie! How's it going?
    * [Hey Eric, it's going well! Been a busy morning so far, I think there's a conference happening next door.]
        Good to hear! It seems pretty packed in here today.
        ~ affection++
    * [It's going alright...I'm pretty tired though.]
        You're in a good spot for it though-- there's free coffee whenever you need it!
    -
    
It's crazy how many businessmen from my company are here right now...I feel kinda intimidated. I wonder if they know I intern for their company.
    * [You should introduce yourself to some of them! Hopefully this internship could get you a permanent spot at the company.]
        You're right...who knows who I might meet. Maybe there are some managers here...
        ~ affection++
    * [That's fair, it can be hard to get noticed in a big company.]
        Yeah, there's a lot of people competing for permanent positions.
    -
    
I don't know how these guys seem interested in this company. Who wants to spend all their time working for a car insurance business.
    * [What type of business would you wanna work for?]
        I'm not sure...I don't mind the work I'm doing, but I wanna work for someone who's passionate about what their company does.
        ~ affection++
    * [I guess it just pays the bills.]
        Damn, you're right.
    -
    
If I'm being honest, I don't think I wanna work for this company when my internship is over. I wanna work for a business that's doing something cool, or new.
    * [That's okay! You're learning so much right now that will help you when you look for a job you really want.]
        You're right. Once I graduate I can expand my horizons.
        ~ affection++
    * [Fair enough, from the look of these guys the company doesn't seem too interesting.]
        You've got that right.
    -

Thanks again for the coffee--I can't get enough of it, it's so flavorful!
    * [It makes me so happy you like it as much as I do! See you soon.]
        Bye Georgie!
        ~ affection++
    * [See you soon!]
        See ya!
    -
    -> END
