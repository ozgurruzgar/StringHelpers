using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    public class StringHelpers
    {
        //Requirements:
        //1. Must delete more blanks recieved head and end statements.
        //2. Must delete more blanks recieved in statements.  
        public static string DeleteToMoreBlank(string statement)
        {
            statement = statement.Trim();

            string newStatement = string.Empty;

            for (int i = 0; i < statement.Length; i++)
            {
                if (statement[i] == ' ' && statement[i + 1] == ' ')
                    continue;

                newStatement += statement[i];
            }
            return newStatement;
        }
    }
}
