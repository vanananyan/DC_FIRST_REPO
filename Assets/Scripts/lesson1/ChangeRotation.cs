using UnityEngine;

namespace lesson1 
{
    public class ChangeRotation : MonoBehaviour
    {
        [SerializeField] private Vector3 rotateValue  = Vector3.zero;

        private void Awake()
        {
            Debug.Log("Awake");
        }
        private void OnEnable()
        {
            Debug.Log("OnEnable");
        }
        private void Start()
        {
            Debug.Log("Start");
        }
        private void Update()
        {
            if (rotateValue.x >= 180)
            {
                rotateValue.x = rotateValue.x - 360;
            }
            else if(rotateValue.x <= -180) 
            {
                rotateValue.x = rotateValue.x + 360;
            }
            if (rotateValue.y >= 180)
            {
                rotateValue.y = rotateValue.y - 360;
            }
            else if(rotateValue.y <= -180) 
            {
                rotateValue.y = rotateValue.y + 360;
            }
            if (rotateValue.z >= 180)
            {
                rotateValue.z = rotateValue.z - 360;
            }
            else if(rotateValue.z <= -180) 
            {
                rotateValue.z = rotateValue.z + 360;
            }
            transform.rotation = Quaternion.Euler(rotateValue.x,rotateValue.y,rotateValue.z);
        }
        private void OnDisable()
        {
            Debug.Log("OnDisable");
        }
        private void FixedUpdate()
        {
            
        } 
        private void LateUpdate()
        {
            
        }
        private void OnDestroy()
        {

        }
    }
}