import java.util.Scanner;

enum ValidRollNumbers {
    ROLL_101, ROLL_102, ROLL_103, ROLL_104, ROLL_105;
}

public class RestrictRollNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Get roll number input from user
        System.out.print("Enter your roll number (ROLL_101 to ROLL_105): ");
        String inputRoll = scanner.next();
        scanner.close();

        try {
            // Convert user input to Enum
            ValidRollNumbers rollNumber = ValidRollNumbers.valueOf(inputRoll.toUpperCase());
            System.out.println("Valid Roll Number: " + rollNumber);
        } catch (IllegalArgumentException e) {
            System.out.println("Invalid Roll Number! Allowed values: ROLL_101 to ROLL_105");
        }
    }
}