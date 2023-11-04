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
