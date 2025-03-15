import java.util.Scanner;

public class GradeCalculator {
    public static void main(String[] args) {
        // Create a Scanner object to get input from the user
        Scanner scanner = new Scanner(System.in);

        // Ask the user to enter their percentage
        System.out.print("Enter your percentage: ");
        double percentage = scanner.nextDouble();

        // Determine the grade based on the percentage using nested if
        String grade;

        if (percentage >= 90) {
            grade = "A+";
        } else if (percentage >= 80) {
            grade = "A";
        } else if (percentage >= 70) {
            grade = "B+";
        } else if (percentage >= 60) {
            grade = "B";
        } else if (percentage >= 50) {
            grade = "C+";
        } else if (percentage >= 40) {
            grade = "C";
        } else {
            grade = "F";
        }

        // Output the grade
        System.out.println("Your grade is: " + grade);

        // Close the scanner object to prevent memory leaks
        scanner.close();
    }
}