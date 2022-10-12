﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep12attributes
{
    
        [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        sealed class StereoDiscAttribute : Attribute
        {
            // See the attribute guidelines at 
            //  http://go.microsoft.com/fwlink/?LinkId=85236
            //readonly string positionalString;

            // This is a positional argument

            public string SongName { get; set; }
            public string Lang { get; set; }
           public string lyrics { get; set; }
        // public string Lyrics { get; set; }
        //public StereoDiscAttribute(string positionalString , string lang)
        //{
        //    this.SongName = positionalString;
        //    this.Lang = lang;

        //    // TODO: Implement code here

        //    throw new NotImplementedException();
        //}  

        public StereoDiscAttribute(string SongName, string Lang,string lyrics)
            {
                this.SongName = SongName;
                this.Lang = Lang;
                this.lyrics=lyrics;
                
            }

            //public string PositionalString
            //{
            //    get { return positionalString; }
            //}

            // This is a named argument
            //public int NamedInt { get; set; }
        }
    }



