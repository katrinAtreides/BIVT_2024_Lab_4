using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml.Linq;


public class Program
{
    public static void Main()
    {
        Program program = new Program();
        int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 5, 25, -19, 3 },
                { 5, 6, -7, 8, -99, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
        int k = 2;
        program.Task_3_5(matrix,k);

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        int q = 0;
        int nom = 0;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    nom = A[i, j];
                    if (nom > 0)
                    {
                        q++;
                        answer += A[i, j];
                    }
                }

            }
            answer = answer / q;
        }
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here
        

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here
        if ((A.GetLength(0) == 5) && (colIndex <= 4))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, colIndex] < 0)
                {
                    value = A[i, colIndex];
                    rowIndex = i;
                    break;
                }
            }
        }
                // end
        if (rowIndex == -1)
        {
            value = 0; 
            rowIndex = 0;
        }
        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = new int[A.GetLength(0)];
        // code here
        
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = new double[A.GetLength(0)];
        double a = 0;
        double summ = 0;
        // code here
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 6))
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (A[i, j] > 0)
                    {
                        a++;
                        summ += A[i, j];
                    }
                }
                if (a != 0)
                    summ = Math.Round(summ / a, 2);
                else
                    summ = 0;
                a = 0;
                
                answer[i] = summ;
                summ = 0;
            }
        }
        else
        {
            answer = null;
        }
 
        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here
        int[,] B = new int[4,7];
        int nom = 0;
        double min = double.MaxValue;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, 0] < min)
                {
                    min = A[i, 0];
                    nom = i;
                }
            }
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < nom; i++)
                {
                    B[i, j] = A[i, j];
                }
                for (int i = nom + 1; i < 5; i++)
                {
                    B[i-1, j] = A[i, j];
                }
            }
            min = double.MaxValue;
            nom = 0;
        }
        else
            B = null;

                // end

                return B;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = new int[A.GetLength(1)];
        int nom = 0;
        // code here
        if ((A.GetLength(0) == 4) && (A.GetLength(1) == 3))
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (A[j,i] < 0)
                    {
                        nom++;
                    }
                }
                answer[i] = nom;
                nom = 0;
            }
        }
        else
        {
            answer = null;
        }





        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here
        int max = int.MaxValue;
        int nom = 0;
        int[,] A = new int[B.GetLength(0), B.GetLength(1)];
        if ((B.GetLength(0) == n) && (B.GetLength(1) == m))
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (B[i, j] < max)
                    {
                        max = B[i, j];
                        nom = j;
                    }
                }
                A[i, 0] = B[i, nom];
                for (int j = 0;j < nom; j++)
                {
                    A[i,j + 1] = B[i, j];
                }
                for (int j = nom + 1; j < m; j++)
                {
                    A[i,j] = B[i, j];
                }
                nom = 0;
                max = int.MaxValue;

            }
        }
        else
            A = null;
        


        // end

        return A;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here
        double max = double.MinValue;
        int nom = 0;
        int q = 1, w = 0;
        double a = 0, b = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (F[i,j] > max)
                {
                    max = F[i,j];
                    nom = j;
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (F[i,j] < 0)
                {
                    if (q == 1)
                    {
                        q = 0;
                        a = F[i,j];
                    }
                    else
                    {
                        b = F[i,j];
                    }
                    w++;
                }
            }
            if (w > 0)
            F[i, nom] = (a + b) / 2;
            w = 0;
            max = double.MinValue;
            nom = 0;
            q = 1;
            
        }
        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here
        double max = double.MinValue;
        int nom = 0;
        int[,] F = new int[5,7];
        if ((G.GetLength(0) == 5) && (G.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            { 
                for (int j = 0; j < 7; j++)
                {
                    if (G[i, j] > max)
                    {
                        max = G[i, j];
                        nom = j;
                    }
                }
                for (int j = 0; j < nom; j++)
                {
                    F[i,j] = G[i, j];
                }
                F[i,nom] = G[i,nom];
                F[i,nom + 1] = G[i,nom];
                for (int j = nom + 2; j < 7; j++)
                {
                    F[i,j] = G[i,j-1];
                }
                nom = 0;
                max = double.MinValue;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    G[i,j] = F[i,j];
                }
            }



        }
        else
        {
            G = null;
        }
        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here
        double max = double.MinValue;
        int nom = 0;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7) && (B.Length == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, 6] > max)
                {
                    max = A[i, 6];
                    nom = i;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                A[nom+1,i] = B[i];
            }
                

        }
        else
        {
            A = null;
        }

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here
        double max = double.MaxValue;
        int nom = 0;
        int[,] A = new int[5, 6];
        if ((F.GetLength(0) == 5) && (F.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                if (Math.Abs(F[2, i]) < max)
                {
                    max = F[2, i];
                    nom = i;
                }
            }
            nom += 1;
            for (int i = 0;i < 5 ; i++)
            {
                for(int j = 0; j < nom ; j++)
                    A[i,j] = F[i,j];
                for(int j = nom + 1; j < 7; j++)
                    A[i,j-1] = F[i,j];
            }
            nom = 0;
            
        }
        else
        {
            A = null;
        }


        // end

        return A;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here
        double max = double.MinValue;
        int nom = 0;    
        double summ = 0;
        int ch = 0;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7;j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        nom = j;
                    }
                    if  (A[i, j] > 0)
                    {
                        summ += A[i, j];
                        ch++;
                    }
                }
                if (ch > 0)
                    summ = summ / ch;
                else summ = 0;
                A[i,nom] = summ;
                nom = 0;
                max = double.MinValue;
                ch = 0;
                summ = 0;
            }
        }
        else
        {
            A = null;
        }


        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int ctr = A.GetLength(0);
        int stol = A.GetLength(1);
        double max = -10000000000;
        int maxim = 0;

        if (ctr != 5 || stol != 7) return null;


        for (int i = 0; i < ctr; i++)
        {
            double per = 2;
            max = -1000000000;
            for (int j = 0; j < stol; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxim = j;
                }
            }
            int elem = 0;
            if (maxim == 0 || maxim == stol - 1)
            {
                if (maxim == 0)
                    elem = 1;
                else
                    elem = stol - 2;                               
            }
            else
            {
                if (A[i, maxim - 1] < A[i, maxim + 1])
                    elem = maxim - 1;
                else
                    elem = maxim + 1;
            }
            if (A[i, elem] < 0)
                per = 0.5;
            A[i, elem] = A[i, elem] * per;
        }
        // end
        return A;
        
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int ctr = A.GetLength(0);
        int stol = A.GetLength(1);
        int pl = 0;
        int min = 0;
        int max = -1000000000;
        int maxim = 0;
        if (ctr != 7 || stol != 5) return null;

        for (int i = 0; i < stol; i++)
        {
            max = -1000000000;
            pl = 0;
            min = 0;
            for (int j = 0; j < ctr; j++)
            {
                if (A[j, i] > 0)
                {
                    pl++;
                }
                else if (A[j, i] < 0)
                {
                    min++;
                }
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    maxim = j;
                }
            }
            if (pl > min)
            {
                A[maxim, i] = 0;
            }
            else
            {
                A[maxim, i] = maxim;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int ctr = A.GetLength(0);
        int stol = A.GetLength(1);
        int max = -100000000;
        int maxim = 0;
        int summa = 0;
        if (ctr != 10 || stol != 5) return null;

        for (int i = 0; i < stol; i++)
        {
            max = -100000000;
            summa = 0;
            for (int j = 0; j < ctr; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    maxim = j;
                }
            }
            if (maxim == ctr - 1)
            {
                continue;
            }
            for (int j = maxim + 1; j < ctr; j++)
            {
                summa += A[j, i];
            }
            if (maxim < ctr / 2)
            {
                A[0, i] = summa;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int ctr = A.GetLength(0);
        int stol = A.GetLength(1);
        int[,] C = default(int[,]);
        int max = -1000000000;
        int maxim = 0;
        if (ctr != 7 || stol != 5) return null;

        bool bol1 = false;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] != 0)
            {
                bol1 = true;
                break;
            }
        }
        if (bol1 == false)
            return C;
        for (int i = 0; i < stol; i++)
        {
            max = -1000000000;
            for (int j = 0; j < ctr; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    maxim = j;
                }
            }
            if (max < B[i])
            {
                A[maxim, i] = B[i];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int ctr = A.GetLength(0);
        int stol = A.GetLength(1);
        double[,] B = default(double[,]);
        double max = -1000000000;
        int maxim = 0;
        bool bol = false;
        if (ctr != 7 || stol != 5) return null;

        for (int i = 0; i < stol; i++)
        {
            max = -1000000000;
            for (int j = 0; j < ctr; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    maxim = j;
                }
            }
            if ((A[0, i] + A[ctr - 1, i]) / 2 > max)
            {
                A[maxim, i] = (A[0, i] + A[ctr - 1, i]) / 2;
            }
            else
            {
                A[maxim, i] = maxim;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] A = default(int[,]);

        // code here

        if (n <= 0)
        {
            return A;
        }
        A = new int[n, n * 3];
        int ctr = A.GetLength(0);
        int stol = A.GetLength(1);
        for (int i = 0; i < ctr; i++)
        {
            for (int j = 0; j < stol; j++)
            {
                A[i, j] = 0;
            }
        }

        int count = -1;
        for (int i = 0; i < ctr; i++)
        {
            count++;
            for (int j = count; j < stol;)
            {
                A[i, j] = 1;
                j += 3;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int ctr = A.GetLength(0);
        int stol = A.GetLength(1);
        int[,] answer = default(int[,]);
        if (ctr != 6 || stol != 6) return null;

        int max = -1000000000;
        int maxim = 0;
        for (int i = 0; i < ctr; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                maxim = i;
            }
        }

        for (int i = 0; i < maxim; i++)
        {
            for (int j = i + 1; j < stol; j++)
                A[i, j] = 0;
        }
        // end

        return A;
    }
    
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int ctr = B.GetLength(0);
        int stol = B.GetLength(1);
        int[,] answer = default(int[,]);
        int max_1 = -1000000000;
        int maxim_1 = 0;
        int max_2 = -1000000000;
        int maxim_2 = 0;
        if (ctr != 6 || stol != 6) return null;

        for (int i = 0; i < ctr; i += 2)
        {
            max_1 = -1000000000;
            max_2 = -1000000000;
            for (int j = 0; j < stol; j++)
            {
                if (B[i, j] > max_1)
                {
                    max_1 = B[i, j];
                    maxim_1 = j;
                }
            }
            for (int j = 0; j < stol; j++)
            {
                if (B[i + 1, j] > max_2)
                {
                    max_2 = B[i + 1, j];
                    maxim_2 = j;
                }
            }
            B[i, maxim_1] = max_2;
            B[i + 1, maxim_2] = max_1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int ctr = A.GetLength(0);
        int stol = A.GetLength(1);

        if (ctr != 6 || stol != 7) return null;

        for (int i = 0; i < ctr; i++)
        {
            for (int j = 0; j < stol / 2; j++)
            {
                int P = A[i, j];
                A[i, j] = A[i, stol - j - 1];
                A[i, stol - j - 1] = P;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int nom = 0, min = int.MaxValue, max = int.MinValue;
        int[,] A = new int[7,5];
        int[] B = new int[7];
        if ((matrix.GetLength(0) == 7) && (matrix.GetLength(1) == 5))
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        nom = j;
                    }
                }
                B[i] = matrix[i, nom];
                nom = 0;
                min = int.MaxValue;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (B[j] > max)
                    {
                        max = B[j];
                        nom = j;
                    }
                }
                B[nom] = int.MinValue;
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = matrix[nom, j];
                }
                max = int.MinValue;
                nom = 0;
            }

        }
        else
            A = null;

        // end

        return A;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = rows;
        int[] answer = default(int[]);
        // code here
        bool continueProgram = false;
        for (int q = 0; q < rows; q++)
        {
            for (int m = 0; m < cols; m++)
            {
                if (matrix[q, m] != 0)
                {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return null;


        answer = new int[2 * cols - 1];
        int half = (int)answer.Length / 2;
        for (int i = 0; i < cols; i++)
        {
            int sum_l = 0;
            int sum_r = 0;
            for (int j = 0; j < rows; j++)
            {
                if (i - j >= 0)
                {
                    sum_l = sum_l + matrix[rows - 1 - j, i - j];
                }
                if (i + j < rows)
                {
                    sum_r = sum_r + matrix[j, i + j];
                }
            }
            answer[i] = sum_l;
            answer[i + half] = sum_r;
        }

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here
        int nom1 = 0, nom2 = 0;
        int max = -10000000;
        int[] A = new int[matrix.GetLength(0)];
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || k <= 0) return null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0;j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i,j]) > max)
                {
                    max = Math.Abs(matrix[i,j]);
                    nom1 = i;
                    nom2 = j;
                    
                }
            }
        }
            for (int j = 0; j < matrix.GetLength(0); j++)
                A[j] = matrix[nom1, j];
            for (int j = 0; j < matrix.GetLength(0); j++)
                matrix[nom1,j] = matrix[k-1,j];
            for (int j = 0; j < matrix.GetLength(0); j++)
                matrix[k-1, j] = A[j];

            for (int j = 0; j < matrix.GetLength(0); j++)
                A[j] = matrix[j,nom2];
            for (int j = 0; j < matrix.GetLength(0); j++)
                matrix[j,nom2] = matrix[j,k-1];
            for (int j = 0; j < matrix.GetLength(0); j++)
                matrix[j,k-1] = A[j];
        // end
        return matrix;
        

    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end
        return (upper,lower);
        
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);
        answer = new int[n * n];
        int[,] first_matrix = new int[n, n];
        int[,] second_matrix = new int[n, n];
        int index = 0;

        bool continueProgram = false;
        for (int q = 0; q < A.Length; q++)
        {
            if (A[q] != 0 || B[q] != 0)
                continueProgram = true;
        }

        if (!continueProgram)
            return null;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                first_matrix[i, j] = A[index];
                second_matrix[i, j] = B[index];
                index++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                first_matrix[j, i] = first_matrix[i, j];
                second_matrix[j, i] = second_matrix[i, j];
            }
        }

        index = 0;
        int s;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                s = 0;
                for (int l = 0; l < n; l++)
                {
                    s = s + first_matrix[i, l] * second_matrix[l, j];
                }
                answer[index++] = s;
            }
        }
        return answer;

    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        // code here
        bool continueProgram = false;
        for (int q = 0; q < rows; q++)
        {
            for (int m = 0; m < cols; m++)
            {
                if (matrix[q, m] != 0)
                {
                    continueProgram = true;
                    break;
                }
            }
            if (continueProgram)
                break;
        }
        if (continueProgram == false)
            return null;

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < cols - i - 1; j++)
            {
                int countCurrent = 0;
                int countNext = 0;
                for (int p = 0; p < rows; p++)
                {
                    if (matrix[p, j] < 0)
                        countCurrent++;
                    if (matrix[p, j + 1] < 0)
                        countNext++;
                }
                if (countCurrent > countNext)
                {
                    int[] temp = new int[rows];
                    for (int p = 0; p < rows; p++)
                    {
                        temp[p] = matrix[p, j];
                        matrix[p, j] = matrix[p, j + 1];
                        matrix[p, j + 1] = temp[p];
                    }
                }
            }
        }
        
        return matrix;
        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int ctr = matrix.GetLength(0);
        int stol = matrix.GetLength(1);
        int a = 0;
        bool f = false;

        for (int i = 0; i < ctr; i++)
        {
            for (int j = 0; j < stol; j++)
            {
                if (matrix[i, j] == 0)
                {
                    a++;
                    f = true;
                    break;
                }
            }
            if (f)
            {
                f = false;
                continue;
            }
        }
        int per = 0;
        int[,] A = new int[ctr - a, stol];
        for (int i = 0; i < ctr; i++)
        {
            for (int j = 0; j < stol; j++)
            {
                if (matrix[i, j] == 0)
                {
                    a++;
                    f = true;
                    break;
                }
                A[per, j] = matrix[i, j];
            }
            if (f)
            {
                f = false;
                continue;
            }
            per++;
            if (per >= ctr - a)
                break;
        }
        matrix = A;
        
        return matrix;
        // end

        
    }
    #endregion
}