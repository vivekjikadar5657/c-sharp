public class SumEvenNumbers {
    public static void main(String[] args) {
        int num = 1;  // Start from 1
        int sum = 0;  // Variable to store sum

        while (num <= 20) {
            if (num % 2 == 0) {  // Check if the number is even
                sum += num;  // Add even number to sum
            }
            num++;  // Increment number
        }

        // Print the sum of even numbers
        System.out.println("Sum of even numbers from 1 to 20 is: " + sum);
    }
}
