using Sep13library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;


namespace Sep13
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            FileStream fs3 = new FileStream(@"moviedata.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs_xml = new FileStream(@"empxmldata.xml", FileMode.Create, FileAccess.Write);
            Movie m1 = new Movie();
            m1.AddMovieDetails("abc", "Tamil", "Action", 50);
            Movie m2 = new Movie();
            m2.AddMovieDetails("ddd", "Tamil", "Action", 60);
            Movie m3 = new Movie();
            m3.AddMovieDetails("aaa", "English", "Mystery", 100);
            Movie m4 = new Movie();
            m4.AddMovieDetails("ccc", "Tamil", "Romance", 60);
            Movie m5 = new Movie();
            m5.AddMovieDetails("kkk", "Tamil", "Comedy", 110);
            Movie m6 = new Movie();
            m6.AddMovieDetails("nnn", "English", "Thriller", 100);
            Movie m7 = new Movie();
            m7.AddMovieDetails("DDD", "English", "Action", 50);
            Movie m8 = new Movie();
            m8.AddMovieDetails("uuu", "Tamil", "Action", 120);
            Movie m9 = new Movie();
            m9.AddMovieDetails("Mmm", "English", "Action", 120);
            Movie m10 = new Movie();
            m10.AddMovieDetails("ttt", "English", "Action", 120);

            User u1 = new User();
            User u2 = new User();
            User u3 = new User();
            User u4 = new User();
            User u5 = new User();
            User u6 = new User();

            u1.AddUser("Naveena", "Sam", "Gold");
            u2.AddUser("Naveena", "Sam", "Gold");
            u3.AddUser("Naveena", "Sam", "Gold");
            u4.AddUser("Naveena", "Sam", "Gold");
            u5.AddUser("Naveena", "Sam", "Gold");
            u6.AddUser("Naveena", "Sam", "Gold");
           
           
            u1.BorrowMovie(m1);
            u2.BorrowMovie(m1);
            u4.BorrowMovie(m1);
            Console.WriteLine("Movie 1 Availability " + m1.Availability);
            u3.BorrowMovie(m1);
            Console.WriteLine("Movie 1 Availability " + m1.Availability);
            u2.RetrunMovie(m1, 4);

            u6.BorrowMovie(m1);
            u5.BorrowMovie(m1);
            u1.RetrunMovie(m2, 5);

            u1.BorrowMovie(m2);
            u2.BorrowMovie(m3);
            u2.BorrowMovie(m4);
            u1.BorrowMovie(m3);
            Console.WriteLine("=================================================");
            u1.ShowMyList();
           
            Console.WriteLine("==================================================");
            u1.SearchByLanguage("Tamil");
            Console.WriteLine("==================================================");
            u1.SearchByGenre("Action");
            XmlSerializer xml = new XmlSerializer(typeof(User));
            xml.Serialize(fs_xml, u1);
            fs_xml.Flush();
            fs_xml.Close();
            fs_xml.Dispose();
          
            formatter.Serialize(fs3, u1);

            fs3.Flush();
            fs3.Close();
            fs3.Dispose();
            Console.ReadLine();
            

         
          




        }
    }
}
