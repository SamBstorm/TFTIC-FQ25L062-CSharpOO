using Demo_25_Evenement_02.Models;

Tamagochi cookie = new("Cookie");
Tamagochi pasteque = new("Pasteque");

void Reagir(Tamagochi m) {
    Console.WriteLine("REAGITTT: " + m.Nom);
    m.Nourir();
}

// abonnement à Event +=
cookie.FaimEvent += Reagir;
pasteque.FaimEvent += Reagir;

cookie.FaimEvent += (Tamagochi m) =>
{ // lambda expression
    Console.WriteLine("Lambda " + m.Nom);
};

// désabonner d'un Event -=
//cookie.FaimEvent -= Reagir;

int journee = 0;
while (cookie.estVivant)
{
    journee++;
    Console.WriteLine($"Jour {journee}");
    cookie.PasserJournee();
    pasteque.PasserJournee();
}