class Program {
    static void Main() {
        int width = 10;
        int height = 20;
        int area = CalculateArea(width,height);

        Console.WriteLine($"Area: {area}");
        
        if (area >= 50 && area <= 100){
            Console.WriteLine("The area is medium.");
        }
        else if(area > 100){
            Console.WriteLine("The area is large");
        }
        else{
            Console.WriteLine("The area is small.");
        }
    }

    static int CalculateArea(int width, int height){
        return width * height;
    } 

}