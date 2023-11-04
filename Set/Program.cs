using Set.Entities;

HashSet<Product> Products = new HashSet<Product>();
HashSet<Point> Points = new HashSet<Point>();

Product product = new Product("TV", 900.0);
Products.Add(product);
Product otherProduct = new Product("TV", 900.0);
Console.WriteLine(Products.Contains(otherProduct));

Point point = new Point(2, 3);
Points.Add(point);
Point otherPoint = new Point(2, 3);
Console.WriteLine(Points.Contains(otherPoint));

//HashSet<int> a = new HashSet<int>(){ 1, 2, 3};
//HashSet<int> b = new HashSet<int> { 3, 4, 5};
//HashSet<int> c = new(a);
//HashSet<int> d = new();

//Console.Write("UnionWith: ");
//a.UnionWith(b);
//Print(a);
//Console.WriteLine();

//Console.Write("ExceptWith: ");
//a.ExceptWith(b);
//Print(a);
//Console.WriteLine();

//Console.Write("IntersetWith: ");
//c.IntersectWith(b);
//Print(c);
//Console.WriteLine();

//var s = new SortedSet<int> { 3, 2, 1};
//Console.Write("SortedSet: ");
//Print(s);

//static void Print<T>(IEnumerable<T> collection)
//{
//    foreach (T obj in collection)
//    {
//        Console.Write(obj + " ");
//    }
//    Console.WriteLine();
//}