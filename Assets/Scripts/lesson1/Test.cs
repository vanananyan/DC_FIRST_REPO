using UnityEngine;

namespace lesson1 
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private int value = 2;

        public void Set(int value) {
            this.value = value;
        }

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
            value++;
            Debug.Log(value);
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
            Debug.Log("OnDestroy");
        }
    }
}