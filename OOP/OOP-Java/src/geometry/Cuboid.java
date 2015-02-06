package geometry;

public class Cuboid extends SpaceShape {
	private double width;
	private double height;
	private double depth;

	public Cuboid(double x, double y, double z, double width, double height,
			double depth) {
		super(x, y, z);
		this.setWidth(width);
		this.setHeight(height);
		this.setDepth(depth);
	}

	@Override
	public double volume() {
		return (this.width * this.depth + this.width * this.height + this.height
				* this.depth);
	}

	@Override
	public double areaMeasurable() {
		return this.width * this.height * this.depth;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		if (height < 0) {
			throw new IllegalArgumentException("Height cannot be negative");
		}

		this.height = height;
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		if (width < 0) {
			throw new IllegalArgumentException("Width cannot be negative");
		}

		this.width = width;
	}

	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) {
		if (depth < 0) {
			throw new IllegalArgumentException("Depth cannot be negative");
		}

		this.depth = depth;
	}
	
	@Override
	public String toString() {
		return "\nCuboid:" +
				super.toString();			
	}

}
