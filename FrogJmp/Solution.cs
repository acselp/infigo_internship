namespace FrogJmp;

public class SolutionClass
{
    public int Solution(int X, int Y, int D)
    {
        if (((Y - X) % D) == 0)
        {
            return ((Y - X) / D);
        }
        
        return ((Y - X) / D) + 1;
    }
}