// using directive - allow the use of types in a namespace
using System;
using System.Collections.Generic;
using System.IO;

namespace codeTester
{
    // using statement
    // using statement is only useful,
    // for objects with a lifetime,
    // that does not extend beyond the method,
    // in which the objects are constructed.
    // the objects that are instantiate must implement the System.IDisposable interface.
    // using statement is translated into three parts: acquisition, usage, and disposal.
    // the resource is first acquired,
    // then the usage is enclosed in a try statement with a finally clause.
    // the object then gets disposed in the finally clause. 
    
    public class Using
    {
        public class FileWriter
        {
            readonly string emailFilePath = $@"C:\emails\emails{DateTime.Now:yyyy-MM-dd HH.mm.ss}.txt";
            const string fileCountPath = @"C:\emails\emailCount.txt";
            
            public void WriteEmailsToFile(IEnumerable<string> emails)
            {
                
                HandleDirectory(@"C:\emails");

                using (var file = File.CreateText(emailFilePath))
                {
                    foreach (var email in emails)
                    {
                        file.Write(email);
                        file.Write("\r\n");
                    }
                }
            }

            public void WriteEmailCountToFile(int emailCount)
            {
                using (var file = File.CreateText(fileCountPath))
                    file.Write("Total Email Count: " + emailCount);
            }

            private void HandleDirectory(string directory)
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}