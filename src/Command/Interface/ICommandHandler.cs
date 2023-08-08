namespace OkoloIt.Architecture.Cqrs.Command
{
    /// <summary>
    /// Интерфейс описания команды.
    /// </summary>
    /// <typeparam name="TCommand">Тип принимаемых данных команды.</typeparam>
    public interface ICommandHandler<in TCommand, out TResult>
        : ICommand where TCommand
        : ICommand
    {
        #region Public Methods

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="command">Данные для команды.</param>
        /// <returns>Результат команды.</returns>
        public TResult Handle(TCommand command);

        #endregion Public Methods
    }
}