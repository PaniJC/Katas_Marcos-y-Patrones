
/**
 *
 * @author PaniJC
 */
package statemethod;

public class SiegeState extends State {
 
    @Override
    public void nextState(Tank tank) {
        tank.setState(new TankState());
    }
 
    @Override
    public int getDamage(Tank tank) {
        return 20;
    }

    @Override
    public boolean getMove(Tank tank) {
         return false;
    }

    

   

    
    
    
}
