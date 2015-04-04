using Qix_Game;
using System;
using System.Collections.Generic;

public class GameField
{
    //Properties and fields
    public int height { get; set; }
    public int width { get; set; }
    public List<List<int>> tmpList { get; set; }
    public CellStatus[,] gameField { get; set; }

    private bool[,] isChecked;
    public bool isForFilling { get; set; }
    //Constructor
    public GameField(int height, int width)
    {
        this.height = height;
        this.width = width;
        tmpList = new List<List<int>>();
        gameField = new CellStatus[height, width];

        //Not for here, must be in GameSettings
        Console.BufferHeight = Console.WindowHeight = height;
        Console.BufferWidth = Console.WindowWidth = width + 26;
        Console.CursorVisible = false;
    }

    //Initialize the field array with starting values (just the walls)
    public void Initialization()
    {
        for (int col = 0; col < width; col++)
        {
            for (int row = 0; row < height; row++)
            {
                if (IsOnTheEdge(row, col))
                {
                    gameField[row, col] = CellStatus.Filled;
                }
                else
                {
                    gameField[row, col] = CellStatus.Empty;
                }
            }
        }
    }

    //Check if the current cell is on the edge
    private bool IsOnTheEdge(int row, int col)
    {
        return (row == 0) || (row == height - 1) || (col == 0) || (col == width - 1);
    }


    public int FillTheField(List<Ball> balls)
    {
        int filledCells = 0;
        List<List<int>> trailValues = new List<List<int>>();
        for (int i = 0; i < gameField.GetLength(0); i++)
        {
            for (int j = 0; j < gameField.GetLength(1); j++)
            {
                if (gameField[i, j] == CellStatus.Trail)
                {
                    gameField[i, j] = CellStatus.Filled;
                    trailValues.Add(new List<int> { i, j });
                    filledCells++;
                }
            }
        }

        isChecked = new bool[gameField.GetLength(0), gameField.GetLength(1)];

        //Check for sequence
        for (int startRow = 0; startRow < gameField.GetLength(0); startRow++)
        {
            for (int startCol = 0; startCol < gameField.GetLength(1); startCol++)
            {
                //bool[,] checkedLst = (bool[,])isChecked.Clone();
                if (gameField[startRow, startCol] == CellStatus.Empty && !isChecked[startRow, startCol])
                {
                    tmpList = checkForSeq(gameField.GetLength(1), gameField.GetLength(0), startRow, startCol, gameField);
                    bool fill = true;
                    for (int b = 0; b < balls.Count; b++)
                    {
                        if (tmpList.Exists(x => x[0] == balls[b].ballPositionY && x[1] == balls[b].ballPositionX))
                        {
                            fill = false;
                            break;
                        }
                    }
                    if (fill)
                    {
                        tmpList.AddRange(trailValues);
                        for (int i = 0; i < tmpList.Count; i++)
                        {
                            List<int> currentItem = tmpList[i];
                            gameField[currentItem[0], currentItem[1]] = CellStatus.Filled;
                            filledCells++;
                        }
                        isForFilling = false;
                        return filledCells;
                    }
                    else
                    {
                        tmpList = trailValues;
                    }
                }
            }
        }
        isForFilling = false;
        return filledCells;
    }
    
    private List<List<int>> checkForSeq(int m, int n, int startRow, int startCol, CellStatus[,] matrix)
    {
        //CellStatus currentElement = matrix[startRow, startCol];
        List<List<int>> returnList = new List<List<int>>();
        List<int> currentPosition = new List<int> { startRow, startCol };
        isChecked[startRow, startCol] = true;
        //Temporary lists holding the other items from the recursive call
        List<List<int>> listRight = new List<List<int>>();
        List<List<int>> listLeft = new List<List<int>>();
        List<List<int>> listBelow = new List<List<int>>();
        List<List<int>> listBelowRight = new List<List<int>>();
        List<List<int>> listBelowLeft = new List<List<int>>();
        List<List<int>> listAbove = new List<List<int>>();

        //Check if the element to the right is filled
        if (startCol + 1 < m && matrix[startRow, startCol + 1] != CellStatus.Filled)
        {
            if (!isChecked[startRow, startCol + 1])
            {
                listRight = checkForSeq(m, n, startRow, startCol + 1, matrix);
            }
        }
        //Check if the same element to the left is filled
        if (startCol - 1 >= 0 && matrix[startRow, startCol - 1] != CellStatus.Filled)
        {
            if (!isChecked[startRow, startCol - 1])
            {
                listLeft = checkForSeq(m, n, startRow, startCol - 1, matrix);
            }
        }
        //Check if the element below the current is filled
        if (startRow + 1 < n && matrix[startRow + 1, startCol] != CellStatus.Filled)
        {
            if (!isChecked[startRow + 1, startCol])
            {
                listBelow = checkForSeq(m, n, startRow + 1, startCol, matrix);
            }
        }
        //Check if we have the same element below and to the right the current
        //if (startRow + 1 < n && startCol + 1 < m && currentElement.Equals(matrix[startRow + 1, startCol + 1]))
        //{
        //    if (!isChecked[startRow + 1, startCol + 1])
        //    {
        //        listBelowRight = checkForSeq(m, n, startRow + 1, startCol + 1, isChecked, matrix);
        //    }
        //}
        //Check if we have the same element below and to the left the current
        //if (startRow + 1 < n && startCol - 1 >= 0 && currentElement.Equals(matrix[startRow + 1, startCol - 1]))
        //{
        //    if (!isChecked[startRow + 1, startCol - 1])
        //    {
        //        listBelowLeft = checkForSeq(m, n, startRow + 1, startCol - 1, isChecked, matrix);
        //    }
        //}
        //Check if the element above the current is filled
        if (startRow - 1 >= 0 && matrix[startRow - 1, startCol] != CellStatus.Filled)
        {
            if (!isChecked[startRow - 1, startCol])
            {
                listAbove = checkForSeq(m, n, startRow - 1, startCol, matrix);
            }
        }

        //Add the list with the most items to the return list
        returnList.AddRange(listRight);
        returnList.AddRange(listLeft);
        returnList.AddRange(listBelow);
        returnList.AddRange(listBelowRight);
        returnList.AddRange(listBelowLeft);
        returnList.AddRange(listAbove);

        returnList.Add(currentPosition);

        return returnList;
    }
}