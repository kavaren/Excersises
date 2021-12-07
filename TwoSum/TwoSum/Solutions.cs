internal class Solutions
{

    public static int[] BasicSolution(int[] listOfNumbers, int targetValue)
    {
        int[] list = listOfNumbers;
        int target = targetValue;
        int[] result = new int[2];

        for (int i = 0; i < list.Length; i++)
        {
            for (int j = 0; j < list.Length; j++)
            {
                if ((list[i] + list[j]) == target)
                {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }
        }
        return result;
    }

    public static int[] OptimalSolution(int[] listOfNumbers, int targetValue)
    {
        int[] list = listOfNumbers;
        int target = targetValue;
        Dictionary<int, int> map = new();
        int diff;
        int[] result = new int[2];
        int i = 0;

        foreach (var item in list)
        {
            diff = target - item;
            if (map.ContainsKey(diff))
            {
                result[0] = map[diff];
                result[1] = i;
            }
            else
            {
                map[item] = i;
            }
            i++;
        }
        return result;
    }
}