using System.Collections.Generic;
using UnityEngine;

namespace Assets.Custom.scripts
{
    public class NoRightTurn : InGameViolation
    {
        [SerializeField] private Collider _motorbikeCollider;
        [SerializeField] private ViolationDetector _motorbikeViolationDetector;
        [SerializeField] private BoxCollider boxFirstArea;
        [SerializeField] private Collider[] otherColliders;
        [SerializeField] private Road wrongRoad;
        [SerializeField] private KeyCode restrictedKey = KeyCode.D;

        public override void Violate()
        {
            if (_nextViolationTimeOffset <= 0f)
            {
                if (Input.GetKey(restrictedKey))
                {
                    base.Violate();
                }
                else if (_motorbikeViolationDetector.LastRoad == wrongRoad)
                {                    
                    /*Collider[] colliders = Physics.OverlapBox(boxFirstArea.transform.position, boxFirstArea.transform.localScale / 2, boxFirstArea.transform.rotation);
                    var colliderList = new List<Collider>();
                    colliderList.AddRange(colliders);

                    foreach (var item in otherColliders)
                    {
                        if (!colliderList.Contains(item))
                        {
                            return;
                        }
                    }*/

                    base.Violate();
                }
            }
            
        }
    }
}