package geometry;

public abstract class SpaceShape extends Shape implements AreaMeasurable,
		VolumeMeasurable {

	public SpaceShape(double x, double y,double z) {
		this.vertices = new Vertex2D[1];
		this.vertices[0] = new Vertex2D(x, y);
	}
	
	@Override
	public String toString() {
		return "\nArea: " + this.areaMeasurable() + "\nPerimeter: "
				+ this.volume();
	}

	@Override
	public abstract double volume();

	@Override
	public abstract double areaMeasurable();

}
