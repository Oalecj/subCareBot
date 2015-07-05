using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditSharp;

namespace subCareBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var reddit = new Reddit();
			var user = reddit.LogIn("botusername", "botpassword");
			
        }
    }
}
