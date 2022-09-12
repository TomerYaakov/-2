using System;

class Program {
  public static void Main (string[] args) {
    int x = -5;
    int y = 0;
    while (x <= 0) {
      y = x*x;
      int space = x;
      int forspace = -5;
      int hight = 0;
      forSpace(forspace, x, y);
      Console.Write(-y);
      Space(space, x);
      if(x !=0) {
      Console.WriteLine(y);
      }
      // Hight(hight, y);
      x++;
    }
    
  }
  private static void Space(int space, int x) {
    while(space < Math.Abs(x) - 1) {
     Console.Write(" ");
     space++; 
    }
  }
  private static void forSpace(int forspace, int x, int y) {
    if(y < 10) {
      while(forspace < x + 1) {
       Console.Write(" ");
        if(x == 0 && forspace == -1) {
          Console.Write(" ");
        }
       forspace++;
      }
    }
    else {
      while(forspace < x) {
       Console.Write(" ");
       forspace++;
      }
    }
  }
  private static void Hight(int hight, int y) {
    while(hight < y) {
     Console.WriteLine(" ");
     hight++;
    }
  }
  
}
