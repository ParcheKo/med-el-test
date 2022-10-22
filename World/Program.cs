using Vehicles.Domain.Cars;
using Vehicles.Domain.Cars.Builders;
using Vehicles.Domain.Motorcycles.Builders;
using Vehicles.Domain.Tire;

var car = CarFactory.New().FabricatedBy(Brands.Toyota).Build();
car.Move();
car.SwitchTiresFor(WinterTires.WithSpec(2.7F, -10, 1));
car.Move();
car.SwitchTiresFor(SummerTires.WithSpec(2.4F, 40));
car.Move();

var motorcycle = MotorcycleFactory.New().FabricatedBy(Brands.Honda).Build();
motorcycle.Move();