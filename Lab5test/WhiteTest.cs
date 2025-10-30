using System.Transactions;

namespace Lab5test
{
    [TestClass]
    public sealed class WhiteTest
    {
        Lab5.White _main = new Lab5.White();
        const double E = 0.0001;
        Data _data = new Data();

        [TestMethod]
        public void Test01()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new double[10] { 
                8.852941176470589,
                7,
                5.117647058823529,
                4.769230769230769,
                8.421052631578947,
                4.4,
                6,
                4.916666666666667,
                5.571428571428571,
                5.5 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task1(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test02()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new (int, int)[] {
                (4, 0),
                (0, 0),
                (2, 0),
                (1, 1),
                (3, 6),
                (1, 2),
                (0, 4),
                (1, 2),
                (1, 2),
                (1, 2)
            };
            var test = new (int, int)[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task2(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test03()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var inputk = new int[10] { 1, 2, 3, 4, 5, 0, 1, 3, 5, 7 };
            var answer = new int[][,] {
                new int[,] {
                    {13, 14, 15, 16, 17, 18, 19},
                    {5, 6, 7, 8, 9, 10, 11},
                    {9, 10, 11, 12, 13, 14, 15},
                    {1, 2, 3, 4, 5, 6, 7},
                    {0, 1, 2, 3, 4, 5, 6},
                },
                new int[,] {
                    {1},
                    {5},
                    {9},
                    {13},
                },
                new int[,] {
                    {5, 6, 7, 8, 9, 11},
                    {1, 2, 3, 4, 5, 6},
                    {0, 2, 3, 4, 5, 6},
                },
                new int[,] {
                    {1, 2, 4, 6},
                    {5, -6, 7, 11},
                    {-1, 4, -5, 6},
                    {1, 4, 5, 6},
                },
                new int[,] {
                    {-13, -14, 15, 16, 17, 18, -19},
                    {5, 6, 7, 8, -9, 10, 11},
                    {9, 10, -11, -12, -13, -14, -15},
                    {1, 2, 3, 4, 5, 6, 7},
                },
                new int[,] {
                    {5, 11, -17},
                    {1, 2, 3},
                    {0, -2, -3},
                },
                new int[,] {
                    {-9, -10, -11, -14, -15, 6},
                },
                new int[,] {
                    {5, 11, -17, 11, -10, 6, 5},
                    {1, 2, 3, 4, -5, -6, -7},
                    {-9, -10, -11, -14, -15, -16, 1},
                    {-9, -10, -11, -14, -15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                },
                new int[,] {
                    {5, 11, -17, 11, -10, 6, 5},
                    {1, 2, 3, 4, -5, -6, -7},
                    {-9, -10, -11, -14, -15, -16, 1},
                    {-9, -10, -11, -14, 15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                    {5, 11, -17, 11, -10, 6, -5},
                    {1, 1, -2, 3, -4, 0, 0},
                    {0, -2, -3, -4, -5, 0, 5},
                },
                new int[,] {
                    {1, 2, 3, 4, -5},
                    {5, 11, -17, 11, 7},
                    {-9, -10, -11, -14, -15},
                    {-9, -10, -11, -14, -6},
                    {0, -2, -3, -4, -5},
                }
            };
            var test = new int[answer.Length][,];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task3(input[i], inputk[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
                for (int j = 0; j < answer[i].GetLength(0); j++)
                {
                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
                    for (int k = 0; k < answer[i].GetLength(1); k++)
                    {
                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
                    }
                }
            }
        }
        [TestMethod]
        public void Test04()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new int[][,] {
                new int[,] {
                    {1, 2, 3, 4, 5, 6, 7},
                    {5, 6, 7, 8, 9, 10, 11},
                    {9, 10, 11, 12, 13, 14, 15},
                    {13, 14, 15, 16, 17, 18, 19},
                },
                new int[,] {
                    {5},
                    {9},
                    {13},
                },
                new int[,] {
                    {1, 2, 3, 4, 5, 6},
                    {5, 6, 7, 8, 9, 11},
                },
                new int[,] {
                    {1, 2, 4, 6},
                    {5, -6, 7, 11},
                    {1, 4, 5, 6},
                },
                new int[,] {
                    {1, 2, 3, 4, 5, 6, 7},
                    {5, 6, 7, 8, -9, 10, 11},
                    {9, 10, -11, -12, -13, -14, -15},
                },
                new int[,] {
                    {1, 2, 3},
                    {5, 11, -17},
                },
                new int[,] {
                },
                new int[,] {
                    {1, 2, 3, 4, -5, -6, -7},
                    {5, 11, -17, 11, -10, 6, 5},
                    {-9, -10, -11, -14, -15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                },
                new int[,] {
                    {1, 2, 3, 4, -5, -6, -7},
                    {5, 11, -17, 11, -10, 6, 5},
                    {-9, -10, -11, -14, 15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                    {5, 11, -17, 11, -10, 6, -5},
                    {1, 1, -2, 3, -4, 0, 0},
                    {0, -2, -3, -4, -5, 0, 5},
                },
                new int[,] {
                    {1, 2, 3, 4, -5},
                    {5, 11, -17, 11, 7},
                    {-9, -10, -11, -14, -6},
                    {0, -2, -3, -4, -5},
                },
            };
            var test = new int[answer.Length][,];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task4(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].GetLength(0), test[i].GetLength(0));
                for (int j = 0; j < answer[i].GetLength(0); j++)
                {
                    Assert.AreEqual(answer[i].GetLength(1), test[i].GetLength(1));
                    for (int k = 0; k < answer[i].GetLength(1); k++)
                    {
                        Assert.AreEqual(answer[i][j, k], test[i][j, k]);
                    }
                }
            }
        }
        [TestMethod]
        public void Test05()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new int[10] { 0, 0, 0, -4, 0, 9, 0, 0, 0, -18 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test06()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new int[][,] {
                new int[,] {
                    {1, 2, 3, 4, 5, 6, 7},
                    {5, 6, 7, 8, 9, 10, 11},
                    {9, 10, 11, 12, 13, 14, 15},
                    {13, 14, 15, 16, 17, 18, 19},
                    {0, 1, 2, 3, 4, 5, 6},
                },
                new int[,] {
                    {1},
                    {5},
                    {9},
                    {13},
                },
                new int[,] {
                    {1, 2, 3, 4, 5, 6},
                    {5, 6, 7, 8, 9, 11},
                    {0, 2, 3, 4, 5, 6},
                },
                new int[,] {
                    {1, 2, 4, 6},
                    {-6, 5, 7, 11},
                    {-1, 4, -5, 6},
                    {1, 4, 5, 6},
                },
                new int[,] {
                    {1, 2, 3, 4, 5, 6, 7},
                    {5, 6, 7, -9, 8, 10, 11},
                    {9, -15, -11, -12, -13, -14, 10},
                    {-13, -14, 15, 16, 17, 18, -19},
                },
                new int[,] {
                    {1, 2, 3},
                    {5, -17, 11},
                    {-3, -2, 0},
                },
                new int[,] {
                    {-9, -10, -11, -14, -15, 6},
                },
                new int[,] {
                    {1, 2, 3, -7, -5, -6, 4},
                    {5, -10, -17, 11, 11, 6, 5},
                    {-9, -10, -11, -14, -15, -16, 1},
                    {-9, -10, -11, -14, -15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                },
                new int[,] {
                    {1, 2, 3, -7, -5, -6, 4},
                    {5, -10, -17, 11, 11, 6, 5},
                    {-9, -10, -11, -14, -15, -16, 1},
                    {-9, -10, -11, -14, 15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                    {5, -5, -17, 11, -10, 6, 11},
                    {-4, 1, -2, 3, 1, 0, 0},
                    {-5, -2, -3, -4, 0, 0, 5},
                },
                new int[,] {
                    {1, 2, 3, -5, 4},
                    {5, -17, 11, 11, 7},
                    {-9, -10, -11, -14, -15},
                    {-9, -10, -11, -14, -6},
                    {-5, -2, -3, -4, 0},
                }
            };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task6(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
                for (int j = 0; j < answer[i].GetLength(0); j++)
                {
                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
                    for (int k = 0; k < answer[i].GetLength(1); k++)
                    {
                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
                    }
                }
            }
        }
        [TestMethod]
        public void Test07()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new int[][] {
                null,
                null,
                null,
                new int[] { -6, -1, -5 },
                new int[] { -9, -11, -12, -13, -14, -15, -13, -14, -19 },
                new int[] { -17, -2, -3 },
                new int[] { -9, -10, -11, -14, -15 },
                new int[] { -5, -6, -7, -17, -10, -9, -10, -11, -14, -15, -16, -9, -10, -11, -14, -15, -6, -2, -9, -10, -11, -14, -15 },
                new int[] { -5, -6, -7, -17, -10, -9, -10, -11, -14, -15, -16, -9, -10, -11, -14, -6, -2, -9, -10, -11, -14, -15, -17, -10, -5, -2, -4, -2, -3, -4, -5 },
                new int[] { -5, -17, -9, -10, -11, -14, -15, -9, -10, -11, -14, -6, -2, -3, -4, -5 }
                };
            var test = new int[answer.Length][];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task7(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == null)
                {
                    Assert.IsNull(test[i]);
                    continue;
                }
                Assert.AreEqual(answer[i].Length, test[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], test[i][j]);
                }
            }
        }
        [TestMethod]
        public void Test08()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new int[][,] {
                new int[,] {
                    {1, 2, 3, 4, 5, 12, 7},
                    {5, 6, 7, 8, 9, 20, 11},
                    {9, 10, 11, 12, 13, 28, 15},
                    {13, 14, 15, 16, 17, 36, 19},
                    {0, 1, 2, 3, 4, 10, 6},
                },
                new int[,] {
                    {1},
                    {5},
                    {9},
                    {13},
                },
                new int[,] {
                    {1, 2, 3, 4, 10, 6},
                    {5, 6, 7, 8, 18, 11},
                    {0, 2, 3, 4, 10, 6},
                },
                new int[,] {
                    {1, 2, 8, 6},
                    {5, -6, 14, 11},
                    {-1, 4, -10, 6},
                    {1, 4, 10, 6},
                },
                new int[,] {
                    {1, 2, 3, 4, 5, 12, 7},
                    {5, 6, 7, 8, -9, 20, 11},
                    {9, 10, -22, -12, -13, -14, -15},
                    {-13, -14, 15, 16, 17, 18, -38},
                },
                new int[,] {
                    {1, 4, 3},
                    {5, 11, -34},
                    {0, -4, -3},
                },
                new int[,] {
                    {-9, -10, -11, -14, -30, 6},
                },
                new int[,] {
                    {1, 2, 3, 4, -10, -6, -7},
                    {5, 11, -34, 11, -10, 6, 5},
                    {-9, -10, -11, -14, -15, -32, 1},
                    {-9, -10, -11, -14, -15, -12, -2},
                    {-9, -10, -11, -14, -30, 6, 4},
                },
                new int[,] {
                    {1, 2, 3, 4, -10, -6, -7},
                    {5, 11, -34, 11, -10, 6, 5},
                    {-9, -10, -11, -14, -15, -32, 1},
                    {-9, -10, -11, -28, 15, -6, -2},
                    {-9, -10, -11, -14, -30, 6, 4},
                    {5, 11, -34, 11, -10, 6, -5},
                    {1, 1, -2, 3, -8, 0, 0},
                    {0, -2, -3, -4, -5, 0, 5},
                }
                };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task8(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
                for (int j = 0; j < answer[i].GetLength(0); j++)
                {
                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
                    for (int k = 0; k < answer[i].GetLength(1); k++)
                    {
                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
                    }
                }
            }
        }
        [TestMethod]
        public void Test09()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new int[][,] {
                new int[,] {
                    {7, 6, 5, 4, 3, 2, 1},
                    {11, 10, 9, 8, 7, 6, 5},
                    {15, 14, 13, 12, 11, 10, 9},
                    {19, 18, 17, 16, 15, 14, 13},
                    {6, 5, 4, 3, 2, 1, 0},
                },
                new int[,] {
                    {1},
                    {5},
                    {9},
                    {13},
                },
                new int[,] {
                    {6, 5, 4, 3, 2, 1},
                    {11, 9, 8, 7, 6, 5},
                    {6, 5, 4, 3, 2, 0},
                },
                new int[,] {
                    {6, 4, 2, 1},
                    {11, 7, -6, 5},
                    {6, -5, 4, -1},
                    {6, 5, 4, 1},
                },
                new int[,] {
                    {7, 6, 5, 4, 3, 2, 1},
                    {11, 10, -9, 8, 7, 6, 5},
                    {-15, -14, -13, -12, -11, 10, 9},
                    {-19, 18, 17, 16, 15, -14, -13},
                },
                new int[,] {
                    {3, 2, 1},
                    {-17, 11, 5},
                    {-3, -2, 0},
                },
                new int[,] {
                    {6, -15, -14, -11, -10, -9},
                },
                new int[,] {
                    {-7, -6, -5, 4, 3, 2, 1},
                    {5, 6, -10, 11, -17, 11, 5},
                    {1, -16, -15, -14, -11, -10, -9},
                    {-2, -6, -15, -14, -11, -10, -9},
                    {4, 6, -15, -14, -11, -10, -9},
                },
                new int[,] {
                    {-7, -6, -5, 4, 3, 2, 1},
                    {5, 6, -10, 11, -17, 11, 5},
                    {1, -16, -15, -14, -11, -10, -9},
                    {-2, -6, 15, -14, -11, -10, -9},
                    {4, 6, -15, -14, -11, -10, -9},
                    {-5, 6, -10, 11, -17, 11, 5},
                    {0, 0, -4, 3, -2, 1, 1},
                    {5, 0, -5, -4, -3, -2, 0},
                },
                new int[,] {
                    {-5, 4, 3, 2, 1},
                    {7, 11, -17, 11, 5},
                    {-15, -14, -11, -10, -9},
                    {-6, -14, -11, -10, -9},
                    {-5, -4, -3, -2, 0},
                }
                };
            var test = new int[answer.Length][,];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task9(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
                for (int j = 0; j < answer[i].GetLength(0); j++)
                {
                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
                    for (int k = 0; k < answer[i].GetLength(1); k++)
                    {
                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
                    }
                }
            }
        }
        [TestMethod]
        public void Test10()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new int[][,] {
                new int[,] {
                    {1, 2, 3, 4, 5, 6, 7},
                    {5, 6, 7, 8, 9, 10, 11},
                    {9, 10, 11, 12, 13, 14, 15},
                    {13, 14, 15, 16, 17, 18, 19},
                    {0, 1, 2, 3, 4, 5, 6},
                },
                new int[,] {
                    {1},
                    {5},
                    {9},
                    {13},
                },
                new int[,] {
                    {1, 2, 3, 4, 5, 6},
                    {5, 6, 7, 8, 9, 11},
                    {0, 2, 3, 4, 5, 6},
                },
                new int[,] {
                    {1, 2, 4, 6},
                    {5, -6, 7, 11},
                    {1, 1, 1, 6},
                    {1, 1, 1, 1},
                },
                new int[,] {
                    {1, 2, 3, 4, 5, 6, 7},
                    {5, 6, 7, 8, -9, 10, 11},
                    {9, 10, -11, -12, -13, -14, -15},
                    {-13, -14, 15, 16, 17, 18, -19},
                },
                new int[,] {
                    {1, 2, 3},
                    {1, 1, -17},
                    {1, 1, 1},
                },
                new int[,] {
                    {-9, -10, -11, -14, -15, 6},
                },
                new int[,] {
                    {1, 2, 3, 4, -5, -6, -7},
                    {5, 11, -17, 11, -10, 6, 5},
                    {-9, -10, -11, -14, -15, -16, 1},
                    {-9, -10, -11, -14, -15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                },
                new int[,] {
                    {1, 2, 3, 4, -5, -6, -7},
                    {5, 11, -17, 11, -10, 6, 5},
                    {-9, -10, -11, -14, -15, -16, 1},
                    {-9, -10, -11, -14, 15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                    {5, 11, -17, 11, -10, 6, -5},
                    {1, 1, -2, 3, -4, 0, 0},
                    {0, -2, -3, -4, -5, 0, 5},
                },
                new int[,] {
                    {1, 2, 3, 4, -5},
                    {5, 11, -17, 11, 7},
                    {1, 1, 1, -14, -15},
                    {1, 1, 1, 1, -6},
                    {1, 1, 1, 1, 1},
                }
                };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task10(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].GetLength(0), input[i].GetLength(0));
                for (int j = 0; j < answer[i].GetLength(0); j++)
                {
                    Assert.AreEqual(answer[i].GetLength(1), input[i].GetLength(1));
                    for (int k = 0; k < answer[i].GetLength(1); k++)
                    {
                        Assert.AreEqual(answer[i][j, k], input[i][j, k]);
                    }
                }
            }
        }
        [TestMethod]
        public void Test11()
        {
            // Arrange
            var input = _data.GetMatrixes();
            var answer = new int[][,] {
                new int[,] {
                    {1, 2, 3, 4, 5, 6, 7},
                    {5, 6, 7, 8, 9, 10, 11},
                    {9, 10, 11, 12, 13, 14, 15},
                    {13, 14, 15, 16, 17, 18, 19},
                },
                new int[,] {
                    {1},
                    {5},
                    {9},
                    {13},
                },
                new int[,] {
                    {1, 2, 3, 4, 5, 6},
                    {5, 6, 7, 8, 9, 11},
                },
                new int[,] {
                    {1, 2, 4, 6},
                    {5, -6, 7, 11},
                    {-1, 4, -5, 6},
                    {1, 4, 5, 6},
                },
                new int[,] {
                    {1, 2, 3, 4, 5, 6, 7},
                    {5, 6, 7, 8, -9, 10, 11},
                    {9, 10, -11, -12, -13, -14, -15},
                    {-13, -14, 15, 16, 17, 18, -19},
                },
                new int[,] {
                    {1, 2, 3},
                    {5, 11, -17},
                },
                new int[,] {
                    {-9, -10, -11, -14, -15, 6},
                },
                new int[,] {
                    {1, 2, 3, 4, -5, -6, -7},
                    {5, 11, -17, 11, -10, 6, 5},
                    {-9, -10, -11, -14, -15, -16, 1},
                    {-9, -10, -11, -14, -15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                },
                new int[,] {
                    {1, 2, 3, 4, -5, -6, -7},
                    {5, 11, -17, 11, -10, 6, 5},
                    {-9, -10, -11, -14, -15, -16, 1},
                    {-9, -10, -11, -14, 15, -6, -2},
                    {-9, -10, -11, -14, -15, 6, 4},
                    {5, 11, -17, 11, -10, 6, -5},
                },
                new int[,] {
                    {1, 2, 3, 4, -5},
                    {5, 11, -17, 11, 7},
                    {-9, -10, -11, -14, -15},
                    {-9, -10, -11, -14, -6},
                }
            };
            var test = new int[answer.Length][,];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task11(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].GetLength(0), test[i].GetLength(0));
                for (int j = 0; j < answer[i].GetLength(0); j++)
                {
                    Assert.AreEqual(answer[i].GetLength(1), test[i].GetLength(1));
                    for (int k = 0; k < answer[i].GetLength(1); k++)
                    {
                        Assert.AreEqual(answer[i][j, k], test[i][j, k]);
                    }
                }
            }
        }
        [TestMethod]
        public void Test12()
        {
            // Arrange
            var input = _data.GetArrayArrays();
            var answer = new int[][][] {
                new int[][] {
                new int[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 },
                new int[] { -2, -1, -3, -4 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 1, 1 },
                new int[] { 5 },
                new int[] { 2, 1, 3, 4 },
                new int[] { 0, 2, 4, 6, 8 },
                new int[] { 2, 1, 3, 3, 5, 6, 3, 4 },
                new int[] { 5, 2, -8, 1, 9, 3, 7, 4, 6 },
                new int[] { 12, 1, 3, 3, 5, 6, 3, 4 },
                new int[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 0 },
                new int[] { 5, 2, 8, 1, 9, 0, 7, 4, 6, 10 },
                },
                new int[][] {
                new int[] { -5, 2, -8, 1, -9 },
                new int[] { -2, -1, -3, -4, -5 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 5, 2, -8, 1, 9 },
                new int[] { 2, 1, 3, 3, 5 },
                new int[] { 2, 1, 3, 4, 5 },
                new int[] { 0, 2, 4, 6, 8 },
                new int[] { 12, 1, 3, 0, 5 },
                new int[] { 5, 2, 8, 1, 9 },
                new int[] { 5, 2, 8, 1, 9 },
                },
                new int[][] {
                new int[] { -2, 1, 3, 3, 0, 5, -6, 3, 4 },
                },
                new int[][] {
                new int[] { -2 },
                new int[] { 0 },
                new int[] { 2 },
                new int[] { 5 },
                },
                new int[][] {
                new int[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 },
                new int[] { 2, 1, 3, 3, 5, 6, 3, 4 },
                new int[] { 5, 2, -8, 1, 9, 3, 7, 4, 6 },
                new int[] { 12, 1, 3, 3, 5, 6, 3, 4 },
                new int[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 0 },
                new int[] { 5, 2, 8, 1, 9, 0, 7, 4, 6, 10 },
                }
            };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task12(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].Length, input[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j].Length, input[i][j].Length);
                    for (int k = 0; k < answer[i][j].Length; k++)
                    {
                        Assert.AreEqual(answer[i][j][k], input[i][j][k]);
                    }
                }
            }
        }
    }
}
