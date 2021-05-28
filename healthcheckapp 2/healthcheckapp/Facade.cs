using System;
using System.Collections.Generic;
using System.Text;

namespace healthcheckapp
{
    public class AccountService
    {
        public string getAccount(string Email)
        {
            return "Account with " + Email; 
        }
    }
    public class PaymentService
    {
        public string paymentByPaypal()
        {
            return ("Payment by Paypal");
        }

        public string paymentByCreditCard()
        {
            return ("Payment by Credit Card");
        }

        public string paymentByEbankingAccount()
        {
            return ("Payment by E-banking account");
        }

        public string paymentByCash()
        {
            return ("Payment by cash");
        }
    }
    public class EmailService
    {

        public string sendMail(string mailTo)
        {
            return ("Sending an email to " + mailTo);
        }
    }
    public class SmsService
    {

        public string sendSMS(string mobilePhone)
        {
            return ("Sending an mesage to " + mobilePhone);
        }
    }
    public class AccountFacade
    {
        public static AccountFacade INSTANCE = new AccountFacade();
        private AccountService accountService;
        private PaymentService paymentService;
        private EmailService emailService;
        private SmsService smsService;

        private AccountFacade()
        {
            accountService = new AccountService();
            paymentService = new PaymentService();
            emailService = new EmailService();
            smsService = new SmsService();
        }

        public static AccountFacade getInstance()
        {
            return INSTANCE;
        }

        public string buyProductByCash(String email)
        {
            return accountService.getAccount(email)+
            paymentService.paymentByCash()+
            emailService.sendMail(email);
            
        }

        public string buyProductByPaypal(String email, String mobilePhone)
        {
            return accountService.getAccount(email)+
            paymentService.paymentByPaypal()+
            emailService.sendMail(email)+
            smsService.sendSMS(mobilePhone);
            //print("Done\n");
        }

    }
}
