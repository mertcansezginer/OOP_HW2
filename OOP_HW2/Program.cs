namespace OOP_HW2
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rectangle = new Rectangle("red", 8, 6);  // Rectangle ve Circle icin instance lar olusuturulur
            Circle circle = new Circle("yellow", 3.5);

            
            Shape[] shapes = new Shape[] { rectangle, circle }; // Polymorphism: Storing Rectangle and Circle objects in a Shape array

            foreach (Shape shape in shapes)
            {
                shape.Result();
            }
        }
    }
}
