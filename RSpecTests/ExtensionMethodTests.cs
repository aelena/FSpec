using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;


namespace RSpecTests
{
    [TestClass]
    public class ExtensionMethodTests
    {
        [TestMethod]
        public void Test_Should_Equal ()
        {
            object first = new object ();
            object second = first;
            Assert.IsTrue ( first.should_equal ( second ), "first was not equal to second when it should have been..." );
        }

        [TestMethod]
        public void Test_Should_Not_Equal ()
        {
            object first = new object ();
            object second = new object ();
            Assert.IsTrue ( first.should_not_equal ( second ), "first was equal to second when it should have not been..." );
        }

        [TestMethod]
        public void Test_Should_Be_Same_As ()
        {
            object first = new object ();
            object second = first;
            Assert.IsTrue ( first.should_be_same_as ( second ), "first was not equal to second when it should have been..." );
        }

        [TestMethod]
        public void Test_Should_Not_Be_Same_As ()
        {
            object first = new object ();
            object second = new object ();
            Assert.IsTrue ( first.should_not_be_same_as ( second ), "first was equal to second when it should have not been..." );
        }

        [TestMethod]
        public void Test_Object_Should_Contain_Part_Of_Type_Name ()
        {
            object first = new object ();
            Assert.IsTrue ( first.should_contain ( "Object" ) );
        }

        [TestMethod]
        public void Test_Object_Should_Not_Contain_Arbitrary_String ()
        {
            object first = new object ();
            Assert.IsFalse ( first.should_contain ( "foobarez" ) );
        }

        [TestMethod]
        public void Test_Objects_With_Default_ToString_Implementation_Should_Have_Same_Value ()
        {
            object first = new object ();
            object second = new object ();
            Assert.IsTrue ( first.should_have_same_value ( second.ToString () ) );
        }

        [TestMethod]
        public void Test_String_Should_Have_Same_Value ()
        {
            string first = "Hello";
            string second = "Hello";
            Assert.IsTrue ( first.should_have_same_value ( second.ToString () ) );
        }

        [TestMethod]
        public void Test_Null_Object_Should_Be_Null ()
        {
            string first = null;
            Assert.IsTrue ( ShouldExtensions.should_be_null ( first ) );
        }

        [TestMethod]
        public void Test_Not_Null_Object_Should_Not_Be_Null ()
        {
            object first = new object ();
            Assert.IsTrue ( ShouldExtensions.should_not_be_null ( first ) );
        }

        [TestMethod]
        public void Test_Newly_Created_System_Object_Should_Be_Empty ()
        {
            Object obj = new Object ();
            Assert.IsTrue ( obj.should_be_empty () );
        }

        [TestMethod]
        public void Test_Newly_Created_Hashtable_Should_Be_Empty ()
        {
            Hashtable ht = new Hashtable ();
            Assert.IsTrue ( ht.should_be_empty () );
        }

        [TestMethod]
        public void Test_Newly_Created_Empty_String_Should_Be_Empty ()
        {
            String st = String.Empty;
            Assert.IsTrue ( st.should_be_empty () );
        }

        [TestMethod]
        public void Test_String_With_Value_Should_Not_Be_Empty ()
        {
            String st = "I am a string or so they say...";
            Assert.IsFalse ( st.should_be_empty () );
        }

        [TestMethod]
        public void Test_Value_Type_Int_Should_Not_Be_Empty ()
        {
            int a = 1;
            Assert.IsFalse ( a.should_be_empty () );
        }

        [TestMethod]
        public void Test_Value_Type_Float_Should_Not_Be_Empty ()
        {
            float b = 1.1F;
            Assert.IsFalse ( b.should_be_empty () );
        }

        [TestMethod]
        public void Test_Value_Type_Long_Should_Not_Be_Empty ()
        {
            long c = Int64.MaxValue;
            Assert.IsFalse ( c.should_be_empty () );
        }



        // FIX THIS : MUST DO SHOULDS FOR REFERENCE EQUALITY AND SHOULDS FOR REPRESENTATION EQUALITY
        //[TestMethod]
        //public void Test_Two_String_With_Same_Value_Should_Not_Be_Equal()
        //{
        //    string first = "Hello";
        //    string second = "Hello";
        //    Assert.IsFalse(first.should_equal(second.ToString()));
        //}


    }
}
