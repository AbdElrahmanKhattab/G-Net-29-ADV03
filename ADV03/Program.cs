namespace ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager

            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine("Grades:");
            //foreach (var g in grades)
            //    Console.Write(g + " ");

            //Console.WriteLine($"\nCount = {grades.Count}");
            //Console.WriteLine($"First = {grades[0]}");
            //Console.WriteLine($"Last = {grades[grades.Count - 1]}");

            //grades.Sort();

            //Console.WriteLine("\nSorted:");
            //foreach (var g in grades)
            //    Console.Write(g + " ");

            //// First grade > 90
            //foreach (var g in grades)
            //{
            //    if (g > 90)
            //    {
            //        Console.WriteLine($"\nFirst > 90 = {g}");
            //        break;
            //    }
            //}

            //// Failing grades (<75)
            //Console.WriteLine("Failing Grades:");
            //foreach (var g in grades)
            //{
            //    if (g < 75)
            //        Console.WriteLine(g);
            //}

            //// Remove failing
            //for (int i = grades.Count - 1; i >= 0; i--)
            //{
            //    if (grades[i] < 75)
            //        grades.RemoveAt(i);
            //}

            //// Check 100
            //bool has100 = false;
            //foreach (var g in grades)
            //{
            //    if (g == 100)
            //        has100 = true;
            //}

            //Console.WriteLine($"Contains 100: {has100}");

            //// Convert to string list
            //List<string> gradeStrings = new List<string>();
            //foreach (var g in grades)
            //{
            //    gradeStrings.Add($"Grade: {g}");
            //}

            //foreach (var s in gradeStrings)
            //    Console.WriteLine(s);

            #endregion


            #region Exercise 2: Leaderboard

            //SortedList<int, string> leaderboard = new SortedList<int, string>();

            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");

            //Console.WriteLine("\nLeaderboard:");
            //foreach (var item in leaderboard)
            //    Console.WriteLine($"{item.Key} = {item.Value}");

            //Console.WriteLine($"First Key: {leaderboard.Keys[0]}");
            //Console.WriteLine($"First Value: {leaderboard.Values[0]}");

            //Console.WriteLine($"Contains 500: {leaderboard.ContainsKey(500)}");

            //if (leaderboard.TryGetValue(999, out string player))
            //    Console.WriteLine(player);
            //else
            //    Console.WriteLine("Score 999 not found");

            //leaderboard.Remove(200);

            //Console.WriteLine("After Remove:");
            //foreach (var item in leaderboard)
            //    Console.WriteLine($"{item.Key} = {item.Value}");

            #endregion


            #region Exercise 3: Phone Book

            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            //phoneBook.Add("Ahmed", "111");
            //phoneBook.Add("Sara", "222");
            //phoneBook.Add("Ali", "333");
            //phoneBook.Add("Mona", "444");

            //// [] syntax
            //phoneBook["Ahmed"] = "999";

            //// Add duplicate
            //try
            //{
            //    phoneBook.Add("Ahmed", "000");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //// TryAdd
            //bool added = phoneBook.TryAdd("Ahmed", "000");
            //Console.WriteLine($"TryAdd success: {added}");

            //// Search non-existing
            //Console.WriteLine(phoneBook.ContainsKey("Omar"));

            //// Get with fallback
            //string value;
            //if (!phoneBook.TryGetValue("Omar", out value))
            //    value = "Not Found";

            //Console.WriteLine(value);

            //Console.WriteLine("Keys:");
            //foreach (var k in phoneBook.Keys)
            //    Console.Write(k + " ");

            //Console.WriteLine("\nValues:");
            //foreach (var v in phoneBook.Values)
            //    Console.Write(v + " ");

            #endregion

            #region Exercise 4: HashSet

            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            //Console.WriteLine($"\nUnique Emails Count = {emails.Count}");
            //// Explanation: Case-insensitive → duplicates removed

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //HashSet<int> union = new HashSet<int>(setA);
            //union.UnionWith(setB);

            //Console.WriteLine("Union:");
            //foreach (var i in union)
            //    Console.Write(i + " ");

            //HashSet<int> intersect = new HashSet<int>(setA);
            //intersect.IntersectWith(setB);

            //Console.WriteLine("\nIntersect:");
            //foreach (var i in intersect)
            //    Console.Write(i + " ");

            //HashSet<int> except = new HashSet<int>(setA);
            //except.ExceptWith(setB);

            //Console.WriteLine("\nExcept:");
            //foreach (var i in except)
            //    Console.Write(i + " ");

            //Console.WriteLine($"\nIsSubset: {new HashSet<int> { 1, 2 }.IsSubsetOf(setA)}");

            #endregion


            #region Exercise 5: Queue

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Report.pdf");
            queue.Enqueue("Invoice.pdf");
            queue.Enqueue("Letter.docx");
            queue.Enqueue("Resume.pdf");
            queue.Enqueue("Photo.jpg");

            Console.WriteLine("\nQueue:");
            foreach (var q in queue)
                Console.WriteLine(q);

            Console.WriteLine($"Count = {queue.Count}");

            Console.WriteLine($"Next: {queue.Peek()}");

            while (queue.Count > 0)
            {
                Console.WriteLine($"Printing: {queue.Dequeue()}");
            }

            if (!queue.TryDequeue(out string doc))
                Console.WriteLine("Queue is empty");

            #endregion


        }
    }
}
