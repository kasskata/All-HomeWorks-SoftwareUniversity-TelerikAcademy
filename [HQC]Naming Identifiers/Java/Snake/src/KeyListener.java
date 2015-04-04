import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class keyListener implements KeyListener{
	
	public keyListener(Games game){
		game.addKeyListener(this);
	}
	
	public void keyPressed(KeyEvent e) {
		int button = e.getKeyCode();
		
		if (button == KeyEvent.VK_W || button == KeyEvent.VK_UP) {
			if(Games.snake.getY() != 20){
				Games.snake.setX(0);
				Games.snake.setY(-20);
			}
		}
		if (button == KeyEvent.VK_S || button == KeyEvent.VK_DOWN) {
			if(Games.snake.getY() != -20){
				Games.snake.setX(0);
				Games.snake.setY(20);
			}
		}
		if (button == KeyEvent.VK_D || button == KeyEvent.VK_RIGHT) {
			if(Games.snake.getX() != -20){
			Games.snake.setX(20);
			Games.snake.setY(0);
			}
		}
		if (button == KeyEvent.VK_A || button == KeyEvent.VK_LEFT) {
			if(Games.snake.getX() != 20){
				Games.snake.setX(-20);
				Games.snake.setY(0);
			}
		}
		//Other controls
		if (button == KeyEvent.VK_ESCAPE) {
			System.exit(0);
		}
	}
	
	public void keyReleased(KeyEvent e) {
	}
	
	public void keyTyped(KeyEvent e) {
		
	}

}
