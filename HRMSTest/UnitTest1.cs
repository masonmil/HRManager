using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HRMSTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Get_Address_Address1_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.Address();

            foo.Address1 = "foo";
            Assert.AreEqual("foo", foo.Address1);

            foo.Address1 = "foo2";
            Assert.AreEqual("foo2", foo.Address1);
        }

        [TestMethod]
        public void Get_Address_Address2_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.Address();

            foo.Address2 = "foo";
            Assert.AreEqual("foo", foo.Address2);

            foo.Address2 = "foo2";
            Assert.AreEqual("foo2", foo.Address2);
        }

        [TestMethod]
        public void Get_Address_City_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.Address();

            foo.City = "foo";
            Assert.AreEqual("foo", foo.City);

            foo.City = "foo2";
            Assert.AreEqual("foo2", foo.City);
        }

        [TestMethod]
        public void Get_Address_Country_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.Address();

            foo.Country = "foo";
            Assert.AreEqual("foo", foo.Country);

            foo.Country = "foo2";
            Assert.AreEqual("foo2", foo.Country);
        }

        [TestMethod]
        public void Get_Address_PostalCode_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.Address();

            foo.PostalCode = "foo";
            Assert.AreEqual("foo", foo.PostalCode);

            foo.PostalCode = "foo2";
            Assert.AreEqual("foo2", foo.PostalCode);
        }

        [TestMethod]
        public void Get_Address_StateProvince_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.Address();

            foo.StateProvince = "foo";
            Assert.AreEqual("foo", foo.StateProvince);

            foo.StateProvince = "foo2";
            Assert.AreEqual("foo2", foo.StateProvince);
        }

        [TestMethod]
        public void Get_AddressInfoSample_Address1_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.AddressInfoSample();

            foo.Address1 = "foo";
            Assert.AreEqual("foo", foo.Address1);

            foo.Address1 = "foo2";
            Assert.AreEqual("foo2", foo.Address1);
        }

        [TestMethod]
        public void Get_AddressInfoSample_Address2_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.AddressInfoSample();

            foo.Address2 = "foo";
            Assert.AreEqual("foo", foo.Address2);

            foo.Address2 = "foo2";
            Assert.AreEqual("foo2", foo.Address2);
        }

        [TestMethod]
        public void Get_AddressInfoSample_City_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.AddressInfoSample();

            foo.City = "foo";
            Assert.AreEqual("foo", foo.City);

            foo.City = "foo2";
            Assert.AreEqual("foo2", foo.City);
        }

        [TestMethod]
        public void Get_AddressInfoSample_Country_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.AddressInfoSample();

            foo.Country = "foo";
            Assert.AreEqual("foo", foo.Country);

            foo.Country = "foo2";
            Assert.AreEqual("foo2", foo.Country);
        }

        [TestMethod]
        public void Get_AddressInfoSample_PostalCode_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.AddressInfoSample();

            foo.PostalCode = "foo";
            Assert.AreEqual("foo", foo.PostalCode);

            foo.PostalCode = "foo2";
            Assert.AreEqual("foo2", foo.PostalCode);
        }

        [TestMethod]
        public void Get_AddressInfoSample_StateProvince_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.AddressInfoSample();

            foo.StateProvince = "foo";
            Assert.AreEqual("foo", foo.StateProvince);

            foo.StateProvince = "foo2";
            Assert.AreEqual("foo2", foo.StateProvince);
        }

        [TestMethod]
        public void Get_PersonInfoAddressSample_Address1_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.PersonInfoAddressSample();

            foo.Address1 = "foo";
            Assert.AreEqual("foo", foo.Address1);

            foo.Address1 = "foo2";
            Assert.AreEqual("foo2", foo.Address1);
        }

        [TestMethod]
        public void Get_PersonInfoAddressSample_Address2_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.PersonInfoAddressSample();

            foo.Address2 = "foo";
            Assert.AreEqual("foo", foo.Address2);

            foo.Address2 = "foo2";
            Assert.AreEqual("foo2", foo.Address2);
        }

        [TestMethod]
        public void Get_PersonInfoAddressSample_City_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.PersonInfoAddressSample();

            foo.City = "foo";
            Assert.AreEqual("foo", foo.City);

            foo.City = "foo2";
            Assert.AreEqual("foo2", foo.City);
        }

        [TestMethod]
        public void Get_PersonInfoAddressSample_Country_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.PersonInfoAddressSample();

            foo.Country = "foo";
            Assert.AreEqual("foo", foo.Country);

            foo.Country = "foo2";
            Assert.AreEqual("foo2", foo.Country);
        }

        [TestMethod]
        public void Get_PersonInfoAddressSample_PostalCode_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.PersonInfoAddressSample();

            foo.PostalCode = "foo";
            Assert.AreEqual("foo", foo.PostalCode);

            foo.PostalCode = "foo2";
            Assert.AreEqual("foo2", foo.PostalCode);
        }

        [TestMethod]
        public void Get_PersonInfoAddressSample_StateProvince_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.address.sample.PersonInfoAddressSample();

            foo.StateProvince = "foo";
            Assert.AreEqual("foo", foo.StateProvince);

            foo.StateProvince = "foo2";
            Assert.AreEqual("foo2", foo.StateProvince);
        }

        [TestMethod]
        public void Get_BusinessCard_Name_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.businessCard.BusinessCard();

            foo.Name = "foo";
            Assert.AreEqual("foo", foo.Name);

            foo.Name = "foo2";
            Assert.AreEqual("foo2", foo.Name);
        }

        [TestMethod]
        public void Get_BusinessCard_Notes_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.businessCard.BusinessCard();

            foo.Notes = "foo";
            Assert.AreEqual("foo", foo.Notes);

            foo.Notes = "foo2";
            Assert.AreEqual("foo2", foo.Notes);
        }

        [TestMethod]
        public void Get_Company_FullName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.company.Company();

            foo.FullName = "foo";
            Assert.AreEqual("foo", foo.FullName);

            foo.FullName = "foo2";
            Assert.AreEqual("foo2", foo.FullName);
        }

        [TestMethod]
        public void Get_Company_Name_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.company.Company();

            foo.Name = "foo";
            Assert.AreEqual("foo", foo.Name);

            foo.Name = "foo2";
            Assert.AreEqual("foo2", foo.Name);
        }

        [TestMethod]
        public void Get_CompanyInfoSample_FullName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.company.sample.CompanyInfoSample();

            foo.FullName = "foo";
            Assert.AreEqual("foo", foo.FullName);

            foo.FullName = "foo2";
            Assert.AreEqual("foo2", foo.FullName);
        }

        [TestMethod]
        public void Get_CompanyInfoSample_Name_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.company.sample.CompanyInfoSample();

            foo.Name = "foo";
            Assert.AreEqual("foo", foo.Name);

            foo.Name = "foo2";
            Assert.AreEqual("foo2", foo.Name);
        }

        [TestMethod]
        public void Get_Contact_EmailAddress_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.Contact();

            foo.EmailAddress = "foo";
            Assert.AreEqual("foo", foo.EmailAddress);

            foo.EmailAddress = "foo2";
            Assert.AreEqual("foo2", foo.EmailAddress);
        }

        [TestMethod]
        public void Get_Contact_FirstName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.Contact();

            foo.FirstName = "foo";
            Assert.AreEqual("foo", foo.FirstName);

            foo.FirstName = "foo2";
            Assert.AreEqual("foo2", foo.FirstName);
        }

        [TestMethod]
        public void Get_Contact_LastName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.Contact();

            foo.LastName = "foo";
            Assert.AreEqual("foo", foo.LastName);

            foo.LastName = "foo2";
            Assert.AreEqual("foo2", foo.LastName);
        }

        [TestMethod]
        public void Get_Contact_MiddleName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.Contact();

            foo.MiddleName = "foo";
            Assert.AreEqual("foo", foo.MiddleName);

            foo.MiddleName = "foo2";
            Assert.AreEqual("foo2", foo.MiddleName);
        }

        [TestMethod]
        public void Get_Contact_Phone_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.Contact();

            foo.Phone = "foo";
            Assert.AreEqual("foo", foo.Phone);

            foo.Phone = "foo2";
            Assert.AreEqual("foo2", foo.Phone);
        }

        [TestMethod]
        public void Get_ContactInfoSample_EmailAddress_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.sample.ContactInfoSample();

            foo.EmailAddress = "foo";
            Assert.AreEqual("foo", foo.EmailAddress);

            foo.EmailAddress = "foo2";
            Assert.AreEqual("foo2", foo.EmailAddress);
        }

        [TestMethod]
        public void Get_ContactInfoSample_FirstName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.sample.ContactInfoSample();

            foo.FirstName = "foo";
            Assert.AreEqual("foo", foo.FirstName);

            foo.FirstName = "foo2";
            Assert.AreEqual("foo2", foo.FirstName);
        }

        [TestMethod]
        public void Get_ContactInfoSample_LastName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.sample.ContactInfoSample();

            foo.LastName = "foo";
            Assert.AreEqual("foo", foo.LastName);

            foo.LastName = "foo2";
            Assert.AreEqual("foo2", foo.LastName);
        }

        [TestMethod]
        public void Get_ContactInfoSample_MiddleName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.sample.ContactInfoSample();

            foo.MiddleName = "foo";
            Assert.AreEqual("foo", foo.MiddleName);

            foo.MiddleName = "foo2";
            Assert.AreEqual("foo2", foo.MiddleName);
        }

        [TestMethod]
        public void Get_ContactInfoSample_Phone_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.contact.sample.ContactInfoSample();

            foo.Phone = "foo";
            Assert.AreEqual("foo", foo.Phone);

            foo.Phone = "foo2";
            Assert.AreEqual("foo2", foo.Phone);
        }

        [TestMethod]
        public void Get_Person_FirstName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.person.Person();

            foo.FirstName = "foo";
            Assert.AreEqual("foo", foo.FirstName);

            foo.FirstName = "foo2";
            Assert.AreEqual("foo2", foo.FirstName);
        }

        [TestMethod]
        public void Get_Person_LastName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.person.Person();

            foo.LastName = "foo";
            Assert.AreEqual("foo", foo.LastName);

            foo.LastName = "foo2";
            Assert.AreEqual("foo2", foo.LastName);
        }

        [TestMethod]
        public void Get_Person_MiddleName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.person.Person();

            foo.MiddleName = "foo";
            Assert.AreEqual("foo", foo.MiddleName);

            foo.MiddleName = "foo2";
            Assert.AreEqual("foo2", foo.MiddleName);
        }

        [TestMethod]
        public void Get_PersonInfoSample_FirstName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.person.sample.PersonInfoSample();

            foo.FirstName = "foo";
            Assert.AreEqual("foo", foo.FirstName);

            foo.FirstName = "foo2";
            Assert.AreEqual("foo2", foo.FirstName);
        }

        [TestMethod]
        public void Get_PersonInfoSample_LastName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.person.sample.PersonInfoSample();

            foo.LastName = "foo";
            Assert.AreEqual("foo", foo.LastName);

            foo.LastName = "foo2";
            Assert.AreEqual("foo2", foo.LastName);
        }

        [TestMethod]
        public void Get_PersonInfoSample_MiddleName_EqualsAssignedValue()
        {
            var foo = new MasonApps.HRManager.models.person.sample.PersonInfoSample();

            foo.MiddleName = "foo";
            Assert.AreEqual("foo", foo.MiddleName);

            foo.MiddleName = "foo2";
            Assert.AreEqual("foo2", foo.MiddleName);
        }

    }
}