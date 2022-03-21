using System;

namespace CSharp.net
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Magnus";
            string lastname = "Andersson";

            string message;

            //message = "Hello! " + firstname + " " + lastname + ", Welcome!";
            message = $"Hello! {firstname} {lastname}, Welcome!";
        }
    }
}
