namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var runways = new Runway[]
        {
            new Runway(),
            new Runway()
        };

            var aircrafts = new Aircraft[]
            {
            new Aircraft("Boeing 737"),
            new Aircraft("Airbus A320"),
            new Aircraft("Cessna 172")
            };

            var commandCentre = new CommandCentre(runways, aircrafts);

            // Демонстрація
            aircrafts[0].RequestLanding();
            aircrafts[1].RequestLanding();
            aircrafts[2].RequestLanding(); // Очікуємо, що зайняті всі смуги

            aircrafts[0].RequestTakeOff();
            aircrafts[2].RequestLanding(); // Тепер з’явилася вільна смуга
        }
    }
}
