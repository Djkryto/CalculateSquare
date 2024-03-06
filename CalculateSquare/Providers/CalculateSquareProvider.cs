
namespace CalculateSquareDI;
/// <inheritdoc/>
public class CalculateSquareProvider : ICalculateSquare
{
    private ICalculatePerimeterProvider _calculateFigureProvider;

    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="calculateFigureProvider"></param>
    public CalculateSquareProvider(ICalculatePerimeterProvider calculateFigureProvider)
    {
        _calculateFigureProvider = calculateFigureProvider;
    }

    /// <inheritdoc/>
    public Result Handle(IList<int> args)
    {
        try
        {
            return args.Count switch
            {
                0 => new ErrorResult("Кол-во аргументов равно 0"),
                1 => _calculateFigureProvider.CalculateCycle(args),
                3 => _calculateFigureProvider.CalculateTriangleRectangular(args),
                _ => _calculateFigureProvider.CalculatePerimeter(args),
            };
        }
        catch (Exception exception)
        {
            return new ErrorResult(exception.Message);
        }
    }
}