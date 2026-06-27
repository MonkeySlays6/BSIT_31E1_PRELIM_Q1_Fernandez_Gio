# Reflection

## 1. Why did you use inheritance?
- I used inheritance because all of the transport classes are types of Vehicles and they share the same base class.

## 2. Why did you use interfaces?
- I used interfaces because they show what each transport can do, like drive, fly, or sail.

## 3. Can Helicopter inherit from both Vehicle and Airplane? Why or why not?
- No, because C# only allows a class to inherit from one base class.

## 4. Why can Helicopter implement both IFlyable and IDriveable?
- It can implement both interfaces becuase C# allows a class to implement multiple interfaces.

## 5. If a Submarine can both sail and dive, how would you design it?
- I would make the Submarine inherit from Vehicle and implement ISailable and a new IDiveable interface.
