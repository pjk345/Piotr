namespace Komis1.Models
{
    public class MockSamochodRepository : ISamochodRepository
    {
        private List<Samochod> samochody;

        public MockSamochodRepository()
        {
            if (samochody == null)
            {
                ZaladujSamochody();
            }
        }

        private void ZaladujSamochody()
        {
            samochody = new List<Samochod>() 
            {
                new Samochod { Id=1, Marka = "Ford", Model = "Mustang", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc =  "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Opis = "xxx", Cena = 160000M , ZdjecieUrl = "/images/fordMustang.jpg", MiniaturkaUrl = "/images/fordMustang.jpg", JestSamochodemTygodnia = true },
                new Samochod { Id=2, Marka = "Audi", Model = "S5", RokProdukcji = 2013, Przebieg = "112 000 km", Pojemnosc =  "3 000 cm3", RodzajPaliwa = "benzyna", Moc = "280 KM", Opis = "xxx", Cena = 115000M , ZdjecieUrl = "/images/audiS5.jpg", MiniaturkaUrl = "/images/audiS5.jpg", JestSamochodemTygodnia = true },
                new Samochod { Id=3, Marka = "BMV", Model = "X4", RokProdukcji = 2017, Przebieg = "4 300 km", Pojemnosc =  "1 995 cm3", RodzajPaliwa = "benzyna", Moc = "190 KM", Opis = "xxx", Cena = 194000M , ZdjecieUrl = "/images/bmvx4.jpg", MiniaturkaUrl = "/images/bmvx4.jpg", JestSamochodemTygodnia = true },
            }; 
        }

        public Samochod PobierzSamochodOId(int samochodId);
        {
            return samochody.FirstOrDefault(s => s.Id == samochodId);
        }

    public IEnumerable<Samochod> PobierzWszystkieSamochody();
      {
            return samochody;
       }
    }
}
