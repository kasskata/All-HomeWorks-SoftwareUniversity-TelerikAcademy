import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

/**
 * create new object Apple on random place on field
 */
public class AppleCore {
	public static Random randomGenerator;
	private Point apple;
	private Color snakeColor;

	public AppleCore(Snake s) {
		apple = createApple(s);
		snakeColor = Color.RED;
	}

    /**
     * Create random based position fro the apple
     * @param snake current object snake and look for whether if new point is not on snake body
     * @return new object from class Point with X and Y on the field
     */
	private Point createApple(Snake snake) {
		randomGenerator = new Random();
		int x = randomGenerator.nextInt(30) * 20;
		int y = randomGenerator.nextInt(30) * 20;
		for (Point snakePoint : snake.snakeBody) {
			if (x == snakePoint.getX() || y == snakePoint.giveY()) {
				return createApple(snake);
			}
		}
		return new Point(x, y);
	}

    /**
     * Draw the the snake on field
     * @param g
     */
	public void draw(Graphics g){
		apple.printSnake(g, snakeColor);
	}

    /**
     * Return current apple point of the field
     * @return
     */
	public Point givePoint(){
		return apple;
	}
}
