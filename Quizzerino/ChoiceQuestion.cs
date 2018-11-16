using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzerino
{
    class ChoiceQuestion : Question
    {
        private List<String> choices;
        public ChoiceQuestion()
        {
            choices = new List<string>();
        }

        public void addChoice(String choice, Boolean correct)
        {
            choices.Add(choice);
            if (correct)
            {
                String choiceString = "" + choices.Count();
                setAnswer(choiceString);
            }
        }

        public void display()
        {
            base.display();
            for (int i = 0; i < choices.Count(); i++)
            {
                int choiceNumber = i + 1;
                Console.WriteLine(choiceNumber + ": " + choices.ElementAt(i));
            }
        }
    }
}
