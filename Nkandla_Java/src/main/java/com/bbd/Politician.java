package com.bbd;


/**
 * Created by bbdnet1523 on 2016/12/06.
 */
@SuppressWarnings("DefaultFileTemplate")
public class Politician extends Person implements IVisitor {

    public Politician(String name, int age, Gender gender, PersonType politician) {
        super(name, age, gender, politician);
    }

    @Override
    public String toString() {
        return "Politician{} " + super.toString();
    }

    public void visit(Homestead home) {
        if (super.getType().equals(PersonType.Politician))
            throw new RuntimeException("Pay back the money!");

    }
}
