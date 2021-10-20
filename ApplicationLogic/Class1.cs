using System;

namespace ApplicationLogic
{
    public static class Class1
    {
        public static string StringRepeat(int repeats, string word)
        {
            string answer = word;
            
            for (int i = 1; i < repeats; i++)
            {
                answer += word;
            }

            return answer;
        }
    }
}
