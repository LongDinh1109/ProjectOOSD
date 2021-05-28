using System;
using System.Collections.Generic;
using System.Text;
public interface Type
{
    string OpenAccount();
}
namespace healthcheckapp
{
   
    public class CheckingAccount : Type
    {
        public string OpenAccount()
        {
            return "Checking...";
        }
    }
    public class SavingAccount : Type
    {
        public string OpenAccount()
        {
            return "Saving....";

        }
    }
    public abstract class MemberType
    {
        protected Type type;
        public MemberType(Type type)
        {
            this.type = type;
        }
        public abstract string OpenAccount();
    }
    public class SMember : MemberType
    {
        protected Type type;
        public SMember(Type type):base(type)
        {
            this.type = type;
        }

        public override string OpenAccount()
        {
            
            type.OpenAccount();
            return "SMember is Opened";

        }
    }
    public class SSMember : MemberType
    {
        protected Type type;
        public SSMember(Type type):base(type)
        {
            this.type = type;
        }
        public override string OpenAccount()
        {
            //print open a normal account is a 
            type.OpenAccount();
            return "SSMember is opened";
        }
    }
    public class client
    {

        public static void main(String[] args)
        {
            MemberType sMember = new SMember(new CheckingAccount());
            sMember.OpenAccount();
            MemberType sSMember = new SSMember(new CheckingAccount());
            sSMember.OpenAccount();
        }
    }
}
