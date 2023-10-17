VAR affection = 0
-> start

=== start ===
Oh hey! Can I just get an Americano please? 

I have a big show tonight, and it would be bad if I just start snoozing on my fans.
    * [That's fantastic, what do you do?!]
        I'm glad you asked! I do music, it's like a mix between disco pop and funk.
        ~ affection++

    * [That's nice to hear]
        I know you didn't ask, but I make music, it's sort of a mix between disco pop and funk.
-

I have big hopes and dreams, tonight will definitely be the breakthrough that I've been hoping for.
    * [Wow that's so cool]
        I know!
        ~ affection++
    * [As if]
        Oh wow...
    -

Oh who am I kidding, it's barely a show. I was hired to be a performer for some kids birthday party.
    * [We all have to start somewhere]
        ~ affection++
    * [I'm sorry for your loss]
        ~ affection++
    -

I've had dreams of making it big, performing in sold out venues, headlining for Coachella. Instead...

All I've been able to do is sing Cocomelon songs, while dressed as a clown. I could be touching peoples hearts with my melodies, but instead i'm making balloon animals while having infants vomit on me.
    * [Maybe the real clown is you.]
        Damn...
        
    * [The Jonas Brothers started off as for kids.]
        You're right!
        ~ affection++
    -
    
Oh sorry, I forgot to introduce myself, I'm Eugene.
    * [Nice to meet you]
        ~ affection++
    * [I'm Georgie!]
        ~ affection++
    -

It was nice talking to you!    

// {affection}
-> END
