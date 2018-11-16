using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzerino
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoiceQuestion first = new ChoiceQuestion();
            first.setText("What was the original name of the Java language?");
            first.addChoice("*7", false);
            first.addChoice("Duke", false);
            first.addChoice("Oak", true);
            first.addChoice("Gosling", false);

            
            presentQuestion(first);
        }
        public static void presentQuestion(ChoiceQuestion q)
        {
            q.display();
            Console.Write("Your answer: ");
            String response = Console.ReadLine();
            Console.WriteLine(q.checkAnswer(response));    // checkt of het overeenkomt
        }
    }
}
