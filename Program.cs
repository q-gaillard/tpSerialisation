using System.IO;
using System;

namespace tp_serialisation;

class Program
{
    static void Main(string[] args)
    {
        GestionJeux gestionJeux = new GestionJeux();
        gestionJeux.AjouterJeu(new JeuVideo("Minecraft", "Mojang", new DateTime(2009, 5, 17), 29.99));
        gestionJeux.AjouterJeu(new JeuVideo("Mario Kart 8 Deluxe", "Nintendo", new DateTime(2017, 10, 20), 59.99));
        gestionJeux.AjouterJeu(new JeuVideo("The Witcher 3", "CD Projekt", new DateTime(2015, 5, 19), 39.99));
        gestionJeux.AjouterJeu(new JeuVideo("The Legend of Zelda: Breath of the Wild", "Nintendo", new DateTime(2017, 3, 3), 59.99));
        gestionJeux.AjouterJeu(new JeuVideo("Among Us", "InnerSloth", new DateTime(2018, 6, 15), 4.99));
        gestionJeux.AfficherJeux();

        // Sauvegarder les jeux dans un fichier CSV
        Console.WriteLine("\nSauvegarde des jeux dans un fichier CSV :\n");
        GestionJeux gestionJeux2 = new GestionJeux();
        gestionJeux2.AfficherJeux();
        gestionJeux.SauverCSV("jeux.csv");
        gestionJeux2.ChargerCSV("jeux.csv");
        gestionJeux2.AfficherJeux();

        // Sauvegarder les jeux dans un fichier XML
        Console.WriteLine("\nSauvegarde des jeux dans un fichier XML :\n");
        GestionJeux gestionJeux3 = new GestionJeux();
        gestionJeux3.AfficherJeux();
        gestionJeux.SauverXml("jeux.xml");
        gestionJeux3.ChargerXml("jeux.xml");
        gestionJeux3.AfficherJeux();

        // Sauvegarder les jeux dans un fichier JSON
        Console.WriteLine("\nSauvegarde des jeux dans un fichier JSON :\n");
        GestionJeux gestionJeux4 = new GestionJeux();
        gestionJeux4.AfficherJeux();
        gestionJeux.SauverJson("jeux.json");
        gestionJeux4.ChargerJson("jeux.json");
        gestionJeux4.AfficherJeux();
    }
}
