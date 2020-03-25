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
public class Tank {
    private State state;
    public boolean canMove;
    public int damage;
    
    public Tank(){
      this.setState(new SiegeState());
    }
     
    protected void setState (State state){
        this.state = state;
    }
    
    public int getDamage(){
        return state.getDamage(this);
   
    }
    
    public boolean getMove(){
        return state.getMove(this);
      
    }
    
    
  
    
}
