using UnityEngine;

namespace Lesson2 
{
    public class YAxisObj : MonoBehaviour,iRotation
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
            transform.Rotate(0.0f, number, 0.0f); 
        }

        private void Update()
        {
            rotate(rotateValue);
        }
    }
}