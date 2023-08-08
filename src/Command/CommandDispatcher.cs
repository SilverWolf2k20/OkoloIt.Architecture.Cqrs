namespace OkoloIt.Architecture.Cqrs.Command;

/// <summary>
/// Диспетчер команд.
/// </summary>
public class CommandDispatcher<TResult> : ICommandDispatcher<TResult>
{
    #region Private Fields

    private readonly IServiceProvider _provider;

    #endregion Private Fields

    #region Public Constructors

    /// <summary>
    /// Создает экземпляр класса диспетчера команд.
    /// </summary>
    /// <param name="provider">Провайдер сервисов.</param>
    public CommandDispatcher(IServiceProvider serviceProvider)
        => _provider = serviceProvider;

    #endregion Public Constructors

    #region Public Methods

    /// <summary>
    /// Выполняет команду
    /// </summary>
    /// <typeparam name="TCommand">Тип команды.</typeparam>
    /// <param name="command">Данные запроса.</param>
    /// <returns>Результат запроса.</returns>
    public TResult Handle<TCommand>(TCommand command)
        where TCommand : ICommand
    {
        var service = _provider.GetService(typeof(ICommandHandler<TCommand, TResult>))
            as ICommandHandler<TCommand, TResult>;

        if (service is null)
            throw new NotImplementedException("Отсутствует данная команда.");

        return service.Handle(command);
    }

    #endregion Public Methods
}