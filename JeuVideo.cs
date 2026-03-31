class JeuVideo
{
    protected string titre;
    protected string studio;
    protected DateTime anneeSortie;
    protected double prix;

    public string GetTitre()
    {
        return this.titre;
    }
    public string GetGenre()
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
    public JeuVideo()
    {
        this.titre = "Inconnu";
        this.studio = "Inconnu";
        this.anneeSortie = DateTime.Now;
        this.prix = 0;
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