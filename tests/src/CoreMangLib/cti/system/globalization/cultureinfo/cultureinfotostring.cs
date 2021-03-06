using System;
using System.Globalization;
using TestLibrary;

/// <summary>
///ToString
/// </summary>
public class CultureInfoToString
{
    public static int Main()
    {
        CultureInfoToString CultureInfoToString = new CultureInfoToString();

        TestLibrary.TestFramework.BeginTestCase("CultureInfoToString");
        if (CultureInfoToString.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        if (!Utilities.IsWindows)
        {
            // Neutral cultures not supported on Windows
            retVal = PosTest2() && retVal;
        }
        retVal = PosTest3() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: CultureTypes.SpecificCultures");
        try
        {
            string expectName = "en-US";
            CultureInfo myCultureInfo = new CultureInfo(expectName);
            if (expectName != myCultureInfo.ToString())
            {
                TestLibrary.TestFramework.LogError("001", "ToString method should return " + expectName);
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest2: CultureTypes.NeutralCultures");
        try
        {
            string expectName = "en";
            CultureInfo myCultureInfo = new CultureInfo(expectName);
            if (expectName != myCultureInfo.ToString())
            {
                TestLibrary.TestFramework.LogError("003", "ToString method should return " + expectName);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest3()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest3: invariant culture ");
        try
        {
            string expectName = "";
            CultureInfo myCultureInfo = new CultureInfo(expectName);
            if (expectName != myCultureInfo.ToString())
            {
                TestLibrary.TestFramework.LogError("005", "ToString method should return " + expectName);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
  
}

