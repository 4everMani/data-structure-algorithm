


using System;
using Array;
using LinkedList;

// reverse an array
//var input = new int[] { 10, 20, 30 ,40, 50, 60, 70 };
//var output = ArrayReverse.Reverse(input);
//PrintArray.Print(output);

// Extreme print
// input => [1, 2, 3, 4, 5, 6] 
// output => [1, 6, 2, 5, 3, 4]
//var input = new int[] { 1, 2, 3, 4, 5, 6,7 };
//ExtremePrint.Print(input);

// Print unique element
// input => [1,3,5,7,11,1,5,7,3]
// output => 11
//var input = new int[] { 1, 3, 5, 7, 11, 1, 5, 7, 3 };
//UniqueElement.Print(input);

// Sort zero and one arr
// input => {1, 0, 0, 1, 0, 1, 1, 1, 0}
// output => {0, 0, 0, 0, 1, 1, 1, 1, 1}
//var input = new int[] { 1, 0, 0, 1, 0, 1, 1, 1, 0 };
//var output = SortZeroAndOne.Sort(input);
//PrintArray.Print(output);

// Print transpose of a matrix
// input => {
//           { 1 2 3 4 }
//           { 5 6 7 8 }
//           { 9 10 11 12 }
//           { 13 14 15 16 }
//          }
//
// output => {
//           { 1 5 9  13 }
//           { 2 6 10 14 }
//           { 3 7 11 15 }
//           { 4 8 112 16 }
//          }
//var input = new int[4, 4] {
//           { 1, 2, 3, 4 },
//           { 5, 6, 7, 8 },
//           { 9, 10, 11, 12 },
//           { 13, 14, 15, 16 }};
//MatrixTranspose.Print(input);


// moveing negative elements to left of array
// input => {23, -7, 12, -10, 11, 40, 60}
//MoveNegativeToLeft.Move([23, -7, 12, -10, -11, 40, 60]);

//SortColor.Solution([2, 0, 2, 1, 1, 0]);
//SortColor.Solution([2, 0, 1]);

RotateArray.Solution([1, 2, 3, 4, 5, 6, 7], 3);
// RotateArray.Solution([-1,-100,3,99], 2);

//var output = RearrangeArray.Solution([3, 1, -2, -5, 2, -4]);
//PrintArray.Print(output);

//var output = RowAndMaximumOnes.Solution([[0, 0], [1, 1], [0, 0]]);
//PrintArray.Print(output);

//RotateImage.Solution([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);

//TwoSum.Solution([2, 7, 11, 15], 9);

//PivotIndex.Solution([1, 7, 3, 6, 5, 6]);
//PivotIndex.Solution([1, 2, 3]);
//PivotIndex.Solution([2, 1, -1]);

//FindDuplicate.Solution([1, 3, 4, 2, 2]);

//FindMissing2.Solution([1, 3, 5, 3, 4]);

//FirstRepeatingElement.Solution([1, 3, 8, 7, 4, 2, 7, 7, 9, 3, 1, 9, 8, 6, 5, 0, 2, 8, 6, 0, 2, 4], 22);

//CommonElement.Solution([1, 5, 10, 20, 40, 80], [6, 7, 20, 80, 100], [3, 4, 15, 20, 30, 70, 80, 120], 6, 5, 8);
//CommonElement.Solution([3, 3, 3], [3, 3, 3], [3, 3, 3], 3, 3, 3);

//WavePrint.Solution([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]]);

//SpiralPrint2DMatrix.Solution([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13,14,15,16]]);

//AddTwoNumberRepresentedByArray.Solution([1, 2, 3, 4], [5, 6, 7, 8]);
//AddTwoNumberRepresentedByArray.Solution([9, 9, 9, 9], [2, 2]);
//AddTwoNumberRepresentedByArray.Solution([9, 9, 9, 9], [1, 1, 1, 1]);
//AddTwoNumberRepresentedByArray.Solution([0, 9, 0, 0, 3, 5], [2, 2, 7]);

//FactorailOfLargeNumber.Solution(7);

//RemoveDuplicatesFromSortedArray.Solution([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
//RemoveDuplicatesFromSortedArray.Solution([1, 1, 2]);

//MaximumAverageSubarray_I.Solution([1, 12, -5, -6, 50, 3], 4);
//MaximumAverageSubarray_I.Solution([-1], 1);
//MaximumAverageSubarray_I.Solution([0, 4, 0, 3, 2], 1);

//BinarySearch.PrintIndex([1, 3, 5, 7, 9, 76, 88, 99], 8, 9);

//FirstOccuranceInSortedArray.Solution([1, 3, 5, 7, 7, 9,11, 69, 69, 76, 88, 99], 69);
//FirstOccuranceInSortedArray.Solution([1, 3, 5, 7, 7, 9, 11, 69, 69, 76, 88, 99], 67);


