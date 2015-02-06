package geometry;

public class Triangle extends PlaneShape{

	public Triangle(double x, double y, double x2, double y2,double x3, double y3) {
		super(x, y);
		this.vertices[1] = new Vertex2D(x2, y2);
		this.vertices[2] = new Vertex2D(x3, y3);
	}

	@Override
	public double areaMeasurable() {
		double s = this.perimeterMeasurable();
		double a = this.getDistanceAB();
		double b = this.getDistanceBC();
		double c = this.getDistanceAC();
		
		double areaTriangle = Math.sqrt(s * (s - a) * (s - b) * (s - c));
		
		return areaTriangle;
	}

	@Override
	public double perimeterMeasurable() {	
		double perimeter = this.getDistanceAB() + this.getDistanceBC() + this.getDistanceAC();
		
		return perimeter;
	}
	
	public double getDistanceAB() {
		double distanceAB = Vertex.distanceBetweenPoints(this.vertices[0], this.vertices[1]);
		
		return distanceAB;
	}
	
	public double getDistanceBC() {
		double distanceBC = Vertex.distanceBetweenPoints(this.vertices[1], this.vertices[2]);
		
		return distanceBC;
	}
	
	public double getDistanceAC() {
		double distanceAC = Vertex.distanceBetweenPoints(this.vertices[2], this.vertices[0]);
		
		return distanceAC;
	}	
	
	@Override
	public String toString() {
		return "\nTriangle:" + super.toString();
	}
}
