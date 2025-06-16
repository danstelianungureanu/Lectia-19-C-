using Lectia_19;

class Program
{
    static void Main()
    {
        List<ILivrare> livrari = new List<ILivrare>
        {
            new LivrareDrona("Ion Popescu", "Str. Libertății 45", 2.5),
            new LivrareCurier("Maria Ionescu", "Bd. Unirii 12", 5.0)
        };

        foreach (var livrare in livrari)
        {
            livrare.ShowDeliveryDetails();
            livrare.DeliverPackage();
            Console.WriteLine();
        }
    }
}