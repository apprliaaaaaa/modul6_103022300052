// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
       
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - APRILIANI");

        video.PrintVideoDetails();
        video.IncreasePlayCount(10);

        video.PrintVideoDetails();
    }
}

