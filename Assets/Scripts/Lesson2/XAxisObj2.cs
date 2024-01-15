using UnityEngine;

namespace Lesson2 
{
    public class XAxisObj2 : Base
    {
        protected override void rotate(float number) 
        {
            transform.Rotate(number, 0.0f, 0.0f); 
        }
        protected void Update()
        {
            rotate(rotateValue);
        }
    }
}