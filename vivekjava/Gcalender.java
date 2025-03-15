import java.util.Calendar;
import java.util.GregorianCalendar;
class Gcalender
{
	public static void main(String[] args)
	{
		Calendar cal = Calendar.getInstance();
		System.out.println(cal.getTime());
		
		GregorianCalendar gcal = new GregorianCalendar();
		System.out.println(gcal.getTime());
	}
}