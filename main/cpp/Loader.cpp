#include <iostream>

int main() {
    // Declare a 10x10 grid of integers
    int grid[10][10];

    // Initialize the grid with values
    for (int row = 0; row < 10; row++) {
        for (int col = 0; col < 10; col++) {
            grid[row][col] = row * 10 + col;
        }
    }

    // Print the grid
    for (int row = 0; row < 10; row++) {
        for (int col = 0; col < 10; col++) {
            std::cout << std::setw(3) << grid[row][col] << " ";
        }
        std::cout << std::endl;
    }

    return 0;
}
