package Shop;

public class Appliance extends ElectonicsProduct {

	public Appliance(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction, 6);
	}

	@Override
	public double getPrice() {
		if (this.quantity < 50) {
			return this.price * (1.05);
		}

		return this.price;
	}
}
