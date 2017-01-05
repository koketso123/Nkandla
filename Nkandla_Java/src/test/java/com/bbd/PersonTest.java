package com.bbd;

import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 * Created by bbdnet1523 on 2016/12/06.
 */
@SuppressWarnings("DefaultFileTemplate")
public class PersonTest {

    private Politician HelenZille;
    private Politician JuliusMalema;
    private Lawyer BarryRoux;

    @Before
    public void setUp() throws Exception {
        HelenZille = new Politician("Hellen Zille", 50, Gender.FEMALE, PersonType.Politician);
        JuliusMalema = new Politician("Julius Malema", 38, Gender.MALE, PersonType.Politician);
        BarryRoux = new Lawyer("Barry Roux", 55, Gender.MALE, PersonType.Lawyer);

    }

    @Test
    public void testNames() {
        assertEquals("Hellen Zille", HelenZille.getName());
        assertEquals("Julius Malema", JuliusMalema.getName());
        assertEquals("Barry Roux", BarryRoux.getName());
    }

    @Test
    public void testAges() {
        assertEquals(50, HelenZille.getAge());
        assertEquals(38, JuliusMalema.getAge());
        assertEquals(55, BarryRoux.getAge());
    }

    @Test
    public void testGender() {
        assertEquals(Gender.FEMALE, HelenZille.getGender());
        assertEquals(Gender.MALE, JuliusMalema.getGender());
        assertEquals(Gender.MALE, BarryRoux.getGender());
    }

    @Test
    public void testType() {
        assertEquals(PersonType.Politician, HelenZille.getType());
        assertEquals(PersonType.Politician, JuliusMalema.getType());
        assertEquals(PersonType.Lawyer, BarryRoux.getType());
    }
}
