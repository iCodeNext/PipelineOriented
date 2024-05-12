using PartOneDemo;
using System.ComponentModel;

//var instance = new For();
//Console.WriteLine(instance.DoSimple());

//Console.WriteLine(instance.DoWithPipeline());



var person = new Person("Mohammad", "Karimi", "mha.karimi@gmail.com");
//var p1 = person.WithName("Alireza");
//var p2 = p1.WithLastName("hassani");
//var p3 = p2.WithEmail("a.hassani@live.com");

//var person = new Person("Mohammad", "Karimi", "mha.karimi@gmail.com");
var p1 = person.WithName("Alireza")
               .WithName("hassani")
               .WithEmail("a.hassani@live.com");


int Add1(int x) => x + 1;
int Square(int x) => x * x;
int Double(int x) => x * 2;
int Min1(int y)=> y - 1;


var result = 5.Pipe(Add1)
              .Pipe(Double)
              .Pipe(Double)
              .Pipe(Square)
              .Pipe(Min1)
              .Pipe(Add1);


//Console.WriteLine(pipelineResult_1);


//var pipelineResult_2 = 5.Pipe(Double)
//                        .Pipe(Square)
//                        .Pipe(Add1)
//                        .Pipe(Add, 15)
//                        .Pipe(Mult, 3);

//Console.WriteLine(pipelineResult_2);


//Console.WriteLine(RomanNumerals.Run(590));





Console.WriteLine();