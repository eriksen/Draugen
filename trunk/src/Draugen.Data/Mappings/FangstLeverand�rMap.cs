namespace Draugen.Data.Mappings
{
    public class FangstLeverandørMap<T> : KommenterbarMap<T> where T : FangstLeverandør
    {
        public FangstLeverandørMap(string entitetKommentarTabellNavn)
            : base(entitetKommentarTabellNavn)
        {
            Map(x => x.Navn);
            HasMany(x => x.Fangster).Inverse();
        }
    }
}
