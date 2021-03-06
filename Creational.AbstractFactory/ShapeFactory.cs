﻿namespace Creational.AbstractFactory
{
    /// <inheritdoc />
    /// <summary>
    /// Step 4 - Create Factor classes extending AbstractFactory to generate object of
    /// concrete class based on given information
    /// </summary>
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeName)
        {
            if (shapeName.ToUpper() == Rectangle.ShapeName)
            {
                return new Rectangle();
            }
            else if (shapeName.ToUpper() == Square.ShapeName)
            {
                return new Square();
            }

            return null;
        }
    }
}