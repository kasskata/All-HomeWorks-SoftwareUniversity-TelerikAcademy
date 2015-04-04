using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Write a program that replaces in a HTML document given as string all the
//tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
//Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

// TO:

//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
//Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>


class ReplaceTheHTMLComponents
{
    static void Main(string[] args)
    {
        string rawText = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses";
        string text = rawText.Replace("<a href=\"", "[URL=");
        text = text.Replace("\">","]");
        text = text.Replace("</a>", "[/URL]");
        Console.WriteLine(text);
    }
}