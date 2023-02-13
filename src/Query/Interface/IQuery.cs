namespace OkoloIt.Architecture.Cqrs.Query
{
    /// <summary>
    /// Интерфейс описания данных для запроса.
    /// </summary>
    /// <typeparam name="TResponse">Тип возвращаемого значения.</typeparam>
    public interface IQuery<out TResponse> 
    {
    }
}