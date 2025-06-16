namespace Lectia_19
{
    // Interfața pentru abstractizare
    interface ILivrare
    {
        void DeliverPackage();
        void ShowDeliveryDetails();
    }

    // Clasa de bază abstractă
    abstract class Livrare : ILivrare
    {
        private static int nextId = 1;

        public int Id { get; }
        protected string Destinatar { get; set; }
        protected string Adresa { get; set; }
        protected double Greutate { get; set; }

        public Livrare(string destinatar, string adresa, double greutate)
        {
            Id = nextId++;
            Destinatar = destinatar;
            Adresa = adresa;
            Greutate = greutate;
        }

        public abstract void DeliverPackage();
        public abstract void ShowDeliveryDetails();
    }
    class LivrareDrona : Livrare
    {
        private double AltitudineZbor { get; set; } = 120.0;

        public LivrareDrona(string destinatar, string adresa, double greutate)
            : base(destinatar, adresa, greutate) { }

        public override void DeliverPackage()
        {
            Console.WriteLine($"[Dronă] Livrare ID #{Id} – zboară la altitudine {AltitudineZbor}m...");
        }

        public override void ShowDeliveryDetails()
        {
            Console.WriteLine($"[Dronă] ID: {Id}, Destinatar: {Destinatar}, Adresă: {Adresa}, Greutate: {Greutate} kg");
        }
    }
    // Livrare prin curier uman
    class LivrareCurier : Livrare
    {
        private string NumeCurier { get; set; } = "Curier Standard";

        public LivrareCurier(string destinatar, string adresa, double greutate)
            : base(destinatar, adresa, greutate) { }

        public override void DeliverPackage()
        {
            Console.WriteLine($"[Curier] Livrare ID #{Id} – {NumeCurier} este în drum spre {Adresa}...");
        }

        public override void ShowDeliveryDetails()
        {
            Console.WriteLine($"[Curier] ID: {Id}, Destinatar: {Destinatar}, Adresă: {Adresa}, Greutate: {Greutate} kg");
        }
    }
}
