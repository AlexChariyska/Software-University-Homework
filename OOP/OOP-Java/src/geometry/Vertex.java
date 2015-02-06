package geometry;

public abstract class Vertex {
	protected double x;
	protected double y;
	
	protected Vertex(double x, double y) {
		this.x = x;
		this.y = y;
	}
	
	public static double distanceBetweenPoints(Vertex... vertices) {
		double pointSum = 0;
		
		for (int i = 1; i < vertices.length; i++) {
			double diffBetweenPoints =
					Math.pow(vertices[i].getX() - vertices[i-1].getX() , 2) + 
					Math.pow(vertices[i].getY() - vertices[i-1].getY() , 2);
			
			pointSum += diffBetweenPoints;
		}
		
		double distance = Math.sqrt(pointSum);
		
		return distance;
	}

	public double getX() {
		return this.x;
	}

	public void setX(double x) {
		this.x = x;
	}

	public double getY() {
		return this.y;
	}

	public void setY(double y) {
		this.y = y;
	}	
	
	@Override
	public String toString() {
		return "{x = " + this.x + ", y = " + this.y + "}\n";
	}
}