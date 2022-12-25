using System;
public class program{
    public static void Main(){
        //1
        /*var n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n*n);*/
        //2
       /* var n1=Convert.ToInt32(Console.ReadLine());
        var n2=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine((n1+n2)/2);*/

        //3
       /* int n=Convert.ToInt32(Console.ReadLine());
        int sum =0;
        for(int i=0;i<n;i++){
            int s=Convert.ToInt32(Console.ReadLine());
            sum+=s;
        }
         Console.WriteLine(sum);*/
         //4
         /*var c=Convert.ToDouble(Console.ReadLine());
         double f=1.8*c+32;
         Console.WriteLine(f);*/
      //5
       /* var s=Console.ReadLine();
      string s2= s.ToUpper();
      Console.WriteLine(s2);*/
      //6
     /* int c=0;
      var s=Console.ReadLine();
      for(int i=0;i<s.Length;i++){
        if(s[i]>='A'&&s[i]<='Z'){
        c=c+(s[i]-64);}
        else if(s[i]>='a'&&s[i]<='z'){
            c=c+(s[i]-96);
        }
      }
         Console.WriteLine(c);*/
         //7
         /*var x=Convert.ToInt32(Console.ReadLine());
         var max=Convert.ToInt64(Console.ReadLine());

         for(int i=1;i<x;i++){
            
         var s=Convert.ToInt64(Console.ReadLine());
         if(max<s)
         max=s;
         }
         Console.WriteLine(max);*/
         //8
        /* var x=Convert.ToInt32(Console.ReadLine());
         Int64 even=0;
         for(int i=1;i<x;i++){  
         var s=Convert.ToInt64(Console.ReadLine());
         if(s%2==0)
          even=s;
         }
         
         Console.WriteLine(even);*/
         //9
     /* string s2="";
     var s=Console.ReadLine();
      for(int i=s.Length-1;i>=0;i--){
        s2+=s[i];

    }
    Console.WriteLine(s2);*/
    

   
}}