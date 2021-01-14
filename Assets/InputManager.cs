using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public TMP_InputField input1;
    public TMP_InputField input2;
    public TextMeshProUGUI resultText;

    // exercise 1
    public void HelloWorld()
    {
        // TODO: print "Hello World!" with PrintAnswer method,
        // usage:
        // string TheAnswerAsString;
        // TheAnswerAsString = "asdf"    // store the answer in the variable
        // PrintAnswer(TheAnswerAsString);

        string result;
        result = "Hello World";

        PrintAnswer(result);
    }

    // exercise 2
    public void HelloYou()
    {
        string inputText = input1.text;

        // TODO: print "Hello {name}" with PrintAnswer method

        string result = "Hello " + inputText;

        PrintAnswer(result);
    }

    // exercise 3
    public void MultiplyByTwo()
    {
        int inputNumber = int.Parse(input1.text);   // 12
        // int inputNumber = int.Parse("12");
        // int inputNumber = 12;

        // TODO: multiply inputNumber by two and print out

        int solution = inputNumber * 2;
        // int solution = 12 * 2;
        // int solution = 24;

        PrintAnswer(solution.ToString());
    }

    // exercise 4
    public void IsBigger()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);

        // TODO: print out, whether the first number is bigger (true/false)

        bool result = inputNumber1 > inputNumber2;
        PrintAnswer(result.ToString());
    }

    // exercise 5
    public void ChangeSpeed()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: input is km/h, print out m/s
        float result = inputNumber1 / 3.6f;
        PrintAnswer(result.ToString());
    }

    // exercise 6
    public void PowerOf()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: print out the value of the input to the second power
        int result = inputNumber1 * inputNumber1;
        PrintAnswer(result.ToString());
    }

    // exercise 7
    public void FahrenheitToCelsius()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: change fahrenheit ti celsius
        float result = (inputNumber1 - 32) / 1.8f;
        PrintAnswer(result.ToString());
    }

    // exercise 8
    public void Modulo()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);

        // TODO print out inputNumber1 modulo inputNumber2
        int result = inputNumber1 % inputNumber2;
        PrintAnswer(result.ToString());
    }

    // exercise 9
    public void ChangeType()
    {
        float inputNumber1 = float.Parse(input1.text);

        // TODO: change float to int and print it out
        int result = (int)inputNumber1;
        PrintAnswer(result.ToString());
    }

    // exercise 10
    public void ChangeVariables()
    {
        int inputNumber1 = int.Parse(input1.text);  // 3
        int inputNumber2 = int.Parse(input2.text);  // 5

        // TODO: change the values of inputNumber1 and inputNumber2 without using an additional variable
        inputNumber1 = inputNumber1 + inputNumber2; // 8
        inputNumber2 = inputNumber1 - inputNumber2; // 8 - 5 = 3
        inputNumber1 = inputNumber1 - inputNumber2; // 8 - 3 = 5

        PrintAnswer("number 1: " +inputNumber1 + "\nnumber 2: " + inputNumber2);
    }

    public void IWantMoreExercises()
    {
        // TODO: ask for more exercises, if you are done with everything
    }

    // a helper method to show the result in the console and in resultText
    public void PrintAnswer(string solution)
    {
        Debug.Log(solution);
        resultText.text = solution;
    }
}
