package homeworks.BasicSintax;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by Saki on 24.1.2018 ã..
 */
public class DebitCardNumber {
    public static void main(String[] args) throws IOException {

        BufferedReader console = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < 4; i++) {
            int num = Integer.parseInt(console.readLine());
            //result.append(String.format("%04d", num)).append(" ");
        }

        System.out.println(result);
    }
}
