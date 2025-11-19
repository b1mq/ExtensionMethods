
using ExtMethids.Domain.Entities;

var PublicPeoples = new List<Person>
{
    new Person("Oleg","Vinnik",76),
    new Person("Michail","Krug",15),
    new Person("Oleksii","Magera",51)

};

var A = new Point3D(1, 2, 3);
var B = new Point3D(4, 6, 8);

Console.WriteLine(Point3DExtension.DistanceOfPoints(A,B));


