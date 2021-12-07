
/// <summary>
///  Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
///  You may assume that each input would have exactly one solution, and you may not use the same element twice.
///  You can return the answer in any order.
/// </summary>

//Example data
int[] list = { 15, 11, 7, 2 };
int target = 18;


int[] result = Solutions.OptimalSolution(list, target);

int[] result2 = Solutions.BasicSolution(list, target);


Console.WriteLine(result[0] + " " + result[1]);
