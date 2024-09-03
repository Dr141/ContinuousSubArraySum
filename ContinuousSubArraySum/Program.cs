using ContinuousSubArraySum;

int[] nums = { 23, 2, 4, 6, 7};
int[] nums1 = { 23, 2, 4, 6, 7, 1 };
int[] nums2 = { 23, 2, 3, 6, 7};
int[] nums3 = { 23, 2, 6, 7 };
int[] nums4 = { 23, 5, 2, 4, 7, 3 };
int[] nums5 = { 0, 6, 2, 1, 4, 7, 1 };
int[] nums6 = { 23, 6, 2 };
Console.WriteLine($"Resultado: {SubArraySum.CheckSubarraySum(nums, 6)}");
Console.WriteLine($"Resultado1: {SubArraySum.CheckSubarraySum(nums1, 6)}");
Console.WriteLine($"Resultado2: {SubArraySum.CheckSubarraySum(nums2, 6)}");
Console.WriteLine($"Resultado3: {SubArraySum.CheckSubarraySum(nums3, 23)}");
Console.WriteLine($"Resultado4: {SubArraySum.CheckSubarraySum(nums4, 6)}");
Console.WriteLine($"Resultado4: {SubArraySum.CheckSubarraySum(nums5, 7)}");
Console.WriteLine($"Resultado4: {SubArraySum.CheckSubarraySum(nums6, 8)}");
Console.ReadLine();