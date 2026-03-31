namespace tp_serialisation;

class Program
{
    static void Main(string[] args)
    {
        GestionJeux gestionJeux = new GestionJeux();
        gestionJeux.AjouterJeu(new JeuVideo("Minecraft", "Mojang", new DateTime(2009, 5, 17), 29.99));
        gestionJeux.AjouterJeu(new JeuVideo("Mario Kart 8 Deluxe", "Nintendo", new DateTime(2017, 10, 20), 59.99));
        gestionJeux.AjouterJeu(new JeuVideo("The Witcher 3", "CD Projekt", new DateTime(2015, 5, 19), 39.99));
        gestionJeux.AfficherJeux();

        GestionJeux gestionJeux2 = new GestionJeux();
    }
}
