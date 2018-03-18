import java.util.Scanner;


/**
 * Created by Saki on 24.1.2018 ã..
 */
public class DebitCardNumber {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);//here we initiate the console
        StringBuilder debitCardNumber = new StringBuilder();//in this line we make stringbuilder to hold the creditcard numbers
        for (int i = 0; i < 4; i++) {                      //by this loop we read each number
            int cardNumber = Integer.parseInt(scanner.nextLine()); //we receive 4 integers on the console 
            debitCardNumber.append(String.format("%04d", cardNumber )).append(" ");//we format the result in 4-digit debit card format
        }

        System.out.println(debitCardNumber); //printing the result 
    }
}
