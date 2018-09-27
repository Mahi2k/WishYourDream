using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishYourDream.Models
{
    public class Name
    {
        #region Properties
        //Properties
        public string First { get; set; }

        public string Last { get; set; }

        public string Middle { get; set; }

        public string Prefix { get; set; }

        public string Suffix { get; set; }

        public TypeOfUser UserType { get; set; }

        public enum TypeOfUser
        {
            Standard,
            Premium,
            Guest
        } 
        #endregion
        
        #region Constructor's
        //Constructor's
        public Name()
        {
            First = "First";
            Middle = "Middle";
            Last = "Last";
            Prefix = "Prefix";
            Suffix = "Suffix";
            UserType = TypeOfUser.Guest;
        }

        public Name(string fname, string mname, string lname, string suff, string pref, string type)
        {
            First = fname;
            Middle = mname;
            Last = lname;
            Suffix = suff;
            Prefix = pref;
            UserType = Enum.Parse<TypeOfUser>(type);
        } 
        #endregion


    }
}