using System.Collections;
using UnityEngine;

public class StopViolation : InGameViolation
{
    private bool _stopped;
    private MotorbikeController _motorbikeController;
    [SerializeField] private ScoreViolation _scoreViolation;

    public void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out MotorbikeController controller))
        {
            _motorbikeController = controller;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (_motorbikeController == null)
            return;
        if(other.gameObject == _motorbikeController.gameObject)
        {
            if (_motorbikeController.rb.velocity.magnitude <= 2f)
            {
                _stopped = true;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out MotorbikeController controller))
        {
            if (controller != _motorbikeController)
                return;
            _motorbikeController = null;
            if(_stopped == false)
            {
                ViolateStop();
            }
            else
            {
                _scoreViolation.GiveScore();
            }
        }
    }

    private void ViolateStop()
    {
        ViolationUI.Instance.ShowViolation(_violation);
        Time.timeScale = 0f;
        _nextViolationTimeOffset = 2f;
    }

    public override void Violate()
    {
        
    }
}