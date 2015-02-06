package geometry;

import geometry.PerimeterMeasurable;
import geometry.VolumeMeasurable;

import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.function.Predicate;
import java.util.stream.Collector;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class TestingShape {

	public static void main(String[] args) {
		Shape[] shapes = new Shape[6];
		shapes[0] = new Triangle(1, 2, 2, 11, 11, 15);
		shapes[1] = new Circle(122, -17, 13);
		shapes[2] = new Rectangle(1, 8, 3, 50);
		shapes[3] = new SquarePyramid(1, -1, 3, 4, 1, 6);
		shapes[4] = new Cuboid(10, -70, 30, 11, 20, 30);
		shapes[5] = new Sphere(5, -12, 3, 45);
		
		for (Shape shape : shapes) {
			System.out.println(shape);
		}
		
		
		
		/*List<Shape> volumeShapes =Arrays.asList(shapes).stream()
				.filter(s -> s instanceof VolumeMeasurable)
				.filter(s -> ((VolumeMeasurable) s).volume() > 40)
				.collect(Collectors.toList());
		
		for (Shape shape : volumeShapes) {
			System.out.println(shape);
		}
		
		Comparator<Shape> byPerimeter = (s1, s2) -> {
			PerimeterMeasurable Shape1 = (PerimeterMeasurable) s1;
			PerimeterMeasurable Shape2 = (PerimeterMeasurable) s2;
			double perimeterShape1 = Shape1.getPerimeter();
			double perimeterShape2 = Shape2.getPerimeter();
			
			return perimeterShape1 < perimeterShape2 ? -1 :
				perimeterShape1 > perimeterShape2 ? 1 : 0;		
		};
		
		List<Shape> planeShapesByPerimeter = Arrays.asList(shapeCollection)
				.stream()
				.filter(p -> p instanceof PlaneShape)
				.sorted(byPerimeter)
				.collect(Collectors.toList());
		
		for (Shape shape : planeShapesByPerimeter) {
			System.out.println(shape);
		}*/
	}
}
