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
			var timer = new System.Threading.Timer(
			e => ModInvites(),  
			null, 
			TimeSpan.Zero, 
			TimeSpan.FromMinutes(5));
        }
		private ModInvites() {
			// TODO: Figure out how to do this in RedditSharp.
		}
    }
}
