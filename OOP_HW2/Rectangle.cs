namespace OOP_HW2
{
    
    public class Rectangle : Shape  //inheritance yapiyoruz Shape class indan.
    {
        
        private double width;   //width ve height verilerini saklamak icin encapsulated field lar olusturduk.
        private double height;

        
        public Rectangle(string color, double width, double height) : base(color) //Constructor method
        {                                                            //Shape classindan inheritance yaptigimiz icin 
            Width = width;                                           //shape base class oluyor ve shape class inin constructor ini cagirabiliyoruz.
            Height = height;                                         // base yazarak inherit edilen classin constructor ini cagiriyoruz.
        }

        public double Width { get; set; } //auto-implementation islemi

        
        public double Height { get; set; } //auto-implementation 

        
        public override double AreaCalculator()  //AreaCalculator fonksiyonu yeniden tanimlaniyor ve override ediliyor mevcur metodun uzerine.
        {
            return Width * Height;
        }

        
        public override void Result()  //Polymorphism, Result metodunu override ediyoruz.
        {
            Console.WriteLine($"This is a {Color} rectangle with width {Width} and height {Height}. Area: {AreaCalculator()}");
        }
    }
}
