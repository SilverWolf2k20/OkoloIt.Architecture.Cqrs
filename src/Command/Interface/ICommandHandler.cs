using Istok.Utilities.Result;

namespace Istok.ProductTree.Cqrs.Command
{
    /// <summary>
    /// Интерфейс описания команды.
    /// </summary>
    /// <typeparam name="TCommand">Тип принимаемых данных команды.</typeparam>
    public interface ICommandHandler<in TCommand>
        : ICommand where TCommand
        : ICommand
    {
        #region Public Methods

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="command">Данные для команды.</param>
        /// <returns>Результат команды.</returns>
        public IResult Handle(TCommand command);

        #endregion Public Methods
    }
}