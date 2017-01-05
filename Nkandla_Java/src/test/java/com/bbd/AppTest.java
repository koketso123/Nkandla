package com.bbd;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.junit.FixMethodOrder;
import org.junit.runners.MethodSorters;

import static org.junit.Assert.*;

/**
 * Unit test for simple App.
 */
@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class AppTest
{
    private String helloWorld;

    @Before //Set the test
    public void setup(){
        helloWorld = "Hallo World!";
    }
    @Test
    public void testApp()
    {
        assertTrue( true );
    }

    @After
    public void after() {
        helloWorld = null;
    }

}
