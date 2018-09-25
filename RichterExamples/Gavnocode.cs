namespace RichterExamples
{
    using System;

    public class Gavnocode
    {
        int a;

        // Зато наверняка!
        public int InitAValue(int value)
        {
            a = value;

            if (a != value)
            {
                try
                {
                    a = value;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            else 
            {
                a = value;
            }

            return a;
        }

        
        private bool CheckIfTrueOrFalce(bool value)
        {
            if (value.ToString().Length == 4) 
            {
                return true;
            }
            else if(value.ToString().Length == 5)
            {
                return false;
            }
            else 
            {
                return !true && !false;
            }
        }

        public bool SetValue146Percents()
        {
            bool exitstatus = true;

            if (!exitstatus) 
            { 
                exitstatus = true; 
            }

            return exitstatus;
        }

        public bool CheckState(bool? state) => state == null == false;

        private bool IsNumber (string str) 
        { 
            return (str.Replace ("0", "").Replace ("1", "")
            .Replace ("2", "").Replace ("3", "").Replace ("4", "")
            .Replace ("5", "").Replace ("6", "").Replace ("7", "")
            .Replace ("8", "").Replace ("9", "").Length == 0);
        }

        private bool IsStringIsNotEmpty(string s)
        {
            return s.Length > 0;
        }

        private bool IsSingleNumber(uint i)
        {
            if(i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8 || i == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsSingleNumberRefactored(uint i)
        {
            if (i.ToString().Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateCounter(double counter)
        {
            return ((int)(counter / 2) != (counter / 2.00) && counter != 0);
        }

        private void SwitchWhatIWant(bool option)
        {
            switch (option)
            {
                case true: 
                Console.WriteLine("Option 1");
                break;
                
                case false: 
                Console.WriteLine("Option 2");
                break;             

                default: 
                Console.WriteLine("Option Unspecified");
                break;
            }
        }

        private static object CopyCustomObject(object originalObj, ICopyContext context)
        {
            return originalObj;
        }

        public bool CheckBool(string value)
        {
           value = value.ToLower();
           return !string.IsNullOrEmpty(value) && (value == "on" || value == "yes"|| value == "ok" ||value == "da" || value == "1") ? true : false;
        }

        public void CompareWait(int displayCharactersCount)
        {
            var actualCharCount = displayCharactersCount;

            while (displayCharactersCount != actualCharCount)
            {
                Thread.Sleep(500);
            }
        }

        public bool CheckValue(int value)
        {
            if(value != 0 && value.ToString() != "58974563215896426")
            {
                return false;
            }
            else
            {
                return true;                
            }
        } 
    }
}