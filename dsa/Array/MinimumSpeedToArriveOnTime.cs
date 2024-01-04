using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class MinimumSpeedToArriveOnTime
    {

        public static void Solution(int[] dist, double hour)
        {
            Console.WriteLine(MinSpeedOnTime(dist, hour));
        }


        private static int MinSpeedOnTime(int[] dist, double hour)
        {
            if (dist.Length == 1)
            {
                var speed = (dist[0] / hour);
                if (speed % 1 > 0.99)
                {
                    double additionalTime = 1.00 - speed % 1;
                    speed += additionalTime;
                }
                return (int)(speed);
            }

            int minSpeed = 1;
            int maxSpeed = 10000000;
            int ans = -1;

            while (minSpeed <= maxSpeed)
            {
                int mid = minSpeed + (maxSpeed - minSpeed) / 2;
                bool isValidSpeed = ValidateSpeed(dist, hour, mid);
                if (isValidSpeed)
                {
                    ans = mid;
                    maxSpeed = mid - 1;
                }
                else minSpeed = mid + 1;
            }
            return ans;
        }

        private static bool ValidateSpeed(int[] dist, double hour, int speed)
        {
            double hourExpend = 0.00;

            for (int i = 0; i < dist.Length; i++)
            {
                hourExpend += dist[i] / (double)speed;
                if (hourExpend > hour) return false;
                if (hourExpend % 1 != 0)
                {
                    //double additionalTime = 1.00 - hourExpend % 1;
                    //hourExpend += additionalTime;
                    hourExpend = double.Ceiling(hourExpend);
                }
            }
            return true;
        }
    }
}
