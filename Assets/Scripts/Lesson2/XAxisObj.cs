using UnityEngine;

namespace Lesson2 
{
    public class XAxisObj : MonoBehaviour,iRotation
    {
        [SerializeField] private float rotateValue  = 0;

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

        public void rotate(float number) 
        {
            transform.Rotate(number, 0.0f, 0.0f); 
        }

        private void Update()
        {
            rotate(rotateValue);
        }
    }
}