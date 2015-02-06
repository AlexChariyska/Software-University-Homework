package Shop;

public final class PurchaseManager {
	private PurchaseManager() {
	}
	
	public static void processPurchase(Product product, Customer customer) throws Exception{
		if (product instanceof FoodProduct) {
			if (((FoodProduct) product).isExpiring()) {
				throw new Exception("The product is with expired date!");
			}
		}

		if (product.getQuantity() < 1) {
			throw new Exception("There is no more quantity of this product!");
		}

		if (customer.getBalance() < product.getPrice()) {
			throw new Exception(
					"The customer's balance is with insufficient amount!");
		}

		if (product.ageRestriction == AgeRestriction.ADULT
				&& customer.getAge() < 18) {
			throw new Exception("The customer's age must be over 18!");
		}

		customer.setBalance(customer.getBalance() - product.getPrice());
		product.setQuantity(product.getQuantity() - 1);
	}

}
