namespace Calculator {
  class Program {
    static void Main(string[] args) {
      
    }
    private static int Total = 0;

    public static int Add (int num)
    {
      return Total += num;
    }

    public static int Subtract(int num)
    {
      return Total -= num;

    }

    public static int Multiply(int num)
    {
      return Total *= num;
    }

    public static int Divide(int num)
      
    {
      if(num == 0) return 0;  
      return Total /= num; 
    }

    public static void ResetTotal () 
    {
      Total = 0;  
    }
  }
}