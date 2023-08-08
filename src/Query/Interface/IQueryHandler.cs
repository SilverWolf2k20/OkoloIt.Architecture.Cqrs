namespace OkoloIt.Architecture.Cqrs.Query;

/// <summary>
/// Интерфейс описания запроса.
/// </summary>
/// <typeparam name="TQuery">Тип принимаемых данных запроса.</typeparam>
/// <typeparam name="TResponse">Тип возвращаемого значения.</typeparam>
public interface IQueryHandler<in TQuery, out TResponse> : IQuery<TResponse>
    where TQuery : IQuery<TResponse>
{
    #region Public Methods

    /// <summary>
    /// Выполняет запрос.
    /// </summary>
    /// <param name="query">Данные для запроса.</param>
    /// <returns>Результат запроса.</returns>
    public TResponse Handle(TQuery query);

    #endregion Public Methods
}