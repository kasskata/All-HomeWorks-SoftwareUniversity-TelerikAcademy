import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

/**
 * Create new object "Point" witch care to snake stay in field and move the snake
 */

public class Point {
	private int x, y;
	private final int WIDTH = 20;
	private final int HEIGHT = 20;

	public Point(Point p){
		this(p.x, p.y);
	}
	
	public Point(int x, int y){
		this.x = x;
		this.y = y;
	}

	public int getX() {
		return x;
	}

	public void setX(int x) {
		this.x = x;
	}

	public int getY() {
		return y;
	}

	public void setY(int y) {
		this.y = y;
	}

    /**
     * Draw snake to the field on current coordinatess and colored it
     * @param graphics the dimensions of the snake
     * @param color the color of the snake
     */
	public void printSnake(Graphics graphics, Color color) {
		graphics.setColor(Color.BLACK);
		graphics.fillRect(x, y, WIDTH, HEIGHT);
		graphics.setColor(color);
		graphics.fillRect(x + 1, y + 1, WIDTH - 2, HEIGHT - 2);
	}

    /**
     * Return string with coordinates
     * @return
     */
	public String toString() {
		return "[x=" + x + ",y=" + y + "]";
	}

    /**
     * Define a weather when is equals X and Y with current point
     * @param obj
     * @return true if is equals and false when not
     */
	public boolean equals(Object obj) {
        if (obj instanceof Point) {
            Point point = (Point)obj;
            return (x == point.x) && (y == point.y);
        }
        return false;
    }
}
