package Shop;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.function.Predicate;
import java.util.stream.Collectors;

import javax.print.PrintException;

public class TestingShop {

	public static void main(String[] args) throws Exception {
		FoodProduct vodka = new FoodProduct("Flirt", 15.90, 2, AgeRestriction.ADULT, "2014-10-20");
		Customer ivan = new Customer("Ivan Ivanov", 18, 50.00);
		
		System.out.println(ivan.getBalance());
		System.out.println(vodka.getQuantity());
		
		try {
			PurchaseManager.processPurchase(vodka, ivan);
		} catch (PrintException e) {
			System.err.println(e.getMessage());
		}
		
		System.out.println(ivan.getBalance());
		System.out.println(vodka.getQuantity());
		
		Customer anna = new Customer("Anna", 25, 200);
		
		try {
			PurchaseManager.processPurchase(vodka, anna);
		} catch (PrintException e) {
			System.err.println(e.getMessage());
		}
		
		List<Product> products = new ArrayList<Product>();
		
		products.add(new FoodProduct("white Bread", 2.00, 10, AgeRestriction.NONE, "2016-05-07"));
		products.add(new FoodProduct("Vita bread", 1.10, 2, AgeRestriction.ADULT, "2014-10-20"));
		products.add(new FoodProduct("Milk", 0.79, 111, AgeRestriction.NONE, "2014-05-12"));
		products.add(new Computer("XX Five", 699.90, 2, AgeRestriction.NONE));
		products.add(new Computer("Lenovo", 1699.90, 2, AgeRestriction.ADULT));
		products.add(new Appliance("Eldom Oven", 299.90, 6, AgeRestriction.NONE));
		
/*		Comparator<Product> byDateOfExpiry = (p1, p2) -> Long.compare(
				((FoodProduct) p1).getDaysUntilExpir(), ((FoodProduct) p2).getDaysUntilExpir());
		Comparator<Product> byPrice = (p1, p2) -> p1.getPrice().compareTo(p2.getPrice());
		
		Product expirableProduct = products.stream()
				.filter(p -> p instanceof Expirable)
				.sorted(byDateOfExpir)
				.findFirst()
				.get();
		
		System.out.println(expirableProduct);
		System.out.println("\n ----------------");
		
		List<Product> adultAgerestrictionByPrice = products.stream()
				.filter(p -> p.ageRestriction == AgeRestriction.ADULT)
				.sorted(byPrice)
				.collect(Collectors.toList());
		
		for (Product product : adultAgerestrictionByPrice) {
			System.out.println(product + "\n");
		}*/
	}

}
