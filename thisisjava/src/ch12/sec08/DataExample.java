package ch12.sec08;

import java.text.SimpleDateFormat;
import java.util.Date;

public class DataExample {
	public static void main(String[] args) {
		Date now = new Date();
		String strNow1 = now.toString();
		System.out.println(strNow1);
		
		SimpleDateFormat sdf = new SimpleDateFormat("yyyy.mm.dd HH:mm:ss");
		String strNow2 = sdf.format(now);
		System.out.println(strNow2);
		
	}

}
