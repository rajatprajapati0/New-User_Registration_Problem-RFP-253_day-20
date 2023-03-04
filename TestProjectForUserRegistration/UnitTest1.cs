using User_Registration;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace TestProjectForUserRegistration
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
  
        //ex. riht password 
        [TestCase("a@ahAdkdkf06")]
        [TestCase("raJjat@121")]
        [TestCase("121A+*deepak121")]
        [TestCase("sbjfjdJfjfsks*fjd09")]
        
        //ex. wrong password 
        [TestCase("a9a04#121")]
      



        public void TestPassword(string input)
        {
            var password = new RegistrationForm();
           
            bool expect = true;
            var act = password.Password(input);
            Assert.AreEqual(expect, act);
        }



        //ex. right mobile no.
        [TestCase("+91 6895646469")]

        //ex. wrong mobile no.
        [TestCase("+91 756656560000")]

        public void testnumber(string input)
        {
            var number= new RegistrationForm();
            bool expact = true;
            var act = number.MobileNumber(input);
            Assert.AreEqual(expact, act);
        }

       
         //ex.right email     
        [TestCase("abc@yahoo.com")]
        [TestCase("abc@1.com")]
        [TestCase("rajat90@gamail.com")]
        [TestCase("abc111 @abc.com")]
        [TestCase("abc-100 .@abc.net")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("deepm7987@gmail.com")]
        [TestCase("abc @gmail.com.com")]
        [TestCase("abc 100@gmail.com")]
        [TestCase("abc-100@yahoo.com")]
        [TestCase("+abc.100@yahoo.com")]
        [TestCase("abc+.100@yahoo.com")]

        //ex. wrong Email 
        [TestCase("abc@.com.my")]
        [TestCase(".abc123@gmail.a")]
        [TestCase(".abc123@.com")]
        [TestCase(".abc@abc.com")]
        [TestCase("abc()*@gmail.com")]
        [TestCase("abc@%*.com –")]
        [TestCase("abc..2002@gmail.com")]
        [TestCase("abc.@gmail.com.")]
        [TestCase("abc@abc@gmail.com")]
        [TestCase("abc@gmail.com.1a")]
        [TestCase("abc@gmail.com.aa.au")]

        public void TestemailID(string input)
        {
            var email = new RegistrationForm();
            bool expect = true;

            
            var act = email.Email(input);

            Assert.AreEqual(expect, act);
        }


    }
}