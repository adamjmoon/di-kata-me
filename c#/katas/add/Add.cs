using System;

namespace Kata.Katas.Add
{
    public class Add
    {
        public int Invoke(string [] args){
           int sum=0;
           foreach(var arg in args){
             sum = sum + Int32.Parse(arg);
           } 
           return sum;    
        }
        
    }
}