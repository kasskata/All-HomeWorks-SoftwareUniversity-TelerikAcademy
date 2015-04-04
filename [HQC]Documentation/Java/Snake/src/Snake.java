import java.awt.Color;
import java.awt.Graphics;
import java.util.LinkedList;

/**
 * Create new object "Snake" and initilize with 10 lenght of the snake body and default position x=20 and y=0;
 */
public class Snake {
	LinkedList<Point> snakeBody = new LinkedList<Point>();
	private Color snakeColor;
	private int x, y;

    /**
     * Create new object "Snake" and initialize with 10 length of the snake body and default position x=20 and y=0;
     */
	public Snake() {
		snakeColor = Color.GREEN;
		snakeBody.add(new Point(300, 100));
		snakeBody.add(new Point(280, 100));
		snakeBody.add(new Point(260, 100));
		snakeBody.add(new Point(240, 100));
		snakeBody.add(new Point(220, 100));
		snakeBody.add(new Point(200, 100));
		snakeBody.add(new Point(180, 100));
		snakeBody.add(new Point(160, 100));
		snakeBody.add(new Point(140, 100));
		snakeBody.add(new Point(120, 100));

		x = 20;
		y = 0;
	}
	/**
	 * Draw the snake on the field
	 */
	public void printSnake(Graphics g) {
		for (Point point : this.snakeBody) {
			point.printSnake(g, snakeColor);
		}
	}

	/**
     * Method for snake move
     */
	public void tick() {
		Point newPosition = new Point((snakeBody.get(0).giveX() + x), (snakeBody.get(0).giveY() + y));
		
		if (newPosition.getX() > Games.width - 20) {
		 	Games.gameRunning = false;
		} else if (newPosition.getX() < 0) {
			Games.gameRunning = false;
		} else if (newPosition.giveY() < 0) {
			Games.gameRunning = false;
		} else if (newPosition.giveY() > Games.height - 20) {
			Games.gameRunning = false;
		} else if (Games.apple.givePoint().equals(newPosition)) {
			snakeBody.add(Games.apple.givePoint());
			Games.apple = new AppleCore(this);
			Games.point += 50;
		} else if (snakeBody.contains(newPosition)) {
			Games.gameRunning = false;
			System.out.println("You ate yourself");
		}	
		
		for (int i = snakeBody.size()-1; i > 0; i--) {
			snakeBody.set(i, new Point(snakeBody.get(i-1)));
		}	
		snakeBody.set(0, newPosition);
	}

    /**
     * Get current X from the head of snake
     */
	public int getX() {
		return x;
	}

    /**
     * Set current X from the head of snake
     */
	public void setX(int x) {
		this.x = x;
	}
    /**
     * Get current Y from the head of snake
     */
	public int getY() {
		return y;
	}

    /**
     * Set current Y from the head of snake
     */
	public void setY(int y) {
		this.y = y;
	}
}
