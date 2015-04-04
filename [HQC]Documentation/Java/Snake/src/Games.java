import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

/**
 * create new Object "Game", initialize new game and start it.
 */
@SuppressWarnings("serial")
public class Games extends Canvas implements Runnable {
	public static Snake snake;
	public static AppleCore apple;
	static int point;
	
	private Graphics globalGraphics;
	private Thread runThread;
	public static final int width = 600;
	public static final int height = 600;
	private final Dimension dimension = new Dimension(width, height);
	
	static boolean gameRunning = false;

    /**
     * Drawn Game
     * @param graphics
     */
	public void draw(Graphics graphics){
		this.setPreferredSize(dimension);
		globalGraphics = graphics.create();
		point = 0;
		
		if(runThread == null){
			runThread = new Thread(this);
			runThread.start();
			gameRunning = true;
		}
	}

    /**
     * Run the game
     */
	public void run(){
		while(gameRunning){
			snake.tick();
			render(globalGraphics);
			try {
				Thread.sleep(100);
			} catch (Exception e) {
				// TODO: Exception
			}
		}
	}

	public Games(){
		snake = new Snake();
		apple = new AppleCore(snake);
	}

    /**
     * Rendering the game
     * @param graphic
     */
	public void render(Graphics graphic){
		graphic.clearRect(0, 0, width, height + 25);
		
		graphic.drawRect(0, 0, width, height);
		snake.printSnake(graphic);
		apple.drawAppleCore(graphic);
		graphic.drawString("score= " + point, 10, height + 25);
	}
}

