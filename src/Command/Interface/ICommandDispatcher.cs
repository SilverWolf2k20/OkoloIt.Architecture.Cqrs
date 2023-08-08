namespace OkoloIt.Architecture.Cqrs.Command
{
    /// <summary>
    /// Интерфейс диспетчера команд.
    /// </summary>
    public interface ICommandDispatcher<out TResult>
    {
        #region Public Methods

        /// <summary>
        /// Выполняет команду 
        /// </summary>
        /// <typeparam name="TCommand">Тип команды.</typeparam>
        /// <param name="command">Данные запроса.</param>
        /// <returns>Результат запроса.</returns>
        public TResult Handle<TCommand>(TCommand command) 
            where TCommand : ICommand;

        #endregion Public Methods
    }
}