namespace ContinuousSubArraySum
{
    public static class SubArraySum
    {
        public static bool CheckSubarraySum(int[] nums, int k)
        {
            if(nums.Length >= 2)
            {
                int modulo = nums.Sum() % k;                
                if (modulo.Equals(0)){ return true; }
                
                if(nums.Length > 2)
                {                    
                    int i = 0;
                    int sum = 0;
                    while (i < nums.Length)
                    {   
                        if (nums[i] < k && sum + nums[i] <= k)
                        {
                            sum += nums[i];
                            int aux = i + 1;
                            while (aux < nums.Length) 
                            {
                                sum += nums[aux];
                                aux++;
                                if (sum == k && sum % k == 0) { return true; }   
                                if(sum > k)
                                {
                                    sum = 0;
                                    break;
                                }
                            }
                        }
                        
                        i++;
                    }
                }
            }

            return false;
        }
    }
}
