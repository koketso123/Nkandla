package com.bbd;

/**
 * Created by bbdnet1523 on 2016/12/06.
 */
@SuppressWarnings("DefaultFileTemplate")
abstract class Person {

    private String name;
    private int age;
    private Gender gender;
    private PersonType type;

    Person(String name, int age, Gender gender, PersonType personType) {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.type = personType;

    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }

    public Gender getGender() {
        return gender;
    }

    public PersonType getType() {
        return type;
    }

    @Override
    public String toString() {
        return "Person{" +
                "name='" + name + '\'' +
                ", age=" + age +
                ", gender=" + gender +
                ", type=" + type +
                '}';
    }

}
