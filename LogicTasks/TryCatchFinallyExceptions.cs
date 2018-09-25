namespace LogicTasks
{
    using System;

    public class TryCatchFinallyExceptions
    {
        public int TryCatchFinallyNoVariables()
        {
            Console.WriteLine("TryCatchFinally without variable");

            try
            {
                Console.WriteLine("Try Count - 1");
                return 1;
            }
            catch (Exception)
            {
                Console.WriteLine("Catch Count - 2");
                return 2;
            }
            finally
            {
                Console.WriteLine("Finally Count - 3");
            }

            return 4;
        }
        public int TryCatchFinally()
        {
            Console.WriteLine("TryCatchFinally with local variable");
            
            int countResult = 0;

            Console.WriteLine("Input: " + countResult);

            try
            {
                countResult = 1;
                Console.WriteLine("Try Count - " + countResult);
                return countResult;
            }
            catch (Exception)
            {
                countResult = 2;
                Console.WriteLine("Catch Count - " + countResult);
            }
            finally
            {
                countResult = 3;
                Console.WriteLine("Finally Count - " + countResult);
            }

            return countResult;
        }

        public int TryCatchFinally(int value)
        {
            Console.WriteLine("TryCatchFinally with parameter value");
            Console.WriteLine("Input: " + value);

            try
            {
                value = 1;
                Console.WriteLine("Try Count - " + value);
                return value;
            }
            catch (Exception)
            {
                value = 2;
                Console.WriteLine("Catch Count - " + value);
            }
            finally
            {
                value = 3;
                Console.WriteLine("Finally Count - " + value);
            }

            return value;
        }

        public string TryCatchFinally(string reference)
        {
            Console.WriteLine("TryCatchFinally with reference value");
            Console.WriteLine("Input: " + reference);

            try
            {
                reference = "try";
                Console.WriteLine("Try Count - " + reference);
                return reference;
            }
            catch (Exception)
            {
                reference = "catch";
                Console.WriteLine("Catch Count - " + reference);
            }
            finally
            {
                reference = "finally";
                Console.WriteLine("Finally Count - " + reference);
            }

            return reference;
        }

        public int TryFinally()
        {
            int countResult = 0;

            try
            {
                countResult = 1;
                Console.WriteLine("Count - " + countResult);
                //throw new Exception("Something Wrong");
            }
            finally
            {
                countResult = 2;
                Console.WriteLine("Count - " + countResult);
            }

            return countResult;
        }

        public int TryOnly()
        {
            int countResult = 0;
            try
            {
                Console.WriteLine("Count - " + countResult);
            }
            catch
            {
                Console.WriteLine("Count - " + countResult);
            }

            return countResult;
        }
    }

    public static class TryCatchFinallyStaticExceptions
    {
        public static int TryCatchFinally()
        {
            Console.WriteLine("TryCatchFinally with local variable");

            int countResult = 0;

            Console.WriteLine("Input: " + countResult);

            try
            {
                countResult = 1;
                Console.WriteLine("Try Count - " + countResult);
                return countResult;
            }
            catch (Exception)
            {
                countResult = 2;
                Console.WriteLine("Catch Count - " + countResult);
            }
            finally
            {
                countResult = 3;
                Console.WriteLine("Finally Count - " + countResult);
            }

            return countResult;
        }
    }
}
