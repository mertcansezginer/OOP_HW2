namespace OOP_HW2
{
    public abstract class Shape   // Shape adinda bir base class olusturuyoruz, genel ozellikleri belirtiyoruz
    {
        
        private string color;     // Şeklin rengini tutmak için color adidan private bir string olusturuyoruz, encapsulation

       
        public Shape(string color) // Constructor method, Color ozelligine baslangic degeri atiyoruz.
        {
            Color = color;
        }


        public string Color { get; set; } //Color ozelligi get,set metodu ile color a ulasiyor, color alani direkt ulasima kapali, encapsulation

        public abstract double AreaCalculator(); // AreaCalculator metodunu cagiriyoruz, abstract cunku her seklin kendine ozgu alan hesabi ayri olarak belirtilecek.

        
        public virtual void Result() // Sonuc islemi yazilacak, virtual olarak belirtildi cunku her seklin kendine ozgu sonuc sekli farkli
        {                            //abstract da kullanilabilir, virtual isleyisini gormek icin yapildi, benzer sekilde polymorphism i.
            Console.WriteLine($"This is a {Color} shape.");
        }
    }
}
