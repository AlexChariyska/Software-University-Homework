package Shop;

import Shop.Interfaces.Buyable;

public abstract class Product implements Buyable {

	protected String name;
	protected double price;
	protected double quantity;
	protected AgeRestriction ageRestriction;

	public Product(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		this.setName(name);
		this.setPrice(price);
		this.setQuantity(quantity);
		this.ageRestriction = ageRestriction;
	}

	@Override
	public double getPrice() {
		return this.price;
	}
	
	@Override
	public String toString() {
		return "Name: " + this.name +
				"\nPrice: " + this.price +
				"\nQuantity: " + this.quantity +
				"\nAge Restriction Level: " + this.ageRestriction + "\n";
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		if (name.isEmpty() || name == null) {
			throw new IllegalArgumentException(
					"Product name cannot be empty or null");
		}

		this.name = name;
	}

	public void setPrice(double price) {
		if (quantity < 0) {
			throw new IllegalArgumentException("Quantity cannot be negative");
		}

		this.price = price;
	}

	public double getQuantity() {
		return quantity;
	}

	public void setQuantity(double quantity) {
		this.quantity = quantity;
	}

	public AgeRestriction getAgeRestriction() {
		return ageRestriction;
	}

	public void setAgeRestriction(AgeRestriction ageRestriction) {
		this.ageRestriction = ageRestriction;
	}
	
	

}
