package com.bbd;

/**
 * Created by bbdnet1523 on 2016/12/06.
 */
@SuppressWarnings("DefaultFileTemplate")
public class SwimmingPool {

    private final int length;
    private final int width;

    public SwimmingPool(int length, int width) {
        this.length = length;
        this.width = width;
    }

    public int getLength() {
        return length;
    }

    public int getWidth() {
        return width;
    }

    @Override
    public String toString() {
        return "SwimmingPool{" +
                "length=" + length +
                ", width=" + width +
                '}';
    }
}
