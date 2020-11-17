// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil Kumar yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace AddressBook_AdoNet
{
    /// <summary>
    /// Program Class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book AdoNet");
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            ContactDetails contactDetails = new ContactDetails();
            contactDetails.firstName = "AAYAM";
            contactDetails.lastName = "kumar";
            contactDetails.phoneNumber = 87215447;
            contactDetails.email = "aa@gmail.com";
            contactDetails.city = "bop";
            contactDetails.start = Convert.ToDateTime("1/2/2018");
            contactDetails.state = "wb";
            contactDetails.addressBookId = 6;
            contactDetails.completeAddressId = 106;
            contactDetails.addressBookName = "First";
            contactDetails.address = "street 1";
            contactDetails.zip = 6265165;
            contactDetails.typeId = 1;
            contactDetails.typeName = "Friends";
            Console.WriteLine(addressBookOperations.AddingContactDetailsInDatabase(contactDetails) ? "Query Succesful for between DateRange " : "Failed");
            //Console.WriteLine(addressBookOperations.GetContactsByCityOrState() ? "Query Succesful For Get by city " : "Failed");

        }
    }
}