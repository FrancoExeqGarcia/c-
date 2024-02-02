// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
var cervezas = new List<Cerveza>()
{
    new(){ Name = "Pikantus", Brand = "Erdinger", Alcohol = 7.5m},
    new(){ Name = "Corona", Brand = "Modelo", Alcohol = 4.5m},
    new(){ Name = "Red", Brand = "Delirium", Alcohol = 8m},
    new(){ Name = "Stout", Brand = "Minerva", Alcohol = 6m},
    new(){ Name = "IPA", Brand = "Minerva", Alcohol = 7m},

};

var brands = new List<Brand>()
{
    new(){ Name = "Erdinger", Country = "Alemania"},
    new(){ Name = "Modelo", Country = "Mexico"},
    new(){ Name = "Minerva", Country = "Mexico"},
    new(){ Name = "Delirium", Country = "Belgica"}

};
//select
var nombres = from c in cervezas
              select new { c.Name, c.Brand };
//where
var nombres2 = from b in cervezas
               where b.Brand == "Minerva" || b.Alcohol > 7m
               select new { b.Name};

var nombres3 = cervezas.Where(b => b.Brand == "Minerva" || b.Alcohol >= 7).Select(b => new{b.Name,b.Brand});

var nombres5 = from b in cervezas
                where b.Brand == "Minerva" || b.Alcohol > 7m
                orderby b.Name
                select new { b.Name, b.Brand };

//GROUP  BY
var cervezas6 = from b in cervezas
                group b by b.Brand into grupoDeCervezas
                select new
                {
                    Brand = grupoDeCervezas.Key,
                    Count = grupoDeCervezas.Count()
                };

//JOIN

var cervezas7 = from b in cervezas
                join bra in brands on b.Brand equals bra.Name
                select new
                {
                    Brand = b.Brand,
                    Name = b.Name,
                    Country = bra.Country 
                };


foreach (var b in cervezas7)
{
    Console.WriteLine(b.Name + " " + b.Brand + " " + b.Country);
}

foreach (var nombre in nombres5)
{
    Console.WriteLine(nombre);
}


public class Cerveza
{
    public string? Name { get; set; }
    public string? Brand { get; set; }
    public decimal Alcohol { get; set; }

}

public class Brand
{
    public string? Name { get; set; }
    public string Country { get; set; }

}

