using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Green
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            answer = new int[n];
            for (int i = 0; i < n; i++)
            {
                int min = matrix[i, 0];
                int index = 0;

                for (int j = 1; j < m; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        index = j;
                    }
                }
                answer[i] = index;
            }

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int m = int.MinValue;
                int index = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > m)
                    {
                        m = matrix[i, j];
                        index = j;
                    }
                }
                for (int j = 0; j < index; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = (int)Math.Floor((double)matrix[i, j] / m);
                    }
                }
            }

        }
        public void Task3(int[,] matrix, int k)
        {

            if (matrix.GetLength(0) == matrix.GetLength(1) && k < matrix.GetLength(1))
            {
                int index = 0;
                int m = matrix[0, 0];

                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, i] > m)
                    {
                        m = matrix[i, i];
                        index = i;
                    }
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {

                    int t = matrix[i, k];
                    matrix[i, k] = matrix[i, index];
                    matrix[i, index] = t;


                }
            }

        }
        public void Task4(int[,] matrix)
        {

            if (matrix.GetLength(0) != matrix.GetLength(1))
                return;

            int max = int.MinValue, imax = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                    imax = i;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
                (matrix[i, imax], matrix[imax, i]) = (matrix[imax, i], matrix[i, imax]);

        }
        public int[,] Task5(int[,] matrix)
        {
            int[,] answer = null;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxr = 0;
            double maxs = 0;

            for (int i = 0; i < rows; i++)
            {
                double sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                    }
                }

                if (sum > maxs)
                {
                    maxs = sum;
                    maxr = i;
                }
            }
            int[,] newMatrix = new int[rows - 1, cols];
            int newRow = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i != maxr)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        newMatrix[newRow, j] = matrix[i, j];
                    }
                    newRow++;
                }
            }

            return newMatrix;

            return answer;
        }
        public void Task6(int[,] matrix)
        {

            int maxIndex = 0, minIndex = 0, max = Int32.MinValue, min = Int32.MaxValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int cnt = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        cnt++;
                    }
                }

                if (cnt > max)
                {
                    max = cnt;
                    maxIndex = i;
                }

                if (cnt < min)
                {
                    min = cnt;
                    minIndex = i;
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
                (matrix[maxIndex, i], matrix[minIndex, i]) = (matrix[minIndex, i], matrix[maxIndex, i]);

        }
        public int[,] Task7(int[,] matrix, int[] array)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task8(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here

            // end

        }
        public (int[] A, int[] B) Task10(int[,] matrix)
        {
            int[] A = null, B = null;

            // code here

            // end

            return (A, B);
        }
        public void Task11(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task12(int[][] array)
        {

            // code here

            // end

        }
    }
}
