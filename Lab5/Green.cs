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

            int maxIndex = 0, minIndex = 0, max = int.MinValue, min = int.MaxValue;
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
            

            if (matrix.GetLength(0) != array.Length)
            {
                return matrix;
            }
            int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1) + 1];
            int minn = int.MaxValue;
            int mincolumn = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < minn)
                    {
                        minn = matrix[i, j];
                        mincolumn = j;
                    }
                }
            }
            

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <= matrix.GetLength(1); j++)
                {
                    if (j <= mincolumn)
                        answer[i, j] = matrix[i, j];
                    else if (j == mincolumn + 1)
                        answer[i, j] = array[i];
                    else
                        answer[i, j] = matrix[i, j - 1];
                }
            }

            return answer;
        }
        public void Task8(int[,] matrix)
        {

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int maxx = int.MinValue;
                int maxindex = -1;
                int countpositive = 0;
                int countnegative = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {

                    if (matrix[i, j] < 0) countnegative += 1;
                    if (matrix[i, j] > 0) countpositive += 1;

                    if ((matrix[i, j] > maxx))
                    {
                        maxx= matrix[i, j];
                        maxindex = i;
                    }

                }
                if (maxindex != -1)
                {
                    if (countpositive > countnegative)
                    {
                        matrix[maxindex, j] = 0;
                    }
                    else if (countnegative > countpositive)
                    {
                        matrix[maxindex, j] = maxindex;
                    }

                }
            }

        }
        public void Task9(int[,] matrix)
        {

            if (matrix.GetLength(0) != matrix.GetLength(1))
                return;

            for (int a = 0; a < matrix.GetLength(0) * matrix.GetLength(1); a++)
            {
                int i = a / matrix.GetLength(0);
                int j = a % matrix.GetLength(0);
                if (i == 0 || i == matrix.GetLength(0) - 1 || j == 0 || j == matrix.GetLength(0) - 1)
                {
                    matrix[i, j] = 0;
                }
            }

        }
        public (int[] A, int[] B) Task10(int[,] matrix)
        {
            int[] A = null, B = null;

            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                return (A, B);

            }
            int n = matrix.GetLength(0);

            int sizeA = n * (n + 1) / 2;
            int sizeB = n * (n - 1) / 2;

            A = new int[sizeA];
            B = new int[sizeB];

            int indexA = 0;
            int indexB = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= i)
                    {
                        A[indexA] = matrix[i, j];
                        indexA++;
                    }
                    else
                    {
                        B[indexB] = matrix[i, j];
                        indexB++;
                    }
                }
            }

            return (A, B);
        }
        public void Task11(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int a = 0; a < matrix.GetLength(0) - i - 1; a++)
                    {

                        if (j % 2 == 0 && matrix[a, j] < matrix[a + 1, j])
                        {
                            int temp = matrix[a, j];
                            matrix[a, j] = matrix[a + 1, j];
                            matrix[a + 1, j] = temp;
                        }

                        if (j % 2 != 0 && matrix[a, j] > matrix[a + 1, j])
                        {
                            int temp = matrix[a, j];
                            matrix[a, j] = matrix[a + 1, j];
                            matrix[a + 1, j] = temp;
                        }
                    }
                }
            }

        }
        public void Task12(int[][] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sumi = 0;
                    for (int k = 0; k < array[i].Length; k++)
                        sumi += array[i][k];

                    int sumj = 0;
                    for (int a = 0; a < array[j].Length; a++)
                    {
                        sumj += array[j][a];
                    }

                    if (array[j].Length > array[i].Length || (array[j].Length == array[i].Length && sumj > sumi))
                    {
                        int[] temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

        }
    }
}
