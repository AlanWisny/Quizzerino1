using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzerino
{
    class Question
    {
        private String text { get; set; }
        private String answer { get; set; }
        public int difficulty { get; set; }
        public String category { get; set; }

        // initializer maken
        public Question()
        {
            String text = "";
            String answer = "";
            
        }
        public void setText(String questionText)
        {
            text = questionText;
        }

        public void setAnswer(String correctResponse)
        {
            answer = correctResponse;
        }

        public Boolean checkAnswer(String response)
        {
            return response.Equals(answer);
        }

        public void display()
        {
            Console.WriteLine(text);
        }


    
      
    }
}
