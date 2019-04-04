package com.deveducation.febr2019.sukovach;
import junit.framework.Assert;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class TestCore {

    private Core core;

    @Before
    public void run(){
        core = new Core();
    }
    @After
    public void stop(){
        core = null;
    }

    @Test
    public void testAddition(){
        double testResult = core.addition(2,2);
        Assert.assertTrue(testResult == 4);
    }

    @Test
    public void testAddition_001(){
        double a = 2;
        double b = 3;
        double expectedResult = 5;
        double testResult = core.addition(a, b);
        Assert.assertEquals(expectedResult, testResult, 0);
    }

    @Test
    public void testAddition_002(){
        double a = 0;
        double b = 3;
        double expectedResult = 3;
        double testResult = core.addition(a, b);
        Assert.assertEquals(expectedResult, testResult, 0);
    }

    @Test
    public void testAddition_003(){
        double a = -9;
        double b = 3;
        double expectedResult = -6;
        double testResult = core.addition(a, b);
        Assert.assertEquals(expectedResult, testResult, 0);
    }

    @Test
    public void testSubtraction(){
        double testResult = core.subtraction(2,2);
        if(testResult != 0.0) { Assert.fail();}
    }
    @Test
    public void testMultiplication(){
        double testResult = core.multiplication(2,2);
        if(testResult != 4) { Assert.fail();}
    }
    @Test
    public void testDivision001(){
        double testResult = core.division(2,2);
        if(testResult != 1) { Assert.fail();}
    }

    @Test
    public void testDivision002(){
        double testResult = core.division(0,2);
        if(testResult != 0) { Assert.fail();}
    }

    @Test
    public void testDivision003(){
        double testResult = core.division(6,3);
        if(testResult != 2) { Assert.fail();}
    }

    @Test
    public void testDivision004(){
        double testResult = core.division(3.14,2);
        if(testResult != 1.57) { Assert.fail();}
    }

    @Test
    public void testDivision005(){
        double testResult = core.division(0.4,3);
        double expectedResult = 0.13;
        Assert.assertEquals(expectedResult, testResult, 0.03);

    }

    @Test
    public void testDivision006() {
        double a = 1.2;
        double b = 0;
        Object result = new ArithmeticException();
        Object fact = new Core().division(a, b);
        Assert.assertEquals(result, fact);
    }

    @Test
    public void test_square_roo()
    {
        double a = 16;
        double result = 4;
        double fact = core.mysqrt(a);
        Assert.assertEquals(fact, result, 0);

    }

    @Test
    public void testReverse(){
        double a = 5;
        double expectedResult = -5;
        double testResult = core.reverse(a);
        Assert.assertEquals(expectedResult, testResult, 0);
    }
}

