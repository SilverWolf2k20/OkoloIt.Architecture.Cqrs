namespace OkoloIt.Architecture.Cqrs.Query;

/// <summary>
/// Диспетчер запросов.
/// </summary>
public class QueryDispatcher : IQueryDispatcher
{
    #region Private Fields

    private readonly IServiceProvider _provider;

    #endregion Private Fields

    #region Public Constructors

    /// <summary>
    /// Создает экземпляр класса диспетчера запросов.
    /// </summary>
    /// <param name="provider">Провайдер сервисов.</param>
    public QueryDispatcher(IServiceProvider provider)
        => _provider = provider;

    #endregion Public Constructors

    #region Public Methods

    /// <summary>
    /// Выполняет команду
    /// </summary>
    /// <typeparam name="TQuery">Тип запроса.</typeparam>
    /// <typeparam name="TResult">Тип резальтата.</typeparam>
    /// <param name="query">Данные запроса.</param>
    /// <returns>Результат запроса.</returns>
    public TResult? Handle<TQuery, TResult>(TQuery query)
        where TQuery : IQuery<TResult>
        where TResult : class
    {
        var service = _provider.GetService(typeof(IQueryHandler<TQuery, TResult>))
            as IQueryHandler<TQuery, TResult>;

        return service?.Handle(query);
    }

    #endregion Public Methods
}