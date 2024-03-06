/// <summary>
/// Поставщик расчёта периметра геометрических фигур
/// </summary>
public interface ICalculatePerimeterProvider
{
    /// <summary>
    /// Расчёт периметра прямоугольного треугольника
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public Result CalculateTriangleRectangular(IList<int> args);

    /// <summary>
    /// Расчёт периметра круга
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public Result CalculateCycle(IList<int> args);

    /// <summary>
    /// Расчёт периметра
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public Result CalculatePerimeter(IList<int> args);
}