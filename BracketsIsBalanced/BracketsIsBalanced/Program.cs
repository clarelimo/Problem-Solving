using System;
using System.Collections;

namespace BracketsIsBalanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsBalanced("())"));
            Console.WriteLine(IsBalanced("((miriam)(clare))"));
            Console.WriteLine(IsBalanced(")("));
            Console.WriteLine(IsBalanced("(another((test)(is))here)ff "));
        }

        static bool IsBalanced(string word, int count = 0)
        {
            if (word.Length == 0)
            {
                return count == 0;
            }
            else if (count < 0)
            {
                return false;
            }
            else if (word.StartsWith('('))
            {
                return IsBalanced(word.Substring(1), count + 1);
            }
            else if (word.StartsWith(')'))
            {
                return IsBalanced(word.Substring(1), count - 1);
            }
            else
            {
                return IsBalanced(word.Substring(1), count);
            }
        }
       /* Stack st = new Stack();
        foreach(Object c in s.ToCharArray()){
            if(c.Contains("(")){
                st.push(")");}
            else if(c=="{"){
                st.push("}");}
            else if(c=="["){
                st.push("]");}
            else if(st.IsEmpty()|| st.pop!=c){
                return false;
    }*/
}

