using PartOneDemo;
using System.ComponentModel;

//var instance = new For();
//Console.WriteLine(instance.DoSimple());

//Console.WriteLine(instance.DoWithPipeline());



//var person = new Person("Mohammad", "Karimi", "mha.karimi@gmail.com");
//var p1 = person.WithName("Alireza");
//var p2 = person.WithName("hassani");
//var p3 = person.WithEmail("a.hassani@live.com");

//var person = new Person("Mohammad", "Karimi", "mha.karimi@gmail.com");
//var p1 = person.WithName("Alireza")
//               .WithName("hassani")
//               .WithEmail("a.hassani@live.com");


//int Add1(int x) => x + 1;
//int Square(int x) => x * x;
//int Double(int x) => x * 2;
//int Add(int x, int y) => x + y;
//int Mult(int x, int y) => x * y;

//var result = Add1(Square(Double(5)));

//var pipelineResult = 5.Double()
//                      .Square()
//                      .Add1();


//Console.WriteLine(result);
//Console.WriteLine(pipelineResult);


//var pipelineResult_1 = 5.Pipe(Double)
//                        .Pipe(Square)
//                        .Pipe(Add1);

//Console.WriteLine(pipelineResult_1);


//var pipelineResult_2 = 5.Pipe(Double)
//                        .Pipe(Square)
//                        .Pipe(Add1)
//                        .Pipe(Add, 15)
//                        .Pipe(Mult, 3);

//Console.WriteLine(pipelineResult_2);


//Console.WriteLine(RomanNumerals.Run(590));

 BizzBuzzSimple bizzBuzzSimple = new BizzBuzzSimple();
//bizzBuzzSimple.Do(65);
bizzBuzzSimple.DoWithPipeline(65);



Console.WriteLine();