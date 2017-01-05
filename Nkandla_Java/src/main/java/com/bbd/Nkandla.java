package com.bbd;

/**
 * Created by bbdnet1523 on 2016/12/06.
 */
@SuppressWarnings("DefaultFileTemplate")
class Nkandla extends Homestead {

    private SwimmingPool swimmingPool;
    private ChickenRun chickenRun;
    private Amphitheater amphitheater;

    public Nkandla(String name, String distict, String province, String country) {
        super(name, distict, province, country);
    }

    public SwimmingPool getSwimmingPool() {
        return swimmingPool;
    }

    public void setSwimmingPool(SwimmingPool swimmingPool) {
        this.swimmingPool = swimmingPool;
    }

    public ChickenRun getChickenRun() {
        return chickenRun;
    }

    public void setChickenRun(ChickenRun chickenRun) {
        this.chickenRun = chickenRun;
    }

    public Amphitheater getAmphitheater() {
        return amphitheater;
    }

    public void setAmphitheater(Amphitheater amphitheater) {
        this.amphitheater = amphitheater;
    }
}
