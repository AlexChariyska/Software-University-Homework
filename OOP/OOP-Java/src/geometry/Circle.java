package geometry;

public class Circle extends PlaneShape {
	private double radius;
	
	public Circle(double x, double y, double radius) {
		super(x, y);
		this.setRadius(radius);
	}
	
	@Override
	public double areaMeasurable() {
		return Math.PI * (this.radius * this.radius);
	}

	@Override
	public double perimeterMeasurable() {
		return 2.00 * Math.PI * this.radius;
	}
	
	public double getRadius() {
		return this.radius;
	}

	public void setRadius(double radius) {
		if (radius < 0) {
			throw new IllegalArgumentException("Radius cannot be negative");
		}
		
		this.radius = radius;
	}

	
	@Override
	public String toString() {
		return "\nCircle:" +
				super.toString();			
	}
}
