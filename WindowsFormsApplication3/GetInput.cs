using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.Data;
using MSScriptControl;


namespace WindowsFormsApplication3
{
    class GetInput
    {
      
       String[] mark = { "＋", "－", "×", "÷" };
       StringBuilder sbuider = new StringBuilder();
       String last = "";
       public String finalresult = "";
      
       
       public GetInput()
       {
           
       }
        //输入
       public void input(String data)
       {
           if (judgeMark(data))
           {
               if (sbuider.ToString().Length == 0)
               {
                   Console.WriteLine("Do Nothing !");
                   return;
               }
               else
               {
                   if (judgeMark(last))
                   {
                       last = data;
                       sbuider.Remove(sbuider.ToString().Length - 1, 1);
                       sbuider.Append(last);
                       return;
                   }
                   else
                   {
                       last = data;
                       sbuider.Append(data);
                       return;
                   }
               }
           }

           if (last.Length == 0 || sbuider.ToString().Equals("0"))
           {
               if (data.Equals("0"))
               {
                   return;
               }
           }

           if(finalresult.Length>0 && !contain(sbuider.ToString())){
               clear();
               finalresult = "";
               last = data;
               sbuider.Append(data);
               return;
           }

           last = data;
           sbuider.Append(data);
           return;
       }

        //判断字符串是否包含运算符号，从而判断是否为第一次输入数字
       public bool contain(String l)
       {
           foreach (String s in mark)
           {
               if (l.Contains(s))
               {
                   return true;
               }
           }
           return false;
       }

       //判断是否为运算符 是返回true 不是返回false
       public bool judgeMark(String data)
       {
           foreach (String s in mark)
           {
               if (data.Equals(s))
               {
                   return true;
               }
           }
           return false;
       }

       public String getString()
       {
           return sbuider.ToString();
       }
        
        //字符串转运算式，计算得出结果。
       public String calculate()
       {
           String result = getString();
           if(result.Length > 0){
               String lastchar = result.Substring(result.Length - 1, 1);

               if (judgeMark(lastchar))
               {
                   result = result.Substring(0, result.Length - 1);
               }
               MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControlClass();
               sc.Language = "javascript";
               result = result.Replace("×", "*").Replace("÷", "/").Replace("＋", "+").Replace("－", "-");//将字符串中的“运算符”转为真正的运算符。

               //Console.WriteLine(result);

               var a = sc.Eval(result);
               finalresult = a.ToString();

               clear();
               sbuider.Append(finalresult);
               last = finalresult.Substring(finalresult.Length-1,1);

               return a.ToString();
           }

           return "";
       }

       public void clear()
       {
           sbuider.Clear();
           last = "";
       }

       public void deleteOne()
       {
           if (sbuider.ToString().Length == 0)
           {
               last = "";
               return;
           }

           last = sbuider.ToString().Substring(sbuider.ToString().Length - 1, 1);
           sbuider.Remove(sbuider.ToString().Length - 1, 1);
           
       }

    }
}
