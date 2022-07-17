using Exception_Custom_.Exceptions;
using System;
using System.Collections.Generic;

namespace Exception_Custom_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exception
            //List<string> checklist = new List<string>();

            //checklist.Add("Huseyn");
            //checklist.Add("Hesen");
            //checklist.Add("dayi");
            //checklist.Add("ayi");

            //string searchText = "Huseyn";
            //CheckString(checklist, searchText);
            #endregion

            #region CustomExceptionMethod(1)

            //LoginException("huseynnjj", "huseyn123");

            #endregion

            #region CustomExceptionMethod(2)

            //List<string> listUsername = new List<string>() { "huseyn1", "huseyngd", "Hyseyn12", "huseynnj" };

            //List<string> listPassword = new List<string>() { "huseyn112", "124568", "123huseyn", "huseyn12345" };

            //string searchUsername = "45huseynnj";

            //string searchPassword = "hus545yn12345";

            //LoginException(listUsername, searchUsername, listPassword, searchPassword);

            #endregion




        }

        #region Exception

        //public static void CheckString(List<string> names, string name)
        //{
        //    try
        //    {
        //        var data = names.Find(m => m == name);
        //        if (data is null) throw new CheckString("Not Found Name");
        //        Console.WriteLine("Doğrudurr, Ne bildin Ala");
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
        //}
        #endregion

        #region CustomExceptionMethod(1)

        //public static void LoginException(string username, string password)
        //{
        //    try
        //    {
        //        if (username == "huseynnj" && password == "huseyn123")
        //        {
        //            throw new Login("Entered");

        //        }
        //        else
        //        {
        //            Console.WriteLine("Username or Password incorrect");
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }

        //}
        #endregion

        #region CustomExceptionMethod(2)

        //public static void LoginException(List<string> username,string user,List<string> password,string pass)
        //{
        //    try
        //    {
        //        if (!username.Contains(user) && !password.Contains(pass))
        //        {
        //            throw new Login("Username or Password incorret");
        //        }

        //        //var data = username.Find(m => m == user);
        //        //var data1 = password.Find(m => m == pass);

        //        //if (data is null && data1 is null) throw new Login("Username or Password Incorret");

        //        Console.WriteLine("Entered");
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
        //}

        #endregion

        




    }
}