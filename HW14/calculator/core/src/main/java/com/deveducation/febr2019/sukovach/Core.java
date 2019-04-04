package com.deveducation.febr2019.sukovach;
import  java.util.Scanner;

public class Core implements Calculable {

   private double result;

    public void calculate (){

        Scanner scanner = new Scanner(System.in);
        System.out.println("Input first Number: ");
        double firstNumber = scanner.nextDouble();

        System.out.println("Input operator: ");
        char operator = scanner.next().trim().charAt(0);

        System.out.println("Input second Number: ");
        double secondNumber = scanner.nextDouble();

        switch (operator){
            case '+':
                addition(firstNumber, secondNumber);
                break;
            case '-':
                subtraction(firstNumber, secondNumber);
                break;
            case '*':
                multiplication(firstNumber, secondNumber);
                break;
            case '/':
                division(firstNumber, secondNumber);
                break;
            default:
                System.out.println("Illegal operator");
        }
        System.out.println( firstNumber + " " + operator + " " + secondNumber  + "  = " + result );

    }


    public double addition(double a, double b){
        result = a + b;
        return result;
    }
    public double subtraction(double a, double b){
        result = a - b;
        return result;
    }
    public double multiplication(double a, double b){
        result = a * b;
        return result;
    }
    public double division(double a, double b){
        try {
            if (b == 0) throw new ArithmeticException();
            result = a / b;
        } catch(ArithmeticException e){
            System.out.println("Forbidden operation. Division by zero!");
            System.exit(0);
        }
        return result;
    }

    public double mysqrt(double a) {
        double t;
        double squareRoot = a / 2;
        do {
            t = squareRoot;
            squareRoot = (t + (a / t)) / 2;
        } while ((t - squareRoot) != 0);
        return squareRoot;
    }

    public double reverse(double a){
        return a*(-1);
    }

}
