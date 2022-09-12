using System;

class Program {
  public static void Main (string[] args) {
    int x = -4;
    int temp = x;
    int y = 0;
    while (x <= 0) {
      y = x*x - 2;
      int space = x;
      int forspace = temp;
      int hight = 0;
      forSpace(forspace, x, y);
      Console.Write(-y);
      Space(space, x);
      if(x != 0) {
      Console.WriteLine(y);
      }
      // Hight(hight, x, y, forspace, space);
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
      while(forspace < x + 3) {
       Console.Write(" ");
        if(x == 0 && forspace == -1) {
          Console.Write(" ");
        }
       forspace++;
      }
    }
    else if(y >= 10 && y < 100) {
      while(forspace < x + 2) {
       Console.Write(" ");
       forspace++;
      }
    }
    else if(y >= 100 && y < 1000) {
      while(forspace < x + 1) {
       Console.Write(" ");
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
  private static void Hight(int hight, int x, int y, int forspace, int space) {
    while(hight < y - 2) {
      if(y > 10) {
       forSpace(forspace, x, y);
       Console.Write("  .");
       Space(space, x);
       Console.WriteLine(".");
      }
      else {
       forSpace(forspace, x, y);
       Console.Write(" .");
       Space(space, x);
       Console.WriteLine(".");
      }
     hight++;
    }
  }
  
}
