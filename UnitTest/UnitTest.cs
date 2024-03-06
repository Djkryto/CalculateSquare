using CalculateSquareDI;

namespace UnitTest;

public class Tests
{
    static object[] Parameters =
    {
        new object[] { new int[] {4}, "����� ���������� ������: " },
        new object[] { new int[] { 4, 3, 7 }, "���������� ��������������. �������� ����� " },
        new object[] { new int[] { 4, 3, 2 }, "�������� ����������� ����� " },
        new object[] { new int[] { 4, 3, 7, 5 }, "�������� ������ �����: " },
    };

    [TestCaseSource(nameof(Parameters))]
    public void TestPerimeterProvider(int[] args, string outResult)
    {
        var figures = new CalculateFigureProvider();
        var perimeter = new CalculateSquareProvider(figures);

        var result = perimeter.Handle(args);

        var expected = Calculate(args, outResult); 

        Assert.AreEqual(expected, result.Message);
    }

    [TestCaseSource(nameof(Parameters))]
    public void TestFigureProvider(int[] args, string outResult)
    {
        var provider = new CalculateFigureProvider();

        var result = args.Length switch
        {
            1 => provider.CalculateCycle(args),
            3 => provider.CalculateTriangleRectangular(args),
            _ => provider.CalculatePerimeter(args)
        };

        var expected = Calculate(args, outResult);

        Assert.AreEqual(expected, result.Message);
    }

    private string Calculate(int[] args, string outResult)
    {
        if (args.Length == 1)
        {
            var arg = args.FirstOrDefault();
            var perimeterRadius = 2 * arg * float.Pi;
            var perimeterDiameter = arg * float.Pi;

            outResult += $"������: {perimeterRadius}\n ";
            outResult += $"�������: {perimeterDiameter}";
        }
        else
        {
            outResult += args.Sum();
        }

        return outResult;
    }
}