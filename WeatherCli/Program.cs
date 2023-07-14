// See https://aka.ms/new-console-template for more information


using Weather.Data.Proof;

ProofOfConcept Proof = new ProofOfConcept();
var result = Proof.GetTemp();
result.Wait();

var res = result.Result;
Console.WriteLine(res);
Console.WriteLine("Hello, World!");