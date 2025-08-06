using System;

// See 
class Program
{
    static void Main()
    {
        
        Console.Write("Recipient's Full Name: ");
        string recipient = Console.ReadLine();

        Console.Write("Your Full Name (Sender): ");
        string sender = Console.ReadLine();

        Console.Write("Subject of the Letter: ");
        string subject = Console.ReadLine();

        Console.Write("Project or Task to Discuss: ");
        string project = Console.ReadLine();

        Console.Write("Follow-up Date (MM/DD/YYYY): ");
        string folowDate = Console.ReadLine();

        
        Console.WriteLine();
        Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}");
        Console.WriteLine($"To: {recipient}");
       
        Console.WriteLine($"Dear {recipient},");
      
        Console.WriteLine($"Subject: {subject}");

        Console.WriteLine($"Hey, I am writing to discuss the progress of the \"{project}\" project. Your hard work have been very helpful, and I appreciate your dedication to this project.");
       
        Console.WriteLine($"As the group moves forward, note that our next follow up is scheduled for {folowDate}. If you have any questions feel free to reach out.");
       
        Console.WriteLine("From,");
        Console.WriteLine(sender);
    }
}