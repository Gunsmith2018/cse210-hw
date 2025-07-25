using System;
using System.Collections.Generic;
using System.Data;


public class Scriptures
{

    private string[] Scripture = new string[]
    {
         "Mosiah 2:17: And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.",
         "1 Nephi 3:7: And it came to pass that I, Nephi said unto my father: I will go and do the things which the Lord hath commanded..."
    };


    public string GetRandomScripture()
    {
        Random rand = new Random();
        int index = rand.Next(Scripture.Length);
        return Scripture[index];
    }
    



    /*

    public void _Reference()
    {
        Reference reference - new Reference();
        Console.WriteLine(scripture.GetRandomScripture());
        
    }


_reference
_words
GetDisplayText()
IsCompletelyHidden(): bool




















    */

}