using System;
public class SortArray
{
    public static void  Sort(int[] arr){
        Array.Sort(arr);
    }
}
public class Program
{
    public static void Main(string[] args){
        int[] array = { 5, 7, 1, 8, 3, 9, 2, 6 };
         SortArray.Sort(array);
        foreach(int number in array){
            Console.Write(number + " ");
        }
    }
}