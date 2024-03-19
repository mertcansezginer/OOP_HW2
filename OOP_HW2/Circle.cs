namespace OOP_HW2
{
    
    public class Circle : Shape  //inheritance yapiyoruz Shape class indan.
    {
        
        private double radius; //radius verisini saklamak icin encapsulated field lar olusturduk.

        
        public Circle(string color, double radius) : base(color) //constructor method
        {                                                        //Shape classindan inheritance yaptigimiz icin
            Radius = radius;                                     // base yazarak inherit edilen classin constructor ini cagiriyoruz.
        }

        
        public double Radius { get; set; } //radius degerine encapsulation yapoildi, devaminda auto-implemente edildi.

        public override double AreaCalculator()  //AreaCalculator metodu override edildi.
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        
        public override void Result()   //Polymorphism, Result metodunu override ediyoruz.
        {
            Console.WriteLine($"This is a {Color} circle with radius {Radius}. Area: {AreaCalculator()}");
        }
    }
}
