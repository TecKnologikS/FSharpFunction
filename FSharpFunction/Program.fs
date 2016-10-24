open System

let bonjour = 
    printfn "Coucou"

let bonjourToi prenom = 
    printfn "Coucou %s" prenom

let bonjourToiString prenom : string = 
    sprintf "Coucou %s" prenom

let bonjourVous prenom prenom2 = 
    printfn "Coucou %s et %s" prenom prenom2

[<EntryPoint>]
let main argv = 
    
    bonjour
    bonjourToi "toto"
    printfn "%s" (bonjourToiString "toto2")
    bonjourVous "toto" "tata"

    let stop = Console.ReadLine()

    1
