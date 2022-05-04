using System;
using System.Runtime.Serialization;

namespace UnitTestingXUnitIntro
{
 
    public class EmailNotProvidedException : Exception
    {
        public override string Message => "Email can't be empty";
    }
}