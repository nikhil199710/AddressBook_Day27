// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil Kumar yadav"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;

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
            contactDetails.phoneNumber = 877655447;
            contactDetails.email = "aa@gmail.com";
            contactDetails.city = "kol";
            contactDetails.start = Convert.ToDateTime("1/2/2018");
            contactDetails.state = "wb";
            contactDetails.addressBookId = 6;
            contactDetails.completeAddressId = 106;
            contactDetails.addressBookName = "First";
            contactDetails.address = "street 1";
            contactDetails.zip = 315151;
            contactDetails.typeId = 1;
            contactDetails.typeName = "Friends";
            List<ContactDetails> listOfContactsToBeAdded = new List<ContactDetails>();
            listOfContactsToBeAdded.Add(contactDetails);
            addressBookOperations.AddingMultipleContactDetailsUsingThreading(listOfContactsToBeAdded);

        }
    }
}