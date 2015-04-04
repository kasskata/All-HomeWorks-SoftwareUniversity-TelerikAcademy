//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

//Implement an indexer this[row, col] to access the inner matrix cells.

//Implement the operators + and - (addition and subtraction of matrices of the same size)
//and * for matrix multiplication. Throw an exception when the operation cannot be performed. 

//Implement the true operator (check for non-zero elements).

//Create a [Version] attribute that can be applied to structures, classes, interfaces, 
//enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 

//Apply the version attribute to a sample class and display its version at runtime.

namespace MatrixOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using GenericMatrix;
     public class MatrixOperations
    {
        static void Main()
        {
            double[,] matrixOne = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 8, 7, 6 }, {5, 4, 3, 2 } };
            double[,] matrixTwo = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 8, 7, 6 }, { 5, 4, 3, 2 } };

            Matrix<double> batman = new Matrix<double>(matrixOne);
            Matrix<double> joker = new Matrix<double>(matrixTwo);

            Console.WriteLine("First Array : \n"+batman.ToString());
            Console.WriteLine("Second Array: \n"+joker.ToString());

            Console.WriteLine("Sum of them:\n" + batman + joker);
            Console.WriteLine("mmultiply:\n" + batman * joker);
            Console.WriteLine("Devide Them:\n" + (batman - joker));
        }
    }
}
