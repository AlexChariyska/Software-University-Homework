package geometry;

public class SquarePyramid extends SpaceShape {
	private double baseWidth;
	private double height;
	private double pHeight;
	
	public SquarePyramid(double x, double y, double z,
			double baseWidth, double height, double pHeight) {
		super(x, y, z);
		this.setBaseWidth(baseWidth);
		this.setHeight(height);
		this.setPHeight(pHeight);
	}

	private double getBaseArea() {
		return this.baseWidth * this.baseWidth;
	}

	public double getBaseWidth() {
		return this.baseWidth;
	}

	public void setBaseWidth(double baseWidth) {
		if (baseWidth < 0) {
			throw new IllegalArgumentException("base width cannot be negative");
		}
		
		this.baseWidth = baseWidth;
	}

	public double getHeight() {
		return this.height;
	}

	public void setHeight(double height) {
		if (height < 0) {
			throw new IllegalArgumentException("height cannot be negative");
		}
		
		this.height = height;
	}

	public double getPHeight() {
		return this.pHeight;
	}

	public void setPHeight(double pHeight) {
		if (pHeight < 0) {
			throw new IllegalArgumentException("Pyramit Height cannot be negative");
		}
		
		this.pHeight = pHeight;
	}

	@Override
	public double volume() {
		return (1.0 / 3.0) * this.getBaseArea() * this.height;
	}

	@Override
	public double areaMeasurable() {
		double fArea = (1.0 / 2.0) * (4 * this.baseWidth) * this.height;
		double bArea = this.getBaseArea();
		
		return fArea + bArea;
	}	
	
	@Override
	public String toString() {
		return "\nPyramid:" +
				super.toString();			
	}
}