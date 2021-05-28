using System;
using System.Collections.Generic;
using System.Text;

namespace healthcheckapp
{
    public class AccountCommand
    {
        private string Name;
        public AccountCommand(string Name)
        {
            this.Name = Name;
        }
        public string SignOut()
        {
            return "Account" + this.Name + "Sign Out";
        }
        public string Close()
        {
            return "Account" + this.Name + "Closed";
        }

    }
    public interface Command
    {
        string Excute();

    }
    public class SignOut : Command
    {
        private AccountCommand account;
        public SignOut(AccountCommand account)
        {
            this.account = account;
        }
        public string Excute()
        {
            return account.SignOut();
        }
    }
    public class CloseAccount : Command
    {
        private AccountCommand account;
        public CloseAccount(AccountCommand account)
        {
            this.account = account;
        }
        public string Excute()
        {
            return account.Close();
        }
    }
    public class HealthApp
    {

        private Command signOut;
        private Command closeAccount;

        public HealthApp(Command signOut, Command closeAccount)
        {
            this.signOut = signOut;
            this.closeAccount = closeAccount;
        }

        public string clickSignOutAccount()
        {
          
            return signOut.Excute();
        }

        public string clickCloseAccount()
        {
            //print("User click close an account");
            return closeAccount.Excute();
        }
    }
}
