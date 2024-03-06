/// <inheritdoc/>
public class CalculateFigureProvider : ICalculatePerimeterProvider
{
    /// <inheritdoc/>
    public Result CalculateTriangleRectangular(IList<int> args)
    {
        var perimeter = args.Sum();
        var result = args.Where((arg, mainIndex) =>
        {
            var sum = args.Where((arg, customIndex) => customIndex != mainIndex).Sum();
            return sum == arg;
        });

        return result.Any() ? 
        new SuccessResult($"Трегольник равнобедренный. Периметр равен {perimeter}")
        :
        new SuccessResult($"Периметр трегольника равен {perimeter}");

    }

    /// <inheritdoc/>
    public Result CalculateCycle(IList<int> args)
    {
        var arg = args.FirstOrDefault();
        var perimeterRadius = 2 * arg * float.Pi;
        var perimeterDiameter = arg * float.Pi;
        return new SuccessResult($"Длина окружности равена: радиус: {perimeterRadius}\n диаметр: {perimeterDiameter}");
    }

    /// <inheritdoc/>
    public Result CalculatePerimeter(IList<int> args)
    {
        var perimeter = args.Sum(x => x);
        return new SuccessResult("Периметр фигуры равен: " + perimeter);
    }
}