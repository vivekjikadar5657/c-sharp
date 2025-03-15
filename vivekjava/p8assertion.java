import java.util.Scanner;

public class SquareAreaAssertion {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Get the side of the square
        System.out.print("Enter the side length of the square: ");
        double side = scanner.nextDouble();

        // Get the value of n
        System.out.print("Enter the value of n (must be 3.14): ");
        double n = scanner.nextDouble();
        scanner.close();

        // Assertion to check if n is 3.14
        assert n == 3.14 : "Assertion failed: n must be 3.14";

        // Calculate the area of the square
        double area = side * side;
        System.out.println("Area of the square: " + area);
    }
}