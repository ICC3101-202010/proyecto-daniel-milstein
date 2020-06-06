using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;


namespace Proyecto
{
    [Serializable]
    public static class Spotflix
    {
        private static Dictionary<string, User> UserDB;
        private static List<Media> MediaDB;
        private static List<Person> PeopleDB;


        

        static Spotflix()
        {
            
            
            var load = Load("Spotflix.bin");

            Dictionary<string, User> userDB = load.Item1;
            List<Media> mediaDB = load.Item2;
            List<Person> peopleDB = load.Item3;


            UserDB = userDB;
            MediaDB = mediaDB;
            PeopleDB = peopleDB;
            
        }

        

        public static List<Person> GetPeopleDB
        {
            get
            {
                return PeopleDB;
            }
        }

        public static List<Media> GetMediaDB { get { return MediaDB; } }

        public static void SetMediaDB(List<Media> mediaDB) { mediaDB = MediaDB; }

        public static void SetUserDB(Dictionary<string, User> userDB) { userDB = UserDB; }

        public static void AddPerson(Person person)
        {
            PeopleDB.Add(person);
        }

        public static void SaveMedia(Media media)
        {
            MediaDB.Add(media);
        }

        public static void AddUser(User user)
        {
            UserDB.Add(user.GetUsername(), user);
        }



        public static Dictionary<string, User> GetUserDB
        {
            get
            {
                return UserDB;
            }
        }

        public static void ImportMedia(Media media)
        {

            //Media a = new Media();

            MediaDB.Add(media);
        }


