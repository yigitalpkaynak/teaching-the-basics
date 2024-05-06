namespace AracUygulamasi
{
    public class Surucu
    {
        private IArac _arac;
        public Surucu(IArac arac)
        {
            _arac = arac;
        }

        public string Calistir()
        {
            return _arac.Calis();
        }

        public string Sur()
        {
            return _arac.HareketEt();
        }
    }
}