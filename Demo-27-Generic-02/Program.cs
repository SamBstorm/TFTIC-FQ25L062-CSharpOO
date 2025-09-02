using Demo_27_Generic_02.Models;

Boite<string> boiteDeTexte = new("Du texte");
Boite<int> boiteDeNombre = new(42);
Boite<List<string>> boiteDeListeString = new(["a", "b"]);

boiteDeTexte.Afficher();
boiteDeNombre.Afficher();
boiteDeListeString.Afficher();