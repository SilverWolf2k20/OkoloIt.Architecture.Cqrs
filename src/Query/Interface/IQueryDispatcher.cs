namespace OkoloIt.Architecture.Cqrs.Query
{
    /// <summary>
    /// Интерфейс диспетчера запросов.
    /// </summary>
    public interface IQueryDispatcher
    {
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
            where TResult : class;

        #endregion Public Methods
    }
}