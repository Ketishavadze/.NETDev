// See https://aka.ms/new-console-template for more information


//ნაწილი 1: List (სიები და მანიპულაცია)
//1)დუბლიკატების ძებნა: მოცემულია მთელი რიცხვების სია. იპოვეთ და დააბრუნეთ ყველა ის ელემენტი, რომელიც სიაში ერთზე მეტჯერ გვხვდება.

 /*
 int[] arr = {1,2,3,4,5,6,7,8,3,9,4,3,9,9,9};

 for (int i = 0; i < arr.Length; i++)
 {
  int count = 0;
  for (int j = 0; j < arr.Length; j++)
  {

   if (arr[i] == arr[j])
   {
    count++;
   }
  }

  if (count > 1)
  {
   bool alreadyPrinted = false;
   
   for (int k = 0; k < i; k++)
   {
    if (arr[i] == arr[k])
    {
     alreadyPrinted = true;
     break;
    }
   }

   if (!alreadyPrinted)
   {
    Console.WriteLine(arr[i]);
   }
  }
 }
 */



//2)გააერთიანეთ ორი წინასწარ დახარისხებული სია (Sorted List) ისე, რომ საბოლოო შედეგიც დახარისხებული იყოს.

 /*
 int[] arr1 = {1, 3, 5, 7};
 int[] arr2 = {2, 4, 6, 8};

 int[] result = new int[arr1.Length + arr2.Length];

 int i = 0, j = 0, k = 0;

 while (i < arr1.Length && j < arr2.Length)
 {
  if (arr1[i] < arr2[j])
  {
   result[k++] = arr1[i++];
  }
  else
  {
   result[k++] = arr2[j++];
  }
 }
 while (i < arr1.Length)
 {
  result[k++] = arr1[i++];
 }
 while (j < arr2.Length)
 {
  result[k++] = arr2[j++];
 }

 foreach (int num in result)
 {
  Console.Write(num + " ");
 }
 */


 

//3)დაწერეთ ფუნქცია, რომელიც სიას k პოზიციით გადაწევს მარჯვნივ (მაგალითად: [1,2,3] -> [3,1,2]).

 /*
  List<int> num = new List<int>() { 1, 2, 3 };
 int k = 2;
 k = k % num.Count;

List<int> tail = num.GetRange(num.Count - k, k);
List<int> head  = num.GetRange(0, num.Count-k);
tail.AddRange(head);
foreach (int i in tail)
{
 Console.WriteLine(i + " ");
}
*/


//4)შექმენით ახალი სია, სადაც ყოველი i-ური ელემენტი იქნება საწყისი სიის პირველი i ელემენტის ჯამი.

 /*
 List<int> arr = new List<int> { 1, 2, 3, 4 };
 List<int> result = new List<int>();

 int temp = 0;

 for (int i = 0; i < arr.Count; i++)
 {
  temp += arr[i];
  result.Add(temp);
 }

// print
 foreach (int num in result)
 {
  Console.Write(num + " ");
 }
 */



//5) მინიმალურის ამოშლა: იპოვეთ სიის მინიმალური ელემენტი და ამოშალეთ მისი ყველა ეგზემპლარი სიიდან.
 /*
  int[] arr = { 2, 4, 6, 1, 8, 5, 1 };

 int min = arr[0];

 foreach (int num in arr)
 {
  if (num < min)
   min = num;
 }

 List<int> result = new List<int>();

 foreach (int num in arr)
 {
  if (num != min)
   result.Add(num);
 }
 
 foreach (int num in result)
 {
  Console.Write(num + " ");
 }
 */


//HashSet 
//უნიკალური სიმბოლოები: დაადგინეთ, შედგება თუ არა მოცემული ტექსტი მხოლოდ უნიკალური სიმბოლოებისგან.
//HashSet only stores unique values and fails if you try otherwise 

 /*
  string text = "Ketato";
 HashSet<char> set = new HashSet<char>();
 bool isUnique = true;
 foreach (char c in text)
 {
  if (!set.Add(c))
  {
   isUnique = false;
   break;
  }
 }

 Console.WriteLine(isUnique);
 */
 

//კვეთა (Intersection): ორ სხვადასხვა სიაში იპოვეთ საერთო ელემენტები HashSet-ის გამოყენებით.

 /*
 List<int> set1 = new List<int>() { 1, 2, 3, 4 };
 List<int> set2 = new List<int>(){3,4,5,6};
HashSet<int> set =  new HashSet<int>(set1);
HashSet<int> intersection = new HashSet<int>();

foreach (int i in set2)
{
 if (set.Contains(i))
 {
  intersection.Add(i);
 }
}

foreach (int i in intersection)
{
 Console.WriteLine(i + " ");
}
*/


//პირველი განმეორებადი: იპოვეთ მასივში პირველივე ელემენტი, რომელიც მეორდება.
/*
int[] arr = new int[] { 1, 2, 4, 5, 2, 6, 1 };
HashSet<int> set = new HashSet<int>();
foreach (int i in arr)
{
 if (!set.Add(i))
 {
  Console.WriteLine(i);
  break;
 }
}
*/


