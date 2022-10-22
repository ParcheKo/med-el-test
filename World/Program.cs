using Vehicles.Domain.Cars.Builders;
using Vehicles.Domain.Motorcycles.Builders;
using Vehicles.Domain.Tire;

var car = CarFactory.New().FabricatedBy("Toyota").Build();
car.Move();
car.SwitchTiresTo(WinterTires.WithSpec(2.7F, -10, 1));
car.Move();
car.SwitchTiresTo(SummerTires.WithSpec(2.4F, 40));
car.Move();

var motor = MotorcycleFactory.New().MadeBy("Honda").Build();
motor.Move();