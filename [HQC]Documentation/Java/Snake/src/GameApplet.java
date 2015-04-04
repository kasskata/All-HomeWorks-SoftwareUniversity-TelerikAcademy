import java.applet.Applet;
import java.awt.Dimension;
import java.awt.Graphics;

@SuppressWarnings("serial")
public class GameApplet extends Applet {
	private Games game;
	keyListener IH;

    /**
     * Initialize new game with default parameters Size, Visibility, Focus and listen for new button press
     */
	public void initializeGame(){
		game = new Games();
		game.setPreferredSize(new Dimension(800, 650));
		game.setVisible(true);
		game.setFocusable(true);
		this.add(game);
		this.setVisible(true);
		this.setSize(new Dimension(800, 650));
		IH = new keyListener(game);
	}

    /**
     * Drwan the game with default dimensions 800,650
     * @param g
     */
	public void paint(Graphics g){
		this.setSize(new Dimension(800, 650));
	}

}
