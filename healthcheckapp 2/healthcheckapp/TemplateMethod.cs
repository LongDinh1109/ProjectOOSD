public abstract class PageTemplate {
 
    protected void showHeader() {
        System.println("<header />");
    }
 
    protected void showNavigation() {
        System.println("<nav />");
    }
 
    protected void showFooter() {
        System.println("<footer />");
    }
 
    protected abstract void showBody();
 
    public void showPage() {
        showHeader();
        showNavigation();
        showBody();
        showFooter();
    }
}
public class HomePage: PageTemplate {
 
    
    protected void showBody() {
        System.println("Content of home page page");
    }
}

public class DetailPage :PageTemplate {
    protected void showBody() {
        System.println("Content of detail");
    }
}
public class ContactPage :PageTemplate {
 

    protected void showNavigation() {
        // Just do nothing
        // Because we don't want to show navigation bar on contact page
    }
 
    protected void showBody() {
        System.println("Content of contact page");
    }
}
 
public class TemplateMethodPatternExample {
 
    public static void main(String[] args) {
         
        PageTemplate homePage = new HomePage();
        homePage.showPage();
         
        System.println();
        PageTemplate detailPage = new DetailPage();
        detailPage.showPage();
 
        System.println();
        PageTemplate contactPage = new ContactPage();
        contactPage.showPage();
    }
}