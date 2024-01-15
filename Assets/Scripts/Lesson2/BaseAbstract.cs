using UnityEngine;

namespace Lesson2
{
    public abstract class BaseAbstract : MonoBehaviour
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
        protected abstract void rotate(float number);
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