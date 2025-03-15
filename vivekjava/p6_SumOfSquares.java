public class SumOfSquares {
    public static void main(String[] args) {
        int sum = 0;  // Variable to store the sum

        // Loop from 1 to 10
        for (int i = 1; i <= 10; i++) {
            sum += i * i;  // Add the square of the current number
        }

        // Print the sum of squares
        System.out.println("Sum of squares from 1 to 10 is: " + sum);
    }
}