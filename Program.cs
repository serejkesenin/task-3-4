using System;
using task_3_4;
class Program
{
 static void Main()
 {
    var getItem = new GetItem(false);
    var mass = new Massive<int>[3];
     mass[0] = new Odnomerniy<int>(2,getItem.GetNewIntItem );
     mass[1] = new Dvumerniy<int>(3,3,getItem.GetNewIntItem);
     mass[2] = new Stupenchatiy<int>(3, getItem.GetNewIntItem);
     var mass1 = new Massive<string?>[3];
     mass1[0] = new Odnomerniy<string?>(2,getItem.GetNewStringItem );
     mass1[1] = new Dvumerniy<string?>(3,3,getItem.GetNewStringItem);
     mass1[2] = new Stupenchatiy<string?>(3, getItem.GetNewStringItem);
    
   var mass2 = new Massive<bool>[3];
     mass2[0] = new Odnomerniy<bool>(2,getItem.GetNewBoolItem );
     mass2[1] = new Dvumerniy<bool>(3,3,getItem.GetNewBoolItem);
     mass2[2] = new Stupenchatiy<bool>(3, getItem.GetNewBoolItem);
    
    
     Weeks_Day masss = new Weeks_Day();
  ///   masss.PrintMass();

    IPrint[] prints = new IPrint [] {mass[0],mass[1],mass[2],mass1[0],mass1[1],mass1[2],mass2[0],mass2[1],mass2[2],masss};
    foreach(var printer in prints){
        printer.PrintMass();
        Console.WriteLine(" ");
    }

 }
}
