
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            if(string.IsNullOrEmpty(s))
                throw new Exception("s is null or empty");

            string [] splitByPunctuation = s.Split(new char[] { '.', '!', '?' });

            var maxWords = 0;
            foreach (string sentence in splitByPunctuation)
            {
                var words = sentence.Split(' ');
                var wordLength = 0;
                foreach (string word in words)
                {
                    if (word != "")
                        wordLength++;
                }

                if (maxWords < wordLength)
                {
                    maxWords = wordLength;
                }
            }

            return maxWords;
        }
    }
}




