namespace TWOSUM
{
    public class MAIN
    {
        public static void Main()
        {
            int[] nums = [2,7,11,15];
            int target = 9;
            int x = 0, i = 0, p = nums.Length - 1 , t = p;
            
            while (x != target)
            {
                x = nums[i] + nums[t];
                if (x != target)
                {
                t--;
                    if (t == 0)
                    {
                    t = p ;
                    i++;
                        if (i >= p)
                        {
                            Console.WriteLine("não foi possivel encontrar o target");
                        return;
                        }
                    }
                }
                else if (x == target)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(t);
                return;
                }
            }
        }
    }
}
