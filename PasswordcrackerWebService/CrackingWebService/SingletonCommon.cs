using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CrackingWebService
{
    public class SingletonCommon
    {
        private List<UserInfo> _passwords;
        private List<string> _dictList;
        //public string Dictionary { get; set; }
        // Not 100% sure if string is ok.
        // might be better to make a handlerclass, that returns them in List<UserInfo> like in the program
        // but easily rewriteable.
        private static SingletonCommon instance = new SingletonCommon();
        public int PartToGive { get; set; }
        public List<string> DictList
        {
            // The Get-method to the property, also reads the file.
            //This is Quality Assurance, so it can never be null.
            // we experimented with having another method or having it in constructor, but this was simplest, and works.
            get
            {
                _dictList = new List<string>();
                // Opens a filestream to the file. - We chose C:\temp\
                using (FileStream fs = new FileStream(@"c:\temp\webster-dictionary.txt", FileMode.Open, FileAccess.Read))
                // Opens a streamreader from the filestream
                using (StreamReader dictionary = new StreamReader(fs))
                {
                    while (!dictionary.EndOfStream)
                    {
                        // Foreach line read, adds it to a list.
                        String dictionaryEntry = dictionary.ReadLine();
                        _dictList.Add(dictionaryEntry);
                    }
                    // return the list. This is then returned to the Client/Slave, and can be used as foreach
                    // instead of while-loop in an open streamreader.
                } return _dictList;
            }
            set { _dictList = value; }
        }

        public static SingletonCommon Instance
        {
            get { return instance; }
        }
        public List<string> ResultList { get; set; }

        public List<UserInfo> Passwords
        {
            get
            { //Get method Reads the file.
                _passwords = PasswordFileHandler.ReadPasswordFile(@"c:\temp\passwords.txt");
                return _passwords;
            }
            set { _passwords = value; }
        }

        public List<string> MakeDictionaryParts(int part)
        {
            // This was an interesting method to write:
            // Method splits up the list of strings, into 3 equally big parts.
            // We did this by dividing the total amount of elements in the dictionary, with 3.
            // HOWEVER, it was a number undividable with 3, so as to not loose an element, we added +1 to list1.
            // list0 will therefore have 1 less than the others, as 1,33 would have int value 1.
           int splitInt = (DictList.Count / 3);
            List<string> dictList0 = DictList.GetRange(0, splitInt);
            List<string> dictList1 = DictList.GetRange(splitInt, splitInt+1);
            List<string> dictList2 = DictList.GetRange((splitInt * 2) + 1, DictList.Count-(splitInt*2+1) );

            // Returns part 0,1 or 2, based on which number of incoming request it is.
            if (part.Equals(0))
            {
                return dictList0;
            }
            if (part.Equals(1))
            {
                return dictList1;
            }
            if (part.Equals(2))
            {
                return dictList2;
            }
            else return null;
        }
        //


       

        
        //mvh Martin
    }
}