using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = NUnit.Framework.Assert;

public class FirstTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void FirstTestSimplePasses()
    {
        Assert.IsTrue(true);
    }
    
    [Test]
    public void FirstTestSimplePassesa()
    {
        Assert.IsTrue(true);
    }


}
