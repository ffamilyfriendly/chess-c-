using System.Xml;

public class PiecesVisuals {
    public static readonly Dictionary<Piece, ChessPair> Pieces = new Dictionary<Piece, ChessPair>() {
        { Piece.King, new ChessPair('♚', '♔') },
        { Piece.Queen, new ChessPair('♛', '♕') },
        { Piece.Rook, new ChessPair('♜', '♖') },
        { Piece.Bishop, new ChessPair('♝', '♗') },
        { Piece.Knight, new ChessPair('♞', '♘') },
        { Piece.Pawn, new ChessPair('♟', '♙') },
    };

    public struct ChessPair {
        public Char black;
        public Char white;

        public ChessPair(Char black, Char white) {
            this.black = black;
            this.white = white;
        }
    }

    public static Char GetPiece(Colour clr, Piece piece) {
        var pc = Pieces[piece];

        if(clr == Colour.Black) {
            return pc.black;
        } else {
            return pc.white;
        }
    }
}




public enum Colour {
    Black,
    White
}

public enum Piece {
    King,
    Queen,
    Rook,
    Bishop,
    Knight,
    Pawn
}