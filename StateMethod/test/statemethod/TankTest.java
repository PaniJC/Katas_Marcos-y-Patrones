/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package statemethod;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author PaniJC
 */
public class TankTest {
    
    public TankTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }

    /**
     * Test of setState method, of class Tank.
     */
    @org.junit.Test
    public void testSetState() {
        System.out.println("setState");
        State state = null;
        Tank instance = new Tank();
        instance.setState(state);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of getDamage method, of class Tank.
     */
    @org.junit.Test
    public void testGetDamage() {
        System.out.println("getDamage");
        Tank instance = new Tank();
        int expResult = 0;
        int result = instance.getDamage();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of getMove method, of class Tank.
     */
    @org.junit.Test
    public void testGetMove() {
        System.out.println("getMove");
        Tank instance = new Tank();
        boolean expResult = false;
        boolean result = instance.getMove();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}
