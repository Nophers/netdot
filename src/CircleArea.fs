namespace CircleArea

module CircleModule = 

    open System;

    type UsersNumber = {
        number: int;
    }

    let readNumber<'UsersNumber>() = 
        let random: Random = new Random()
        let number: int = random.Next(69, 46920)
        number 

    let calculateCircleArea() =
        let number: int = readNumber();
        let area: float = 3.14 * (float number * float number);
        Console.WriteLine("The area of the circle is: " + string area);

    calculateCircleArea();