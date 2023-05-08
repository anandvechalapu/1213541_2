// Apex Class
public with sharing class AccountContactWrapper {

    // Method to get list of accounts and their associated contacts
    public static List<Account> getAccountsAndContacts() {
        // Get list of accounts visible to user
        List<Account> accounts = [SELECT Id, Name, Phone, BillingStreet, BillingCity, BillingState, BillingPostalCode
            FROM Account];
        // Get list of contacts associated with the accounts
        List<Contact> contacts = [SELECT Id, Name, Email, Phone
            FROM Contact
            WHERE AccountId IN :accounts];
        // Add contacts to accounts
        for (Account a : accounts) {
            List<Contact> accountContacts = new List<Contact>();
            for (Contact c : contacts) {
                if (a.Id == c.AccountId) {
                    accountContacts.add(c);
                }
            }
            a.Contacts = accountContacts;
        }
        return accounts;
    }

}