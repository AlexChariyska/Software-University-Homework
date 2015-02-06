package Shop;

public abstract class ElectonicsProduct extends Product {
	private int guaranteePeriod;

	public ElectonicsProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod) {
		super(name, price, quantity, ageRestriction);
		this.setGuaranteePeriod(guaranteePeriod);
	}

	@Override
	public String toString() {
		return super.toString() + "Guarantee Period date: "
				+ this.guaranteePeriod;
	}

	public int getGuaranteePeriod() {
		return guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) {
		this.guaranteePeriod = guaranteePeriod;
	}

}
