using Vehicles.Domain;
using Vehicles.Domain.Cars.Builders;
using Vehicles.Domain.Motorcycles.Builders;
using Vehicles.Domain.Tire;

// Car example scenario
var car = CarFactory.New().FabricatedBy(Brands.Toyota).Build();
car.Move();
car.SwitchTiresFor(WinterTires.WithSpec(2.7F, -10, 1));
car.Move();
car.SwitchTiresFor(SummerTires.WithSpec(2.4F, 40));
car.Move();

// Motorcycle example scenario
var motorcycle = MotorcycleFactory.New().FabricatedBy(Brands.Honda).Build();
motorcycle.Move();