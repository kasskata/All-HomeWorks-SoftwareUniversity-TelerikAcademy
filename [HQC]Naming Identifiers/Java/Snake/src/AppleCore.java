import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;


public class AppleCore {
	public static Random randomGenerator;
	private Point apple;
	private Color snakeColor;

	public AppleCore(Snake s) {
		apple = createApple(s);
		snakeColor = Color.RED;
	}

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

	public void draw(Graphics g){
		apple.printSnake(g, snakeColor);
	}

	public Point givePoint(){
		return apple;
	}
}