//LastOccuranceInSortedArray.Solution([1, 3, 5, 7, 7, 9, 11, 69, 69, 76, 88, 99], 69);

//CountOfOccuranceInSortedArray.Solution([1, 3, 5, 7, 7, 9, 11, 61, 61, 61, 69, 69, 76, 88, 99], 61);

//FindMissingElementInSortedArray.Solution([1, 2, 3, 4, 6, 7, 8, 9]);
//FindMissingElementInSortedArray.Solution([1, 2, 3, 4, 5, 6, 7, 8, 9]);
//FindMissingElementInSortedArray.Solution([1, 2, 3, 4, 5, 6, 7, 8, 9, 10,12]);
//FindMissingElementInSortedArray.Solution([ 2, 4, 5, 6, 7, 8, 9]);
//FindMissingElementInSortedArray.Solution([1, 2, 3, 4, 5, 6, 8, 9]);

//PeakElementInMountainArray.Solution([2, 5, 3]);

//FindPivotElement.Solution([9, 10, 2, 4, 6, 8]);
//FindPivotElement.Solution([9, 10, 11, 12, 13, 8]);
//FindPivotElement.Solution([9, 10, 12, 14, 16, 18]);
//FindPivotElement.Solution([4, 5, 6, 7, 0, 1, 2]);

//SearchInRotatedArray.Solution([9, 10, 11, 12, 13, 8], 8);
//SearchInRotatedArray.Solution([4, 5, 6, 7, 0, 1, 2], 0);

//SquareRoot.Solution(2147395599);
//SquareRoot.Solution(100);

//BinarySearchIn2DMatrix.Solution([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]], 13);
//BinarySearchIn2DMatrix.Solution([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16], [17, 18, 19, 20]], 20);
//BinarySearchIn2DMatrix.Solution([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16], [17, 18, 19, 20]], 15);

//DevideTwoNumber.Solution(-29, 7);
//DevideTwoNumber.Solution(35, 7);
//DevideTwoNumber.Solution(24, 1);
//DevideTwoNumber.Solution(-84, 19);

//FinedIndexInAlmostSortedArray.Solution([10, 3, 40, 20, 50, 80, 70], 40);
//FinedIndexInAlmostSortedArray.Solution([10, 3, 40, 20, 50, 80, 70], 90);
//FinedIndexInAlmostSortedArray.Solution([10, 3, 40, 20, 50, 80, 70], 3);
//FinedIndexInAlmostSortedArray.Solution([10], 100);

//OddOccurance.Solution([10, 10, 20, 20, 15, 15, 3, 44, 44]);
////OddOccurance.Solution([10, 10, 20, 20, 15, 15, 3, 44, 44]);
//OddOccurance.Solution([1, 1, 5, 5, 2, 2, 3, 3, 2, 4, 4]);

//BubbleSort.Sort([5, 4, 3, 2, 1]);
//BubbleSort.Sort([5, 2, 3, 4, 1]);
//BubbleSort.Sort([5, 4, 3, 2, 1, 10, 9, 8, 7, 6]);

//SelectionSort.Sort([5, 4, 3, 2, 1]);
//SelectionSort.Sort([5, 4, 3, 2, 1, -1, 44, 23, 67,99,8]);

//InsertionSort.Sort([5, 4, 3, 2, 1]);
//InsertionSort.Sort([5, 4, 3, 2, 1, -1, 44, 23, 67, 99, 8]);

//SortListByFirstIndex.Solution();

//FindPairs.Solution([1, 2, 3, 4, 5], 1);
//FindPairs.Solution([3, 1, 4, 1, 5], 2);
//FindPairs.Solution([1, 3, 1, 5, 4], 0);

//FindKClosestElement.Solution([1, 2, 3, 4, 5], 4, 3);
//FindKClosestElement.Solution([1, 2, 3, 4, 5], 4, -1);
//FindKClosestElement.Solution([12, 16, 22, 30, 35, 39, 42, 45, 48, 50, 53, 55, 56], 4, 54);
//FindKClosestElement.Solution([-2, -1, 1, 2, 3, 4, 5], 7, 3);
//FindKClosestElement.Solution([1, 5, 10], 1, 4);

//ExponentialSearch.Search([12, 16, 22, 30, 35, 39, 42, 45, 48, 50, 53, 55, 56], 30);

//-------------- very importent questions of binary search

//AllocateMinimumNumberOfPages.Solution(4, [12, 34, 67, 90], 3);
//AllocateMinimumNumberOfPages.Solution(3, [15, 17, 20], 2);
//AllocateMinimumNumberOfPages.Solution(7, [15, 10, 19, 10, 5, 18, 7], 5);

//ThePainter_sPartitionProblem_II.Solution([10, 20, 30, 40], 4, 2);

//AggressiveCows.Solution([1, 2, 4, 8, 9], 5, 3);

