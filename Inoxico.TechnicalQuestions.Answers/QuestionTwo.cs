
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
            if (points == null)
                throw new Exception("points is null");

            var deepestPit = -1;

            var pointsLength = points.Length;
            for (int i = 0; i < pointsLength-1; i++)
            {
                if (points[i] < points[i + 1])
                {

                }
                else if (points[i] > points[i + 1])
                {
                    var declineInitial = points[i] - points[i + 1];
                    var hitIncline = false;
                    for (i = i + 1; i < pointsLength - 1; i++)
                    {
                        if (points[i] < points[i + 1])
                        {
                            deepestPit = Math.Min(declineInitial, points[i + 1] - points[i]);
                            hitIncline = true;
                        }

                        if (hitIncline && points[i] >= points[i + 1])
                        {
                            i--;
                            break;
                        }
                    }
                }
            }

            return deepestPit;
        }
    }
}
