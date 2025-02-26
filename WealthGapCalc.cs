using TMPro;
using UnityEngine;

public class WealthGapCalc : MonoBehaviour
{
    [SerializeField] private TMP_InputField minWageInput;
    [SerializeField] private TMP_InputField avgWageInput;
    [SerializeField] private TMP_InputField stampCostInput;
    [SerializeField] private TextMeshProUGUI hourlyStampsTxt;
    [SerializeField] private TextMeshProUGUI wealthGapPercentTxt;

    private float minWage;
    private float avgWage;
    private float stampCost;
    private float wealthGapPercentage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Optionally initialize values here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Convert TMP_InputField values to floats
        if (float.TryParse(minWageInput.text, out minWage) && minWage > 0)
        {
            // Successfully converted minWageInput text to a float
        }
        else
        {
            Debug.LogWarning("Invalid input for minWage.");
        }

        if (float.TryParse(avgWageInput.text, out avgWage) && avgWage > 0)
        {
            // Successfully converted avgWageInput text to a float
        }
        else
        {
            Debug.LogWarning("Invalid input for avgWage.");
        }

        if (float.TryParse(stampCostInput.text, out stampCost))
        {
            // Successfully converted stampCostInput text to a float
        }
        else
        {
            Debug.LogWarning("Invalid input for stampCost.");
        }

        // Calculate wealth gap percentage
        if (minWage > 0)
        {
            wealthGapPercentage = ((avgWage - minWage) / avgWage) * 100;
            Debug.Log($"Wealth Gap Percentage: {wealthGapPercentage}%");
        }
        else
        {
            Debug.LogWarning("Cannot calculate wealth gap: minWage must be greater than zero.");
        }

        float minWageStamps = minWage / stampCost;
        float avgWageStamps = avgWage / stampCost;
        hourlyStampsTxt.text = "Min Wage Stamps/Hr = " + minWageStamps + "\n" + "Avg Wage Stamps/Hr = " + avgWageStamps;
        wealthGapPercentTxt.text = "Wealth Gap = " + wealthGapPercentage.ToString("n2") + "%";
    }
}
