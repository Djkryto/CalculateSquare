/// <summary>
/// Успешный результат
/// </summary>
public class SuccessResult : Result
{
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="message"></param>
    public SuccessResult(string message)
    {
        HasError = false;
        Message = message;
    }
}