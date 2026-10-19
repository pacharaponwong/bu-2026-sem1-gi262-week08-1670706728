using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        #region Lecture

        public int LCT01_RecursiveFactorial(int n)
        {
            return Factorial(n);
        }

        private int Factorial(int n)
        {
            // base case
            if (n <= 1)
                return 1;
            // recursive case

            return n * Factorial(n - 1);
        }

        public int LCT02_RecursiveFibonacci(int n)
        {
            return Fibonacci(n);
        }

        private int Fibonacci(int n)
        {
            // base case
            if (n <= 1)
                return n;

            // recursive case

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public int LCT03_RecursiveSumOfOneToN(int n)
        {
            return SumOfOneToN(n);
        }

        private int SumOfOneToN(int n)
        {
            // base case
            if (n <= 0)
            {
                return 0;
            }

            // recursive case
            return n + SumOfOneToN(n - 1);
        }


        public int LCT04_RecursiveSumOfNumbers(int[] numbers)
        {
            return SumOfNumbers(numbers, 0);
        }

        private int SumOfNumbers(int[] numbers, int index)
        {
            /// base case
            if (index >= numbers.Length)
            {
                return 0;
            }

            // recursive case
            return numbers[index] + SumOfNumbers(numbers, index + 1);
        }

        #endregion

        #region Assignment


        public int ASN01_RecursivePower(int baseNum, int exponent)
        {
            return Power(baseNum, exponent);
        }

        private int Power(int baseNum, int exponent)
        {
            // Base Case: ถ้า exponent == 0 ให้ return 1 (เพราะอะไรยกกำลัง 0 ก็ได้ 1)
            if (exponent == 0)
            {
                return 1;
            }

            // Recursive Case: นำตัวฐานไปคูณกับ ฟังก์ชันเดิมที่ลดค่า exponent ลง 1
            return baseNum * Power(baseNum, exponent - 1);
        }

        public bool ASN02_IsPalindrome(string str)
        {
            return IsPalindrome(str, 0, str.Length - 1);
        }

        private bool IsPalindrome(string str, int start, int end)
        {
            // Base Case 1: ตรวจสอบครบทุกตัวแล้ว (start วิ่งมาชนหรือเลย end) ให้ return true
            if (start >= end)
            {
                return true;
            }

            // Base Case 2: ถ้าตัวอักษรหน้าและหลังสุดไม่ตรงกัน แสดงว่าไม่ใช่ Palindrome ให้ return false
            if (str[start] != str[end])
            {
                return false;
            }

            // Recursive Case: ขยับ start เข้าไปทางขวา 1 และขยับ end เข้ามาทางซ้าย 1 เพื่อเช็คคู่ถัดไป
            return IsPalindrome(str, start + 1, end - 1);
        }

        public int ASN03_RecursiveGCD(int a, int b)
        {
            return GCD(a, b);
        }

        private int GCD(int a, int b)
        {
            // Base Case: ถ้า b == 0 ให้ return a
            if (b == 0)
            {
                return a;
            }

            // Recursive Case: ตามหลัก Euclidean Algorithm สลับตำแหน่งโดยส่ง b ไปเป็น a และส่งเศษของการหาร a % b ไปเป็น b
            return GCD(b, a % b);
        }

        public int ASN04_RecursiveBinarySearch(int[] arr, int target)
        {
            return BinarySearch(arr, target, 0, arr.Length - 1);
        }

        private int BinarySearch(int[] arr, int target, int low, int high)
        {
            // Base Case: ถ้า low มากกว่า high แสดงว่าหาในทุกช่วงแล้วไม่พบ ให้ return -1
            if (low > high)
            {
                return -1;
            }

            // คำนวณหาจุดกึ่งกลาง (ป้องกันปัญหา Integer Overflow ด้วยสูตรนี้)
            int mid = low + (high - low) / 2;

            // ตรวจสอบกับค่าตรงกลาง
            if (arr[mid] == target)
            {
                return mid; // เจอแล้ว return index
            }

            if (arr[mid] > target)
            {
                // ถ้าค่าตรงกลางมากกว่า target แปลว่า target อยู่ครึ่งซ้าย ให้หาฝั่งซ้ายโดยปรับ high เป็น mid - 1
                return BinarySearch(arr, target, low, mid - 1);
            }
            else
            {
                // ถ้าค่าตรงกลางน้อยกว่า target แปลว่า target อยู่ครึ่งขวา ให้หาฝั่งขวาโดยปรับ low เป็น mid + 1
                return BinarySearch(arr, target, mid + 1, high);
            }
        }
    }
}
        
    
    
        #endregion