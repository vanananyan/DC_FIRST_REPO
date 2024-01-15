using UnityEngine;

namespace Lesson2
{
    public class Base : MonoBehaviour
    {
        [SerializeField] protected int rotateValue = 2;

        protected void Awake()
        {
            Debug.Log("Awake");
        }
        protected void OnEnable()
        {
            Debug.Log("OnEnable");
        }
        protected void Start()
        {
            Debug.Log("Start");
        }
        protected virtual void rotate(float number)
        {
            Debug.Log("Rotate");
        }
        protected void OnDisable()
        {
            Debug.Log("OnDisable");
        }
        protected void OnDestroy()
        {
            Debug.Log("OnDestroy");
        }
    }
}