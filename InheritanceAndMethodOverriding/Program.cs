namespace InheritanceAndMethodOverriding
{
    class Animal
    {
        // add virtual keyword to allow for method overriding
        public virtual void MakeSound() {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // animal sound
            animal.MakeSound();

            // dog sound
            dog.MakeSound();

            // cat sound
            cat.MakeSound();

            Console.WriteLine("Hello, World!");
        }
    }
}
