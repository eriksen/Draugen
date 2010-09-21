namespace Draugen.ModelFactories
{
    public interface IFangsterFactory<out T> where T : class
    {
        T Create(int page);
    }
}