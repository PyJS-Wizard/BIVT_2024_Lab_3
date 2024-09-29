using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class Program
    {
        
        public double Min(double a, double b) {
            return (a < b) ? a : b;
        }

        public double Max(double a, double b) {
            return (a > b) ? a : b;
        }

        public double SumArray(double[] arr) {
            double result = 0;
            
            foreach (double i in arr) 
                result += i;

            return result;
        }

        public double AvgArray(double[] arr) {
            return SumArray(arr) / arr.Length;
        }

        public (int, double) MinArray(double[] arr) {
            double minElement = double.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < minElement) {
                    minElement = arr[i];
                    minIndex = i;
                }
            }

            return (minIndex, minElement);
        }


        public (int, double) MaxArray(double[] arr) {
            double maxElement = double.MinValue;
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > maxElement) {
                    maxElement = arr[i];
                    maxIndex = i;
                }
            }
    

            return (maxIndex, maxElement);
        }

        public void InsertionSortDesc(double[] arr) {
            for (int i = 0; i < arr.Length - 1; i++) {

                double curMax = arr[i];
                int curMaxIndex = i;

                for (int j = i + 1; j < arr.Length; j++) {

                    if (arr[j] > curMax) {
                        curMax = arr[j];
                        curMaxIndex = j;
                    }
                }


                if (curMaxIndex != i) {
                    double tmp = arr[i];
                    arr[i] = arr[curMaxIndex];
                    arr[curMaxIndex] = tmp;
                }

            }

        }
        public static void Main()
        {
            Program program = new Program();

        }

        #region Level 1
        public double[] Task_1_1(double[] array)
        {
            // code here
            double sumArr = SumArray(array);

            for (int i = 0; i < array.Length; i++) {
                array[i] = Math.Round(array[i] / sumArr, 2);
            }
            // end

            return array;
        }
        public double[] Task_1_2(double[] array)
        {
            // code here
            double positiveSum = 0, positiveAvg;
            int positiveCount = 0;
            
            foreach (double i in array) {
                if (i > 0) {
                    positiveCount++;
                    positiveSum += i;
                }
            }
            
            positiveAvg = Math.Round(positiveSum / positiveCount, 2);

            for (int i = 0; i < array.Length; i++) {
                if (array[i] > 0) 
                    array[i] = positiveAvg;
                
            }
            // end

            return array;
        }
        public (double[], double[]) Task_1_3(double[] first, double[] second)
        {
            double[] sum = new double[first.Length], dif = new double[first.Length];

            // code here

            for (int i = 0; i < first.Length; i++) {
                sum[i] = Math.Round(first[i] + second[i], 2);
                dif[i] = Math.Round(first[i] - second[i], 2);
            }
            // end

            return (sum, dif);
        }
        public double[] Task_1_4(double[] array)
        {
            // code here
            double avgArr = AvgArray(array);

            for (int i = 0; i < array.Length; i++) {
                array[i] = Math.Round(array[i] - avgArr, 2);
            }
            // end

            return array;
        }
        public double Task_1_5(double[] vector1, double[] vector2)
        {
            double product = 0;

            // code here
            for (int i = 0; i < vector1.Length; i++) {
                product += vector1[i] * vector2[i];
            }
            // end

            return Math.Round(product, 2);
        }
        public double Task_1_6(double[] vector)
        {
            double length = 0;

            // code here
            foreach (double i in vector) 
                length += i * i;

            length = Math.Sqrt(length);
            // end

            return Math.Round(length, 2);
        }
        public double[] Task_1_7(double[] array)
        {
            // code here
            double avgArr = AvgArray(array);

            for (int i = 0; i < array.Length; i++) {
                if (array[i] > avgArr)
                    array[i] = 0;
            }
            // end

            return array;
        }
        public int Task_1_8(double[] array)
        {
            int count = 0;

            // code here
            foreach (double i in array) {
                if (i < 0)
                    count++;
            }
            // end

            return count;
        }
        public int Task_1_9(double[] array)
        {
            int count = 0;
            double avgArr = AvgArray(array);
            // code here
            foreach (double i in array) {
                if (i > avgArr)
                    count++;
            }
            // end

            return count;
        }
        public int Task_1_10(double[] array, int P, int Q)
        {
            int count = 0;

            // code here
            foreach (double i in array) {
                if (i > P && i < Q)
                    count++;
            }
            // end

            return count;
        }
        public double[] Task_1_11(double[] array)
        {
            double[] output = null;
            int positiveCount = 0, j = 0;

            // code here
            foreach (double i in array) {
                if (i > 0)
                    positiveCount++;
            }

            output = new double[positiveCount];

            foreach (double i in array) {
                if (i > 0) {
                    output[j] = i;
                    j++;
                }
            }
            // end

            return output;
        }
        public (double, int) Task_1_12(double[] array)
        {
            double value = 0;
            int index = -1;

            // code here
            for (int i = 0; i < array.Length; i++) {
                if (array[i] < 0) {
                    index = i;
                    value = array[i];
                }
            }
            // end

            return (value, index);
        }
        public (double[], double[]) Task_1_13(double[] array)
        {
            double[] even = new double[array.Length / 2];
            double[] odd = new double[array.Length/2];

            // code here
            for (int i = 0; i < array.Length; i++) {
                if (i % 2 == 0)
                    even[i / 2] = array[i];
                else
                    odd[i / 2] = array[i];
            }
            // end

            return (even, odd);
        }
        public double Task_1_14(double[] array)
        {
            double sum = 0;

            // code here
            foreach (double i in array) {
                if (i < 0)
                    break;

                sum += i * i;
            }
            // end

            return sum;
        }
        public double[] Task_1_15(double[] x)
        {
            double[] y = new double[x.Length];

            // code here
            for (int i = 0; i < x.Length; i++) {
                if (x[i] > 0)
                    y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
                else
                    y[i] = double.NaN;
                
            }
            // end

            return y;
        }
        #endregion

        #region Level 2
        public double[] Task_2_1(double[] array)
        {
            // code here
            var (minIndex, minValue) = MinArray(array);

            array[minIndex] *= 2;
            // end

            return array;
        }
        public double Task_2_2(double[] array)
        {
            double sum = 0;

            // code here

            // end

            return sum;
        }
        public double[] Task_2_3(double[] array)
        {
            // code here
            var (minIndex, minValue) = MinArray(array);

            for (int i = 0; i < minIndex; i++) {
                if (array[i] >= 0) 
                    array[i] *= 2;
                else
                    array[i] /= 2;
            }
            // end

            return array;
        }
        public double[] Task_2_4(double[] array)
        {
            // code here

            // end

            return array;
        }
        public double[] Task_2_5(double[] array)
        {
            // code here
            var (minIndex, minValue) = MinArray(array);
            var (maxIndex, maxValue) = MaxArray(array);
            int lowerBound = (int) Min(minIndex, maxIndex), upperBound = (int) Max(minIndex, maxIndex);

            int negativeCount = 0, j = 0;

            for (int i = lowerBound + 1; i < upperBound; i++) {
                if (array[i] < 0)
                    negativeCount++;
            }

            double[] result = new double[negativeCount];

            for (int i = lowerBound + 1; i < upperBound; i++) {
                if (array[i] < 0) {
                    result[j] = array[i];
                    j++;
                }
            }
            // end

            return result;
        }
        public double[] Task_2_6(double[] array, double P)
        {
            // code here

            // end

            return array;
        }
        public double[] Task_2_7(double[] array)
        {
            // code here
            var (maxIndex, maxValue) = MaxArray(array);

            if (maxIndex + 1 < array.Length) {
                if (array[maxIndex + 1] >= 0) 
                    array[maxIndex + 1] *= 2;
                else
                    array[maxIndex + 1] /= 2;
            }
            // end

            return array;
        }
        public double[] Task_2_8(double[] array)
        {
            // code here

            // end

            return array;
        }
        public double Task_2_9(double[] array)
        {
            double average = 0;

            // code here
            var (minIndex, minValue) = MinArray(array);
            var (maxIndex, maxValue) = MaxArray(array);
            int lowerBound = (int) Min(minIndex, maxIndex), upperBound = (int) Max(minIndex, maxIndex);

            int count = upperBound - lowerBound - 1;
            double sum = 0;
            for (int i = lowerBound + 1; i < upperBound; i++) {
                sum += array[i];
            }

            if (count > 0)
                average = sum / count;
            else
                average = 0;
            // end

            return Math.Round(average, 2);
        }
        public double[] Task_2_10(double[] array)
        {
            // code here

            // end

            return array;
        }
        public double[] Task_2_11(double[] array, double P)
        {
            // code here
            int lastPositiveIndex = -1;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > 0)
                    lastPositiveIndex = i;
            }   
            // end

            if (lastPositiveIndex == -1) 
                return array;

            double[] result = new double[array.Length + 1];

            for (int i = 0; i < result.Length; i++) {
                if (i <= lastPositiveIndex)
                    result[i] = array[i];
                else if (i == lastPositiveIndex + 1)
                    result[i] = P;
                else 
                    result[i] = array[i - 1];

            }
            return result;
        }
        public double[] Task_2_12(double[] array)
        {
            // code here

            // end

            return array;
        }
        public double[] Task_2_13(double[] array)
        {
            // code here
            int maxIndex = 0;
            double maxValue = double.MinValue;

            for (int i = 0; i < array.Length; i += 2) {
                if (array[i] > maxValue) {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }
            // end
            
            array[maxIndex] = maxIndex;

            return array;
        }
        public double[] Task_2_14(double[] array)
        {
            // code here

            // end

            return array;
        }
        public double[] Task_2_15(double[] A, double[] B, int k)
        {   
            if (k >= A.Length || k <= 0) 
                return A;

            k -= 1;

            double[] output = new double[A.Length + B.Length];

            for (int i = 0; i < A.Length + B.Length; i++) {
                if (i <= k) 
                    output[i] = A[i];
                else if (i <= k + B.Length)
                    output[i] = B[i - k - 1];
                else
                    output[i] = A[i - B.Length];
            }
            // code here

            // end

            return output;
        }
        public int[] Task_2_16(double[] array)
        {
            int[] output = null;

            // code here

            // end

            return output;
        }
        public double Task_2_17(double[] array)
        {
            double average = 0, sum = 0;
            int count = 0;

            // code here
            var (minIndex, minValue) = MinArray(array);
            var (maxIndex, maxValue) = MaxArray(array);



            foreach (double i in array) {
                if ((maxIndex < minIndex && i > 0) || (minIndex < maxIndex && i < 0)) {
                        sum += i;
                        count++;
                    }
            }

            if (count > 0)
                average = sum / count;
            else
                average = 0;
            // end

            return Math.Round(average, 2);
        }
        public double[] Task_2_18(double[] array)
        {
            // code here

            // end

            return array;
        }
        public double[] Task_2_19(double[] array)
        {
            // code here
            var (maxIndex, maxValue) = MaxArray(array);
            double sumArr = SumArray(array);

            if (maxValue > sumArr)
                array[maxIndex] = 0;
            else
                array[maxIndex] *= 2;
            // end

            return array;
        }
        public double Task_2_20(double[] array)
        {
            double sum = 0;

            // code here

            // end

            return sum;
        }
        #endregion
        #region Level 3
        public int[] Task_3_1(double[] array)
        {
            int[] output = null;

            // code here

            // end

            return output;
        }
        public double[] Task_3_2(double[] array)
        {
            // code here
            var (maxIndex, maxValue) = MaxArray(array);
            int orderNum = 1;

            for (int i = maxIndex; i < array.Length; i++) {
                if (array[i] == maxValue) {
                    array[i] += orderNum;
                    orderNum++;
                }

            }
            // end

            return array;
        }
        public double[] Task_3_3(double[] array)
        {
            // code here
            
            // end

            return array;
        }
        public double[] Task_3_4(double[] array)
        {
            // code here
            var (maxIndex, maxValue) = MaxArray(array);
            double sum = 0, tmp;

            for (int i = 0; i < array.Length; i++) {
                
                tmp = array[i];

                if (array[i] == maxValue)
                    array[i] = sum;


                Console.WriteLine(array[i]);
                sum += tmp;
      

            }
            // end

            return array;
        }
        public double[] Task_3_5(double[] array)
        {
            // code here

            // end

            return array;
        }
        public int Task_3_6(double[] array)
        {
            int count = 1, maxCount = 1;

            // code here
            for (int i = 0; i < array.Length - 1; i++) {
                if (array[i] > array[i + 1]) {
                    count++;
                    maxCount = (int) Max(maxCount, count);
                } else
                    count = 1;
            }
            // end

            return maxCount;
        }
        public double[] Task_3_7(double[] array)
        {
            // code here

            // end

            return array;
        }
        public double[] Task_3_8(double[] array)
        {
            // code here
            int negativeCount = 0, j = 0;
            
            foreach (double i in array) {
                if (i < 0)
                    negativeCount++;
            }

            double[] negativeNums = new double[negativeCount];
            foreach (double i in array) {
                if (i < 0) {
                    negativeNums[j] = i;
                    j++;
                }
            }

            InsertionSortDesc(negativeNums);

            foreach (double i in negativeNums) {
                Console.WriteLine(i);
            }
            
            j = 0;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] < 0) {
                    array[i] = negativeNums[j];
                    j++;
                }
            }
            // end

            return array;
        }
        public int Task_3_9(double[] array)
        {
            int count = 0;

            // code here

            // end

            return count;
        }
        public double[] Task_3_10(double[] array)
        {
            // code here
            double[] leftHalf = new double[array.Length / 2];

            for (int i = 0; i < array.Length / 2; i++) {
                leftHalf[i] = array[i];
            }

            for (int i = 0; i < array.Length; i += 2) {
                array[i] = leftHalf[i / 2];
                array[i + 1] = leftHalf[i / 2];
            }

            // end

            return array;
        }
        public (double[], double[], double, double) Task_3_11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double globalMax = 0, globalMin = 0;

            // code here

            // end

            return (X, Y, globalMax,globalMin);
        }
        public double[] Task_3_12(double[] array)
        {
            // code here
            int nonNegativeCount = 0;

            foreach (double i in array) {
                if (i >= 0)
                    nonNegativeCount++;
            }

            
            double[] nonNegativeArr = new double[nonNegativeCount];


            int j = 0;

            foreach (double i in array) {
                if (i >= 0) {
                    Console.WriteLine(j + " " + i);
                    nonNegativeArr[j] = i;
                    j++;
                }
            }
            // end


            return nonNegativeArr;
        }
        public double[] Task_3_13(double[] array)
        {
            // code here

            // end

            return array;
        }
        public double[] Task_3_14(double[] array)
        {

            var (minIndex, minValue) = MinArray(array);
            var (maxIndex, maxValue) = MaxArray(array);

            // code here: TODO
            for (int i = 0; i < array.Length; i++) {
                array[i] = Math.Round(2 * (array[i] - minValue) / (maxValue - minValue) - 1, 2);
            }
            // end

            return array;
        }
        #endregion
}
