namespace Draugen.ModelFactories
{
    public interface IModelFactory<out T> where T : class
    {
        T Create();
    }
}