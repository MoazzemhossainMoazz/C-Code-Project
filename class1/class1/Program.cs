class Program
{
    static void Main()
    {
        Circle c =new Circle(2, 4, 6);
        c.sum(3, 8);
      
       


    }
}
class Circle
{
    public int x=0, y=0, z=0;
    public Circle(int x, int y, int z)

    {
       
       Console.WriteLine(x.ToString());
       Console.WriteLine(this.x.ToString());
    }
    public void sum(int x,int y) {
        this.x = x;
        Console.WriteLine(x.ToString());
        Console.WriteLine(this.x.ToString());


    }
   
    
 

}