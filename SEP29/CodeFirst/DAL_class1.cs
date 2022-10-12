using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep29library
{
   
        public class Member
        {
            [Key]
            [Required]
            public int memberID { get; set; }
            [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
            [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
            public string memberName { get; set; }

           
            //1 Student---M Enrollments
            public virtual ICollection<Issues> issues { get; set; }
           

        }

        public class Book
        {
            [Key]
            public int bookID { get; set; }

            public string bookName { get; set; }

            [Range(100, 200, ErrorMessage = "not in range")]
            public int cost { get; set; }
            
            public virtual ICollection<Issues> issues { get; set; }

        }

        public class Issues
        {
            [Key]
            public int issueID { get; set; }
            public int bookID { get; set; }
            public int memberID { get; set; }

            [ForeignKey("bookID")]
            public virtual Book BookDetails { get; set; }
            [ForeignKey("memberID")]
            public virtual Member MemberDetails { get; set; }


        }

        public class MyContext : DbContext
        {
            public MyContext() : base("MyContext")
            {
                

                Database.SetInitializer<MyContext>(new DropCreateDatabaseAlways<MyContext>());
            }

            public virtual DbSet<Member> MemberTable { get; set; }
            public virtual DbSet<Book> BookTable { get; set; }
            public virtual DbSet<Issues> IssuesTable { get; set; }

        }
    }


