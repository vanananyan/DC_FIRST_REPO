using UnityEngine;

namespace Lesson2 
{
    public class YAxisObj1 : BaseAbstract
    {
        protected override void rotate(float number) 
        {
            transform.Rotate(0.0f, number, 0.0f); 
        }
        protected void Update()
        {
            rotate(rotateValue);
        }
    }
}