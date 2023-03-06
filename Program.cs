
/**
 Install-Package MySql.EntityFrameworkCore -Version 6.0.4
 
 
 
 */


// See https://aka.ms/new-console-template for more information
using Mysql_EF;

var context = new Context();
Console.WriteLine("Hello MySql!");
Console.WriteLine("Creating Database");
context.Database.EnsureCreated();
Console.WriteLine("Database Created");
var model = new Model() { Name = "EF" };
context.Models.Add(model);
context.SaveChanges();
Console.WriteLine( $"Name = {model.Name} Id = {model.Id}");

Console.ReadLine();
