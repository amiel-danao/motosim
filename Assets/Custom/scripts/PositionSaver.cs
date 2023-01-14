using System.Collections;
using UnityEngine;

namespace Assets.Custom.scripts
{
    public class PositionSaver : MonoBehaviour
    {

        // Use this for initialization
        void Awake()
        {
            var savedPosition = transform.position;
            if (PlayerPrefs.HasKey("x"))
            {
                savedPosition.x = PlayerPrefs.GetFloat("x");
            }
            if (PlayerPrefs.HasKey("y"))
            {
                savedPosition.x = PlayerPrefs.GetFloat("y");
            }
            if (PlayerPrefs.HasKey("z"))
            {
                savedPosition.x = PlayerPrefs.GetFloat("z");
            }


            var savedRotation = transform.rotation.eulerAngles;
            if (PlayerPrefs.HasKey("rx"))
            {
                savedRotation.x = PlayerPrefs.GetFloat("rx");
            }
            if (PlayerPrefs.HasKey("ry"))
            {
                savedRotation.x = PlayerPrefs.GetFloat("ry");
            }
            if (PlayerPrefs.HasKey("ry"))
            {
                savedRotation.x = PlayerPrefs.GetFloat("rz");
            }

            transform.SetLocalPositionAndRotation(savedPosition, Quaternion.Euler(savedRotation));
        }

        // Update is called once per frame
        public void Save()
        {
            var position = transform.position;

            PlayerPrefs.SetFloat("x", position.x);
            PlayerPrefs.SetFloat("y", position.y);
            PlayerPrefs.SetFloat("z", position.z);

            var rotation = transform.rotation.eulerAngles;
            PlayerPrefs.SetFloat("rx", rotation.x);
            PlayerPrefs.SetFloat("ry", rotation.y);
            PlayerPrefs.SetFloat("rz", rotation.z);

            PlayerPrefs.Save();
        }
    }
}