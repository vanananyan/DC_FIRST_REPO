using UnityEngine;

namespace Lesson2 
{
    public class YAxisObj2 : Base
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