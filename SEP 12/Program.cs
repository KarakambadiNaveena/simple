using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sep12attributes
{
    public class Program
    {
        static void Attribute_Answers(Type t)
        {
            // Console.WriteLine("Class Name  : " + t.Name);

            Attribute[] a = Attribute.GetCustomAttributes(t);
            foreach (var item in a)
            {
                if (item is StereoDiscAttribute)
                {
                    StereoDiscAttribute s = (StereoDiscAttribute)item;
                    Console.WriteLine("Song Name : " + s.SongName + " Language : " + s.Lang +  "  Lyrics :" + s.lyrics);
                }
            }
            MemberInfo[] m = t.GetMembers();
            foreach (var item in m)
            {
                //Console.WriteLine("Name : " + item.Name);
                Attribute[] memberAttr = Attribute.GetCustomAttributes(item);
                foreach (var item1 in memberAttr)
                {
                    if (item1 is StereoDiscAttribute)
                    {
                        StereoDiscAttribute s = (StereoDiscAttribute)item1;
                        Console.WriteLine("Song Name : " + s.SongName + " Language " + s.Lang + "  Lyrics :" + s.lyrics);
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Attribute_Answers(typeof(Song));
        }
    }
}
