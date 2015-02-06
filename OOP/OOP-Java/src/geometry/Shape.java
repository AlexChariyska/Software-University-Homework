package geometry;

public abstract class Shape {
	protected Vertex[] vertices;

	protected Shape() {
		this.vertices = new Vertex[1];
	}
	
	public Vertex[] getVertices() {
		return this.vertices;
	}

	@Override
	public String toString() {
		return this.vertices[0].toString();
	}
}