        public static string LogIn(string username, string password)
        {

            User user = UserDB[username];
            try
            {
                if (user.GetPassword() == password)
                {
                    return username;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }

        }
        public static string AdminLogIn(string username, string password)
        {
            string admin = LogIn(username, password);
            User user = UserDB[admin];
            if (user.GetAdmin() == true)
            {
                return username;
            }
            else
            {
                return "";
            }


        }

        public static void Register()
        {
            string username = null;
            string password = null;
            string password2 = null;
            string email = null;
            bool privateAccount = true;
            bool premium = false;
            string a = null;
            string b = null;
            string c = null;
            string d = null;
            bool usertaken = false;
            bool emailtaken = false;
            string pvt = "";
            string prem = "";

            List<string> registrationForm = new List<string>()
            {
                "Username: ",
                "Email: ",
                "Password: ",
                "Confirm password: ",
                "Private account? y/n",
                "Premium user? y/n",
                "Ready!",
                "Back"
            };

            List<string> yesNo = new List<string>() { "Yes", "No" };

            while (true)
            {

                string sel = RegexUtilities.GetMenu(registrationForm);

                if (sel == registrationForm[0])
                {
                    registrationForm[0] = registrationForm[0].Substring(0, 10);
                    Console.Clear();
                    RegexUtilities.LoadingScreen();
                    Console.CursorVisible = true;
                    username = RegexUtilities.WriteData(registrationForm[0]);
                    Console.CursorVisible = false;
                    usertaken = UserDB.ContainsKey(username);
                    if (usertaken == true)
                    {
                        usertaken = true;
                        Console.Clear();
                        RegexUtilities.LoadingScreen();
                        Console.WriteLine("Username taken, please choose a different one.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        registrationForm[0] += username;
                        usertaken = false;
                    }

                    Console.Clear(); RegexUtilities.LoadingScreen();

                }
                else if(sel == registrationForm[1])
                {
                    registrationForm[1] = registrationForm[1].Substring(0, 7);
                    Console.Clear();
                    RegexUtilities.LoadingScreen();
                    Console.CursorVisible = true;
                    email = RegexUtilities.WriteData(registrationForm[1]);
                    foreach (User user in UserDB.Values)
                    {
                        if (user.GetEmail() == email)
                        {
                            emailtaken = true;
                            break;
                        }
                        else
                        {
                            emailtaken = false;
                        }
                    }

                    Console.CursorVisible = false;

                    if (RegexUtilities.IsValidEmail(email) == true && emailtaken == false)
                    {
                        registrationForm[1] += email;
                    }
                    else
                    {
                        Console.Clear(); RegexUtilities.LoadingScreen();
                        Console.WriteLine("Invalid email or email already in use!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        email = null;
                    }

                    
                    Console.Clear(); RegexUtilities.LoadingScreen();
                }

                else if (sel == registrationForm[2])
                {
                    registrationForm[2] = registrationForm[2].Substring(0, 10);
                    Console.Clear(); RegexUtilities.LoadingScreen();
                    Console.CursorVisible = true;
                    Console.Write(registrationForm[2]);
                    password = RegexUtilities.HidePassword();
                    Console.CursorVisible = false;
                    Console.Clear(); RegexUtilities.LoadingScreen();
                    a = "";
                    foreach (char item in password) { a += "•"; }
                    registrationForm[2] = $"Password: {a}";
                }
                else if (sel == registrationForm[3] && password == null)
                {
                    Console.Clear(); RegexUtilities.LoadingScreen();
                    Console.WriteLine("You must enter a password first!");
                    Thread.Sleep(1000);
                    Console.Clear(); RegexUtilities.LoadingScreen();
                }
                else if (sel == registrationForm[3] && password != null)
                {
                    registrationForm[3] = registrationForm[3].Substring(0, 18);
                    Console.Clear(); RegexUtilities.LoadingScreen();
                    Console.CursorVisible = true;
                    Console.Write(registrationForm[3]);
                    password2 = RegexUtilities.HidePassword();
                    b = "";
                    foreach (char item in password2) { b += "•"; }
                    registrationForm[3] = $"Confirm password: {b}";
                    Console.CursorVisible = false;
                    Console.Clear(); RegexUtilities.LoadingScreen();
                }

                else if (sel == registrationForm[4])
                {
                    c = "x";
                    while (true)
                    {
                        
                        Console.Clear(); RegexUtilities.LoadingScreen();
                        Console.WriteLine("Do you want your account to be private?");
                        pvt = RegexUtilities.GetMenu(yesNo);
                        if (pvt == "Yes")
                        {
                            privateAccount = true;
                            registrationForm[4] = registrationForm[4].Substring(0, 15);
                            registrationForm[4] += ": Yes";
                            break;

                        }
                        else if (pvt == "No")
                        {
                            privateAccount = false;
                            registrationForm[4] = registrationForm[4].Substring(0, 15);
                            registrationForm[4] += ": No";
                            break;
                        }
                    }
                    Console.Clear();

                }

                else if (sel == registrationForm[5])
                {
                    d = "x";
                    while (true)
                    {
                        
                        Console.Clear(); RegexUtilities.LoadingScreen();
                        Console.WriteLine("Do you want to get our premium service for only $3.990/month?"); // Que incluye...?
                        prem = RegexUtilities.GetMenu(yesNo);
                        if (prem == "Yes")
                        {
                            premium = true;
                            registrationForm[5] = registrationForm[5].Substring(0, 12);
                            registrationForm[5] += ": Yes";
                            break;
                        }
                        else if (prem == "No")
                        {
                            premium = false;
                            registrationForm[5] = registrationForm[5].Substring(0, 12);
                            registrationForm[5] += ": No";
                            break;
                        }
                    }
                    Console.Clear(); RegexUtilities.LoadingScreen();
                }

                else if (sel == registrationForm[6])
                {
                    if (username == null | usertaken == true)
                    {
                        Console.Clear(); RegexUtilities.LoadingScreen();
                        Console.WriteLine("Username in already taken or empty!");
                        Thread.Sleep(1000);
                        Console.Clear(); RegexUtilities.LoadingScreen();
                    }

                    else if (password != password2 | password == null | password2 == null | password == "" | password2 == "")
                    {
                        Console.Clear(); RegexUtilities.LoadingScreen();
                        Console.WriteLine("Password doesn't match or empty!");
                        Thread.Sleep(1000);
                        Console.Clear(); RegexUtilities.LoadingScreen();
                    }

                    else if (email == null | emailtaken == true | email == "")
                    {
                        Console.Clear(); RegexUtilities.LoadingScreen();
                        Console.WriteLine("Please enter a valid email address!");
                        Thread.Sleep(1000);
                        Console.Clear(); RegexUtilities.LoadingScreen();
                    }

                    else if (c == null)
                    {
                        Console.Clear(); RegexUtilities.LoadingScreen();
                        Console.WriteLine("You have to select if you want your account to be private!");
                        Thread.Sleep(1000);
                        Console.Clear(); RegexUtilities.LoadingScreen();
                    }

                    else if (d == null)
                    {
                        Console.Clear(); RegexUtilities.LoadingScreen();
                        Console.WriteLine("You have to select if you want a premium account!");
                        Thread.Sleep(1000);
                        Console.Clear(); RegexUtilities.LoadingScreen();
                    }
                    else
                    {
                        User user = new User(username, email, password, privateAccount, premium, false);
                        UserDB.Add(username, user);
                        Console.Clear();
                        Console.WriteLine("User created successfully!");
                        Console.WriteLine("Now you can log in with your username and password.");
                        Thread.Sleep(1000);
                        Console.Clear(); RegexUtilities.LoadingScreen();
                        return;
                    }

                }
                                                                                                                              
                else if (sel == registrationForm[7])
                {
                    return;
                }

                if (password == password2 && password != null)
                {
                    registrationForm[2] = $"Password: {a} ✔";
                    registrationForm[3] = $"Confirm password: {b} ✔";

                }
                else if (password != password2 && password != null && password2 != null)
                {
                    registrationForm[2] = $"Password: {a} ✗";
                    registrationForm[3] = $"Confirm password: {b} ✗";
                }

                





            }







        }
        public static void Save(Dictionary<string, User> userDB, List<Media> mediaDB, List<Person> peopleDB, string name)
        {
            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, userDB);
            formatter.Serialize(stream, mediaDB);
            formatter.Serialize(stream, peopleDB);
            stream.Close();
        }

        public static (Dictionary<string, User>, List<Media>, List<Person>) Load(string name)
        {
            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            Dictionary<string, User> userDB = (Dictionary<string, User>)formatter.Deserialize(stream);
            List<Media> mediaDB = (List<Media>)formatter.Deserialize(stream);
            List<Person> peopleDB = (List<Person>)formatter.Deserialize(stream);
            stream.Close();

            return (userDB, mediaDB, peopleDB);
        }


    }
}
