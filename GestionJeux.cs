class GestionJeux
{
    private List<JeuVideo> jeux;

    public List<JeuVideo> GetJeux()
    {
        return this.jeux;
    }
    public void SetJeux(List<JeuVideo> jeux)
    {
        this.jeux = jeux;
    }

    public GestionJeux(List<JeuVideo> jeux)
    {
        this.jeux = jeux;
    }

    public GestionJeux()
    {
        this.jeux = new List<JeuVideo>();
    }

    public void AjouterJeu(JeuVideo jeu)
    {
        this.jeux.Add(jeu);
    }

    public void SuprimerJeu(JeuVideo jeu)
    {
        this.jeux.Remove(jeu);
    }

    public void AfficherJeux()
    {
        Console.WriteLine(" \n*** Liste des jeux vidéo: *** \n");
        foreach (JeuVideo jeu in this.jeux)
        {
            jeu.AfficherDetails();
            Console.WriteLine();
        }
        Console.WriteLine(" ******************************* \n");
    }
}