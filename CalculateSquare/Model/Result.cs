/// <summary>
/// Абстрактынй результат
/// </summary>
public abstract class Result
{
    /// <summary>
    /// Имеется ошибка
    /// </summary>
    public bool HasError { get; set; }

    /// <summary>
    /// Сообщение
    /// </summary>
    public string Message { get; set; }
}