//SearchIn2DMatrix.Solution([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3);

//FindFirstAndLastOccuranceInSortedArray.Solution([5, 7, 7, 8, 8, 10], 8);

//FindPeakElement.Solution([3, 4, 3, 2, 1]);

//MinimumSpeedToArriveOnTime.Solution([1, 1, 100000], 2.01);
//MinimumSpeedToArriveOnTime.Solution([69], 4.6);

//FindKthPositiveMissingElement.Solution([2, 3, 4, 7, 11], 5);
//FindKthPositiveMissingElement.Solution([2], 1);

//FindMinimumInRotatedSortedArrayII.Solution([2, 2, 2, 0, 1]);
//FindMinimumInRotatedSortedArrayII.Solution([1, 3]);

//KokoEatingBananas.Solution([30, 11, 23, 4, 20], 5);

//FindInMountainArray.Solution(3, new MountainArray([1, 2, 3, 4, 5, 3, 1]));

//EkoSPOJ.Solution([20, 10, 15, 17], 7);
//EkoSPOJ.Solution([4, 42, 40, 26, 46], 20);








// --------------------------- LinkedList-------------------------------------
//ConvertArrayToLL.Convert2LL([9, 7, 1, 5, 8]);

// LinkedList Traversing, Length
//var ll = new LinkedList<int>();
//ll.Head = ConvertArrayToLL.Convert2LL([9, 7, 1, 5, 8]);
//ll.Traverse();
//ll.Length();
//ll.CheckElementPresent(7);
//ll.CheckElementPresent(6);
//ll.RemoveHead();
//ll.RemoveTail();
//ll.RemoveElementAt(6);
//ll.RemoveElement(1);
//ll.InsertHead(2);
//ll.InsertHead(4);
//ll.InsertTail(2);
//ll.InsertTail(4);
//ll.InsertAt(1, 1);
//ll.InsertAt(2, 99);
//ll.InsertBeforeValue(5, 88);
//ll.Traverse();

// Doubly LinkedList
//var dll = new DoublyLinkedList<int>();
//dll.Convert2DLL([2, 4, 5, 6, 7]);
//dll.DeleteHead();
//dll.DeleteTail();
//dll.DeleteAt(5);
//dll.DeleteByValue(5);
//dll.InsertBeforeHead(22);
//dll.InsertBeforeTail(12);
//dll.InsertBeforeKthElement(6, 3);
//dll.InsertBeforeGivenElement(2, 10);
//dll.Traverse();

//ReverseDLL.Solution([4, 2, 3, 1, 7]);

//Add2NumbersInLinkedList.Solution([3, 8, 7], [5, 2, 4, 1]);
//Add2NumbersInLinkedList.Solution([3, 5], [4, 5, 9, 9]);


//GroupOddAndEven.Solution([1, 3, 4, 2, 5, 6]);

//LLSortingI.Solution([0, 1, 1, 2, 2, 2, 0, 0, 1]);
//LLSortingI.Solution([1, 2, 0, 0, 2, 2, 1, 0, 1]);

//RemoveNthElementFromEnd.Solution([1, 2, 3, 4, 5], 1);
//RemoveNthElementFromEnd.Solution([1, 2, 3, 4, 5], 2);
//RemoveNthElementFromEnd.Solution([1, 2, 3, 4, 5], 3);
//RemoveNthElementFromEnd.Solution([1, 2, 3, 4, 5], 4);
//RemoveNthElementFromEnd.Solution([1, 2, 3, 4, 5], 5);

//ReverseLL.Solution([1, 2, 3, 4, 5]);

//CheckPalindromeLL.Solution([1, 2, 3, 2, 1]);
//CheckPalindromeLL.Solution([1, 2, 3,3, 2, 1]);
//CheckPalindromeLL.Solution([1, 2, 3, 2, 3]);

//Add1ToLL.Solution([1, 5, 9]);
//Add1ToLL.Solution([9, 9, 9]);

//FindIntersectionPointInYLL.Solution();

//FindMiddleElementInALL.Solution([1, 2, 3, 4, 5]);
//FindMiddleElementInALL.Solution([1, 2, 3, 4, 5, 6]);

//DetectCycleInLL.Solution();

//FindLengthOfLoopInLL.Solution();

//DeleteMiddleNode.Solution([1, 2, 3, 4, 5]);
//DeleteMiddleNode.Solution([1, 2, 3, 4]);

//StartingPointInLoopInLL.Solution();

//DeleteAllOccurancesOfElementInDLL.Solution([10, 4, 10, 10, 6, 10], 10);

//FindAllPairsHavingGivenSumInSortedDLL.Solution([1, 2, 3, 4, 9], 5);

DeleteDuplicatesInSortedDLL.Solution([1, 1, 1, 2, 3, 3, 4,4,4]);


