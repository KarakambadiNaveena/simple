using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sep12attributes
{
   
        [StereoDisc("Kesariya", "Hindi","KESARIYA TERA ISHQ HAI PIYA")]
        public class Song
        {
            [StereoDisc("Inthandham", "Telugu","inthandham dhari mallindha")]
            public string Name { get; set; }

            [StereoDisc("aashiqui", "Hindi","meri ashiqi ab thum hi ho")]
            public Song()
            {
                Console.WriteLine("Song Default Constructor");
            }
        }
    }


