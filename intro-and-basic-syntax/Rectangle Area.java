import java.util.Scanner;
public class Demo {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double width = Double.parseDouble(scanner.nextLine());
        double height = Double.parseDouble(scanner.nextLine());

        float sum =(float)(width*height);

        System.out.printf("%.2f",sum);

    }
}