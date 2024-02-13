/*
Title :Hierachical Inheritance
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 12/10/2022
Reviewed by :
Reviewed at :
*/
using System;

namespace HieraricalInheritance
{
    public class Application
    {
        public string UserName = "/0";
        public void Call()
        {
            Console.WriteLine("Call is Ongoing by "+UserName);
        }
        public void message()
        {
            Console.WriteLine("The message has been Sent by "+UserName);
        }
    }
    public class Whatsapp : Application
    {
        public void statusUpload()
        {
            Console.WriteLine("Your Status has been Set.Tap to see the video");
        }
    }
    public class Instagram : Application
    {
        public void reelsUpload()
        {
            Console.WriteLine("Instagram Reels is posted");
        }
    }

    public class Facebook : Application
    {
        public void storyUpload()
        {
            Console.WriteLine("Your Story has been uploaded");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Instagram detail : ");
            Instagram instagram = new Instagram();
            instagram.UserName = "lovely_kid";
            instagram.Call();
            instagram.message();
            instagram.reelsUpload();

            Console.WriteLine();

            Console.WriteLine("Whatsapp detail : ");
            Whatsapp whatsapp = new Whatsapp();
            whatsapp.UserName = "Joy Boy";
            whatsapp.Call();
            whatsapp.message();
            whatsapp.statusUpload();

            Console.WriteLine();

            Console.WriteLine("Facebook details : ");
            Facebook facebook = new Facebook();
            facebook.UserName = "Praveen kumar";
            facebook.Call();
            facebook.message();
            facebook.storyUpload();
        }
    }
}