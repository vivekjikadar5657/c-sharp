import java.util.Scanner;

public class NumberOperations {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Taking decimal input
        System.out.print("Enter first decimal number: ");
        int decimal1 = scanner.nextInt();
        System.out.print("Enter second decimal number: ");
        int decimal2 = scanner.nextInt();

        // Taking binary input
        System.out.print("Enter first binary number: ");
        String binary1 = scanner.next();
        System.out.print("Enter second binary number: ");
        String binary2 = scanner.next();

        // Taking octal input
        System.out.print("Enter first octal number: ");
        String octal1 = scanner.next();
        System.out.print("Enter second octal number: ");
        String octal2 = scanner.next();

        // Taking hexadecimal input
        System.out.print("Enter first hexadecimal number: ");
        String hex1 = scanner.next();
        System.out.print("Enter second hexadecimal number: ");
        String hex2 = scanner.next();

        scanner.close();

        // Convert binary, octal, and hexadecimal to decimal
        int bin1 = Integer.parseInt(binary1, 2);
        int bin2 = Integer.parseInt(binary2, 2);
        int oct1 = Integer.parseInt(octal1, 8);
        int oct2 = Integer.parseInt(octal2, 8);
        int hexDec1 = Integer.parseInt(hex1, 16);
        int hexDec2 = Integer.parseInt(hex2, 16);

        // Perform operations
        performOperations("Decimal", decimal1, decimal2);
        performOperations("Binary", bin1, bin2);
        performOperations("Octal", oct1, oct2);
        performOperations("Hexadecimal", hexDec1, hexDec2);
    }

    public static void performOperations(String type, int num1, int num2) {
        System.out.println("\n" + type + " Operations:");
        System.out.println("Sum: " + num1 + " + " + num2 + " = " + (num1 + num2));
        System.out.println("Subtraction: " + num1 + " - " + num2 + " = " + (num1 - num2));
        System.out.println("Multiplication: " + num1 + " * " + num2 + " = " + (num1 * num2));

        if (num2 != 0) {
            System.out.println("Division: " + num1 + " / " + num2 + " = " + (num1 / num2));
        } else {
            System.out.println("Division by zero is not allowed.");
        }
    }
}