VAR affection = 0
VAR name = "Jennie"
-> start

=== start ===
Oh hey! Can I just get an Americano please? 

I have a big show tonight, and it would be bad if I just start snoozing during my set.
    * [That's fantastic, what do you do?!]
        I'm glad you asked! I do music, it's like a mix between disco pop and funk.
        ~ affection++

    * [I'll get that americano right out for you.]
        I know you didn't ask, but I make music, it's sort of a mix between disco pop and funk.
-

I have big hopes and dreams, tonight will definitely be the breakthrough that I've been hoping for.
    * [Wow that's exciting!]
        I know!
        ~ affection++
    * [It's hard to make dreams into reality.]
        Oh wow...
    -

Oh who am I kidding, it's barely a show. I was hired to be a performer for some kid's birthday party.
    * [We all have to start somewhere!]
        ~ affection++
    * [Dang, I'm sorry about that.]
        ~ affection++
    -

I've had dreams of making it big, performing in sold out venues, headlining for Coachella. Instead...

All I've been able to do is sing Cocomelon songs, while dressed as a clown. I could be touching peoples hearts with my melodies, but instead I'm just trying to keep toddlers from crying.
    * [Maybe the real clown is you.]
        Damn...
        
    * [The Jonas Brothers started off as for kids.]
        You're right!
        ~ affection++
    -
    
Oh sorry, I forgot to introduce myself, I'm Jennie.
    * [Nice to meet you]
        ~ affection++
    * [I'm Georgie!]
        ~ affection++
    -

It was nice talking to you!    

// {affection}
-> END
