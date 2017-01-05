package com.bbd;

/**
 * Created by bbdnet1523 on 2016/12/06.
 */
@SuppressWarnings("DefaultFileTemplate")
class Homestead {

    private String Name;
    private String Distict;
    private String Province;
    private String Country;

    public Homestead(String name, String distict, String province, String country) {
        Name = name;
        Distict = distict;
        Province = province;
        Country = country;
    }

    public void accept(IVisitor visitor) {
        if (visitor != null)
            visitor.visit(this);
    }

    @Override
    public String toString() {
        return "Homestead{" +
                "Name='" + Name + '\'' +
                ", Distict='" + Distict + '\'' +
                ", Province='" + Province + '\'' +
                ", Country='" + Country + '\'' +
                '}';
    }
}
