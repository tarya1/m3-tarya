using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField left;
    public InputField right;
    public Text EqualsText;
    public void calculate()
    {
        int leftHandSide = 0;
        int leftNumber = 0;
        bool success = int.TryParse(left.text, out leftNumber);
        if (success)
        {
            leftHandSide = leftNumber;
            
        }
        success = false;
        int rightHandSide = 0;
        int rightNumber = 0;
        success = int.TryParse(right.text, out rightNumber);
        if (success)
        {
            rightHandSide = rightNumber;
        }

        int equals = leftHandSide + rightHandSide;
        EqualsText.text = "" + equals;

    }

}
