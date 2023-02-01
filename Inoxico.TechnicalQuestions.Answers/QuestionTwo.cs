
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
                // if decline and decline is above ground
                if (points[i] > points[i + 1] && points[i] >= 0)
                {
                    var declineInitial = points[i] - points[i + 1];
                    var declineInitialIndex = i;
                    var hitIncline = false;
                    var firstInclinePoint = 0;
                    for (i = i + 1; i < pointsLength - 1; i++)
                    {
                        if (!hitIncline && points[i] < points[i + 1])
                        {
                            var minimun = Math.Min(declineInitial, points[i + 1] - points[i]);
                            if (deepestPit < minimun)
                                deepestPit = minimun;

                            firstInclinePoint = i;
                            hitIncline = true;
                        }
                        else if (hitIncline && points[i] < points[i + 1])
                        {
                            var minimun = Math.Min(declineInitial, points[i + 1] - points[firstInclinePoint]);
                            if (deepestPit < minimun)
                                deepestPit = minimun;

                            hitIncline = true;
                        }
                        else
                        {
                            declineInitial = points[declineInitialIndex] - points[i + 1];
                            if (hitIncline && points[i] >= points[i + 1])
                            {
                                i--;
                                break;
                            }
                            hitIncline = false;
                        }

                        
                    }
                }
            }

            return deepestPit;
        }
    }
}
