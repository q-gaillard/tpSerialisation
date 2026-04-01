using System.IO;
using System.Xml.Serialization;


public class GestionJeux
{
    public List<JeuVideo> jeux { get; set; }

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

    // Méthodes pour la sauvegarde et le chargement en CSV
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

    // Méthodes pour la sauvegarde et le chargement en XML
    public void SauverXml(string nomFichier)
    {
        XmlSerializer xs = new XmlSerializer(typeof(List<JeuVideo>));
        StreamWriter writer = new StreamWriter(nomFichier);
        xs.Serialize(writer, this.jeux);
        writer.Close();
    }

    public void ChargerXml(string nomFichier)
    {
        if (File.Exists(nomFichier))
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<JeuVideo>));
            StreamReader reader = new StreamReader(nomFichier);
            this.jeux = (List<JeuVideo>)xs.Deserialize(reader);
            reader.Close();
        }
    }
}