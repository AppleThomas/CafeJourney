VAR affection = 0
VAR name = "Eric"
VAR coffee = ""
-> start

=== start ===
Good morning, Georgie. Can I get a {coffee}
    * ['Morning!]
        If I could get my usual {coffee} that would be great.
    * [Hey Eric, glad to see you! I'll get your {coffee} right out.]
        You're the best, thanks.
        ~ affection++
    -
    
Guess what...I was offered a position at my company.
    * [Dude that's awesome-- you worked so hard for it, and there was a lot of competition. Congrats!]
        Thanks Geogie, that means a lot to me.
        ~ affection++
    * [Period!]
        Yeah...hahah.
    -
    
I didn't accept the offer. I've been thinking about it all week...but I don't think a boring corporate job is for me. I wanna explore something new.
    * [Oh, yeah, that makes sense!]
        I think so at least! I'm a little nervous though...I hope another opportunity presents itself.
    * [Dude! I'm proud of you. That's a hard decision to make, but it's your life. You gotta do what's best for you!]
        Honestly I'm glad you said that. It feels right, but I know it's not a typical decision.
        ~ affection++
    -
    
I know that decision is a little risky, but with the experience the internship gave me I know I can find something.
    * [It'll be hard but you've got this.]
        Thank you.
    * [This city is huge...there's a place for you, I promise.]
        You're right. I just have to find something that feels right.
        ~ affection++
    -

Last coffee tastes different...but good! It kinda tastes like fruit.
    * [You said you didn't know much about coffee, but you've got the flavor notes down!]
        I guess I just needed to try some better coffee--I owe it to you!
        ~ affection++
    * [That coffee was new, I'm glad you like it.]
        See you later!
    -
    -> END
