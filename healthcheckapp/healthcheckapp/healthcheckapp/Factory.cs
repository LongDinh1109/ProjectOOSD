using System;
using System.Collections.Generic;
using System.Text;

namespace healthcheckapp
{
    
    public class AccountFactory
    {
        private AccountFactory()
        {
        }
        public static MemberType getAccount(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.SMEMBER:
                    return new SMember(new CheckingAccount());
                case AccountType.SSMEMBER:
                    return new SSMember(new CheckingAccount());
                default:
                    return null;
            }
            
        }
    }
    public enum AccountType
    {
        SMEMBER, SSMEMBER
    }

}
