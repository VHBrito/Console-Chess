﻿using Chess.Board;

namespace Chess.ChessGame;

public class Queen : Piece
{
    public Queen(Colors color, ChessBoard board) : base(color, board)
    {
    }

    public override string ToString()
    {
        return " Q ";
    }
}