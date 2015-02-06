package Shop;

public class Customer {
	private String name;
	private int age;
	private double balance;

	public Customer(String name, int age, double balance) {
		this.setName(name);
		this.setAge(age);
		this.setBalance(balance);
	}

	public String getName() {
		return this.name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return this.age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public double getBalance() {
		return (Math.round (this.balance*100)/100.00);
	}

	public void setBalance(double balance) {
		this.balance = balance;
	}

}
