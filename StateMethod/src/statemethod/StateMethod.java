
/**
 *
 * @author PaniJC
 */
package statemethod;

public class StateMethod {

    public static void main(String[] args) {
        Tank t = new Tank();  
        System.out.println("Se supone que acá sale el daño: " + t.getDamage());
        System.out.println("Se puede mover?: " + t.getMove());
        
    }
    
}
