using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD1.VD5
{
    // VD5: Viết một chương trình tạo lớp Animal với phương thức ảo MakeSound(). Tạo các lớp con
    // Dog và Cat kế thừa từ lớp Animal, triển khai phương thức MakeSound(). Tạo đối tượng
    // của các lớp con và gọi phương thức MakeSound()
    internal abstract class Animal
    {
        public abstract void MakeSound();

    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat speak MewMew !");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog speak Go Gow!");
        }
    }
}
