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

    public void SauverCSV(string nomFichier)
    {
        StreamWriter writer = new StreamWriter(nomFichier);
        foreach (JeuVideo j in this.jeux)
        {
            writer.WriteLine(j.GetTitre() + ";" + j.GetStudio() + ";" + j.GetAnneeSortie().ToString("yyyy-MM-dd") + ";" + j.GetPrix());
        }
        writer.Close();
    }

    public void ChargerCSV(string nomFichier)
    {
        this.jeux.Clear();
        if (File.Exists(nomFichier))
        {
            StreamReader reader = new StreamReader(nomFichier);
            while (!reader.EndOfStream)
            {
                string ligne = reader.ReadLine();
                string[] morceaux = ligne.Split(';');
                JeuVideo j = new JeuVideo();
                j.SetTitre(morceaux[0]);
                j.SetStudio(morceaux[1]);
                j.SetAnneeSortie(DateTime.Parse(morceaux[2]));
                j.SetPrix(double.Parse(morceaux[3]));
                this.jeux.Add(j);
            }
            reader.Close();
        }
    }
}