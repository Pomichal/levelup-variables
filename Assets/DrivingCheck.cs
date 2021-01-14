using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DrivingCheck : MonoBehaviour
{

    public Toggle hasDriverLicenceToggle;
    public Toggle withResponsivePersonToggle;
    public Toggle withInstructorToggle;

    public TMP_InputField ageInput;

    public TextMeshProUGUI resultText;

    public void CheckDriving()
    {
        bool hasLicence = hasDriverLicenceToggle.isOn;
        bool withResponsivePerson = withResponsivePersonToggle.isOn;
        bool withInstructor = withInstructorToggle.isOn;

        int age = int.Parse(ageInput.text);

        // TODO: print out, whether the person may drive a car (in Slovakia)
        bool result = withInstructor || (hasLicence && age >= 18) || (hasLicence && withResponsivePerson && age >=17);
        PrintResult(result.ToString());
    }

    public void PrintResult(string result)
    {
        resultText.text = result;
    }
}
