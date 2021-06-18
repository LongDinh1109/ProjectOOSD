enum AccountState {
    NEW, SUBMITTED, APPROVED, REJECTED
}
 
class AccountService {
    private AccountState state;
 
    public void setState(AccountState state) {
        this.state = state;
    }
 
    public string handleRequest() {
        switch (state) {
        case NEW:
            return("Create a new account");
            break;
        case SUBMITTED:
            return("Submitted");
            break;
        case APPROVED:
            return("Approved");
            break;
        case REJECTED:
            return("Rejected");
            break;
 
        default:
            break;
        }
    }
}
 
public class AccountApp {
 
    public static void main(String[] args) {
        AccountService service = new AccountService();
 
        service.setState(AccountState.NEW);
        service.handleRequest();
 
        service.setState(AccountState.SUBMITTED);
        service.handleRequest();
 
        service.setState(AccountState.APPROVED);
        service.handleRequest();
    }
}