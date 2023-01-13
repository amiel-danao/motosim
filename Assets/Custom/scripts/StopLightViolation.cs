using System.Collections;
using UnityEngine;

namespace Assets.Custom.scripts
{
    public class StopLightViolation : InGameViolation
    {
        [SerializeField] private MotorbikeController _motorbikeController;
        [SerializeField] private Stoplight _stopLight;

        public override void Violate()
        {
            if (_nextViolationTimeOffset <= 0f)
            {
                if (_stopLight.redLight.activeSelf)
                {
                    base.Violate();
                }
            }
        }
    }
}