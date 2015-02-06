package geometry;


public abstract class PlaneShape extends Shape implements AreaMeasurable, PerimeterMeasurable {
	
	public final static int MAX_VERTEX=3;
	
	public PlaneShape(double x, double y) {
		this.vertices = new Vertex2D[MAX_VERTEX];
		this.vertices[0] = new Vertex2D(x, y);
	}
	
	@Override
	public String toString() {
		return "\nArea: " + this.areaMeasurable() + "\nPerimeter: "
				+ this.perimeterMeasurable();
	}	
	
	@Override
	public abstract double perimeterMeasurable();

	@Override
	public abstract double areaMeasurable();

}
