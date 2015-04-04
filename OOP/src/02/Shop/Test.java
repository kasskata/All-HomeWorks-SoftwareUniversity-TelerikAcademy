import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;


public class ShopTester {

    public static void main(String[] args) {

        Food bread = new Food("Bread", 1, 10,	Age.None, "16.10.2014");
        Food milk = new Food("Milk", 2, 50, Age.None, "16.11.2014");
        Food cigars = new Food("Cigars", 6, 50, Age.Adult, "16.11.2014");
        Food apples = new Food("Apples", 2, 0, Age.Adult, "16.11.2014");

        Customer pesho = new Customer("Pesho", 14, 100);
        Customer gosho = new Customer("Gosho", 14, 1.5);
        Customer ivan = new Customer("Ivan", 20, 10.5);

        try {
            Purchase.ProcessPurchase(bread, pesho);
        } catch (RuntimeException ex) {
            System.out.println(ex.getMessage());
        }

        try {
            Purchase.ProcessPurchase(cigars, pesho);
        } catch (RuntimeException ex) {
            System.out.println(ex.getMessage());
        }

        try {
            Purchase.ProcessPurchase(milk, gosho);
        } catch (RuntimeException ex) {
            System.out.println(ex.getMessage());
        }

        try {
            PurchaseManager.ProcessPurchase(apples, gosho);
        } catch (RuntimeException ex) {
            System.out.println(ex.getMessage());
        }

        System.out.println(bread.getPrice());
        System.out.println();

        List<Product> products = new ArrayList<Product>();
        products.add(bread);
        products.add(milk);
        products.add(cigars);
        products.add(apples);

        Product productWithMostRecentExpirationDate = products.stream()
                .filter(p -> p instanceof Experiable)
                .map(p -> (Experiable) p)
                .sorted((p1, p2) -> p1.getExpirationDate().compareTo(p2.getExpirationDate()))
                .map(p -> (Product) p)
                .findFirst()
                .get();

        System.out.println(productWithMostRecentExpirationDate.getName());
        System.out.println();

        products.stream()
                .filter(p -> p.getAgeRestriction() == AgeRestriction.Adult)
                .sorted((p1, p2) -> Double.compare(p1.getPrice(), p2.getPrice()))
                .collect(Collectors.toList())
                .forEach(p -> System.out.println(p.getName() + " price: " + p.getPrice()));
    }
}