using System.Linq;

namespace Collections
{
    public class SumN
    {
        public int N { get; set; } = 1 * 1000 * 1000;

        public long Solution1()
        {
            return Enumerable.Range(1, N)
                .ToList()
                .Aggregate((x, y) => x + y);
        }
    }
}