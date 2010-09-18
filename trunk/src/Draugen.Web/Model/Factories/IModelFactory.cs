namespace Draugen.Model.Factories
{
    public interface IModelFactory<out T> where T : class
    {
        T Create();
    }
}