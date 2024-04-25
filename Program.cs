internal class Program
{
    private static void Main(string[] args)
    {
        Wood wood = new Wood();
        wood.Efect();
    }
}

public interface IDamger
{
    void Efect();
}

public class Wood : IDamger
{
    public void Efect()
    {
        Console.WriteLine("Tao lo tren manh go");
    }
}
public class Iron : IDamger
{
    public void Efect()
    {
        Console.WriteLine("Tao tia lua");
    }
}
public class Grass : IDamger
{
    public void Efect()
    {
        Console.WriteLine("Tao bun dat ban len");
    }
}
public class Bullet
{
    Wood bulletCollider = new Wood();

}