## Purpose
The purpose of this lab is to better familiarise yourself with inheritance and polymorphism.

## Objective
Create an inheritance hierarchy that a bank might use to represent customers' bank accounts. All customers at this bank can deposit (i.e. credit) money into their accounts and withdraw (i.e. debit) money from their accounts. More specific types of accounts also exist. Savings accounts, for instance, earn interest on the money they hold. Checking accounts, on the other hand, charge a fee per transaction (both for credits and debits).

First, add a base class called Account, and derived classes SavingsAccount and CheckingAccount that each inherit from class Account.

_Account Class:_

 * The base class Account must include one private field of type decimal to represent the account balance. The class must provide a constructor that receives an initial balance parameter (also type decimal) and uses it to initialize the instance variable through a special read/write property named Balance. The Balance property will have a public "get" that returns the value of the balance field. 

 * The Balance property will have a protected "set" that will validate the value we are attempting to set the balance field to in order to ensure that it is greater than or equal to 0.00; if not, throw an exception.

 * The Account class must also provide two public methods: Credit and Debit. Method Credit must add an amount to the current balance. Method Debit will withdraw money from the Account and ensure that the debit amount does not exceed the Account balance.

 * Both the Credit and Debit methods will be marked as "virtual" so the any derived classes can overide them. they will have a decimal return type that returns the actual transacted amount. Normally, the returned amount will be the amount that was passed into the method, but derived classes may override this behavior.

 * In addition, both the Credit and Debit methods will include an out string parameter that is used to provide a message regarding the result of the Credit or Debit. If the transaction was successful, then load the out parameter with "Success". If the amount parameter for either method is less than 0.00, then load the out parameter with "Incoming Credit amount is less than 0.00." (substitute "Debit" for "Credit" for the Debit method).

 * If the debit method has a valid (> 0.00) incoming debit amount but attempts to take more money out of the Account than is in the balance, then load the out parameter with "Debit transaction amount exceeds balance".

 * In any of the above error conditions occur, the methods will leave the balance unchanged and return 0.00. Otherwise, the methods will return the value of the incoming amount parameter.

Here is an example method header for Credit method:

`public virtual decimal Credit(decimal amountIn, out string transactionMessage)`

_SavingsAccount Class:_

 * The SavingsAccount class will inherit the functionality of an Account, but will also include a private type `decimal` field for the interest rate assigned to the account (*NOTE: store the interest rate as a fractional value, i.e. 3% would be stored as 0.03*). Provide a public read-only property named InterestRate that will return the value of the interest rate field.

 * The SavingAccount class constructor will take in a starting balance amount as the Account class does, but, in addition, it will take in another value for the interest rate. If the interest rate passed into the constructor is less than 0.00, throw an exception.

 * The SavingsAccount class will provide a public method named CalculateInterest that returns a type decimal consisting of the amount of interest earned on the account (InterestRate * Balance).

_CheckingAccount Class:_

 * The CheckingAccount class will inherit the functionality of an Account, but will also include a private type decimal field for the fee charged per transaction (checing accounts are charged a fee whenever money is added to or deducted from the account). Provide a public read-only property named FeePerTransaction that will return the value of the fee charged per transaction field.

 * The CheckingAccount class constructor will take in a starting balance amount as the Account class does, but, in addition, it will take in another value for the fee charged per transaction. If the fee charged per transaction passed into the constructor is less than 0.00, throw an exception.

 * The CheckingAccount class will override both the Credit and Debit methods so that they will apply the fee per transaction amount each time these methods are called. Both methods must validate the incoming amounts for less than 0.00 condition as the base class methods do.

 * In addition, the Credit method will return the net amount of the deposit: original deposit amount minus the fee per transaction. The Debit method will return the withdrawal amount plus the fee per transaction. In both methods, load the transactionMessage with "A $2.00 transaction fee was charged" (use the actual fee per transaction amount where I show $2.00).

There are also two other special conditions the CheckingAccount Credit and Debit methods must handle:

 1. If the deposit amount in the Credit method is not greater than the fee per transaction, return 0.00 and load the transactionMessage with "Deposit amount must exceed the $2.00 transaction fee" (again, $2.00 here will be replaced with the actual fee per transaction amount).

 1. If withdrawal amount plus the fee per transaction amount in the Debit method exceeds the account Balance, do not change the Balance and return 0.00. Also load the transactionMessage with "Debit amount plus the $2.00 transaction fee exceeded the account balance" (once again, $2.00 here will be replaced with the actual fee per transaction amount).

_Main Method:_

In your client code (main method), create at least one SavingAccount object and CheckingAccount object. Create a menu system to ask the user to add money (Credit) and withdraw money (Debit) to and from a prompted account.

## Expectations and Grading
 - (10 pts) Create and implement the Account class as described
 - (10 pts) Create and implement the SavingsAccount class as described
 - (10 pts) Create and implement the CheckingAccount class as described
 - (5 pts) Implement a menu system that allows the user to access all functionality of the above three classes.

## Assignment Retrieval, Testing, and Submission
1. Pull down this repository from GitHub to your local machine.
1. You can check in your work, as well as push to GitHub, as infrequently or as often as you wish. However, you must ensure that your work is checked in and pushed, as that will be how your assignment is turned in. The code as of the due date and time will be the version that will be graded.
