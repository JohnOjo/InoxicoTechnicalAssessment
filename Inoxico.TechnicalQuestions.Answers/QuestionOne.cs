
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            string [] splitByPunctuation = s.Split(new char[] { '.', '!', '?' });

            var maxWords = 0;
            foreach (string word in splitByPunctuation)
            {
                var words = word.Split(' ');
                var wordLength = word.Length;
                if (maxWords < wordLength)
                {
                    maxWords = wordLength;
                }
            }

            return maxWords;
        }
    }
}




