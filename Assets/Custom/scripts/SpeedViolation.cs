using System.Collections;
using UnityEngine;

public class SpeedViolation : InGameViolation
{
    [SerializeField] private MotorbikeController _motorbikeController;
    public override void Violate()
    {
        if (_nextViolationTimeOffset > 0f)
            return;
        if (_motorbikeController.rb.velocity.magnitude * 2 >= 50f)
        {            
            ViolationUI.Instance.ShowViolation(_violation);
            Time.timeScale = 0f;
            _nextViolationTimeOffset = 1f;
        }
        
    }
}