namespace Задание_11_Работа_над_ошибками

    internal struct Linear
{
    double k;
    double b;

    public Linear(double k, double b)
    {
        this.k = k;
        this.b = b;
    }

    public string Root()
    {
        if (k == 0 && b == 0)
        { return "x - любое"; }
        else if (k == 0 && b != 0)
        { return "Решений нет"; }
        else
        {
            double x = (-b / k);
            return $"x = {x}";
        }
    }
}
}