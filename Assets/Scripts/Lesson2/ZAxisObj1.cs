using UnityEngine;

namespace Lesson2 
{
    public class ZAxisObj1 : BaseAbstract
    {
        protected override void rotate(float number) 
        {
            transform.Rotate(0.0f, 0.0f, number); 
        }
        protected void Update()
        {
            rotate(rotateValue);
        }
    }
}