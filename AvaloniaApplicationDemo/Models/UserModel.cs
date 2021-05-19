using System;

namespace DataGridExample.Models
{
    public class UserModel
    {
        public string OpdNo { get; set; }
        
        public string Name{ get; set; }
        
        public string Reserve { get; set; }

        public string Business { get; set; }

        public string Client { get; set; }

        public int State { get; set; }

        public DateTime CreateTime { get; set; }
    }
}