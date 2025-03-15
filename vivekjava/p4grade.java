import java.util.Scanner;

public class GradeCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Get percentage input from the user
        System.out.print("Enter your percentage: ");
        int percentage = scanner.nextInt();
        scanner.close();

        // Determine grade category (rounded to the nearest 10)
        int gradeCategory = percentage / 10;

        // Using switch-case to determine the grade
        String grade;
        switch (gradeCategory) {
            case 10:
            case 9:
                grade = "A+ (Excellent)";
                break;
            case 8:
                grade = "A (Very Good)";
                break;
            case 7:
                grade = "B (Good)";
                break;
            case 6:
                grade = "C (Satisfactory)";
                break;
            case 5:
                grade = "D (Pass)";
                break;
            default:
                grade = (percentage >= 0) ? "F (Fail)" : "Invalid percentage";
                break;
        }
