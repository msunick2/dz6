// #1

// int [] InputNumbers(int m)
// {
//     int [] newArray = new int [m];
//     for(int i = 0; i < m; i++)
//     {
//         Console.WriteLine($"Input {i + 1} digit");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return newArray;
// }


// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// Console.WriteLine("Input number of numbers");
// int non = Convert.ToInt32(Console.ReadLine());

// int[] myArray = InputNumbers(non);

// int PositiveNumbers(int[] arrayOfUser)
// {
//     int count = 0;
//     for(int i = 0; i < arrayOfUser.Length; i++)
//     {
//         if(arrayOfUser[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// ShowArray(myArray);
// Console.WriteLine(PositiveNumbers(myArray));
// требуется вычислить сколько раз встречается некоторое число х в массиве


// #2
// string FindIntersection(int b1, int k1, int b2, int k2)
// {
//     float tan = k2 - k1;
//     if (tan == 0) return ("Lines are parallel, no solution");
//     float x = (b1 - b2) / tan;
//     float y = (k2 * b1 - k1 * b2) / tan;

//     return ($"({Math.Round(x, 2)}, {Math.Round(y, 2)})");
// }

// Console.Write("Please input b1 -> ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input k1 -> ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input b2 -> ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input k2 -> ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// string output = FindIntersection(b1, k1, b2, k2);
// Console.WriteLine($"k1 = {b1}, b1 = {k1}, k2 = {b2}, b2 = {k2} -> {output}");



// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// int SameNumber(int [] array, int foundDigit)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == foundDigit)
//         count++;
        
//     }
//     return count;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input Found digit:");
// int foundDigit = Convert.ToInt32(Console.ReadLine());

// int [] array = CreateRandomArray(size, minValue, maxValue);
// ShowArray(array);
// Console.WriteLine(SameNumber(array, foundDigit));