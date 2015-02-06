package Shop;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;

import Shop.Interfaces.Expirable;

public class FoodProduct  extends Product implements Expirable {
	private Date expirationDate;
	private boolean expiring;
	private long daysUntilExpir;
	
	public FoodProduct(String name, double price, int quantity,
			Shop.AgeRestriction ageRestriction, String expirationalDate) {
		super(name, price, quantity, ageRestriction);
		
		SimpleDateFormat dateFormat = (SimpleDateFormat) DateFormat.getDateInstance();
		dateFormat.applyPattern("yyyy-MM-dd");

		try {
			this.expirationDate = dateFormat.parse(expirationalDate);
		} catch (ParseException e) {
			throw new IllegalArgumentException("not a valid date");
		}
		isExpired();
	}
	
	private void isExpired() {	
		Date now = new Date();
		long diff = this.expirationDate.getTime() - now.getTime();
		
		long days = TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
		
		if (days < 1) {
			this.setExpiring(true);
		} else {
			this.setExpiring(false);
		}
		
		this.setDaysUntilExpir(days);
	}
	
	@Override
	public double getPrice() {
		if (this.daysUntilExpir < 15) {
			return this.price*(0.70);
		}
		
		return this.price;
	}
	

	@Override	
	public Date getExpirationDate() {
		return this.expirationDate;
	}
	
	@Override
	public String toString() {
		return super.toString() +
				"Expiration date: " + this.expirationDate.toString();
	}
	

	public boolean isExpiring() {
		return expiring;
	}

	public void setExpiring(boolean expiring) {
		this.expiring = expiring;
	}

	public long getDaysUntilExpir() {
		return daysUntilExpir;
	}

	public void setDaysUntilExpir(long daysUntilExpir) {
		this.daysUntilExpir = daysUntilExpir;
	}


}
