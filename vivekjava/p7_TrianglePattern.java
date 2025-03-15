import java.util.Scanner;

public class TrianglePattern {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Get number of rows from user
        System.out.print("Enter the number of rows for the triangle: ");
        int rows = scanner.nextInt();
        scanner.close();

        // Loop to print the triangle
        for (int i = 1; i <= rows; i++) {  // Controls the number of rows
            for (int j = 1; j <= i; j++) {  // Controls the number of stars per row
                System.out.print("* ");
            }
            System.out.println(); // Move to the next line
        }
    }
}
