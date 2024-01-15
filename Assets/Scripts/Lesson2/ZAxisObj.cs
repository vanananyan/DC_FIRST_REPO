using UnityEngine;

namespace Lesson2 
{
    public class ZAxisObj : MonoBehaviour,iRotation
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
            transform.Rotate(0.0f, 0.0f, number); 
        }

        private void Update()
        {
            rotate(rotateValue);
        }
    }
}