using UnityEngine;

public class Stoplight : MonoBehaviour
{
    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;

    [SerializeField] private int currentLight = 2;
    public float redInterval = 5f; // interval between red light and green light
    public float yellowInterval = 2f; // interval for the yellow light
    public float greenInterval = 6f; // interval for the yellow light
    private readonly string changeLightMethodName = nameof(ChangeLight);

    void Start()
    {
        InvokeRepeating(changeLightMethodName, 0, redInterval);
    }

    void ChangeLight()
    {
        CancelInvoke(changeLightMethodName);
        var interval = redInterval;
        if (currentLight == 0)
        {
            
            redLight.SetActive(false);
            yellowLight.SetActive(false);
            greenLight.SetActive(true);
            interval = greenInterval;
        }
        else if (currentLight == 1)
        {
            redLight.SetActive(false);
            yellowLight.SetActive(true);
            greenLight.SetActive(false);
            interval = yellowInterval;
        }
        else if (currentLight == 2)
        {
            redLight.SetActive(true);
            yellowLight.SetActive(false);
            greenLight.SetActive(false);
            interval = redInterval;
        }
        currentLight = (currentLight + 1) % 3;
        Invoke(changeLightMethodName, interval);
    }
}
