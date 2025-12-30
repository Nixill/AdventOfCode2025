using Nixill.Utils.Extensions;

namespace Nixill.AdventOfCode.Year2025;

public static class Functions
{
  public static string RandomColor()
  {
    int low = 0x23;
    int high = 0xCC;
    int mid = Random.Shared.Next(low, high + 1);

    (int red, int green, int blue) = Enumerable
      .OrderBy<int, double>([low, mid, high], i => Random.Shared.NextDouble())
      .Triple();

    return $"{red:x2}{green:x2}{blue:x2}";
  }
}