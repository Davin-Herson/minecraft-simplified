#import <Foundation/Foundation.h>
#include <stdio.h>

int main(int argc, const char * argv[]) {
    @autoreleasepool {
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
                printf("%3d ", grid[row][col]);
            }
            printf("\n");
        }
    }
    return 0;
}
