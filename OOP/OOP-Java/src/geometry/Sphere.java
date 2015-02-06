package geometry;

public class Sphere extends SpaceShape {
	private double radius;

	public Sphere(double x, double y, double z, double radius) {
		super(x, y, z);
		this.setRadius(radius);
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
	public double volume() {
		return (4.0 / 3.0) * Math.PI * Math.pow(this.radius, 3);
	}

	@Override
	public double areaMeasurable() {
		return 4.0 * Math.PI * Math.pow(this.radius, 2);
	}
	
	@Override
	public String toString() {
		return "\nSphere:" +
				super.toString();			
	}
}
