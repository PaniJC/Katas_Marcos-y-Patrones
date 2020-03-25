/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package statemethod;

/**
 *
 * @author PaniJC
 */
public class TankState extends State{
    
    @Override
    public void nextState(Tank tank) {
        tank.setState(new SiegeState());
    }

    @Override
    public int getDamage(Tank tank) {
       return 5;
    }

    @Override
    public boolean getMove(Tank tank) {
         return true;
    }


    
    
   
}
