public class JeuVideo
{
    public string titre { get; set; }
    public string studio { get; set; }
    public DateTime anneeSortie { get; set; }
    public double prix { get; set; }

    public JeuVideo() {} // obligatoire pour la sérialisation XML

    public string GetTitre()
    {
        return this.titre;
    }
    public string GetStudio()
    {
        return this.studio;
    }
    public DateTime GetAnneeSortie()
    {
        return this.anneeSortie;
    }
    public double GetPrix()
    {
        return this.prix;
    }

    public void SetTitre(string titre)
    {
        this.titre = titre;
    }
    public void SetStudio(string studio)
    {
        this.studio = studio;
    }
    public void SetAnneeSortie(DateTime anneeSortie)
    {
        this.anneeSortie = anneeSortie;
    }
    public void SetPrix(double prix)
    {
        this.prix = prix;
    }

    public JeuVideo(string titre, string studio, DateTime anneeSortie, double prix)
    {
        this.titre = titre;
        this.studio = studio;
        this.anneeSortie = anneeSortie;
        this.prix = prix;
    }

    public void AfficherDetails()
    {
        Console.WriteLine(" ------ Détails du jeu vidéo: ------ ");
        Console.WriteLine($"Titre: {this.titre}");
        Console.WriteLine($"Studio: {this.studio}");
        Console.WriteLine($"Année de sortie: {this.anneeSortie}");
        Console.WriteLine($"Prix: {this.prix} euros");
        Console.WriteLine("-----------------------------------");
    }
}