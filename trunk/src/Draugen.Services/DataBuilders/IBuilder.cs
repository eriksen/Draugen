namespace Draugen.Services.DataBuilders
{
    public interface IBuilder<out T> 
    {
        T Build();
    }
}