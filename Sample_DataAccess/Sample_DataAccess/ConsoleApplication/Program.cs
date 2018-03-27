using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Repository;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string recordvalue;
            Console.WriteLine("Enter Record value");
            recordvalue = Console.ReadLine();
            if (!string.IsNullOrEmpty(recordvalue))
            {
                List<string> comment = new CommentRepository().GetCommentbyRecValue(recordvalue);
                if (comment.Count > 0)
                {
                    foreach (string commentvalue in comment)
                    {
                        Console.WriteLine("Comment value : " + commentvalue);
                    }
                }

                else
                    Console.WriteLine("No records found");
            }
            

            Console.ReadLine();
        }
    }
}
