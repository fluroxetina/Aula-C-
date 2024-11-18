
// using System;

// class GFG {
	

// 	public static void sortStrings(String[] arr, int n)
// 	{
// 		String temp;

// 		for (int j = 0; j < n - 1; j++) {

// 			for (int i = j + 1; i < n; i++) {
// 				if (arr[j].CompareTo(arr[i]) > 0) {

// 					temp = arr[j];
// 					arr[j] = arr[i];
// 					arr[i] = temp;

// 				}
// 			}
// 		}
// 	}


// 	public static void Main(String[] args)
// 	{
// 		String[] arr = { "UiuiDanthe", "Pedro", "Antonho", "João" };
// 		int n = arr.Length;
// 		sortStrings(arr, n);
// 		Console.WriteLine("Nomes ordenados : ");
// 		for (int i = 0; i < n; i++)
// 			Console.WriteLine(arr[i]);
// 	}
// }


