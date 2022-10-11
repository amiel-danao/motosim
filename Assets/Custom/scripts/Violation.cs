using UnityEngine;

[CreateAssetMenu(fileName = "Violation", menuName = "New Violation")]
public class Violation : ScriptableObject
{
    [SerializeField] private string _violationName;
    [SerializeField] private string _violationMessage;
    public string ViolationName => _violationName;
    public string ViolationMessage => _violationMessage;

}