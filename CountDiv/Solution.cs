namespace CountDiv;

public class SolutionClass
{
    public int Solution(int A, int B, int K) {
        int b = B / K;
        int a = (A > 0 ? (A - 1) / K: 0);
        if(A == 0){
            b++;
        }
        return b - a;
    }
}