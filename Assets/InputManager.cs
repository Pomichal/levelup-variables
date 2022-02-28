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
    }

    // exercise 2
    public void HelloYou()
    {
        string inputText = input1.text;

        // TODO: print "Hello {name}" with PrintAnswer method
    }

    // exercise 3
    public void MultiplyByTwo()
    {
        int inputNumber = int.Parse(input1.text);

        // TODO: multiply inputNumber by two and print out
    }

    // exercise 4
    public void IsBigger()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);

        // TODO: print out, whether the first number is bigger (true/false)
    }

    // exercise 5
    public void ChangeSpeed()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: input is km/h, print out m/s
    }

    // exercise 6
    public void PowerOf()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: print out the value of the input to the second power
    }

    // exercise 7
    public void FahrenheitToCelsius()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: change fahrenheit ti celsius
    }

    // exercise 8
    public void Modulo()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);

        // TODO print out inputNumber1 modulo inputNumber2
    }

    // exercise 9
    public void ChangeType()
    {
        float inputNumber1 = float.Parse(input1.text);

        // TODO: change float to int and print it out
    }

    // exercise 10
    public void ChangeVariables()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);

        // TODO: change the values of inputNumber1 and inputNumber2 without using an additional variable
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
