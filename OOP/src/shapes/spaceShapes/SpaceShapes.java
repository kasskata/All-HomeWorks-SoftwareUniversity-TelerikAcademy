package shapes.spaceShapes;

import shapes.AreaMeasurable;
import shapes.Shape;
import shapes.VolumeMeasurable;

public abstract class SpaceShapes extends Shape implements AreaMeasurable,
        VolumeMeasurable {

    public SpaceShapes(double[] vertexCoordinates) {
        this.vertexCoordinates = new double[3];
        this.vertexCoordinates = vertexCoordinates;
    }
}