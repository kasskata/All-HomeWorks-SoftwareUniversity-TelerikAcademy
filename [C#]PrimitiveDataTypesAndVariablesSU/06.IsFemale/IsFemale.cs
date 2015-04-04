using System;

//Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

class IsFemale
{
    static void Main()
    {
        string MyGender= "male";
        string male = "male";
        string female = "female";
        bool isFemale = (MyGender == male);

        if (MyGender == male)
        {
            Console.WriteLine("I am {0} ! Am I ? -> {1}", male, isFemale);
        }
        else 
        {
            Console.WriteLine("I am {0} ! Am I ? -> {1}", female, isFemale);
        }

    }    
}