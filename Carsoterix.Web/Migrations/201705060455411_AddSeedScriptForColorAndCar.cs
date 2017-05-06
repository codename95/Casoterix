namespace Carsoterix.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeedScriptForColorAndCar : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Colors (ColorId, ColorName) VALUES(1, 'Green')");
            Sql("INSERT INTO Colors (ColorId, ColorName) VALUES(2, 'Black')");
            Sql("INSERT INTO Colors (ColorId, ColorName) VALUES(3, 'White')");
            Sql("INSERT INTO Colors (ColorId, ColorName) VALUES(4, 'Red')");
            Sql("INSERT INTO Colors (ColorId, ColorName) VALUES(5, 'Blue')");
            Sql("INSERT INTO Colors (ColorId, ColorName) VALUES(6, 'Furshia')");
            Sql("INSERT INTO Colors (ColorId, ColorName) VALUES(7, 'Silver')");


            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(1, 'Toyota Camry Sport')");
            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(2, 'Lambourghini')");
            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(3, 'Bently')");
            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(4, 'Cardilac')");
            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(5, 'Range Rover')");
            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(6, 'Lexus')");
            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(7, 'Masserati')");
            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(8, 'BMW')");
            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(9, 'Audi')");
            Sql("INSERT INTO CarTypes (CarTypeId, CarTypeName) VALUES(10, 'Mercedes Benz')");
        }
        
        public override void Down()
        {
        }
    }
}
