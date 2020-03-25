
/**
 *
 * @author PaniJC
 */
package statemethod;

public abstract class State {
    
    abstract public void nextState(Tank tank);
    abstract public int getDamage(Tank tank);
    abstract public boolean getMove(Tank tank);

    
}
