import java.util.Scanner;
public class Demo {

    public static void main(String[] args) {
		
		// Creating object Scanner
        Scanner scanner = new Scanner(System.in);
		
		// receiving width data from console  - double
        double widthOfRectangle = Double.parseDouble(scanner.nextLine());
		// receiving height data from console  - double
        double heightOfRectangle = Double.parseDouble(scanner.nextLine());
			
		//calculating rectangle area
        float area =(float)(widthOfRectangle*heightOfRectangle);
		
		//printing the result with two digits precision
        System.out.printf("%.2f",area);

    }
}