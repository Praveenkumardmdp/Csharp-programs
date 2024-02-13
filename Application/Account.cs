using System;
using System.Collections;
public class Account
{
    private string ?accountNumber;
    private static string referenceNumber1="20380";
    private static long referenceNumber2=1234560;
    private static int uniqueNumber=1000;
    private int pinNumber;
    private string ?userName;
    private int age;
    private long phoneNumber;
    private float balance;
    private string ?previousTransaction;
    Stack<string> stack = new Stack<string>();
    public void generateAccountNumber()
    {
        accountNumber = referenceNumber1+referenceNumber2++;
    }
    public string getAccountNumber()
    {
        return accountNumber;
    }
    public int getPinNumber()
    {
        return pinNumber;
    }
    public void setPinNumber()
    {
        pinNumber=uniqueNumber;
        uniqueNumber++;
    }
    public string getUserName()
    {
        return userName;
    }
    public void setFirstName(string userName)
    {
        this.userName=userName;
    }
    public int getAge()
    {
        return age;
    }
    public void setAge(int age)
    {
        this.age=age;
    }
    public long getPhoneNumber()
    {
        return phoneNumber;
    }
    public void setPhoneNumber(long phoneNumber)
    {
        this.phoneNumber=phoneNumber;
    }
    public float getBalance()
    {
        return balance;
    }
    public void setBalance(float balance)
    {
        this.balance=balance;
    }
    public string getPreviousTransaction()
    {
        return previousTransaction;
    }
    public void setPreviousTransaction(string previousTransaction)
    {
        this.previousTransaction=previousTransaction;
        stack.Push(previousTransaction);
    }
    public string tostring()
    {
        return "*********Account details********* \nAccount Number     =" + accountNumber+ "\n"+"Name               =" + userName +"\n"+"Age                ="+age+ "\n"+"Phone Number       =" + phoneNumber + "\n"+"Available Balance  =" + balance+"\n**********************************";
    }
}