//სიმრავლური სხვაობა: მოცემულია ორი სია $A$ და $B$. იპოვეთ ელემენტები, რომლებიც არის $A$-ში, მაგრამ არ არის $B$-ში

/*List<int> A = new List<int>() { 1, 2, 3, 4, 5, 6, 1 };
List<int> B = new List<int>() { 1, 2, 3 };
HashSet<int> set = new HashSet<int>(B);
HashSet<int> diff = new HashSet<int>(A);
foreach (int i in set)
{
 if (diff.Contains(i))
 {
  diff.Remove(i);
 }
}

foreach (int i in diff)
{
 Console.WriteLine(i + " ");
}*/

//.ანაგრამის შემოწმება: გამოიყენეთ სიმბოლოების სიმრავლე, რათა დაადგინოთ, არის თუ არა ორი სიტყვა ერთმანეთის ანაგრამა.

/*string text1 = "dormitory";
string text2 = "dirtyroom";

if (text1.Length != text2.Length)
{
 Console.WriteLine(false);
 return;
}

HashSet<char> set1 = new HashSet<char>(text1);
HashSet<char> set2 = new HashSet<char>(text2);

bool sameChars = set1.SetEquals(set2);

Console.WriteLine(sameChars);*/

//ქვესიმრავლის ძებნა: შეამოწმეთ, არის თუ არა ერთი მასივის ყველა ელემენტი მეორე მასივშიც.

/*
int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] subset = new int[] { 4, 5, 8 };
HashSet<int> hashSet = new HashSet<int>(arr);
bool isSubset = true;

foreach (int i in subset)
{
 if (!hashSet.Contains(i))
 {
  isSubset = false;
  break;
 }
}

Console.WriteLine(isSubset);
*/



//Dictionary
//სიმბოლოების სიხშირე: დათვალეთ სტრიქონში თითოეული სიმბოლოს რაოდენობა და შეინახეთ ლექსიკონში.
 /*
 string text = "ketevaniko";
 Dictionary<char, int> map = new Dictionary<char, int>();

 foreach (var c in text)
 {
  if( map.ContainsKey(c))
    map[c]++;
  else
   map.Add(c, 1);
 }

 foreach (var c in map)
 {
  Console.WriteLine(c.Key + ": " + c.Value);
 }
 */


 //Two Sum პრობლემა: მოცემულია მასივი და რიცხვი $T$. იპოვეთ მასივში ის ორი ინდექსი, რომელთა მნიშვნელობების ჯამი $T$-ს უდრის.
 int[] arr = new int[] { 2, 3, 4, 5, 6, 8, };
 int t = 7;
Dictionary<int , int> dict = new Dictionary<int, int>();
 
for (int i = 0; i < arr.Length; i++)
{
 int complement = t - arr[i];

 if (dict.ContainsKey(complement))
 {
  Console.WriteLine("Indices: " + dict[complement] + " and " + i);
  break;
 }

 dict[arr[i]] = i;
}


//ტელეფონების წიგნაკი: შექმენით სისტემა, რომელიც ინახავს სახელსა და ნომერს. მომხმარებელმა სახელის შეყვანისას უნდა მიიღოს შესაბამისი ნომერი.
/*
Dictionary<string, string> numbers = new Dictionary<string, string>();
numbers.Add("keti", "598003987");
numbers.Add("sxva aravis nomeri vici", "1234567890");
Console.Write("Enter name: ");

string name = Console.ReadLine();

if (numbers.ContainsKey(name))
{
 Console.WriteLine("Number: " + numbers[name]);
}
else
{
 Console.WriteLine("Name not found");
}
*/


//დაჯგუფება სიგრძით: მოცემულია სიტყვების სია. დააჯგუფეთ ისინი სიგრძის მიხედვით: Key - სიგრძე, Value - სიტყვების სია.
 /*
 List<string> words = new List<string>() { "Keti", "nini", "ilia", "ani", "tina", "tornike", "luka", "akaki" };
Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();
foreach (string word in words)
{
 if (!dictionary.ContainsKey(word.Length))
 {
  dictionary[word.Length] = new List<string>();
 }
 dictionary[word.Length].Add(word);
}

foreach (var pair in dictionary)
{
 Console.Write(pair.Key + " : ");

 foreach (string word in pair.Value)
 {
  Console.Write(word + " ");
 }

 Console.WriteLine();
}
*/

//ყველაზე ხშირი ელემენტი: იპოვეთ მასივში ელემენტი, რომელიც ყველაზე მეტჯერ მეორდება (Mode).
/*int[] arr = new int[]{1,2,1,2,3,1,3,1,4,5,2,5,6};

Dictionary<int, int> dict = new Dictionary<int, int>();

foreach (int i in arr)
{
 if (!dict.ContainsKey(i))
 {
  dict.Add(i, 1);
 }
 else 
 {
 dict[i]++;
 }
}

int maxCount = 0;
int mode = 0;

foreach (var pair in dict)
{
 if (pair.Value > maxCount)
 {
  maxCount = pair.Value;
  mode = pair.Key;
 }
}

Console.WriteLine("Mode: " + mode);
Console.WriteLine("Count: " + maxCount);*/