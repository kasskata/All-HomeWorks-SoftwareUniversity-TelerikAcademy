public abstract class Electronics extends Product {

    public int guaranteePeriodInMonths;

    public Electonics(String name, double price, int quantity,
                             Age ageRestriction, int guaranteePeriodInMonths ) {
        super(name, price, quantity, ageRestriction);
        this.guaranteePeriodInMonths = guaranteePeriodInMonths;
    }
}