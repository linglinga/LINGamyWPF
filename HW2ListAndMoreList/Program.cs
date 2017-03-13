using HW2ListAndMoreList.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HW2ListAndMoreList
{
    public partial class Program
    {
        private Models.User user = new Models.User();

        public class ToLower
        {

        }
        static void Main(string[] args)
        {
            
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            var firstUser = users[0];
            




            //list all users name and password in the List.
            //http://stackoverflow.com/questions/24390005/checking-for-empty-or-null-liststring
            if (users.Count > 0)            //if users count is more than 0.
            {
                if (users[0] != null)       //if users index is not empty.
                {
                    users.ToList();         //list the users info.
                }
                Console.WriteLine("Current list of All User's \"Name\" & \"Password\":");
                users.ForEach(Console.WriteLine);
            }
            Console.WriteLine();   
            
            
            //Display to console, all the passwords that are "hello", by using Where.
            //http://stackoverflow.com/questions/1071032/searching-if-value-exists-in-a-list-of-objects-using-linq
            //http://stackoverflow.com/questions/29880034/what-is-the-best-way-to-display-list-items-on-the-console-based-on-the-value-of
            var hasHello = (from user in users where user.Password == "hello" select user).ToList();
            Console.WriteLine("Password using \"hello\":");
            hasHello.ForEach(Console.WriteLine);
            Console.WriteLine();

            //Display to console, the first passwords that is "hello", and remove it from the list.
            var firstHello = hasHello.FirstOrDefault();
            users.Remove(firstHello);
            Console.WriteLine("User with first \"hello\" password were succesfully removed: ");
            Console.WriteLine(firstHello);
            Console.WriteLine();

            //RemoveAll users name and passwords that are the same (lowercase), and remove it.
            var foundSame = (from user in users where user.Name == user.Password select user).ToList();
            Console.WriteLine("User with the same Name & Password were successfully removed: ");
            foundSame.ForEach(Console.WriteLine); 
            Console.WriteLine();

            //list all users name and password in the List.
            //http://stackoverflow.com/questions/24390005/checking-for-empty-or-null-liststring
            if (users.Count > 0)            //if users count is more than 0.
            {
                if (users[0] != null)       //if users index is not empty.
                {
                    users.ToList();         //list the users info.
                }
                Console.WriteLine("Remaining list of All User's \"Name\" & \"Password\":");
                users.ForEach(Console.WriteLine);
            }
            Console.WriteLine();

















            /*
        var hasHello = (from user in users where user.Password == "hello" select user).FirstOrDefault() != null;


        /*
      string search = "hello";
        IEnumerable<string> results = users.Where(s => s.Equals (search));
        users.RemoveAll(password.Contains ("hello"));

        string match = users.Where(User.password, predicate => predicate.Contains("hello"));

         */







        }
    }
}
