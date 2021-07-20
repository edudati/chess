﻿using System;
using board;

namespace chessMatch
{
    class ChessMatch
    {
        public Board b { get; private set; }
        private int shift;
        private Color currentPlayer;
        public bool finished { get; private set; }

        public ChessMatch()
        {
            b = new Board(8, 8);
            shift = 1;
            currentPlayer = Color.White;
            putPiecesOnTheBoard();
            finished = false;
        }

        public void performMov(Position origin, Position destination)
        {
            Piece p = b.removePiece(origin);
            p.addMovAmount();
            Piece capturedPiece = b.removePiece(destination);
            b.putPiece(p, destination);
        }

        private void putPiecesOnTheBoard()
        {
            b.putPiece(new Rock(b, Color.Black), new PositionOfChess('c', 8).ToPosition());
            b.putPiece(new Rock(b, Color.Black), new PositionOfChess('c', 7).ToPosition());
            b.putPiece(new King(b, Color.Black), new PositionOfChess('d', 8).ToPosition());
            b.putPiece(new Rock(b, Color.Black), new PositionOfChess('d', 7).ToPosition());
            b.putPiece(new Rock(b, Color.Black), new PositionOfChess('e', 8).ToPosition());
            b.putPiece(new Rock(b, Color.Black), new PositionOfChess('e', 7).ToPosition());

            b.putPiece(new Rock(b, Color.White), new PositionOfChess('c', 1).ToPosition());
            b.putPiece(new Rock(b, Color.White), new PositionOfChess('c', 2).ToPosition());
            b.putPiece(new King(b, Color.White), new PositionOfChess('d', 1).ToPosition());
            b.putPiece(new Rock(b, Color.White), new PositionOfChess('d', 2).ToPosition());
            b.putPiece(new Rock(b, Color.White), new PositionOfChess('e', 1).ToPosition());
            b.putPiece(new Rock(b, Color.White), new PositionOfChess('e', 2).ToPosition());
        }
    }
}