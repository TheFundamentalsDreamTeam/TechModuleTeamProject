package homeworks.BasicSintax;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by Saki on 24.1.2018 �..
 */
public class DebitCardNumber {
    public static void main(String[] args) throws IOException {

        BufferedReader console = new BufferedReader(new InputStreamReader(System.in));//here we initiate the console
        StringBuilder result = new StringBuilder();//in this line we make stringbuilder to hold the creditcard numbers
        for (int i = 0; i < 4; i++) {                      //by this loop we read each number
            int num = Integer.parseInt(console.readLine()); //we receive 4 integers on the console 
            result.append(String.format("%04d", num)).append(" ");//we format the result in 4-digit debit card format
        }

        System.out.println(result); //printing the result 
    }
}
