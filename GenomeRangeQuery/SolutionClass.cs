namespace MissingIntegers;

public class SolutionClass
{
    public int[] Solution(string genome, int[] p, int[] q)
    {
        string impactFactors = "ACGT";
        var m = p.Length;
        int[] response = new int[m];
        var responseIndex = 0;

        for (int i = 0; i < m; i++)
        {
            int minNucleotide = Int32.MaxValue;

            for (int j = p[i]; j <= q[i]; j++)
            {
                if ((impactFactors.IndexOf(genome[j]) + 1) < minNucleotide)
                {
                    minNucleotide = (impactFactors.IndexOf(genome[j]) + 1);
                }
            }

            response[responseIndex] = minNucleotide;
            responseIndex++;
        }

        return response;
    }
}