public class MyClass {
    public int MyMethod(int a, int b) {
        //Check for division by zero
        if (b == 0) {
            return 0; // Or throw a custom exception, handle it appropriately.
        }
        return a / b; 
    }
}