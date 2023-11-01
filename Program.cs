// Type alias for the 2D List
using Board = System.Collections.Generic.List<System.Collections.Generic.List<char>>;

const char  INITIAL_VALUE = 'X';

Board board = [
    [INITIAL_VALUE, INITIAL_VALUE, INITIAL_VALUE],
    [INITIAL_VALUE, INITIAL_VALUE, INITIAL_VALUE],
    [INITIAL_VALUE, INITIAL_VALUE, INITIAL_VALUE],
];

DisplayBoard(board);


// Displays the board
void DisplayBoard(Board board) {
    foreach (var row in board) {
        foreach (var col in row) {
            Console.Write(col);
        }
        Console.WriteLine();
    }
}