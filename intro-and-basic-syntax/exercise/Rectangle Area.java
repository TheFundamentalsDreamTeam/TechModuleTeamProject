import java.util.Scanner;
public class Demo {

    public static void main(String[] args) {
		
		// Creating object Scanner
        Scanner scanner = new Scanner(System.in);
		
		// receiving width data from console  - double
        double width = Double.parseDouble(scanner.nextLine());
		// receiving height data from console  - double
        double height = Double.parseDouble(scanner.nextLine());
			
		//calculating rectangle area
        float sum =(float)(width*height);
		
		//printing the result with two digits precision
        System.out.printf("%.2f",sum);

    }
}