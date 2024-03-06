/// <summary>
/// Результат с ошибкой
/// </summary>
public class ErrorResult : Result
{
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="message"></param>
    public ErrorResult(string message)
    {
        HasError = true;
        Message = message;
    }
}