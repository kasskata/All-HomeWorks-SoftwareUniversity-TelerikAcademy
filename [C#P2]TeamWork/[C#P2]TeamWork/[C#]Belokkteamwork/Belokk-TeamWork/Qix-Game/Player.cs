using Qix_Game;
using System;
using System.Collections.Generic;

public class Player
{
    public int CurrentPositionX { get; set; }
    public int LastPositionX { get; set; }
    public int CurrentPositionY { get; set; }
    public int LastPositionY { get; set; }
    private ConsoleColor PlayerColor { get; set; }
    private char PlayerChar { get; set; }

    public CellStatus currentPosition = CellStatus.Head;

    public CellStatus lastPosition = CellStatus.Filled;

    public MovementStatus movement = MovementStatus.Stopped;

    public Player(int x, int y, ConsoleColor color = ConsoleColor.DarkYellow, char character = (char)2)
    {
        CurrentPositionX = x;
        CurrentPositionY = y;
        LastPositionX = x;
        LastPositionY = y;
        PlayerColor = color;
        PlayerChar = character;
        lastPosition = CellStatus.Filled;
    }

    public void MoveOnDirection(GameField field)
    {
        if (movement == MovementStatus.Left)
        {
            if (this.currentPosition == CellStatus.Empty)
            {
                this.Move(new ConsoleKeyInfo('\u2190', ConsoleKey.LeftArrow, false, false, false), field);
            }
            else if (this.currentPosition == CellStatus.Trail)
            {
                Game.Kill();
            }
            else if (this.currentPosition == CellStatus.Ball)
            {
                Game.Kill();
            }
            else if (this.currentPosition == CellStatus.Filled)
            {
                //Fill the occupied field
            }
        }
        else if (movement == MovementStatus.Right)
        {
            if (this.currentPosition == CellStatus.Empty)
            {
                this.Move(new ConsoleKeyInfo('\u2192', ConsoleKey.RightArrow, false, false, false), field);
            }
            else if (this.currentPosition == CellStatus.Trail)
            {
                Game.Kill();
            }
            else if (this.currentPosition == CellStatus.Ball)
            {
                Game.Kill();
            }
            else if (this.currentPosition == CellStatus.Filled)
            {
                //Fill the occupied field
            }
        }
        else if (movement == MovementStatus.Up)
        {
            if (this.currentPosition == CellStatus.Empty)
            {
                this.Move(new ConsoleKeyInfo('\u2191', ConsoleKey.UpArrow, false, false, false), field);
            }
            else if (this.currentPosition == CellStatus.Trail)
            {
                Game.Kill();
            }
            else if (this.currentPosition == CellStatus.Ball)
            {
                Game.Kill();
            }
            else if (this.currentPosition == CellStatus.Filled)
            {
                //Fill the occupied field
            }
        }
        else if (movement == MovementStatus.Down)
        {
            if (this.currentPosition == CellStatus.Empty)
            {
                this.Move(new ConsoleKeyInfo('\u2193', ConsoleKey.DownArrow, false, false, false), field);
            }
            else if (this.currentPosition == CellStatus.Trail)
            {
                Game.Kill();
            }
            else if (this.currentPosition == CellStatus.Ball)
            {
                Game.Kill();
            }
            else if (this.currentPosition == CellStatus.Filled)
            {
                //Fill the occupied field
            }
        }
    }

    public void Move(ConsoleKeyInfo pressedKey, GameField field)
    {
        if (pressedKey.Key == ConsoleKey.LeftArrow)
        {
            if (CurrentPositionX > 0)
            {
                if (currentPosition == CellStatus.Empty)
                {
                    this.lastPosition = CellStatus.Trail;
                }
                else if (currentPosition == CellStatus.Filled)
                {
                    this.lastPosition = CellStatus.Filled;
                }
                else if (currentPosition == CellStatus.Trail)
                {
                    this.lastPosition = currentPosition;
                }

                this.LastPositionX = this.CurrentPositionX;
                this.LastPositionY = this.CurrentPositionY;


                this.CurrentPositionX--;

                this.currentPosition = field.gameField[this.CurrentPositionY, this.CurrentPositionX];

                if (this.currentPosition == CellStatus.Empty && this.movement != MovementStatus.Left)
                {
                    this.movement = MovementStatus.Left;
                }
            }
        }
        else if (pressedKey.Key == ConsoleKey.RightArrow)
        {
            if (CurrentPositionX < field.width - 1)
            {
                if (currentPosition == CellStatus.Empty)
                {
                    this.lastPosition = CellStatus.Trail;
                }
                else if (currentPosition == CellStatus.Filled)
                {
                    this.lastPosition = CellStatus.Filled;
                }
                else if (currentPosition == CellStatus.Trail)
                {
                    this.lastPosition = currentPosition;
                }

                this.LastPositionX = this.CurrentPositionX;
                this.LastPositionY = this.CurrentPositionY;

                this.CurrentPositionX++;

                this.currentPosition = field.gameField[this.CurrentPositionY, this.CurrentPositionX];

                if (this.currentPosition == CellStatus.Empty && this.movement != MovementStatus.Right)
                {
                    this.movement = MovementStatus.Right;
                }
            }
        }
        else if (pressedKey.Key == ConsoleKey.UpArrow)
        {
            if (CurrentPositionY > 0)
            {
                if (currentPosition == CellStatus.Empty)
                {
                    this.lastPosition = CellStatus.Trail;
                }
                else if (currentPosition == CellStatus.Filled)
                {
                    this.lastPosition = CellStatus.Filled;
                }
                else if (currentPosition == CellStatus.Trail)
                {
                    this.lastPosition = currentPosition;
                }

                this.LastPositionX = this.CurrentPositionX;
                this.LastPositionY = this.CurrentPositionY;

                this.CurrentPositionY--;

                this.currentPosition = field.gameField[this.CurrentPositionY, this.CurrentPositionX];

                if (this.currentPosition == CellStatus.Empty && this.movement != MovementStatus.Up)
                {
                    this.movement = MovementStatus.Up;
                }
            }
        }
        else if (pressedKey.Key == ConsoleKey.DownArrow)
        {
            if (CurrentPositionY < field.height - 1)
            {
                if (currentPosition == CellStatus.Empty)
                {
                    this.lastPosition = CellStatus.Trail;
                }
                else if (currentPosition == CellStatus.Filled)
                {
                    this.lastPosition = CellStatus.Filled;
                }
                else if (currentPosition == CellStatus.Trail)
                {
                    this.lastPosition = currentPosition;
                }

                this.LastPositionX = this.CurrentPositionX;
                this.LastPositionY = this.CurrentPositionY;

                this.CurrentPositionY++;

                this.currentPosition = field.gameField[this.CurrentPositionY, this.CurrentPositionX];

                if (this.currentPosition == CellStatus.Empty && this.movement != MovementStatus.Down)
                {
                    this.movement = MovementStatus.Down;
                }
            }
        }

        if (this.lastPosition == CellStatus.Trail && field.gameField[this.CurrentPositionY, this.CurrentPositionX] == CellStatus.Filled)
        {
            field.isForFilling = true;
        }
            
        field.gameField[this.LastPositionY, this.LastPositionX] = this.lastPosition;
        field.gameField[this.CurrentPositionY, this.CurrentPositionX] = CellStatus.Head;
    }
}