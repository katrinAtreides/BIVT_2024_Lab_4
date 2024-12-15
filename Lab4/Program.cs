using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        // :3
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        for (int i=0; i<A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                answer += A[i, j];
            }
        }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        double amount = 0; // amount of positive elements

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                { 
                    answer += A[i, j];
                    amount++;
                }
            }
        }

        if (answer != 0) { answer /= amount; }
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        for (int i=0; i<A.GetLength(0); i++)
        {
            answer += A[i, i];
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

        int max = int.MinValue;

        for (int i=0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i,j] < A[row,col]) { row = i; col = j; }
            }
        }
        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        rowIndex = 0;
        if (colIndex > A.GetLength(1)) return (value, rowIndex);

        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        answer = new int[A.GetLength(0)];
        if (A.GetLength(0) < 4 && A.GetLength(1) > 7) return null;

        for (int i=0; i < A.GetLength(0); i++)
        {
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < A[i, index]) index = j;
            }
            answer[i] = index;
        }

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        answer = new int[A.GetLength(1)];
        if (A.GetLength(0) < 3 && A.GetLength(1) > 5) return null;

        for (int i = 0; i < A.GetLength(1); i++)
        {
            int index = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > A[index, i]) index = j;
            }
            answer[i] = A[index, i];
        }

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        answer = new double[A.GetLength(0)];
        if (A.GetLength(0) < 4 && A.GetLength(1) > 6) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int count = 0;
            double sum = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0) { sum += A[i, j]; count++; }
            }

            if (count != 0) answer[i] = sum / count;
        }

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here

        if (A.GetLength(0) < 5 && A.GetLength(1) > 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int iMax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, iMax]) iMax = j;
            }

            int temp = A[i, 0];
            A[i, 0] = A[i, iMax];
            A[i, iMax] = temp;
        }

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here
        if (A.GetLength(0) < 5 && A.GetLength(1) > 7) return null;

        int iMax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > A[iMax, 2]) iMax = i;
        }

        // temporarily save string with max element to an array
        int[] temp = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            temp[j] = A[iMax, j];
        }

        // fill the string with max
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[iMax, j] = A[3, j];
        }

        // fill the 4th string
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[3, j] = temp[j];
        }
        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        if (A.GetLength(0) < 5 && A.GetLength(1) > 7) return null;

        int iDel = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < A[iDel, 0]) iDel = i;
        }

        int[,] newA = new int[A.GetLength(0) - 1, A.GetLength(1)];

        for (int i = 0, k = 0; i < newA.GetLength(0); i++)
        {
            if (i == iDel) k++;
            for (int j = 0; j < newA.GetLength(1); j++)
            {
                newA[i, j] = A[k, j];
            }
            k++;
        }

        A = newA;

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here

        if (A.GetLength(0) < 5 && A.GetLength(1) > 7) return null;

        int iMax = 0, jMax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[iMax, jMax]) 
                { 
                    iMax = i; 
                    jMax = j;
                }
            }
        }

        int[,] newA = new int[A.GetLength(0) - 1, A.GetLength(1)-1];

        for (int i = 0, k = 0; i < newA.GetLength(0); i++)
        {
            if (i == iMax) k++;
            for (int j = 0, l=0; j < newA.GetLength(1); j++)
            {
                if (l == jMax) l++;
                newA[i, j] = A[k, l];
                l++;
            }
            k++;
        }

        A = newA;

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        if (A.GetLength(0) < 5 && A.GetLength(1) > 5) return null;

        int jMax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > A[i, jMax]) jMax = i;
        }

        // temporarily save column with max element to an array
        int[] temp = new int[A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            temp[i] = A[i, jMax];
        }

        // fill the max column
        for (int i = 0; i < A.GetLength(1); i++)
        {
            A[i,jMax] = A[i, 3];
        }

        // fill the 4th string
        for (int i = 0; i < A.GetLength(1); i++)
        {
            A[i, 3] = temp[i];
        }

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        if (A.GetLength(0) < 4 && A.GetLength(1) > 3) return null;

        answer = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0) count++;
            }

            answer[j] = count;
        }

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here

        if (A.GetLength(0) < 5 && A.GetLength(1) > 7) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, jMax]) jMax = j;
            }

            A[i, jMax] *= i+1;
        }

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        if (A.GetLength(0) < n && A.GetLength(1) > m) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, jMax]) jMax = j;
            }

            int max = A[i, jMax];
            for (int j = jMax; j < A.GetLength(1); j++)
            {
                if (j == m - 1) A[i, j] = max;
                else A[i, j] = A[i, j + 1];
            }
        }

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        if (B.GetLength(0) < n && B.GetLength(1) > m) return null;

        for (int i = 0; i < B.GetLength(0); i++)
        {
            int jMin = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] < B[i, jMin]) jMin = j;
            }

            int min = B[i, jMin];
            for (int j = jMin; j >= 0; j--)
            {
                if (j == 0) B[i, j] = min;
                else B[i, j] = B[i, j - 1];
            }
        }

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here

        for (int i = 0; i < D.GetLength(0); i++)
        {
            int jMax = -1, jNeg = -1, max = int.MinValue;
            bool check = false;
            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (!check && D[i, j] < 0) check = true;
                else if (check && D[i, j] < 0) jNeg = j;

                if (!check && D[i, j] > max) { jMax = j; max = D[i, j]; }
            }

            if (jNeg != -1 && jMax != -1)
            {
                int temp = D[i, jMax];
                D[i, jMax] = D[i, jNeg];
                D[i, jNeg] = temp;
            }
        }

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        for (int i = 0; i < C.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 0; j < C.GetLength(1); j++)
            {
                if (C[i, j] > C[i, jMax]) jMax = j;
            }

            for (int j = 0; j < jMax; j++)
            {
                if (C[i, j] < 0) C[i, j] /= C[i, jMax];
            }
        }

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        for (int i = 0; i < F.GetLength(0); i++)
        {
            int jMax = 0;
            double first = 0, last = 0;
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] > F[i, jMax]) jMax = j;

                if (first == 0 && F[i, j] < 0) first += F[i, j];
                else if (first < 0 && F[i, j] < 0) last = F[i, j];
            }

            if (first != 0 && last != 0) F[i, jMax] = (first + last) / 2;
        }

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here

        if (H.GetLength(0) < 5 && H.GetLength(1) > 7) return null;

        for (int i = 0; i < H.GetLength(0); i++)
        {
            H[i, H.GetLength(1) - 1] = H[i, H.GetLength(1) - 2];
        }

        for (int i = 0; i < H.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 0; j < H.GetLength(1); j++)
            {
                if (H[i, j] > H[i, jMax]) jMax = j;
            }

            H[i, H.GetLength(1) - 2] = H[i, jMax];
        }

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        if (Z.GetLength(0) < 6 && Z.GetLength(1) > 8) return null;

        int jMax = 0, iMax=0, pCount = 0;
        double pAve = 0;

        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > Z[iMax, jMax]) { iMax = i; jMax = j; }

                if (Z[i,j]>0)
                {
                    pCount++;
                    pAve += Z[i, j];
                }
            }
        }

        if (pCount > 0)
        {
            Z[iMax, jMax] = pAve / pCount;
        }

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        if (G.GetLength(0) < 5 && G.GetLength(1) > 7) return null;

        for (int i = 0; i < G.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] > G[i, jMax]) jMax = j;
            }

            for (int j = G.GetLength(1)-1; j > jMax; j--)
            {
                if (j == jMax + 1) G[i, j] = G[i, jMax];
                else G[i,j] = G[i,j-1]; 
            }
        }

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

        if (Y.GetLength(0) < 6 && Y.GetLength(1) > 5) return null;

        for (int i = 0; i < Y.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > Y[i, jMax]) jMax = j;
            }

            int pCount = 0;
            double pAve = 0;
            for (int j = jMax + 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > 0)
                {
                    pCount++;
                    pAve += Y[i, j];
                }
            }

            if (pCount > 0) pAve /= pCount;

            for (int j = 0; j < jMax; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = pAve;
            }
        }

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        if (X.GetLength(0) < 6 && X.GetLength(1) > 5) return null;

        int iMax = 0, iMin = 0, max = int.MinValue, min = int.MaxValue;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0) count++;
            }

            if (count > max)
            {
                iMax = i;
                max = count;
            }
            else if (count < min)
            {
                iMin = i;
                min = count;
            }
        }

        int[] temp = new int[X.GetLength(1)];
        for (int j = 0; j < X.GetLength(1); j++)
        {
            temp[j] = X[iMax, j];
        }

        for (int j = 0; j < X.GetLength(1); j++)
        {
            X[iMax, j] = X[iMin, j];
        }

        for (int j = 0; j < X.GetLength(1); j++)
        {
            X[iMin, j] = temp[j];
        }

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        if ((A.GetLength(0) < 5 && A.GetLength(1) > 7) || B.Length<7) return null;

        int iMax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > A[iMax, 5]) iMax = i;
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[iMax, j] = B[j];
        }

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here

        if (B.GetLength(0) < 5 && B.GetLength(1) > 7) return null;

        int[] N = new int[B.GetLength(0)];

        for (int i = B.GetLength(0)-1, k=0; i >= 0; i--)
        {
            int jMax = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i,jMax]) jMax = j;  
            }

            N[k] = B[i, jMax];
            k++;
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i,3] = N[i];
        }

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        if (A.GetLength(0) < 7 && A.GetLength(1) > 5) return null;

        int mSum=0, iDel = -1;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0) sum+= A[i, j];
            }

            if (sum>mSum)
            {
                mSum = sum;
                iDel= i;
            }
        }

        if (iDel!=-1)
        {
            int[,] newA = new int[A.GetLength(0) - 1, A.GetLength(1)];

            for (int i = 0, k=0; i < newA.GetLength(0); i++)
            {
                if (k == iDel) k++;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    newA[i, j] = A[k, j];
                }
                k++;
            }

            A = newA;
        }

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        if (F.GetLength(0) < 5 && F.GetLength(1) > 7) return null;

        int jDel = 0;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < F[1, jDel]) jDel = j;
        }

        jDel++;

        if (jDel < F.GetLength(1))
        {
            int[,] newF = new int[F.GetLength(0), F.GetLength(1)-1];

            for (int i = 0; i < F.GetLength(0); i++)
            {
                for (int j = 0, k = 0; j < newF.GetLength(1); j++)
                {
                    if (k == jDel) k++;
                    newF[i, j] = F[i,k];
                    k++;
                }
            }

            F = newF;
        }

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here

        if (B.GetLength(0) < 5 && B.GetLength(1) > 5) return null;

        int iMax = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] > B[iMax, iMax]) { iMax = i; }
        }

        int iNeg = -1;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0) { iNeg = i; break; }
        }

        // temporarily copy iMax to an array
        int[] temp = new int[B.GetLength(1)];
        for (int j = 0; j < B.GetLength(1); j++)
        {
            temp[j] = B[iMax,j];
        }

        // fill the iMax column
        for (int j = 0; j < B.GetLength(1); j++)
        {
            B[iMax, j] = B[iNeg, j];
        }

        // fill the iNeg string
        for (int j = 0; j < B.GetLength(1); j++)
        {
            B[iNeg, j] = temp[j];
        }

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

        if (A.GetLength(0) < 5 || A.GetLength(1) > 8 || B.Length < 5 || B.Length > 5) return null;

        int jMin = 0;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if (A[4, j] < A[4, jMin]) jMin = j;
        }

        for (int j = A.GetLength(1)-1; j > jMin; j--)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (j == jMin+1) A[i, j] = B[i];
                else A[i, j] = A[i, j - 1];
            }
        }

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here

        if (A.GetLength(0) < 5 || A.GetLength(1) > 7) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int jMax = 0, pCount = 0;
            double pAve = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, jMax]) jMax = j;

                if (A[i,j]>0) { pAve += A[i, j]; pCount++; }
            }

            if (pCount > 0) pAve /= pCount;
            A[i, jMax] = pAve;
        }

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        if (A.GetLength(0) < 5 || A.GetLength(1) > 7) return null;

        int count = 0;
        for (int i = 0, k=0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) count++;
            }
        }

        answer = new int[count];
        for (int i = 0, k = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) { answer[k] = A[i, j]; k++; }
            }
        }

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here

        // end

        return A;
    }
    
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        // end

        return A;
    }

    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

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

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

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
        // code here

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

        // end

        return matrix;
    }
    #endregion
}
