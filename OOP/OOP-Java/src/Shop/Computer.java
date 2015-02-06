package Shop;

public class Computer extends ElectonicsProduct {

	public Computer(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction, 24);
		
	}
	
	@Override
	public double getPrice() {
		if (this.quantity > 1000) {
			return this.price*(0.95);
		}
		
		return this.price;
	}

}
