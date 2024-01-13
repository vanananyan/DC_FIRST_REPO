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
            ResetValue(ref rotateValue.x);
            ResetValue(ref rotateValue.y);
            ResetValue(ref rotateValue.z);
            transform.rotation = Quaternion.Euler(rotateValue.x,rotateValue.y,rotateValue.z);
        }

        private void ResetValue(ref float number) 
        {
            if (number > 180)
            {
                number = number - 360;
            }
            else if(number < -180) 
            {
                number = number + 360;
            }
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