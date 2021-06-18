public class Item {
    private string title;

 
    public Item(string title) {
        this.title = title;
    }
 
    
    public override string toString() {
        return "Item [title=" + title + "]";
    }
}
public interface ItemIterator<T> {
     
    boolean hasNext();
     
    T next();
}
public class Menu {
    private List<Item> menuItems = new ArrayList<>();
 
    public void addItem(Item item) {
        menuItems.add(item);
    }
 
    public ItemIterator<Item> iterator() {
        return new MenuItemIterator();
    }
 
    class MenuItemIterator: ItemIterator<Item> {
        private int currentIndex = 0;
 
        
        public override boolean hasNext() {
            return currentIndex < menuItems.size();
        }
 
        public override Item next() {
            return menuItems.get(currentIndex++);
        }
    }
}
public class Client {
    public static void main(String[] args) {
 
        Menu menuCustomer = new Menu();
        menuCustomer.addItem(new Item("Home", "/home"));
        menuCustomer.addItem(new Item("Java", "/java"));
        menuCustomer.addItem(new Item("Spring Boot", "/spring-boot"));
 
        ItemIterator<Item> iterator = menuCustomer.iterator();
        while (iterator.hasNext()) {
            Item item = iterator.next();
        }
    }
}