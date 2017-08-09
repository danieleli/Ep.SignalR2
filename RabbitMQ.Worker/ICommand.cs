public interface ICommand<T>
{
    void Execute(T input);
}