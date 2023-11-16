using System;

namespace Tumakov10
{
    internal class BCipher : ICipher
    {
        string alfavit_Eng = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
        string alfavit_RU = "абвгдеёжзийклмнорпстуфхцчшщъыьэюяабвгдеёжзийклмнорпстуфхцчшщъыьэюя";
        public string encode(string text)
        {
            text = text.ToLower();
            string result = "";
            Console.WriteLine("Выберите язык RU/EU: ");
            string lang = Console.ReadLine().ToUpper();
            if (lang == "RU")
            {
                foreach (char c in text)
                {
                    byte index = (byte)alfavit_RU.IndexOf(c);
                    int new_index = alfavit_RU.Length - index;
                    if (alfavit_RU.Contains(c.ToString()))
                    {
                        result += alfavit_RU[new_index-1];
                    }
                    else
                    {
                        result += c;
                    }
                }

            }
            else
            {
                foreach (char c in text)
                {
                    {
                        byte index = (byte)alfavit_Eng.IndexOf(c);
                        int new_index = alfavit_Eng.Length - index;
                        if (alfavit_Eng.Contains(c.ToString()))
                        {
                            result += alfavit_Eng[new_index-1];
                        }
                        else
                        {
                            result += c;
                        }
                    }
                }
            }
            return result;
        }
        public string decode(string text)
        {
            text = text.ToLower();
            string result = "";
            Console.WriteLine("Выберите язык RU/EU: ");
            string lang = Console.ReadLine().ToUpper();
            if (lang == "RU")
            {
                foreach (char c in text)
                {
                    byte index = (byte)alfavit_RU.IndexOf(c);
                    int new_index = alfavit_RU.Length - index;
                    if (alfavit_RU.Contains(c.ToString()))
                    {
                        result += alfavit_RU[new_index - 1];
                    }
                    else
                    {
                        result += c;
                    }
                }

            }
            else
            {
                foreach (char c in text)
                {
                    {
                        byte index = (byte)alfavit_Eng.IndexOf(c);
                        int new_index = alfavit_Eng.Length - index;
                        if (alfavit_Eng.Contains(c.ToString()))
                        {
                            result += alfavit_Eng[new_index - 1];
                        }
                        else
                        {
                            result += c;
                        }
                    }
                }
            }
            return result;
        }
    }
}
