using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program main = new Program();
        Random rand = new Random();
        const int ERROR = 0;
        const double EPS = 0.0001;
        const int[] DEFAULT_ARRAY = default(int[]);
        const int[,] DEFAULT_MATRIX = default(int[,]);

        [TestMethod()]
        public void Task_1_1Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 5, 6, 7, 8, 9, 10, 11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { 13, 14, 15, 16, 17, 18, 19 },
                { 0, 1, 2, 3, 4, 5, 6 }
            };
            int[,] error = new int[rand.Next(0, 5), rand.Next(8, 10)];
            int outputC, outputE, answer = 301;
            // Act
            outputC = main.Task_1_1(matrix);
            outputE = main.Task_1_1(error);
            // Assert
            Assert.AreEqual(answer, outputC);
            Assert.AreEqual(ERROR, outputE);
        }
        [TestMethod()]
        public void Task_1_2Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 5, 6, 7, 8, 9, 10, 11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { 13, 14, 15, 16, 17, 18, 19 },
                { 0, 1, 2, 3, 4, 5, 6 }
            };
            int[,] error = new int[rand.Next(0, 5), rand.Next(8, 10)];
            double outputC, outputE, answer = 8.852941176470589;
            // Act
            outputC = main.Task_1_2(matrix);
            outputE = main.Task_1_2(error);
            // Assert
            Assert.IsTrue(Math.Abs(answer - outputC) < EPS);
            Assert.AreEqual(ERROR, outputE);
        }
        [TestMethod()]
        public void Task_1_3Test()
        {
            // Arrange
            int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };
            int[,] error = new int[rand.Next(0, 4), rand.Next(5, 9)];
            int outputC, outputE, answer = 34;
            // Act
            outputC = main.Task_1_3(matrix);
            outputE = main.Task_1_3(error);
            // Assert
            Assert.AreEqual(answer, outputC);
            Assert.AreEqual(ERROR, outputE);
        }
        [TestMethod()]
        public void Task_1_4Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, 5, 6 },
                { 5, 6, 7, 8, 9, 11 },
                { 0, 2, 3, 4, 5, 6 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(7, 10)];
            double rowC, colC, rowE, colE, row = 2, col = 0;
            // Act
            (rowC, colC) = main.Task_1_4(matrix);
            (rowE, colE) = main.Task_1_4(error);
            // Assert
            Assert.AreEqual(row, rowC);
            Assert.AreEqual(col, colC);
            Assert.AreEqual(ERROR, rowE);
            Assert.AreEqual(ERROR, colE);
        }
        [TestMethod()]
        public void Task_1_5Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 4, 6 },
                { 5, -6, 7, 11 },
                { 0, 2, 3, -6 },
                { -1, 4, -5, 6 },
                { 1, 4, 5, 6 }
            };
            int target = 2;
            int[,] error = new int[rand.Next(0, 5), rand.Next(5, 10)];
            double valueC, valueE, value = -5;
            int rowC, rowE, row = 3;
            // Act
            (valueC, rowC) = main.Task_1_5(matrix, target);
            (valueE, rowE) = main.Task_1_5(error, target);
            // Assert
            Assert.AreEqual(value, valueC);
            Assert.AreEqual(row, rowC);
            Assert.AreEqual(ERROR, valueE);
            Assert.AreEqual(ERROR, rowE);
        }
        [TestMethod()]
        public void Task_1_6Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 5, 6, 7, 8, -9, 10, 11 },
                { 9, 10, -11, -12, -13, -14, -15 },
                { -13, -14, 15, 16, 17, 18, -19 }
            };
            int[,] error = new int[rand.Next(0, 4), rand.Next(8, 10)];
            int[] outputC, outputE, answer = new int[] { 0, 4, 6, 6 };
            // Act
            outputC = main.Task_1_6(matrix);
            outputE = main.Task_1_6(error);
            // Assert
            Assert.AreEqual(answer.Length, outputC.Length);
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], outputC[i]);
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_7Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, -5 },
                { 5, 11, -17, 11, -10 },
                { -9, -10, -11, -14, -15 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[] outputC, outputE, answer = new int[] { 5, 11, 3, 11, -5 };
            // Act
            outputC = main.Task_1_7(matrix);
            outputE = main.Task_1_7(error);
            // Assert
            Assert.AreEqual(answer.Length, outputC.Length);
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], outputC[i]);
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_8Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, -5, -6 },
                { 5, 11, -17, 11, -10, 6 },
                { -9, -10, -11, -14, -15, -6 },
                { -9, -10, -11, -14, -15, 6 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            double[] outputC, outputE, answer = new double[] { 2.5, 8.25, 0, 6 };
            // Act
            outputC = main.Task_1_8(matrix);
            outputE = main.Task_1_8(error);
            // Assert
            Assert.AreEqual(answer.Length, outputC.Length);
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], outputC[i]);
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_9Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1 },
                { -9, -10, -11, -14, -15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 4, 2, 3, 1, -5, -6, -7 },
                { 11, 5, -17, 11, -10, 6, 5 },
                { 1, -10, -11, -14, -15, -16, -9 },
                { -2, -10, -11, -14, -15, -6, -9 },
                { 6, -10, -11, -14, -15, -9, 4 }
            };
            // Act
            outputC = main.Task_1_9(matrix);
            outputE = main.Task_1_9(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_10Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1 },
                { -9, -10, -11, -14, -15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { -9, -10, -11, -14, -15, -6, -2 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1  },
                { 1, 2, 3, 4, -5, -6, -7  },
                { -9, -10, -11, -14, -15, 6, 4 }
            };
            // Act
            outputC = main.Task_1_10(matrix);
            outputE = main.Task_1_10(error);
            // Assert
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_11Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1 },
                { -9, -10, -11, -14, -15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 }
            };
            // Act
            outputC = main.Task_1_11(matrix);
            outputE = main.Task_1_11(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_12Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, -5, -6, -7 },
                { 5, 11, -17, 11, -10, 6, 5 },
                { -9, -10, -11, -14, -15, -16, 1 },
                { -9, -10, -11, -14, 15, -6, -2 },
                { -9, -10, -11, -14, -15, 6, 4 },
                { 0, -2, -3, -4, -5, 0, 5 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, 3, 4, -6, -7 },
                { 5, 11, -17, 11, 6, 5 },
                { -9, -10, -11, -14, -16, 1 },
                { -9, -10, -11, -14, 6, 4 },
                { 0, -2, -3, -4, 0, 5 }
            };
            // Act
            outputC = main.Task_1_12(matrix);
            outputE = main.Task_1_12(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_13Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3, 4, -5 },
                { 5, 11, -17, 11, 7 },
                { -9, -10, -11, -14, -15 },
                { -9, -10, -11, -14, -6 },
                { 0, -2, -3, -4, -5 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 4, 3, 2, -5 },
                { 5, 11, -17, 11, 7 },
                { -9, -14, -11, -10, -15 },
                { -9, -14, -11, -10, -6 },
                { 0, -4, -3, -2, -5 }
            };
            // Act
            outputC = main.Task_1_13(matrix);
            outputE = main.Task_1_13(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_14Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3 },
                { 5, 11, -17},
                { 9, -10, -11},
                { 0, -2, -3 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[] outputC, outputE, answer = new int[] { 0, 2, 3 };
            // Act
            outputC = main.Task_1_14(matrix);
            outputE = main.Task_1_14(error);
            // Assert
            Assert.AreEqual(answer.Length, outputC.Length);
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], outputC[i]);
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_15Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, -12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 18, -10, -11 },
                { 9, 10, 11, -12, 13, 14, 45 },
                { -13, 14, 15, 16, 68, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
            // Act
            outputC = main.Task_1_15(matrix);
            outputE = main.Task_1_15(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_16Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, -12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
            int[,] outputC, answer = new int[,] {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, -10, -11, 9 },
                { 9, 10, 11, -12, 13, 14, 15 },
                { -13, 14, 15, 16, -18, -19, 17 },
                { -1, -2, -3, -4, -5, -6, 0 }
            };
            // Act
            outputC = main.Task_1_16(matrix, matrix.GetLength(0), matrix.GetLength(1));
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
        }
        [TestMethod()]
        public void Task_1_17Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
            int[,] outputC, answer = new int[,] {
                { -5,1, 2, -3, 4,  6, 7 },
                {  -11, 5, 6, -7, 8, 9, -10},
                { 9, 10, 11, 12, 13, 14, 15 },
                { -19, -13, 14, 15, 16, 17, -18 },
                { -6, 0, -1, -2, -3, -4, -5 }
            };
            // Act
            outputC = main.Task_1_17(matrix, matrix.GetLength(0), matrix.GetLength(1));
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
        }
        [TestMethod()]
        public void Task_1_18Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
            int[,] outputC, answer = new int[,] {
                { 1, -5, -3, 4, 2, 6, 7 },
                { 5, -11, -7, 8, 9, -10, 6 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                {  -6, -1, -2, -3, -4, -5, 0 }
            };
            // Act
            outputC = main.Task_1_18(matrix, matrix.GetLength(0), matrix.GetLength(1));
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
        }
        [TestMethod()]
        public void Task_1_19Test()
        {
            // Arrange
            double[,] matrix = {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
            double[,] outputC, answer = new double[,] {
                { 1, 2, -0.42857142857142855, 4, -0.7142857142857143, 6, 7 },
                { 5, 6, -0.7777777777777778, 8, 9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -0.7647058823529411, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
            // Act
            outputC = main.Task_1_19(matrix, matrix.GetLength(0), matrix.GetLength(1));
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(Math.Round(answer[i, j], 2), Math.Round(outputC[i, j], 2));
                }
            }
        }
        [TestMethod()]
        public void Task_1_20Test()
        {
            // Arrange
            double[,] matrix = {
                { 1, 2, -3, 4, -5, 6, 7 },
                { 5, 6, -7, 8, 9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, 17, -18, -19 },
                { 0, -1, -2, -3, -4, -5, -6 }
            };
            double[,] outputC, answer = new double[,] {
                { 1, 2, -3, 4, -5, 6, -4 },
                { 5, 6, -7, 8, -9, -10, -11 },
                { 9, 10, 11, 12, 13, 14, 15 },
                { -13, 14, 15, 16, -16, -18, -19 },
                { -3.5, -1, -2, -3, -4, -5, -6 }
            };
            // Act
            outputC = main.Task_1_20(matrix, matrix.GetLength(0), matrix.GetLength(1));
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(Math.Round(answer[i, j], 2), Math.Round(outputC[i, j], 2));
                }
            }
        }
        [TestMethod()]
        public void Task_1_21Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 4, -5, 7, 0 },
                { 5, 6, -7, 8, 9, -11, 0 },
                { 9, 10, 11, 12, 13, 15, 0 },
                { -13, 14, 15, 16, 17, -19,0 },
                { 0, -1, -2, -3, -4, -6, 0 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, -3, 4, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 15, 16, 17, 17, -19 },
                { 0, -1, -2, -3, -4, 0, -6 }
            };
            // Act
            outputC = main.Task_1_21(matrix);
            outputE = main.Task_1_21(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_22Test()
        {
            // Arrange
            double[,] matrix = {
                { 1, 2, -3, 4, -5, 6, 7, 8 },
                { 5, 6, -7, 8, 9, -10, -11, 12 },
                { 9, 10, 11, 12, 13, 14, 15, 16 },
                { -13, 14, 15, 16, 17, -18, -19, 0 },
                { 0, -1, -2, -3, -4, -5, -6, 0 },
                { 0, 1, -2, 3, -4, 5, -6, 5 }
            };
            double[,] error = new double[rand.Next(0, 3), rand.Next(10, 20)];
            double[,] outputC, outputE, answer = new double[,] {
                { 1, 2, -3, 4, -5, 6, 7, 8 },
                { 5, 6, -7, 8, 9, -10, -11, 12 },
                { 9, 10, 11, 12, 13, 14, 15, 16 },
                { -13, 14, 15, 16, 9.04, -18, -19, 0 },
                { 0, -1, -2, -3, -4, -5, -6, 0 },
                { 0, 1, -2, 3, -4, 5, -6, 5 }
        };
            // Act
            outputC = main.Task_1_22(matrix);
            outputE = main.Task_1_22(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(Math.Round(answer[i, j], 2), Math.Round(outputC[i, j], 2));
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_23Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 4, -5, 7, 0 },
                { 5, 6, -7, 8, 9, -11, 0 },
                { 9, 10, 11, 12, 13, 15, 0 },
                { -13, 14, 25, 16, 17, -19,0 },
                { 0, -1, -2, -3, -4, -6, 0 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, -3, 4, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 25, 25, 16, 17, -19 },
                { 0, 0, -1, -2, -3, -4, -6 }
            };
            // Act
            outputC = main.Task_1_23(matrix);
            outputE = main.Task_1_23(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_24Test()
        {
            // Arrange
            double[,] matrix = {
                { 1, 2, -3, 4, -5 },
                { 5, 6, -7, 8, 9, },
                { 9, 10, 11, 12, 13},
                { -13, 14, 25, 16, 11 },
                { 0, -1, -2, -3, -4 },
                { 1, -1, 2, -2, 3 }
            };
            double[,] error = new double[rand.Next(0, 3), rand.Next(8, 10)];
            double[,] outputC, outputE, answer = new double[,] {
                { 1, 2, 0, 4, -5 },
                { 5, 6, 0, 8, 9, },
                { 9, 10, 11, 12, 13},
                { 13.5, 14, 25, 16, 11 },
                { 0, -1, -2, -3, -4 },
                { 1, 0, 2, 0, 3 }
            };
            // Act
            outputC = main.Task_1_24(matrix);
            outputE = main.Task_1_24(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_25Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 4, -5 },
                { 5, 6, -7, 8, 9 },
                { 9, 10, 11, 12, 13},
                { -13, 14, 25, 16, 11 },
                { 0, -1, -2, -3, -4 },
                { 1, -1, 2, -2, 3 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, -3, 4, -5 },
                { 5, 6, -7, 8, 9 },
                { 0, -1, -2, -3, -4 },
                { -13, 14, 25, 16, 11 },
                { 9, 10, 11, 12, 13 },
                { 1, -1, 2, -2, 3 }
            };
            // Act
            outputC = main.Task_1_25(matrix);
            outputE = main.Task_1_25(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_26Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 4, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 25, 25, 16, 17, -19 },
                { 0, 0, -1, -2, -3, -4, -6 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[] vector = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] vectorError = new int[rand.Next(0, 5)];
            int[,] outputC, outputE, outputER, answer = new int[,] {
                { 1, 2, -3, 4, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { 1, 2, 3, 4, 5, 6, 7 },
                { 0, 0, -1, -2, -3, -4, -6 }
            };
            // Act
            outputC = main.Task_1_26(matrix, vector);
            outputE = main.Task_1_26(error, vector);
            outputER = main.Task_1_26(matrix, vectorError);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
            Assert.IsNull(outputER);
        }
        [TestMethod()]
        public void Task_1_27Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 25, 25, 16, 17, -19 },
                { 0, 0, -1, -2, -3, -4, -6 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, -3, 0, -5, 7, 7 },
                { 5, 6, -7, 25, 9, 9, -11 },
                { 9, 10, 11, 15, 13, 15, 15 },
                { -13, 14, 25, 9, 16, 17, -19 },
                { 0, 0, -1, 7, -3, -4, -6 }
            };
            // Act
            outputC = main.Task_1_27(matrix);
            outputE = main.Task_1_27(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_28Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            // Act
            outputC = main.Task_1_28(matrix);
            outputE = main.Task_1_28(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_29Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 25, 25, 16, 17, -19 },
                { 0, 0, -1, -2, -3, -4, -6 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, -3, 7, -5, 7, 7 },
                { 5, -7, 8, 9, 9, -11 },
                { 9, 11, 12, 13, 15, 15 },
                { -13, 25, 25, 16, 17, -19 },
                { 0, -1, -2, -3, -4, -6 }
            };
            // Act
            outputC = main.Task_1_29(matrix);
            outputE = main.Task_1_29(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_30Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, -5},
                { 5, 6, -7, 8, 9 },
                { 9, 10, 11, 12, 13 },
                { -13, 14, 25, 25, 16 },
                { 0, 0, -1, -2, -3 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { -13, 14, 25, 25, 16 },
                { 5, 6, -7, 8, 9 },
                { 9, 10, 11, 12, 13 },
                { 1, 2, -3, 7, -5},
                { 0, 0, -1, -2, -3 }
            };
            // Act
            outputC = main.Task_1_30(matrix);
            outputE = main.Task_1_30(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_31Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, -5, 7, 7, 0 },
                { 5, 6, -7, 8, 9, 9, -11, 0},
                { 9, 10, 11, 12, 13, 15, 15, 0 },
                { -13, 14, 25, 25, 16, 17, -19, 0 },
                { 0, 0, -1, -2, -3, -4, -6, 0 }
            };
            int[] vector = new int[] { 1, 2, 3, 4, 5 };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[] errorVector = new int[rand.Next(8, 10)];
            int[,] outputC, outputE, outputV, answer = new int[,] {
                { 1, 2, -3, 7, -5, 7, 7, 1 },
                { 5, 6, -7, 8, 9, 9, -11, 2},
                { 9, 10, 11, 12, 13, 15, 15, 3 },
                { -13, 14, 25, 25, 16, 17, -19, 4 },
                { 0, 0, -1, -2, -3, -4, -6, 5 }
            };
            // Act
            outputC = main.Task_1_31(matrix, vector);
            outputV = main.Task_1_31(matrix, errorVector);
            outputE = main.Task_1_31(error, vector);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
            Assert.IsNull(outputV);
        }
        [TestMethod()]
        public void Task_1_32Test()
        {
            // Arrange
            double[,] matrix = {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 25, 25, 16, 17, -19 },
                { -6, -5, -1, -2, -3, -4, -6 }
            };
            double[,] error = new double[rand.Next(0, 3), rand.Next(8, 10)];
            double[,] outputC, outputE, answer = new double[,] {
                { 1, 2, -3, 4.8, -5, 7, 7 },
                { 5, 6, -7, 8, 7.4, 9, -11 },
                { 9, 10, 11, 12, 13, 12.142857142857142, 15 },
                { -13, 14, 19.4, 25, 16, 17, -19 },
                { -6, -5, 0, -2, -3, -4, -6 }
            };
            // Act
            outputC = main.Task_1_32(matrix);
            outputE = main.Task_1_32(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_1_33Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, 14, 25, 25, 16, 17, -19 },
                { -6, -5, -1, -2, -3, -4, -6 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[] outputC, outputE, answer = new int[] { -3, -5, -7, -11, -13, -19, -6, -5, -1, -2, -3, -4, -6 };
            // Act
            outputC = main.Task_1_33(matrix);
            outputE = main.Task_1_33(error);
            // Assert
            Assert.AreEqual(answer.Length, outputC.Length);
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], outputC[i]);
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_2_1Test()
        {
            // Arrange
            double[,] matrix = {
                { 1, 2, -3, 7, -5, 7, 7 },
                { 5, 6, -7, 8, 9, 9, -11 },
                { 9, 10, 11, 12, 13, 15, 15 },
                { -13, -30, 25, 25, 16, 17, -19 },
                { -6, -5, -1, -2, -3, -4, -6 }
            };
            double[,] error = new double[rand.Next(0, 3), rand.Next(8, 10)];
            double[,] outputC, outputE, answer = new double[,] {
                { 1, 2, -3, 7, -2.5, 7, 7 },
                { 5, 6, -7, 16, 9, 9, -11 },
                { 9, 10, 11, 12, 26, 15, 15 },
                { -13, -15, 25, 25, 16, 17, -19 },
                { -6, -2.5, -1, -2, -3, -4, -6 }
            };
            // Act
            outputC = main.Task_2_1(matrix);
            outputE = main.Task_2_1(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_2_2Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 0, 10, 11, 15, 3 },
                { -13, 0, 4, 0, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            // Act
            outputC = main.Task_2_2(matrix);
            outputE = main.Task_2_2(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_2_3Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 2, 3, -19 },
                { 1, 2, -3, 7, 0 },
                { 5, 0, -1, 9, -1 },
                { 9, 10, 11, 2, 15 },
                { 0, 0, -1, -2, -3 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(11, 15)];
            int[,] outputC, outputE, answer = new int[,] {
                { -6, 32, 1, 27, -18 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 2, 3, -19 },
                { 1, 2, -3, 7, 0 },
                { 5, 0, -1, 9, -1 },
                { 9, 10, 11, 2, 15 },
                { 0, 0, -1, -2, -3 }
            };
            // Act
            outputC = main.Task_2_3(matrix);
            outputE = main.Task_2_3(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_2_4Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            int[] vector = new int[] { 10, 20, 30, 0, -50 };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[] errorVector = new int[rand.Next(8, 10)];
            int[,] outputC, outputE, outputV, answer = new int[,] {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 10, 10, 11, 15, 15 },
                { -13, 20, 30, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            // Act
            outputC = main.Task_2_4(matrix, vector);
            outputV = main.Task_2_4(matrix, errorVector);
            outputE = main.Task_2_4(error, vector);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
            Assert.IsNull(outputV);
        }
        [TestMethod()]
        public void Task_2_5Test()
        {
            // Arrange
            double[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            double[,] error = new double[rand.Next(0, 3), rand.Next(8, 10)];
            double[,] outputC, outputE, answer = new double[,] {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 3, 10, 11, 15, 3 },
                { -13, 4, 4, 4, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            // Act
            outputC = main.Task_2_5(matrix);
            outputE = main.Task_2_5(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_2_6Test()
        {
            // Arrange
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 0, 0, 1, 0, 0, 1, 0, 0 },
                { 0, 1, 0, 0, 1, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 0, 1, 0, 0, 1 }
            };
            // Act
            outputC = main.Task_2_6(3);
            outputE = main.Task_2_6(-1);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_2_7Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(11, 15)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 0, 0, 0, 0, 0 },
                { 5, 6, 0, 0, 0, 0 },
                { 9, 10, 11, 0, 0, 0 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
            // Act
            outputC = main.Task_2_7(matrix);
            outputE = main.Task_2_7(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_2_8Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, -5 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(11, 15)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, -3, 9, 7, 0 },
                { 5, 6, -7, 7, -11, 1 },
                { 9, 10, 11, 25, 15, 2 },
                { -13, 14, 15, 25, -19, 3 },
                { 5, 6, -7, 8, 0, 4},
                { 9, 0, -1, -2, -3, -5 }
            };
            // Act
            outputC = main.Task_2_8(matrix);
            outputE = main.Task_2_8(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_2_9Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7, 0, -2 },
                { 5, 6, -7, 9, -11, 1, 3 },
                { 9, 10, 11, 15, 15, 2, 5 },
                { -13, 14, 25, 25, -19, 3, -7 },
                { 5, 6, -7, 8, 9, 4, 4},
                { 0, 0, -1, -2, -3, -5, 0 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(11, 15)];
            int[,] outputC, outputE, answer = new int[,] {
                { -2, 0, 7, 7, -3, 2, 1},
                { 3, 1, -11, 9, -7, 6, 5 },
                { 5, 2, 15, 15, 11, 10, 9 },
                { -7, 3, -19, 25, 25, 14, -13},
                { 4, 4, 9, 8, -7, 6, 5},
                { 0, -5, -3, -2, -1, 0, 0 }
            };
            // Act
            outputC = main.Task_2_9(matrix);
            outputE = main.Task_2_9(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_3_1Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 9, 10, 11, 15, 15 },
                { 1, 2, -3, 7, 7 },
                { 0, 0, -1, -2, -3 },
                { 5, 6, -7, 8, 9},
                { 5, 6, -7, 9, -11 },
                { -13, 14, 25, 25, -19 },
                { -13, 14, 25, 25, -19 }
            };
            // Act
            outputC = main.Task_3_1(matrix);
            outputE = main.Task_3_1(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_3_2Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(11, 15)];
            int[,] outputC, outputE, answer = new int[,] {
                { 0, 0, 0, 0, 0, 0 },
                { 0, 6, -7, 9, -11, 0 },
                { 0, 10, 11, 15, 15, 0 },
                { 0, 14, 25, 25, -19, 0 },
                { 0, 6, -7, 8, 9, 0},
                { 0, 0, 0, 0, 0, 0 }
            };
            // Act
            outputC = main.Task_3_2(matrix);
            outputE = main.Task_3_2(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_3_3Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 25, 25, -19, 3 },
                { 5, 6, -7, 8, 9, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(11, 15)];
            int[] outputC, outputE, answer = new int[2 * 6 - 1] { 0, 5, -8, 14, 45, 57, -5, 24, -2, 8, 0 };
            // Act
            outputC = main.Task_3_3(matrix);
            outputE = main.Task_3_3(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                Assert.AreEqual(answer[i], outputC[i]);
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_3_4Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9 },
                { 0, 0, -1, -2, -3 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(11, 15)];
            int[,] outputC, outputE, answer = new int[,] {
                { 1, 2, -3, 7, 7 },
                { 9, 10, 11, 15, 15 },
                { 1, 1, 1, 25, -19 },
                { 1, 1, 1, 1, 9 },
                { 1, 1, 1, 1, 1 }
            };
            // Act
            outputC = main.Task_3_4(matrix);
            outputE = main.Task_3_4(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_3_5Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 5, 25, -19, 3 },
                { 5, 6, -7, 8, -99, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(11, 15)];
            int[,] outputC, outputE, outputI, answer = new int[,] {
                { 1, 7, -3, 7, 2, 0 },
                { 5, -99, -7, 8, 6, 4 },
                { 9, 15, 11, 15, 10, 2 },
                { -13, -19, 5, 25, 14, 3 },
                { 5, -11, -7, 9, 6, 1},
                { 0, -3, -1, -2, 0, 5 }
            };
            // Act
            outputC = main.Task_3_5(matrix, 2);
            outputE = main.Task_3_5(error, 2);
            outputI = main.Task_3_5(matrix, 0);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
            Assert.IsNull(outputI);
        }
        [TestMethod()]
        public void Task_3_6Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 5, 25, -19, 3 },
                { 5, 6, -7, 8, -99, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(11, 15)];
            int[] outputC1, outputC2, outputE1, outputE2,
                answer1 = new int[] { 1, 2, -3, 7, 7, 0, 6, -7, 9, -11, 1, 11, 15, 15, 2, 25, -19, 3, -99, 4, 5 },
                answer2 = new int[] { 5, 9, 10, -13, 14, 5, 5, 6, -7, 8, 0, 0, -1, -2, -3 };
            // Act
            (outputC1, outputC2) = main.Task_3_6(matrix);
            (outputE1, outputE2) = main.Task_3_6(error);
            // Assert
            Assert.AreEqual(answer1.GetLength(0), outputC1.GetLength(0));
            Assert.AreEqual(answer2.GetLength(0), outputC2.GetLength(0));
            for (int i = 0; i < answer1.GetLength(0); i++)
            {
                Assert.AreEqual(answer1[i], outputC1[i]);
            }
            for (int i = 0; i < answer2.GetLength(0); i++)
            {
                Assert.AreEqual(answer2[i], outputC2[i]);
            }
            Assert.IsNull(outputE1);
            Assert.IsNull(outputE2);
        }
        [TestMethod()]
        public void Task_3_7Test()
        {
            // Arrange
            int[] A = { 1, 2, 3, 4, 5, 6 };
            int[] B = { 10, 11, 12, 13, 14, 15 };
            int[] errorA = new int[rand.Next(0, 1)];
            int[] errorB = new int[rand.Next(0, 1)];

            int[] outputC, outputE,
                answer = new int[] { 68, 79, 85, 124, 144, 155, 157, 182, 196 };
            // Act
            outputC = main.Task_3_7(A, B, 3);
            outputE = main.Task_3_7(errorA, errorB, 3);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                Assert.AreEqual(answer[i], outputC[i]);
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_3_8Test()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 9, 10, 11, 15, 15 },
                { 1, 2, -3, 7, 7 },
                { 5, 6, -7, 8, 9},
                { 5, 6, -7, 9, -11 },
                { -13, 14, 25, 25, -19 },
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }
            };
            // Act
            outputC = main.Task_3_8(matrix);
            outputE = main.Task_3_8(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_3_9Test()
        {
            // Arrange
            int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            };
            int[,] error = new int[rand.Next(0, 3), rand.Next(8, 10)];
            int[,] outputC, outputE, answer = new int[,] {
                { 7,    7,      1,      2,      -5,     -3,   7 },
                { 8,    9,      5,      6,      9,      -7,    -11 },
                { 12,   15,     9,      10,     13,     11,    15 },
                { 25,   17,     -13,    -30,    16,     25,  -19 },
                { -2,   -4,     -6,     -5,     -3,     -1,   -6 }
            };
            // Act
            outputC = main.Task_3_9(matrix);
            outputE = main.Task_3_9(error);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
            Assert.IsNull(outputE);
        }
        [TestMethod()]
        public void Task_3_10Test()
        {
            // Arrange
            int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  -30,    25,     25,     16,     17,     -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     -6 }
            };
            int[,] outputC, outputE, answer = new int[,] {
                { 7,    7,      7,      2,      1,      -3,     -5 },
                { -11,  -7,     5,      6,      8,      9,      9 },
                { 15,   15,     13,     12,     11,     10,     9 },
                { -30,  -19,    -13,    16,     17,     25,     25 },
                { -1,   -2,     -3,     -4,     -5,     -6,     -6 }
            };
            // Act
            outputC = main.Task_3_10(matrix);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
        }
        [TestMethod()]
        public void Task_3_11Test()
        {
            // Arrange
            int[,] matrix = {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  0,      25,     25,     16,     0,      -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     0 }
            };
            int[,] outputC, outputE, answer = new int[,] {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 }
            };
            // Act
            outputC = main.Task_3_11(matrix);
            // Assert
            Assert.AreEqual(answer.GetLength(0), outputC.GetLength(0));
            Assert.AreEqual(answer.GetLength(1), outputC.GetLength(1));
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Assert.AreEqual(answer[i, j], outputC[i, j]);
                }
            }
        }
    }
}